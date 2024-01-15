
using Service.Interfaces.ModelsServiceInterfaces;

namespace Service.Interfaces
{
    public interface IServiceManager
    {
        IAuthenticationService AuthenticationService { get; }
    }
}
