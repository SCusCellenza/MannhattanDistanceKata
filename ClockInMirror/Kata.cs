
namespace ClockInMirror
{
    public class Kata
    {
        public static string WhatIsTheTime(string time)
        {
            var inputList = time.Split(":");

            int mirorHours = 12 - int.Parse(inputList[0]);
            int mirorMinutes = (60 - int.Parse(inputList[1])) % 60;

            if (mirorMinutes != 0) {
                mirorHours--;
            }
            if (mirorHours < 1) { 
                mirorHours += 12; 
            }

            return $"{mirorHours:00}:{mirorMinutes:00}";
        }
    }
}