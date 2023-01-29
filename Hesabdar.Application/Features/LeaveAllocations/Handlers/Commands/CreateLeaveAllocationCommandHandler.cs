using AutoMapper;
using Hesabdar.Application.Features.LeaveAllocations.Requests.Commands;
using Hesabdar.Application.Persistence.Contracts;
using Hesabdar.Domain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Hesabdar.Application.Features.LeaveAllocations.Handlers.Commands
{
	public class CreateLeaveAllocationCommandHandler : IRequestHandler<CreateLeaveAllocationCommand, int>
	{
		private readonly ILeaveAllocationRepository _leaveAllocation;
		private readonly IMapper _mapper;

		public CreateLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocation, IMapper mapper)
		{
			_leaveAllocation = leaveAllocation;
			_mapper = mapper;
		}



		public async Task<int> Handle(CreateLeaveAllocationCommand request, CancellationToken cancellationToken)
		{
			var leaveAllocation = _mapper.Map<LeaveAllocation>(request.LeaveAllocationDto);
			leaveAllocation = await _leaveAllocation.Add(leaveAllocation);
			return leaveAllocation.Id;
		}
	}
}
