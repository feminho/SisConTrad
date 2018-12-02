using System;
using Microsoft.Extensions.DependencyInjection;
using SisConTrad.Core.Interfaces.Repository;
using SisConTrad.Core.Interfaces.Services;
using SisConTrad.Core.Services;
using SisConTrad.Infrastructure.Data;
using SisConTrad.Infrastructure.Repository;

namespace SisConTrad.IOC
{
    public class DependencyInjectionResolver
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Repositories
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<ITranslationRepository, TranslationRepository>();
            services.AddScoped<IMessageRepository, MessageRepository>();

            //Application
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<ITranslationService, TranslationService>();
            services.AddScoped<IMessageService, MessageService>();

            //context
            services.AddScoped<SisConTradContex>();
        }
    }
}
