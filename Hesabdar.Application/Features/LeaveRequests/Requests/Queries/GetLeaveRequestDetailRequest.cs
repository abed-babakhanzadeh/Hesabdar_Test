using Hesabdar.Application.DTOs.LeaveRequests;
using MediatR;

namespace Hesabdar.Application.Features.LeaveRequests.Requests.Queries
{
	public class GetLeaveRequestDetailRequest : IRequest<LeaveRequestDto>
	{
		public int Id { get; set; }
	}
}
