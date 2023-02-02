using Hesabdar.Application.DTOs.Common;

namespace Hesabdar.Application.DTOs.LeaveTypes
{
	public class LeaveTypeDto : BaseDto
	{
		public string Name { get; set; }
		public int DefaultDay { get; set; }
	}
}
