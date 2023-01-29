using Hesabdar.Application.DTOs.Common;
using Hesabdar.Application.DTOs.LeaveTypes;
using System;

namespace Hesabdar.Application.DTOs.LeaveRequests
{
	public class LeaveRequestListDto : BaseDto
	{
		public LeaveTypeDto LeaveType { get; set; }
		public DateTime DateRequested { get; set; }
		public bool? Approved { get; set; }

	}
}
