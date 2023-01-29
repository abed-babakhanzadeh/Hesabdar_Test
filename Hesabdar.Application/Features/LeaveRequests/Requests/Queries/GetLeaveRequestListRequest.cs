using Hesabdar.Application.DTOs.LeaveRequests;
using MediatR;
using System.Collections.Generic;

namespace Hesabdar.Application.Features.LeaveRequests.Requests.Queries
{
	public class GetLeaveRequestListRequest : IRequest<List<LeaveRequestListDto>>
	{

	}
}
