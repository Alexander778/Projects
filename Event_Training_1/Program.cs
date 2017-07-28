using System;
using namespace Event_Training_1;
{



    public class MainClass
    {
        public static void Main(string[] args)
        {
            var myButton = new Button();
            myButton.OnClick += _OnClickButton();


            myButton.Click("Yes!");
            Console.ReadKey();
        }

        private static void _OnClickButton(object sender, ClickEventsArgs)
        {
            Console.WriteLine($"{e.NameOfButton}");


        }
    }
}
