namespace CommandPattern
{
    public class SwitchOffCommand : ICommand
    {
        private ISwitchable switchable;

        public SwitchOffCommand(ISwitchable switchable)
        {
            this.switchable = switchable;
        }
        public void Execute()
        {
            this.switchable.PowerOff();
        }
    }
}
