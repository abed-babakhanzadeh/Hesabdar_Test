using AutoMapper;
using Hesabdar.Application.Features.LeaveRequests.Requests.Commands;
using Hesabdar.Application.Persistence.Contracts;
using Hesabdar.Domain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Hesabdar.Application.Features.LeaveRequests.Handlers.Commands
{
	public class CreateLeaveRequestCommandHandler : IRequestHandler<CreateLeaveRequestCommand, int>
	{
		private readonly ILeaveRequestRepository _leaveRequest;
		private readonly IMapper _mapper;

		public CreateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequest, IMapper mapper)
		{
			_leaveRequest = leaveRequest;
			_mapper = mapper;
		}


		public async Task<int> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
		{
			var leaveRequest = _mapper.Map<LeaveRequest>(request.LeaveRequestDto);
			leaveRequest = await _leaveRequest.Add(leaveRequest);
			return leaveRequest.Id;
		}
	}
}
