namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            if (ForDongu(11)) {
                Console.WriteLine("correct");
            }
            else
            {
                Console.WriteLine("not prime");
            }


        }

        private static bool ForDongu(int number)
        {

            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if(number%i == 0)
                {
                    result = false;
                    break;
                }
              


            }
            return result;
           
        }


    }
}

