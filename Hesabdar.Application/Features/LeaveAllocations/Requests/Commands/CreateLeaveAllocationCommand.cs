using Hesabdar.Application.DTOs.LeaveAllocations;
using MediatR;

namespace Hesabdar.Application.Features.LeaveAllocations.Requests.Commands
{
	public class CreateLeaveAllocationCommand : IRequest<int>
	{
		public LeaveAllocationDto LeaveAllocationDto { get; set; }
	}
}
