namespace DesignPattern.BehaviouralDesignPattern.CommandDesignPattern
{
    public class Invoker
    {
        private readonly ICommand onCommand;
        private readonly ICommand offCommand;
        private readonly ICommand upCommand;
        private readonly ICommand downCommand;

        public Invoker(ICommand onCommand, ICommand offCommand, ICommand upCommand, ICommand downCommand)
        {
            this.onCommand = onCommand;
            this.offCommand = offCommand;
            this.upCommand = upCommand;
            this.downCommand = downCommand;
        }
        public void ClickOn()
        {
            this.onCommand.Execute();
        }

        public void ClickOff()
        {
            this.offCommand.Execute();
        }

        public void ClickUp()
        {
            this.upCommand.Execute();
        }

        public void ClickDown()
        {
            this.downCommand.Execute();
        }
    }
}
