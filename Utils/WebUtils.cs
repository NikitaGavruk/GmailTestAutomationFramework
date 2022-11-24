﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailTA.Utils
{
    public class WebUtils
    {
        public WebUtils()
        {
        }

        public static By FormatXpath(string xpath, string argument)
        {
            return By.XPath(string.Format(xpath, argument));
        }
    }
}