using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public interface IHardExercises
    {
        // Given a string, reverse all the words which have odd length.The even length words are not changed.
        // There is exactly one space between each word and no punctuation is used.
        string Exercise1(string strArr);

        //Create a function to check if a candidate is qualified in an imaginary coding interview of an imaginary tech startup.
        //The criteria for a candidate to be qualified in the coding interview is:

        //The candidate should have complete all the questions.
        //The maximum time given to complete the interview is 120 minutes.
        //The maximum time given for very easy questions is 5 minutes each.
        //The maximum time given for easy questions is 10 minutes each.
        //The maximum time given for medium questions is 15 minutes each.
        //The maximum time given for hard questions is 20 minutes each.

        //If all the above conditions are satisfied, return "qualified", else return "disqualified".
        //You will be given an array of time taken by a candidate to solve a particular question and the total time taken by the candidate to complete the interview.
        //Given an array, in a true condition will always be in the format [very easy, very easy, easy, easy, medium, medium, hard, hard].
        //The maximum time to complete the interview includes a buffer time of 20 minutes.
        //Try to solve the problem using only array methods.
        string Exercise2(int[] arr, int tot);


        //Write a function that takes an integer i and returns a string with the integer backwards followed by the original integer.
        string Exercise3(int i);

        //There are three cups on a table, at positions A, B, and C.At the start, there is a ball hidden under the cup at position B.
        //However, I perform several swaps on the cups, which is notated as two letters. For example, if I swap the cups at positions A and B,
        //I could notate this as AB or BA.
        //Create a function that returns the letter position that the ball is at, once I finish swapping the cups. The swaps will be given to you as an array.
        //A swap could be notated in two different ways, since both ways end up with the same outcome.
        //All swaps will be notated as capital letters and will be valid.
        //You cannot swap a cup with itself.

        string Exercise4(string[] swaps);


        //Create a function that determines whether elements in an array can be re-arranged to form a consecutive list of numbers
        //where each number appears exactly once.
        bool Exercise5(int[] arr);

        //Create a function that takes an array arr and a number n and returns
        //an array of two integers whose product is that of the number n.
        int[] Exercise6(int[] arr, int n);

        //Create a function that takes in n, a, b and returns the number of
        //positive values raised to the nth power that lie in the range[a, b], inclusive.
        int Exercise7(int power, int min, int max);

        //Given an integer, create a function that returns the next prime.
        //If the number is prime, return the number itself.
        int Exercise8(int num);

        //Someone has attempted to censor my strings by replacing every vowel with a*, l* k* th* s.
        //Luckily, I've been able to find the vowels that were removed.
        string Exercise9(string txt, string vowels);

        //Carlos is a huge fan of something he calls smooth sentences.
        //A smooth sentence is one where the last letter of each word is identical to the first letter the following word(and not case sensitive, so "A" would be the same as "a").
        //The following would be a smooth sentence "Carlos swam masterfully" because "Carlos" ends with an "s" and swam begins with an "s" and swam ends with an "m" and masterfully begins with an "m".
        //Create a function that determines whether the input sentence is a smooth sentence, returning a boolean value true if it is, false if it is not.
        bool Exercise10(string sentence);

        //Create a function that determines whether a string is a valid hex code.
        //A hex code must begin with a pound key # and is exactly 6 characters in length. Each character must be a digit from 0-9 or an alphabetic character from A-F. All alphabetic characters may be uppercase or lowercase.
        bool Exercise11(string str);

        //Create a function to return the Nth number in the Fibonacci sequence as a string.
        string Exercise12(int n);

        //Given a positive number x, if all the positive divisors of x(excluding x) add up to x, then x is said to be a perfect number.
        //For example, the set of positive divisors of 6 excluding 6 itself is (1, 2, 3). The sum of this set is 6. Therefore, 6 is a perfect number.
        //Given a positive number x, if all the positive divisors of x add up to a second number y, and all the positive divisors of y add up to x, then x and y are said to be a pair of amicable numbers.
        //Create a function that takes a number and returns "Perfect" if the number is perfect, "Amicable" if the number is part of an amicable pair, or "Neither".
        string Exercise13(int num);

        //Create a function that takes a strings characters as ASCII and returns each characters
        //hexadecimal value as a string.
        string Exercise14(string inputword);

        //This is a reverse coding challenge.Normally you're given explicit directions with how to create a function.
        //Here, you must generate your own function to satisfy the relationship between the inputs and outputs.
        //Your task is to create a function that, when fed the inputs below, produce the sample outputs shown.
        //832 ➞ 594
        //51 ➞ 36
        //7977 ➞ 198
        //1 ➞ 0
        //665 ➞ 99
        int Exercise15(int num);

        //This is a reverse coding challenge.Normally you're given explicit directions with how to create a function.
        //Here, you must generate your own function to satisfy the relationship between the inputs and outputs.
        //Your task is to create a function that, when fed the inputs below, produce the sample outputs shown.
        //Examples
        //"A4B5C2" ➞ "AAAABBBBBCC"
        //"C2F1E5" ➞ "CCFEEEEE"
        //"T4S2V2" ➞ "TTTTSSVV"
        //"A1B2C3D4" ➞ "ABBCCCDDDD"
        string Exercise16(string str);

        // Create a function Brackets() that takes a string and checks that the brackets
        // in the math expression are correct.The function should return true or false.
        // The string may not contain brackets, then return true.
        // String may contain spaces.
        // The string may be empty.
        bool Brackets(string str);

        //Given the complete factorization of a number, create a function
        //that converts this array of factors to a string.
        //To illustrate: 24's complete factorization is [2, 2, 2, 3], which should be converted to "2^3 x 3".
        string StringFactor(int[] arr);

        //Legendre's formula finds the exponent of the largest power of some prime p that divides
        //(is a factor of) the factorial of some number n.
        //The formula returns the sum of many fractions(rounded down) with n as the numerator and a
        //steadily increasing power of p as the denominator, stopping when it exceeds the numerator.
        // link to the question: https://edabit.com/challenge/Ktr9CQidBThMSMttH
        int Legendre(int p, int n);

        //Joseph is in the middle of packing for a vacation.He's having a bit of trouble finding all of his socks, though.
        //Write a function that returns the number of sock pairs he has. A sock pair consists of two of the same letter, such as "AA". The socks are represented as an unordered sequence.
        //        Examples
        //SockPairs("AA") ➞ 1
        //SockPairs("ABABC") ➞ 2
        //SockPairs("CABBACCC") ➞ 4
        int SockPairs(string socks);

        //Every quadratic curve y = a x² + b x + c has a vertex point:
        //the turning point where the curve stops heading down and starts going up.
        //Given the values a, b and c, you need to return the coordinates of the vertex.
        //Return your answers rounded to 2 decimal places.

        //Examples
        //FindVertex(1, 0, 25)  ➞ [0, 25]
        //The vertex of y=x²+25 is at (0, 25).

        //FindVertex(-1, 0, 25) ➞ [0, 25]
        //The vertex of y=-x²+25 is at (0, 25).

        //FindVertex(1, 10, 4) ➞ [-5, -21]
        //The vertex of y=x²+10x+4 is at (-5, -21).
        double[] FindVertex(int a, int b, int c);


        //Create a function that takes a string and returns the number of alphanumeric characters
        //that occur more than once.

        //Examples
        //DuplicateCount("abcde") ➞ 0
        //DuplicateCount("aabbcde") ➞ 2
        //DuplicateCount("Indivisibilities") ➞ 2
        //DuplicateCount("Aa") ➞ 0
        // Case sensitive
        int DuplicateCount(string str);

        //A string is an almost-palindrome if, by changing only one character, you can make it a palindrome.
        //Create a function that returns true if a string is an almost-palindrome and false otherwise.

        //Examples
        //AlmostPalindrome("abcdcbg") ➞ true
        //// Transformed to "abcdcba" by changing "g" to "a".

        //AlmostPalindrome("abccia") ➞ true
        //// Transformed to "abccba" by changing "i" to "b".

        //AlmostPalindrome("abcdaaa") ➞ false
        //// Can't be transformed to a palindrome in exactly 1 turn.

        //AlmostPalindrome("1234312") ➞ false
        bool AlmostPalindrome(string str);

        //Write a function that returns the longest common ending between two strings.
        //Examples
        //LongestCommonEnding("multiplication", "ration") ➞ "ation"
        //LongestCommonEnding("potent", "tent") ➞ "tent"
        //LongestCommonEnding("skyscraper", "carnivore") ➞ ""
        string LongestCommonEnding(string str1, string str2);


        //Write a function that takes an integer n, reverses the binary representation of that integer, and returns the new integer from the reversed binary.

        //Examples
        //reversedBinaryInteger(10) ➞ 5
        //// 10 = 1010 -> 0101 = 5

        //reversedBinaryInteger(12) ➞ 3
        //// 12 = 1100 -> 0011 = 3

        //reversedBinaryInteger(25) ➞ 19
        //// 25 = 11001 -> 10011 = 19

        //reversedBinaryInteger(45) ➞ 45
        //// 45 = 101101 -> 101101 = 45

        int ReversedBinaryInteger(int num);

        //Create a function that takes a string and replaces each letter with its appropriate position in the alphabet. "a" is 1, "b" is 2, "c" is 3, etc, etc.

        //Examples
        //AlphabetIndex("Wow, does that work?")
        //➞ "23 15 23 4 15 5 19 20 8 1 20 23 15 18 11"

        //AlphabetIndex("The river stole the gods.")
        //➞ "20 8 5 18 9 22 5 18 19 20 15 12 5 20 8 5 7 15 4 19"

        //AlphabetIndex("We have a lot of rain in June.")
        //➞ "23 5 8 1 22 5 1 12 15 20 15 6 18 1 9 14 9 14 10 21 14 5"
        //Notes
        //If any character in the string isn't a letter, ignore it.
        string AlphabetIndex(string str);

        //Create a function that takes the width, height and character and returns a picture frame as an array of strings(string[]).

        //Examples
        //get_frame(4, 5, "#") ➞ [
        //  "####",
        //  "#  #",
        //  "#  #",
        //  "#  #",
        //  "####"
        //]
        //        // Frame is 4 characters wide and 5 characters tall.

        //        get_frame(10, 3, "*") ➞ [
        //          "**********",
        //          "*        *",
        //          "**********"
        //]
        //        // Frame is 10 characters and wide and 3 characters tall.

        //        get_frame(2, 5, "0") ➞ "invalid"
        //// Frame's width is less than 3.

        string[] GetFrame(int w, int h, char ch);

        //Write a function that returns the closest palindrome number to an integer.
        //If two palindrome numbers tie in absolute distance, return the smaller number.

        //Examples
        //ClosestPalindrome(887) ➞ 888

        //ClosestPalindrome(100) ➞ 99
        //// 99 and 101 are equally distant, so we return the smaller palindrome.

        //ClosestPalindrome(888) ➞ 888

        //ClosestPalindrome(27) ➞ 22

        int ClosestPalindrome(int num);

        //A snail fell into a bucket and wanted to crawl out. Assuming we already know the snail can climb 5cm per minute,
        //the snail can crawl for 30 minutes continuously and then needs to rest for 10 minutes.When it is resting it will slide down 30cm.

        //How many minutes will it take for the snail to crawl out from different depths?
        //Create a function that takes the bucket depth(the unit is cm) as an argument and returns the time in minutes.

        //if depth = 270
        //the snail crawling process
        //process: (150 - 30) +  150
        //minutes: (30+10) + 150 / 5
        //it will take 70 minutes
        //the last 150cm, the snail doesn't need a rest
        //Examples
        //Cal(31) ➞ 7

        //Cal(150) ➞ 30

        //Cal(200) ➞ 56
        int Cal(int depth);
        //Create a function that returns true if two lines rhyme and false otherwise.For the purposes of this exercise, two lines rhyme if the last word from each sentence contains the same vowels.

        //Examples
        //DoesRhyme("Sam I am!", "Green eggs and ham.") ➞ true

        //DoesRhyme("Sam I am!", "Green eggs and HAM.") ➞ true
        //// Capitalization and punctuation should not matter.

        //DoesRhyme("You are off to the races", "a splendid day.") ➞ false

        //DoesRhyme("and frequently do?", "you gotta move.") ➞ false
        //Notes
        //Case insensitive.
        //Here we are disregarding cases like "thyme" and "lime".
        //We are also disregarding cases like "away" and "today" (which technically rhyme, even though they contain different vowels).

        bool DoesRhyme(string str1, string str2);



        //I was born on the 21st of September in the year of 1970. That was a Monday.Where I was born that weekday is called måndag.

        //Write a method that when passed a date as year/month/ day and returns the date's weekday name in the Dutch culture. The culture identifier to use is "nl-NL". Not "nl-BE".
        //You can assume the specified date is valid.
        //Looking at the tests and doing a switch statement or similar is considered cheating.
        //System.Globalization.CultureInfo should be used.
        //The method may be used to get the name of the Dutch weekday of other memorable days too, like in the examples below:
        //Examples
        //WeekdayRobWasBornInDutch(new DateTime(1970, 9, 21)) ➞ "maandag"

        //WeekdayRobWasBornInDutch(new DateTime(1945, 9, 2)) ➞ "zondag"

        //WeekdayRobWasBornInDutch(new DateTime(2001, 9, 11)) ➞ "dinsdag"

        string WeekdayRobWasBornInDutch(int year, int month, int day);

        //Hermione has come up with a precise formula for determining whether or not a phrase was
        //ssspoken by a parssseltongue(a reference from the Harry Potter universe;
        //the language of ssserpents and those who can converse with them).

        //Each word in a sssentence must contain either:

        //Two or more consecutive instances of the letter "s" (i.e.must be together ss..), or...
        //Zero instances of the letter "s" by itself.
        //Examples
        //IsParselTongue("Sshe ssselects to eat that apple. ") ➞ true

        //IsParselTongue("She ssselects to eat that apple. ") ➞ false
        //// "She" only contains one "s".

        //IsParselTongue("Beatrice samples lemonade") ➞ false
        //// While "samples" has 2 instances of "s", they are not together.

        //IsParselTongue("You ssseldom sssspeak sso boldly, ssso messmerizingly.") ➞ true

        bool IsParselTongue(string sentence);

        //        This is a reverse coding challenge.

        //Your task is to create a function that, when fed the inputs below, produce the sample outputs shown.

        //Examples
        //3 ➞ 21

        //9 ➞ 2221

        //17 ➞ 22221

        //24 ➞ 22228

        int MysteryFunc(int num);


        //Create a function that takes a string containing money in dollars and pounds sterling(seperated by comma+space) and returns the sum of dollar bills only, as an integer.

        //For the input string:


        //Each amount is prefixed by the currency symbol: $ for dollars and £ for pounds.
        //Thousands are represented by the suffix k.
        //i.e. $4k = $4,000 and £40k = £40,000


        //Examples
        //AddBill("$20, £40, £60, $50") ➞ 70
        //// 20 + 50 = 70

        //AddBill("£30, $20, £60, $150, £360") ➞ 170
        //// 20  + 150 = 170

        //AddBill("£30, $2k, £60, $200, £360") ➞ 2200
        //// 2 * 1000 + 200 = 2200

        int AddBill(string money);


        //Create two functions ToCamelCase() and ToSnakeCase() that each take a single string and convert it into either camelCase or snake_case.If you're not sure what these terms mean, check the Resources tab above.

        //Examples
        //ToCamelCase("hello_edabit") ➞ "helloEdabit"

        //ToSnakeCase("helloEdabit") ➞ "hello_edabit"

        //ToCamelCase("is_modal_open") ➞ "isModalOpen"

        //ToSnakeCase("getColor") ➞ "get_color"
        //Notes
        //Test input will always be appropriately formatted as either camelCase or snake_case, depending on the function being called.

        string ToSnakeCase(string str);
        string ToCamelCase(string str);

        //Create a function that accepts string input and int cases as parameters
        //where the string is split into N distinct cases of equal length as shown:

        //Examples
        //SplitNCases("Strengthened", 6) ➞ { "St", "re", "ng", "th", "en", "ed" }

        //SplitNCases("Unscrupulous", 2) ➞ { "Unscru", "pulous" }

        //SplitNCases("Flavorless", 1) ➞ { "Flavorless" }
        //Notes
        //If it's not possible to split the string as described, return { "Error" }.
        string[] SplitNCases(string input, int cases);

        //A number n is called uban if its name(in English) does not contain the letter "u".
        //In particular, it cannot contain the terms "four", "hundred", and "thousand", so the uban number following 99 is 1,000,000.
        //Write a function to determine if the given integer is uban.
        //Examples
        //IsUban(456) ➞ false
        //IsUban(25) ➞ true
        //IsUban(1098) ➞ false
        bool IsUban(int num);

        //Given a number, create a function which returns a new number based on the following rules:

        //For each digit, replace it by the number of times it appears in the number.
        //The final instance of the number will be an integer, not a string.
        //The following is a working example:

        //DigitCount(136116) ➞ 312332
        //// The number 1 appears thrice, so replace all 1s with 3s.
        //// The number 3 appears only once, so replace all 3s with 1s.
        //// The number 6 appears twice, so replace all 6s with 2s.
        //Examples
        //DigitCount(221333) ➞ 221333

        //DigitCount(136116) ➞ 312332

        //DigitCount(2) ➞ 1
        //Notes
        //Each test will have a positive whole number in its parameter.
        long DigitCount(long num);

        //Watch the video about Gauss's Addition in the Resources tab to see how you can use the formula for your function.

        //Gauss

        //Create a function that adds all the numbers together from 1 to n or, if two numbers are given: n to m.The input can be in any order.

        //Examples
        //Gauss({ 100 }) ➞ 5050 // From the video

        //Gauss({ 5001, 7000 }) ➞ 12001000 // Also ^^

        //Gauss({ 1975, 165 }) ➞ 1937770

        long Gauss(long[] arr);

        //Create a function to return the count of all bridges in a two-dimensional grid.

        //Bridge B should be counted if:

        //It connects from one end of the grid to the one opposite to it.
        //It is unobstructed.
        //Example
        //"#########/#       #/#   #   #/#   #   #/#### ####/#   #   #/#   #   #/#       #/#########"
        //In this case the number 4 is returned because, when unraveled, the string reveals four bridges that meet the requirements listed above as shown:

        int BridgesII(string str);

        //Create a function that takes a number and returns the sum of factors of factors of the given number.

        //Examples
        //SumFF(69) ➞ 3, 23 ➞ 0
        //// Both 3 and 23 are prime numbers and have no factors
        //// other than 1 and themselves so the result is 0.

        //SumFF(12) ➞ 2, 3, 4, 6 ➞ (0) + (0) + (2) + (2+3) ➞ 7

        //SumFF(420) ➞ 2,4, 6, 10, 12 ... ➞ (2) + (2+3) + (2+5) + (2+3+4+6) ... ➞ 1175

        //SumFF(619) ➞ ___ ➞ 0
        //// 619 doesn't have any factors (other than 1 and 619).
        //Notes
        //The number will always be greater than 0.
        //Factors that are equal to the number or 1, don't count (see example #1).

        int SumFF(int a);

        //Create a function that takes two integers and returns true if a digit repeats three times
        //in a row at any place in num1 AND that same digit repeats two times in a row in num2.

        //Examples
        //Trouble(451999277, 41177722899) ➞ true

        //Trouble(1222345, 12345) ➞ false

        //Trouble(666789, 12345667) ➞ true

        //Trouble(33789, 12345337) ➞ false
        //Notes
        //You can expect every test case to contain exactly two integers.

        bool Trouble(long num1, long num2);

        //Create a function that takes in a sentence and returns the average length of each word in that sentence.
        //Round your result to two decimal places.

        //Examples
        //AverageWordLength("A B C.") ➞ 1.00

        //AverageWordLength("What a gorgeous day.") ➞ 4.00

        //AverageWordLength("Dude, this is so awesome!") ➞ 3.80
        //Notes
        //Ignore punctuation when counting the length of a word.
        double AverageWordLength(string str);

        //Create a function that takes a string as an argument.The function must return a string containing 1s and 0s based on
        //the string argument's words. If any word in the argument is not equal to "zero" or "one" (case insensitive), you should ignore it.
        //The returned string's length should be a multiple of 8, if the string is not a multiple of 8 you should remove the numbers in excess.

        //Examples
        //TextToNumberBinary("zero one zero one zero one zero one") ➞ "01010101"

        //TextToNumberBinary("Zero one zero ONE zero one zero one") ➞ "01010101"

        //TextToNumberBinary("zero one zero one zero one zero one one two") ➞ "01010101"

        //TextToNumberBinary("zero one zero one zero one zero three") ➞ ""

        //TextToNumberBinary("one one") ➞ ""

        string TextToNumberBinary(string str);


        //Create a function that returns a number which can block the player from reaching 3 in a row in a game of Tic Tac Toe.
        //The number given as an argument will correspond to a grid of Tic Tac Toe: topleft is 0, topright is 2,
        //bottomleft is 6, and bottomright is 8.

        //Create a function that takes two numbers a, b and returns another number.
        //This number should be the final one in a line to block the player from winning.
        //Examples
        //BlockPlayer(0, 3) ➞ 6

        //BlockPlayer(0, 4) ➞ 8

        //BlockPlayer(3, 5) ➞ 4
        //Notes
        //The values given will always have two filled squares in a line.
        int BlockPlayer(int a, int b);

        //This robot roams around a 2D grid.It starts at(0, 0) facing North.After each time it moves, the robot rotates 90 degrees clockwise.
        //Given the amount the robot has moved each time, you have to calculate the robot's final position.

        //To illustrate, if the robot is given the movements int[] { 20, 30, 10, 40 }
        //        then it will move:

        //20 steps North, now at(0, 20)
        //30 steps East, now at(30, 20)
        //10 steps South.now at (30, 10)
        //40 steps West, now at(-10, 10)
        //...and will end up at coordinates(-10, 10).

        //Examples
        //TrackRobot(new int[] { 20, 30, 10, 40 }) ➞ [-10, 10]

        //    TrackRobot(new int[] { }) ➞ [0, 0]
        //// No movement means the robot stays at (0, 0).

        //TrackRobot(-10, 20, 10) ➞ [20, -20]
        //// The amount to move can be negative.
        //Notes
        //Each movement is an integer (whole number).
        //The return value must be of type int[]
        int[] TrackRobot(int[] steps);

        //Create a function that takes a string as an argument and returns the number of repitions of a substring.
        //This the opposite of creating a string by repeating a smaller string n times.For example "abc" repeated4 times would be "abcabcabcabc"

        //In this challenge, we do the opposite. Given the final string, and ask the number of times the substring is repeated.

        //Examples
        //NumberOfRepeats("abcabcabcabc" ) ➞ 4

        //NumberOfRepeats("bcbcbc") ➞ 3

        //NumberOfRepeats("llbllbllbllbllbllb") ➞ 6

        //NumberOfRepeats("kc") ➞ 1
        //Notes
        //Assume that the substring length is always greater than 1.
        //Assume that the string length is always greater than 1.
        //Assume that the substring is not always the same.
        int NumberOfRepeats(string str);

        //In JavaScript, there are two types of comments:

        //Single-line comments start with //
        //Multi-line or inline comments start with /* and end with */
        //The input will be a sequence of //, /* and */. Every /* must have a */ that immediately follows it.
        //To add, there can be no single-line comments in between multi-line comments in between the /* and */.

        //Create a function that returns true if comments are properly formatted, and false otherwise.

        //Examples
        //CommentsCorrect("//////") ➞ true
        //// 3 single-line comments: ["//", "//", "//"]

        //CommentsCorrect("/**//**////**/") ➞ true
        //// 3 multi-line comments + 1 single-line comment:
        //// ["/*", "*/", "/*", "*/", "//", "/*", "*/"]

        //CommentsCorrect("///*/**/") ➞ false
        //// The first /* is missing a */

        //CommentsCorrect("/////") ➞ false
        //// The 5th / is single, not a double //

        bool CommentsCorrect(string str);

        //Write a method that accepts two integer parameters rows and cols.
        //The output is a 2d array of numbers displayed in column-major order,
        //meaning the numbers shown increase sequentially down each column and wrap to the top of the next column
        //to the right once the bottom of the current column is reached.

        //Examples
        //PrintGrid(3, 6) ➞ new int[,] { 
        //  new in[,]t[] { 1, 4, 7, 10, 13, 16 },
        //  new int[] { 2, 5, 8, 11, 14, 17 },
        //  new int[] { 3, 6, 9, 12, 15, 18 }
        //]

        //PrintGrid(5, 3) ➞ new int[,] {
        //  new int[] { 1, 6, 11 },
        //  new int[] { 2, 7, 12 },
        //  new int[] { 3, 8, 13 },
        //  new int[] { 4, 9, 14 },
        //  new int[] { 5, 10, 15 }
        //]

        //PrintGrid(4, 1) ➞ new int[,] {
        //  new int[] { 1 },
        //  new int[] { 2 },
        //  new int[] { 3 },
        //  new int[] { 4 }
        //]
        //Notes
        //The return type of the function must be a 2 dimensional array of integers - int[,]
        int[,] PrintGrid(int rows, int cols);


        //It's time to send and receive secret messages.
        //Create two functions that take a string and an array and returns a coded or decoded message.
        //The first letter of the string, or the first element of the array represents the Character Code of that letter.
        //The next elements are the differences between the characters: e.g.A +3 --> C or z -1 --> y.

        //Examples
        //Encrypt("Hello") ➞ [72, 29, 7, 0, 3]
        //        // H = 72, the difference between the H and e is 29 (upper- and lowercase).
        //        // The difference between the two l's is obviously 0.

        //        Decrypt([ 72, 33, -73, 84, -12, -3, 13, -13, -68 ]) ➞ "Hi there!"

        //Encrypt("Sunshine") ➞ [83, 34, -7, 5, -11, 1, 5, -9]
        //        Notes
        //The input of the encrypt function will always be a string.
        //The input of the decrypt function will always be an array with numbers.
        int[] Encrypt(string str);
        string Decrypt(int[] arr);

        //Create a function that takes two times of day(hours, minutes, seconds) and returns the amount of occurences of palendrome timestamps.

        //A palendrome timestamp should be read the same hours : minutes : seconds as seconds : minutes : hours, keeping in mind the second's and hour's digits will reverse.For example, 02 : 11 : 20 is a palendrome timestamp.

        //Examples
        //PalendromeTimestamps(2, 12, 22, 4, 35, 10) ➞ 14

        //PalendromeTimestamps(12, 12, 12, 13, 13, 13) ➞ 6

        //PalendromeTimestamps(6, 33, 15, 9, 55, 10) ➞ 0
        //Notes
        //Expect military time.
        //Include the given time parameters if they happen to be palendromes.
        //The parameter timestamps are chronological.
        int PalendromeTimestamps(int h1, int m1, int s1, int h2, int m2, int s2);


        //You arrive at the supermarket checkout and you've only got a limited number of shopping bags with you.
        //Miser that you are, you hate buying extra bags when you've got dozens at home that you forgot to bring with you!!
        //Can you fit all your shopping into the bags you've got with you?

        //Each bag can carry a maximum of 10kg and each item you've purchased weighs between 1 and 10kg.

        //Create a function that takes two parameters, a list of the weights of each item and the number of bags you are carrying.Return True if there are enough bags to contain all the items, otherwise False.

        //Example
        //CanFit(new int[] { 2, 1, 2, 5, 4, 3, 6, 1, 1, 9, 3, 2 }, 4) ➞ True
        //// Bag 1 = [2, 1, 2, 5] (10kg)
        //// Bag 2 = [4, 3, 3] (10kg)
        //// Bag 3 = [6, 2, 1, 1] (10kg)
        //// Bag 4 = [9] (9kg)

        //CanFit(new int[] { 2, 7, 1, 3, 3, 4, 7, 4, 1, 8, 2 ], 4) ➞ False
        //// Bag 1 = [2, 8] (10kg)
        //// Bag 2 = [3, 7] (10kg)
        //// Bag 3 = [2, 4, 4] (10kg)
        //// Bag 4 = [7, 3] (10kg)
        //// two 1kg items left over!
        //Notes
        //All weights will be integers between 1 and 10kg inclusive
        //Items can be packed in any order
        //There may be more than one way to fit all the items in the available bags
        bool CanFit(int[] weights, int bags);

        //Create a function that returns true if a given inequality expression is correct and false otherwise.

        //Examples
        //CorrectSigns("3 < 7 < 11") ➞ true

        //CorrectSigns("13 > 44 > 33 > 1") ➞ false

        //CorrectSigns("1 < 2 < 6 < 9 > 3") ➞ true
        bool CorrectSigns(string str);


        //In recreational mathematics, a square array of numbers, usually positive integers, is called a magic square if
        //the sums of the numbers in each row, each column, and both main diagonals are the same.
        //Create a function that takes a square 1D array as an argument and returns a Boolean(if it is: true, if it isn't: false).

        //Examples
        //IsMagicSquare(new int[][] {
        //  { 2, 7, 6 },
        //  { 9, 5, 1 },
        //  { 4, 3, 8 }
        //}) ➞ true

        //IsMagicSquare(new int[][] {
        //  { 16, 3, 2, 13 },
        //  { 5, 10, 11, 8 },
        //  { 9, 6, 7, 12 },
        //  { 4, 15, 14, 1 }
        //}) ➞ true

        //IsMagicSquare(new int[][] {
        //  { 1, 14, 14, 4 },
        //  { 11, 7, 6, 9 },
        //  { 8, 11, 10, 5 },
        //  { 13, 2, 3, 15 }
        //}) ➞ false

        bool IsMagicSquare(int[] arr);

        //Rondo Form is a type of musical structure, in which there is a recurring theme/refrain, notated as A.Here are the rules for valid rondo forms:

        //Rondo forms always start and end with an A section.
        //In between the A sections, there should be contrasting sections notated as B, then C, then D, etc...No letter should be skipped.
        //There shouldn't be any repeats in the sequence (such as ABBACCA).
        //Create a function which validates whether a given string is a valid Rondo Form.

        //Examples
        //ValidRondo("ABACADAEAFAGAHAIAJA") ➞ true

        //ValidRondo("ABA") ➞ true

        //ValidRondo("ABBACCA") ➞ false

        //ValidRondo("ACAC") ➞ false

        //ValidRondo("A") ➞ false
        //Notes
        //Inputs will be given as all uppercase.
        //For the purposes of this challenge, accept ABA as valid Rondo forms.
        bool ValidRondo(string s);

        //A Collatz sequence is generated by repeatedly applying the following rules to an integer and
        //then to each resulting integer in turn:

        //If even: divide by 2.
        //If odd: multiply by 3, then add 1.
        //The Collatz algorithm has been tested and found to always reach 1 for all positive integers.

        //Create a function that, when given two positive integers a b, returns the string "a" if integer a took fewer steps to reach 1 than b when passed through the Collatz sequence, or "b" if integer b took fewer steps to reach 1 than a.

        //Examples
        //Collatz(10, 15) ➞ "a"
        //// Because 10.0 - 5.0 - 16.0 - 8.0 - 4.0 - 2.0 - 1.0: 6 steps
        //// 15.0 - 46.0 - 23.0 - 70.0 - 35.0 - 106.0 - 53.0 - 160.0 - 80.0 - 40.0 - 20.0 - 10.0 - 5.0 - 16.0 - 8.0 - 4.0 - 2.0 - 1.0: 17 steps

        //Collatz(13, 16) ➞ "b"

        //Collatz(53782, 72534) ➞ "b"
        //Notes
        //Assume a and b never take the same number of steps to reach 1.

        string Collatz(Int64 a, Int64 b);

        //Create a function to reproduce the wrap around effect shown:

        //Examples
        //WrapAround("Hello, World!", 2) ➞ "llo, World!He"

        //WrapAround("From what I gathered", -4) ➞ "eredFrom what I gath"

        //WrapAround("Excelsior", 30) ➞ "elsiorExc"

        //WrapAround("Nonscience", -116) ➞ "cienceNons"
        //Notes
        //The offset can be negative.
        //The offset can be greater than the input string's length.
        string WrapAround(string input, int offset);


        //A number has a breakpoint if it can be split in a way where the digits on the left side and the
        //digits on the right side sum to the same number.

        //For instance, the number 35190 can be sliced between the digits 351 and 90, since 3 + 5 + 1 = 9 and 9 + 0 = 9.
        //On the other hand, the number 555 does not have a breakpoint(you must split between digits).

        //Create a function that returns true if a number has a breakpoint, and false otherwise.

        //Examples
        //BreakPoint(159780) ➞ true

        //BreakPoint(112) ➞ true

        //BreakPoint(1034) ➞ true

        //BreakPoint(10) ➞ false

        //BreakPoint(343) ➞ false
        //Notes
        //Read each digit as only one number.
        bool BreakPoint(int num);


        //A briefcase has a 4-digit rolling-lock. Each digit is a number from 0-9 that can be rolled either forwards or backwards.

        //Create a function that returns the smallest number of turns it takes to transform the lock from the current combination to the target combination.
        //One turn is equivalent to rolling a number forwards or backwards by one.

        //To illustrate:

        //current-lock: 4089
        //target-lock: 5672
        //What is the minimum number of turns it takes to transform 4089 to 5672?

        //4 ➞ 5
        //4 ➞ 5  // Forward Turns: 1 <- Min
        //4 ➞ 3 ➞ 2 ➞ 1 ➞ 0 ➞ 9 ➞ 8 ➞ 7 ➞ 6 ➞ 5  // Backward Turns: 9

        //0 ➞ 6
        //0 ➞ 1 ➞ 2 ➞ 3 ➞ 4 ➞ 5 ➞ 6  // Forward Turns: 6
        //0 ➞ 9 ➞ 8 ➞ 7 ➞ 6  // Backward Turns: 4  <- Min

        //8 ➞ 7
        //8 ➞ 9 ➞ 0 ➞ 1 ➞ 2 ➞ 3 ➞ 4 ➞ 5 ➞ 6 ➞ 7  // Forward Turns: 9
        //8 ➞ 7  // Backward Turns: 1  <- Min

        //9 ➞ 2
        //9 ➞ 0 ➞ 1 ➞ 2  // Forward Turns: 3  <- Min
        //9 ➞ 8 ➞ 7 ➞ 6 ➞ 5 ➞ 4 ➞ 3 ➞ 2  // Backward Turns: 7
        //It takes 1 + 4 + 1 + 3 = 9 minimum turns to change the lock from 4089 to 5672.

        //Examples
        //MinTurns("4089", "5672") ➞ 9

        //MinTurns("1111", "1100") ➞ 2

        //MinTurns("2391", "4984") ➞ 10
        //Notes
        //Both locks are in string format.
        //A 9 rolls forward to 0, and a 0 rolls backwards to a 9.

        int MinTurns(string current, string target);

        //Create a function that converts 12-hour time to 24-hour time or vice versa.Return the output as a string.

        //Examples
        //ConvertTime("12:00 am") ➞ "0:00"

        //ConvertTime("6:20 pm") ➞ "18:20"

        //ConvertTime("21:00") ➞ "9:00 pm"

        //ConvertTime("5:05") ➞ "5:05 am"
        //Notes
        //A 12-hour time input will be denoted with an am or pm suffix.
        //A 24-hour input time contains no suffix.
        string ConvertTime(string time);

        //Create a function that takes a string and replaces every letter with the letter following it
        //in the alphabet("c" becomes "d", "z" becomes "a", "b" becomes "c", etc).
        //Then capitalize every vowel(a, e, i, o, u) and return the new modified string.

        //Examples
        //Mangle("Fun times!") ➞ "GvO Ujnft!"

        //Mangle("The quick brown fox.") ➞ "UIf rvjdl cspxO gpy."

        //Mangle("Omega") ➞ "Pnfhb"
        //Notes
        //If a letter is already uppercase, return it as uppercase(regardless of being a vowel).
        //"y" is not considered a vowel.
        string Mangle(string str);

        //Create a function that takes two strings and returns true if either of the strings appears at the very end of the other string.
        //Return false otherwise.The character * is a wildcard, so it can take the place of any character.

        //Examples
        //Overlap("ABC", "Ican'tsingmyABC") ➞ true

        //Overlap("abc", "Ican'tsingmyABC") ➞ true

        //Overlap("Ican'tsingmyABC", "abc") ➞ true

        //Overlap("hello world", "hello") ➞ false

        //Overlap("+=", "this should work too +=") ➞ true

        //Overlap("hey", "*********") ➞ true
        //Notes
        //Your function should NOT be case sensitive(see example #2).
        bool Overlap(string str1, string str2);


        //Create a function that determines whether it is possible to build a palindrome from the characters in a string.

        //Examples
        //PossiblePalindrome("acabbaa") ➞ true
        //// Can make the following palindrome: "aabcbaa"

        //PossiblePalindrome("aacbdbc") ➞ true
        //// Can make the following palindrome: "abcdcba"

        //PossiblePalindrome("aacbdb") ➞ false

        //PossiblePalindrome("abacbb") ➞ false

        bool PossiblePalindrome(string str);


        //Write a function that accepts a string and an n and returns a cipher by rolling each character forward(n > 0) or backward(n< 0) n times.

        //Note: Think of the letters as a connected loop, so rolling a backwards once will yield z, and rolling z forward once will yield a.
        //If you roll 26 times in either direction, you should end up back where you started.

        //Examples
        //RollingCipher("abcd", 1) ➞ "bcde"

        //RollingCipher("abcd", -1) ➞ "zabc"

        //RollingCipher("abcd", 3) ➞ "defg"

        //RollingCipher("abcd", 26) ➞ "abcd"
        //Notes
        //All letters are lower cased.
        //No spacing.
        //Each character is rotated the same number of times.

        string RollingCipher(string str, int n);

        //        Find the index of a string within a hex encoded string.

        //You will be given a string which needs to be found in another string which has previously been translated into hex.
        //You will need to return the first index of the needle within the hex encoded string.

        //Examples
        //FirstIndex("68 65 6c 6c 6f 20 77 6f 72 6c 64", "world") ➞ 6

        //FirstIndex("47 6f 6f 64 62 79 65 20 77 6f 72 6c 64", "world") ➞ 8

        //FirstIndex("42 6f 72 65 64 20 77 6f 72 6c 64", "Bored") ➞ 0

        int FirstIndex(string hexString, string needle);


        //Write a sorting function that takes in an array of names and sorts them by last name either alphabetically(ASC) or
        //reverse-alphabetically(DESC).

        //Examples
        //SortContacts(new string[] {
        //  "John Locke",
        //  "Thomas Aquinas",
        //  "David Hume",
        //  "Rene Descartes"
        //}, "ASC") ➞ {
        //  "Thomas Aquinas",
        //  "Rene Descartes",
        //  "David Hume",
        //  "John Locke"
        //}

        //// Aquinas (A) < Descartes (D) < Hume (H) < Locke (L)

        //SortContacts(new string[] {
        //  "Paul Erdos",
        //  "Leonhard Euler",
        //  "Carl Gauss"
        //}, "DESC") ➞ {
        //    "Carl Gauss",
        //  "Leonhard Euler",
        //  "Paul Erdos"
        //}

        //// Gauss (G) > Erdos (ER) > Euler (EU)

        //SortContacts([], "DESC") ➞ { }

        //SortContacts(null, "DESC") ➞ { }
        //Notes
        //An array with a single name should be trivially returned.
        //An empty array, or an input of null should return an empty array.
        string[] SortContacts(string[] names, string sort);


        //        Given an array of random digits of any length, return true if the number n appears times times in a row, and false otherwise.

        //Worked Example
        //IsThereConsecutive(new int[] { 1, 3, 5, 5, 3, 3, 1 }, 3, 2) ➞ true
        //// Second parameter is the number to look out for (3).
        //// Third parameter means you need to find the number 3 twice in a row.
        //// Return true if it can be found.
        //Examples
        //IsThereConsecutive(new int[] { 1, 2, 3, 4, 5 }, 1, 1) ➞ true

        //IsThereConsecutive(new int[] { 3 }, 1, 0) ➞ true

        //IsThereConsecutive(new int[] { 2, 2, 3, 2, 2, 2, 2, 3, 4, 1, 5 }, 3, 2) ➞ false

        //IsThereConsecutive(new int[] { 5, 5, 5, 5, 5 }, 5, 7) ➞ false
        //Notes
        //Arrays will only contain positive single digit numbers.
        //Expect all parameters to be valid.

        bool IsThereConsecutive(int[] arr, int n, int times);


        //Given a string text.Write a function that returns the character with the highest frequency.
        //If more than 1 character has the same highest frequency, return all those characters as a comma separated string.
        //If there is no repetition in characters, return "No Repetition".

        //Examples
        //MaxOccur("Computer Science") ➞ "e"

        //MaxOccur("Edabit") ➞ "No Repetition"

        //MaxOccur("system admin") ➞ "m, s"

        //MaxOccur("the quick brown fox jumps over the lazy dog") ➞ " "
        //Notes
        //Characters are case sensitive, so, for example, "C" and "c" are counted separately
        string MaxOccur(string text);

        //An abecedarian word is a word where all of its letters are arranged in alphabetical order.Examples of these words include:

        //Empty
        //Forty
        //Almost
        //Given an array of words, create a function which returns the longest abecedarian word.
        //If no word in an array matches the criterea, return an empty string.

        //Examples
        //LongestAbecedarian(new string[] { "ace", "spades", "hearts", "clubs" }) ➞ "ace"

        //LongestAbecedarian(new string[] { "forty", "choppy", "ghost" }) ➞ "choppy"

        //LongestAbecedarian(new string[] { "one", "two", "three" }) ➞ ""
        //Notes
        //All words will be given in lowercase.
        //If two abecedarian words have the same length, return the word which appeared first in the array.

        string LongestAbecedarian(string[] arr);


        //Create a function that returns the smallest number of changes it takes to transform one number into one with identical digits.
        //A step is incrementing or decrementing a digit by one.

        //Examples
        //SmallestTransform(399) ➞ 6
        //// 399 transformed to 999 in 6 steps.

        //SmallestTransform(1234) ➞ 4
        //// 1234 can be transformed to either 2222 or 3333 using 4 steps.

        //SmallestTransform(153) ➞ 4

        //SmallestTransform(33338) ➞ 5

        //SmallestTransform(7777) ➞ 0
        //Notes
        //If a number already has identical digits, return 0.
        int SmallestTransform(int num);

        //An input string can be completed if additional letters can be added and no letters need to be taken away to match the word.
        //Furthermore, the order of the letters in the input string must be the same as the order of letters in the final word.

        //Create a function that, given an input string, determines if the word can be completed.

        //Examples
        //CanComplete("butl", "beautiful") ➞ true
        //// We can add "ea" between "b" and "u", and "ifu" between "t" and "l".

        //CanComplete("butlz", "beautiful") ➞ false
        //// "z" does not exist in the word beautiful.

        //CanComplete("tulb", "beautiful") ➞ false
        //// Although "t", "u", "l" and "b" all exist in "beautiful", they are incorrectly ordered.

        //CanComplete("bbutl", "beautiful") ➞ false
        //// Too many "b"s, beautiful has only 1.
        //Notes
        //Both string input and word will be lowercased.
        bool CanComplete(string initial, string word);

        //Create a function that takes a string (IPv4 address in standard dot-decimal format) and returns true if the IP is valid or
        //false if it's not. For information on IPv4 formatting, please refer to the resources in the Resources tab.

        //Examples
        //IsValidIP("1.2.3.4") ➞ true

        //IsValidIP("1.2.3") ➞ false

        //IsValidIP("1.2.3.4.5") ➞ false

        //IsValidIP("123.45.67.89") ➞ true

        //IsValidIP("123.456.78.90") ➞ false

        //IsValidIP("123.045.067.089") ➞ false
        //Notes
        //IPv6 addresses are not valid.
        //Leading zeros are not valid ("123.045.067.089" should return false).
        //You can expect a single string for every test case.
        //Numbers may only be between 1 and 255.
        //The last digit may not be zero, but any other might.

        bool IsValidIP(string IP);

        //This number sequence can start with any positive integer n.s is the sum of the individual digits in n.
        //If s divides into n evenly then the next term of the series is n//s.
        //Otherwise the next term is n*s. Eventually the series will reach a dead end with two numbers
        //alternating: 58, 754, 12064, 928, 17632, 928, 17632. This series has a length of 5 with 17632 as the last term.

        //Compose a function that takes a positive integer and returns its series length and its last term.

        //Examples
        //DeadEnd(5) ➞ [2, 1]

        //DeadEnd(11) ➞ [7, 11440]

        //DeadEnd(123456789) ➞ [2, 5555555505]

        //DeadEnd(101) ➞ [9, 136804096]
        //Notes
        //All numbers in the sequence will be integers within the range 0 < n <= Int64.MaxValue

        long[] DeadEnd(long n);


        //        The 2019/20 season of the English Premier League(EPL) saw Liverpool FC win the title for the first time despite their bitter rivals, Manchester United, having won 13 titles!

        //Create a function that receives an alphabetically sorted array of the results achieved by each team in that season and the name of one of the teams.The function should return a string giving the final position of the team, the number of points achieved and the goal difference (see examples for precise format).

        //The results table is given in the following format:

        //Team Played  Won Drawn   Lost G/Diff
        //Arsenal	38	14	14	10	8
        //Aston Villa	38	9	8	21	-26
        //Bournemouth	38	9	7	22	-26
        //Brighton	38	9	14	15	-15
        //Burnley	38	15	9	14	-7
        //Chelsea	38	20	6	12	15
        //Crystal Palace	38	11	10	17	-19
        //Everton	38	13	10	15	-12
        //Leicester City	38	18	8	12	26
        //Liverpool	38	32	3	3	52
        //Manchester City	38	26	3	9	67
        //Manchester Utd	38	18	12	8	30
        //Newcastle	38	11	11	16	-20
        //Norwich	38	5	6	27	-49
        //Sheffield Utd	38	14	12	12	0
        //Southampton	38	15	7	16	-9
        //Tottenham	38	16	11	11	14
        //Watford	38	8	10	20	-28
        //West Ham	38	10	9	19	-13
        //Wolves	38	15	14	9	11
        //Examples
        //string[] table = [
        //  "Arsenal, 38, 14, 14, 10, 8",
        //  "Aston Villa, 38, 9, 8, 21, -26",
        //    ...
        //    ...
        //  "West Ham, 38, 10, 9, 19, -1",
        //  "Wolves, 38, 15, 14, 9, 11"
        //]

        //EPLResult(table, "Liverpool")
        //  ➞ "Liverpool came 1st with 99 points and a goal difference of 52!"

        //EPLResult(table, "Manchester Utd")
        //  ➞ "Manchester Utd came 3rd with 66 points and a goal difference of 30!"

        //EPLResult(table, "Norwich")
        //  ➞ "Norwich came 20th with 21 points and a goal difference of -49!"
        //Notes
        //Each result in the source table is a comma separated string.
        //Score 3 points for a win and 1 point for a draw.
        //If teams are tied on points, their position is determined by better goal difference.
        //The input table should be considered immutable - do not make any changes to it!
        string EPLResult(string[] table, string team);

        // Write a function that returns true if the knights are placed on a chessboard such that no knight can capture another knight.
        // Here, 0s represent empty squares and 1s represent knights.

        //Examples
        //CannotCapture(new int[,] {
        //  { 0, 0, 0, 1, 0, 0, 0, 0 },
        //  { 0, 0, 0, 0, 0, 0, 0, 0 },
        //  { 0, 1, 0, 0, 0, 1, 0, 0 },
        //  { 0, 0, 0, 0, 1, 0, 1, 0 },
        //  { 0, 1, 0, 0, 0, 1, 0, 0 },
        //  { 0, 0, 0, 0, 0, 0, 0, 0 },
        //  { 0, 1, 0, 0, 0, 0, 0, 1 },
        //  { 0, 0, 0, 0, 1, 0, 0, 0 }
        //}) ➞ True

        //CannotCapture(new int[,] {
        //  {1, 0, 1, 0, 1, 0, 1, 0},
        //  { 0, 1, 0, 1, 0, 1, 0, 1},
        //  { 1, 0, 1, 0, 1, 0, 1, 0},
        //  { 0, 0, 0, 1, 0, 1, 0, 1},
        //  { 1, 0, 0, 0, 1, 0, 1, 0},
        //  { 0, 0, 0, 0, 0, 1, 0, 1},
        //  { 1, 0, 1, 0, 1, 0, 1, 0},
        //  { 1, 0, 0, 1, 0, 0, 0, 1} 
        //}) ➞ False
        //Notes
        //Knights can be present in any of the 64 squares.
        //No other pieces except knights exist.

        bool CannotCapture(int[,] board);


        //Create a function that creates a pattern as a 2D array for a given number.

        //Examples
        // >
        // >>
        // >>>
        // >>
        // >

        //Arrow(3) ➞ [">", ">>", ">>>", ">>", ">"]
        // >
        // >>
        // >>>
        // >>>>
        // >>>>
        // >>>
        // >>
        // >

        //Arrow(4) ➞ [">", ">>", ">>>", ">>>>", ">>>>", ">>>", ">>", ">"]
        //        Notes
        //Function argument will always be a number greater than 0.
        //Odd numbers will have a single "peak" (see example #1).
        //Even numbers have two "peaks" (see example #2).

        string[] Arrow(int num);
    }
}
