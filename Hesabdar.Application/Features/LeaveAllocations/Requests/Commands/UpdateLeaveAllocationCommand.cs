using Hesabdar.Application.DTOs.LeaveAllocations;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hesabdar.Application.Features.LeaveAllocations.Requests.Commands
{
	public class UpdateLeaveAllocationCommand : IRequest<Unit>
	{
		public LeaveAllocationDto LeaveAllocationDto { get; set; }
	}
}
