using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class VeryHardExerciseSolutions : IVeryHardExercises
    {
        public bool AnagramStrStr(string needle, string haystack)
        {
            StringBuilder newHayStack = new StringBuilder(haystack);

            for (int i = 0; i < newHayStack.Length; i++)
            {
                if (!needle.Contains(newHayStack[i]))
                {
                    newHayStack[i] = ' ';
                }
            }

            var splittedHayStack = newHayStack.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var str in splittedHayStack)
            {
                if (str.Length >= needle.Length)
                {
                    string temp = str;

                    foreach (var ch in needle)
                    {
                        if (temp.Contains(ch))
                        {
                            temp = temp.Remove(temp.IndexOf(ch), 1);
                        }

                        else
                        {
                            continue;
                        }
                    }
                    return true;
                }
            }

            return false;
        }

        public int[] Decode(string str)
        {
            List<int> output = new List<int>();

            foreach (var ch in str)
            {
                int asciiVal = ch;

                string asciiValStr = asciiVal.ToString();

                int sum = 0;

                foreach (var asciiCh in asciiValStr)
                {
                    sum += int.Parse(asciiCh.ToString());
                }

                output.Add(sum);
            }

            return output.ToArray();
        }

        public int DiamondSum(int n)
        {
            int firstColIndex = (int)Math.Ceiling((double)n / 2);

            List<(int row, int col)> rowColPairs = new List<(int row, int col)>();

            rowColPairs.Add((1, firstColIndex));

            int currentRow = 1;
            int currentCol = firstColIndex;

            while (currentCol > 1)
            {
                currentCol--;
                currentRow++;

                rowColPairs.Add((currentRow, currentCol));
            }

            while (currentRow < n)
            {
                currentRow++;
                currentCol++;

                rowColPairs.Add((currentRow, currentCol));
            }

            currentRow = 1;
            currentCol = firstColIndex;

            while (currentCol < n)
            {
                currentCol++;
                currentRow++;

                rowColPairs.Add((currentRow, currentCol));
            }

            while (currentRow < n - 1)
            {
                currentRow++;
                currentCol--;

                rowColPairs.Add((currentRow, currentCol));
            }

            return rowColPairs.Sum(pair => ((pair.row - 1) * n + pair.col));
        }

        public string FiboWord(int n)
        {
            if (n < 2)
            {
                return "invalid";
            }
            List<string> output = new List<string>()
            {
                "b",
                "a"
            };

            n -= 2;

            while (n > 0)
            {
                string newStr = output[output.Count - 1] + output[output.Count - 2];
                output.Add(newStr);
                n--;
            }

            return string.Join(", ", output.ToArray());
        }

        public string GenerateNonconsecutive(int len)
        {
            if (len == 1)
            {
                return "0 1";
            }

            string returnedStr = GenerateNonconsecutive(len - 1);

            var splittedStr = returnedStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> result = new List<string>();

            foreach (var str in splittedStr)
            {
                if (str[0] == '0')
                {
                    result.Add("1" + str);
                }
                result.Add("0" + str);
            }
            result.Sort();
            return string.Join(" ", result);
        }

        public string IncrementString(string txt)
        {
            if (txt.All(ch => char.IsLetter(ch)))
            {
                return txt + "1";
            }

            int index = txt.Length - 1;

            while (char.IsDigit(txt[index]))
            {
                index--;
            }

            string numberStr = txt.Substring(index + 1);
            txt = txt.Remove(index + 1, txt.Length - index - 1);
            string newNumber = (int.Parse(numberStr) + 1).ToString();

            while (numberStr.Length > newNumber.Length)
            {
                newNumber = newNumber.Insert(0, "0");
            }

            return txt + newNumber;
        }

        public bool InstrumentRange(string instr, string note)
        {
            string range;
            switch (instr)
            {
                case "Piccolo":
                    range = "D4-C7";
                    break;
                case "Tuba":
                    range = "D1-F4";
                    break;
                case "Guitar":
                    range = "E3-E6";
                    break;
                case "Piano":
                    range = "A0-C8";
                    break;
                case "Violin":
                    range = "G3-A7";
                    break;
                default:
                    throw new Exception("Error");
            }

            var rangeSplitted = range.Split(new char[] { '-' });

            int min = int.Parse(rangeSplitted[0][1].ToString()) * 7 + (rangeSplitted[0][0] - 'A');
            int max = int.Parse(rangeSplitted[1][1].ToString()) * 7 + (rangeSplitted[1][0] - 'A');

            int currentNote = int.Parse(note[1].ToString()) * 7 + (note[0] - 'A');

            return (currentNote >= min && currentNote <= max);
        }

        public bool IsMagicSquare(int[] arr)
        {
            throw new NotImplementedException();
        }

        public string LandscapeType(int[] arr)
        {
            if (arr.Length <= 2)
            {
                return "neither";
            }

            bool isIncreasing = false;
            bool isDecreasing = false;

            bool isTypeFound = false;

            bool isMountain = false;
            bool isValley = false;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                // Means increasing
                if (arr[i + 1] > arr[i])
                {
                    if (isTypeFound)
                    {
                        if (isMountain)
                        {
                            return "neither";
                        }
                    }

                    else
                    {
                        if (isDecreasing)
                        {
                            isTypeFound = true;
                            isValley = true;
                        }
                        isDecreasing = false;
                        isIncreasing = true;
                    }
                }

                // Means decreasing
                else if (arr[i] > arr[i + 1])
                {
                    if (isTypeFound)
                    {
                        if (isValley)
                        {
                            return "neither";
                        }
                    }

                    else
                    {
                        if (isIncreasing)
                        {
                            isTypeFound = true;
                            isMountain = true;
                        }
                        isDecreasing = true;
                        isIncreasing = false;
                    }
                }
            }

            if (!isTypeFound)
            {
                return "neither";
            }

            if (isMountain)
            {
                return "mountain";
            }
            else
            {
                return "valley";
            }
        }

        public int License(string me, int agents, string others)
        {
            var names = others.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            names.Add(me);

            names.Sort();

            int index = names.IndexOf(me) + 1;

            int licenseTime = 20;

            return ((int)Math.Ceiling(index / (double)(agents)) * licenseTime);
        }

        public string LongestSubstring(string digits)
        {

            bool isPreviousEven = int.Parse(digits[0].ToString()) % 2 == 0;

            string currentSubStr = digits[0].ToString();
            string longestSubStr = digits[0].ToString();

            for (int index = 1; index < digits.Length; index++)
            {
                bool isCurrentEven = int.Parse(digits[index].ToString()) % 2 == 0;

                if (isPreviousEven == !isCurrentEven)
                {
                    currentSubStr += digits[index];

                    if (currentSubStr.Length > longestSubStr.Length)
                    {
                        longestSubStr = currentSubStr;
                    }
                }

                else
                {
                    currentSubStr = digits[index].ToString();
                }

                isPreviousEven = isCurrentEven;
            }

            return longestSubStr;
        }

        public string MissingAlphabets(string str)
        {
            // Find number of alphebets
            var distinctCharArr = str.Distinct().ToArray();
            int numOfAlphabets = distinctCharArr.Select(ch => str.Count(c => c == ch)).Max();

            // Find missing chars
            StringBuilder output = new StringBuilder();

            for (char ch = 'a'; ch <= 'z'; ch++)
            {
                int num = str.Count(c => c == ch);
                output.Append(ch, numOfAlphabets - num);
            }

            return output.ToString();
        }

        public int OverlappingRectangles(int[] rect1, int[] rect2)
        {
            int rightPointRect1 = rect1[0] + rect1[2];
            int leftPointRect1 = rect1[0];
            int upperPointRect1 = rect1[1] + rect1[3];
            int lowerPointRect1 = rect1[1];

            int rightPointRect2 = rect2[0] + rect2[2];
            int leftPointRect2 = rect2[0];
            int upperPointRect2 = rect2[1] + rect2[3];
            int lowerPointRect2 = rect2[1];

            // Check if rectangles overlap
            if (leftPointRect1 >= rightPointRect2 || leftPointRect2 >= rightPointRect1)
            {
                return 0;
            }

            if (lowerPointRect1 >= upperPointRect2 && lowerPointRect2 >= upperPointRect1)
            {
                return 0;
            }

            int largerLeftPoint = leftPointRect1 > leftPointRect2 ? leftPointRect1 : leftPointRect2;
            int smallerRightPoint = rightPointRect1 > rightPointRect2 ? rightPointRect2 : rightPointRect1;

            int smallerUpperPoint = upperPointRect1 > upperPointRect2 ? upperPointRect2 : upperPointRect1;
            int largerLowerPoint = lowerPointRect1 > lowerPointRect2 ? lowerPointRect1 : lowerPointRect2;

            return Math.Abs(smallerRightPoint - largerLeftPoint) * (smallerUpperPoint - largerLowerPoint);
        }

        public string OverTime(double[] arr)
        {
            double normalIncome = 0;

            if (arr[0] < 17)
            {
                double endingHour = arr[1] > 17 ? 17 : arr[1];

                normalIncome = (endingHour - arr[0]) * arr[2];
            }

            double overtimeIncome = 0;

            if (arr[1] > 17)
            {
                overtimeIncome = (arr[1] - 17) * arr[3] * arr[2];
            }

            double totalIncome = normalIncome + overtimeIncome;

            return $"${totalIncome:F2}";
        }

        public int[] PalSeq(int n)
        {
            int baseNum = 1;
            int numOfSteps = 0;

            while (true)
            {
                bool isFound;

                int currentNum = baseNum;

                while (true)
                {
                    if (currentNum == n)
                    {
                        isFound = true;
                        break;
                    }

                    if (currentNum > n)
                    {
                        isFound = false;
                        break;
                    }

                    string currentNumStr = currentNum.ToString();

                    string currentNumReverseStr = new string(currentNumStr.Reverse().ToArray());

                    int currentNumReverseInt = int.Parse(currentNumReverseStr);

                    if (currentNumReverseInt == currentNum)
                    {
                        isFound = false;
                        break;
                    }

                    currentNum += currentNumReverseInt;

                    numOfSteps++;
                }

                if (isFound)
                {
                    return new int[] { baseNum, numOfSteps };
                }

                else
                {
                    baseNum++;
                    numOfSteps = 0;
                }
            }
        }

        public string Permutations(string s)
        {
            if (s.Length == 1)
            {
                return s;
            }

            List<string> result = new List<string>();

            for (int index = 0; index < s.Length; index++)
            {
                string returnedStr = Permutations(s.Remove(index, 1));

                var parsedStr = returnedStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var str in parsedStr)
                {
                    result.Add(s.ElementAt(index) + str);
                }
            }
            result.Sort();
            return string.Join(" ", result);
        }

        public bool SameLetterPattern(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }

            for (int index = 0; index < str1.Length - 1; index++)
            {
                if (str1[index] - str1[index + 1] != str2[index] - str2[index + 1])
                {
                    return false;
                }
            }

            return true;
        }

        public string Simplify(string str)
        {
            var splittedStr = str.Split(new char[] { '/' });

            int numerator = int.Parse(splittedStr[0]);
            int denumerator = int.Parse(splittedStr[1]);

            int num = 2;

            while (true)
            {
                if (num > numerator || num > denumerator)
                {
                    break;
                }

                if (numerator % num == 0 && denumerator % num == 0)
                {
                    numerator /= num;
                    denumerator /= num;

                    num = 2;
                    continue;
                }

                num++;
            }

            if (denumerator == 1)
            {
                return numerator.ToString();
            }

            return numerator + "/" + denumerator;

        }

        public string Sorting(string str)
        {
            List<(char, bool)> letterBool = new List<(char, bool)>();
            List<char> numbers = new List<char>();

            foreach (var ch in str)
            {
                if (char.IsLetter(ch))
                {
                    if (!letterBool.Contains((ch, char.IsUpper(ch))))
                    {
                        letterBool.Add((ch, char.IsUpper(ch)));
                    }
                }
                else
                {
                    numbers.Add(ch);
                }
            }

            letterBool = letterBool.ConvertAll(item => (char.ToLower(item.Item1), item.Item2));

            letterBool = letterBool.OrderBy(item => item.Item1).ToList();
            numbers.Sort();

            for (int i = 0; i < letterBool.Count - 1; i++)
            {
                if (letterBool[i].Item2)
                {
                    if (letterBool[i].Item1 == letterBool[i + 1].Item1)
                    {
                        letterBool[i + 1] = (char.ToUpper(letterBool[i + 1].Item1), false);
                    }
                    else
                    {
                        letterBool[i] = (char.ToUpper(letterBool[i].Item1), false);
                    }
                }
            }

            if (letterBool.Last().Item2)
            {
                letterBool[letterBool.Count() - 1] = (char.ToUpper(letterBool.Last().Item1), letterBool.Last().Item2);
            }

            var letters = letterBool.Select(item => item.Item1).ToList();
            letters.AddRange(numbers);

            return new string(letters.ToArray());
        }

        public string SpecialReverseString(string txt)
        {
            string txtWOSpaces = txt.Replace(" ", "");
            StringBuilder reversedStr = new StringBuilder(new string(txtWOSpaces.ToLower().Reverse().ToArray()));

            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == ' ')
                {
                    reversedStr = reversedStr.Insert(i, " ");
                }

                else if (char.IsUpper(txt[i]))
                {
                    reversedStr[i] = char.ToUpper(reversedStr[i]);
                }
            }

            return reversedStr.ToString();
        }

        public string TapCode(string text)
        {
            string[,] chars = new string[5, 5]
            {
                {"A","B","CK","D","E" },
                {"F",      "G",      "H",      "I",      "J", },
                {"L",      "M",      "N",      "O",      "P",},
                {"Q",      "R",      "S",      "T",      "U",},
                {"V",      "W",      "X",      "Y",      "Z"},
            };

            text = text.ToUpper();

            bool isTap = false;

            if (text[0] == '.')
            {
                isTap = true;
            }

            string result = "";

            if (isTap)
            {
                var splittedTaps = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < splittedTaps.Length - 1; i+=2)
                {
                    int row = splittedTaps[i].Count() - 1;
                    int col = splittedTaps[i + 1].Count() - 1;
                    
                    if (row==0 && col==2)
                    {
                        result += 'c';
                    }
                    else
                    {
                        result += chars[row, col];
                    }
                }

            }

            else
            {
                foreach (var ch in text)
                {
                    int row = 0;
                    int col = 0;

                    for (int rowIndex = 0; rowIndex < chars.GetLength(0); rowIndex++)
                    {
                        for (int colIndex = 0; colIndex < chars.GetLength(1); colIndex++)
                        {
                            if (chars[rowIndex, colIndex].Contains(ch))
                            {
                                row = rowIndex + 1;
                                col = colIndex + 1;
                                break;
                            }
                        }
                    }

                    result += new string('.', row);
                    result += " ";
                    result += new string('.', col);
                    result += " ";
                }

                result = result.Remove(result.Length - 1, 1);
            }

            return result.ToLower();
        }

        public int[] TrackRobot(string steps)
        {
            if (string.IsNullOrEmpty(steps))
            {
                return new int[] { 0, 0 };
            }

            char currentDir = 'e';

            int[] currentPos = new int[] { 0, 0 };

            foreach (var ch in steps)
            {
                if (currentDir == 'e')
                {
                    if (ch == '.')
                    {
                        currentPos[0] += 1;
                    }
                    else if (ch == '>')
                    {
                        currentDir = 's';
                    }
                    else if (ch == '<')
                    {
                        currentDir = 'n';
                    }
                }
                else if (currentDir == 'w')
                {
                    if (ch == '.')
                    {
                        currentPos[0] -= 1;
                    }
                    else if (ch == '>')
                    {
                        currentDir = 'n';
                    }
                    else if (ch == '<')
                    {
                        currentDir = 's';
                    }

                }
                else if (currentDir == 'n')
                {
                    if (ch == '.')
                    {
                        currentPos[1] += 1;
                    }
                    else if (ch == '>')
                    {
                        currentDir = 'e';

                    }
                    else if (ch == '<')
                    {
                        currentDir = 'w';

                    }
                }
                else if (currentDir == 's')
                {
                    if (ch == '.')
                    {
                        currentPos[1] -= 1;
                    }
                    else if (ch == '>')
                    {
                        currentDir = 'w';

                    }
                    else if (ch == '<')
                    {
                        currentDir = 'e';

                    }
                }
            }

            return currentPos;
        }

        public string TrueAlphabetic(string str)
        {
            List<int> lengths = new List<int>();

            var splittedStrs = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var splittedStr in splittedStrs)
            {
                lengths.Add(splittedStr.Length);
            }

            var joinedElements = string.Join("", splittedStrs).ToCharArray();

            string joinedStr = new string(joinedElements.OrderBy(ch => ch).ToArray());

            List<string> output = new List<string>();


            foreach (var lenth in lengths)
            {
                string sub = joinedStr.Substring(0, lenth);
                output.Add(sub);
                joinedStr = joinedStr.Remove(0, lenth);
            }

            return string.Join(" ", output);
        }

        public double UniqueFract()
        {
            double sum = 0;

            for (double numerator = 1; numerator <= 9; numerator++)
            {
                for (double denumerator = numerator + 1; denumerator <= 9; denumerator++)
                {
                    bool skip = false;

                    for (double num = 2; num <= denumerator; num++)
                    {
                        if (denumerator % num == 0 && numerator % num == 0)
                        {
                            skip = true;
                            break;
                        }
                    }

                    if (!skip)
                    {
                        sum += numerator / denumerator;
                    }
                }
            }

            return sum;
        }

        public bool ValidatePassword(string password)
        {
            if (password.Length > 24 || password.Length < 6)
            {
                return false;
            }

            if (password.Count(ch => char.IsLower(ch)) == 0 || password.Count(ch => char.IsUpper(ch)) == 0)
            {
                return false;
            }

            if (password.Count(ch => char.IsDigit(ch)) == 0 || password.Count(ch => ch <= sbyte.MaxValue) == 0)
            {
                return false;
            }

            for (int i = 0; i < password.Length - 2; i++)
            {
                if ((password[i] == password[i + 1]) && (password[i] == password[i + 2]))
                {
                    return false;
                }
            }

            var allowedSpecialChars = "! @ # $ % ^ & * ( ) + = _ - { } [ ] : ; \" ' ? < > , .".Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (password.Any(ch => !char.IsDigit(ch) && ch > sbyte.MaxValue && !allowedSpecialChars.Contains(ch.ToString())))
            {
                return false;
            }

            return true;
        }

        public bool ValidName(string name)
        {
            var splittedName = name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (splittedName.Length != 2 && splittedName.Length != 3)
            {
                return false;
            }

            if (splittedName.Any(str => char.IsLower(str[0])))
            {
                return false;
            }

            foreach (var nameStr in splittedName)
            {
                if (nameStr.Contains('.'))
                {
                    if (nameStr.Length != 2)
                    {
                        return false;
                    }
                }
                else
                {
                    if (nameStr.Length <= 2)
                    {
                        return false;
                    }
                }
            }

            string firstName = splittedName[0];
            string middleName = null;
            string lastName = splittedName[splittedName.Length - 1];

            if (splittedName.Length == 3)
            {
                middleName = splittedName[1];
            }

            bool isFirstNameInitial = firstName.Contains(".");

            if (middleName != null)
            {
                // Middle name needs to be initial also
                if (isFirstNameInitial)
                {
                    if (!middleName.Contains("."))
                    {
                        return false;
                    }
                }
            }

            if (lastName.Contains("."))
            {
                return false;
            }
            return true;
        }

        public string XORCipher(string msg1, string msg2)
        {
            throw new NotImplementedException();
        }
    }
}
