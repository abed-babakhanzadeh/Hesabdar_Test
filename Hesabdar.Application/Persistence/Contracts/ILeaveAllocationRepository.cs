using Hesabdar.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hesabdar.Application.Persistence.Contracts
{
	public interface ILeaveAllocationRepository:IGenericRepository<LeaveAllocation>
	{
		Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails();
		Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id);
	}
}
