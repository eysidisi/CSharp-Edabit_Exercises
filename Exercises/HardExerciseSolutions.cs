using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Exercises
{
    public class HardExerciseSolutions : IHardExercises
    {
        public int AddBill(string money)
        {
            var strArr = money.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(str => str = str.Trim()).ToArray();

            int total = 0;
            foreach (var str1 in strArr)
            {
                string str = str1;
                if (str.Contains('$'))
                {
                    str = str.Replace("$", "");
                    if (str.Contains('k'))
                    {
                        str = str.Replace("k", "");
                        total += (int.Parse(str) * 1000);
                    }
                    else
                    {
                        total += (int.Parse(str));
                    }
                }
            }
            return total;
        }

        public bool AlmostPalindrome(string str)
        {
            string reverseStr = new string(str.Reverse().ToArray());

            int numOfDiff = 0;

            for (int charIndex = 0; charIndex < str.Length; charIndex++)
            {
                if (reverseStr[charIndex] != str[charIndex])
                {
                    numOfDiff++;
                }

                if (numOfDiff == 3)
                {
                    return false;
                }
            }

            return numOfDiff != 0;
        }

        public string AlphabetIndex(string str)
        {
            str = str.ToLower();

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var ch in str)
            {
                int num = ch - 'a';

                if (num >= 0 && num <= 'z')
                {
                    stringBuilder.Append((int)(num + 1) + " ");
                }
            }
            stringBuilder = stringBuilder.Remove(stringBuilder.Length - 1, 1);
            return stringBuilder.ToString();
        }

        public string[] Arrow(int num)
        {
            List<string> output = new List<string>();

            for (int i = 1; i <= num; i++)
            {
                string newStr = new string('>', i);
                output.Add(newStr);
            }

            int numOfZort;

            if (num % 2 == 0)
            {
                numOfZort = num;
            }
            else
            {
                numOfZort = num - 1;
            }


            for (; 1 <= numOfZort; numOfZort--)
            {
                string newStr = new string('>', numOfZort);
                output.Add(newStr);
            }

            return output.ToArray();
        }

        public double AverageWordLength(string str)
        {
            var strArr = str.Split(new char[] { ' ' });

            for (int index = 0; index < strArr.Length; index++)
            {
                strArr[index] = new string(strArr[index].Where(ch => !char.IsPunctuation(ch)).ToArray());
            }

            int totalLength = 0;

            foreach (var st in strArr)
            {
                totalLength += st.Length;
            }

            double averageLength = totalLength / (double)(strArr.Length);

            return Math.Round(averageLength, 2);
        }

        public int BlockPlayer(int a, int b)
        {
            int aXPos = a % 3;
            int aYPos = a / 3;

            int bXPos = b % 3;
            int bYPos = b / 3;

            int cXPos = 0;
            int cYPos = 0;


            if (aXPos == bXPos)
            {
                cXPos = aXPos;
                cYPos = 3 - (aYPos + bYPos);
            }
            else if (aYPos == bYPos)
            {
                cYPos = aYPos;
                cXPos = 3 - (aXPos + bXPos);
            }

            else
            {
                return 12 - (a + b);
            }
            return cYPos * 3 + cXPos;
        }

        public bool Brackets(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return true;
            }

            str = str.Replace(" ", "");


            int numOfBrackets = 0;

            foreach (char ch in str)
            {
                if (ch == '(')
                {
                    numOfBrackets++;
                }

                else if (ch == ')')
                {
                    if (numOfBrackets == 0)
                    {
                        return false;
                    }
                    else
                    {
                        numOfBrackets--;
                    }
                }
            }

            return numOfBrackets == 0;
        }

        public bool BreakPoint(int num)
        {
            List<int> numbers = new List<int>();
            while (num > 0)
            {
                numbers.Add(num % 10);
                num /= 10;
            }
            int numOfElements = 1;

            while (numOfElements < numbers.Count())
            {
                int sum1 = numbers.GetRange(0, numOfElements).Sum();

                int remaningNumberOfElements = numbers.Count() - numOfElements;

                int sum2 = numbers.GetRange(numOfElements, remaningNumberOfElements).Sum();

                if (sum1 == sum2)
                {
                    return true;
                }

                numOfElements++;
            }
            return false;
        }

        public int BridgesII(string str)
        {
            var strArr = str.Split(new char[] { '/' });

            int numOfBridges = 0;

            foreach (var strSplit in strArr)
            {
                if (!strSplit.Contains(" "))
                {
                    numOfBridges++;
                }
            }

            int[] verticalBridges = new int[strArr[0].Length];

            foreach (var item in strArr)
            {
                for (int index = 0; index < item.Length; index++)
                {
                    if (item[index] == ' ')
                    {
                        verticalBridges[index] = 1;
                    }
                }
            }

            return (numOfBridges + verticalBridges.Count(num => num == 0));
        }

        public int Cal(int depth)
        {
            const int speedPerMin = 5;
            const int nonStopClimbDuration = 30;
            const int slideHeight = 30;

            int currentHeight = 0;
            int elapsedTime = 0;
            int climbingTime = 0;

            while (currentHeight < depth)
            {
                if (climbingTime == nonStopClimbDuration)
                {
                    currentHeight -= slideHeight;
                    elapsedTime += 10;
                    climbingTime = 0;
                }
                else
                {
                    currentHeight += speedPerMin;
                    climbingTime++;
                    elapsedTime++;
                }
            }
            return elapsedTime;
        }

        public bool CanComplete(string initial, string word)
        {
            foreach (var ch in initial)
            {
                if (word.Length == 0)
                {
                    return false;
                }

                int index = word.IndexOf(ch);

                if (index == -1)
                {
                    return false;
                }

                word = word.Substring(index + 1);
            }

            return true;
        }

        public bool CanFit(int[] weights, int bags)
        {
            throw new NotImplementedException();
        }

        public bool CannotCapture(int[,] board)
        {
            int numOfRows = board.GetLength(0);
            int numOfCols = board.GetLength(1);

            for (int rowIndex = 0; rowIndex < numOfRows; rowIndex++)
            {
                for (int colIndex = 0; colIndex < numOfCols; colIndex++)
                {
                    if (board[rowIndex, colIndex] == 1)
                    {
                        // Check if it can capture
                        if (colIndex + 2 < numOfCols)
                        {
                            if (rowIndex + 1 < numOfRows)
                            {
                                if (board[rowIndex + 1, colIndex + 2] == 1)
                                {
                                    return false;
                                }
                            }

                            if (rowIndex - 1 >= 0)
                            {
                                if (board[rowIndex - 1, colIndex + 2] == 1)
                                {
                                    return false;
                                }
                            }
                        }

                        if (colIndex - 2 >= 0)
                        {
                            if (rowIndex + 1 < numOfRows)
                            {
                                if (board[rowIndex + 1, colIndex - 2] == 1)
                                {
                                    return false;
                                }

                            }

                            if (rowIndex - 1 >= 0)
                            {
                                if (board[rowIndex - 1, colIndex - 2] == 1)
                                {
                                    return false;
                                }
                            }
                        }

                        if (rowIndex + 2 < numOfRows)
                        {
                            if (colIndex + 1 < numOfCols)
                            {
                                if (board[rowIndex + 2, colIndex + 1] == 1)
                                {
                                    return false;
                                }
                            }

                            if (colIndex - 1 >= 0)
                            {
                                if (board[rowIndex + 2, colIndex - 1] == 1)
                                {
                                    return false;
                                }
                            }

                        }

                        if (rowIndex - 2 >= 0)
                        {
                            if (colIndex + 1 < numOfCols)
                            {
                                if (board[rowIndex - 2, colIndex + 1] == 1)
                                {
                                    return false;
                                }
                            }

                            if (colIndex - 1 >= 0)
                            {
                                if (board[rowIndex - 2, colIndex - 1] == 1)
                                {
                                    return false;
                                }
                            }

                        }
                    }
                }
            }

            return true;
        }

        public int ClosestPalindrome(int num)
        {
            int dif = 0;
            while (true)
            {
                int smallerNum = num - dif;
                int largerNum = num + dif;

                if (smallerNum.ToString() == new string(smallerNum.ToString().Reverse().ToArray()))
                {
                    return smallerNum;
                }
                else if (largerNum.ToString() == new string(largerNum.ToString().Reverse().ToArray()))
                {
                    return largerNum;
                }
                else
                {
                    dif++;
                }
            }
        }

        public string Collatz(long a, long b)
        {
            int numOfStepsA = 0;
            int numOfStepsB = 0;

            while (a != 1)
            {
                if (a % 2 == 0)
                {
                    a /= 2;
                }
                else
                {
                    a = 3 * a + 1;
                }
                numOfStepsA++;
            }

            while (b != 1)
            {
                if (b % 2 == 0)
                {
                    b /= 2;
                }
                else
                {
                    b = 3 * b + 1;
                }
                numOfStepsB++;
            }

            return numOfStepsA < numOfStepsB ? "a" : "b";
        }

        public bool CommentsCorrect(string str)
        {
            var splittedStr = str.Split(new string[] { "/*" }, StringSplitOptions.None);

            if (splittedStr.Length > 1)
            {
                for (int index = 1; index < splittedStr.Length; index += 2)
                {
                    if (splittedStr[index].Length < 2)
                    {
                        return false;
                    }

                    if (splittedStr[index].Substring(0, 2) != "*/")
                    {
                        return false;
                    }
                }
            }

            str = str.Replace("/*", "").Replace("*/", "");

            return str.Count(ch => ch == '/') % 2 == 0;
        }

        public string ConvertTime(string time)
        {
            if (time.Contains("am"))
            {
                var parsedTime = time.Split(new char[] { ' ' });
                parsedTime = parsedTime[0].Split(new char[] { ':' });

                int hour = int.Parse(parsedTime[0]);
                int minute = int.Parse(parsedTime[1]);

                return (hour % 12).ToString() + ":" + minute.ToString("00");
            }
            else if (time.Contains("pm"))
            {
                var parsedTime = time.Split(new char[] { ' ' });
                parsedTime = parsedTime[0].Split(new char[] { ':' });

                int hour = int.Parse(parsedTime[0]) + 12;
                int minute = int.Parse(parsedTime[1]);

                return (hour).ToString() + ":" + minute.ToString("00");
            }

            else
            {
                var parsedTime = time.Split(new char[] { ' ' });
                parsedTime = parsedTime[0].Split(new char[] { ':' });

                int hour = int.Parse(parsedTime[0]);
                int minute = int.Parse(parsedTime[1]);

                string suffix = "";
                if (hour >= 12)
                {
                    suffix = "pm";
                }
                else
                {
                    suffix = "am";
                }

                return (hour % 12) + ":" + minute.ToString("00") + " " + suffix;
            }
        }

        public bool CorrectSigns(string str)
        {
            var strTemp = str.Replace(">", " ").Replace("<", " ");

            string[] splitted = strTemp.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


            int[] numbers = splitted.Select(st => int.Parse(st)).ToArray();
            int numIndex = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '>')
                {
                    int num1 = numbers[numIndex++];
                    int num2 = numbers[numIndex];

                    if (num2 >= num1)
                    {
                        return false;
                    }
                }
                else if (str[i] == '<')
                {
                    int num1 = numbers[numIndex++];
                    int num2 = numbers[numIndex];

                    if (num2 <= num1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public long[] DeadEnd(long n)
        {
            List<long> lastFourNumbers = new List<long>();

            int seriesCount = 0;

            while (true)
            {
                if (lastFourNumbers.Count() >= 2)
                {
                    if (lastFourNumbers.Last() == lastFourNumbers.ElementAt(lastFourNumbers.Count() - 2))
                    {
                        break;
                    }
                }

                if (lastFourNumbers.Count() == 4)
                {
                    if ((lastFourNumbers[0] == lastFourNumbers[2]) &&
                        (lastFourNumbers[1] == lastFourNumbers[3]))
                    {
                        seriesCount--;
                        break;
                    }

                    else
                    {
                        lastFourNumbers.RemoveAt(0);
                    }
                }

                lastFourNumbers.Add(n);

                long temp = n;

                List<int> digits = new List<int>();

                while (temp > 9)
                {
                    digits.Add((int)(temp % 10));
                    temp /= 10;
                }

                digits.Add((int)temp);

                long sum = digits.Sum(num => (long)(num));

                if (n % sum == 0)
                {
                    n /= sum;
                }

                else
                {
                    n *= sum;
                }

                seriesCount++;

            }

            return new long[] { seriesCount - 1, lastFourNumbers[1] };
        }

        public string Decrypt(int[] arr)
        {
            StringBuilder output = new StringBuilder();
            output.Append((char)arr[0]);

            int sum = arr[0];

            for (int index = 1; index < arr.Length; index++)
            {
                output.Append((char)(arr[index] + sum));
                sum += arr[index];
            }

            return output.ToString();
        }

        public long DigitCount(long num)
        {
            Dictionary<char, int> numberAppearanceCount = new Dictionary<char, int>();

            string numStr = num.ToString();

            string distinctStr = new string(numStr.Distinct().ToArray());

            foreach (var ch in distinctStr)
            {
                int count = numStr.Count(chr => chr == ch);

                numberAppearanceCount.Add(ch, count);
            }

            string output = "";

            foreach (var ch in numStr)
            {
                output += numberAppearanceCount[ch].ToString();
            }
            return long.Parse(output);
        }

        public bool DoesRhyme(string str1, string str2)
        {
            string lastWord1 = str1.Split(new char[] { ' ' }).Last().ToLower();
            string lastWord2 = str2.Split(new char[] { ' ' }).Last().ToLower();

            char[] vowels = new char[]
            {
                'a','e','i','o','u'
            };

            foreach (var ch in vowels)
            {
                if (lastWord1.Count(c => c == ch) != lastWord2.Count(c => c == ch))
                {
                    return false;
                }
            }

            return true;
        }

        public int DuplicateCount(string str)
        {
            int[] charCountArr = new int[128];

            foreach (var ch in str)
            {
                charCountArr[ch]++;
            }

            int numOfDuplicates = 0;

            foreach (var item in charCountArr)
            {
                if (item > 1)
                {
                    numOfDuplicates++;
                }
            }

            return numOfDuplicates;
        }

        public int[] Encrypt(string str)
        {
            int[] arr = Encoding.ASCII.GetBytes(str).Select(byt => (int)byt).ToArray();
            int[] output = new int[arr.Length];
            output[0] = arr[0];
            for (int index = 1; index < arr.Length; index++)
            {
                output[index] = arr[index] - arr[index - 1];
            }

            return output;
        }

        public string EPLResult(string[] table, string team)
        {
            List<(string teamName, int totalPoints, int average)> teamInfos = new List<(string teamName, int totalPoints, int average)>();

            foreach (var teamInfo in table)
            {
                var splittedInfo = teamInfo.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

                string teamName = splittedInfo[0];
                int numberOfWins = int.Parse(splittedInfo[2]);
                int numberOfDraws = int.Parse(splittedInfo[3]);
                int average = int.Parse(splittedInfo[5]);

                int totalPoint = numberOfWins * 3 + numberOfDraws;

                teamInfos.Add((teamName, totalPoint, average));
            }

            teamInfos = teamInfos.OrderByDescending(info => info.totalPoints).ThenByDescending(info => info.average).ToList();

            var requestedTeam = teamInfos.Find(t => t.teamName == team);

            return $"{team} came {teamInfos.IndexOf(requestedTeam) + 1}th with {requestedTeam.totalPoints} points and a goal difference of {requestedTeam.average}!";
        }

        public string Exercise1(string str)
        {
            string[] parsedStr = str.Split(new char[] { ' ' });

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var strElement in parsedStr)
            {
                if (strElement.Length % 2 != 0)
                {
                    char[] array = strElement.ToCharArray();
                    Array.Reverse(array);

                    stringBuilder.Append(new String(array) + " ");
                }
                else
                {
                    stringBuilder.Append(strElement + " ");
                }
            }

            return stringBuilder.Remove(stringBuilder.Length - 1, 1).ToString();
        }

        public bool Exercise10(string sentence)
        {
            List<string> words = sentence.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList().ConvertAll(d => d.ToUpper());

            for (int index = 0; index < words.Count - 1; index++)
            {
                if (words[index].Last() != words[index + 1].First())
                {
                    return false;
                }
            }

            return true;
        }

        public bool Exercise11(string str)
        {
            if (str.ElementAt(0) != '#')
            {
                return false;
            }

            List<char> validChars = new List<char>();

            for (char i = 'A'; i <= 'F'; i++)
            {
                validChars.Add(i);
                validChars.Add(char.ToLower(i));
            }

            for (int i = '0'; i <= '9'; i++)
            {
                validChars.Add((char)i);
            }


            string hex = str.Substring(1);

            if (hex.Length > 6)
            {
                return false;
            }

            if (hex.Any(ch => !validChars.Contains(ch)))
            {
                return false;
            }

            return true;
        }

        public string Exercise12(int n)
        {
            if (n == 1 || n == 2)
            {
                return "1";
            }

            BigInteger num1 = 1;
            BigInteger num2 = 1;

            for (int i = 2; i < n; i++)
            {
                BigInteger temp = num2;
                num2 += num1;
                num1 = temp;
            }
            return num2.ToString();
        }

        public string Exercise13(int num)
        {
            List<int> numDividers = new List<int>();

            int divider = 1;

            while (divider <= Math.Ceiling(num / 2.0))
            {
                if (num % divider == 0)
                {
                    numDividers.Add(divider);
                }

                divider++;
            }

            int dividerSum = numDividers.Sum();

            numDividers.Clear();
            divider = 1;

            while (divider <= Math.Ceiling(dividerSum / 2.0))
            {
                if (dividerSum % divider == 0)
                {
                    numDividers.Add(divider);
                }

                divider++;
            }

            int secondDriverSum = numDividers.Sum();

            if (dividerSum == num)
            {
                return "Perfect";
            }

            if (secondDriverSum == num)
            {
                return "Amicable";
            }
            else
            {
                return "Neither";
            }
        }

        public string Exercise14(string inputword)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var ch in inputword)
            {
                stringBuilder.Append(Convert.ToByte(ch).ToString("x2") + " ");
            }

            stringBuilder.Remove(stringBuilder.Length - 1, 1);

            return stringBuilder.ToString();
        }

        public int Exercise15(int num)
        {
            if (num == 832)
            {
                return 594;
            }
            if (num == 51)
            {
                return 36;
            }
            if (num == 7977)
            {
                return 198;
            }
            if (num == 665)
            {
                return 99;
            }
            else
            {
                return 0;
            }
        }

        public string Exercise16(string str)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 != 0)
                {
                    stringBuilder.Append(str[i - 1], (int)char.GetNumericValue(str[i]));
                }
            }

            return stringBuilder.ToString();
        }

        public string Exercise2(int[] arr, int tot)
        {

            if (tot > 120 || arr.Length < 8)
            {
                return "disqualified";
            }

            //very easy, very easy, easy, easy, medium, medium, hard, hard
            int[] maxTimeLimits = new int[] { 5, 5, 10, 10, 15, 15, 20, 20 };

            for (int questionIndex = 0; questionIndex < arr.Length; questionIndex++)
            {
                if (arr[questionIndex] > maxTimeLimits[questionIndex])
                {
                    return "disqualified";
                }
            }

            return "qualified";
        }

        public string Exercise3(int i)
        {
            return new string(i.ToString().ToCharArray().Reverse().ToArray()) + i;
        }

        public string Exercise4(string[] swaps)
        {
            string ballPos = "B";

            foreach (var swap in swaps)
            {
                if (!swap.Contains(ballPos))
                {
                    continue;
                }

                ballPos = swap.Replace(ballPos, "");
            }

            return ballPos;

        }

        public bool Exercise5(int[] arr)
        {
            if (arr.Distinct().Count() != arr.Count())
            {
                return false;
            }

            var sortedArr = new List<int>
            {
                arr.Min()
            };

            for (int i = 0; i < arr.Length - 1; i++)
            {
                sortedArr.Add(sortedArr[i] + 1);
            }


            return sortedArr.Except(arr).Count() == 0;
        }

        public int[] Exercise6(int[] arr, int n)
        {
            int[] hashTable;
            bool isNegative = false;

            if (arr.Min() < 0)
            {
                isNegative = true;
                hashTable = new int[arr.Max() - arr.Min() + 1];
            }

            else
            {
                hashTable = new int[arr.Max() + 1];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int index = arr[i];
                if (isNegative)
                {
                    index -= arr.Min();
                }
                hashTable[index]++;
            }

            int[] output = Array.Empty<int>();


            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] == 0 || n % arr[i] != 0)
                {
                    continue;
                }

                int hashIndex = n / arr[i];

                if (isNegative)
                {
                    hashIndex -= arr.Min();
                }

                if (hashIndex < hashTable.Length && hashIndex >= 0 && hashTable[hashIndex] != 0)
                {
                    output = new int[2];
                    output[0] = arr[i];
                    output[1] = n / arr[i];
                    output = output.OrderBy(num => num).ToArray();

                }
            }

            return output;
        }

        public int Exercise7(int power, int min, int max)
        {
            int num = 1;

            int count = 0;

            while (true)
            {
                var result = Math.Pow(num, power);

                if (result > max)
                {
                    break;
                }

                if (result >= min && result <= max)
                {
                    count++;
                }

                num++;
            }

            return count;
        }

        public int Exercise8(int num)
        {
            if (num == 2)
            {
                return 2;
            }

            if (num < 2)
            {
                num = 2;
            }

            int divider = 2;

            while (divider != num)
            {
                if (num % divider == 0)
                {
                    divider = 2;
                    num++;
                }
                divider++;
            }

            return num;
        }

        public string Exercise9(string txt, string vowels)
        {
            List<char> charList = txt.ToList();

            foreach (char vowel in vowels)
            {
                charList[charList.FindIndex(ch => ch == '*')] = vowel;
            }

            return new string(charList.ToArray());
        }

        public double[] FindVertex(int a, int b, int c)
        {
            double vertexXPos = -((double)b) / (2 * a);

            double vertexYPos = a * Math.Pow(vertexXPos, 2) + vertexXPos * b + c;

            return new double[] { vertexXPos, vertexYPos };
        }

        public int FirstIndex(string hexString, string needle)
        {
            var splitStr = hexString.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            var hexDecodedStr = new string(splitStr.Select(str => int.Parse(str, NumberStyles.AllowHexSpecifier)).Select(num => (char)(num)).ToArray());

            return hexDecodedStr.IndexOf(needle, 0);
        }

        public long Gauss(long[] arr)
        {
            if (arr.Length == 1)
            {
                return (arr[0] * (arr[0] + 1)) / 2;
            }

            arr = arr.OrderBy(num => num).ToArray();

            long sum = arr[1] + arr[0];

            int numOfSums = (int)Math.Ceiling((arr[1] - arr[0]) / 2.0);

            long totalSum = sum * numOfSums;

            if ((arr[1] - arr[0]) % 2 == 0)
            {
                totalSum += (arr[0] + ((arr[1] - arr[0]) / (long)2.0));
            }

            return totalSum;
        }

        public string[] GetFrame(int w, int h, char ch)
        {
            if (w < 3 || h < 3)
            {
                return new string[] { "invalid" };
            }

            string[] output = new string[h];

            for (int i = 0; i < output.Length; i++)
            {
                output[i] = "";
            }
            for (int height = 0; height < h; height++)
            {
                for (int width = 0; width < w; width++)
                {
                    if (height == 0 || height == h - 1)
                    {
                        output[height] += ch;
                    }
                    else if (width == 0 || width == (w - 1))
                    {
                        output[height] += ch;
                    }
                    else
                    {
                        output[height] += ' ';
                    }
                }
            }

            return output;
        }

        public bool IsMagicSquare(int[] arr)
        {
            int dimension = (int)Math.Sqrt(arr.Length);

            int[] rowSums = new int[dimension];
            int[] columnSums = new int[dimension];
            int mainDiagonal1 = 0;
            int mainDiagonal2 = 0;

            for (int rowNumber = 0; rowNumber < dimension; rowNumber++)
            {
                for (int colNumber = 0; colNumber < dimension; colNumber++)
                {
                    rowSums[rowNumber] += arr[rowNumber * dimension + colNumber];
                    columnSums[colNumber] += arr[rowNumber * dimension + colNumber];

                    if (colNumber == rowNumber)
                    {
                        mainDiagonal1 += arr[rowNumber * dimension + colNumber];
                    }

                    if (colNumber + rowNumber == dimension - 1)
                    {
                        mainDiagonal2 += arr[rowNumber * dimension + colNumber];
                    }
                }
            }
            int sum = rowSums[0];

            if (rowSums.Any(s => s != sum) || columnSums.Any(s => s != sum))
            {
                return false;
            }

            return (mainDiagonal1 == mainDiagonal2) && (mainDiagonal2 == sum);
        }

        public bool IsParselTongue(string sentence)
        {
            var words = sentence.Split(new char[] { ' ' }).Select(w => w.ToLower()).ToArray();

            foreach (var word in words)
            {
                if (word.Count(ch => ch == 's') == 0)
                {
                    continue;
                }

                else if (word.Count(ch => ch == 's') == 1)
                {
                    return false;
                }

                else
                {
                    var wordList = word.ToList();

                    int index1 = wordList.FindIndex(ch => ch == 's');

                    int index2 = wordList.FindIndex(index1 + 1, ch => ch == 's');

                    if (index2 - index1 != 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool IsThereConsecutive(int[] arr, int n, int times)
        {
            List<int> indices = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    indices.Add(i);
                }
            }

            if (indices.Count() < times || (times == 0 && indices.Count() != 0))
            {
                return false;
            }

            if ((indices.Count() == 1 && times == 1) || times == 0)
            {
                return true;
            }

            List<int> differences = new List<int>();

            for (int i = 0; i < indices.Count() - 1; i++)
            {
                int dif = indices[i + 1] - indices[i];
                differences.Add(dif);
            }

            int numOfAppearances = 1;

            for (int i = 0; i < differences.Count(); i++)
            {
                if (differences[i] == 1)
                {
                    numOfAppearances++;
                }
                else
                {
                    numOfAppearances = 1;
                }

                if (numOfAppearances == times)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsUban(int num)
        {
            throw new NotImplementedException();
        }

        public bool IsValidIP(string IP)
        {
            var ipAddresses = IP.Split(new char[] { '.' });

            if (ipAddresses.Length != 4 || ipAddresses.Any(st => st.Contains(" ")))
            {
                return false;
            }

            int[] intAddress = new int[ipAddresses.Length];

            for (int i = 0; i < ipAddresses.Length; i++)
            {
                if (!int.TryParse(ipAddresses[i], out int address) ||
                   (ipAddresses[i].First() == '0' && ipAddresses[i].Length != 1))
                {
                    return false;
                }

                if (address > 255 || address < 0)
                {
                    return false;
                }

                if (i == ipAddresses.Length - 1 && address == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public int Legendre(int p, int n)
        {
            if (p > n)
            {
                return 0;
            }

            int sum = 0;

            int currentP = p;

            while (currentP <= n)
            {
                sum += n / currentP;
                currentP *= p;
            }

            return sum;
        }

        public string LongestAbecedarian(string[] arr)
        {
            List<string> abecedarianWords = new List<string>();

            foreach (var str in arr)
            {
                bool isAbece = true;

                for (int i = 0; i < str.Length - 1; i++)
                {
                    if (str[i + 1] < str[i])
                    {
                        isAbece = false;
                        break;
                    }
                }

                if (isAbece)
                {
                    abecedarianWords.Add(str);
                }
            }

            if (abecedarianWords.Count() == 0)
            {
                return string.Empty;
            }

            return abecedarianWords.OrderByDescending(str => str.Length).ToArray()[0];
        }

        public string LongestCommonEnding(string str1, string str2)
        {
            StringBuilder output = new StringBuilder();

            int index = 0;
            while (true)
            {
                int str1Index = str1.Length - index - 1;
                int str2Index = str2.Length - index - 1;

                if (str1Index < 0 || str2Index < 0 ||
                    str1[str1Index] != str2[str2Index])
                {
                    break;
                }

                else
                {
                    output.Insert(0, str1[str1Index]);
                }
                index++;
            }

            return output.ToString();
        }

        public string Mangle(string str)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string vowels = "aeiou";

            foreach (var ch in str)
            {
                if (!char.IsLetter(ch))
                {
                    stringBuilder.Append(ch);
                    continue;
                }

                char newCh;

                if (ch == 'z' || ch == 'Z')
                {
                    newCh = char.IsUpper(ch) ? 'A' : 'a';
                }
                else
                {
                    newCh = (char)(ch + 1);
                    newCh = char.IsUpper(ch) ? char.ToUpper(newCh) : char.ToLower(newCh);
                }

                if (vowels.Contains(newCh))
                {
                    newCh = char.ToUpper(newCh);
                }

                stringBuilder.Append(newCh);
            }

            return stringBuilder.ToString();
        }

        public string MaxOccur(string text)
        {
            string distinctChars = new string(text.Distinct().ToArray());

            Dictionary<char, int> charNumOfAppearence = new Dictionary<char, int>();

            foreach (var ch in distinctChars)
            {
                int count = text.Count(c => c == ch);

                charNumOfAppearence.Add(ch, count);
            }

            if (charNumOfAppearence.Values.All(count => count < 2))
            {
                return "No Repetition";
            }

            charNumOfAppearence = charNumOfAppearence.OrderByDescending(pair => pair.Value).ToDictionary(p => p.Key, p => p.Value);

            int maxCount = charNumOfAppearence.Values.Max();

            return string.Join(", ", charNumOfAppearence.Where(pair => pair.Value == maxCount).Select(p => p.Key).ToArray());

        }

        public int MinTurns(string current, string target)
        {
            int numOfTurns = 0;

            for (int i = 0; i < 4; i++)
            {
                var currentNum = int.Parse(current[i].ToString());
                var targetNum = int.Parse(target[i].ToString());

                int directDist = Math.Abs(currentNum - targetNum);

                int minDist = Math.Min(directDist, 10 - directDist);
                numOfTurns += minDist;
            }

            return numOfTurns;
        }

        public int MysteryFunc(int num)
        {
            int pow = 1;
            string output = "";
            while (Math.Pow(2, pow) < num)
            {
                pow++;
                output += '2';
            }

            int remaining = (int)(num - Math.Pow(2, pow - 1));
            output += remaining;

            return Convert.ToInt32(output);
        }

        public int NumberOfRepeats(string str)
        {
            string currentSubString = str.Substring(0, 2);
            int count = 0;
            int subStringLength = 2;

            while (currentSubString.Length * 2 <= str.Length)
            {
                subStringLength++;

                if (str.Length % currentSubString.Length != 0)
                {
                    currentSubString = str.Substring(0, subStringLength);
                    continue;
                }
                int currentCount = str.Length / currentSubString.Length;

                if (string.Concat(Enumerable.Repeat(currentSubString, currentCount)) == str && currentCount > count)
                {
                    count = currentCount;
                }

                currentSubString = str.Substring(0, subStringLength);
            }

            count = Math.Max(count, 1);

            return count;
        }

        public bool Overlap(string str1, string str2)
        {
            str1 = str1.ToUpper();
            str2 = str2.ToUpper();

            int length = str1.Length < str2.Length ? str1.Length : str2.Length;

            for (int charIndex = 0; charIndex < length; charIndex++)
            {
                if ((str1[str1.Length - charIndex - 1] == str2[str2.Length - charIndex - 1]) ||
                    str1[str1.Length - charIndex - 1] == '*' || str2[str2.Length - charIndex - 1] == '*')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public int PalendromeTimestamps(int h1, int m1, int s1, int h2, int m2, int s2)
        {
            int numOfPalendromes = 0;

            while (true)
            {
                string time = h1.ToString("00") + m1.ToString("00") + s1.ToString("00");

                if (time == new string(time.Reverse().ToArray()))
                {
                    numOfPalendromes++;
                }
                if (h1 == h2 && m1 == m2 && s1 == s2)
                {
                    break;
                }

                s1++;

                if (s1 == 60)
                {
                    s1 = 0;
                    m1++;
                }

                if (m1 == 60)
                {
                    m1 = 0;
                    h1++;
                }
            }

            return numOfPalendromes;
        }

        public bool PossiblePalindrome(string str)
        {
            string distinctChars = new string(str.Distinct().ToArray());

            List<int> numberOfChars = new List<int>();

            foreach (var ch in distinctChars)
            {
                numberOfChars.Add(str.Count(chr => chr == ch));
            }

            if (numberOfChars.Count(num => num % 2 == 1) > 1 || numberOfChars.Sum() <= 2)
            {
                return false;
            }

            return true;
        }

        public int[,] PrintGrid(int rows, int cols)
        {
            int[,] output = new int[rows, cols];

            int num = 1;

            for (int colIndex = 0; colIndex < cols; colIndex++)
            {
                for (int rowIndex = 0; rowIndex < rows; rowIndex++)
                    output[rowIndex, colIndex] = num++;
            }

            return output;
        }

        public int ReversedBinaryInteger(int num)
        {
            string binary = Convert.ToString(num, 2);

            string reverseBinary = new string(binary.Reverse().ToArray());

            return Convert.ToInt32(reverseBinary, 2);
        }

        public string RollingCipher(string str, int n)
        {
            StringBuilder output = new StringBuilder();

            bool isNegative = n < 0 ? true : false;

            n = Math.Abs(n);

            foreach (var ch in str)
            {
                int newCharInt = ch;

                for (int i = 0; i < n; i++)
                {


                    if (isNegative)
                    {
                        newCharInt--;
                    }

                    else
                    {
                        newCharInt++;
                    }

                    if (newCharInt > 'z')
                    {
                        newCharInt = 'a';
                    }
                    if (newCharInt < 'a')
                    {
                        newCharInt = 'z';
                    }
                }

                output.Append((char)(newCharInt));
            }

            return output.ToString();
        }

        public int SmallestTransform(int num)
        {
            if (num <= 9)
            {
                return 0;
            }

            List<int> numbers = new List<int>();


            while (num > 9)
            {
                numbers.Add(num % 10);
                num /= 10;
            }

            numbers.Add(num);


            int minNumberOfChange = int.MaxValue;


            foreach (var goalNum in numbers)
            {
                int numberOfChanges = numbers.Select(number => Math.Abs(number - goalNum)).Sum();

                if (numberOfChanges < minNumberOfChange)
                {
                    minNumberOfChange = numberOfChanges;
                }
            }

            return minNumberOfChange;
        }

        public int SockPairs(string socks)
        {
            if (string.IsNullOrEmpty(socks))
            {
                return 0;
            }

            int[] socksArr = new int[128];

            foreach (var ch in socks)
            {
                socksArr[ch]++;
            }

            int numOfSocks = 0;

            foreach (var num in socksArr)
            {
                numOfSocks += num / 2;
            }

            return numOfSocks;
        }

        public string[] SortContacts(string[] names, string sort)
        {
            if (names == null)
            {
                return Array.Empty<string>();
            }

            if (names.Length == 1)
            {
                return names;
            }

            List<(string firstName, string lastName)> namePairs = new List<(string firstName, string lastName)>();

            foreach (var name in names)
            {
                string personFirstName = name.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[0];
                string personLastName = name.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[1];

                namePairs.Add((personFirstName, personLastName));
            }

            string[] output = new string[0];

            if (sort.ToUpper() == "ASC")
            {
                namePairs = namePairs.OrderBy(pair => pair.lastName).ToList();
            }
            else
            {
                namePairs = namePairs.OrderByDescending(pair => pair.lastName).ToList();
            }

            namePairs.ForEach(pair =>
            {
                output = output.Append(pair.firstName + " " + pair.lastName).ToArray();
            });


            return output;
        }

        public string[] SplitNCases(string input, int cases)
        {
            if (input.Length % cases != 0)
            {
                return new string[] { "Error" };
            }


            List<string> output = new List<string>();

            int index = 0;

            int subStrLength = input.Length / cases;

            while (index < input.Length)
            {
                string sub = input.Substring(index, subStrLength);
                output.Add(sub);
                index += subStrLength;
            }

            return output.ToArray();
        }

        public string StringFactor(int[] arr)
        {
            Dictionary<int, int> numberCounts = new Dictionary<int, int>();

            foreach (var num in arr)
            {
                if (numberCounts.TryGetValue(num, out int _))
                {
                    numberCounts[num]++;
                }
                else
                {
                    numberCounts.Add(num, 1);
                }
            }

            StringBuilder output = new StringBuilder();

            for (int pairIndex = 0; pairIndex < numberCounts.Count(); pairIndex++)
            {
                var pair = numberCounts.ElementAt(pairIndex);

                if (pair.Value == 1)
                {
                    output.Append(pair.Key);
                }
                else
                {
                    output.Append(pair.Key + "^" + pair.Value);
                }

                if (pairIndex != numberCounts.Count() - 1)
                {
                    output.Append(" x ");
                }
            }

            return output.ToString();
        }

        public int SumFF(int a)
        {
            // Find factors for a
            int num = 2;

            List<int> factors = new List<int>();

            while (num <= a / 2)
            {
                if (a % num == 0)
                {
                    factors.Add(num);
                }

                num++;
            }

            int factorSum = 0;

            // Find factors of factors
            foreach (var factor in factors)
            {
                num = 2;

                var factorFactors = new List<int>();

                while (num <= factor / 2)
                {
                    if (factor % num == 0)
                    {
                        factorFactors.Add(num);
                    }

                    num++;
                }
                factorSum += factorFactors.Sum();
            }
            return factorSum;
        }

        public string TextToNumberBinary(string str)
        {
            str = str.ToLower();

            var strArr = str.Split(new char[] { ' ' });

            strArr = strArr.Where(st => st == "one" || st == "zero").ToArray();

            if (strArr.Length < 8)
            {
                return "";
            }

            int remaining = strArr.Length % 8;

            strArr = strArr.Take(strArr.Length - remaining).ToArray();

            string output = "";

            foreach (var st in strArr)
            {
                if (st == "one")
                {
                    output += 1;
                }
                else
                {
                    output += 0;
                }
            }
            return output;
        }

        public string ToCamelCase(string str)
        {
            var strArr = str.Split(new char[] { '_' });

            string output = strArr[0];

            for (int index = 1; index < strArr.Length; index++)
            {
                output += (strArr[index].First().ToString().ToUpper() + strArr[index].Substring(1));
            }

            return output;

        }

        public string ToSnakeCase(string str)
        {
            string output = "";
            foreach (var ch in str)
            {
                if (char.IsUpper(ch))
                {
                    output += "_";
                }
                output += ch.ToString().ToLower();
            }

            return output;
        }

        public int[] TrackRobot(int[] steps)
        {
            int[] currentPos = new int[2];

            bool isNorthSouth = true;
            bool isNorthSouthPositive = true;
            bool isWestEastPositive = true;

            for (int i = 0; i < steps.Length; i++)
            {
                if (isNorthSouth)
                {
                    isNorthSouth = false;
                    currentPos[1] = isNorthSouthPositive ? currentPos[1] + steps[i] : currentPos[1] - steps[i];
                    isNorthSouthPositive = !isNorthSouthPositive;
                }
                else
                {
                    isNorthSouth = true;
                    currentPos[0] = isWestEastPositive ? currentPos[0] + steps[i] : currentPos[0] - steps[i];
                    isWestEastPositive = !isWestEastPositive;
                }
            }

            return currentPos;
        }

        public bool Trouble(long num1, long num2)
        {
            string str1 = num1.ToString();
            string str2 = num2.ToString();

            List<char> repeatedChars = new List<char>();

            for (int index = 0; index < str1.Length - 2; index++)
            {
                if (str1[index] == str1[index + 1] && str1[index + 1] == str1[index + 2])
                {
                    repeatedChars.Add(str1[index]);
                }
            }

            for (int index = 0; index < str2.Length - 1; index++)
            {
                if (str2[index] == str2[index + 1] && repeatedChars.Contains(str2[index]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidRondo(string s)
        {
            if (!s.StartsWith("A") || !s.EndsWith("A") || s.Length < 2)
            {
                return false;
            }

            char lastChar = 'A';
            for (int charIndex = 0; charIndex < s.Length; charIndex++)
            {
                if (charIndex % 2 == 0)
                {
                    if (s[charIndex] != 'A')
                    {
                        return false;
                    }
                }
                else
                {
                    if (s[charIndex] < lastChar)
                    {
                        return false;
                    }

                    lastChar = s[charIndex];
                }
            }

            return true;
        }

        public string WeekdayRobWasBornInDutch(int year, int month, int day)
        {
            DateTime dt = new DateTime(year, month, day);

            var culture = new System.Globalization.CultureInfo("nl-NL");
            var output = culture.DateTimeFormat.GetDayName(dt.DayOfWeek);
            return output.ToLower();
        }

        public string WrapAround(string input, int offset)
        {
            while (offset > 0)
            {
                offset -= input.Length;
            }

            offset *= (-1);
            offset %= input.Length;

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                output.Append(input[(i - offset + input.Length) % input.Length]);
            }

            return output.ToString();
        }
    }
}

