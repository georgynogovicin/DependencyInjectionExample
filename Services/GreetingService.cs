namespace DependencyInjectionExample.Services
{
    public class GreetingService : IGreetingService
    {
        public string GetGreeting()
        {
            return "Hello from Dependency Injection!";
        }
    }
}
