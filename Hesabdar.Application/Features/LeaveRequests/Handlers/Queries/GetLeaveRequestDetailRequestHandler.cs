using AutoMapper;
using Hesabdar.Application.DTOs.LeaveRequests;
using Hesabdar.Application.Features.LeaveRequests.Requests.Queries;
using Hesabdar.Application.Persistence.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Hesabdar.Application.Features.LeaveRequests.Handlers.Queries
{
	public class GetLeaveRequestDetailRequestHandler : IRequestHandler<GetLeaveRequestDetailRequest, LeaveRequestDto>
	{
		private readonly ILeaveRequestRepository _leaveRequest;
		private readonly IMapper _mapper;

		public GetLeaveRequestDetailRequestHandler(ILeaveRequestRepository leaveRequest, IMapper mapper)
		{
			_leaveRequest = leaveRequest;
			_mapper = mapper;
		}
		//-----------------------------------------------


		public async Task<LeaveRequestDto> Handle(GetLeaveRequestDetailRequest request, CancellationToken cancellationToken)
		{
			var leaveRequest = await _leaveRequest.GetLeaveRequestWithDetails(request.Id);
			return _mapper.Map<LeaveRequestDto>(leaveRequest);
		}
	}
}
