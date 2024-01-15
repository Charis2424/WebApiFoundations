using AutoMapper;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using RepoInterfaces;
using Service.Interfaces;
using Service.Interfaces.ModelsServiceInterfaces;
using Services.ModelsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IAuthenticationService> _authenticationService;
        public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper, UserManager<User> userManager,IConfiguration configuration)
        {
            _authenticationService = new Lazy<IAuthenticationService>(() => new
            AuthenticationService(mapper, userManager, configuration));

        }
        public IAuthenticationService AuthenticationService => _authenticationService.Value;
    }
}
