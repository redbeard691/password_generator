using System;

namespace Password_Generator
{
    class Program
    {
        public static void Main(string[] arg)
        {
            bool flag = true;
            string input = "";
            bool alph = false;
            bool nums = false;
            bool symbols = false;
            int passwordLength = 0;

            while(flag)
            {
                // Reseting values for loop.
                alph = false;
                nums = false;
                symbols = false;
                passwordLength = 0;
                

                Console.Write("Do you wish to Generate a new password: ");
                input = Console.ReadLine();
                
                if(input == "y" || input == "Y")
                {
                    Console.Write("Enter length of Password you want: ");
                    passwordLength = int.Parse(Console.ReadLine());

                    if (passwordLength > 0)
                    {
                        Console.Write("Do you want letters in your password (y/n): ");
                        input = Console.ReadLine();
                        if (input == "y" || input == "Y")
                        {
                            alph = true;
                        }

                        Console.Write("Do you want numbers in your password (y/n): ");
                        input = Console.ReadLine();
                        if (input == "y" || input == "Y")
                        {
                            nums = true;
                        }

                        Console.Write("Do you want symbols in your password (y/n): ");
                        input = Console.ReadLine();
                        if (input == "y" || input == "Y")
                        {
                            symbols = true;
                        }

                        if (alph == true || nums == true || symbols == true)
                        {
                            input = PersonalGenerator(alph, nums, symbols, passwordLength);

                            Console.WriteLine("Your new password is: " + input);
                            Console.WriteLine("Press any key to continue....");
                            Console.ReadKey(); // code waits for any input to conitue.
                            
                        }
                        else
                        {
                            Console.WriteLine("Please select yes for at least one ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter a number larger than 0");
                    }
                }
                else
                {
                    flag = false;
                }

                input = "";
            }
        }

        private static string PersonalGenerator(bool alph, bool nums, bool symb, int passwordLength)
        {
            List<char> theList = new List<char>();
            string newPassword = "";
            var random = new Random();

            if (alph)
            {   
                for ( char c = 'a'; c <= 'z'; c++)
                {
                    theList.Add(c);
                }

                for ( char c = 'A'; c <= 'Z'; c++)
                {
                    theList.Add(c);
                }
            }

            if(nums)
            {
                List<char> numList = new() { '0','1', '2','3','4','5','6','7','8','9'};
                theList.AddRange(numList);
            }

            if(symb)
            {
                List<char> symboList = new() { '!', '?', '@', '#', '$', '%', '&' };
                theList.AddRange(symboList);
            }
            
            for ( int i = 0; i < passwordLength; i++)
            {
                newPassword += theList[random.Next(theList.Count)];
            }

            return newPassword;
        }
    }
    
}
