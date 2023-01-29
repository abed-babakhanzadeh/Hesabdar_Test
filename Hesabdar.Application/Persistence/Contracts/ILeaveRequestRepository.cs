using Hesabdar.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hesabdar.Application.Persistence.Contracts
{
	public interface ILeaveRequestRepository:IGenericRepository<LeaveRequest>
	{
		Task<LeaveRequest> GetLeaveRequestWithDetails(int id);
		Task<List<LeaveRequest>> GetLeaveRequestsWithDetails();
		Task ChangeApprovedStatuse(LeaveRequest leaveRequest, bool? approvedStatuse);
	}
}
