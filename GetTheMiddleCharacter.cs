// https://www.codewars.com/kata/56747fd5cb988479af000028

public class Kata
{
  public static string GetMiddle(string s)
  {
    if (s.Length%2 == 0) { return s.Substring((s.Length-1)/2, 2); }
    else { return s.Substring((s.Length-1)/2, 1); }
  }
}