﻿using Hesabdar.Domain.Common;

namespace Hesabdar.Domain
{
	public class LeaveAllocation : BaseDomainEntity
	{
		public int NumberOfDays { get; set; }
		public LeaveType LeaveType { get; set; }
		public int LeaveTypeId { get; set; }
		public int Priod { get; set; }
	}
}
