namespace Hesabdar.Application.Features.LeaveRequests.Handlers.Commands
{
	using AutoMapper;
	using Hesabdar.Application.Features.LeaveRequests.Requests.Commands;
	using Hesabdar.Application.Persistence.Contracts;
	using MediatR;
	using System.Threading;
	using System.Threading.Tasks;

	public class DeleteLeaveRequestCommandHandler : IRequestHandler<DeleteLeaveRequestCommand>
	{
		private readonly ILeaveRequestRepository _requestRepository;
		private readonly IMapper _mapper;

		public DeleteLeaveRequestCommandHandler(ILeaveRequestRepository requestRepository, IMapper mapper)
		{
			_requestRepository = requestRepository;
			_mapper = mapper;
		}

		public async Task<Unit> Handle(DeleteLeaveRequestCommand request, CancellationToken cancellationToken)
		{
			var leaveRequest = await _requestRepository.Get(request.Id);
			await _requestRepository.Delete(leaveRequest.Id);
			return Unit.Value;
		}
	}
}
