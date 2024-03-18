# Note-Taking-App

This is a simple Note Taking App developed using C# and Windows Forms. It allows users to create, save, view, and delete notes. The notes are stored in a SQL Server database.

## Setup Instructions

### Prerequisites

- Visual Studio installed on your system.
- SQL Server installed and running.

### Steps to Run the App

1. Clone or download this repository to your local machine.
2. Open the solution file `NoteTakingApp.sln` in Visual Studio.
3. Configure the database connection string
4. Create the database:
   - I used SQL Server Management Studio (SSMS)
5. Build the solution by pressing `Ctrl + Shift + B` or by selecting `Build > Build Solution` from the Visual Studio menu.
6. Start the application by pressing `F5` or by selecting `Debug > Start Debugging` from the Visual Studio menu.

## Usage

- Upon running the application, you will see the main window of the Note Taking App.
- To create a new note, click on the "Create" button and fill in the title and content fields, then "Save".
- To view saved notes, they will be displayed in the ListView. You can select a note to view its content.
- To delete a note, select it from the ListView and click on the "Delete" button.
- Close the application by clicking the close button (X) on the window.
