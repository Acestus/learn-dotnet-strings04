/* 
Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
*/

using System;
using System.Collections.Generic;

Console.Write("Enter a few words separated by a space: ");
var input = Console.ReadLine().Split(" ");
var PascalCase = "";
for (var i = 0; i < input.Length; i++)
{
    var word = input[i].ToLower();
    var wordPascalCase = char.ToUpper(word[0]) + word.Substring(1);
    PascalCase += wordPascalCase;
}
Console.WriteLine(PascalCase);