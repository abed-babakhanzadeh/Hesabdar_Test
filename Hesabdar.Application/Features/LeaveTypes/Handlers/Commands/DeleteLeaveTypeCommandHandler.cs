namespace Hesabdar.Application.Features.LeaveTypes.Handlers.Commands
{
	using AutoMapper;
	using Hesabdar.Application.Features.LeaveTypes.Requests.Commands;
	using Hesabdar.Application.Persistence.Contracts;
	using MediatR;
	using System.Threading;
	using System.Threading.Tasks;

	public class DeleteLeaveTypeCommandHandler : IRequestHandler<DeleteLeaveTypeCommand>

	{
		private readonly ILeaveTypeRepository _leaveType;
		private readonly IMapper _mapper;

		public DeleteLeaveTypeCommandHandler(ILeaveTypeRepository leaveType, IMapper mapper)
		{
			_leaveType = leaveType;
			_mapper = mapper;
		}
		public async Task<Unit> Handle(DeleteLeaveTypeCommand request, CancellationToken cancellationToken)
		{
			var leavetype = await _leaveType.Get(request.Id);
			await _leaveType.Delete(request.Id);
			return Unit.Value;
		}
	}
}
