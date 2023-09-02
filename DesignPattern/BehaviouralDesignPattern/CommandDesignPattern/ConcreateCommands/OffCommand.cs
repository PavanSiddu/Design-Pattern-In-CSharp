namespace DesignPattern.BehaviouralDesignPattern.CommandDesignPattern
{
    internal class OffCommand : ICommand
    {
        private readonly IDevice device;

        public OffCommand(IDevice device)
        {
            this.device = device;
        }

        public void Execute()
        {
            this.device.Off();
        }
    }
}
