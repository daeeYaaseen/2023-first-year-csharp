/*using System;  //use classes from System namespace
               // blankline - makes code more readable
namespace HelloWorld  //namespace - used to organise code - container for classes and other namespaces
{              //curlybraces = marks beginning and end of block of code
    class Program   //class - container for data + methods - brings functionality to program. every line of code that runs in C# must be inside a class. this example - named class Program
    {
        static void Main(string[] args) //Main method - any code inside its {} will run 
        {
            Console.WriteLine("Hello World!"); //Console is a class fo the System namespace, which has Writeline() method used to print text

            // if omit the using System line, you have to write System.Console.Writeline() to print text

        }
            //NOTE: every C# statement ends with semicolon;
            //NOTE: C# case sensitive - MyClass != myclass
     
        //Write() similar to WriteLine()
        //only difference is that it doesnt enter new line at end of output
    }
}*/
//comments
/* multiline comments 
  */
/* The code below will print the words Hello World
to the screen, and it is amazing */


//short comments
/* long
 * comments*/

//method - a code block that contains a series of statements

//class -a data structure that may contain data members (constants and fields),
//  function members (methods, properties, events, indexers, operators, instance constructors, finalizers, and static constructors),
//  and nested types


//C# VARIABLES 
// containers for holding data values

// int - stores integers - whole numbers, w/o decimals ---- 123, -123
// double - stores floating point numbers, with decimals ---- 19.99, -19.99
// char - stores single characters, surr by single quotes ---- 'a', 'B'
// string - stores text, surr by double quotes ---- "Hello World"
// bool - stores values two states ---- true, false

//SYNTAX

// ***type variableName = value;***
// type -- c# type (int, string)
// variableName -- name of variable (x or name)
// = -- assign values to variable


// create variable called name of type string and assign it the value "john":

using System.Linq.Expressions;

string name = "John";
Console.WriteLine(name);

// create variable called myNum of type int and assign value 15

int myNum = 15;
Console.WriteLine(myNum);

// can also declare a variable w/o assigning value and assign value later

int myNum2;
myNum2 = 16;
Console.WriteLine(myNum2);

// NOTE: ASSIGN NEW VALUE TO EXISTING VARIABLE - OVERWRITES PREV VALUE

//change value of myNum to 20

int myNum3 = 15;
myNum3 = 20; // myNum is now 20
Console.WriteLine(myNum3);

// other types:

int myNum4 = 155;
double myDoubleNum = 5.99D;
char myLetter = 'A';
bool myBool = false;
string myString = "Hello";

//CONSTANTS
// const keyword - unchangeable and read-only
// very useful when you want variable to always store same value
// so that code wont mess up
// eg often referred to as constant - PI (3.14159)

// NOTE: you cannot declare a constant variable without assigning value
//  if you do, an error will occur - const req a value to be provided

const int myNum5 = 15;
//myNum5 = 20; error

// C# DISPLAY VARIABLES

// writeLine() - display variable values to console window

// combine both text and variable - +

string name1 = "john";
Console.WriteLine("Hello " + name);

// + to add variable to variable 

string firstName = "John";
string lastName = "Doe";
string fullName = firstName + lastName;
Console.WriteLine(fullName);

// numeric values - + ,mathematical operators - int variables

int x = 5;
int y = 10;
Console.WriteLine(x + y); // print value of x + y

//MULTIPLE VARIABLES

// declare more than one variable of SAME TYPE, use comm separated list

int x = 5, y = 6, z = 50;
Console.WriteLine(x + y + z);

// assign SAME value to MULTIPLE variables in one line

int x, y, z;
x = y = z = 50;
Console.WriteLine(x + y + z);

//C# IDENTIFIERS

// all variables must be identified with unique names
// unique names - identifiers 
//identifiers - short names (x and y)
// or more descriptive names (age, sum, totalVolume)
//NOTE: reccom. to use descriptive names in order to create understandable and maintainable code


// good
int minutesPerHour = 60;

//okay, not easy to understand what 'm' is
int , m = 60;

//GENERAL RULES FOR NAMING VARIABLES

// letters, digits, underscore
//must begin with a letter
// should start with lowercase and cant contain whitespace
//case sensitive myVar != myvar
// reserved words (int, double) cant be used as names

//C# DATA TYPES
int myNum = 5; // integer - whole number
double myDoubleNum = 5.99D; // floating point number
char myLetter = 'A'; // character
bool myBool = true; // boolean
string myText = "Hello"; // string

// DATA TYPE SPECIFIES SIZE AND TYPE OF VARIABLE VALUES

// important to use correct data type for corr variable
// avoid errors, save time and memory
// makes code maintainable and readable


// int - 4 bytes - stores whole numbers  -2,147,483,648 to 2,147,483,647
// long - 8 bytes - stores whole numbers Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
// float - 4 bytes - stores fractional numbers. sufficient for storing 6 to 7 decimal points
// double = 8 bytes - stores fractional numbers - 15 decimal digits
// bool - 1 bit - true or false
// char - 2 bytes - single character/letter, surr single quotes
//string - 2 bytes per character - Stores a sequence of characters, surrounded by double quotes



//NUMBERS

//integer stores whole numbers, +/- w/o decimals
// valid types int and long
// type to use - depends on numeric value

//floating point numbers - fractional part, one or more decimals
//valid types float and double

// most used for numbers - int
// most used for floating point numbers - double


//INTEGER TYPES

//int =- -2147483648 to 2147483647.
int myNum100 = 100000;
Console.WriteLine(myNum100);

//long -- -9223372036854775808 to 9223372036854775807
//NOTE - end with "L"

long myNum12 = 15000000000L;
Console.WriteLine(myNum12);


//FLOATING POINT TYPES
//number with decimal - 9.99 or 3.1415

//float and double 
// F - float
// D - double

float myNumF= 5.75F;
Console.WriteLine(myNumF);

double myNumD = 19.99D;
Console.WriteLine(myNumD);

//float of double 

//precision of floating point value indicates how many digits the value can have after decimal point

//precision of float - 6/7 decimal digits
//precision of double - 15 digits
//SAFER to use double for most calculations 


//Scientific numbers

//floating point number can also be a scientific number with an "e" - indicate power of 10

float f1 = 35e3F;
double d1 = 12E4D;
Console.WriteLine(f1);
Console.WriteLine(d1);


//Booleans
//true / false

bool isCSharpFun = true;
bool isFishTasty = false;
Console.WriteLine(isCSharpFun); // outputs True
Console.WriteLine(isFishTasty); // outputs False

//boolean used for conditional testing

//Characters - char data type

//store single characters
//  surrounded by single quotes - 'A' or 'c'

char myGrade = 'A';
Console.WriteLine(myGrade);

//Strings - string data type

//store sequence of characters (text)
//  surrounded by double quotes

string greeting = "Hello";
Console.WriteLine(greeting);



//C# TYPE CASTING

// type casting is when you assign a value of one data type to another data type

// TWO TYPES
    // IMPLICIT - AUTOMATICALLY - convert smaller type to larger type size
                // char -> int -> long -> float -> double
    //EXPLICIT - MANUALLY - convert larger type to smaller type 
                // double -> float -> long -> int -> char

//Implicit Casting

// 


using System

namespace a

{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }
}








