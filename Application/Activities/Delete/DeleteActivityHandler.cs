using AutoMapper;
using MediatR;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Activities.Delete
{
    public class DeleteActivityHandler : AsyncRequestHandler<DeleteActivityCommand>
    {
        private readonly DataContext _context;

        public DeleteActivityHandler(DataContext context)
        {
            _context = context;
        }

        protected override async Task Handle(DeleteActivityCommand request, CancellationToken cancellationToken)
        {
            var activity = await _context.Activities.FindAsync(request.Id);

            _context.Remove(activity);

            await _context.SaveChangesAsync();
        }
    }
}
