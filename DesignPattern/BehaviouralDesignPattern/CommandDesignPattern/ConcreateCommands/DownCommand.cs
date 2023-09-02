namespace DesignPattern.BehaviouralDesignPattern.CommandDesignPattern
{
    internal class DownCommand : ICommand
    {
        private readonly IDevice device;

        public DownCommand(IDevice device)
        {
            this.device = device;
        }

        public void Execute()
        {
            this.device.Down();
        }
    }
}
