using MediatorDesignPattern.Classes;

namespace MediatorDesignPattern.Interfaces
{
    public interface FacebookGroupMediator
    {
        void SendMessage(string msg, User user);
        void RegisterUser(User user);
    }
}
