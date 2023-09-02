namespace DesignPattern.BehaviouralDesignPattern.CommandDesignPattern
{
    public class OnCommand : ICommand
    {
        private readonly IDevice device;

        public OnCommand(IDevice device)
        {
            this.device = device;
        }

        public void Execute()
        {
            this.device.On();
        }
    }
}
