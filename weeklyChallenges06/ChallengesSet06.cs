using System;
using System.Linq;
using System.Collections.Generic;

namespace weeklyChallenges06
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if(words is null || words.Contains(null))
            {
                return false;
            }
            foreach(string item in words)
            {
                if(ignoreCase == true && item.ToLower() == word)
                {
                    return true;
                }
            }
            if (words.Contains(word))
            {
                return true;
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            int n, i;
            n = num / 2;
            for (i = 2; i <= n; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            if (num <= 1)
            {
                return false;
            }
            return true;
        }
        public int IndexOfLastUniqueLetter(string str)
        {
            throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int newCount;
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                newCount = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        newCount++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (newCount > counter)
                {
                    counter = newCount;
                }
            }
            return counter;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (n <= 0 || elements == null)
            {
                double[] wrong = new double[0];
                return wrong;
            }
            return elements.Where((x, i) => (i + 1) % n == 0).ToArray();
        }
    }
}
