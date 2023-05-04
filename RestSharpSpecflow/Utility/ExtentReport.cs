
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;

namespace Utility{
public class ExtentReport{

public static ExtentReports _extentReports ;
public static ExtentTest _feature;
public static ExtentTest _scenarios;

public static string dir = AppDomain.CurrentDomain.BaseDirectory;
public static string testResultPath = dir.Replace("bin//debug//net6.0","TestResults");

public static void ExtentReportInit(){
    var htmlReporter = new ExtentHtmlReporter(testResultPath);
    htmlReporter.Config.ReportName = "Automation status Report";
    htmlReporter.Config.DocumentTitle = "Automations status report";
    htmlReporter.Config.Theme = Theme.Standard;
    htmlReporter.Start();

    _extentReports = new ExtentReports();
    _extentReports.AttachReporter(htmlReporter);
}

public static void cleanReport(){
    _extentReports.Flush();
}

}
}