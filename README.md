# Gym Workout Diary & Tracker

![C#](https://img.shields.io/badge/C%23-239120?style=flat-square&logo=c-sharp&logoColor=white)
![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-5C2D91?style=flat-square&logo=.net&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Platform-Windows_Forms-blue?style=flat-square)
![IDE](https://img.shields.io/badge/IDE-Visual_Studio_2022-5C2D91?style=flat-square&logo=visual-studio&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-green?style=flat-square)

## Project Overview

**Gym Workout Diary & Tracker** is a Windows Forms application developed to organize workout routines and track fitness progress. Created as a university coursework, this project marks my first experience building a complete software solution using C# and .NET.

The primary goal was to transition from theoretical knowledge to a functional application, strictly adhering to **Object-Oriented Programming (OOP)** principles and implementing a **Layered Architecture**.

---

## 📹 Video Demonstration

A walkthrough of the codebase, architecture and functionality is available
[here](https://drive.google.com/file/d/1gC_xD6Q1ROvxPIvTK2V0s_rPIf_o1qRK/view?usp=sharing)

---

## 🏗️ Architecture & Design

The solution follows a strict separation of concerns, dividing the application into two distinct layers to ensure scalability

```text
Gym Workout Diary & Tracker
├── 📂 Domain  (Business Logic Layer)
│   ├── BmiCalculatorService.cs   # Static logic for BMI calculation
│   ├── Exercise.cs               # Abstract base class and derived 'StrengthExercise'/'CardioExercise' classes
│   ├── MuscleGroup.cs            # Enum for workout types (Push, Pull, Legs, etc.)
│   ├── Trackable.cs              # Interface defining the GetProgress() method
│   ├── WorkoutCompletedEventArgs.cs # Custom event data for completion events
│   ├── WorkoutDiary.cs           # Main container logic
│   ├── WorkoutEntry.cs           # Represents a single workout session
│   └── WorkoutStatus.cs          # Enum for session status (Planned/Completed)
│
└── 📂 UI      (Presentation Layer)
    ├── MainForm.cs               # Dashboard & Main navigation
    ├── AddWorkoutForm.cs         # Dialog window for adding new workout sessions
    ├── AddExerciseForm.cs        # Dialog window for exercises
    └── BmiCalculatorForm.cs      # UI window for BMI calculation
```

### ⚙️ Technical Implementation Details

This project demonstrates the practical application of core OOP pillars and C# patterns:

1.  **Encapsulation & Data Integrity:**
    * Key properties use restricted accessors (e.g., `public WorkoutStatus Status { get; private set; }` in `WorkoutEntry`) to prevent invalid state changes.
    * State transitions are handled via specific business methods like `MarkCompleted()`, ensuring proper logic execution.

2.  **Interfaces & Abstraction:**
    * The `Trackable` interface defines a contract for monitoring progress (`GetProgress()`).
    * Both the individual `WorkoutEntry` (0% or 100%) and the main `WorkoutDiary` (average of all entries) implement this interface, demonstrating how different objects can share behavior.

3.  **Polymorphism & Inheritance:**
    * The abstract base class `Exercise` defines the core structure.
    * Derived classes `StrengthExercise` and `CardioExercise` override the abstract `GetVolume()` method.
        * *Strength:* Calculates based on Sets × Reps × Weight.
        * *Cardio:* Calculates based on Duration × Sets.
    * The UI treats all objects simply as `Exercise`, allowing for a unified list display via the overridden `ToString()` method.

4.  **Event-Driven Architecture:**
    * The application utilizes custom events to handle logic flow. The `WorkoutDiary` exposes a `WorkoutCompleted` event, which passes data via a custom `WorkoutCompletedEventArgs` class when a session is finished.

5.  **Static Utilities:**
    * Health calculations are isolated in the `BmiCalculatorService` helper class, keeping the domain models clean.

## Key Features

| Feature | Description |
| :--- | :--- |
| **Workout Management** | Create, view, delete, and mark workouts as completed. Records are automatically sorted chronologically using LINQ. |
| **Dynamic UI** | The *Add Exercise* interface adapts in real-time. Selecting "Cardio" hides irrelevant fields (like Reps) and updates labels to reflect time-based metrics. |
| **BMI Calculator** | A dedicated module for calculating Body Mass Index with visual color-coding based on health categories. |
| **Volume Tracking** | Automatic calculation of total training volume, adapting units (kg vs. minutes) based on the workout type. |
| **Visual Progress Tracking** | A real-time progress bar that visualizes overall diary completion. It calculates the average progress across all entries using the `Trackable` interface logic. |

## 📸 Screenshots

### Main Dashboard
<img width="504" height="346" alt="image" src="https://github.com/user-attachments/assets/29a73275-48fb-42e2-a315-b82a3811e7e0" />

### Adding a Workout & an Exercise
<img width="504" height="282" alt="image" src="https://github.com/user-attachments/assets/6be25d3d-24ad-478c-bf17-2ce6fcd0bbda" />


### BMI Calculator
<img width="864" height="232" alt="image" src="https://github.com/user-attachments/assets/a2578e8e-d14a-42d5-9b38-408758994e17" />

---

## 👨‍💻 Author

* **Ivan Tenev Ivanov**
* Faculty Number: F115436
* *First steps in .NET Development*

---
