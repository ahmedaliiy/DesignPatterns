using MediatorDesignPattern.Interfaces;

namespace MediatorDesignPattern.Classes
{
    public abstract class User
    {
        protected FacebookGroupMediator _mediator;
        protected string _name;

        public User(FacebookGroupMediator mediator, string name)
        {
            _mediator = mediator;
            _name = name;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
