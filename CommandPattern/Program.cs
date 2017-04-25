namespace CommandPattern
{
    using System;

    class Program
    {
        static void Main(string[] arguments)
        {
            var argument = arguments.Length > 0 ? arguments[0].ToUpper() : null;

            ISwitchable lamp = new Light();
            
            ICommand switchClose = new SwitchOnCommand(lamp);
            ICommand switchOpen = new SwitchOffCommand(lamp);
            
            var @switch = new Switch(switchClose, switchOpen);

            switch (argument)
            {
                case "ON":
                    @switch.On();
                    break;
                case "OFF":
                    @switch.Off();
                    break;
                default:
                    Console.WriteLine("Argument \"ON\" or \"OFF\" is required.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
