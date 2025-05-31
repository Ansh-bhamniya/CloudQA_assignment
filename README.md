# 🧪 Selenium Automation - Automation Practice Form (C#)

This project contains a C# program using **Selenium WebDriver** that automatically fills out and submits a sample form hosted at [CloudQA Automation Practice Form](https://app.cloudqa.io/home/AutomationPracticeForm).

It demonstrates how to use Selenium to interact with web elements like input fields, checkboxes, radio buttons, file uploads, and rich text editors, all through an automated browser session.


---

The script is designed to work even if the position or properties of the HTML elements change. For minor changes, it works as-is. If locators change, I’ve used the Page Object Model (POM), so only small updates are needed. Even with major changes, updating the POM class is enough to keep it working.

---

---
demo video 
https://drive.google.com/file/d/1S6s9ombvMI8H3ycXlW1NWtyalkPN3xbJ/view?usp=sharing

---


## 🚀 Features

- Uses **Page Object Model (POM)** for maintainable and readable code
- Automates:
  - Input fields (textboxes)
  - Radio buttons
  - Checkboxes
  - Rich text editor using JavaScript
  - File upload
  - Form submission

---

## 📁 Project Structure

├── Program.cs # Main test runner
├── AutomationPracticeFormPage.cs # Page Object Model class for form interactions
└── README.md # Project description


---

## 🛠 Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/en-us/download) (>= .NET 6 recommended)
- Google Chrome
- NuGet packages:
  - `Selenium.WebDriver`
  - `Selenium.WebDriver.ChromeDriver`


---

## 💻 How to Run

1. Clone the repository:

   ```bash
   git clone https://github.com/yourusername/your-repo-name.git
   cd your-repo-name

Alternatively

donwload this zip file and 
Run the project:
dotnet run


🧱 Built With
C#

Selenium WebDriver

ChromeDriver


📬 Contact
Ansh Bhamniya
📧 ansh_b@bt.iitr.ac.in
+91 8868944498
address - RKB IIT ROORKEE




   
