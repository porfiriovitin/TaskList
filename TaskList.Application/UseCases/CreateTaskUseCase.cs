using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskList.Communication.Requests;
using TaskList.Communication.Responses;

namespace TaskList.Application.UseCases
{
    public class CreateTaskUseCase
    {
        public ResponseCreateTaskJson Execute (RequestTaskJson request)
        {
            return new ResponseCreateTaskJson
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description
             
            };
        }
    }
}
