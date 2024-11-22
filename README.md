Contract Monthly Claim System
The Contract Monthly Claim System is a web application designed to streamline the process of submitting, approving, and managing lecturer contract claims. It offers features such as claim submission, real-time validation, document uploads, status updates, and the ability to approve or reject claims with detailed feedback. This project was developed using ASP.NET Core MVC with a MySQL database.

Table of Contents
Features
Installation
Technologies Used
Screenshots
How to Use
Feedback Implementation
Version Control
License
Features
Claim Submission: Lecturers can submit claims by specifying hours worked, hourly rate, and uploading supporting documents.
Document Upload: Uploaded files are securely stored and can be accessed or downloaded.
Real-time Validation: Prevent invalid inputs with real-time form validation for hours worked and hourly rate.
Admin Dashboard: View, approve, or reject claims. Provide reasons for rejection.
Claim Status Tracking: Monitor the status of claims as "Pending," "Approved," or "Rejected."
Responsive UI: A visually appealing, futuristic, and user-friendly interface.
Installation
Follow these steps to set up the system on your local machine:

Clone the Repository

bash
Copy code
git clone https://github.com/your-username/contract-monthly-claim-system.git
Navigate to the Project Folder

bash
Copy code
cd contract-monthly-claim-system
Set up the Database

Create a MySQL database named claimsystem.
Import the database schema from the file schema.sql (provided in the project).
Update Connection String
Modify the connection string in appsettings.json to match your MySQL database configuration:

json
Copy code
"ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=claimsystem;User=root;Password=yourpassword;"
}
Install Dependencies
Run the following command to restore NuGet packages:

bash
Copy code
dotnet restore
Run the Application
Start the project:

bash
Copy code
dotnet run
Access the Application
Open your browser and navigate to:
http://localhost:5000

Technologies Used
Frontend: HTML, CSS, Bootstrap, jQuery
Backend: ASP.NET Core MVC
Database: MySQL
Version Control: Git and GitHub
Frameworks: .NET Core 6.0+
Screenshots
Dashboard - Manage Claims

Claim Submission Form

File Upload

How to Use
Lecturer Workflow:
Log in to the system.
Submit claims by providing hours worked, hourly rate, and uploading supporting documents.
Track the status of submitted claims.
Admin Workflow:
Log in to access the Manage Claims dashboard.
View all pending claims with details.
Approve or reject claims and provide a reason for rejection.
Download uploaded documents for verification.
Feedback Implementation
Lecturer Feedback:
Form Validation: Implemented validation to prevent negative or zero values for hours worked and hourly rate.
Rejection Reasons: Added a field for administrators to provide reasons when rejecting claims.
Uploaded Documents: Enhanced the interface to allow document downloads directly from the dashboard.
Version Control
This project uses Git for version control. Below is a sample of the commit history:

Commit #	Message
1	feat: Set up the basic structure of the system
2	feat: Implemented client-side and server-side validation
3	feat: Added rejection reasons and approval process
4	style: Improved UI with a futuristic design
5	fix: Corrected file path validation for uploaded documents
6	feat: Added document upload and view feature
7	docs: Updated README file and added screenshots
8	chore: Updated database seed script for deployment
9	fix: Enhanced error handling during claim submission
