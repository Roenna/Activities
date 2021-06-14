
using Application.Activities;
using Application.Activities.Delete;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        public ActivitiesController(IMediator _mediator) : base(_mediator)
        { }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetAllActivities()
        {
            return await _mediator.Send(new GetAllActivitiesRequest());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await _mediator.Send(new GetActivityDetailRequest() { Id = id });
        }

        [HttpPost]
        public async Task<ActionResult> CreateActivity(Activity activity)
        {
            return Ok(await _mediator.Send(new CreateNewActivityCommand() { Activity = activity }));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> CreateActivity(Guid id, Activity activity)
        {
            activity.Id = id;

            return Ok(await _mediator.Send(new EditActivityCommand() { Activity = activity }));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteActivity(Guid id)
        {
            return Ok(await _mediator.Send(new DeleteActivityCommand() { Id = id }));
        }
    }
}
