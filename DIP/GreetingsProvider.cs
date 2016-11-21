using System;

namespace SolidTraining.DIP
{
    public class GreetingsProvider
    {
        public string GetGreeting()
        {
            var currentHour = DateTime.Now.Hour;
            if (currentHour < 12) return "Good morning.";
            if (currentHour < 18) return "Good afternoon.";
            return "Good evening.";
        }
    }
}