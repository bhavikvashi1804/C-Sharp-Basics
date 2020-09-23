using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp
{
	public interface INotification
	{
		//members
		void showNotification();
		string getDate();
	}
	//derived class must implement all the methods
	public class Notification : INotification
	{
		//member variables
		private string sender;
		private string message;
		private string date;

		//constructor
		public Notification()
		{
			this.sender ="Bhavik";
			this.message ="Hello";
			this.date ="18 - 04 - 1998";
		}
		public Notification(string sender, string message, string date)
		{
			this.sender = sender;
			this.message = message;
			this.date = date;
		}

		//methods
		//interface methods must be public 
		public void showNotification()
		{
			Console.WriteLine("Message {0} by {1} @ {2}",message,sender,date);
		}
		public string getDate()
		{
			return (this.date);
		}
	}

}
