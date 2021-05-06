using System;

namespace CreateElizaResponse
{
    class Program
    {
		public static void Main()
		{
			Console.Write("Hello, my name is Eliza. ");
			do
			{
				Console.WriteLine("What do you have to say?");
				string input = Console.ReadLine();
				string response = CreateElizaResponse(input);
				Console.WriteLine(response);

			} while (InputAgain());

		}

		static string CreateElizaResponse(string s)
        {
			Random gen = new Random();
			int numResponse = -1;
			string[] cannedResponses = { "Please go on.", "Tell me more.", "Continue..." };
			string word = "";
			string response = "";
			string[] words = s.Split(); // create an array of strings from a string.  Default delimiter is white space.
			for (int i = 0; i < words.Length; i++)
            {
				word = words[i].ToLower();
				if (word == "my")
                {
					response = $"Tell me more about your {words[i + 1]}.";
                }
				else if (word == "love" || word == "hate")
                {
					response = $"You have strong feelings about that!";
                }
				
			}
			if (response == "")
            {
				numResponse = gen.Next(0, 3);
				response = cannedResponses[numResponse];
			}
			return response;
		}

		static bool InputAgain()
		{
			string answer;
			do
			{
				Console.WriteLine("Would you like to keep discussing? (y/n)?");
				answer = Console.ReadLine();
				answer = answer.ToLower().Substring(0, 1);
			} while (!(answer == "y" || answer == "n"));

			if (answer == "y")
				return true;
			else
				return false;
		}
	}
}
