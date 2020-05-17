using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        //Default error message when targets aren't found
        string NOT_FOUND = "Contatto non trovato";

        public Whatspam()
        {
            InitializeComponent();
        }

        #region SPAMMING
        //When the confirm button gets clicked
        private void confirmButton_Click(object sender, EventArgs e)
        {
            IWebElement contact;
            bool breakOut = false;
            //Saving the target name from user input
            string targetName = nameInput.Text;
            Stopwatch restTime;

            if (!browserOpen)
            {
                //If the browser isn't already open, it setups the driver and opens Whatsapp Web page
                driverService = ChromeDriverService.CreateDefaultService(Directory.GetCurrentDirectory());
                //Prevents the Dev Tools command prompt from being displayed
                driverService.HideCommandPromptWindow = true;

                driver = new ChromeDriver(driverService);
                
                driver.Url = "https://web.whatsapp.com/";

                browserOpen = true;
            }
            //Resets progress bar value
            progressBar.Value = 0;
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
                        breakOut = true;
                        restTime.Stop();
                        break;
                    }
                }
            }

            restTime.Stop();
            //If the user is logged in
            if (!breakOut)
            {
                try
                {
                    //Retrieves the target from recent chats and starts the spamming process
                    contact = driver.FindElement(By.XPath($"//span[@class='_1wjpf _3NFp9 _3FXB1' and @title='{targetName}']"));

                    SpamTarget(contact);
                }
                catch (NoSuchElementException)
                {
                    //Searches for the target in the Whatsapp search bar and then starts the spamming process
                    driver.FindElement(By.XPath("//div[@class='_2S1VP copyable-text selectable-text' and @data-tab='3']")).SendKeys(targetName);

                    try
                    {
                        contact = driver.FindElement(By.XPath($"//span[@class='_1wjpf _3NFp9 _3FXB1' and @title='{targetName}']"));

                        SpamTarget(contact);
                    }
                    catch (NoSuchElementException)
                    {
                        //If the target couldn't be found it minimizes the browser window and shows an error message
                        driver.Manage().Window.Minimize();

                        nameInput.Text = NOT_FOUND;
                        nameInput.ForeColor = Color.Red;
                    }  
                }
            }           
        }

        //Spamming method
        private void SpamTarget(IWebElement contact)
        {
            string message;
            int spamNum;
            int i;
            //Opens the chat of the given target
            contact.Click();
            //Locates the message input space
            IWebElement textField = driver.FindElement(By.XPath("//div[@class='_2S1VP copyable-text selectable-text' and @data-tab='1']"));
            //Saves the message and the number of messages to be sent from user input
            message = messageInput.Text;
            spamNum = (int)numberInput.Value;
            //Sets a maximum for the progress bar
            progressBar.Maximum = spamNum;
            //Sends the same message n times
            for (i = 0; i < spamNum; i++, progressBar.Value++)
            {
                textField.SendKeys(message);

                driver.FindElement(By.ClassName("_35EW6")).Click();
            }           
        }

        //Closes the browser when the program is closed
        private void Whatspam_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (browserOpen)
            {
                driver.Quit();
            }          
        }
        #endregion

        #region DEFAULT TEXT
        //Default text vanishes when something is written in the name form
        private void nameInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (nameInput.Text == "Scrivi il nome del contatto" || nameInput.Text == NOT_FOUND)
            {
                nameInput.Text = "";
                nameInput.ForeColor = Color.YellowGreen;
            }
        }
        //Default text vanishes when the name form is clicked
        private void nameInput_Click(object sender, EventArgs e)
        {
            if (nameInput.Text == "Scrivi il nome del contatto" || nameInput.Text == NOT_FOUND)
            {
                nameInput.Text = "";
                nameInput.ForeColor = Color.YellowGreen;
            }
        }
        //If the name form is left empty the default text gets displayed
        private void nameInput_Leave(object sender, EventArgs e)
        {
            if (nameInput.Text == "")
            {
                nameInput.Text = "Scrivi il nome del contatto";
                nameInput.ForeColor = Color.OliveDrab;
            }
        }
        //Default text vanishes when something is written in the message form
        private void messageInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (messageInput.Text == "Scrivi il messaggio")
            {
                messageInput.Text = "";
                messageInput.ForeColor = Color.YellowGreen;
            }          
        }
        //Deafult text vanishes when the message form is clicked
        private void messageInput_Click(object sender, EventArgs e)
        {
            if (messageInput.Text == "Scrivi il messaggio")
            {
                messageInput.Text = "";
                messageInput.ForeColor = Color.YellowGreen;
            }
        }
        //If the message form is left empty the default text gets displayed
        private void messageInput_Leave(object sender, EventArgs e)
        {
            if (messageInput.Text == "")
            {
                messageInput.Text = "Scrivi il messaggio";
                messageInput.ForeColor = Color.OliveDrab;
            }
        }
        #endregion

        #region HIGHLIGHT

        private void nameLabel_MouseEnter(object sender, EventArgs e)
        {
            nameLabel.ForeColor = System.Drawing.Color.GreenYellow;
        }

        private void nameLabel_MouseLeave(object sender, EventArgs e)
        {
            nameLabel.ForeColor = System.Drawing.Color.YellowGreen;
        }

        private void messageLabel_MouseEnter(object sender, EventArgs e)
        {
            messageLabel.ForeColor = Color.GreenYellow;
        }

        private void messageLabel_MouseLeave(object sender, EventArgs e)
        {
            messageLabel.ForeColor = Color.YellowGreen;
        }

        private void numberLabel_MouseEnter(object sender, EventArgs e)
        {
            numberLabel.ForeColor = Color.GreenYellow;
        }

        private void numberLabel_MouseLeave(object sender, EventArgs e)
        {
            numberLabel.ForeColor = Color.YellowGreen;
        }

        #endregion

        #region UTILITIES
        private bool isIn(string[] arr, string str)
        {
            foreach (string s in arr)
            {
                if (s == str)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        
    }
}