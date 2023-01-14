using MediatorDesignPattern.Interfaces;

namespace MediatorDesignPattern.Classes
{
    public class ConcreteUser : User
    {
        public ConcreteUser(FacebookGroupMediator mediator, string name) : base(mediator, name)
        {
        }
        public override void Receive(string message)
        {
            Console.WriteLine(_name + ": Received Message: " + message);
        }
        public override void Send(string message)
        {
            Console.WriteLine(_name + ": Sending Message: " + message + "\n");
            _mediator.SendMessage(message, this);
        }
    }
}
