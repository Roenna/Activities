using AutoMapper;
using Domain;
using MediatR;
using Persistence;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Activities
{
    public class EditActivityHandler : AsyncRequestHandler<EditActivityCommand>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public EditActivityHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        protected override async Task Handle(EditActivityCommand request, CancellationToken cancellationToken)
        {
            var activity = await _context.Activities.FindAsync(request.Activity.Id);

            _mapper.Map(request.Activity, activity);

            await _context.SaveChangesAsync();
        }
    }
}
