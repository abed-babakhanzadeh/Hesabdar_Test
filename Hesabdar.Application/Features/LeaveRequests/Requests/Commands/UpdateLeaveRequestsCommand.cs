using Hesabdar.Application.DTOs.LeaveRequests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hesabdar.Application.Features.LeaveRequests.Requests.Commands
{
	public class UpdateLeaveRequestsCommand : IRequest<Unit>
	{
		public int Id { get; set; }
		public LeaveRequestDto LeaveRequestDto { get; set; }
		public ChangeLeaveRequestsApprovedDto ChangeLeaveRequestsApprovedDto { get; set; }
	}
}
