using AutoMapper;
using Hesabdar.Application.DTOs.LeaveAllocations;
using Hesabdar.Application.Features.LeaveAllocations.Requests.Queries;
using Hesabdar.Application.Persistence.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Hesabdar.Application.Features.LeaveAllocations.Handlers.Queries
{
	public class GetLeaveAllocationDetailRequestHandler : IRequestHandler<GetLeaveAllocationDetailRequest, LeaveAllocationDto>
	{
		private readonly ILeaveAllocationRepository _leaveAllocation;
		private readonly IMapper _mapper;

		public GetLeaveAllocationDetailRequestHandler(ILeaveAllocationRepository leaveAllocation, IMapper mapper)
		{
			_leaveAllocation = leaveAllocation;
			_mapper = mapper;
		}


		public async Task<LeaveAllocationDto> Handle(GetLeaveAllocationDetailRequest request, CancellationToken cancellationToken)
		{
			var leaveAllocation = await _leaveAllocation.GetLeaveAllocationWithDetails(request.Id);
			return _mapper.Map<LeaveAllocationDto>(leaveAllocation);
		}
	}
}
