﻿using Hesabdar.Application.DTOs.Common;
using System;

namespace Hesabdar.Application.DTOs.LeaveRequests
{
	public class UpdateLeaveRequestDto : BaseDto
	{
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public int LeaveTypeId { get; set; }
		public string RequestComments { get; set; }
		public bool Cancelled { get; set; }

	}
}
