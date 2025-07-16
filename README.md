# 🧪 Potion Brewery Simulation System

**A gamified desktop application to manage potion recipes, ingredients, and simulate potion brewing — built with WinForms and SQLite.**

---

## 📦 Project Overview

As a master potion brewer, you’ve been tasked with managing a magical potion brewery. This WinForms-based system lets users manage ingredients, create recipes, simulate potion brewing, and track custom-brewed potions with detailed stats and analytics.

---

## 🧰 Tech Stack

- **Language**: C#
- **UI Framework**: Windows Forms
- **Database**: SQLite (via Entity Framework Core)
- **ORM**: Entity Framework Core
- **IDE**: Visual Studio

---

## 🧙‍♂️ Features

### 🧪 Recipe Management
- Add, edit, view, and delete potion recipes.
- Each recipe includes:
  - Name & description
  - Brewing time (seconds)
  - A list of required ingredients and quantities
- UI supports ingredient selection and quantity input.

### 🌿 Ingredient Management
- Add new ingredients.
- Edit stock quantity and minimum threshold.
- Automatically checks stock levels before brewing.
- Prevent deletion if the ingredient is used in any recipe.

### ⚗️ Brewing Potion
- Select a recipe and brew it.
- Simulated with a progress bar and timer.
- Checks ingredient availability.
- Deducts used ingredients after brewing.

### ✨ Customize Brewed Potions
- Name and define attributes for each brewed potion.
- Brewed potions are saved and displayed.
- Includes brew date and recipe reference.

### 📊 Dashboard & Reports
- Summary of brewing activity:
  - Most brewed potions
  - Most used ingredients
  - Brewing frequency over time

---
## 🚀 Getting Started

### 1. Download & Run

1. [Download the latest release](https://github.com/DuanWong/potion-brewery-simulation-system/releases)  
2. Extract the ZIP file
3. Make sure the following files are in the **same folder**:
   - `PotionBrewerySimulationSystem.exe`
   - `e_sqlite3.dll`
4. Double-click `PotionBrewerySimulationSystem.exe` to launch the program

### 2. Data Persistence
A PotionBrewery.db file will be created automatically on first run.

All saved data will store in this local database.

Deleting PotionBrewery.db will erase all saved data.

