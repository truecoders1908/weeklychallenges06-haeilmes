﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace weeklyChallenges06
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words.Contains(word) && words != null)
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
            int[] count = new int[numbers.Length];
            for (int x = 0; x <= numbers.Length; x++)
            {
                for (int y = 0; y < numbers.Length; y++)
                {
                    if (numbers[y] == x)
                        count[x]++;
                }
            }
            return count.Max();
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
