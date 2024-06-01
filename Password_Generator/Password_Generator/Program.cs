using System;

namespace Password_Generator
{
    class Program
    {
        public void Main(string[] arg)
        {
            bool flag = true;
            string input = "";

            while(flag)
            {
                Console.WriteLine("Do you wish to Generate a new password: ");
                
                if(input == "y" || input == "Y")
                {
                    input = PersonalGenerator();
                }
                else
                {
                    flag = false;
                }
            }
        }

        private string PersonalGenerator()
        {

            return "hello";
        }
    }
    
}
