using Hesabdar.Application.DTOs.Common;
using Hesabdar.Application.DTOs.LeaveTypes;

namespace Hesabdar.Application.DTOs.LeaveAllocations
{
	public class LeaveAllocationDto : BaseDto
	{
		public int NumberOfDays { get; set; }
		public LeaveTypeDto LeaveType { get; set; }
		public int LeaveTypeId { get; set; }
		public int Priod { get; set; }
	}
}
