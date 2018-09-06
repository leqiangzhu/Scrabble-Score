using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ScrabbleScore.Models;
using System;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class WordTest
  {
    [TestMethod]
    public void GetWord_ReturnUserWord_String()
    {
      //Arrange
      string word = "hello";
      Word newWord = new Word(word);
      //Act
      string result = newWord.GetWord();
      //Assert
      Assert.AreEqual("hello", result);
    }
    [TestMethod]
    public void StringToChar_ReturnStringToChar_Char()
    {
      //Arrange
      string userWord = "he";
      Word newWord = new Word(userWord);
      //Act
      char[] result = newWord.StringToChar(userWord);
      //Assert
      Assert.AreEqual('e', result[1]);
    }
    [TestMethod]
      public void CharValue_GiveCharacterANumericalValue_Int()
    {
      //Arrange
      string userWord = "he";
      Word newWord = new Word(userWord);
      char[] newResult = newWord.StringToChar(userWord);
      //Act
      int result = newWord.CharValue(newResult[0]);

      //Assert
      Assert.AreEqual(4, result);
    }

    // [TestMethod]
    // public void MakeWordValue_AddCharValues_Int()
    // {
    //   //Arrange
    //   string userWord="hello";

      //Act

      //Assert
    }
    // [TestMethod]
    // public void ReturnValue_ReturnScrabbleWordValue_Int()
    // {
    //   //Arrange
    //   //Act
    //   //Assert
    // }
  }
}
