using ProxyDesignPattern.Interfaces;

namespace ProxyDesignPattern.Services
{
    public class SharedFolder : ISharedFolder
    {
        public void PerformRWOperations()
            => Console.WriteLine("Performing Read Write operation on the Shared Folder");
    }
}
