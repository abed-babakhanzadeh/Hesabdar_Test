namespace Hesabdar.Application.Features.LeaveAllocations.Handlers.Commands
{
	using AutoMapper;
	using Hesabdar.Application.Features.LeaveAllocations.Requests.Commands;
	using Hesabdar.Application.Persistence.Contracts;
	using MediatR;
	using System.Threading;
	using System.Threading.Tasks;

	public class DeleteLeaveAllocationsCommandHandler : IRequestHandler<DeleteLeaveAllocationsCommand>
	{
		private readonly ILeaveAllocationRepository _allocationRepository;
		private readonly IMapper _mapper;

		public DeleteLeaveAllocationsCommandHandler(ILeaveAllocationRepository allocationRepository, IMapper mapper)
		{
			_allocationRepository = allocationRepository;
			_mapper = mapper;
		}
		public async Task<Unit> Handle(DeleteLeaveAllocationsCommand request, CancellationToken cancellationToken)
		{
			var leaveAllocation = await _allocationRepository.Get(request.Id);
			await _allocationRepository.Delete(leaveAllocation.Id);
			return Unit.Value;
		}
	}
}
