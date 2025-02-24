using Microsoft.AspNetCore.Mvc;
using TaskList.Application.UseCases;
using TaskList.Communication.Requests;

namespace TaskList.API.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {

    [HttpPost]
    [ProducesResponseType(typeof(CreateTaskUseCase), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody]RequestTaskJson request)
    {
        var useCase = new CreateTaskUseCase();
        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]

    public IActionResult Update([FromRoute] int id, [FromBody] RequestTaskJson request)
    {
        var useCase = new UpdateTaskUseCase();

        useCase.Execute(id, request);

        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(ListAllTasksUseCase), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]

    public IActionResult ListAll()
    {
        var useCase = new ListAllTasksUseCase();
        var response = useCase.Execute();

        if (response.Tasks.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ListAllTasksUseCase), StatusCodes.Status200OK)]

    public IActionResult ListById([FromRoute]int id)
    {
        var useCase = new ListsTasksByIdUseCase();
        var response = useCase.Execute(id);

        return Ok(response);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]

    public IActionResult Delete(int id)
    {
        var useCase = new DeleteTaskUseCase();

        useCase.Execute(id);
        
        return NoContent();
    }





}

