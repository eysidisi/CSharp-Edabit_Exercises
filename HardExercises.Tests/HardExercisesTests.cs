using Exercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace HardExercises.Tests
{
    public class HardExercisesTests
    {
        IHardExercises hardExercises = new HardExerciseSolutions();

        [Theory]
        [InlineData("One two three four", "enO owt eerht four")]
        [InlineData("Make sure uoy only esrever sdrow of ddo length", "Make sure you only reverse words of odd length")]
        [InlineData("", "")]
        [InlineData("Bananas", "sananaB")]
        [InlineData("Even even even even even even even even even", "Even even even even even even even even even")]
        [InlineData("Odd odd odd odd odd odd odd odd odd odd odd", "ddO ddo ddo ddo ddo ddo ddo ddo ddo ddo ddo")]
        public void Exercise1_ShouldReturn(string str, string expected)
        {
            // Arrange

            // Act
            string actual = hardExercises.Exercise1(str);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 120, "qualified")]
        [InlineData(new int[] { 2, 3, 8, 6, 5, 12, 10, 18 }, 120, "qualified")]
        [InlineData(new int[] { 2, 3, 8, 6, 5, 12, 10, 18 }, 64, "qualified")]
        [InlineData(new int[] { 5, 5, 10, 10, 25, 15, 20, 20 }, 120, "disqualified")]
        [InlineData(new int[] { 5, 5, 10, 10, 15, 15, 20 }, 120, "disqualified")]
        [InlineData(new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 130, "disqualified")]
        [InlineData(new int[] { 5, 5, 10, 10, 15, 20, 50 }, 160, "disqualified")]
        [InlineData(new int[] { 5, 5, 10, 10, 15, 15, 40 }, 120, "disqualified")]
        [InlineData(new int[] { 10, 10, 15, 15, 20, 20 }, 150, "disqualified")]
        [InlineData(new int[] { 5, 5, 10, 20, 15, 15, 20, 20 }, 140, "disqualified")]
        public void Exercise2_ShouldReturn(int[] arr, int tot, string expected)
        {
            // Arrange

            // Act
            string actual = hardExercises.Exercise2(arr, tot);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(123, "321123")]
        [InlineData(123456789, "987654321123456789")]
        public void Exercise3_ShouldReturn(int i, string expected)
        {
            // Arrange

            // Act
            string actual = hardExercises.Exercise3(i);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Exercise4_ShouldReturn()
        {
            // Arrange

            // Act and Assert
            Assert.Equal("C", hardExercises.Exercise4(new String[] { "AB", "CA" }));
            Assert.Equal("C", hardExercises.Exercise4(new String[] { "AB", "CA", "AB" }));
            Assert.Equal("B", hardExercises.Exercise4(new String[] { "AC", "CA", "CA", "AC" }));
            Assert.Equal("A", hardExercises.Exercise4(new String[] { "BA", "AC", "CA", "BC" }));
            Assert.Equal("A", hardExercises.Exercise4(new String[] { "BC", "CB", "CA", "BA" }));
            Assert.Equal("C", hardExercises.Exercise4(new String[] { "BC" }));
            Assert.Equal("B", hardExercises.Exercise4(new String[] { "BA", "CA", "CB", "CA" }));
            Assert.Equal("B", hardExercises.Exercise4(new String[] { }));
        }

        [Theory]
        [InlineData(new int[] { 5, 1, 4, 3, 2 }, true)]
        [InlineData(new int[] { 55, 59, 58, 56, 57 }, true)]
        [InlineData(new int[] { -3, -2, -1, 1, 0 }, true)]
        [InlineData(new int[] { 5, 1, 4, 3, 2, 8 }, false)]
        [InlineData(new int[] { 5, 6, 7, 8, 9, 9 }, false)]
        [InlineData(new int[] { 5, 3 }, false)]
        public void Exercise5_ShouldReturn(int[] arr, bool expected)
        {
            // Arrange

            // Act
            bool actual = hardExercises.Exercise5(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 100, 12, 4, 1, 2 }, 15, new int[] { })]
        [InlineData(new int[] { 11, 2, 7, 3, 5, 0 }, 55, new int[] { 5, 11 })]
        [InlineData(new int[] { 1, 2, 3, 4, 13, 5 }, 39, new int[] { 3, 13 })]
        [InlineData(new int[] { 1, 2, -1, 4, 5 }, 20, new int[] { 4, 5 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 10, new int[] { 2, 5 })]
        public void Exercise6_ShouldReturn(int[] arr, int n, int[] expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.Exercise6(arr, n);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(5, 31, 33, 1)]
        [InlineData(4, 250, 1300, 3)]
        [InlineData(2, 49, 65, 2)]
        [InlineData(3, 1, 27, 3)]
        [InlineData(10, 1, 5, 1)]
        [InlineData(1, 1, 5, 5)]
        [InlineData(2, 1, 100, 10)]
        public void Exercise7_ShouldReturn(int power, int min, int max, int expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.Exercise7(power, min, max);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12, 13)]
        [InlineData(24, 29)]
        [InlineData(11, 11)]
        [InlineData(13, 13)]
        [InlineData(14, 17)]
        [InlineData(33, 37)]
        public void Exercise8_ShouldReturn(int num, int expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.Exercise8(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Wh*r* d*d my v*w*ls g*?", "eeioeo", "Where did my vowels go?")]
        [InlineData("abcd", "", "abcd")]
        [InlineData("*PP*RC*S*", "UEAE", "UPPERCASE")]
        [InlineData("Ch**s*, Gr*mm*t -- ch**s*", "eeeoieee", "Cheese, Grommit -- cheese")]
        [InlineData("*l*ph*nt", "Eea", "Elephant")]
        public void Exercise9_ShouldReturn(string txt, string vowels, string expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.Exercise9(txt, vowels);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("Marta appreciated deep perpendicular right trapezoids", true)]
        [InlineData("Someone is outside the doorway", false)]
        [InlineData("She eats super righteously", true)]
        [InlineData("Ben naps so often", true)]
        [InlineData("Cute triangles are cute", false)]
        [InlineData("Mad dislikes sharp pointy yoyos", true)]
        [InlineData("Rita asks Sam mean numbered dilemmas", true)]
        [InlineData("Marigold daffodils streaming happily.", false)]
        [InlineData("Simply wonderful laughing.", false)]
        public void Exercise10_ShouldReturn(string sentence, bool expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.Exercise10(sentence);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("#CD5C5C", true)]
        [InlineData("#EAECEE", true)]
        [InlineData("#eaecee", true)]
        [InlineData("#CD5C58C", false)]
        [InlineData("#CD5C5Z", false)]
        [InlineData("#CD5C&C", false)]
        [InlineData("CD5C5C", false)]
        [InlineData("#123CCCD", false)]
        [InlineData("#123456", true)]
        [InlineData("#987654", true)]
        [InlineData("#9876543", false)]
        [InlineData("#CCCCCC", true)]
        [InlineData("#ZCCZCC", false)]
        [InlineData("#Z88Z99", false)]
        [InlineData("#Z88!99", false)]
        public void Exercise11_ShouldReturn(string str, bool expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.Exercise11(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, "55")]
        [InlineData(20, "6765")]
        [InlineData(30, "832040")]
        [InlineData(40, "102334155")]
        [InlineData(50, "12586269025")]
        [InlineData(60, "1548008755920")]
        [InlineData(70, "190392490709135")]
        [InlineData(80, "23416728348467685")]
        [InlineData(90, "2880067194370816120")]
        [InlineData(98, "135301852344706746049")]
        [InlineData(100, "354224848179261915075")]
        [InlineData(110, "43566776258854844738105")]
        [InlineData(120, "5358359254990966640871840")]
        [InlineData(130, "659034621587630041982498215")]
        [InlineData(140, "81055900096023504197206408605")]
        [InlineData(150, "9969216677189303386214405760200")]
        [InlineData(160, "1226132595394188293000174702095995")]
        [InlineData(170, "150804340016807970735635273952047185")]
        [InlineData(180, "18547707689471986212190138521399707760")]
        [InlineData(190, "2281217241465037496128651402858212007295")]
        [InlineData(200, "280571172992510140037611932413038677189525")]
        public void Exercise12_ShouldReturn(int num, string expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.Exercise12(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, "Perfect")]
        [InlineData(2924, "Amicable")]
        [InlineData(5010, "Neither")]
        [InlineData(8128, "Perfect")]
        [InlineData(10744, "Amicable")]
        [InlineData(17296, "Amicable")]
        [InlineData(498, "Neither")]
        [InlineData(66992, "Amicable")]
        [InlineData(5566, "Neither")]
        public void Exercise13_ShouldReturn(int num, string expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.Exercise13(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Big Boi", "42 69 67 20 42 6f 69")]
        [InlineData("Marty Poppinson", "4d 61 72 74 79 20 50 6f 70 70 69 6e 73 6f 6e")]
        [InlineData("abcdefghi", "61 62 63 64 65 66 67 68 69")]
        [InlineData("oh dear", "6f 68 20 64 65 61 72")]
        [InlineData("i hate C#", "69 20 68 61 74 65 20 43 23")]
        [InlineData("i love C++ , not really", "69 20 6c 6f 76 65 20 43 2b 2b 20 2c 20 6e 6f 74 20 72 65 61 6c 6c 79")]
        public void Exercise14_ShouldReturn(string num, string expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.Exercise14(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(832, 594)]
        [InlineData(51, 36)]
        [InlineData(7977, 198)]
        [InlineData(1, 0)]
        [InlineData(665, 99)]
        [InlineData(149, 0)]
        public void Exercise15_ShouldReturn(int num, int expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.Exercise15(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("A4B5C2", "AAAABBBBBCC")]
        [InlineData("C2F1E5", "CCFEEEEE")]
        [InlineData("T4S2V2", "TTTTSSVV")]
        [InlineData("A1B2C3D4", "ABBCCCDDDD")]
        public void Exercise16_ShouldReturn(string num, string expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.Exercise16(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("(a*(b-c)     )", true)]
        [InlineData(" ) (a-b-45/7*(a-34))", false)]
        [InlineData("sin(90       )+      cos1)", false)]
        [InlineData(" (...). .%_.(.... )", true)]
        [InlineData(" (...)...(..(...).... )  ", true)]
        [InlineData(") .. .() (        ).. . (", false)]
        [InlineData(")))(((", false)]
        [InlineData("  (...).!.)...(", false)]
        [InlineData("a+b", true)]
        [InlineData("", true)]
        [InlineData("(a+f).`!£=.)...) ", false)]
        public void Brackets_ShouldReturn(string str, bool expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.Brackets(str);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(new int[] { 2, 2, 2, 3, 3 }, "2^3 x 3^2")]
        [InlineData(new int[] { 2, 7 }, "2 x 7")]
        [InlineData(new int[] { 2, 3, 3 }, "2 x 3^2")]
        [InlineData(new int[] { 2, 2, 2, 2, 2 }, "2^5")]
        [InlineData(new int[] { 2, 3, 7 }, "2 x 3 x 7")]
        [InlineData(new int[] { 2, 2, 7, 11 }, "2^2 x 7 x 11")]
        [InlineData(new int[] { 11, 11, 11 }, "11^3")]
        public void StringFactor_ShouldReturn(int[] arr, string expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.StringFactor(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 100, 24)]
        [InlineData(2, 128, 127)]
        [InlineData(3, 50, 22)]
        [InlineData(7, 98, 16)]
        [InlineData(11, 500, 49)]
        [InlineData(3, 600, 297)]
        [InlineData(7, 6, 0)]
        [InlineData(3, 1385, 688)]
        [InlineData(5, 4324, 1077)]
        [InlineData(2, 8663, 8655)]
        public void Legendre_ShouldReturn(int p, int n, int expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.Legendre(p, n);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("AA", 1)]
        [InlineData("ABABC", 2)]
        [InlineData("CABBACCC", 4)]
        [InlineData("AACDE", 1)]
        [InlineData("ACDBE", 0)]
        [InlineData("", 0)]
        [InlineData("ABABAB", 2)]
        [InlineData("AAAAA", 2)]
        [InlineData("AAACCBB", 3)]
        public void SockPairs_ShouldReturn(string socks, int expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.SockPairs(socks);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-1, 0, 25, new double[] { 0, 25d })]
        [InlineData(1, 10, 25, new double[] { -5d, 0d })]
        [InlineData(8, 4, 0, new double[] { -0.25d, -0.5d })]
        [InlineData(4, -200, 1000, new double[] { 25d, -1500d })]
        [InlineData(1, -50, -1000, new double[] { 25d, -1625d })]
        [InlineData(-1, 20, 600, new double[] { 10d, 700d })]
        [InlineData(5, 1, 20, new double[] { -0.1d, 19.95d })]
        public void FindVertex_ShouldReturn(int a, int b, int c, double[] expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.FindVertex(a, b, c);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("abcde", 0)]
        [InlineData("Aa", 0)]
        [InlineData("aabbcde", 2)]
        [InlineData("aabbcdeB", 2)]
        [InlineData("indivisibility", 1)]
        [InlineData("Indivisibilities", 2)]
        [InlineData("aa1112", 2)]
        [InlineData("bb2c", 1)]
        public void DuplicateCount_ShouldReturn(string str, int expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.DuplicateCount(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("abcdcbg", true)]
        [InlineData("abccia", true)]
        [InlineData("abcdaaa", false)]
        [InlineData("gggfgig", true)]
        [InlineData("gggffff", false)]
        [InlineData("GIGGG", true)]
        [InlineData("ggggi", true)]
        [InlineData("ggggg", false)]
        [InlineData("gggfggg", false)]
        [InlineData("1234312", false)]
        public void AlmostPalindrome_ShouldReturn(string str, bool expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.AlmostPalindrome(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("pitiful", "beautiful", "tiful")]
        [InlineData("truck", "trick", "ck")]
        [InlineData("vote", "asymptote", "ote")]
        [InlineData("multiplication", "ration", "ation")]
        [InlineData("potent", "tent", "tent")]
        [InlineData("skyscraper", "carnivore", "")]
        public void LongestCommonEnding_ShouldReturn(string str1, string str2, string expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.LongestCommonEnding(str1, str2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(4, 1)]
        [InlineData(5, 5)]
        [InlineData(31, 31)]
        [InlineData(82, 37)]
        [InlineData(90, 45)]
        [InlineData(255, 255)]
        [InlineData(446, 251)]
        [InlineData(451, 391)]
        [InlineData(634, 377)]
        [InlineData(776, 67)]
        [InlineData(898, 263)]
        [InlineData(1103, 1937)]
        [InlineData(3801, 2487)]
        [InlineData(4096, 1)]
        [InlineData(8505, 10017)]
        [InlineData(428293, 328843)]
        [InlineData(547643, 904609)]
        [InlineData(612965, 681385)]
        [InlineData(999999, 1033263)]
        public void ReversedBinaryInteger_ShouldReturn(int num, int expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.ReversedBinaryInteger(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Wednesday is hump day, but has anyone asked the camel if he’s happy about it?", "23 5 4 14 5 19 4 1 25 9 19 8 21 13 16 4 1 25 2 21 20 8 1 19 1 14 25 15 14 5 1 19 11 5 4 20 8 5 3 1 13 5 12 9 6 8 5 19 8 1 16 16 25 1 2 15 21 20 9 20")]
        [InlineData("Check back tomorrow; I will see if the book has arrived.", "3 8 5 3 11 2 1 3 11 20 15 13 15 18 18 15 23 9 23 9 12 12 19 5 5 9 6 20 8 5 2 15 15 11 8 1 19 1 18 18 9 22 5 4")]
        [InlineData("We have a lot of rain in June.", "23 5 8 1 22 5 1 12 15 20 15 6 18 1 9 14 9 14 10 21 14 5")]
        [InlineData("Sixty-Four comes asking for bread.", "19 9 24 20 25 6 15 21 18 3 15 13 5 19 1 19 11 9 14 7 6 15 18 2 18 5 1 4")]
        [InlineData("The#b00k$is*in^fr0nt#0f!the_taBle.", "20 8 5 2 11 9 19 9 14 6 18 14 20 6 20 8 5 20 1 2 12 5")]
        [InlineData("Lets all be unique together until we realise we are all the same.", "12 5 20 19 1 12 12 2 5 21 14 9 17 21 5 20 15 7 5 20 8 5 18 21 14 20 9 12 23 5 18 5 1 12 9 19 5 23 5 1 18 5 1 12 12 20 8 5 19 1 13 5")]
        [InlineData("The river stole the gods.", "20 8 5 18 9 22 5 18 19 20 15 12 5 20 8 5 7 15 4 19")]
        [InlineData("Wow, does that work?", "23 15 23 4 15 5 19 20 8 1 20 23 15 18 11")]
        [InlineData("If Purple People Eaters are real… where do they find purple people to eat?", "9 6 16 21 18 16 12 5 16 5 15 16 12 5 5 1 20 5 18 19 1 18 5 18 5 1 12 23 8 5 18 5 4 15 20 8 5 25 6 9 14 4 16 21 18 16 12 5 16 5 15 16 12 5 20 15 5 1 20")]
        [InlineData("Abstraction is often one floor above you.", "1 2 19 20 18 1 3 20 9 15 14 9 19 15 6 20 5 14 15 14 5 6 12 15 15 18 1 2 15 22 5 25 15 21")]
        public void AlphabetIndex_ShouldReturn(string str, string expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.AlphabetIndex(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 3, '0', new string[] {
        "000",
        "0 0",
        "000" })]
        [InlineData(4, 5, '#', new string[] {
        "####",
        "#  #",
        "#  #",
        "#  #",
        "####" })]
        [InlineData(10, 3, '*', new string[] {
        "**********",
        "*        *",
        "**********" })]
        [InlineData(1, 6, '/', new string[] { "invalid" })]
        [InlineData(3, 2, '$', new string[] { "invalid" })]
        [InlineData(8, 8, '-', new string[] {
        "--------",
        "-      -",
        "-      -",
        "-      -",
        "-      -",
        "-      -",
        "-      -",
        "--------" })]
        public void GetFrame_ShouldReturn(int w, int h, char ch, string[] expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.GetFrame(w, h, ch);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(887, 888)]
        [InlineData(888, 888)]
        [InlineData(27, 22)]
        [InlineData(519, 515)]
        [InlineData(4892, 4884)]
        [InlineData(1, 1)]
        [InlineData(100, 99)]
        [InlineData(33344, 33333)]
        [InlineData(123456, 123321)]
        [InlineData(978215236, 978212879)]
        public void ClosestPalindrome_ShouldReturn(int num, int expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.ClosestPalindrome(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(31, 7)]
        [InlineData(150, 30)]
        [InlineData(200, 56)]
        [InlineData(15, 3)]
        [InlineData(151, 47)]
        [InlineData(160, 48)]
        [InlineData(300, 92)]
        public void Cal_ShouldReturn(int num, int expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.Cal(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Sam I am!", "Green eggs and ham.", true)]
        [InlineData("Sam I am!", "Green eggs and HAM.", true)]
        [InlineData("head straight to town", "give me not a frown", true)]
        [InlineData("with an unpleasant bump", "in a slump", true)]
        [InlineData("your elbow and chin!", "how much can you win?", true)]
        [InlineData("you will start to race", "the waiting Place", true)]
        [InlineData("All that waiting and staying.", "where the band are playing.", true)]
        [InlineData("You are off to the races", "a splendid day.", false)]
        [InlineData("and frequently do?", "you gotta move.", false)]
        [InlineData("down by the bay", "where the watermelons grow", false)]
        [InlineData("back to my home", "i dare not go", false)]
        public void DoesRhyme_ShouldReturn(string str1, string str2, bool expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.DoesRhyme(str1, str2);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(1970, 9, 21, "maandag")]
        [InlineData(1970, 9, 22, "dinsdag")]
        [InlineData(1970, 9, 23, "woensdag")]
        [InlineData(1970, 9, 24, "donderdag")]
        [InlineData(1970, 9, 25, "vrijdag")]
        [InlineData(1970, 9, 26, "zaterdag")]
        [InlineData(1970, 9, 27, "zondag")]
        public void WeekdayRobWasBornInDutch_ShouldReturn(int year, int month, int day, string expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.WeekdayRobWasBornInDutch(year, month, day);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Sshe ssselects to eat that apple.", true)]
        [InlineData("She ssselects to eat that apple.", false)]
        [InlineData("You ssseldom sssspeak sso boldly, ssso messmerizingly.", true)]
        [InlineData("Steve likes to eat pancakes", false)]
        [InlineData("Sssteve likess to eat pancakess", true)]
        [InlineData("Beatrice samples lemonade", false)]
        [InlineData("Beatrice enjoysss lemonade", true)]
        public void IsParselTongue_ShouldReturn(string sentence, bool expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.IsParselTongue(sentence);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 21)]
        [InlineData(9, 2221)]
        [InlineData(15, 2227)]
        [InlineData(17, 22221)]
        [InlineData(19, 22223)]
        [InlineData(24, 22228)]
        [InlineData(35, 222223)]
        public void MysteryFunc_ShouldReturn(int num, int expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.MysteryFunc(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("$200, £40, £60, $1k", 1200)]
        [InlineData("$10, $40, £60, $200", 250)]
        [InlineData("$10k", 10000)]
        [InlineData("£400, $200, £40, £60", 200)]
        [InlineData("$20k, $100, £40", 20100)]
        [InlineData("$100", 100)]
        [InlineData("$100k", 100000)]
        public void AddBill_ShouldReturn(string money, int expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.AddBill(money);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("edabit", "edabit")]
        [InlineData("hello_edabit", "helloEdabit")]
        [InlineData("is_modal_open", "isModalOpen")]
        [InlineData("get_background_color", "getBackgroundColor")]
        [InlineData("is_loading", "isLoading")]
        [InlineData("x", "x")]
        public void ToCamelCase_ShouldReturn(string str, string expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.ToCamelCase(str);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("edabit", "edabit")]
        [InlineData("helloEdabit", "hello_edabit")]
        [InlineData("isModalOpen", "is_modal_open")]
        [InlineData("getBackgroundColor", "get_background_color")]
        [InlineData("isLoading", "is_loading")]
        [InlineData("x", "x")]
        public void ToSnakeCase_ShouldReturn(string str, string expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.ToSnakeCase(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Unscrupulous", 2, new string[] { "Unscru", "pulous" })]
        [InlineData("Incomprehensible", 4, new string[] { "Inco", "mpre", "hens", "ible" })]
        [InlineData("Evaluation", 10, new string[] { "E", "v", "a", "l", "u", "a", "t", "i", "o", "n" })]
        [InlineData("Strengthened", 6, new string[] { "St", "re", "ng", "th", "en", "ed" })]
        [InlineData("Fool's Errand", 20, new string[] { "Error" })]
        [InlineData("Flavorless", 1, new string[] { "Flavorless" })]
        [InlineData("Evolutionary Biology", 8, new string[] { "Error" })]
        [InlineData("Indefatigable Defender", 2, new string[] { "Indefatigab", "le Defender" })]
        [InlineData("Unimaginatively", 3, new string[] { "Unima", "ginat", "ively" })]
        [InlineData("Peppered Moth", 6, new string[] { "Error" })]
        public void SplitNCases_ShouldReturn(string input, int cases, string[] expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.SplitNCases(input, cases);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(221333, 221333)]
        [InlineData(136116, 312332)]
        [InlineData(2, 1)]
        [InlineData(3410515780, 1122222112)]
        [InlineData(24677734541, 13133313131)]
        [InlineData(79825929634, 13121323111)]
        [InlineData(36123594675, 22112211212)]
        [InlineData(62849835970, 11212211211)]
        [InlineData(29081455325, 21111133123)]
        [InlineData(94717270184, 12323131212)]
        [InlineData(72017589759, 31113212322)]
        [InlineData(53569357419, 32312231112)]
        [InlineData(33879999825, 22214444211)]
        [InlineData(33600360627, 33333333311)]
        [InlineData(12594580129, 22221211222)]
        [InlineData(36852564216, 13122231213)]
        [InlineData(34415793631, 32221113132)]
        [InlineData(76384607724, 32112213312)]
        [InlineData(8604519582, 2111211221)]
        [InlineData(70209476552, 22221121222)]
        [InlineData(20036302062, 34422243423)]
        [InlineData(77674727011, 55151515122)]
        [InlineData(17597066090, 12122322323)]
        [InlineData(79082080537, 21321323112)]
        [InlineData(30187177000, 14213233444)]
        [InlineData(72916170033, 21121222222)]
        [InlineData(11314637247, 33232122122)]
        [InlineData(69095956141, 23132322212)]
        [InlineData(66117263379, 33222132221)]
        [InlineData(30491133624, 31212233112)]
        public void DigitCount_ShouldReturn(long num, long expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.DigitCount(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new long[] { 100 }, 5050)]
        [InlineData(new long[] { 1, 100 }, 5050)]
        [InlineData(new long[] { 5000 }, 12502500)]
        [InlineData(new long[] { 5001, 7000 }, 12001000)]
        [InlineData(new long[] { 3, 5 }, 12)]
        [InlineData(new long[] { 1800, 250 }, 1589775)]
        [InlineData(new long[] { 1, 5000 }, 12502500)]
        [InlineData(new long[] { 5, 500 }, 125240)]
        [InlineData(new long[] { 1975, 165 }, 1937770)]
        [InlineData(new long[] { 50000 }, 1250025000)]
        [InlineData(new long[] { 28, 123 }, 7248)]
        [InlineData(new long[] { 7000, 5001 }, 12001000)]
        [InlineData(new long[] { 0, 100 }, 5050)]
        [InlineData(new long[] { 5000, 1 }, 12502500)]
        [InlineData(new long[] { 100, 1 }, 5050)]
        public void Gauss_ShouldReturn(long[] arr, long expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.Gauss(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("   ###   /    #    /    #    /#   #   #/#########/#   #   #/    #    /    #    /   ###   ", 2)]
        [InlineData("         /         /         /#########/#   #   #/#########/         /         /         ", 2)]
        [InlineData("#########/#       #/#   #   #/#   #   #/#### ####/#   #   #/#   #   #/#       #/#########", 4)]
        [InlineData("# # # # #/ # # # # /# # # # #/ # # # # /# # # # #/ # # # # /# # # # #/ # # # # /# # # # #", 0)]
        [InlineData("    #    /#########/#########/#########/#########/#########/#########/#########/ ####### ", 8)]
        [InlineData("#########/    #   #/ ########/    #   #/#########/#   #    /######## /#   #    /#########", 4)]
        [InlineData("#########/#########/#########/#########/#########/#########/#########/#########/#########", 18)]
        [InlineData("# # # # #/# # # # #/# # # # #/# # # # #/#########/# # # # #/# # # # #/# # # # #/# # # # #", 6)]
        [InlineData("### #####/# # #   #/# # # ###/#   #    /#########/    #   #/### # # #/#   # # #/##### ###", 2)]
        [InlineData("##     ##/##     ##/##     ##/##     ##/#########/##     ##/##     ##/##     ##/##     ##", 5)]
        public void BridgesII_ShouldReturn(string str, int expected)
        {
            // Arrange

            // Act
            var actual = hardExercises.BridgesII(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(98, 16)]
        [InlineData(435, 74)]
        [InlineData(534, 188)]
        [InlineData(3123, 353)]
        [InlineData(1232, 1931)]
        [InlineData(12, 7)]
        [InlineData(31232, 32630)]
        [InlineData(4234, 208)]
        [InlineData(655, 0)]
        [InlineData(432, 1240)]
        [InlineData(2343, 170)]
        public void SumFF_ShouldReturn(int a, int expected)
        {
            // Arrange
            // Act
            var actual = hardExercises.SumFF(a);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(444, 44, true)]
        [InlineData(1222345, 12345, false)]
        [InlineData(12345, 12345, false)]
        [InlineData(888, 888, true)]
        [InlineData(666789, 12345667, true)]
        [InlineData(10560002, 100, true)]
        [InlineData(1, 1, false)]
        public void Trouble_ShouldReturn(long num1, long num2, bool expected)
        {
            // Arrange
            // Act
            var actual = hardExercises.Trouble(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("A B C.", 1.00)]
        [InlineData("What a gorgeous day.", 4.00)]
        [InlineData("Dude, this is so awesome!", 3.80)]
        [InlineData("Working on my tan right now.", 3.67)]
        [InlineData("Having a blast partying in Las Vegas.", 4.29)]
        [InlineData("Have you ever wondered what Saturn looks like?", 4.75)]
        [InlineData("I just planted a young oak tree, wonder how tall it will grow in a few years?", 3.47)]
        public void AverageWordLength_ShouldReturn(string str, double expected)
        {
            // Arrange
            // Act
            var actual = hardExercises.AverageWordLength(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("one one one one zero zero zero zero", "11110000")]
        [InlineData("one Zero zero one zero zero one one one one one zero oNe one one zero one zerO", "1001001111101110")]
        [InlineData("one zero one", "")]
        [InlineData("one zero zero one zero ten one one one one two", "10010111")]
        [InlineData("One zero zero one zero one one one zero one one zero zero zero zero one zero one one one zero one one zero zero zero zero one zero one one one zero one one zero zero zero zero one zero one one one zero one one zero zero zero zero one zero one one one zero one one zero zero zero zero one zero", "1001011101100001011101100001011101100001011101100001011101100001")]
        [InlineData("TWO one zero one one zero one zero", "")]
        [InlineData("TWO one zero one one zero one zero one", "10110101")]
        public void TextToNumberBinary_ShouldReturn(string str, string expected)
        {
            // Arrange
            // Act
            var actual = hardExercises.TextToNumberBinary(str);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(0, 3, 6)]
        [InlineData(0, 8, 4)]
        [InlineData(4, 8, 0)]
        [InlineData(2, 5, 8)]
        [InlineData(1, 7, 4)]
        [InlineData(0, 2, 1)]
        public void BlockPlayer_ShouldReturn(int a, int b, int expected)
        {
            // Arrange
            // Act
            var actual = hardExercises.BlockPlayer(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 20, 30, 10, 40 }, new int[] { -10, 10 })]
        [InlineData(new int[] { 10, -10, -10, 10 }, new int[] { -20, 20 })]
        [InlineData(new int[] { }, new int[] { 0, 0 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, new int[] { 6, 5 })]
        [InlineData(new int[] { 1, 0, 2, 0, 3, 0, 4, 0, 5, 0 }, new int[] { 0, 3 })]
        [InlineData(new int[] { 0, 1, 0, 2, 0, 3, 0, 4, 0, 5 }, new int[] { 3, 0 })]

        public void TrackRobot_ShouldReturn(int[] steps, int[] expected)
        {
            // Arrange
            // Act
            var actual = hardExercises.TrackRobot(steps);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("abc", 1)]
        [InlineData("abcabcabc", 3)]
        [InlineData("abab", 2)]
        [InlineData("LVLVLVLV", 4)]
        [InlineData("inkinkinkinkinkink", 6)]
        [InlineData("abcdabcdabcdabcdabcdabcdabcd", 7)]
        [InlineData("abcdefghijklmenopqrstuvwxyzabcdefghijklmenopqrstuvwxyzabcdefghijklmenopqrstuvwxyzabcdefghijklmenopqrstuvwxyzabcdefghijklmenopqrstuvwxyzabcdefghijklmenopqrstuvwxyzabcdefghijklmenopqrstuvwxyzabcdefghijklmenopqrstuvwxyzabcdefghijklmenopqrstuvwxyzabcdefghijklmenopqrstuvwxyzabcdefghijklmenopqrstuvwxyzabcdefghijklmenopqrstuvwxyzabcdefghijklmenopqrstuvwxyzabcdefghijklmenopqrstuvwxyzabcdefghijklmenopqrstuvwxyzabcdefghijklmenopqrstuvwxyzabcdefghijklmenopqrstuvwxyzabcdefghijklmenopqrstuvwxyzabcdefghijklmenopqrstuvwxyzabcdefghijklmenopqrstuvwxyzabcdefghijklmenopqrstuvwxyz", 21)]
        public void NumberOfRepeats_ShouldReturn(string str, int expected)
        {
            // Arrange
            // Act
            var actual = hardExercises.NumberOfRepeats(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("//////", true)]
        [InlineData("/**//**////**/", true)]
        [InlineData("/**//**//**//**/", true)]
        [InlineData("///**///", true)]
        [InlineData("/**//////**//**////**/////", true)]
        [InlineData("//", true)]
        [InlineData("/**/", true)]
        [InlineData("///*/**/", false)]
        [InlineData("//*/**/", false)]
        [InlineData("/////", false)]
        [InlineData("///", false)]
        [InlineData("/**///**/", false)]
        [InlineData("/**/////**/", false)]
        public void CommentsCorrect_ShouldReturn(string str, bool expected)
        {
            // Arrange
            // Act
            var actual = hardExercises.CommentsCorrect(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrintGrid_ShouldReturn()
        {
            // Arrange
            var inputs = new Dictionary<(int, int), int[,]>()
            {
                [(3, 6)] = new int[,] { { 1, 4, 7, 10, 13, 16 }, { 2, 5, 8, 11, 14, 17 }, { 3, 6, 9, 12, 15, 18 } },
                [(5, 3)] = new int[,] { { 1, 6, 11 }, { 2, 7, 12 }, { 3, 8, 13 }, { 4, 9, 14 }, { 5, 10, 15 } },
                [(4, 1)] = new int[,] { { 1 }, { 2 }, { 3 }, { 4 } },
                [(10, 2)] = new int[,] { { 1, 11 }, { 2, 12 }, { 3, 13 }, { 4, 14 }, { 5, 15 }, { 6, 16 }, { 7, 17 }, { 8, 18 }, { 9, 19 }, { 10, 20 } },

            };

            // Act
            foreach (var input in inputs)
            {
                var actual = hardExercises.PrintGrid(input.Key.Item1, input.Key.Item2);

                // Assert
                Assert.Equal(input.Value, actual);
            }
        }

        [Theory]
        [InlineData("?", new[] { 63 })]
        [InlineData("It's a secret!", new[] { 73, 43, -77, 76, -83, 65, -65, 83, -14, -2, 15, -13, 15, -83 })]
        [InlineData("Sunshine", new[] { 83, 34, -7, 5, -11, 1, 5, -9 })]
        public void Encrypt_ShouldReturn(string str, int[] expected)
        {
            // Arrange
            // Act
            var actual = hardExercises.Encrypt(str);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(new[] { 84, 20, -3, -69, 78, -9, 4, -2, 1, -6, 13, 6, -3, 1, -83, 65, 17, -13, -69, 83, 1, -2, -17, 13, -7, -2, -55, 0 }, "The neighbours are strange..")]
        [InlineData(new[] { 79, -4 }, "OK")]
        [InlineData(new[] { 84, 27, -2, 2, 3, 0, -3, 8, -75, -12, 19, -19, 80, -3, -77, 73, 5, -78, 84, -12, -3, -69, 71, -6, 17, -14, 1, 9, -64 }, "Tomorrow, 3 pm in the garden.")]
        public void Decrypt_ShouldReturn(int[] arr, string expected)
        {
            // Arrange
            // Act
            var actual = hardExercises.Decrypt(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 12, 22, 4, 35, 10, 14)]
        [InlineData(12, 12, 12, 13, 13, 13, 6)]
        [InlineData(6, 33, 15, 9, 55, 10, 0)]
        [InlineData(11, 00, 11, 11, 00, 11, 1)]
        [InlineData(10, 22, 01, 12, 22, 21, 13)]

        public void PalendromeTimestamps_ShouldReturn(int h1, int m1, int s1, int h2, int m2, int s2, int expected)
        {
            // Arrange
            // Act
            var actual = hardExercises.PalendromeTimestamps(h1, m1, s1, h2, m2, s2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 4, 4, 4, 4, 4 }, 2, false)]
        [InlineData(new int[] { 5, 4, 3, 2, 2, 2, 2 }, 2, false)]
        [InlineData(new int[] { 4, 6, 1, 9, 6, 1, 1, 9, 2, 9 }, 5, true)]
        [InlineData(new int[] { 2, 2, 10, 10, 1, 5, 2 }, 4, true)]
        [InlineData(new int[] { 9, 6, 2, 3, 1, 2, 4, 8, 3, 1, 3 }, 4, false)]
        [InlineData(new int[] { 2, 5, 1, 6, 2, 9, 5, 2, 1, 6, 1, 6, 6, 1 }, 5, false)]
        [InlineData(new int[] { 2, 5, 1, 6, 2, 9, 5, 2, 1, 6, 1, 6, 6, 1 }, 6, true)]
        [InlineData(new int[] { 1, 2, 3, 2, 6, 4, 1 }, 2, true)]
        [InlineData(new int[] { 1, 1, 2, 1, 2, 10, 2, 2, 5, 1, 5 }, 4, true)]
        [InlineData(new int[] { 8, 3, 2, 1, 1, 2, 1, 3, 2, 1 }, 3, true)]
        [InlineData(new int[] { 10 }, 1, true)]

        public void CanFit_ShouldReturn(int[] weights, int bags, bool expected)
        {
            // Arrange
            // Act
            var actual = hardExercises.CanFit(weights, bags);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("3 < 7 < 11", true)]
        [InlineData("13 > 44 > 33 > 1", false)]
        [InlineData("1 < 2 < 6 < 9 > 3", true)]
        [InlineData("4 > 3 > 2 > 1", true)]
        [InlineData("5 < 7 > 1", true)]
        [InlineData("5 > 7 > 1", false)]
        [InlineData("9 < 9", false)]
        public void CorrectSigns_ShouldReturn(string str, bool expected)
        {
            // Arrange
            // Act
            var actual = hardExercises.CorrectSigns(str);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(new int[] { 2, 7, 6, 9, 5, 1, 4, 3, 8 }, true)]
        [InlineData(new int[] { 2, 7, 600, 9, 5, 1, -94, 3, 8 }, false)]
        [InlineData(new int[] { 2, 7, 50, 9, 555, 1, -9, 3, 8 }, false)]
        [InlineData(new int[] { 16, 3, 2, 13, 5, 10, 11, 8, 9, 6, 7, 12, 4, 15, 14, 1 }, true)]
        [InlineData(new int[] { 7, 12, 1, 14, 2, 13, 8, 11, 16, 3, 10, 5, 9, 6, 15, 4 }, true)]
        [InlineData(new int[] { 7, 12, 1, 14, 2, 13, 8, 11, 16, 3, 10, 5, 9, 6, 16, 5 }, false)]
        [InlineData(new int[] { 1, 14, 14, 4, 11, 7, 6, 9, 8, 10, 10, 5, 13, 2, 3, 15 }, true)]
        [InlineData(new int[] { 1, 14, 14, 4, 11, 7, 6, 9, 8, 11, 10, 5, 13, 2, 3, 15 }, false)]
        [InlineData(new int[] { 1, 15, 4, 14, 10, 11, 5, 8, 7, 6, 12, 9, 16, 2, 13, 3 }, false)]
        public void IsMagicSquare_ShouldReturn(int[] arr, bool expected)
        {
            // Arrange
            // Act
            var actual = hardExercises.IsMagicSquare(arr);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("ABACADAEAFAGAHAIAJA", true)]
        [InlineData("ABA", true)]
        [InlineData("ABBACCA", false)]
        [InlineData("ACAC", false)]
        [InlineData("A", false)]
        [InlineData("AB", false)]
        [InlineData("ABAC", false)]
        [InlineData("ABACA", true)]
        [InlineData("ABACADA", true)]
        [InlineData("ABACADAEA", true)]
        [InlineData("ABACADAEAFA", true)]
        [InlineData("ABACADAEAFAGA", true)]
        [InlineData("ABACADAEAFAGAHA", true)]
        [InlineData("ABACADAEAFAGAHAIA", true)]
        [InlineData("ABACADAEAFAGAHAIAJAKALAMANA", true)]
        [InlineData("ABACADAEAAGAHAIAJAKALAMANA", false)]
        [InlineData("ABACADAEAAGAHAIAJAKALAM", false)]
        [InlineData("HELLO", false)]
        public void ValidRondo_ShouldReturn(string s, bool expected)
        {
            // Arrange
            // Act
            var actual = hardExercises.ValidRondo(s);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(10, 15, "a")]
        [InlineData(13, 16, "b")]
        [InlineData(53782, 72534, "b")]
        [InlineData(72221, 11198, "b")]
        [InlineData(1723817263, 837249873748, "a")]
        [InlineData(556238, 667822, "b")]
        [InlineData(4, 3, "a")]
        public void Collatz_ShouldReturn(long a, long b, string expected)
        {
            // Arrange
            // Act
            var actual = hardExercises.Collatz(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Hello, World!", 2, "llo, World!He")]
        [InlineData("From what I gathered", -4, "eredFrom what I gath")]
        [InlineData("No Changes", 0, "No Changes")]
        [InlineData("S", -60, "S")]
        [InlineData("Subordinating", 2, "bordinatingSu")]
        [InlineData("Assemblywomen", -6, "ywomenAssembl")]
        [InlineData("Pedantic", 4, "nticPeda")]
        [InlineData("Nonscience", -116, "cienceNons")]
        [InlineData("Excelsior", 30, "elsiorExc")]
        [InlineData("Incomprehensibilities", 50, "hensibilitiesIncompre")]
        public void WrapAround_ShouldReturn(string input, int offset, string expected)
        {
            // Arrange
            // Act
            var actual = hardExercises.WrapAround(input, offset);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(159780, true)]
        [InlineData(112, true)]
        [InlineData(10, false)]
        [InlineData(1034, true)]
        [InlineData(343, false)]
        [InlineData(1119444, true)]
        [InlineData(6666, true)]
        [InlineData(9777771, false)]
        public void BreakPoint_ShouldReturn(int num, bool expected)
        {
            // Arrange
            // Act
            var actual = hardExercises.BreakPoint(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("4089", "5672", 9)]
        [InlineData("1732", "4444", 9)]
        [InlineData("7109", "2332", 13)]
        [InlineData("2391", "4984", 10)]
        [InlineData("1234", "3456", 8)]
        [InlineData("1111", "1100", 2)]
        [InlineData("1111", "0000", 4)]
        [InlineData("0000", "9999", 4)]
        public void MinTurns_ShouldReturn(string current, string target, int expected)
        {
            // Arrange
            // Act
            var actual = hardExercises.MinTurns(current, target);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("12:00 am", "0:00")]
        [InlineData("6:20 pm", "18:20")]
        [InlineData("21:00", "9:00 pm")]
        [InlineData("5:05", "5:05 am")]
        public void ConvertTime_ShouldReturn(string time, string expected)
        {
            // Arrange
            // Act
            var actual = hardExercises.ConvertTime(time);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Fun times!", "GvO Ujnft!")]
        [InlineData("The quick brown fox.", "UIf rvjdl cspxO gpy.")]
        [InlineData("Omega", "Pnfhb")]
        [InlineData("I will never be this young again. Ever. Oh damn… I just got older.", "J xjmm Ofwfs cf UIjt zpvOh bhbjO. Fwfs. PI EbnO… J kvtU hpU pmEfs.")]
        [InlineData("Should we start class now, or should we wait for everyone to get here?", "TIpvmE xf tUbsU dmbtt Opx, ps tIpvmE xf xbjU gps fwfszpOf Up hfU Ifsf?")]
        [InlineData("Check back tomorrow; I will see if the book has arrived.", "DIfdl cbdl Upnpsspx; J xjmm tff jg UIf cppl Ibt bssjwfE.")]
        [InlineData("The lake is a long way from here.", "UIf mblf jt b mpOh xbz gspn Ifsf.")]
        [InlineData("It was getting dark, and we weren’t there yet.", "JU xbt hfUUjOh Ebsl, bOE xf xfsfO’U UIfsf zfU.")]
        [InlineData("The mysterious diary records the voice.", "UIf nztUfsjpvt Ejbsz sfdpsEt UIf wpjdf.")]
        [InlineData("Cats are good pets, for they are clean and are not noisy.", "DbUt bsf hppE qfUt, gps UIfz bsf dmfbO bOE bsf OpU Opjtz.")]
        [InlineData("abcz", "bcdA")]
        [InlineData("ABCZ", "BCDA")]
        public void Mangle_ShouldReturn(string str, string expected)
        {
            // Arrange
            // Act
            var actual = hardExercises.Mangle(str);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("ABC", "Ican'tsingmyABC", true)]
        [InlineData("abc", "Ican'tsingmyABC", true)]
        [InlineData("Ican'tsingmyABC", "abc", true)]
        [InlineData("*bc", "Ican'tsingmyABC", true)]
        [InlineData("abc", "Ican'tsingmy***", true)]
        [InlineData("ab", "Ican'tsingmy**c", false)]
        [InlineData("hello world", "hello", false)]
        [InlineData("+=", "this should work too +=", true)]
        [InlineData("don't forget hyphens-", "-", true)]
        [InlineData("don't forget periods ", ".", false)]
        [InlineData("this will always be true", "*", true)]
        [InlineData("this will always be false", "F", false)]
        [InlineData("hey", "*********", true)]
        [InlineData("a*c", "*b*", true)]
        [InlineData("last test", "congrats you passed the last test", true)]
        public void Overlap_ShouldReturn(string str1, string str2, bool expected)
        {
            // Arrange
            // Act
            var actual = hardExercises.Overlap(str1, str2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("acabbaa", true)]
        [InlineData("aacbdbc", true)]
        [InlineData("aacbdb", false)]
        [InlineData("abacbb", false)]
        [InlineData("abb", true)]
        [InlineData("bbb", true)]
        [InlineData("bbaa", true)]
        [InlineData("bbaacc", true)]
        [InlineData("bbaaccd", true)]
        [InlineData("bbaacd", false)]
        [InlineData("abc", false)]
        [InlineData("ab", false)]
        [InlineData("aabbccddef", false)]
        public void PossiblePalindrome_ShouldReturn(string str, bool expected)
        {
            // Arrange
            // Act
            var actual = hardExercises.PossiblePalindrome(str);

            // Assert
            Assert.Equal(expected, actual);
        }



        [Theory]
        [InlineData("abcd", 1, "bcde")]
        [InlineData("abcd", -1, "zabc")]
        [InlineData("abcd", 3, "defg")]
        [InlineData("abcd", 25, "zabc")]
        [InlineData("abcd", 26, "abcd")]
        [InlineData("abcd", 27, "bcde")]
        [InlineData("abcd", 0, "abcd")]
        public void RollingCipher_ShouldReturn(string str, int n, string expected)
        {
            // Arrange
            // Act
            var actual = hardExercises.RollingCipher(str, n);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, "1/2")]
        [InlineData(15, 27, "5/9")]
        [InlineData(-3, 4, "-3/4")]
        [InlineData(-5, -3, "5/3")]
        [InlineData(10, 5, "2")]
        public void TestRational_Create(int num, int denom, string expected)
        {
            // Arrange
            // Act
            var actual = new Rational(num, denom).ToString();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestRational_ThrowsArgumentException()
        {
            //arrange
            // act & assert
            Assert.Throws<ArgumentException>(() => new Rational(1, 0));
        }

        [Theory]
        [InlineData(1, 2, 1)]
        [InlineData(15, 27, 5)]
        [InlineData(-3, 4, -3)]
        [InlineData(-5, -3, 5)]
        [InlineData(10, 5, 2)]
        public void TestRational_Numerator(int num, int denom, int expected)
        {
            // Act
            var actual = new Rational(num, denom).Numerator;

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(15, 27, 9)]
        [InlineData(-3, 4, 4)]
        [InlineData(-5, -3, 3)]
        [InlineData(10, 5, 1)]
        [InlineData(0, 5, 1)]
        public void TestRational_Denominator(int num, int denom, int expected)
        {
            // Act
            var actual = new Rational(num, denom).Denominator;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("68 65 6c 6c 6f 20 77 6f 72 6c 64", "world", 6)]
        [InlineData("47 6f 6f 64 62 79 65 20 77 6f 72 6c 64", "world", 8)]
        [InlineData("74 68 65 20 6e 65 65 64 6c 65 20 69 73 20 74 6f 20 62 65 20 66 6f 75 6e 64", "needle", 4)]
        [InlineData("a3 24 25 2d 2d 2d a3 24 20 77 6f 72 6c 64 2d 2d 2d", "world", 9)]
        [InlineData("42 6f 72 65 64 20 77 6f 72 6c 64", "Bored", 0)]
        public void FirstIndex_ShouldReturn(string hexString, string needle, int expected)
        {
            // Act
            var actual = hardExercises.FirstIndex(hexString, needle);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(new string[] { "John Locke", "Thomas Aquinas", "David Hume", "Rene Descartes" }, "ASC", new string[] { "Thomas Aquinas", "Rene Descartes", "David Hume", "John Locke" })]
        [InlineData(new string[] { "Paul Erdos", "Leonhard Euler", "Carl Gauss" }, "DESC", new string[] { "Carl Gauss", "Leonhard Euler", "Paul Erdos" })]
        [InlineData(new string[] { "Michael Phelps", "Jesse Owens", "Michael Jordan", "Usain Bolt" }, "DESC", new string[] { "Michael Phelps", "Jesse Owens", "Michael Jordan", "Usain Bolt" })]
        [InlineData(new string[] { "Al Gore", "Barack Obama" }, "ASC", new string[] { "Al Gore", "Barack Obama" })]
        [InlineData(new string[] { "Albert Einstein" }, "ASC", new string[] { "Albert Einstein" })]
        [InlineData(new string[0], "DESC", new string[0])]
        [InlineData(null, "DESC", new string[0])]
        public void SortContacts_ShouldReturn(string[] names, string sort, string[] expected)
        {
            // Act
            var actual = hardExercises.SortContacts(names, sort);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 1, 1, true)]
        [InlineData(new int[] { 2, 2, 2, 2, 2, 2, 3, 4, 1, 5 }, 3, 2, false)]
        [InlineData(new int[] { 5, 5, 5, 5, 5 }, 5, 7, false)]
        [InlineData(new int[] { 1, 3, 5, 5, 3, 3, 1 }, 3, 2, true)]
        [InlineData(new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 0, 0 }, 5, 2, true)]
        [InlineData(new int[] { 0 }, 1, 1, false)]
        [InlineData(new int[] { 3 }, 1, 0, true)]
        [InlineData(new int[] { 2, 2, 3, 2, 2, 2, 2, 3, 4, 1, 5 }, 3, 2, false)]
        [InlineData(new int[] { 1 }, 1, 0, false)]
        public void IsThereConsecutive_ShouldReturn(int[] arr, int n, int times, bool expected)
        {
            // Act
            var actual = hardExercises.IsThereConsecutive(arr, n, times);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Computer Science", "e")]
        [InlineData("Edabit", "No Repetition")]
        [InlineData("system admin", "m, s")]
        [InlineData("the quick brown fox jumps over the lazy dog", " ")]
        [InlineData("Computer ScienceComputer ScienceComputer ScienceComputer ScienceComputer ScienceComputer ScienceComputer ScienceComputer ScienceComputer Science", "e")]
        [InlineData("edabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearch", "e")]
        [InlineData("thequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydog", "o")]
        [InlineData("thequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydogthequickbrownfoxjumpsoverthelazydog", "o")]
        [InlineData("edabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearchedabitisawesomequickcountingmergebubbleinsertionselctionshellsortingbinarylinearsearch", "e")]
        [InlineData("gedpeilckbponlhjfoakojkbkqgmlidojdfpiklcmceimijkcfgaagkedcqqlkbhligdgdkinmgoqbohlblkiboeafacphihmhgnpqpefgqoqqfgmnphoifbqkiqhobimjbidkgppghmgfhonidgjlpainhaefqlgljgqfehqdojeakfagqenjmnaanbeiipffbflqbhaqdoanicmccpbohfjifoajcbbjgklecjkffcnplfkplqaopaldjmjqpqjobldkclcfobqdflkfeacdmpoffhhecilgeqbbofffkkpidoachmnipmkdfmfkibhndpnidbpieneaapfjknnhmboonahlabhcblcbibeogepogkjonommonandpfqqfgkjacbmincqabeqlnjdaibgmihgdfahkmhncafpqjmabqpqaoeapalldfaddkjjmapmpqdfagbealmaeoooaeebkmldangbcqfnekbamqlmmbkfkgmijbfpddoobnhlacqmlkbhgjffhjdllgiecnggqlcqcpojncambneaalmddpjbjbhclnfplelcfmjqofgkqdgncbgdnckhcgidqfingkmcfnfaieonmkqjclbedqemolondqklmjmpjimqlkpgfhadhcmbbamplkbnblghijomepenimjipefaoadqgdfbdebgihofdkbealnkcjkqjpnjqjidqbllellnjqjglicgnkpemplfbcenmikalfalafmgbqifpcpgaiipaojboobidbkdfgqcglnjocgacdiligfgkdkjqfbhafchodmnefpflejaemkocphccldldnkhpahncqddqqakkemgqgqlopqiinqfmpneeophcpqginqnkjlngndongdkdqmdglkmbioicebkqfkncmkfakjmmilbbpclqnnkqcilfljjonpefmhenpiqidlcojnqbhcmijlpjeikejqnbqojoopdgfeihombjbnmibhhodmqcbfmneqkkkgnnqnpbgobaahlbkpnkieqpohngeqiimoqkebaiioaqdaqeemlaaobchnjoqojfgjacmkoneljncdifnmbmonolhbobbekmhkhqbbijjeimqninlpjnoicnhhnanpmqobkjbidokcpceealmqjceodfjepnfbfjpplmoofhofphlcjggnokgdbhhmhfbiiciqgqicoincnfbmkbpnqnlgdkknenpeejnnineeananofffmbmpqafdbddogblacchmmiellagacnicckocjmefihmhhahmkklapblcjqjjkjcnkqpiideblobeeopemljkiplkfelibjkilgfbjdaphlnlckcohjgcoaglfgcadoiipeqaeghceelbnjjqohqkcghmjqqfjjkmeqofdqjnjokkgcigpqkhbjeedipbbaekljhjakpgckepjlfeipagibhdknglnapkedkaljcgpeefmimeecfbgjpojepcpmnpcdnjgphmiogjapqhhgmfbecbmnffdoomdcoiamdejjiofqcqngbedohealndhejbkhpaeohkdjmnooefpeehgaddopkebliiqfmolmcepqhbkdjmihalmpeagfgemjklihlqloagpmponplidplgmabnebcpibjmjipjqcbppfaibmeldmfholijnpplialnkahmjblflfijkdbdiqnipfjfbhdgmlfpimpgallgkelhnkbepohdjamlklnkdnakghlenaaegojijlonnjlplkfmgifecigddqmimmjelnfjicjiqjcjfmajbmhgqjhnegnoiaebqkefjcobdjhlieipqbnmjkodmjqhpoljkmhbcenipnpjgdpjngjdaganqfqpbmfbcckneemfelhijihmdonioblediffncnfhkpqnckkkbhbqelfgdgpnaqlibklhgqqjiqjpiqhcikmjacilllhlbkkdqolefpceandqmdgkcdnjofjeghjanaqpmekdejjihlbojbgepddeljkpcekdnogcioniofqicdndbcijdmdmiddogcplejnbbjemcbfljfeqeqfmklbgppkkbmcjhnnokdckdqlbkfqjddbqphpblgoofhpbkpjohnlodkgopdlgfjmaddnfjlickjqdnboebhebmjahkijopakceoehkpoblhhndlbheifjdbaedaefbegaaiaqqhdjjkgkcnhmblnfmqdhopojqfpeoccpinapcnnnlqilkhdehcefhnlcagqdconnngfdkiggnninkcgqpdpimijkdhmpjmbagnbagplcanmdlglqmfglafnciekedlgghhnepbannkenmjkcddijgcfmhpjphlhgaiciinlhmdqqcfqeindgckcphllinandqbooeqqeeghnkijfjdbdilodjokjompakfmoqonhfedcoqmaqddfomnnhggibqgcjgoinjjnmhbflkepacibpidnkolphnqkboohkbmqcokmqqdjlkdpcnhgnaaafkledkbennaemqomnqakjkcqfbkkjfbcpnlcpgipbbdelnmaqqqmemfdlcjqcpkcomgjoimmfqoaeagieegnngbngpdldgbbdimjdibgagbajkbgaqfnkmkplidlfqlceccmcplenodbefqemoocomgfklhekqjlllcooejpijpmagalmefkpnpieahjjiqfkadjmiackjognnfafpdmgqedcnaapdnbkmqonnnbqdnbjpjjacnajfhigifnhopkahfojqkfeoiglkalipcndddeqlemqefdmchfkehnghmqlkkfanedebiqmhdknonaaaglfgqilncdpcodnqggdfibjqkacpoqcjiofflndqqigljqcmbjankjmpoqjjepehcflpogomfnpmqhqoodoohkbkepjdcnbmbacdqmqpcqqkiaejlkpfkjckkoboodgobddlcfjcjoekhbhpapjlkkojqdjqhqjipacpijjpfljhqmkfpeicgpbomndmfqnjaoalbjihgmimijolbleejkiolliimhacjdgpoidbbiihdhjjfhdpopjecgbpdagieephngeeadqgoijjmjphajilqfdlpqomngpeplffqapmmopifqhihgdpmqhobeibfmphamcmignhpapmdnkgapbhelgnkqfmqqgjacpbmkgofbfjohlmmelmnjpnglheaajhckfinbbhnggqpencidkoaepmglhdenhcmqbkfnndbgqmgfehnlqkifhpmpjfakgonfgjqnjifhmfdneacamknhpqcdjnfkiplhjqnkckqpkknjboaeqpdebhmfbkpcaamojehcqilpoeocajgoeqbgmkclmclpnqddmcqkppnqhglmcnlkfobmajgekhmbimnbcnlqohdceocfiblbfcajbqlpihmiabmednnegiccbggekeiolmedkfdadidadiaejpcmmedehhcdeecejknogdbbnqegphpgmjmqnjkkkccjaebhjalbhnqjdialioljmmkailfpidfncepbqihqnfimcebdlldjijqnolkhghlmpmdhglnckbnhgqmnjnakmlpmdnedebacloaabnnohaalnmcoppglqncaqcjjgcokjcpbbgonnihfdjepabaeniphhmpcljnaadbcnpdqbgnabangijkqqhokbpppihpaqcqlnbjjqlklpqlkpemnhafgdecgfodqhjmkgpjqbkkpifqfdfldbijanocjlnmagoqgehecamdjkfbcddhgcqcgqlenjghkbqlnieknfgidefkiilqfkhhcoofgngabdqonphigcomgbadiiplbdcbmmdgqaeqmknomdcmegbdkhlfocenjnngalccadoqfmmohldpdfhciljfjedenmimpegajhlqllhcfjkodonbhpaddbloilhojfchhjokjcjngclpgdkbmkjdmekmiieipadjecdkqgllofmnolgmkkqiblqfgkonaljpadgdddipijqdmkcoibfcmnojhjkemamhkohfimpnhhcoebckncpmnklcnkeabngoljegpplabjcpbpdolbjglhnjblifjockmqpdindipcqafqdelfpjbclkakcppcqodkmhlfafelfpjnfqlkhbecapbbmjmpahaeodceqaimmglnbqhlfbgoalnjhjmkbgfnqjmfogijldbiboccgpgedhhphbblqiloqjnamfenelehhfahqnkdfglfnheidqbjclgnaofgfbfeandnccobgacfqnihpqngmhaojkcdnkkebeqoigjoccadqpaejcqlkigklaohakgmanngfnmjnchbagldgemdolhmikinfmchddepkjjmgipandpoqlcnfjcclqhpajgphhgegdkgemognmhkimjbcngoqbklgfpojdpbneiimkldkmhbjfgdiijhalcbnoebnohkacpccgcekaicaagpeononnfchajenoniqpeipbfadjplehaccqboknjnjjfplbdaongocdlmopibefmcpcddcgfldknfpmhgghfkadlchekcfmckagdmgkhejqdkapaqlijljlflnllcaiegmnjmqhgdepdidhccmipcfidfeigndbkeonakgkoplcqnfbjcdgjqdkoialfiqpgcnhqgaghhpmfpqfmcjbkonedqfqpaflabalhmhfgfeckfpafnlbnkiqoecnkcbdmmciijqjdbbocljqgelgpamdqbnmhbggcfkomhfjanpabckdngiakkdldohmkaoblnppbcboplfhpiiipdfjmcmfgfgqbpomcpmcdohglqemgcncopgkpkncbmjkeebmegbafomnhjfgmkclelahigmljhifmhkgnedcbfnqdbplknkkmhfhboloaigjgcggnoqoopmlfndegoagqemhhqlnfaiepikcqabdnbojpiigiofpgdqlpkhcaglqdlfloiopkijqejkehehgpelkcepnddqaqimjneckbqpediofkbfhjhglqfibmkfncqncieoiabimnbqnbmaqiiepejmggbojinjghhfccpbqkkdljphoabafmohgqqipmhnmjnimkeflhjeankolbihdfbmqfjqqqjqjbjbnfpkijaclmdqngqbplkpkebqopqdmpmmehbcadlpidbpqhcnqlhmdcgeapbgfdndqdeoqccqifhaneegklhngenoehfblmqajcfgldhjekocccndclaccqbpbbfpdelodjmfgdpocdffgleqbjoknlfbnomalaphadbndkbpajdfcekggcqdoqgnlpqdjaeijeiffkeijhcgnnqcemjoonfllhpaipedkoeijkaiknohhkcmdhglfiqdqpannbepdmdlaamhglqcqqfoikboqllccfeohccfpndpkeieofpdgkiceamfqlfmjbjodiefeblbjaecdmpfkndmqpolkaaeiolfhbdpqmngdmomnkjbeokpebglllnoijlmlhmocahabncjaoljamnkhjkhkbecljdkbgdbdkdagbknonnpgdfgcceiqgejclcedkmjpjabfmibcifodhlpmgmlmbqlchbnqmlhnohljnphnilopimpnfifanlickchkecoenkmpoeahmgoiheoakodnqcpmfqqhhepijqqppplpmnjjkpokhnmkdhnjoiebjomniiakqldegqhidjajcnbeinlpmgkdlmohofngppekmklgejiggonqdolaapqmmpdpdccopofpjgjiahkfnqbfchahhmlqokaklqqpelkemljcenihkqddjmnpknogafcfebdkgcdajljnlfgpgmmldldbelajjknmpakpbcilnngpgfmmhjcojoadclqdojekcmaigkpfqjepneeillojajhjfhnokqbngmnaaelllgqnfeendeceekgbqqmlipgiimqimmgbnofonmmpddnnjiqigbbpnicnpkqhgpablfppfllpahoonejbebqbjeheheqoadaiclpqkkkncbofefaieebodcfkikefjjoahmdancidlnapohbjafdmmfagfljjaoqconmmakgccgeoedlkcbinjdmlejhpjflocekbhqdeaijjnpifkephgbmcbmkpejgjafbmiilbnpjdcjmqqhhckahakoggflioebhmdhcompelmjacddgqecpeejeoipigfjdmhgbqpekjefgmehaejfcpnihobjlnebpmpiccnnoejpolqgkahmlnjkfdnodpdhdnmkgeliaknlqlliodhgbllokdopoddbigmeedqhqedjgoblgapciokndleiljifecmofeocnnaplpgbggeohjdhlholhecqacimkmjglcmokfjcpkclkfdpeabafniqmkaenkdqkppjegckcemaohlgkicgpabmpacjlnamlgnfqkfnigfhipmobgqiiglceojadolamkieooochnpinbainjcgdqphfqkkchjpmplklekdgcfcnnepklbjbdjjamjdikalpadkjipdjjeqfkhkiaaefghkoeccnjnakjlfhlmjedojqmjppgaadijfihfhkchjqdqomfolcnklpmndbiphmnompjpnjgqlqedhjqlojpdkakgmogngndmpfmockbbjhbhpnppqqoeboofmhmpbbkqjffoeomlfpggdpngnmcqhggdakpgemhbqgeiigjogqgfipfponpiljofelmedmjjjhhghhaiiklkkhnqnmomnfknlbofjqddjhflkcbabckkooljeilmgfjlbbncdqiggfmhmegmjnmmaibkcqciijgadjbpgkcgeonmmkdbebkhqdfjknpndqqddiceqfmjcodjmeojdehejaklpmmhkkajeaplcfmbiggagcchbfaacegkkeopiqpgldklnbdjgiakqkidihnefffopdopqamcnfqicpmqibhoqgnmlfmlqqjifdckhpnbfjqbnhcflbiqkecnncifkefqhebeiechpgjcimlmgbimqdfincaglbqeheeaiqndfoppenfdelmqoiadhamaqampbmjqlmilqkcijoemphqjmagcqpmhfdgbhalagbqjedjfcaqoennpbgneocjcfliehhkqeambclfadgoiehhphekcdbnagmgflpebikhmcefpbmoahfkqkngeddnqkmekmgifdoeobdnpplqnncikfebdgibhdlpklpbqfgeidjkecgallllhlgbjhqkceifidamqfjenoeiemjdqbbpqpmqpqqbepmbblfjqghpbnhfofnplepobopbaqaqlbiqdopkaohfgqndmlefnkojllpknaibcfbjdhhjlmeipaoqgalbngqqqclqdhjadqmblflqdnhgqeechamjhabfihqqpjakfqkdebmmmhodfjhoijampqiilhaokajkgffkbnmpdqbjqkikkdeinegembpnjqmhqfmdbnemcnapgdhhmcfboidbleajmcpqgjfgkpmmqhkckefjajbnanlkqhlhbnckmbmflkhclhgmfcloojdjolmladbelidcofmeiflklfgbdiigfbfealhdhqbiphjniicqclimjqcdeogmhmlmambgphnpdkdciqpcnalngigdgaahqkqbdcajndaeaqjcanfoqdmbljminjafhkjhfdfncqhoidnpkiomqfidjmgmnoiccjkhlocdqbpqlmgcfgmajpdejbbaemiakhobjmeafnjleoocmipjfhqgqqgfkdaqifklnaaqikpcifnfepqeaqmhlfhglglglkqbdbadpkegqbkdnlmmbpbqnmjecnmbembiqjmhfbdakbmanmhhfijcehdckebnlhgpchapojjgcbmleqlcaiqhpijbfaiqhbmfhqfdemeamqihfojhcobqjgljbldldnbhagpqoeqdkclmcieghocpjoqlqagdajjqhndjgjfinfhcenqqaepogaliijcnmmoelkaihjdkbcipfikhcqjkbedifbjbggmjncnlcodbelekdceillhimjqlfmmlekcnpmgjjmmmcnaanmccfofdgpiincdgnbonghpnajlonkqghkenehfbmcklpgedogejkpjoafbmdkofgehhbpphkcghbheocopkgfchggfhcfdgjdkgekeapejddjoikgandljjnmqjihpfchalahlilmpbfbmopflgjfnmkaibellnlkeeplieeeioiqaibfpcihdjmifipajmdpjccgecjmaohenoobaacndmbjgdbhdqmbfbcmakfopmaqpjdcnbnlbfeaifkkqmkkohpdehjhgnlomqqkddpnclfihjjnnpjiepjinlgfibikdjcjnkchehlnmldkhkhglaickiiebkqbknecnblnbiciagdiqdidjfqaajnkcmcpkbdoikqflilkddqdbcdfollnhlodljbeiglgjnfinhiecloclcggjbghfmqgnmiqbeoqqfjldphndqkooeeajnknqakikekgklggaimniqgjcpohkmeepagepigmcpghgmhdggdbolnidebgajdibcalphcaiqacnkgalhlbojabbneggnagaepmicfflanaibdfppneklcllclmnllhdnmhjegjjnlqlihhcpjchlhmhgnbcdedjbdlmmfjnhkklihbdaehabpceliieekhhoghfjgdfcbiljcdhhijleeqkhggqaelcfapecagohppmiklldglopqadklhdoaidaqhjejjfqfkipbmfmcpajocdiqhkgdncgongqckngdjmglhelkikkfojemfkapkiqkljabnmihoaonpkqbilcmkafinhibkljljddakebbqcbkebkgdodojnmoaihqoinfipeppgglbloaaaeldfhngccjcldplbcjcbdiigkoqlhkeilemhbkodqjnimandahggjqhdblippdhkhaenikcnjbgigcokhepoefdjpnkbjppqnhflijpkpmnjhdigbcpqhmlqbdodbcipqhchqaqkdabckfqajjaoahabomlcmdbmbmbbfqgiqfmdqmecndjpciohdaenffijjqpfqbgiobapnaeomlcifghcilepqgaaqdhjfenegqlgohcppmhelplhlqdqaqpdbhpcccqkikcgmmddlipjnedljkpmpmnpjmnjnqjoegeldgocqagianebjmnqaliapadpbbjneeabjmqjqgoeihlnaqdmibgeeikegehogoqoebblbmmdagnfaghilhlkjbgjjdoqcdkgcljjhdndcbaibjfagmnhkmolanqahjckolnfjkemokmpeqbbgccbcjiqiemmcklobidimiphlqcknnbhlkebqcplnpqqicednfjpnjqphjlfoqkopqgnpfqgoimiagkbiqqcegflkicjcpoqkemllcfkdkljlinepompmegacfgqmbaigafjkljadhecddbnapbhpijlojipdahbfllfamlenhfdbhncdneenmgfagllgebleqfjqdkepogeoodcfnjbfhccpflbgpkiplghagqpemdniojdenjoqmhjopckhidiganiphngeefkihhgbmomedbpphmlhdndflojebiqmgfkibdhijhdgiibeffononbecipfoiidgjbociclkpgiekppfkgkaqpgggjdfpeqipqdjoaqphmhnqmpabpodmifiqnkoelmbhqmbhdcpjiijqjngppacgnopclbqmfcnmcqqpboghqplqhqchnfhggfghihefoaejbeonegojkkobbcnknpmehhbdmglflepfkfkgbmbbnnkcaopbqhnffqbliojgqbjhofijnoqjjpakjmchbmhqdbaloelhilnkcolqhmdppfkckjpjbmnolkbcqbqncpkjnfkbaemqqdhbqpoeqfnmcglpbnbkjbcncdplfhafqqaffenbhegkhamghqanemkjqambneihabpqgpphocoljdecllbkgqnpqajhnhoafmlnldkfhahedqpbebgbmeiidelmbcboobacgadjnbofqigbljfkhnhchhopkahgdhqbangjodlecplhcbollgdqqqeiajpgphemcnnahpdkgdilfogedkpjefkbocbmlbcfmofdfehhhebqmjccflmjgqmhakidohhaagknabkichkfgbqkjhpoilnieqkhkcfpegdliclccdholhfglqqiabfmmpfclgmqmdikeqedchgmgeiefpenkjjobhlndaionoepdnkbnnbfnolklbfbikdnobjkihjqdgejpigcoannaomdpgglofgpmfnigalcgkmjmogfgdimlbicmhkoiodklkbkekoiaapalojojagphfqhofinhhqdlpbocpfiamhnjdjhhdioqmbhbpmaehjeahkehqqkfpgbkmangbnemappngdggoapakfmolhefpcpooajholjhapaghlgqckinhdeogjiefdfddepifinlgnmboffijkhdhkhkjmhpcakopjacanonjbacannoihnpacgmohopfqkobfjcbgaqjneaomhidiplfbjkepcagokepdepemqfalhqabjkgkineelkifkblolpmjkfaickpjeainmgnnmkpoppfqaobcnknknknaqdkahiqalbbdihjqjhoahlphgqcabgkfoammblnlkipbamoapeldjdnpjheqfgjgdjfncdfgdemfeqdfbikmighchomqlkjoccfpmmepaaondjoqcpdcohlqqjgldddolpaojaodhjiiabqadkpmnfeqmaihhkailkljkhqomejdbnqpehjnibpdbllqplpfikmoggpkdoligeqapegmcqliecldnkdhaoecpkmojbolqolclbqnnnhpknqpbplmggpelmpchanqgadbimmehkiicocobahchhfeddlkdqcpcgdjinllnaoecplhlkijkjihbqonefdlnekgcqeiqgnakgqkoilkopibqhdeckndhkipqkfpedccphdfbikjialhiokiolbdimhonkggojogikcifdnjlpbephonpcamfcbfogoeffpojkjaamqpcqphkpjphilchbpjfkaooeqgobcqcqmihbifooqjifmpiekhcojdafcfnpdpaifkcgqbbomjocpkcgqjkeibiioodebnqeffkdqnelpmkmbimiohfgbohpenopjbbbjchjjqekffmpceepapgffqoiknjqaejaimohaahpghpmecholaqakiijkkkcopiopgimqqjgnqeqoolbhbgndonqobjodekbmggeochkfkqmnchamhbognlnfbgehchgbpbkhlcafdqgibblqnmkqqhoqhbghejndneicebgcqpbpjajboacmbqlmnpgjnhheaogldfcckmlafkmacagmlnhockqnihplqddoofiqiomdopiiqikmmmeiieefofegmnmildmniikhqkcgenldadnnefhlkcenghhdahqldbfpbogdojemlkadqqnqjlbiqgldlembdpagiqbabhqqkhfbcacknqndacobjnlcflnaimogqgphmmplfqhqopjnknqgeqiafjhdamniaqpkikqkpfonqmglfahbocjikacnclgflcnehfgijpoiigealeqkkejfgbhoahjqachfglblbndlcefjqkqpnhpmjjlkmpddfaedjbkaoiofofgblhhahdehincfgkaaqlbeibaaqhablbnqpdpipfqcpdokoamcocpnffbqplqnfljqbggbqqfbhphcdephqqibjqmdimeqajgikmafkfblfkdcpgfjkkdqgfejklgfqeeifgaldjhppmjqahmodpakibpcgjkohnfelfdlmgccdlafapgagalekenpapmfegngehlpomqknjjebemflfbmngjilejbqhoghndejhcodpdaelhapkkcnakblabcmoejmaqbomadppfedaqfljefiikfhecqpjhcgjljcbphiefjkoneoaeqfknkjenhkaimbeakcklddocbmhbkemjjkoqicleeckeodjfooiajinqbfplicmdbenjedneeqnmlqjqgoegmidoqefjmhacijcjahqkqinjdnolfiadkgjaqneqgbpkccpkoqackplkfomopidhffjffmfjplkaedkllmlcponmdihnalppbiqpgjohjifkbilemmidelfgmdjedapjmgibqjdfdhnaqiajjacdlnpgeagedeffndocacbbqlhoinjdicolpiaikjokldmpkofkigknppofnkkepopncnfaabcleicoccefamniognmajimbqnqmnmpipepncmokndnpmccjbqglpqnjfpjlgfjokomdqkcfqcmjkehqccqibfcbhehebkhkmmcokkghpkndjkbhljeemhngjaojmpnefplhlniklckablgqjaognaqhcdfcdlggpfhqnhlfdagaljeapgafonhmhfbmfenlpnigmloldfpkgleoajhbijaopaeaqpejdfajfoppeeekkpacmoakphmpaaoknbhdlgaghnjohlihciqfcoqdebhiaghepjffpjmbdmdlokeadnojhmmpgqpdloiapgnkikfqokdjnlpbflfmiojnkqdjmnekdccffffombnikaafiollobggjefoobmnimmbdojkajnpiodhbagjqgifcbkajgmgkcceefbojolibodecehclkekmoqqjpnmngpicdjgeqmbgmjaqkhliibqlkihbkimhfjeebpndlfqfkijimqndbcnocjqbknfanjbmnccbllpmhhnqfaopaacfjmagpeheodqjidakpbijngkjjqcnbmkgnpgiamgkmhiomelafqbmhldqgicendddonqqfelnpqfedghbbkjmnilnjmpjifbekbqbigbqimgcidbokbhncogqiahngpjbhbcdfhkqdbopaanqnbbfalncgmheqbidojloifpmkkechdaikmniccpfenjleagnjnaiahjgckhdijhpnmhqeagfcapgpcdlgiglfaegacefbmningchoefapembjnjhanobbhiachbblocnlmcaebajapiniidhhemjdnimplcplefgpnhegofnfkbooecjgfmqgknmklfddhpjnagobeqolbkfnagiqgemamnjoqjpkkhngdmjckqkenlqnalpjoombgfkkhlqfpplqhnnbaifeinkfaokgkjojemekgnhcffnlmckkeffldqagfkbfdfqlikmfknlpfnlpngjjkjmkkgjpqamjbfkglkqclfgnggopkjnbkbfpqqlckeigamqlqociiqbocfbjkgkabbcnfqlbgimjoecidpobomhaagioqbgnalmpepmdkpqhgihdalbbebbjbbgepjomlbqnnqejdaeedcchlgfcleclgffegiifhbcecamlolgqfilqedmghdkiejahdaomqkncijhkjlndlmfadannmefebqhmdjbjfqfphfhlbaacciollifjbigedkbfacbmiqogboqapimcqamaiofgfokhbnjgbobfghlfbjmkcmpphbpfagdqkbhefalqdpcmcmqkogloggpcocmpjfajqjkaodojiplikkpkdfbkghagpknbafjojgnegqcpjjenkiffmbpcdqddchoiilfapghfnpelebaidbjhqaaqbgbmfgpqeqdmjmnjjfifdfgkoklbeacbfidhqhqldlqkqmnkaggbldbdpeihqdmajoqeqgjeojbhmomhpqomkpoiogqklidkflgfpjbpbdnfjpnaeknqkiqqiflbfqgfhljpefqgclnccgjdiidkmocbkoimikahanoqeadgpgooqikqabdefkmqlfibbadkcjbjlomaoieiqcbbcjhffdijnphenglojamadmccjcfaehhddqmqamlacjgkblmojbmfbaffddcloohegkciqiqjamjaedldifoeehkmclklcihgfkcjenbilfjqmecldiafdqaciihhqldhdolkdlnkciihgdbapdppffhjokbmphjldidkehahkfpiihllpdcaobgppqajjkiddpkniddnmqgbaffpkhqqakeoqcemaaidgdkjcggikqqlgccnhehjmonaqihebdkjbapqhibqkcdipgpcbiqekopdndbqoeglmpoinpnogkhbejgfdhedfhckbkahdnqppoegoaaqjjknggkodpagojepkmdioofqapdkldpakbjifhffnfckebbehekhefiephdoifmkagqeiggnndioiogkmoaqppojkiqhfhfqifjgmkgcgfeeoaacjhiebdlkjgfbbjkdajallgdejpnigjojfaddelnmelbpimoabmqkfejjfpilgpmdjdiifhihgecjqipcmmpoqadjdaencmgmhmfjlgefbgbckhdjphggdopdhqbqqpiqpjjjqanhhaclcbjdiggfgpppmjgahifchkjkneqfhldpmacookceongbolpknlocadidkipodqkoegdkhdjpqmnojlecohblchdebnlfkgcpmjhliekgdcdeqkidoiqcdaqoimdqephlionoackjlaoaniqkpfjeolkdccbjadldfbhgiofqjongojbjekbebgmddeapabmjdfpqemlmidbqapmligijplmkmqnijaimiceakppkjfikakhkebhfnllefaqjmjfngjnogghcnkhkaagqjmbihkbndckalaoqehldiokiqkeijiojfbeflghnodpdlidjjgqjplhcjffambgejmaqmabbdhpkdflkmlkilfjioipbemflqpojqfbopmapeomhjakipgainlqfjhmbmkiicqokhlfpklahndaaagaghfgabjknheedklbqgdklfkahjdkqnlappjnknkcpklnfbqkijqblnkobpgjanphlhjcqmndagjhobnmjhaminngccieghhpbcpcgnnpphllfhiiglefkacpnmloqklhfhhhjqmefjloidncdmfiqkpjcdlbqmojlnblklohembfdekghfddgecbqlnhqciiefgonkbcqjmapbnagnkcmgacocpghlnplbpaclepicingcmepdjoqgjqhimkpjqlqdiaokjkhqgndbqcaqdhhlqgnhghgqffekldhiaafajcanknejbldpnmifdfmkhoqokcihlifqkohjedlgeolcmlqfnkbieomnbqcbgcchfqhglblqcepkcmbcmcggqhjcemdlnbqllebglhfcfhcaqacqfelmngffqlcghaheiimdampdqngcnnjlnhemcoahogbocdgkcbghmjqjgmpfnbephmadkjiclcaihplolofdkkoknkjildnfglfobccpmkpnpkkicdabppninckchmapehlmjniblnjeilmkaceehenllmomjnejeakckjmndamlhfhkbilefplahampnakfmcagnfkaafbhiciadfjlmqqpdfbibmkcchaplfjnqpffcmficjgadkgnbbpanllcoibngijeaoaclldfphlkmjanifojjamidkdgjialfpljbdahoqqaaollmdgpaoggcaemimhelhpdjnniepmedlbefobcoebhjngehqgnecapojkomamqmadnhlgdfinndpqapindkabalamjaambpaofnhiebncamncemhmcodabblfkjgqmhpnebbfgdidmmbciggjoajkncnmnedfeghmhdbclepmpdgkflgiajlahofpmbohhkfqmlhfaifqhqkikqlnghdblgqahgcbqqcqoamqjambdbpbcniqmepgmcnollnlminkmfncjpahkjgbnlmbenahjlmlhdcnkgdpbfgjcmpcpbkpkpfldmoqmfkqlcfkndnhioqlgkanengjdcjhahcpepfbbpeaiangfncnbiiqipjboampejgapjpjbqfgjiaagjfpljmomqclejjmoiiafdomgdffeeacbehhncdidmqjndaflebmdnfpeaooonncebccleedmockfelgl", "n")]
        public void MaxOccur_ShouldReturn(string text, string expected)
        {
            // Act
            var actual = hardExercises.MaxOccur(text);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("ace spades hearts clubs", "ace")]
        [InlineData("forty choppy ghost", "choppy")]
        [InlineData("one two three", "")]
        [InlineData("almost accept access", "almost")]
        [InlineData("aa bbb cccc", "cccc")]
        public void LongestAbecedarian_ShouldReturn(string arr, string expected)
        {
            // Act
            var actual = hardExercises.LongestAbecedarian(arr.Split(' ').ToArray());

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(399, 6)]
        [InlineData(1234, 4)]
        [InlineData(153, 4)]
        [InlineData(33338, 5)]
        [InlineData(7777, 0)]
        [InlineData(977, 2)]
        [InlineData(589, 4)]
        public void SmallestTransform_ShouldReturn(int num, int expected)
        {
            // Act
            var actual = hardExercises.SmallestTransform(num);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("butl", "beautiful", true)]
        [InlineData("butlz", "beautiful", false)]
        [InlineData("tulb", "beautiful", false)]
        [InlineData("bbutl", "beautiful", false)]
        [InlineData("sg", "something", true)]
        [InlineData("sgi", "something", false)]
        [InlineData("sing", "something", true)]
        [InlineData("siing", "something", false)]
        public void CanComplete_ShouldReturn(string initial, string word, bool expected)
        {
            // Act
            var actual = hardExercises.CanComplete(initial, word);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("12.255.56.1", true)]
        [InlineData("1.2.3.4", true)]
        [InlineData("1.2.3", false)]
        [InlineData("1.2.3.4.5", false)]
        [InlineData("123.45.67.89", true)]
        [InlineData("123.456.78.90", false)]
        [InlineData("123.045.067.089", false)]
        [InlineData("", false)]
        [InlineData("abc.def.ghi.jkl", false)]
        [InlineData("123.456.789.0", false)]
        [InlineData("12.34.56", false)]
        [InlineData("12.34.56 .1", false)]
        [InlineData("12.34.56.-1", false)]
        [InlineData("192.168.1.1", true)]
        [InlineData("192.168.1.1  ", false)]
        [InlineData("  192.168.1.1", false)]
        [InlineData("0.232.47.227", true)]
        [InlineData("1e0.1e0.1e0.1e0", false)]
        public void IsValidIP_ShouldReturn(string IP, bool expected)
        {
            // Act
            var actual = hardExercises.IsValidIP(IP);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, new long[] { 1, 1 })]
        [InlineData(9, new long[] { 2, 1 })]
        [InlineData(1000, new long[] { 1, 1000 })]
        [InlineData(999, new long[] { 3, 370 })]
        [InlineData(38, new long[] { 12, 174813842944 })]
        [InlineData(93, new long[] { 9, 217 })]
        [InlineData(100000001, new long[] { 15, 220258825732 })]
        public void DeadEnd_ShouldReturn(long n, long[] expected)
        {
            // Act
            var actual = hardExercises.DeadEnd(n);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Liverpool came 1st with 99 points and a goal difference of 52!", "Liverpool")]
        [InlineData("Manchester Utd came 3rd with 66 points and a goal difference of 30!", "Manchester Utd")]
        [InlineData("Norwich came 20th with 21 points and a goal difference of -49!", "Norwich")]
        [InlineData("Tottenham came 6th with 59 points and a goal difference of 14!", "Tottenham")]
        [InlineData("Aston Villa came 17th with 35 points and a goal difference of -26!", "Aston Villa")]
        [InlineData("Southampton came 11th with 52 points and a goal difference of -9!", "Southampton")]
        [InlineData("Manchester City came 2nd with 81 points and a goal difference of 67!", "Manchester City")]
        public void EPLResult_ShouldReturn(string expected, string team)
        {

            //arrange
            var _table = new string[] {
            "Arsenal, 38, 14, 14, 10, 8",
            "Aston Villa, 38, 9, 8, 21, -26",
            "Bournemouth, 38, 9, 7, 22, -26",
            "Brighton, 38, 9, 14, 15, -15",
            "Burnley, 38, 15, 9, 14, -7",
            "Chelsea, 38, 20, 6, 12, 15",
            "Crystal Palace, 38, 11, 10, 17, -19",
            "Everton, 38, 13, 10, 15, -12",
            "Leicester City, 38, 18, 8, 12, 26",
            "Liverpool, 38, 32, 3, 3, 52",
            "Manchester City, 38, 26, 3, 9, 67",
            "Manchester Utd, 38, 18, 12, 8, 30",
            "Newcastle, 38, 11, 11, 16, -20",
            "Norwich, 38, 5, 6, 27, -49",
            "Sheffield Utd, 38, 14, 12, 12, 0",
            "Southampton, 38, 15, 7, 16, -9",
            "Tottenham, 38, 16, 11, 11, 14",
            "Watford, 38, 8, 10, 20, -28",
            "West Ham, 38, 10, 9, 19, -13",
            "Wolves, 38, 15, 14, 9, 1"
        };
            // Act
            var actual = hardExercises.EPLResult(_table, team);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void CannotCapture_ShouldReturn()
        {
            // Arrange
            var inputs = new Dictionary<int[,], bool>()
            {
                [new int[,] {
                    { 0, 0, 0, 1, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, 0, 0, 1, 0, 0 },
                    { 0, 0, 0, 0, 1, 0, 1, 0 },
                    { 0, 1, 0, 0, 0, 1, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, 0, 0, 0, 0, 1 },
                    { 0, 0, 0, 0, 1, 0, 0, 0 }
            }] = true,
                [new int[,] {
                { 1, 0, 1, 0, 1, 0, 1, 0 },
                {0, 1, 0, 1, 0, 1, 0, 1},
                { 0, 0, 1, 0, 1, 0, 1, 0 },
                { 0, 0, 0, 1, 0, 1, 0, 1 },
                { 0, 0, 0, 0, 1, 0, 1, 0 },
                { 0, 0, 0, 0, 0, 1, 0, 1 },
                { 0, 0, 0, 0, 0, 0, 1, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 1 }
            }] = true,
                [new int[,] {
                    {1, 0, 1, 0, 1, 0, 1, 0},
                    {0, 1, 0, 1, 0, 1, 0, 1},
                    {1, 0, 1, 0, 1, 0, 1, 0},
                    {0, 0, 0, 1, 0, 1, 0, 1},
                    {1, 0, 0, 0, 1, 0, 1, 0},
                    {1, 0, 0, 0, 0, 1, 0, 1},
                    {1, 0, 0, 0, 0, 0, 1, 0},
                    {1, 0, 0, 0, 0, 0, 0, 1}
            }] = true,
                [new int[,] {
                    {1, 0, 1, 0, 1, 0, 1, 0},
                    {0, 1, 0, 1, 0, 1, 0, 1},
                    {1, 0, 1, 0, 1, 0, 1, 0},
                    {0, 0, 0, 1, 0, 1, 0, 1},
                    {1, 0, 0, 0, 1, 0, 1, 0},
                    {0, 0, 0, 0, 0, 1, 0, 1},
                    {1, 0, 0, 0, 1, 0, 1, 0},
                    {0, 0, 0, 1, 0, 1, 0, 1}
            }] = true,
                [new int[,] {
                    {1, 0, 1, 0, 1, 0, 1, 0},
                    {0, 1, 0, 1, 0, 1, 0, 1},
                    {1, 0, 1, 0, 1, 0, 1, 0},
                    {0, 0, 0, 1, 0, 1, 0, 1},
                    {1, 0, 0, 0, 1, 0, 1, 0},
                    {0, 0, 0, 0, 0, 1, 0, 1},
                    {1, 0, 1, 0, 1, 0, 1, 0},
                    {0, 0, 0, 1, 0, 0, 0, 1}
            }] = true,
                [new int[,] {
                    {1, 0, 1, 0, 1, 0, 1, 0},
                    {0, 1, 0, 1, 0, 1, 0, 1},
                    {1, 0, 1, 0, 1, 0, 1, 0},
                    {0, 0, 0, 1, 0, 1, 0, 1},
                    {1, 0, 0, 0, 1, 0, 1, 0},
                    {0, 0, 0, 0, 0, 1, 0, 1},
                    {1, 0, 1, 0, 1, 0, 1, 0},
                    {1, 0, 0, 1, 0, 0, 0, 1}
            }] = false,
                [new int[,] {
                    {1, 0, 1, 0, 1, 0, 1, 0},
                    {0, 1, 0, 1, 0, 1, 0, 1},
                    {1, 0, 1, 0, 1, 1, 1, 0},
                    {0, 0, 0, 1, 0, 1, 0, 1},
                    {1, 0, 0, 0, 1, 0, 1, 0},
                    {0, 0, 0, 0, 0, 1, 0, 1},
                    {1, 0, 1, 0, 1, 0, 1, 0},
                    {0, 0, 0, 1, 0, 0, 0, 1}
            }] = false,
                [new int[,] {
                       {1, 0, 1, 0, 1, 0, 1, 0},
                    {0, 1, 0, 1, 0, 1, 0, 1},
                    {0, 0, 0, 0, 1, 0, 1, 0},
                    {0, 0, 1, 0, 0, 1, 0, 1},
                    {1, 0, 0, 0, 1, 0, 1, 0},
                    {0, 0, 0, 0, 0, 1, 0, 1},
                    {1, 0, 0, 0, 1, 0, 1, 0},
                    {0, 0, 0, 1, 0, 1, 0, 1}
            }] = false,
                [new int[,] {
                    {1, 0, 1, 0, 1, 0, 1, 0},
                    {0, 1, 0, 1, 0, 1, 0, 1},
                    {0, 0, 0, 0, 1, 1, 1, 0},
                    {0, 0, 0, 0, 0, 0, 0, 1},
                    {1, 0, 0, 0, 1, 0, 1, 0},
                    {0, 0, 0, 0, 0, 1, 0, 1},
                    {1, 0, 0, 0, 1, 0, 1, 0},
                    {0, 0, 0, 1, 0, 1, 0, 1}
            }] = false,
                [new int[,] {
                   {1, 0, 1, 0, 1, 0, 1, 0},
                    {0, 1, 0, 1, 0, 1, 0, 1},
                    {0, 0, 0, 0, 1, 0, 1, 0},
                    {0, 0, 0, 0, 0, 0, 0, 1},
                    {1, 0, 0, 0, 1, 0, 1, 0},
                    {0, 0, 0, 0, 0, 1, 0, 1},
                    {1, 0, 0, 0, 1, 0, 1, 0},
                    {0, 0, 1, 1, 0, 1, 0, 1}
            }] = false,
                [new int[,] {
                    {0, 0, 0, 1, 0, 0, 0, 0},
                    {0, 0, 0, 0, 0, 0, 0, 0},
                    {0, 1, 0, 0, 0, 1, 1, 0},
                    {0, 0, 0, 0, 1, 0, 1, 0},
                    {0, 1, 0, 0, 0, 1, 0, 0},
                    {0, 0, 0, 0, 0, 0, 0, 0},
                    {0, 1, 0, 0, 0, 0, 0, 1},
                    {0, 0, 0, 0, 1, 0, 0, 0}
            }] = false,
            };

            // Act
            foreach (var input in inputs)
            {
                var actual = hardExercises.CannotCapture(input.Key);

                // Assert
                Assert.Equal(input.Value, actual);
            }
        }



        [Theory]
        [InlineData(3, new string[] { ">", ">>", ">>>", ">>", ">" })]
        [InlineData(4, new string[] { ">", ">>", ">>>", ">>>>", ">>>>", ">>>", ">>", ">" })]
        [InlineData(7, new string[] { ">", ">>", ">>>", ">>>>", ">>>>>", ">>>>>>", ">>>>>>>", ">>>>>>", ">>>>>", ">>>>", ">>>", ">>", ">" })]
        [InlineData(8, new string[] { ">", ">>", ">>>", ">>>>", ">>>>>", ">>>>>>", ">>>>>>>", ">>>>>>>>", ">>>>>>>>", ">>>>>>>", ">>>>>>", ">>>>>", ">>>>", ">>>", ">>", ">" })]
        [InlineData(9, new string[] { ">", ">>", ">>>", ">>>>", ">>>>>", ">>>>>>", ">>>>>>>", ">>>>>>>>", ">>>>>>>>>", ">>>>>>>>", ">>>>>>>", ">>>>>>", ">>>>>", ">>>>", ">>>", ">>", ">" })]
        [InlineData(10, new string[] { ">", ">>", ">>>", ">>>>", ">>>>>", ">>>>>>", ">>>>>>>", ">>>>>>>>", ">>>>>>>>>", ">>>>>>>>>>", ">>>>>>>>>>", ">>>>>>>>>", ">>>>>>>>", ">>>>>>>", ">>>>>>", ">>>>>", ">>>>", ">>>", ">>", ">" })]
        public void Arrow_ShouldReturn(int num, string[] expected)
        {
            // Act
            var actual = hardExercises.Arrow(num);

            // Assert
            Assert.Equal(expected, actual);
        }

    }
}
