using System;

namespace Longest_Common_Prefix
{
  class Program
  {
    static void Main(string[] args)
    {
      Program p = new Program();
      string[] strs = new string[] { "flow", "fly", "flower" };
      Console.WriteLine(p.LongestCommonPrefix(strs));
    }

    public string LongestCommonPrefix(string[] strs)
    {
      if (strs == null || strs.Length == 0) return "";
      string prefix = strs[0];
      for (int i = 1; i < strs.Length; i++)
      {
        while (!strs[i].StartsWith(prefix))
        {
          prefix = prefix.Substring(0, prefix.Length - 1);
        }
      }

      return prefix;
    }
  }
}
