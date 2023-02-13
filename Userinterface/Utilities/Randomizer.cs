using System;
using System.Linq;

namespace Userinterface.Utilities
{
    public static class Randomizer
    {
        public static int GetInt(int MaxValue = 18)
        {
            return new Random().Next(1, MaxValue);
        }

        public static string GetString(int numOfLetters = 6, int numOfCapitalLetters = 2, int numOfSpecialChars = 0, int numOfDigits = 0)
        {
            String alphabet = "abcdefghijklmnopqrstuvwxyz";
            String capitalAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            String specialChars = "!@#$%^&*~";

            String randomStr = "";

            for (int i = 0; i < numOfLetters; i++)
            {
                int letterIdx = new Random().Next(alphabet.Length);
                randomStr += alphabet.ElementAt(letterIdx);
            }

            for (int i = 0; i < numOfCapitalLetters; i++)
            {
                int capitalLetterIdx = new Random().Next(capitalAlphabet.Length);
                randomStr += capitalAlphabet.ElementAt(capitalLetterIdx);
            }

            for (int j = 0; j < numOfSpecialChars; j++)
            {
                int specCharIdx = new Random().Next(specialChars.Length);
                randomStr += specialChars.ElementAt(specCharIdx);
            }

            for (int k = 0; k < numOfDigits; k++)
            {
                randomStr += new Random().Next(9);
            }

            return randomStr;
        }

        public static string GetTopLevelDomain()
        {
            String[] topLevelDomainsList = { ".org", ".co.uk", ".net", ".gov", ".de", ".fr", ".nl", ".com", ".be", ".jpg" };
            int domainIdx = new Random().Next(topLevelDomainsList.Length);
            return topLevelDomainsList.ElementAt(domainIdx);
        }
    }
}