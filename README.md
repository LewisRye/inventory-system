# Inventory Management System
![Imgur](https://i.imgur.com/EN74XdD.png)

## Table of Contents
1. [Technologies Used](#Technologies)
2. [Project Description](#Description)
3. [Installation and Setup](#Install/Setup)
4. [Future Roadmap](#Roadmap)

## Technologies
Languages: 
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white) ![Rust](https://img.shields.io/badge/rust-%23000000.svg?style=for-the-badge&logo=rust&logoColor=white)

Databases: 
![SQLite](https://img.shields.io/badge/sqlite-%2307405e.svg?style=for-the-badge&logo=sqlite&logoColor=white)

Miscellaneous: 
![Obsidian](https://img.shields.io/badge/Obsidian-%23483699.svg?style=for-the-badge&logo=obsidian&logoColor=white) ![Ubuntu](https://img.shields.io/badge/Ubuntu-E95420?style=for-the-badge&logo=ubuntu&logoColor=white)

## Description
My first major project committed to GitHub, an inventory management system that a company could use in order to keep track of stock in a warehouse. I kept in mind the specific data points that a large system such as this might require, and have tried to create a database using an efficient layout. 

## Install/Setup
1. To get started with the project, clone it to your chosen folder.
```
git clone https://github.com/LewisRye/inventory-system.git
```
2. Navigate to the *'api'* folder and compile / run the server using Rust's `cargo`.
```
cd inventory-system/api/
```
```
cargo b
```
```
cargo r
```
3. **Windows Only:** Navigate to the *'client'* folder and open the `Inventory.sln` file, from here, you can use any .NET IDE of your choice to build and run the Windows Forms project.

***Please note that in a future release a built `.exe` file will be readily available.***

## Roadmap
For the future, here is what is planned:

| Feature            | Description                                                                                                                            | Status               |
| ------------------ | -------------------------------------------------------------------------------------------------------------------------------------- | -------------------- |
| `.exe` file        | Building an `.exe` file for ARM and 64-bit versions of Windows in order to be able to run the client program without building it.      | ✅ In Progress        |
| More endpoints     | Some endpoints are still not complete, for example, you cannot yet update the stock once it has run low, using the client application. | ✅ In Progress        |
| PayPal sandbox     | Introducing the PayPal sandbox to the API, such that a web store could be made that links to this inventory management system.         | ❌ Currently Planning |
| Real time database | Using a real time database such as Google's Firebase in order to make the application always contain the latest information.           | ❌ Currently Planning |
