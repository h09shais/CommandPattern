namespace CommandPattern
{
    public class SwitchOnCommand : ICommand
    {
        private ISwitchable switchable;

        public SwitchOnCommand(ISwitchable switchable)
        {
            this.switchable = switchable;
        }
        public void Execute()
        {
            this.switchable.PowerOn();
        }
    }
}
