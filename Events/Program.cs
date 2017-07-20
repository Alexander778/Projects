using System;

namespace EventsExample
{
	class Program
	{
		static void Main(string[] args)
		{
			//создаем инстанс нашего месенджера
			var myMessanger = new Messanger();
			//назначаем обработчик события OnMessageSend, в нашем случае это приватный статик метод нашей программы
			//который просто будет логировать отправленные сообщения на екран
			myMessanger.OnMessageSend += LogMessage;

			//тестируем
			myMessanger.SendMessage("Dima", "Sasha", "Hi!");
			myMessanger.SendMessage("Sahsa", "Dima", "Hello! How are you?");
			myMessanger.SendMessage("Vasya", "All", "Hi All!");
			Console.ReadKey();
		}

        private static void LogMessage(object sender, messageEventArgs e)
		{
			Console.WriteLine($"{e.SenderName} says \"{e.Message}\" to {e.ReceiverName}");
		}
	}
}