# DCIT 318 Assignment 1 - C# Console Applications

This repository contains three C# console applications developed as part of DCIT 318 Assignment 1.

## Applications

### 1. Grade Calculator (`GradeCalculator.cs`)
A program that converts numerical grades (0-100) to letter grades using the standard grading scale:
- **A**: 90 and above
- **B**: 80-89
- **C**: 70-79
- **D**: 60-69
- **F**: Below 60

**Features:**
- Input validation for grade range (0-100)
- Error handling for invalid inputs
- Clear user interface with detailed feedback

### 2. Ticket Price Calculator (`TicketPriceCalculator.cs`)
A movie theater ticket pricing system that calculates ticket prices based on customer age:
- **Regular Price**: GHC10
- **Discounted Price**: GHC7 (for children ≤12 or seniors ≥65)

**Features:**
- Age-based pricing logic
- Input validation for non-negative ages
- Clear category identification (Child, Senior, Regular)
- Error handling for invalid inputs

### 3. Triangle Type Identifier (`TriangleTypeIdentifier.cs`)
A program that identifies triangle types based on the lengths of three sides:
- **Equilateral**: All three sides are equal
- **Isosceles**: Two sides are equal
- **Scalene**: No sides are equal

**Features:**
- Triangle validity checking using triangle inequality theorem
- Floating-point comparison with epsilon tolerance
- Input validation for positive side lengths
- Comprehensive error handling and user feedback

## How to Run

Each application is a standalone C# console program. To run any of them:

1. **Using Visual Studio:**
   - Open the `.cs` file in Visual Studio
   - Right-click and select "Run" or press Ctrl+F5

2. **Using Command Line:**
   ```bash
   csc GradeCalculator.cs
   GradeCalculator.exe
   
   csc TicketPriceCalculator.cs
   TicketPriceCalculator.exe
   
   csc TriangleTypeIdentifier.cs
   TriangleTypeIdentifier.exe
   ```

3. **Using .NET CLI:**
   ```bash
   dotnet run --source GradeCalculator.cs
   dotnet run --source TicketPriceCalculator.cs
   dotnet run --source TriangleTypeIdentifier.cs
   ```

## Requirements Met

✅ Created three separate C# console applications  
✅ Grade Calculator with proper grading scale implementation  
✅ Ticket Price Calculator with age-based discounting  
✅ Triangle Type Identifier with geometric validation  
✅ Each task committed separately to main branch  
✅ Proper error handling and input validation  
✅ Clean, readable code with documentation  

## Author
Student ID: 11041617  
Course: DCIT 318  
Assignment: Assignment 1
