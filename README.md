# Car Parking Management System

This project is a **Parking Management System** designed to automate vehicle and customer data entry, parking duration tracking, fee calculation, and report generation. It is built using **C#** as a **desktop application** in **Visual Studio 2010 Professional**.

## Features
- **Automated Data Entry**: Vehicle and customer information is recorded when the vehicle enters the parking lot.
- **User Roles**: Two roles in the system:
  - **Administrator**: Responsible for viewing and deleting data.
  - **User**: Responsible for entering and updating data.
- **Parking Duration Calculation**: Automatically calculates parking time based on the time of vehicle departure.
- **Fee Calculation**: Charges are calculated based on parking duration, and a report is generated at checkout.
- **Billing System**: Generates a final bill for the customer (visitor or loyal) upon departure.
- **Auto-Generated Model Numbers**: Each entry generates a unique model number for vehicles.
- **Data Management**: Displays customer, vehicle, and fare information in data frames, supporting data entry, updates, and deletion.

## System Workflow
1. **Vehicle Entry**: Information about the vehicle and customer is obtained.
2. **Parking Duration Tracking**: Tracks how long the vehicle has been parked.
3. **Fee Calculation**: Based on the parking duration, the customer is charged accordingly.
4. **Report and Billing**: A report is generated and a final bill is issued to the customer at checkout.
   
## Technologies Used
- **Programming Language**: C#
- **IDE**: Visual Studio 2010 Professional
- **Database**: MySQL

## How to Use
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/parking-management-system.git
   ```
2. Open the project in **Visual Studio 2010 Professional**.
3. Build and run the project.
