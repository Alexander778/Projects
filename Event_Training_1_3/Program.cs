using System;
using Events_Training_1_1;

class MainClass
{
	static void Main(string[] args)
	{
		var myButton = new Button();
		myButton.OnClick += ShowName;

        myButton.ClickOnTheButton("Alex");
		Console.ReadKey();
	}

	private static void ShowName(object sender, ClickEventsArgs e)
	{
		Console.WriteLine($"{e.NameOfButton}");
	}
}

