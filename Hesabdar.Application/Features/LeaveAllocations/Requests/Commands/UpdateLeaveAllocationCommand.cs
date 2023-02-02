using Hesabdar.Application.DTOs.LeaveAllocations;
using MediatR;

namespace Hesabdar.Application.Features.LeaveAllocations.Requests.Commands
{
	public class UpdateLeaveAllocationCommand : IRequest<Unit>
	{
		public LeaveAllocationDto LeaveAllocationDto { get; set; }
	}
}
