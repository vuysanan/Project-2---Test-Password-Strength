using static System.Console;
using System.Text.RegularExpressions;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            string password, tryAgain;
            
            WriteLine("Test Password Strength \n=======================\n");
            
            do
            {
                password = GetPassword();

                score = TestPasswordStrength(password);

                WriteLine("Password Strength rating out of 5:  " + score);

                tryAgain = TryAgain();
                
            } while (tryAgain == "y" || tryAgain == "yes");
        }

        static string GetPassword()
        {
            Write("Enter a password:  ");
            return ReadLine();
        }
        
        static int TestPasswordStrength(string password)
        {
            int minLength = 10;
            int score = 0;

            if (password.Length >= minLength)
            {
                WriteLine("+1 Has at least 10 characters");
                score++;
            }
            else
            {
                WriteLine("-1 Has less than 10 characters");
            }

            if (Regex.IsMatch(password, "[A-Z]"))
            {
                WriteLine("+1 Has at least one uppercase letter");
                score++;
            }
            else
            {
                WriteLine("-1 Needs at least one uppercase letter");
            }

            if (Regex.IsMatch(password, "[a-z]"))
            {
                WriteLine("+1 Has at least one lowercase letter");
                score++;
            }
            else
            {
                WriteLine("-1 Needs at least one lower case");
            }

            if (Regex.IsMatch(password, "[0-9]"))
            {
                WriteLine("+1 Has at least one number");
                score++;
            }
            else
            {
                WriteLine("-1 Needs at least one number");
            }

            if (Regex.IsMatch(password, "[!@#$%^&*()_+=-?]"))
            {
                WriteLine("+1 Has at least one special character");
                score++;
            }
            else
            {
                WriteLine("-1 Needs at least one special character");
            }
            
            WriteLine();
            
            return score;

        }

        static string TryAgain()
        {
            string again;
            
            Write("\nWould you like to try another password?    ");
            again = ReadLine().ToLower();
            WriteLine();
            
            while (!(again == "y" || again == "yes" || again == "n" || again == "no"))
            {
                Write("Invalid input! Enter Yes or No \nWould you like to try another password?     ");
                again = ReadLine().ToLower();
                WriteLine();
            }
            return again;
        }
    }
}