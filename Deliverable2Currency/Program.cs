using System;
using System.Text;

namespace Deliverable2Currency
{
  class Program
  {
    static void Main(string[] args)
    {
      // Welcome user.
      Console.WriteLine("Welcome. What's your name?");

      //Read username.
      string username = Console.ReadLine();

    // Brings user back to start if mistake occurred when entering a number.
    again:
      // Prompt the user to input 3 numbers.
      Console.WriteLine("Hello " + username + ", " + "please enter three numbers each followed by the Enter key.");

      // Checking if user entered a number.

        // Read a line of text and convert to float.
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        string c = Console.ReadLine();

      while (true)
      {
        String abc = a + b + c;

        // Use method for checking for a number.
        if (!IsAllDigits(abc))
        {
          Console.WriteLine("Hey! That isn't a number. Would you like to try again? Y or N");
          {
            string ans = Console.ReadLine();
            switch (ans.ToUpper())
            {
              case "Y": goto again;

              //End Program
              case "N": goto stop;
            }
          }
        }

        else
        {
          break;
        }
      }
          
          float numa = float.Parse(a);
          float numb = float.Parse(b);
          float numc = float.Parse(c);

          // Calculate the sum and convert to decimal.
          decimal sum = (Convert.ToDecimal(numa) + Convert.ToDecimal(numb) + Convert.ToDecimal(numc));

          // Output the sum.
          Console.WriteLine("Sum = {0}", sum);

          // Calculate the average.
          decimal avg = (Convert.ToDecimal(numa + numb + numc) / 3);

          // Output the average.
          Console.WriteLine("Average = {0}", avg);

          // Calculate the min.
          decimal min = (Convert.ToDecimal((numa < numb) ? (numa < numc ? numa : numc) : (numb < numc ? numb : numc)));

          // Output the min.
          Console.WriteLine("Minimum = {0}", min);

          // Calculate the max.
          decimal max = (Convert.ToDecimal((numa > numb) ? (numa > numc ? numa : numc) : (numb > numc ? numb : numc)));

          // Output the max.
          Console.WriteLine("Maximum = {0}", max);

          Console.WriteLine();
          Console.WriteLine();

          // Output USD currency.
          Console.WriteLine(string.Format("US: {0:C}", sum));

          // Output Japanese currency.
          Console.WriteLine(String.Format(System.Globalization.CultureInfo.CreateSpecificCulture("sv-SE"), "Swedish: {0:C}", sum));

          // Output Swedish currency.
          Console.WriteLine(String.Format(System.Globalization.CultureInfo.CreateSpecificCulture("ja-JP"), "Japanese: {0:C}", sum));

          Console.OutputEncoding = Encoding.UTF8;

          // Output Thai currency.
          Console.WriteLine(String.Format(System.Globalization.CultureInfo.CreateSpecificCulture("th-TH"), "Thai: {0:C}", sum));

          Console.WriteLine();

    stop:
      //Wait for user to acknowledge the results.
      Console.ReadKey();
      Console.WriteLine("Press Enter to End Program");


        // IsAllDigits Method
      bool IsAllDigits(string raw)
        {
          // First get rid of any benign characters at either end of string.
          // If there is nothing left, no number.
          string s = raw.Trim();
          if (s.Length == 0) return false;

          // Loop through the string.
          for (int index = 0; index < s.Length; index++)
          {
            // A nondigit indicates that the string is not a number.
            if (Char.IsDigit(s[index]) == false) return false;
          }
          // No nondigit is found; it's okay!
          return true;
        }
      }
    }
  }
  