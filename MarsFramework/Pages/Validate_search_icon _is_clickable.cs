using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    internal class Validate_search_icon__is_clickable
    {
        public Validate_search_icon__is_clickable()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        // Initialize Web Elements

        //search field
        [FindsBy(How = How.XPath, Using = "//input[@type='text' and @data-page='/search']")]
        private IWebElement Search_field { get; set; }

        //Search icon
        [FindsBy(How = How.XPath, Using = "//button[@datav3-track-event='click' and @datav3-track-text='search']")]
        private IWebElement Search_icon { get; set; }


        internal void validate_search_icon()
        {
            Actions actions = new Actions(Global.GlobalDefinitions.driver);

            //populate the excel sheet
            Global.GlobalDefinitions.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "Search");

            //Navigate to the Url
            Global.GlobalDefinitions.driver.Navigate().GoToUrl(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Url"));

            Thread.Sleep(5000);

            //goto search field
            actions.MoveToElement(Search_field).Build().Perform();
            Thread.Sleep(1000);

            Search_field.Click();
            Search_field.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Product"));

            Thread.Sleep(1000);

            actions.MoveToElement(Search_icon).Build().Perform();
            Thread.Sleep(1000);

            Search_icon.Click();

        }
    }
}