using Hesabdar.Application.DTOs.Common;
using System;

namespace Hesabdar.Application.DTOs.LeaveRequests
{
	public class CreateLeaveRequestsDto : BaseDto
	{
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public int LeaveTypeId { get; set; }
		public DateTime DateRequested { get; set; }
		public string RequestComments { get; set; }
	}
}
