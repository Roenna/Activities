using MediatR;
using Persistence;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Activities
{
    public class CreateNewActivityHandler : AsyncRequestHandler<CreateNewActivityCommand>
    {
        private readonly DataContext _context;

        public CreateNewActivityHandler(DataContext context)
        {
            _context = context;
        }

        protected override async Task Handle(CreateNewActivityCommand request, CancellationToken cancellationToken)
        {
            _context.Activities.Add(request.Activity);

            await _context.SaveChangesAsync();
        }
    }
}
