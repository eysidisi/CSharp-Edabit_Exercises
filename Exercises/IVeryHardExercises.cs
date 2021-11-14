using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public interface IVeryHardExercises
    {
        //In recreational mathematics, a square array of numbers, usually positive integers, is called a magic square
        //if the sums of the numbers in each row, each column, and both main diagonals are the same.

        //Create a function that takes a square 2D array as an argument and returns a Boolean(if it is: true, if it isn't: false).

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
        //Notes
        //N/A


        bool IsMagicSquare(int[] arr);


        //Create a function that returns the simplified version of a fraction.

        //Examples
        //Simplify("4/6") ➞ "2/3"

        //Simplify("10/11") ➞ "10/11"

        //Simplify("100/400") ➞ "1/4"

        //Simplify("8/4") ➞ "2"
        //Notes
        //A fraction is simplified if there are no common factors(except 1) between the numerator and the denominator.
        //For example, 4/6 is not simplified, since 4 and 6 both share 2 as a factor.
        //If improper fractions can be transformed into integers, do so in your code (see example #4).

        string Simplify(string str);

        //A palindrome is a number that is the same when reversed, 2770772 for example.A palindrome can often be formed by adding a number to
        //it's reverse: 641 + 146 = 787 (a palindrome). Using 78 as the seed, it takes 4 steps to produce a palindrome:

        //78 + 87 = 165
        //165 + 561 = 726
        //726 + 627 = 1353
        //1353 + 3531 = 4884 (a palindrome)
        //About 97% of integers less than 10,000 produce palindromes in less than 25 steps.A few, like 196 and 879, may never form palindromes.

        //Make a function that takes a palindrome as it's an argument and returns the smallest seed integer that will produce that palindrome, along with the number of steps required:


        //PalSeq(palindrome) = (seed, steps)
        //PalSeq(4884) ➞ (69, 4)

        //PalSeq(1) ➞ (1, 0)

        //PalSeq(11) ➞ (10, 1)
        //# 10 + 01 = 11

        //PalSeq(3113) ➞ (199, 3)

        //PalSeq(8836886388) ➞ (177, 15)
        //Notes
        //The sequence always terminates when the first palindrome is produced.If the seed is a palindrome, the sequence has 0 steps.

        int[] PalSeq(int n);

        //A Fibonacci Word is a specific sequence of binary digits(or symbols from any two-letter alphabet). The Fibonacci Word is formed by repeated concatenation in the same way that the Fibonacci numbers are formed by repeated addition.

        //Create a function that takes a number n as an argument and returns the first n elements of the Fibonacci Word sequence.

        //If n < 2, the function must return "invalid".


        //Examples
        //FiboWord(1) ➞ "invalid"

        //FiboWord(3) ➞ "b, a, ab"

        //FiboWord(7) ➞ "b, a, ab, aba, abaab, abaababa, abaababaabaab"

        string FiboWord(int n);

        string XORCipher(string msg1, string msg2);

        //Musical instruments have a range of notes to play, some instruments having a much larger range than others.

        //Given the following ranges for the instrument, create a function that returns true if a given note is within a given instrument's range. Otherwise, return false.

        //Instrument Range
        //Piccolo D4-C7
        //Tuba    D1-F4
        //Guitar  E3-E6
        //Piano   A0-C8
        //Violin  G3-A7
        //Examples
        //InstrumentRange("Piccolo", "A3") ➞ false

        //InstrumentRange("Violin", "G6") ➞ true

        //InstrumentRange("Piano", "C8") ➞ true
        //Notes
        //Tests will only include natural notes(i.e.you will only deal with letters and numbers, no special characters).
        //The musical scale follows this pattern: ... A1, B1, C1, D1, E1, F1, G1, A2, B2...
        //You don't need to worry about invalid inputs.
        bool InstrumentRange(string instr, string note);

        //Given an nxn grid of consecutive numbers, return the grid's Diamond Sum. The diamond sum is defined as the sum of the numbers making up the diagonals between adjacent sides.

        //Examples
        //DiamondSum(1) ➞ 1

        //[1]
        //        DiamondSum(3) ➞ 20

        //[
        //  [1, _, 3],
        //  [_, 5, _],
        //  [7, _, 9]
        //]

        //// The numbers behind the underscores make up the Diamond Sum.
        //// 2 + 4 + 6 + 8 = 20
        //DiamondSum(5) ➞ 104

        //[
        //  [1, 2, _, 4, 5],
        //  [6, _, 8, _, 10],
        //  [_, 12, 13, 14, _],
        //  [16, _, 18, _, 20],
        //  [21, 22, _, 24, 25]
        //]

        //// 3 + 7 + 9 + 11 + 15 + 17 + 19 + 23 = 104
        //Notes
        //n is always an odd number.
        //Bonus points for solving it mathematically!

        int DiamondSum(int n);

        //You have to get a new driver's license. You show up at the office at the same time as four other people.,
        //The office says they will see everyone in alphabetical order and it takes 20 minutes for them to process each new license.
        //All of the agents are available now, and they can each see one customer at a time. How long will it take for you to walk out with your new license?

        //Your input will be a string of your name me, an integer of the number of available agents, and a string of the other four names separated by spaces others.

        //Return the number of minutes it will take to get your license.

        //Examples
        //License("Eric", 2, "Adam Caroline Rebecca Frank") ➞ 40
        //// As you are in the second group of people.

        //License("Zebediah", 1, "Bob Jim Becky Pat") ➞ 100
        //// As you are the last person.

        //License("Aaron", 3, "Jane Max Olivia Sam") ➞ 20
        //// As you are the first.

        int License(string me, int agents, string others);

        //Create a function that takes two strings and determines if an anagram of the first string is in the second string.
        //Anagrams of "bag" are "bag", "bga", "abg", "agb", "gab", "gba". Since none of those anagrams are in "grab", the answer is false.
        //A "g", "a", and "b" are in the string "grab", but they're split up by the "r".

        //Examples
        //AnagramStrStr("car", "race") ➞ true

        //AnagramStrStr("nod", "done") ➞ true

        //AnagramStrStr("bag", "grab") ➞ false
        //Notes
        //Inputs will be valid strings in all lowercase letters.
        //There exists a linear time algorithm for this.

        bool AnagramStrStr(string needle, string haystack);


        //Create a function which takes every letter in every word, and puts it in alphabetical order.
        //Note how the original word lengths must stay the same.

        //Examples
        //TrueAlphabetic("hello world") ➞ "dehll loorw"

        //TrueAlphabetic("edabit is awesome") ➞ "aabdee ei imosstw"

        //TrueAlphabetic("have a nice day") ➞ "aaac d eehi nvy"
        //Notes
        //All sentences will be in lowercase.
        //No punctuation or numbers will be included in the Tests.

        string TrueAlphabetic(string str);

        //Create a function double UniqueFract(), which should sum all irreducible regular fractions between 0 and 1,
        //in the numerator and denominator of which there are only single-digit numbers: 1/2, 1/3, 1/4, ... 2/3, 2/4, ... 8/9.

        //Task
        //UniqueFract() ➞ sum
        //Notes
        //Of the fractions 1/2 2/4 3/6 4/8, only 1/2 is included in the sum.
        //Don't include any values >= 1.
        //Both the numerator and denominator are single digit.
        double UniqueFract();


        //Create a function that validates a password to conform to the following rules:

        //Length between 6 and 24 characters.
        //At least one uppercase letter(A-Z).
        //At least one lowercase letter(a-z).
        //At least one digit(0-9).
        //Maximum of 2 repeated characters.
        //"aa" is OK 👍
        //"aaa" is NOT OK 👎
        //Supported special characters:
        //! @ # $ % ^ & * ( ) + = _ - { } [ ] : ; " ' ? < > , .
        //Examples
        //ValidatePassword("P1zz@") ➞ false
        //// Too short.

        //ValidatePassword("iLoveYou") ➞ false
        //// Missing a number.

        //ValidatePassword("Fhg93@") ➞ true
        //// OK!
        //Notes
        //N/A
        bool ValidatePassword(string password);

        //Write a function which increments a string to create a new string.

        //If the string ends with a number, the number should be incremented by 1.
        //If the string doesn't end with a number, 1 should be added to the new string.
        //If the number has leading zeros, the amount of digits should be considered.
        //Examples
        //IncrementString("foo") ➞ "foo1"

        //IncrementString("foobar0009") ➞ "foobar0010"

        //IncrementString("foo099") ➞ "foo100"

        //IncrementString("foo9") ➞ "foo10"

        string IncrementString(string txt);


        //Create a function that takes a string str containing only letters from a to z in lowercase and returns the missing letter(s)
        //in alphabetical order a-z.

        //A set of letters is given by abcdefghijklmnopqrstuvwxyz.
        //Two sets of alphabets means two or more alphabets.
        //Examples
        //MissingAlphabets("abcdefghijklmnopqrstuvwxy") ➞ "z"
        //// "z" is missing.

        //MissingAlphabets("aabbccddeeffgghhiijjkkllmmnnooppqqrrssttuuvvwwxxyy") ➞ "zz"
        //// Given string has a set of two alphabets so output will be "zz"

        //MissingAlphabets("edabit") ➞ "cfghjklmnopqrsuvwxyz"
        //Notes
        //If the string contains all letters from a-z, return an empty string "".
        string MissingAlphabets(string str);

        //Create a function to generate all string character permutations.

        //Examples
        //Permutations("AB") ➞ "AB BA"
        //Permutations("CD") ➞ "CD DC"
        //Permutations("EF") ➞ "EF FE"
        //Permutations("NOT") ➞ "NOT NTO ONT OTN TNO TON"
        //Permutations("RAM") ➞ "AMR ARM MAR MRA RAM RMA"
        //Permutations("YAW") ➞ "AWY AYW WAY WYA YAW YWA"
        //Notes
        //Sort your results in alphabetical order before returning them.
        string Permutations(string s);

        //Create a function that returns the area of the overlap between two rectangles.
        //The function will receive two rectangles, each with the coordinates of the lower left corner followed by the width and the
        //height int[] { x, y, width, height}.
        int OverlappingRectangles(int[] rect1, int[] rect2);

        //Create a function that takes a string and returns the reversed string.
        //However there's a few rules to follow in order to make the challenge interesting:

        //The UPPERCASE/lowercase positions must be kept in the same order as the original string (see example #1 and #2).
        //Spaces must be kept in the same order as the original string (see example #3).
        string SpecialReverseString(string txt);

        //A robot moves around a 2D grid. At the start, it is at[0, 0], facing east.It is controlled by a sequence of instructions:

        //. means take one step forwards in the current direction.
        //< means turn 90 degrees anticlockwise.
        //> means turn 90 degrees clockwise.
        //Your job is to process the instructions and return the final position of the robot.

        //Example
        //For example, if the robot is given the sequence of instructions..<.<., then:
        //Step 1: . It still faces east, and is at[1, 0].
        //Step 2: . It still faces east, and is at[2, 0].
        //Step 3: < It now faces north, and is still at [2, 0].
        //Step 4: . It still faces north, and is at[2, 1].
        //Step 5: < It now faces west, and is still at [2, 1].
        //Step 6: . It still faces west, and is now at [1, 1].
        //So, TrackRobot("..<.<.") returns[1, 1].

        //Notes
        //The instruction strings will only contain the three valid characters., < or >.
        //You will always be passed a string (but the string might be empty).

        int[] TrackRobot(string steps);

        //This is a reverse-coding challenge.Create a function that outputs the correct array from the input. Use the following examples to crack the code.

        //Examples
        //Decode("hello") ➞ int[] { 5, 2, 9, 9, 3 }

        //
        //
        //Decode("wonderful") ➞ int[] { 11, 3, 2, 1, 2, 6, 3, 9, 9 }

        //Decode("something challenging") ➞ int[]
        //{ 7, 3, 10, 2, 8, 5, 6, 2, 4, 5, 18, 5, 16, 9, 9, 2, 2, 4, 6, 2, 4 }

        int[] Decode(string str);

        //        For this exercise, keep in mind the following definitions:

        //A term is either an initials or word.
        //initials = 1 character
        //words = 2 + characters(no dots allowed)
        //A valid name is a name written in one of the following ways:

        //H.Wells
        //H. G.Wells
        //Herbert G.Wells
        //Herbert George Wells
        //The following names are invalid:

        //Herbert or Wells (single names not allowed)
        //H Wells or H. G Wells (initials must end with dot)
        //h.Wells or H.wells or h.g.Wells(incorrect capitalization)
        //H.George Wells (middle name expanded, while first still left as initial)
        //H.G.W. (last name is not a word)
        //Herb.G.Wells(dot only allowed after initial, not word)
        //Rules
        //Both initials and words must be capitalized.
        //Initials must end with a dot.
        //A name must be either 2 or 3 terms long.
        //If the name is 3 words long, you can expand the first and middle name or expand the first name only. You cannot keep the first name as an initial and expand the middle name only.
        //The last name must be a word (not an initial).
        //Your task is to write a function that determines whether a name is valid or not.Return true if the name is valid, false otherwise.

        //Examples
        //ValidName("H. Wells") ➞ true

        //ValidName("H. G. Wells") ➞ true

        //ValidName("Herbert G. Wells") ➞ true

        //ValidName("Herbert") ➞ false
        //// Must be 2 or 3 words

        //ValidName("h. Wells") ➞ false
        //// Incorrect capitalization

        //ValidName("H Wells") ➞ false
        //// Missing dot after initial

        //ValidName("H. George Wells") ➞ false
        //// Cannot have: initial first name + word middle name

        //ValidName("H. George W.") ➞ false
        //// Last name cannot be initial

        //ValidName("Herb. George Wells") ➞ false
        //// Words cannot end with a dot (only initials can)
        //Notes
        //A term is either an initial or word.
        //Initials and words are disjoint sets.

        bool ValidName(string name);

        //Write a function that calculates overtime and pay associated with overtime.

        //Working 9 to 5: regular hours
        //After 5pm is overtime
        //Your function gets an array with 4 values:

        //Start of working day, in decimal format, (24 - hour day notation)
        //End of working day. (Same format)
        //Hourly rate
        //Overtime multiplier
        //Your function should spit out:

        //$ + earned that day(rounded to the nearest hundreth)
        //Examples
        //OverTime([9, 17, 30, 1.5]) ➞ "$240.00"

        //OverTime([16, 18, 30, 1.8]) ➞ "$84.00"

        //OverTime([13.25, 15, 30, 1.5]) ➞ "$52.50"
        //2nd example explained:

        //From 16 to 17 is regular, so 1 * 30 = 30
        //From 17 to 18 is overtime, so 1 * 30 * 1.8 = 54
        //30 + 54 = $84.00

        string OverTime(double[] arr);

        //Create a function that takes a string consisting of lowercase letters, uppercase letters and numbers and returns
        //the string sorted in the same way as the examples below.

        //Examples
        //sorting("eA2a1E") ➞ "aAeE12"
        //// Don't repeat letters.

        //sorting("Re4r") ➞ "erR4"

        //sorting("6jnM31Q") ➞ "jMnQ136"

        //sorting("846ZIbo") ➞ "bIoZ468"
        //Notes
        //Don't repeat letters (numbers can be repeated).

        string Sorting(string str);


        //Given a string of digits, return the longest substring with alternating odd/even or even/odd digits.
        //If two or more substrings have the same length, return the substring that occurs first.

        //Examples
        //LongestSubstring("225424272163254474441338664823") ➞ "272163254"
        //// substrings = 254, 272163254, 474, 41, 38, 23

        //LongestSubstring("594127169973391692147228678476") ➞ "16921472"
        //// substrings = 94127, 169, 16921472, 678, 476

        //LongestSubstring("721449827599186159274227324466") ➞ "7214"
        //// substrings = 7214, 498, 27, 18, 61, 9274, 27, 32
        //// 7214 and 9274 have same length, but 7214 occurs first.
        //Notes
        //The minimum alternating substring size is 2.
        string LongestSubstring(string digits);

        // Create a function that returns true if two strings share the same letter pattern, and false otherwise.

        // Examples
        // SameLetterPattern("ABAB", "CDCD") ➞ true

        // SameLetterPattern("ABCBA", "BCDCB") ➞ true

        // SameLetterPattern("FFGG", "CDCD") ➞ false

        // SameLetterPattern("FFFF", "ABCD") ➞ false

        bool SameLetterPattern(string str1, string str2);


        //Create a function to generate all nonconsecutive binary strings where nonconsecutive is defined as a string where
        //no consecutive ones are present, and where len governs the length of each binary string.

        //Examples
        //GenerateNonconsecutive(1) ➞ "0 1"

        //GenerateNonconsecutive(2) ➞ "00 01 10"

        //GenerateNonconsecutive(3) ➞ "000 001 010 100 101"

        //GenerateNonconsecutive(4) ➞ "0000 0001 0010 0100 0101 1000 1001 1010"

        string GenerateNonconsecutive(int len);
        //A mountain is an array with exactly one peak.

        //All numbers to the left of the peak are increasing.
        //All numbers to the right of the peak are decreasing.
        //The peak CANNOT be on the boundary.
        //A valley is an array with exactly one trough.

        //All numbers to the left of the trough are decreasing.
        //All numbers to the right of the trough are increasing.
        //The trough CANNOT be on the boundary.
        //Some examples of mountains and valleys:

        //Mountain A:  [1, 3, 5, 4, 3, 2]   // 5 is the peak
        //Mountain B:  [-1, 0, -1]   // 0 is the peak
        //Mountain B:  [-1, -1, 0, -1, -1]   // 0 is the peak (plateau on both sides is okay)

        //Valley A: [10, 9, 8, 7, 2, 3, 4, 5]   // 2 is the trough
        //Valley B: [350, 100, 200, 400, 700]  // 100 is the trough
        //Neither mountains nor valleys:

        //Landscape A: [1, 2, 3, 2, 4, 1]  // 2 peaks (3, 4), not 1
        //Landscape B: [5, 4, 3, 2, 1]  // Peak cannot be a boundary element
        //Landscape B: [0, -1, -1, 0, -1, -1]  // 2 peaks (0)
        //Based on the rules above, write a function that takes in an array and returns either "mountain", "valley", or "neither".

        //Examples
        //LandscapeType([3, 4, 5, 4, 3]) ➞ "mountain"

        //LandscapeType([9, 7, 3, 1, 2, 4]) ➞ "valley"

        //LandscapeType([9, 8, 9]) ➞ "valley"

        //LandscapeType([9, 8, 9, 8]) ➞ "neither"
        //Notes
        //A peak is not exactly the same as the max of an array.The max is a unique number, but an array may have multiple peaks.However, if there exists only one peak in an array, then it is true that the peak = max.
        //See comments for a hint.
        string LandscapeType(int[] arr);
        //Tap code is a way to communicate messages via a series of taps(or knocks) for each letter in the message.Letters are arranged in a 5x5 polybius square, with the letter "K" being moved to the space with "C".

        //   1  2  3  4  5
        //1  A B C\K D  E
        //2  F G  H I  J
        //3  L M  N O  P
        //4  Q R  S T  U
        //5  V W  X Y  Z
        //Each letter is translated by tapping out the row and column number that the letter appears in, leaving a short pause in-between.If we use "." for each tap, and a single space to denote the pause:


        //text = "break"

        //"B" = (1, 2) = ". .."
        //"R" = (4, 2) = ".... .."
        //"E" = (1, 5) = ". ....."
        //"A" = (1, 1) = ". ."
        //"K" = (1, 3) = ". ..."
        //Another space is added between the groups of taps for each letter to give the final code:

        //"break" = ". .. .... .. . ..... . . . ..."
        //Write a function that returns the tap code if given a word, or returns the translated word(in lower case) if given the tap code.When translating from tap-code, default to the letter "c" if the tap-code ". ..." is found.

        //Examples
        //TapCode("break") ➞ ". .. .... .. . ..... . . . ..."

        //TapCode(".... ... ... ..... . ..... ... ... .... ....") ➞ "spent"
        //Notes
        //For more information on tap code, please see the resources section.The code was widely used in WW2 as a way for prisoners to communicate.

        string TapCode(string text);
    }
}
