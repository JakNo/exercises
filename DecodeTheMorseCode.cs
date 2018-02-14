// https://www.codewars.com/kata/54b724efac3d5402db00065e

using System.Text.RegularExpressions;
class MorseCodeDecoder
{
	public static string Decode(string morseCode)
	{
    string message = "";
    foreach (string word in Regex.Split(morseCode, "   "))    // If there are 3 spaces between chars, it's a new word
    {
      foreach (string letter in word.Split(' '))
        message += MorseCode.Get(letter);                     // Decoding single letter in word and adding it to message

      message += " ";                                         // Adding space between words in message
    }
    return message.Trim();
	}
}