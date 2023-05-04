using System;
using RestSharpSpecflow.Drivers;
using TechTalk.SpecFlow;
using Utility;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;

namespace RestSharpSpecflow.Hooks
{
    [Binding]
    public sealed class Hooks : ExtentReport
    {
        
        [BeforeTestRun]
        public static void BeforeTestRun(){
              ExtentReportInit();  
        }   

        [AfterTestRun]
        public static void AfterTestRun(){
            cleanReport();
        }

    }
}