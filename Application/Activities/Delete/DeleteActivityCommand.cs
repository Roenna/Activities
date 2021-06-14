using MediatR;
using System;

namespace Application.Activities.Delete
{
    public class DeleteActivityCommand : IRequest
    {
        public Guid Id { get; set;}
    }
}
