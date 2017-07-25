using System;

namespace Event_Training_2
{
    public class Button
    {
        public delegate void ClickButton(string N,string D);//делегат
        public event ClickButton OnClick;//событие
        public string ShowNameOfButton(string Name,string Date)//метод
        {
            string result = Name + Date;
            if(OnClick!=null) //проверка
            {
                OnClick(Name,Date);
            }
            return result ;
        }
    }




    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 10;i++) //цикл
            {
                Button button = new Button();
             
                button.OnClick += ShowInfoButton; //подписка на событие
                button.ShowNameOfButton("Button"+i, "25.07.2017");

            }
        }
        public static void ShowInfoButton(string Name,string Date) //обработчик
        {
            Console.WriteLine("{0} {1} is clicked",Date,Name);
        }

    }
}
