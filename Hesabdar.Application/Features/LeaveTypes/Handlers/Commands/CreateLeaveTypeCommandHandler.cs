using AutoMapper;
using Hesabdar.Application.DTOs.LeaveTypes.Validators;
using Hesabdar.Application.Features.LeaveTypes.Requests.Commands;
using Hesabdar.Application.Persistence.Contracts;
using Hesabdar.Domain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Hesabdar.Application.Features.LeaveTypes.Handlers.Commands
{
	using System;

	public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
	{
		private readonly ILeaveTypeRepository _leaveType;
		private readonly IMapper _mapper;

		public CreateLeaveTypeCommandHandler(ILeaveTypeRepository leaveType, IMapper mapper)
		{
			_leaveType = leaveType;
			_mapper = mapper;
		}


		public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
		{
			var validator = new CreateLeaveTypeDtoValidator();
			var result = await validator.ValidateAsync(request.LeaveTypeDto);
			if (result.IsValid==false)
			{
				throw new Exception();
			}

			var leaveType = _mapper.Map<LeaveType>(request.LeaveTypeDto);
			leaveType = await _leaveType.Add(leaveType);
			return leaveType.Id;
		}
	}
}
