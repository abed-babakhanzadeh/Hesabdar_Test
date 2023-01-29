using Hesabdar.Application.DTOs.LeaveTypes;
using MediatR;

namespace Hesabdar.Application.Features.LeaveTypes.Requests.Queries
{
	public class GetLeaveTypeDetailRequest : IRequest<LeaveTypeDto>
	{
		public int Id { get; set; }
	}
}
