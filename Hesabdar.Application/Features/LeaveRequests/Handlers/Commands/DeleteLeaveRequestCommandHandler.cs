using System;
using System.Collections.Generic;
using System.Text;

namespace Hesabdar.Application.Features.LeaveRequests.Handlers.Commands
{
	using Hesabdar.Application.Features.LeaveRequests.Requests.Commands;
	using MediatR;
	using System.Threading;
	using System.Threading.Tasks;

	using AutoMapper;

	using Hesabdar.Application.Persistence.Contracts;

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
