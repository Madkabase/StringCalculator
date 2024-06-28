# Text Calculator

This project implements a simple text calculator with a .NET Core backend API and a HTML/JavaScript frontend.

## Prerequisites

- .NET Core SDK (version 6 or later)
- A web browser
- xUnit NuGet packages

## Running the Application

1. Clone this repository to your local machine.

2. Open a terminal and navigate to the project directory.

3. Run the following command to start the backend API:

   ```
   dotnet run
   ```

   This will start the API on `https://localhost:7149` (and `http://localhost:5027`).

4. Open a web browser and navigate to `https://localhost:7149/index.html`. You should see the Text Calculator interface.

5. Enter numbers separated by commas in the input field and click "Calculate" to see the result.

## Running Tests

To run the unit tests for the TextCalculator, use the following command in the terminal:

```
dotnet test
```

This will run all the tests in the `TextCalculatorTests` class.

## Project Structure

- `TextCalculator.cs`: Contains the main logic for adding numbers.
- `CalculatorController.cs`: API controller that exposes the Add method.
- `index.html`: Frontend interface for the calculator.
- `TextCalculatorTests.cs`: Unit tests for the TextCalculator class.

## Notes

- The calculator can handle an unknown number of arguments.
- Empty input will return "0".
- Negative numbers are not allowed and will throw an exception.
- A missing number in the last position (e.g., "1,2,") is considered invalid input and will throw an exception.
- Invalid Format Error is throw If:
   - Number contains other characters (e.g.," &, ,/").
   - Number contains letters(e.g.,"a,b,c")
- In the FrontEnd shows the following new features:
  - Exception Tracking Table with "Missing Number", "Negative Number", "Invalid Format", and "Correct Number"
  - Reset Button to clears all recorded and resets the table.
  - The Table displays the exception types with their respective color(green,red,yellow, orange) 
 

 