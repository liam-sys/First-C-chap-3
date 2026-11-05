/*
Chap 3 Summary (Operators and Expressions)
-This chapter basically covers operators and its types and how to use them in expressions. 
-the main things i covered in this chapter are:
1. What operators are in C#:
   I learned the operators are symbols that perform operations on operands(variables and values).
2. Operator categories:
   I learned that operators are categorized into different types such as arithmetic, binary, logical, assignment, comparison, type conversion and more.
3. Operator Precedence:
   I learned that operator precedence determines the order in which operators are evaluated in an expression. Operators with higher precedence are evaluated before those with lower precedence.
4. Operator Associativity:
   I learned that operator associativity determines the order in which operators of the same precedence are evaluated in an expression. Most operators have left-to-right associativity, while some have right-to-left associativity.
5. Arithmetical Operators:
   I learned how to use arithmetic operators such as addition, subtraction, multiplication, division, and modulus to perform mathematical operations on numeric values.
6. Logical Operators:
   I learned how to use logical operators such as AND(&&), OR(||), and NOT(!) to perform logical operations on boolean values.
7. I was reminded of the laws of De Morgan and how to use them to       simplify logical expressions.
8. I learnt how to concatenate strings using the + operator.
9. Bitwise Operators:
   I learned how to use bitwise operators such as AND(&), OR(|), XOR(^), left shift(<<), and right shift(>>) to perform operations on the individual bits of integer values.
10. Comparison Operators:
   I learned how to use comparison operators such as equal to(==), not equal to(!=), greater than(>), less than(<), greater than or equal to(>=), and less than or equal to(<=) to compare values and return boolean results.
11. Assignment Operators:
   I learned how to use assignment operators such as =, +=, -=, *=, /=, and %= to assign values to variables and perform operations on them.
12. Type Conversion and Casting:
    I learned how to use type conversion operators such as implicit and explicit conversion to convert values from one data type to another.
*/


// CHAPTER 3 - OPERATORS AND EXPRESSIONS (short snippet)
using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Arithmetic operators + - * / %
        int a = 17, b = 5;
        Console.WriteLine("a + b = " + (a + b));        // 22
        Console.WriteLine("a / b = " + (a / b));        // 3   (int / int drops the decimals)
        Console.WriteLine("a / 5.0 = " + (a / 5.0));    // 3.4 (one decimal operand gives a real result)
        Console.WriteLine("a % b = " + (a % b));        // 2   (remainder)

        // 2. Increment and decrement
        int counter = 5;
        counter++;                                       // 6
        Console.WriteLine(counter++);                    // prints 6, THEN becomes 7
        Console.WriteLine(++counter);                    // becomes 8, THEN prints 8

        // 3. Assignment operators
        int total = 10;
        total += 5;                                      // total = total + 5 = 15
        total *= 2;                                      // total = total * 2 = 30

        // 4. Comparison operators (result is always bool)
        Console.WriteLine((a > b) + " " + (a == b) + " " + (a != b));   // True False True

        // 5. Logical operators
        bool isStudent = true, hasMoney = false;
        Console.WriteLine((isStudent && hasMoney) + " " + (isStudent || hasMoney)
            + " " + !isStudent + " " + (isStudent ^ hasMoney));          // AND, OR, NOT, XOR

        // 6. Bitwise operators (work on binary digits): 5 = 0101, 3 = 0011
        Console.WriteLine((5 & 3) + " " + (5 | 3) + " " + (5 ^ 3) + " " + (~5));   // 1 7 6 -6
        Console.WriteLine((5 << 1) + " " + (5 >> 1));    // 10 2 (shift left = x2, shift right = /2)

        // 7. Conditional (?:) and null-coalescing (??) operators
        string status = a >= 18 ? "adult" : "minor";     // condition ? ifTrue : ifFalse
        string nickname = null;
        string shown = nickname ?? "Guest";              // use "Guest" when nickname is null

        // 8. Precedence: * / % before + -, and parentheses come first
        Console.WriteLine((2 + 3 * 4) + " " + ((2 + 3) * 4));            // 14 20

        // 9. String concatenation gotcha (evaluated left to right)
        Console.WriteLine("Total: " + 5 + 3);            // Total: 53
        Console.WriteLine("Total: " + (5 + 3));          // Total: 8

        // 10. Type conversion
        long bigLong = a;                                // implicit: small type to bigger type, no data lost
        double pi = 3.99;
        int cut = (int)pi;                               // explicit cast: cuts decimals -> 3
        int rounded = Convert.ToInt32(pi);               // Convert rounds -> 4
        int parsed = int.Parse("123");                   // text to number
        int max = int.MaxValue;
        max = max + 1;                                   // overflow: wraps to -2147483648
        Console.WriteLine(cut + " " + rounded + " " + parsed + " " + max);

        // 11. Math class
        double x = -3.14, z = 4.9;
        Console.WriteLine(Math.Pow(x, 2) + " " + Math.Abs(x) + " " + Math.Sqrt(Math.Abs(x)));
        Console.WriteLine(Math.Round(x) + " " + Math.Ceiling(x) + " " + Math.Floor(x));   // -3 -3 -4
        Console.WriteLine(Math.Max(x, z) + " " + Math.Min(x, z));                        // 4.9 -3.14

        Console.WriteLine(total + " " + status + " " + shown + " " + bigLong);
        Console.ReadKey();
    }
}
