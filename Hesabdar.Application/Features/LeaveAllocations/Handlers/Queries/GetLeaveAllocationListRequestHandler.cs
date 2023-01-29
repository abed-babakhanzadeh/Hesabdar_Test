using AutoMapper;
using Hesabdar.Application.DTOs.LeaveAllocations;
using Hesabdar.Application.Features.LeaveAllocations.Requests.Queries;
using Hesabdar.Application.Persistence.Contracts;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Hesabdar.Application.Features.LeaveAllocations.Handlers.Queries
{
	public class GetLeaveAllocationListRequestHandler : IRequestHandler<GetLeaveAllocationListRequest, List<LeaveAllocationDto>>
	{
		private readonly ILeaveAllocationRepository _leaveAllocation;
		private readonly IMapper _mapper;

		public GetLeaveAllocationListRequestHandler(ILeaveAllocationRepository leaveAllocation, IMapper mapper)
		{
			_leaveAllocation = leaveAllocation;
			_mapper = mapper;
		}
		//----------------------------------------------------------


		public async Task<List<LeaveAllocationDto>> Handle(GetLeaveAllocationListRequest request, CancellationToken cancellationToken)
		{
			var leaveAllocationList = await _leaveAllocation.GetAll();
			return _mapper.Map<List<LeaveAllocationDto>>(leaveAllocationList);
		}
	}
}
