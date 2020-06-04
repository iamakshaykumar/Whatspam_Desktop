using System;
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
using OpenQA.Selenium.Support.UI;
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
        //Bool that checks if there's a spamming process
        bool spammingProcess = false;
        //Bool that checks if it's actually spamming
        bool spamming = false;
        //Variable storing spam numbers
        int spamNum;
        //Default english texts
        string insertNameText = "Write the target name";
        string insertMessageText = "Write the message";
        string targetNotFoundText = "Target not found";
        //Load confirm button images
        Image confirmButtonOn = Properties.Resources.Confirm_On;
        Image confirmButtonOff = Properties.Resources.Confirm_Off;

        public Whatspam()
        {
            InitializeComponent();
            RoundCorners(nameInput);
            RoundCorners(messageInput);
            RoundCorners(spamInput);
        }

        #region SPAMMING
        //When the confirm button gets clicked
        private void confirmButton_Click(object sender, EventArgs e)
        {
            confirmButton.BackgroundImage = confirmButtonOn;
            confirmButton.Refresh();
            Thread.Sleep(100);
            confirmButton.BackgroundImage = confirmButtonOff;
            confirmButton.Refresh();

            //Checks if there's not an ongoing spamming process
            if (!spammingProcess)
            {
                //Stores the content of spam numbers form
                spamNum = int.Parse(spamInput.Text);
                //Resets progress bar value
                progressBar.Value = 0;
                //Sets a maximum for the progress bar
                progressBar.Maximum = spamNum;
                
                //Starts the spamming process in a new thread
                Thread spammingThread = new Thread(new ThreadStart(BeginSpamming));
                spammingThread.Priority = ThreadPriority.Highest;
                spammingThread.Start();
            }
            else if (spamming)
            {
                confirmButton.BackColor = Color.OliveDrab;
                confirmButton.Text = "Send";
                spamming = false;
            }
        }

        private void BeginSpamming()
        {
            IWebElement contact;
            //Saving the target name from user input
            string targetName = nameInput.Text;
            Stopwatch restTime;

            if (!browserOpen)
            {
                //If the browser isn't already open, it setups the driver and opens Whatsapp Web page
                driverService = ChromeDriverService.CreateDefaultService(Directory.GetCurrentDirectory());
                //Prevents the Dev Tools command prompt from being displayed
                driverService.HideCommandPromptWindow = true;

                browserOpen = true;

                driver = new ChromeDriver(driverService);
             
                driver.Url = "https://web.whatsapp.com/";              
            }
            
            //Setting up a timer to give the user a limited amount of time to log in whatsapp
            restTime = new Stopwatch();
            restTime.Start();
            //Waits until the user is logged in, or the time finishes
            while (true)
            {
                try
                {
                    driver.FindElement(By.XPath($"//span[@class='_1wjpf _3NFp9 _3FXB1']"));
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
        
          
            try
            {
                //Retrieves the target from recent chats and starts the spamming process
                //contact = driver.FindElement(By.XPath($"//span[@class='_1wjpf _3NFp9 _3FXB1' and @title='{targetName}']"));
                contact = driver.FindElement(By.XPath($"//span[@class='_1wjpf _3NFp9 _3FXB1' and contains(@title, '{targetName}')]"));
                contact.Click();
                SpamTarget(contact, spamNum);
            }
            catch (NoSuchElementException)
            {
                //Searches for the target in the Whatsapp search bar and then starts the spamming process
                driver.FindElement(By.XPath("//div[@class='_2S1VP copyable-text selectable-text' and @data-tab='3']")).SendKeys(targetName);

                try
                {
                    try
                    {
                        //Thread.Sleep(1000);
                        //contact = driver.FindElement(By.XPath($"//span[@class='_1wjpf _3NFp9 _3FXB1' and @title='{targetName}']"));
                        contact = driver.FindElement(By.XPath($"//span[@class='_1wjpf _3NFp9 _3FXB1' and contains(@title, '{targetName}')]"));
                        SpamTarget(contact, spamNum);
                    }
                    catch(NoSuchElementException)
                    {
                        restTime.Start();
                        while (true)
                        {
                            try
                            {
                                //driver.FindElement(By.XPath($"//span[@class='_1wjpf _3NFp9 _3FXB1' and @title='{targetName}']"));
                                driver.FindElement(By.XPath($"//span[@class='_1wjpf _3NFp9 _3FXB1' and contains(@title, '{targetName}')]"));
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

                        //contact = driver.FindElement(By.XPath($"//span[@class='_1wjpf _3NFp9 _3FXB1' and @title='{targetName}']"));
                        contact = driver.FindElement(By.XPath($"//span[@class='_1wjpf _3NFp9 _3FXB1' and contains(@title, '{targetName}')]"));

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
            IWebElement textField = driver.FindElement(By.XPath("//div[@class='_2S1VP copyable-text selectable-text' and @data-tab='1']"));
            //Saves the message and the number of messages to be sent from user input
            message = messageInput.Text;
       
            //Sends the same message n times
            for (i = 0; i < spamNum && spamming; i++)
            {
                textField.Clear();
                textField.SendKeys(message);
                driver.FindElement(By.ClassName("_35EW6")).Click();
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
            confirmButton.BackColor = Color.Red;
            confirmButton.Text = "Stop";
        }

        private void mainButtonGreen()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(mainButtonGreen);
                Invoke(method);
                return;
            }
            confirmButton.BackColor = Color.OliveDrab;
            confirmButton.Text = "Send";
        }


        #endregion

        #region NUMBER_BUTTONS
        private void number10_Click(object sender, EventArgs e)
        {
            spamInput.Text = "10";
            number10.BackgroundImage = Properties.Resources._10_on_100;
            number10.Refresh();
            Thread.Sleep(100);
            number10.BackgroundImage = Properties.Resources._10_off_100;
            number10.Refresh();
        }

        private void number100_Click(object sender, EventArgs e)
        {
            spamInput.Text = "100";
        }

        private void number1k_Click(object sender, EventArgs e)
        {
            spamInput.Text = "1000";
        }

        private void number10k_Click(object sender, EventArgs e)
        {
            spamInput.Text = "10000";
        }

        private void number100k_Click(object sender, EventArgs e)
        {
            spamInput.Text = "100000";
        }

        private void number500k_Click(object sender, EventArgs e)
        {
            spamInput.Text = "500000";
        }
        #endregion

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
    }
}