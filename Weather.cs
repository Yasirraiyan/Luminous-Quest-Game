namespace Hospital_Management_System
{
    public class Weather
    {
        public string CurrentWeather { get; private set; }
        public string TimeOfDay { get; private set; }
        public int Temperature { get; private set; } // Temperature in Celsius

        public Weather()
        {
            CurrentWeather = "Clear";
            TimeOfDay = "Day";
            Temperature = 25; // Default temperature
        }

        public void UpdateWeather()
        {
            Random rnd = new Random();
            int weatherCondition = rnd.Next(0, 5); // 0: Clear, 1: Rainy, 2: Stormy, 3: Foggy, 4: Snowy
            int timeCondition = rnd.Next(0, 2); // 0: Day, 1: Night
            int tempVariation = rnd.Next(-5, 6); // Temperature variation between -5 to +5

            if (timeCondition == 0)
            {
                TimeOfDay = "Day";
                Console.WriteLine("Time of day: Day");
            }
            else
            {
                TimeOfDay = "Night";
                Console.WriteLine("Time of day: Night");
            }

            if (weatherCondition == 0)
            {
                CurrentWeather = "Clear";
                Console.WriteLine("Weather: Clear");
            }
            else if (weatherCondition == 1)
            {
                CurrentWeather = "Rainy";
                Console.WriteLine("Weather: Rainy");
                Temperature -= 3;
            }
            else if (weatherCondition == 2)
            {
                CurrentWeather = "Stormy";
                Console.WriteLine("Weather: Stormy");
                Temperature -= 5;
            }
            else if (weatherCondition == 3)
            {
                CurrentWeather = "Foggy";
                Console.WriteLine("Weather: Foggy");
            }
            else if (weatherCondition == 4)
            {
                CurrentWeather = "Snowy";
                Console.WriteLine("Weather: Snowy");
                Temperature -= 7;
            }
            else
            {
                Console.WriteLine("Unknown weather condition.");
            }

            Temperature += tempVariation;
            Console.WriteLine($"Temperature: {Temperature}°C");

            ApplyWeatherEffects();
        }

        private void ApplyWeatherEffects()
        {
            if (CurrentWeather == "Clear")
            {
                if (TimeOfDay == "Day")
                {
                    Console.WriteLine("It's a clear day. Visibility is high.");
                }
                else
                {
                    Console.WriteLine("It's a clear night. Stars are visible.");
                }
            }
            else if (CurrentWeather == "Rainy")
            {
                Console.WriteLine("It's raining. Roads might be slippery.");
                if (Temperature <= 0)
                {
                    Console.WriteLine("Beware of icy roads.");
                }
            }
            else if (CurrentWeather == "Stormy")
            {
                Console.WriteLine("A storm is raging. It's dangerous to be outside.");
                if (Temperature <= 0)
                {
                    Console.WriteLine("Expect snowstorm conditions.");
                }
            }
            else if (CurrentWeather == "Foggy")
            {
                Console.WriteLine("Visibility is low due to fog.");
            }
            else if (CurrentWeather == "Snowy")
            {
                Console.WriteLine("Snow is falling. Roads might be blocked.");
                if (Temperature <= -5)
                {
                    Console.WriteLine("Extreme cold conditions. Stay indoors if possible.");
                }
            }
        }

        public void DisplayWeather()
        {
            Console.WriteLine($"Current Weather: {CurrentWeather}");
            Console.WriteLine($"Time of Day: {TimeOfDay}");
            Console.WriteLine($"Temperature: {Temperature}°C");
        }
    }

}
