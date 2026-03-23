// ========================================
// LESSON 1: Variables & Data Types
// ========================================

Console.WriteLine("=== Variables & Data Types ===\n");

// Integer - whole numbers
int age = 25;
Console.WriteLine($"Age: {age}");

// String - text
string name = "John Doe";
Console.WriteLine($"Name: {name}");

// Double - decimal numbers
double height = 5.9;
Console.WriteLine($"Height: {height} feet");

// Boolean - true or false
bool isStudent = true;
Console.WriteLine($"Is Student: {isStudent}");

// Character - single letter
char grade = 'A';
Console.WriteLine($"Grade: {grade}");

// ===== EXERCISE 1.1 =====
Console.WriteLine("\n--- Exercise 1.1: Create Your Profile ---");

string yourName = "Your Name"; // TODO: Change this
int yourAge = 0;              // TODO: Change this
string yourCity = "Your City"; // TODO: Change this
double gpa = 0.0;              // TODO: Change this

Console.WriteLine($"\nProfile:");
Console.WriteLine($"Name: {yourName}");
Console.WriteLine($"Age: {yourAge}");
Console.WriteLine($"City: {yourCity}");
Console.WriteLine($"GPA: {gpa}");

// ===== EXERCISE 1.2 =====
Console.WriteLine("\n--- Exercise 1.2: Variable Operations ---");

int num1 = 10;
int num2 = 20;
int sum = num1 + num2;

Console.WriteLine($"Number 1: {num1}");
Console.WriteLine($"Number 2: {num2}");
Console.WriteLine($"Sum: {sum}");

Console.WriteLine("\n✅ Lesson Complete! Move to the next file.");
