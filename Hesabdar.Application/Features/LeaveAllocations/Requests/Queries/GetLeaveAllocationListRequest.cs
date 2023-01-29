using Hesabdar.Application.DTOs.LeaveAllocations;
using MediatR;
using System.Collections.Generic;

namespace Hesabdar.Application.Features.LeaveAllocations.Requests.Queries
{
	public class GetLeaveAllocationListRequest : IRequest<List<LeaveAllocationDto>>
	{

	}
}
