using AutoMapper;
using Hesabdar.Application.Features.LeaveAllocations.Requests.Commands;
using Hesabdar.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hesabdar.Application.Features.LeaveAllocations.Handlers.Commands
{
	public class UpdateLeaveAllocationCommandHandler : IRequestHandler<UpdateLeaveAllocationCommand, Unit>
	{
		private readonly ILeaveAllocationRepository _leaveAllocation;
		private readonly IMapper _mapper;

		public UpdateLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocation, IMapper mapper)
		{
			_leaveAllocation = leaveAllocation;
			_mapper = mapper;
		}



		public async Task<Unit> Handle(UpdateLeaveAllocationCommand request, CancellationToken cancellationToken)
		{
			var leaveAllocation = await _leaveAllocation.Get(request.LeaveAllocationDto.Id);
			_mapper.Map(request.LeaveAllocationDto, leaveAllocation);
			await _leaveAllocation.Update(leaveAllocation);
			return Unit.Value;
		}
	}
}
