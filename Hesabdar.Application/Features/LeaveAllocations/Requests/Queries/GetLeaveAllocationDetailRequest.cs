using Hesabdar.Application.DTOs.LeaveAllocations;
using MediatR;

namespace Hesabdar.Application.Features.LeaveAllocations.Requests.Queries
{
	public class GetLeaveAllocationDetailRequest : IRequest<LeaveAllocationDto>
	{
		public int Id { get; set; }
	}
}
