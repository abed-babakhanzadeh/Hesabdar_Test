using Hesabdar.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hesabdar.Application.DTOs.LeaveRequests
{
	public class ChangeLeaveRequestsApprovedDto : BaseDto
	{
		public bool? Approved { get; set; }

	}
}
