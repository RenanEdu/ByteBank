# ByteBank Project

## Overview
ByteBank is a simple banking application that allows for the management of employees and their respective bonuses. The application includes a class structure that defines various types of employees, including directors, and calculates their bonuses based on their salaries.

## Files
- **Funcionarios/Diretor.cs**: This file defines the `Diretor` class, which inherits from the `Funcionario` class. It includes a method `GetBonificacao` that returns the salary of the director as their bonus.

## Installation Instructions
1. Clone the repository:
   ```
   git clone https://github.com/yourusername/ByteBank.git
   ```
2. Navigate to the project directory:
   ```
   cd ByteBank
   ```
3. Open the project in your preferred IDE.

## Usage Examples
To create a new director and calculate their bonus, you can use the following code snippet:

```csharp
Diretor diretor = new Diretor();
diretor.Salario = 10000; // Set the salary
double bonus = diretor.GetBonificacao(); // Get the bonus
Console.WriteLine($"The bonus for the director is: {bonus}");
```

## Contributing
If you would like to contribute to this project, please fork the repository and submit a pull request with your changes.

## License
This project is licensed under the MIT License. See the LICENSE file for more details.
