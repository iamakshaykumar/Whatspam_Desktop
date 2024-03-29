﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using seleniumKeys = OpenQA.Selenium.Keys;
using System.Diagnostics;
using System.Threading;

namespace Whatspam
{
    public partial class Whatspam : Form
    {
        //Monitoring variable
        bool browserOpen = false;
        //Declaring chromedriver setup variables
        IWebDriver driver;
        ChromeDriverService driverService;

        bool spammingProcess = false;

        //Bool that checks if it's actually spamming
        bool spamming = false;
        //Variable storing spam numbers
        int spamNum;
        //Default english texts
        string insertNameText = "Write the target name";
        string insertMessageText = "Write the message";
        string targetNotFoundText = "Target not found";
  
        public Whatspam()
        {
            InitializeComponent();
            RoundCorners(nameInput);
            RoundCorners(messageInput);
            RoundCorners(spamInput);
        }

        #region SPAMMING
        //When the confirm button gets clicked
        private void confirmButton_MouseUp(object sender, MouseEventArgs e)
        {
            //Checks if there's not an ongoing spamming process
            if (!spammingProcess)
            {
                confirmButton.BackgroundImage = Properties.Resources.Bottone_acceso_normale_;
                confirmButton.Refresh();
                //Stores the content of spam numbers form
                spamNum = int.Parse(spamInput.Text);
                //Resets progress bar value
                progressBar.Value = 0;
                //Sets a maximum for the progress bar
                progressBar.Maximum = spamNum;
                spammingProcess = true;
                //Starts the spamming process in a new thread
                Thread spammingThread = new Thread(new ThreadStart(BeginSpamming));
                spammingThread.Priority = ThreadPriority.Highest;
                spammingThread.Start();
            }
            else if (spamming)
            {
                if (messageInput.Text != "" && nameInput.Text != "")
                {
                    confirmButton.BackgroundImage = Properties.Resources.Bottone_acceso_normale_;
                }
                else
                {
                    confirmButton.BackgroundImage = Properties.Resources.Bottone_spento_normale;
                    confirmButton.Enabled = false;
                }
                confirmButton.Refresh();
                progressBar.Value = 0; 
                spamming = false;
            }
        }
        //Changing state when button is pressed
        private void confirmButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (!spamming)
            {
                confirmButton.BackgroundImage = Properties.Resources.Bottone_acceso_premuto;
                confirmButton.Refresh();
            }
            else
            {
                confirmButton.BackgroundImage = Properties.Resources.Bottone_spento_premuto;
                confirmButton.Refresh();
            }
            
        }
        private void BeginSpamming()
        {
            IWebElement contact;
            IWebElement searchBar;
            //Saving the target name from user input
            string targetName = nameInput.Text;
            Stopwatch restTime;

            if (!browserOpen)
            {
                //Tries to open Google Chrome with chromedriver
                if (OpenChrome())
                {
                    driver.Url = "https://web.whatsapp.com/";
                }                  
                //Tries to open Firefox with Firefox driver
                else if (OpenFirefox())
                {
                    driver.Url = "https://web.whatsapp.com/";
                }
                //Exits if a browser couldn't be opened
                else
                {
                    return;
                }       
            }

            //Setting up a timer to give the user a limited amount of time to log in whatsapp
            restTime = new Stopwatch();
            restTime.Start();
            //Waits until the user is logged in, or the time finishes
            while (true)
            {
                try
                {
                    driver.FindElement(By.XPath($"//div[@class='_3LX7r']"));
                    break;
                }
                catch (NoSuchElementException)
                {
                    if (restTime.Elapsed.Seconds > 60)
                    {
                        //Closes the browser
                        driver.Quit();
                        browserOpen = false;
                        restTime.Stop();
                        return;
                    }
                }
            }

            restTime.Stop();


            //Gets the search bar
            searchBar = driver.FindElement(By.XPath("//div[@class='_2_1wd copyable-text selectable-text' and @data-tab='3']"));

            try
            {
                //Retrieves the target from recent chats and starts the spamming process

                try
                {
                    contact = driver.FindElement(By.XPath($"//span[@class='_35k-1 _1adfa _3-8er' and @title='{targetName}']"));
                }
                catch
                {
                    contact = driver.FindElement(By.XPath($"//span[@class='_35k-1 _1adfa _3-8er' and contains(@title, '{targetName}')]"));
                }
               
                SpamTarget(contact, spamNum);
            }
            catch (NoSuchElementException)
            {
                //Searches for the target in the Whatsapp search bar and then starts the spamming process
                searchBar.Clear();
                searchBar.SendKeys(targetName);

                try
                {
                    try
                    {
                        try
                        {
                            contact = driver.FindElement(By.XPath($"//span[@class='_35k-1 _1adfa _3-8er' and @title='{targetName}']"));
                        }
                        catch
                        {
                            contact = driver.FindElement(By.XPath($"//span[@class='_35k-1 _1adfa _3-8er' and contains(@title, '{targetName}')]"));
                        }
                        
                        SpamTarget(contact, spamNum);
                    }
                    catch (NoSuchElementException)
                    {
                        restTime.Start();
                        while (true)
                        {
                            try
                            {
                                driver.FindElement(By.XPath($"//span[@class='_35k-1 _1adfa _3-8er' and contains(@title, '{targetName}')]"));
                                break;
                            }
                            catch (NoSuchElementException)
                            {
                                if (restTime.Elapsed.Seconds > 5)
                                {
                                    break;
                                }
                            }
                        }

                        restTime.Stop();

                        contact = driver.FindElement(By.XPath($"//span[@class='_35k-1 _1adfa _3-8er' and contains(@title, '{targetName}')]"));

                        SpamTarget(contact, spamNum);
                    }
                }
                catch (NoSuchElementException)
                {
                    //If the target couldn't be found it minimizes the browser window and shows an error message
                    driver.Manage().Window.Minimize();

                    displayTargetNotFound();
                }

            }
            spammingProcess = false;
        }

        //Spamming method
        private void SpamTarget(IWebElement contact, int spamNum)
        {
            string message;
            int i;

            spamming = true;
            //Shows the red button will now stop the process
            mainButtonRed();

            //Opens the chat of the given target
            contact.Click();
            //Locates the message input space
            IWebElement textField = driver.FindElement(By.XPath("//div[@class='_2_1wd copyable-text selectable-text' and @data-tab='6']"));
            //Saves the message and the number of messages to be sent from user input
            message = messageInput.Text;

            //Sends the same message n times
            for (i = 0; i < spamNum && spamming; i++)
            {
                textField.Clear();
                textField.SendKeys(message);
                textField.SendKeys(seleniumKeys.Enter);
                //Thread.Sleep(1000);
                incrementProgressbar();
            }
            mainButtonGreen();
            spamming = false;
        }

        //Closes the browser when the program is closed
        private void Whatspam_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (browserOpen)
            {
                browserOpen = false;
                driver.Quit();
            }
        }
        #endregion

        #region LANGUAGE
        /*
        private void languageItalian(object sender, EventArgs e)
        {
            insertNameText = "Scrivi il nome del contatto";
            insertMessageText = "Scrivi il messaggio";
            targetNotFoundText = "Contatto non trovato";
            nameInput.Text = insertNameText;
            messageInput.Text = insertMessageText;
            nameLabel.Text = "Obiettivo";
            messageLabel.Text = "Messaggio";      
            numberLabel.Text = "Numero messaggi";
            italianButton.BackColor = Color.Gray;
            englishButton.BackColor = Color.Gainsboro;
        }

        private void languageEnglish(object sender, EventArgs e)
        {
            insertNameText = "Write the target name";
            insertMessageText = "Write the message";
            targetNotFoundText = "Target not found";
            nameInput.Text = insertNameText;
            messageInput.Text = insertMessageText;
            nameLabel.Text = "Target";
            messageLabel.Text = "Message";
            numberLabel.Text = "Spams number";    
            englishButton.BackColor = Color.Gray;
            italianButton.BackColor = Color.Gainsboro;
        }
        */
        #endregion

        #region DEFAULT TEXT
        //Default text vanishes when something is written in the name form
        private void nameInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (nameInput.Text == insertNameText || nameInput.Text == targetNotFoundText)
            {
                nameInput.Text = "";
                nameInput.ForeColor = Color.Black;
            }
            if (messageInput.Text != "" && messageInput.Text != insertMessageText)
            {
                confirmButton.Enabled = true;
                confirmButton.BackgroundImage = Properties.Resources.Bottone_acceso_normale_;
                confirmButton.Refresh();
            }
        }
        //Default text vanishes when the name form is clicked
        private void nameInput_Click(object sender, EventArgs e)
        {
            if (nameInput.Text == insertNameText || nameInput.Text == targetNotFoundText)
            {
                nameInput.Text = "";
                nameInput.ForeColor = Color.Black;           
            }
        }
        //If the name form is left empty the default text gets displayed
        private void nameInput_Leave(object sender, EventArgs e)
        {
            if (nameInput.Text == "")
            {
                nameInput.Text = insertNameText;
                nameInput.ForeColor = Color.OliveDrab;
                confirmButton.Enabled = false;
                confirmButton.BackgroundImage = Properties.Resources.Bottone_spento_normale;
                confirmButton.Refresh();
            }
        }
        //Default text vanishes when something is written in the message form
        private void messageInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (messageInput.Text == insertMessageText)
            {
                messageInput.Text = "";
                messageInput.ForeColor = Color.Black;               
            }
            if (nameInput.Text != "" && nameInput.Text != insertNameText && nameInput.Text != targetNotFoundText)
            {
                confirmButton.Enabled = true;
                confirmButton.BackgroundImage = Properties.Resources.Bottone_acceso_normale_;
                confirmButton.Refresh();
            }
        }
        //Deafult text vanishes when the message form is clicked
        private void messageInput_Click(object sender, EventArgs e)
        {
            if (messageInput.Text == insertMessageText)
            {
                messageInput.Text = "";
                messageInput.ForeColor = Color.Black;
            }
        }
        //If the message form is left empty the default text gets displayed
        private void messageInput_Leave(object sender, EventArgs e)
        {
            if (messageInput.Text == "")
            {
                messageInput.Text = insertMessageText;
                messageInput.ForeColor = Color.OliveDrab;
                confirmButton.Enabled = false;
                confirmButton.BackgroundImage = Properties.Resources.Bottone_spento_normale;
                confirmButton.Refresh();
            }
        }
        #endregion

        #region CROSS-THREAD
        private void incrementProgressbar()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(incrementProgressbar);
                Invoke(method);
                return;
            }
            progressBar.Value++;
        }

        private void displayTargetNotFound()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(displayTargetNotFound);
                Invoke(method);
                return;
            }
            nameInput.Text = targetNotFoundText;
            nameInput.ForeColor = Color.Red;
        }

        //Changes button color, indicating it will now stop the process if clicked
        private void mainButtonRed()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(mainButtonRed);
                Invoke(method);
                return;
            }
            confirmButton.BackgroundImage = Properties.Resources.Bottone_acceso_normale;
            confirmButton.Refresh();
        }

        private void mainButtonGreen()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(mainButtonGreen);
                Invoke(method);
                return;
            }
            confirmButton.BackgroundImage = Properties.Resources.Bottone_spento_normale;
            confirmButton.Refresh();
        }

        #endregion

        #region NUMBER_BUTTONS
        //CURRENTLY NOT USING THE MOUSE_UP FUNCTIONS
        private void number10_MouseDown(object sender, MouseEventArgs e)
        {
            number10.BackgroundImage = Properties.Resources._10_on;
            number10.Refresh();
        }

        private void number10_MouseUp(object sender, MouseEventArgs e)
        {
            number10.BackgroundImage = Properties.Resources._10_off;
            number10.Refresh();
            spamInput.Text = (int.Parse(spamInput.Text) + 10).ToString();
        }
        private void number100_MouseDown(object sender, MouseEventArgs e)
        {
            number100.BackgroundImage = Properties.Resources._100_on;
            number100.Refresh();
        }

        private void number100_MouseUp(object sender, MouseEventArgs e)
        {
            number100.BackgroundImage = Properties.Resources._100_off;
            number100.Refresh();
            spamInput.Text = (int.Parse(spamInput.Text) + 100).ToString();
        }
        private void number1k_MouseDown(object sender, MouseEventArgs e)
        {
            number1k.BackgroundImage = Properties.Resources._1k_on;
            number1k.Refresh();
        }

        private void number1k_MouseUp(object sender, MouseEventArgs e)
        {
            number1k.BackgroundImage = Properties.Resources._1k_off;
            number1k.Refresh();
            spamInput.Text = (int.Parse(spamInput.Text) + 1000).ToString();
        }
        private void number10k_MouseDown(object sender, MouseEventArgs e)
        {
            number10k.BackgroundImage = Properties.Resources._10k_on;
            number10k.Refresh();
        }

        private void number10k_MouseUp(object sender, MouseEventArgs e)
        {
            number10k.BackgroundImage = Properties.Resources._10k_off;
            number10k.Refresh();
            spamInput.Text = (int.Parse(spamInput.Text) + 10000).ToString();
        }
        private void number100k_MouseDown(object sender, MouseEventArgs e)
        {
            number100k.BackgroundImage = Properties.Resources._100k_on;
            number100k.Refresh();
        }

        private void number100k_MouseUp(object sender, MouseEventArgs e)
        {
            number100k.BackgroundImage = Properties.Resources._100k_off;
            number100k.Refresh();
            spamInput.Text = (int.Parse(spamInput.Text) + 100000).ToString();
        }
        private void number500k_MouseDown(object sender, MouseEventArgs e)
        {
            number500k.BackgroundImage = Properties.Resources._500k_on;
            number500k.Refresh();
        }

        private void number500k_MouseUp(object sender, MouseEventArgs e)
        {
            number500k.BackgroundImage = Properties.Resources._500k_off;
            number500k.Refresh();
            spamInput.Text = (int.Parse(spamInput.Text) + 500000).ToString();
        }

        
        #endregion

        #region NUMERIC_INPUT
        private void numericUp_Click(object sender, EventArgs e)
        {
            spamInput.Text = (int.Parse(spamInput.Text) + 1).ToString();
        }

        private void numericDown_Click(object sender, EventArgs e)
        {
            if (spamInput.Text != "1")
            {
                spamInput.Text = (int.Parse(spamInput.Text) - 1).ToString();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Clear button
        private void button1_Click(object sender, EventArgs e)
        {
            spamInput.Text = "0";
        }

        #endregion


        private bool OpenChrome()
        {
            string[] drivers;
            //Getting all the drivers names from the drivers directory
            drivers = Directory.GetFiles($"{Directory.GetCurrentDirectory()}\\Drivers\\Chrome");
            
            //Trying to match each of the existing drivers to the current version of Google Chrome
            foreach (string d in drivers)
            {
                try
                {
                    driverService = ChromeDriverService.CreateDefaultService($"{Directory.GetCurrentDirectory()}\\Drivers\\Chrome", Path.GetFileName(d));

                    //Prevents the Dev Tools command prompt from being displayed
                    driverService.HideCommandPromptWindow = true;

                    //Assigns the chromedriver
                    driver = new ChromeDriver(driverService);
                    //Sets the bool value to true
                    browserOpen = true;
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR 0");
                    Console.WriteLine(e.Message);
                }          
            }
            return false;
        }
        //Have to implement Firefox browser
        private bool OpenFirefox()
        {
            return false;
        }

        private void RoundCorners(Control obj)
        {
            GraphicsPath graphicpath = new GraphicsPath();
            graphicpath.StartFigure();
            graphicpath.AddArc(0, 0, 25, 25, 180, 90);
            graphicpath.AddLine(25, 0, obj.Width - 25, 0);
            graphicpath.AddArc(obj.Width - 25, 0, 25, 25, 270, 90);
            graphicpath.AddLine(obj.Width, 25, obj.Width, obj.Height - 25);
            graphicpath.AddArc(obj.Width - 25, obj.Height - 25, 25, 25, 0, 90);
            graphicpath.AddLine(obj.Width - 25, obj.Height, 25, obj.Height);
            graphicpath.AddArc(0, obj.Height - 25, 25, 25, 90, 90);
            graphicpath.CloseFigure();
            obj.Region = new Region(graphicpath);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {

        }

        
    }
}