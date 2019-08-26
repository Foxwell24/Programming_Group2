using System;

namespace Challenge1Practice
{
    public class WordProcessing
    {
        //Return input with all letters in alternating case.
        //If input starts with an uppercase letter, second
        //letter should be lowercase, third uppercase, etc.
        //If input starts with an lowercase letter, second
        //letter should be uppercase, third lowercase, etc.
        public string AlternateCase(string input)
        {
            char[] chars = input.ToCharArray();
            if (Char.IsUpper(chars[0]))
            {
                for (int i = 1; i < chars.Length; i += 2)
                    chars[i] = char.ToLower(chars[i]);
                for (int i = 2; i < chars.Length; i += 2)
                    chars[i] = char.ToUpper(chars[i]);
            }
            if (Char.IsLower(chars[0]))
            {
                for (int i = 2; i < chars.Length; i += 2)
                    chars[i] = char.ToLower(chars[i]);
                for (int i = 1; i < chars.Length; i += 2)
                    chars[i] = char.ToUpper(chars[i]);
            }
            return new string(chars);
            throw new NotImplementedException();
        }

        //Shift letters of input by shiftAmt.Eg.Input: abc,
        //shiftAmt: 3 => def.Input: abc, shiftAmt: -2 => yza
        public string ShiftWord(string input, int shiftAmt)
        {
            char[] chars = input.ToCharArray();
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            for(int i = 0; i < chars.Length; i++)
            {
                int shift = i + shiftAmt;
                if (shift > alphabet.Length)
                    shift -= alphabet.Length;
                if (shift < 0)
                    shift += alphabet.Length;
                chars[i] = alphabet[shift];
            }
            return new string(chars).ToLower();
            throw new NotImplementedException();
        }

        //Return the most common letter in the string. If
        //there is more than one most common letter,
        //return the first occurring of those.
        public char MostCommonLetter(string input)
        {
            char[] chars = input.ToCharArray();


            throw new NotImplementedException();
        }

        //Return the amount of unique characters in the
        //string
        public int AmtOfDifferentChars(string input)
        {
            throw new NotImplementedException();
        }

        //Return the last found index of pattern in input.
        //Return -1 if pattern not found.Eg.Input: abcab,
        //pattern: ab => 3
        public int findPattern(string input, string pattern)
        {
            throw new NotImplementedException();
        }

        //Return the longest pattern shared between
        //input1 and input2.Case-sensitive.Return empty
        //string if no common pattern.Eg input1: abc,
        //input2: dab => ab.input1: abc, input2: xyz =>
        //<emptystring>
        public string findLongestPattern(string input1, string input2)
        {
            throw new NotImplementedException();
        }
    }
}
