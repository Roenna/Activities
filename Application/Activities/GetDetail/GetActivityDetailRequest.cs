using Domain;
using MediatR;
using System;

namespace Application.Activities
{
    public class GetActivityDetailRequest : IRequest<Activity>
    {
        public Guid Id { get; set; }
    }
}
