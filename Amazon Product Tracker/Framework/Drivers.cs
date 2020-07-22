using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon_Product_Tracker.Framework
{
    class Drivers
    {
        IWebDriver _driver;

        public Drivers()
        {
            string programExecutionBrowser = ConfigurationManager.AppSettings["ProgramExecutionBrowser"];

            switch (programExecutionBrowser)
            {
                case "IE":

                    break;

                case "GC":

                    break;

                case "FF":

                    break;
                default:
                    // Invalid Input From App.config -- ProgramExecutionBrowser
                    break;
            }

        }
    }
}
