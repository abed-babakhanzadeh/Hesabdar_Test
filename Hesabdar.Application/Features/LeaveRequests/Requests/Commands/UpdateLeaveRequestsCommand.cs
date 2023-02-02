using Hesabdar.Application.DTOs.LeaveRequests;
using MediatR;

namespace Hesabdar.Application.Features.LeaveRequests.Requests.Commands
{
	public class UpdateLeaveRequestsCommand : IRequest<Unit>
	{
		public int Id { get; set; }
		public LeaveRequestDto UpdateLeaveRequestDto { get; set; }
		public ChangeLeaveRequestsApprovedDto ChangeLeaveRequestsApprovedDto { get; set; }
	}
}
