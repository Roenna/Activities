using Domain;
using MediatR;
using Persistence;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Activities
{
    public class GetActivityDetailHandler : IRequestHandler<GetActivityDetailRequest, Activity>
    {
        private DataContext _context;

        public GetActivityDetailHandler(DataContext context)
        {
            _context = context;
        }

        public async Task<Activity> Handle(GetActivityDetailRequest request, CancellationToken cancellationToken)
        {
            return await _context.Activities.FindAsync(request.Id);
        }
    }
}
