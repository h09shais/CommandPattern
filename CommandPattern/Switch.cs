namespace CommandPattern
{
    public class Switch
    {
        ICommand on;

        ICommand off;

        public Switch(ICommand on, ICommand off)
        {
            this.on = on;
            this.off = off;
        }

        public void On()
        {
            this.on.Execute();
        }

        public void Off()
        {
            this.off.Execute();
        }
    }
}
