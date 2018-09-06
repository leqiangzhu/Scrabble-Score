using System.Collections.Generic;
using System;

namespace ScrabbleScore.Models
{
  public class Word
  {
    private string _word;
    Dictionary<char, int> letterValue = new Dictionary<char, int>()
    {
      {'a', 1}, {'e', 1}, {'i',1}, {'o',1}, {'u',1}, {'l',1}, {'n',1}, {'r',1}, {'s', 1}, {'t', 1},
      {'d', 2}, {'g', 2},
      {'b', 3}, {'c', 3}, {'m', 3}, {'p', 3},
      {'f', 4}, {'h', 4}, {'v', 4}, {'w', 4}, {'y', 4},
      {'k', 5},
      {'j', 8}, {'x', 8},
      {'q', 10},{'z', 10}
    };
    public Word (string word)
    {
      _word = word;
    }
    public void SetWord(string input)
    {
      _word = input;
    }
    public string GetWord()
    {
      return _word;
    }
    public char[] StringToChar(string input)
    {
      char[] newArray= input.ToCharArray();
      return newArray;
    }
    public int CharValue(char input)
    {
      int value = letterValue[input];
      return value;
    }

    public int MakeWordValue(string input)
    {
      int number=0;
      Word wo =new Word(input);
      char[] array= wo.StringToChar(input);
      for (int i=0;i<array.Length;i++ )
      {
        number += wo.CharValue(array[i]);
      }
      return  number;
    }


  }
  public class Program
  {
    public static void Main()
    {
      int score=0;
      Console.WriteLine("input a word!");
      string inputUser=Console.ReadLine();
      Word woo =new Word(inputUser);
      score =  woo.MakeWordValue(inputUser);

      // Word wo =new Word(inputUser);
      // int number=0;
      // char[] inputUserArray =wo.StringToChar(inputUser);
      //
      // for (int i=0;i<inputUserArray.Length;i++ )
      // {
      //   number += wo.CharValue(inputUserArray[i]);
      // }

      Console.WriteLine("the score you get is :"+score);




    }
  }
}
