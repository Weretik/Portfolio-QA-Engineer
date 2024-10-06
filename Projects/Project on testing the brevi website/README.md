# Brevi Website Testing

This repository contains the documentation for testing the Brevi website.

## Files

1. **[Brevi website testing plan.pdf](0.%20Brevi%20website%20testing%20plan.pdf)** – A detailed plan outlining the testing approach for brevi.com.ua.
2. **[Check list for testing the Brevi site.pdf](./1.%20Check%20list%20for%20testing%20the%20Brevi%20site.pdf)** – A checklist covering tests for website loading, localization, GUI, and cross-platform compatibility.
3. **[Test case for testing the Brevi site.pdf](./2.%20Test%20case%20for%20testing%20the%20Brevi%20site.pdf)** – A test case covering smoke testing to verify basic system functions to ensure that critical functionality is working properly.
4. **[Test scenario for testing the Brevi site.pdf](./3.%20Test%20scenario%20for%20testing%20the%20Brevi%20site.pdf)** – Testing the ability to contact the company: verifying contact information in the header and footer, ordering a consultation through a banner, and the form on the "Contacts" page.
5. **[Selenium project for testing the Brevi site.side](./4.%20Selenium%20project%20for%20testing%20the%20Brevi%20site.side)** – A Selenium project file (.side) created for automated testing of the Brevi website.
6. **[Report on the experience testing the Brevi website.pdf](./5.%20Report%20on%20the%20experience%20testing%20the%20Brevi%20website.pdf)** – A report documenting the findings from exploratory testing on the Brevi website. It includes a summary of identified issues, observations on site behavior, and recommendations for improving functionality and user experience.
7. **[Test report for testing the Brevi site.pdf](./6.%20Test%20report%20for%20testing%20the%20Brevi%20site.pdf)** – A comprehensive report summarizing the results of testing the Brevi website. The report includes the number of tests conducted, defects identified and categorized by priority, and overall findings.

### Postman Testing

Located in the **Postman testing** folder are the Postman environment and collection files used for functional testing of the Brevi website:

- **[Brevi site.postman_environment.json](./Postman%20testing/Brevi%20site.postman_environment.json)** – The Postman environment file, containing variables and configurations for testing.
- **[Functional testing.postman_collection.json](./Postman%20testing/Functional%20testing.postman_collection.json)** – A Postman collection file with requests and tests for functional testing of the Brevi website.

#### How to Import Postman Files

To start using the Postman environment and collection files for testing, follow these steps:

1. **Open Postman.**
2. **Navigate to the "Import" section.** You can find the "Import" button in the top-left corner of the Postman app.
3. **Select the "Upload Files" option.**
4. **Browse and select the JSON files**: 
   - **`Brevi site.postman_environment.json`** – to import the environment.
   - **`Functional testing.postman_collection.json`** – to import the collection.
5. **Click the "Import" button** to add the files to your Postman workspace.
6. Once imported, select the environment from the top-right corner of Postman and use the collection to run the tests on the Brevi website.

## Defect Reports

The **Brevi website defect report** folder contains detailed reports on defects found during testing. These defect reports were documented and managed using **Jira**, providing a structured and efficient workflow for tracking and resolving issues. Each defect report provides the following details:

- **Summary** – A concise description of the defect.
- **Steps to Reproduce** – A step-by-step guide on how to replicate the issue.
- **Expected Result** – The correct behavior that should have been observed.
- **Actual Result** – The behavior that was actually observed during testing.
- **Environment** – Information about the testing environment (OS, browser versions, device types, etc.).
- **Attachments** – Screenshots or any other relevant files to support the defect.

These defect reports were created based on the previously written testing documentation (test plans, checklists, and test cases) to provide actionable insights for the development team to identify, reproduce, and resolve issues on the Brevi website.

