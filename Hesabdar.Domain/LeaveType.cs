using Hesabdar.Domain.Common;

namespace Hesabdar.Domain
{
	public class LeaveType : BaseDomainEntity
	{
		public string Name { get; set; }
		public int DefaultDay { get; set; }

	}
}
