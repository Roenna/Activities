using Domain;
using MediatR;

namespace Application.Activities
{
    public class CreateNewActivityCommand : IRequest
    {
        public Activity Activity { get; set; }
    }
}
