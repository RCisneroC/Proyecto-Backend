using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.Contracts.Interface;
using TaskManager.Application.Features.Command.Tasks.CreateCommand;
using TaskManager.Application.Features.Command.Tasks.DeleteCommand;
using TaskManager.Application.Features.Command.Tasks.UpdateCommand;
using TaskManager.Application.Features.Command.WorkSituation.CreateCommand;
using TaskManager.Application.Features.Queries.Tasks.GetTasksFilter;
using TaskManager.Application.Models;
using TaskManager.Domain.Model;

namespace TaskManager.Infrastructure.Services
{
    public class TaskService : ITasksService
    {
        private readonly TaskManagerDbContext _context;
        private readonly ILogger<ITasksService> _logger;



        public TaskService( TaskManagerDbContext context,
            ILogger<TaskService> logger,
            CreateTasksCommandValidators validator
            )
        {
            _logger = logger;
            _context = context;
          

        }

        public async Task<ResponseServices<TaskM>> CreateTasksAsync(CreateTasksCommand request)
        {

            ResponseServices<TaskM> response = new();
            try
            {

          

                var exist = await _context.Task.Where(f => f.Title == request.Title).FirstOrDefaultAsync();

                if (exist == null)
                {


                    TaskM row = new TaskM()
                    {
                        Title = request.Title,
                        Description = request.Description,
                        Completed = request.Completed,
                        CreatedBy = "Ricardo cisnero",
                        CreatedAt = DateTime.UtcNow,

                    };

                    var result = await _context.Task.AddAsync(row);
                    await _context.SaveChangesAsync();

                    response.Message = "Tasks creado con éxito";
                    response.StatusCode = 200;
                    response.IsError = false;
                   

                }
                else
                {


                    response.Message = "title del Taskso ya existe ";
                    response.StatusCode = 400;
                    response.IsError = true;


                }
            }
            catch (Exception ex)
            {
                response.StatusCode = 500;
                response.IsError = true;
                response.Message = "ha ocurrido un error mientras guardaba Tasks ";
                

            }

            return response;
        }

     

        public async Task<ResponseServices<TaskM>> UpdateTasksAsync(UpdateTasksCommand request)
        {
            ResponseServices<TaskM> response = new();

            try
            {
                var exist = await _context.Task.Where(f => f.Id == request.Id).FirstOrDefaultAsync();

                if (exist != null)
                {
                    exist.Description = request.Description;
                    exist.Title = request.Title;
                    exist.Completed = request.Completed;

                    exist.UpdatedAt = DateTime.UtcNow;

                    var result = _context.Task.Update(exist);
                    await _context.SaveChangesAsync();

                    response.Message = "Tasks actualizado con éxito";
                    response.StatusCode = 200;
                    response.IsError = false;

                }
                else
                {
                    response.Message = "el id no existe ";
                    response.StatusCode = 400;
                    response.IsError = true;
                }
            }
            catch (Exception e)
            {


                response.Message = e.Message;
                response.StatusCode = 400;
                response.IsError = true;

                _logger.LogError(e, e.Message);
            }

            return response;
        }



  
        public async Task<ResponseServices<TaskM>> DeleteTasksAsync(DeleteTasksCommand request)
        {

            ResponseServices<TaskM> response = new();
            try
            {
                var exist = await _context.Task.Where(f => f.Id == request.Id).FirstOrDefaultAsync();

                if (exist != null)
                {
                    var result = _context.Task.Remove(exist);
                    await _context.SaveChangesAsync();

                    response.Message = "Tasks eliminado con éxito";
                    response.StatusCode = 200;
                    response.IsError = false;


                }
                else
                {
                    response.Message = "id no existe ";
                    response.StatusCode = 400;
                    response.IsError = true;
                }
            }
            catch (Exception e)
            {

                response.Message = e.Message;
                response.StatusCode = 500;
                response.IsError = true;

                _logger.LogError(e, e.Message);
            }

            return response;
        }

        public async Task<ResponseServices<TaskM>> GetTasksAsync(GetTasksQuery request)
        {

            var result = new ResponseServices<TaskM>();

            try
            {
                var query = await _context.Task.ToListAsync();

                result.Data = query;
                result.IsError = false;
                result.StatusCode = 200;


                return result;

            }
            catch (Exception e)
            {

                result.IsError = true;
                result.StatusCode = 400;
                result.Message = e.Message;

                _logger.LogError(e, e.Message);

            }
            return result;
        }
    }
}