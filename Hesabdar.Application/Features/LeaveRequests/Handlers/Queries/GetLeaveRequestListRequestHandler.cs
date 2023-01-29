using AutoMapper;
using Hesabdar.Application.DTOs.LeaveRequests;
using Hesabdar.Application.Features.LeaveRequests.Requests.Queries;
using Hesabdar.Application.Persistence.Contracts;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Hesabdar.Application.Features.LeaveRequests.Handlers.Queries
{
	public class GetLeaveRequestListRequestHandler : IRequestHandler<GetLeaveRequestListRequest, List<LeaveRequestListDto>>
	{
		private readonly ILeaveRequestRepository _leaveRequest;
		private readonly IMapper _mapper;

		public GetLeaveRequestListRequestHandler(ILeaveRequestRepository leaveRequest, IMapper mapper)
		{
			_leaveRequest = leaveRequest;
			_mapper = mapper;
		}
		//-----------------------------------------------------------


		public async Task<List<LeaveRequestListDto>> Handle(GetLeaveRequestListRequest request, CancellationToken cancellationToken)
		{
			var leaveRequest = await _leaveRequest.GetLeaveRequestsWithDetails();
			return _mapper.Map<List<LeaveRequestListDto>>(leaveRequest);
		}
	}
}
