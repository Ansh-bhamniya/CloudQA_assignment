using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class FirstApp
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");
        System.Threading.Thread.Sleep(5000); 
        var formPage = new AutomationPracticeFormPage(driver);
        formPage.EnterFirstName("Ansh");
        formPage.EnterLastName("Bhamniya");
        formPage.SelectGenderMale();
        formPage.EnterDOB("2002-04-04");
        formPage.EnterMobile("8868944498");
        formPage.EnterEmail("ansh@gmail.com");
        formPage.EnterCountry("India");
        formPage.EnterState("India");
        formPage.SelectDance();
        formPage.SelectCricket();
        formPage.EnterAbout("I am Ansh Bhamniya, a passionate learner.");

        formPage.FillDescription("<p>This is the <b>description</b> filled by Selenium!</p>");
        formPage.EnterUsername("Battak");
        formPage.EnterPassword("123456");
        formPage.EnterConfirmPassword("123456");

        formPage.UploadFile("/Users/beluga/Desktop/MyCSharpApp/bsbe.png");
        formPage.AgreeToTerms();
        formPage.SubmitForm();

       
        // driver.Quit();
    }
}
