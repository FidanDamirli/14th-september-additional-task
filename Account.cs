namespace String_Array_Class_Intro
{
	public class Account
	{
		public void Login(string username,string password)
		{
			if (username == "lorem123" && password == "123456*")
				Console.WriteLine("You have successfully logged in");
			else
				Console.WriteLine("Error! Try again");

		}
	}
}

