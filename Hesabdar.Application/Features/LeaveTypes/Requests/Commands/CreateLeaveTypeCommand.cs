using Hesabdar.Application.DTOs.LeaveTypes;
using MediatR;

namespace Hesabdar.Application.Features.LeaveTypes.Requests.Commands
{
	public class CreateLeaveTypeCommand : IRequest<int>
	{
		public LeaveTypeDto LeaveTypeDto { get; set; }
	}
}
