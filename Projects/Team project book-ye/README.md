# Book-ye Website Testing Project

This repository contains the work completed by our team as part of the testing project for the **Book-ye** website. The goal of this project was to thoroughly test the functionality, usability, and critical paths of the site, identifying and reporting any issues found during the testing process.

## Project Structure

The project is organized into the following files and directories:

- **Project tasks**: ![Project tasks](Project%20tasks.png)  
  Contains the list of tasks that we performed as part of this testing project.

- **Test cases**: [Test case book-ye.pdf](Test%20case%20book-ye.pdf) 
  This PDF file contains the detailed test cases that we wrote and executed during the project, including Smoke Testing and tests using Equivalence Partitioning and Boundary Value Analysis techniques.

- **Bug reports**: [Jira bug report/](Jira%20bug%20report/)  
  This folder contains all the bug reports that were logged during our testing process. Each bug is documented with reports and related video recordings.

- **Test report**: [Test report book-ye.pdf](Test%20report%20book-ye.pdf)  
  The final test report provides a summary of the testing efforts, the issues found, and recommendations for improvements to the website.

## Key Tasks Completed

1. **Smoke Testing**: Wrote and executed 6 test cases to verify the core functionality of the website.
2. **Registration Form Testing**: Created 6 test cases using **Equivalence Class Partitioning** and **Boundary Value Analysis** to validate the registration process.
3. **Critical Path Testing**: Developed and executed 5 user scenarios for critical path testing, focusing on the most important user journeys on the site.
4. **Bug Reporting**: Logged all identified issues (a minimum of 3) in Jira, with detailed reports and accompanying videos.
5. **Test Result Report**: Created a comprehensive report summarizing the testing activities and results, as well as recommendations for improvement.

## How to Use This Repository

1. Clone the repository to your local machine:
   ```bash

   git clone --no-checkout https://github.com/Weretik/Portfolio-QA-Engineer.git

   cd Portfolio-QA-Engineer

   git sparse-checkout init --cone

   git sparse-checkout set Projects/Team\ project\ book-ye

   git checkout main
