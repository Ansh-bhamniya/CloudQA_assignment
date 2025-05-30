using OpenQA.Selenium;

public class AutomationPracticeFormPage
{
    private readonly IWebDriver driver;
    private readonly IWebElement form;

    public AutomationPracticeFormPage(IWebDriver driver)
    {
        this.driver = driver;
        form = driver.FindElement(By.Id("automationtestform"));
    }

    public void EnterFirstName(string fname) => form.FindElement(By.Id("fname")).SendKeys(fname);
    public void EnterLastName(string lname) => form.FindElement(By.Id("lname")).SendKeys(lname);
    public void SelectGenderMale() => form.FindElement(By.Id("male")).Click();
    public void EnterDOB(string dob) => form.FindElement(By.Id("dob")).SendKeys(dob);
    public void EnterMobile(string mobile) => form.FindElement(By.Id("mobile")).SendKeys(mobile);
    public void EnterEmail(string email) => form.FindElement(By.Id("email")).SendKeys(email);
    public void EnterCountry(string country) => form.FindElement(By.Id("country")).SendKeys(country);
    public void EnterState(string state) => form.FindElement(By.Id("state")).SendKeys(state);
    public void SelectDance() => form.FindElement(By.Id("Dance")).Click();
    public void SelectCricket() => form.FindElement(By.Id("Cricket")).Click();
    public void EnterAbout(string about) => form.FindElement(By.Name("About")).SendKeys(about);

    public void FillDescription(string html)
    {
        IWebElement editableDiv = driver.FindElement(By.CssSelector("div.note-editable.card-block"));
        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        js.ExecuteScript("arguments[0].innerHTML = arguments[1];", editableDiv, html);
    }

    public void EnterUsername(string username) => form.FindElement(By.Name("Username")).SendKeys(username);
    public void EnterPassword(string password) => form.FindElement(By.Name("Password")).SendKeys(password);
    public void EnterConfirmPassword(string password) => form.FindElement(By.Name("Confirm Password")).SendKeys(password);

    public void UploadFile(string filePath) => driver.FindElement(By.Name("pic")).SendKeys(filePath);

    public void AgreeToTerms()
    {
        IWebElement agreeCheckbox = driver.FindElement(By.Name("Agree"));
        if (!agreeCheckbox.Selected)
        {
            agreeCheckbox.Click();
        }
    }

    public void SubmitForm() => form.FindElement(By.CssSelector("[value='submit']")).Click();
}
