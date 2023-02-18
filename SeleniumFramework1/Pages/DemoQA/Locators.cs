﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework1.Pages.DemoQA
{
    internal class Locators
    {
        internal static string inputFullName = "//*[@id='userName']";
        internal static string inputEmail = "//*[@id='userEmail']";
        internal static string inputCurrentAddress = "//*[@id='currentAddress']";
        internal static string inputPermanentAddress = "//*[@id='permanentAddress']";
        internal static string buttonSubmit = "//*[@id='submit']/..";
        internal static string outputFullName = "//*[@id='output']//*[@id='name']";
        internal static string outputEmail = "//*[@id='output']//*[@id='email']";
        internal static string outputCurrentAddress = "//*[@id='output']//*[@id='currentAddress']";
        internal static string outputPermanentAddress = "//*[@id='output']//*[@id='permanentAddress']";
    }
}