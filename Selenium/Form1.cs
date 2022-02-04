using System;
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


namespace Selenium
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (TBotdel.Text =="")
            {
                MessageBox.Show("Введите отдел!");
                return;
            }
            if (TBlanguage.Text == "")
            {
                MessageBox.Show("Введите язык!");
                return;
            }
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(@"https://careers.veeam.ru/vacancies");
            IWebElement element = driver.FindElement(By.XPath("//*[contains(text(), 'Все отделы')]"));
            driver.Manage().Window.Maximize();
            element.Click();
            try
            {
                element = driver.FindElement(By.LinkText($"{TBotdel.Text}"));
            }
            catch (OpenQA.Selenium.NoSuchElementException)
            {
                MessageBox.Show("Вы ввели отдел которого нет на сайте");

                driver.Quit();
                return;
               
            }

            element.Click();
            element = driver.FindElement(By.XPath("//*[contains(text(), 'Все языки')]"));
            element.Click();
            try
            {
                element = driver.FindElement(By.XPath($"//*[contains(text(), '{TBlanguage.Text}')]"));

            }
            catch (OpenQA.Selenium.NoSuchElementException)
            {
                MessageBox.Show("Вы ввели язык которого нет на сайте");

                driver.Quit();
                return;
            }
            element.Click();
            List<IWebElement> innerBlockList = driver.FindElements(By.XPath("//*[@id='root']/div/div[1]/div/div[2]/div[2]/div/a")).ToList();
            for (int i = 0; i < innerBlockList.Count; i++)
            {
                TBvacancies.AppendText(innerBlockList[i].Text + Environment.NewLine);
            }
            Lkolvac.Text =  $"Найдено {innerBlockList.Count} вакансий";
            

        }

        private void BTclear_Click(object sender, EventArgs e)
        {
            TBvacancies.Text = "";
            TBotdel.Text = "";
            TBlanguage.Text = "";
            Lkolvac.Text = "";
        }

       
    }
}
