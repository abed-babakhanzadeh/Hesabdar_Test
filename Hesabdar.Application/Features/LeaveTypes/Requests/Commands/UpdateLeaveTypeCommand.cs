using Hesabdar.Application.DTOs.LeaveTypes;
using MediatR;

namespace Hesabdar.Application.Features.LeaveTypes.Requests.Commands
{
	public class UpdateLeaveTypeCommand : IRequest<Unit>
	{
		public LeaveTypeDto LeaveTypeDto { get; set; }
	}
}
