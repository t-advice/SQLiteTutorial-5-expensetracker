# SQLiteTutorial6 - Expense Tracker App 

A simple  app demonstrating SQLite database integration.  
This project lets users track daily expenses — add, view, and delete entries — stored locally in SQLite.

---

## Features
- Add expenses with description, amount, category, and date
- View a list of all expenses
- Delete an expense from the list
- Local SQLite database persistence
- Scrollable list with real-time updates

---

## 🧱 Project Structure
SQLiteTutorial6/
┣ 📁 Models/
┃ ┗ Expense.cs
┣ 📁 Services/
┃ ┗ DatabaseService.cs
┣ 📁 Views/
┃ ┣ MainPage.xaml
┃ ┣ MainPage.xaml.cs
┃ ┣ AddExpensePage.xaml
┃ ┗ AddExpensePage.xaml.cs
┣ 📄 App.xaml.cs
┣ 📄 AppShell.xaml
┗ 📄 README.md


---

## Setup Steps

1. Create a new .NET MAUI project:
   ```bash
   dotnet new maui -n SQLiteTutorial6

## dotnet add package sqlite-net-pcl

## Made b Tashwill , UWC , 2025