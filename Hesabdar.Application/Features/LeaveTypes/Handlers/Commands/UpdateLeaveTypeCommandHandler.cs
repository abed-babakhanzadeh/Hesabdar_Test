using AutoMapper;
using Hesabdar.Application.Features.LeaveTypes.Requests.Commands;
using Hesabdar.Application.Persistence.Contracts;
using Hesabdar.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hesabdar.Application.Features.LeaveTypes.Handlers.Commands
{
	public class UpdateLeaveTypeCommandHandler : IRequestHandler<UpdateLeaveTypeCommand, Unit>
	{
		private readonly ILeaveTypeRepository _leaveType;
		private readonly IMapper _mapper;

		public UpdateLeaveTypeCommandHandler(ILeaveTypeRepository leaveType, IMapper mapper)
		{
			_leaveType = leaveType;
			_mapper = mapper;
		}



		public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
		{
			var leaveType = await _leaveType.Get(request.LeaveTypeDto.Id);
			_mapper.Map(request.LeaveTypeDto, leaveType);
			await _leaveType.Update(leaveType);
			return Unit.Value;
			
		}
	}
}
