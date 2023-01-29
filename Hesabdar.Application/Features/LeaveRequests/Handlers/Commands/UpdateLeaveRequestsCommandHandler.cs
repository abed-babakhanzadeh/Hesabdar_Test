using AutoMapper;
using Hesabdar.Application.Features.LeaveRequests.Requests.Commands;
using Hesabdar.Application.Persistence.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Hesabdar.Application.Features.LeaveRequests.Handlers.Commands
{
	public class UpdateLeaveRequestsCommandHandler : IRequestHandler<UpdateLeaveRequestsCommand, Unit>
	{
		private readonly ILeaveRequestRepository _leaveRequest;
		private readonly IMapper _mapper;

		public UpdateLeaveRequestsCommandHandler(ILeaveRequestRepository leaveRequest, IMapper mapper)
		{
			_leaveRequest = leaveRequest;
			_mapper = mapper;
		}



		public async Task<Unit> Handle(UpdateLeaveRequestsCommand request, CancellationToken cancellationToken)
		{
			var leaveRequest = await _leaveRequest.Get(request.Id);
			if (request.LeaveRequestDto != null)
			{
				_mapper.Map(request.LeaveRequestDto, leaveRequest);
				await _leaveRequest.Update(leaveRequest);
			}
			else if (request.ChangeLeaveRequestsApprovedDto != null)
			{
				//_mapper.Map(request.ChangeLeaveRequestsApprovedDto, leaveRequest);
				await _leaveRequest.ChangeApprovedStatuse(leaveRequest, request.ChangeLeaveRequestsApprovedDto.Approved);
			}
			//var leaveRequest = await _leaveRequest.Get(request.LeaveRequestDto.Id);

			return Unit.Value;
		}
	}
}
