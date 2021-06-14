using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Activities
{
    public class GetAllActivitiesHandler : IRequestHandler<GetAllActivitiesRequest, List<Activity>>
    {
        private DataContext _context;

        public GetAllActivitiesHandler(DataContext dataContext)
        {
            _context = dataContext;
        }

        public async Task<List<Activity>> Handle(GetAllActivitiesRequest request, CancellationToken cancellationToken)
        {
            return await _context.Activities.ToListAsync();
        }
    }
}
