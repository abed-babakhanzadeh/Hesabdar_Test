using Hesabdar.Application.DTOs.Common;

namespace Hesabdar.Application.DTOs.LeaveAllocations
{
	public class CreateLeaveAllocationDto : BaseDto
	{
		public int NumberOfDays { get; set; }
		public int LeaveTypeId { get; set; }
		public int Priod { get; set; }
	}
}
