# Basic_Exercises_LinQ


### OPERADORES DE FILTRADO Y DE ELEMENTO:

Ejercicio 1: 
Find the first element in the array that starts with 'o':

string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };


Ejercicio 2: 
Return the first element of the sequence:

int[] numbers = { };


Ejercicio 3: 
Find all elements of an array with a value less than 5.

int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };


Ejercicio 4: 
Returns digits whose name is shorter than their value.

string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };


Ejercicio 5: 
Retrieve the second number greater than 5 from an array

int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };


### EJERCICIOS DE CUANTIFICADORES:

Ejercicio 6: 
Return if there is some word in the list that contains 'ei'

string[] words = { "believe", "relief", "receipt", "field" };

Ejercicio 7: 
Determine whether an array contains only odd numbers.

int[] numbers = { 1, 11, 3, 19, 41, 65, 19 };


### EJERCICIOS DE ORDENACIÓN:

Ejercicio 8:
Sort a list of words alphabetically

string[] words = { "cherry", "apple", "blueberry" };


Ejercicio 9:
Sort a list of words by length

string[] words = { "cherry", "apple", "blueberry" };



Ejercicio 10: 
Use order descending to sort a list of doubles from highest to lowest

double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };


Ejercicio 11: 
Order a list of digits, first by length of their name, and then alphabetically by the name itself.

string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };


###EJERCICIOS DE AGRUPACIÓN:

Ejercicio 12: 
Uses group by to partition a list of numbers by their remainder when divided by 5

int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

Ejercicio 13: 
Uses group by to partition a list of words by their first letter.

string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };


### EJERCICIOS DE AGREGACIÓN:

Ejercicio 14: 
Uses Average to get the average of all numbers in an array

int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };


Ejercicio 15: 
uses Average to get the average length of the words in the array

string[] words = { "cherry", "apple", "blueberry" };


Ejercicio 16:
Uses Max to get the highest number in an array

int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };


Ejercicio 17: 

Uses Max to get the length of the longest word in an array.

string[] words = { "cherry", "apple", "blueberry" };


Ejercicio 18: 
Uses Min to get the lowest number in an array.

int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };



Ejercicio 19: 
Uses Min to get the length of the shortest word in an array

string[] words = { "cherry", "apple", "blueberry" };


Ejercicio 20: 
Uses Sum to get the total of the numbers in an array.
int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

Ejercicio 21: 
Uses Sum to get the total number of characters of all words in the array.
string[] words = { "cherry", "apple", "blueberry" };


Ejercicio 22: 
Uses Count to get the number of odd ints in the array.

int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };


###EJERCICIOS DE OPERACIONES SOBRE CONJUNTOS:

Ejercicio 23: 
Get the number of unique factors of 300.

int[] factorsOf300 = { 2, 2, 3, 5, 5 };

Ejercicio 24:

Remove duplicate elements in a sequence of factors of 300.

int[] factorsOf300 = { 2, 2, 3, 5, 5 };

Ejercicio 25: 
Create one sequence that contains the unique values from both arrays

int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
int[] numbersB = { 1, 3, 5, 7, 8 };

Ejercicio 26: 
Create one sequence that contains the common values shared by both arrays

int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
int[] numbersB = { 1, 3, 5, 7, 8 };


Ejercicio 27: 
Create a sequence that contains the values from numbersA that are not also in numbersB

int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
int[] numbersB = { 1, 3, 5, 7, 8 };


###EJERCICIOS DE SELECT.

Ejercicio 28: 
Produce a sequence of ints one higher than those in an existing array of ints

int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

Ejercicio 29: 
Produce a sequence of strings representing the text version of a sequence of ints

int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };


Ejercicio 30: 
produce a sequence of the uppercase and lowercase versions of each word in the original array

string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

Ejercicio 31: 
produce a sequence containing text representations of digits and whether their length is even or odd
int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

Ejercicio 32:
combines select and where to make a simple query that returns the text form of each digit less than 5.

int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
