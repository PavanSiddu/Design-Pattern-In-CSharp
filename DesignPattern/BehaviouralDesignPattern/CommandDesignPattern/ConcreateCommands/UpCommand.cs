namespace DesignPattern.BehaviouralDesignPattern.CommandDesignPattern
{
    internal class UpCommand : ICommand
    {
        private readonly IDevice device;

        public UpCommand(IDevice device)
        {
            this.device = device;
        }

        public void Execute()
        {
            this.device.Up();
        }
    }
}
