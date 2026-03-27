namespace WeatherApp
{
    //public delegate void TemperatureChangeHandler(string message);

    public class TemperatureChangeEventArgs : EventArgs
    {
        public int Temperature { get; }
        public TemperatureChangeEventArgs(int temperature)
        {
            Temperature = temperature;
        }

    }

    public class TemperatureMonitor 
    {
        public event EventHandler<TemperatureChangeEventArgs> TemperatureChanged;
        //public event TemperatureChangeHandler OnTemperatureChanged;

        private int _temperature;
        public int Temperature { get { return _temperature; }

            set
            {
                if (_temperature != value)
                {
                    _temperature = value;
                    OnTemperatureChanged(new TemperatureChangeEventArgs(value));
                }
            }
        }

        protected void OnTemperatureChanged(TemperatureChangeEventArgs e)
        {
            TemperatureChanged?.Invoke(this, e);
        }
    }

    public class TemperatureAlert
    {
        public void GetTemperature(object sender, TemperatureChangeEventArgs e)
        {
            Console.WriteLine("Message Received: " + e.Temperature + " Sender is: " + sender);
        }
    }


    public class TemperatureCoolingAlert
    {
        public void GetTemperature(object sender, TemperatureChangeEventArgs e)
        {
            Console.WriteLine("Message Received: " + e.Temperature + " Sender is: " + sender);
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureAlert subscriber = new TemperatureAlert();
            TemperatureCoolingAlert coolingAlert = new TemperatureCoolingAlert();
            monitor.TemperatureChanged += subscriber.GetTemperature;
            monitor.TemperatureChanged += coolingAlert.GetTemperature;
            monitor.Temperature = 25;
            Console.WriteLine("Set the temperature");
            monitor.Temperature = int.Parse(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
