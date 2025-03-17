using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Application.Models
{
    public class ResponseServices<T>
    {
        public  string Message { get; set; } = string.Empty;
        public bool IsError { get; set; } = false;
        public int? StatusCode { get; set; }

        public List<T> Data { get; set; }

        public List<ValidationError> Errors { get; set; }

    }
 
    public class ValidationError
    {
        public string Field { get; set; }
        public string ErrorMessage { get; set; }
    }

}
