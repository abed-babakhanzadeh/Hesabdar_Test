using Hesabdar.Application.DTOs.LeaveRequests;
using MediatR;

namespace Hesabdar.Application.Features.LeaveRequests.Requests.Commands
{
	public class CreateLeaveRequestCommand : IRequest<int>
	{
		public LeaveRequestDto LeaveRequestDto { get; set; }
	}
}
