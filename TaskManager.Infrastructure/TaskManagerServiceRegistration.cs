using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.Contracts.Interface;
using TaskManager.Infrastructure.Services;

namespace TaskManager.Infrastructure
{
    public static class TaskManagerServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddDbContext<TaskManagerDbContext>(options =>
        {
          
            options.EnableSensitiveDataLogging();
    
        });

        services.AddTransient<ITasksService, TaskService>();

      
   


        return services;

    }
}
}
