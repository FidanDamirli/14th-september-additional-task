namespace String_Array_Class_Intro;
class Program
{
    static void Main(string[] args)
    {
        {
            string reverseSentence = ReverseSentence("Salam necesen");
            Console.WriteLine(reverseSentence);

            Account login = new Account();

            Console.WriteLine("Enter username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            login.Login(username, password);
        }

        #region Task 1
        static string ReverseSentence(string sentence)

        {
            string reversed = "";
            for (int i = 0; i < sentence.Length; i++)
            {
                reversed = sentence[i] + reversed;
            }
            return reversed;
        }
        #endregion

    }
}

