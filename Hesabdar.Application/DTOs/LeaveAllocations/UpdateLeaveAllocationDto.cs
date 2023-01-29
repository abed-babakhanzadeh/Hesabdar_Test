using Hesabdar.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hesabdar.Application.DTOs.LeaveAllocations
{
	public class UpdateLeaveAllocationDto : BaseDto
	{
		public int NumberOfDays { get; set; }
		public int LeaveTypeId { get; set; }
		public int Priod { get; set; }
	}
}
