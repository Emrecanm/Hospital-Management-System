# 🏥 Hospital Management System (Hastane Otomasyonu)

<p align="center">
  <img src="https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=c-sharp" alt="C#" />
  <img src="https://img.shields.io/badge/Framework-.NET%20Framework-512BD4?style=for-the-badge&logo=dotnet" alt=".NET" />
  <img src="https://img.shields.io/badge/Database-Microsoft%20SQL%20Server-CC292B?style=for-the-badge&logo=microsoft-sql-server" alt="MSSQL" />
  <img src="https://img.shields.io/badge/Platform-Windows-0078D6?style=for-the-badge&logo=windows" alt="Windows" />
</p>

---

## 📌 Overview

**Hospital Management System** is a desktop database automation application engineered to streamline hospital operations, patient registrations, appointments, and medical department workflows. 

The application utilizes a robust relational database schema modeled via Entity-Relationship (ER) diagrams and powered by **Microsoft SQL Server**. It demonstrates practical implementations of enterprise data modeling, CRUD workflows, transactional integrity, and desktop UI design.

---

## ✨ Key Modules & Capabilities

- **Patient Registration & Medical Records:** Comprehensive patient admission, contact details, medical history tracking, and query filters.
- **Doctor & Staff Scheduling:** Doctor shift allocation, department routing, and specialty management.
- **Appointment Booking Engine:** Conflict-free appointment scheduling system synchronized with doctor availability.
- **Department & Clinic Routing:** Modular organization of hospital divisions (Cardiology, Neurology, Pediatrics, etc.).
- **Relational Data Schema:** Backed by an optimized MSSQL relational database structure featuring normalized tables, foreign keys, and indexes.

---

## 🛠️ Tech Stack & Database Architecture

- **Programming Language:** C#
- **Platform:** .NET Framework (Windows Forms)
- **Database Engine:** Microsoft SQL Server (MSSQL)
- **Data Schema & Modeling:** 
  - Included ER Diagram (`ER_Diyagrami.docx`)
  - Complete SQL database export/backup (`HASTANE_OTOMASYONU.bacpac`)
- **Documentation:** Full specification document (`HastaneOtomasyonu_Dokuman.docx`)

---

## 🚀 Database Setup & Local Installation

### Prerequisites
- **Visual Studio 2019 / 2022** (with .NET desktop development workload)
- **Microsoft SQL Server Management Studio (SSMS)**

### Database Restoration (.bacpac)
1. Open **SQL Server Management Studio (SSMS)** and connect to your local server instance.
2. In the Object Explorer, right-click **Databases** and choose **Import Data-tier Application...**.
3. Select the `HASTANE_OTOMASYONU.bacpac` file located in the root folder of this repository.
4. Proceed with the wizard to restore the full schema and seed data.

### Running the Application
1. Open the solution file in Visual Studio.
2. Update the `connectionString` inside `App.config` to match your local SQL Server instance:
   ```xml
   <connectionStrings>
       <add name="HospitalDB" 
            connectionString="Server=YOUR_SERVER_NAME;Database=HASTANE_OTOMASYONU;Trusted_Connection=True;" 
            providerName="System.Data.SqlClient" />
   </connectionStrings>
