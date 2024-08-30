# ST10045251_CLDV6212_POE

SEMESTER 2: This is Part 1 of a POE. 

# ABC Retail Storage Management Web Application

## Overview

This is a web application built using ASP.NET Core MVC that allows users to manage customer profiles, upload product images, process orders, and manage contracts/logs. The application interacts with Azure Storage services including Blob Storage, Table Storage, Queue Storage, and File Storage.

## Features

- **Add Customer Profiles**: Store customer information using Azure Table Storage.
- **Upload Product Images**: Store product images in Azure Blob Storage.
- **Process Orders**: Manage order processing with Azure Queue Storage.
- **Manage Contracts and Logs**: Store and manage contracts and logs using Azure File Storage.

## Prerequisites

- **Visual Studio 2022** or later
- **.NET 6.0 SDK** or later
- **Azure Account** with access to Azure Storage services

### **Home Page**

- Navigate to the home page to access various features like adding customer profiles, uploading product images, processing orders, and managing contracts/logs.

### **Add Customer Profile**

1. Click on **Add Customer Profile**.
2. Enter the customer's name, email, and phone number.
3. Click **Submit** to save the profile in Azure Table Storage.

### **Upload Product Image**

1. Click on **Upload Product Image**.
2. Choose an image file from your device.
3. Click **Upload** to store the image in Azure Blob Storage.

### **Process Order**

1. Click on **Process Order**.
2. Enter the order details.
3. Click **Submit** to add the order to Azure Queue Storage.

### **Upload Contract**

1. Click on **Upload Contract**.
2. Choose a file (contract or log) from your device.
3. Click **Upload** to store the file in Azure File Storage.

   ## **License**

This project is for educational purposes as part of the ST10045251 Cloud Development module and is not intended for commercial use.
"""
