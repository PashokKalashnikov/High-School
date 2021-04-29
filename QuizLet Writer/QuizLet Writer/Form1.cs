using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using OpenQA.Selenium;

namespace QuizLet_Writer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        IWebDriver Browser;
        IWebElement Element;
        IList<IWebElement> lElements;

        string[,] sWords;
        int iTests;

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = openFileDialog1.ShowDialog();

            if (dlgResult == DialogResult.OK)
            {
                try
                {
                    StreamReader str = new StreamReader(openFileDialog1.OpenFile());

                    string sNumofWords = str.ReadToEnd();
                    int iFirstIndex = 0,
                        iNumofWords = 0,
                        iIndex = 0;
                    
                    foreach (char cComma in sNumofWords)
                    {
                        if (cComma == ',')
                            iNumofWords++;
                    }

                    sWords = new string[iNumofWords, 2];

                    for (int iSecondIndex = 0; iSecondIndex != sNumofWords.Length; iSecondIndex++)
                    {
                        if (sNumofWords[iSecondIndex] == ',')
                        {
                            sWords[iIndex, 0] = (sNumofWords.Substring(iFirstIndex, iSecondIndex - iFirstIndex));
                            iIndex++;

                            Console.WriteLine(sNumofWords.Substring(iFirstIndex, iSecondIndex - iFirstIndex));
                            iFirstIndex = iSecondIndex + 2;
                        }
                    }

                    label1.Text = "Number of words: " + iIndex.ToString();

                    for (int i = 0; i < sWords.GetLength(0); i++)
                    {
                        sWords[i, 1] = string.Format("Definition #{0}", i + 1);
                    }

                    Console.WriteLine("\n ========== Finished ==========\n");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening file", ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
                Browser.Navigate().GoToUrl("https://quizlet.com/");

                Element = Browser.FindElement(By.XPath("//*[text()='Log in']")); // Log in button
                Element.Click();

                // Logs in
                Browser.FindElement(By.Id("username")).SendKeys("Pashok_Kalashnikov");
                Browser.FindElement(By.Id("password")).SendKeys("vipua2000228");
                Browser.FindElement(By.CssSelector("[aria-label=\"Log in\"]")).Click();

                // Creates a new quiz
                Browser.FindElement(By.XPath("/html/body/div[7]/div/div/div/div/div/button[1]")).Click();

                System.Threading.Thread.Sleep(3000);

                Browser.Navigate().GoToUrl("https://quizlet.com/Pashok_Kalashnikov/folders/english-vocabulary/sets");

                iTests = Convert.ToInt32(Browser.FindElement(By.CssSelector("#DashboardPageTarget > div > div.DashboardPage-header > div > div.DashboardHeader > div > div.UIDiv.FolderPageHeader > div.FolderPageHeader-info > span:nth-child(1) > span")).Text.Substring(0, 1));
                label2.Text = "Number of tests: " + iTests.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            

        }
        // Я хочу питсы

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Browser.Navigate().GoToUrl("https://quizlet.com/create-set");
                System.Threading.Thread.Sleep(2000);
                
                try
                {
                    Browser.FindElement(By.XPath("//*[@class='UILink UILink--revert']")).Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }


                Browser.FindElement(By.CssSelector("#SetPageTarget > div > div.CreateSetHeader.has-adz > div:nth-child(2) > div > div.CreateSetHeader-textarea.CreateSetHeader-title > div > label > div > div > div.AutoExpandTextarea-wrapper > textarea")).SendKeys(string.Format("Quiz #{0}", iTests + 1));

                // ---------------------------------------------------------------------------- //

                System.Threading.Thread.Sleep(2000);

                lElements = Browser.FindElements(By.XPath("//*[@class='TermContent-side TermContent-side--word']/div/div/div/div/p"));

                for (int iAddWords = sWords.Length / 2; iAddWords > lElements.Count - 1; iAddWords--)
                {
                    Browser.FindElement(By.XPath("//*/a[@id='addRow']/span[@class='TermContent-addRowButton']/button")).Click();
                    System.Threading.Thread.Sleep(500);
                }

                lElements = Browser.FindElements(By.XPath("//*[@class='TermContent-side TermContent-side--word']/div/div/div/div/p"));

                for (int i = 0; i < lElements.Count - 1; i++)
                {
                    Element = lElements[i];
                    Element.SendKeys(sWords[i, 0]);
                }

                lElements = Browser.FindElements(By.XPath("//*[@class='TermContent-side TermContent-side--definition']/div/div/div/div/div/p"));

                for (int i = 0; i < lElements.Count - 1; i++)
                {
                    Element = lElements[i];
                    Element.SendKeys(sWords[i, 1]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

/* Useful links/ideads:
 * 1) https://www.c-sharpcorner.com/article/working-with-json-string-in-C-Sharp/
 * 2) Line 64: Figure out the way to insert the founded definition for each words using sWords[i, 1] = "Definition(s)" (Database? Silenium?)
 * 3) System.Threading.Thread.Sleep(3000);
 * 
 */
