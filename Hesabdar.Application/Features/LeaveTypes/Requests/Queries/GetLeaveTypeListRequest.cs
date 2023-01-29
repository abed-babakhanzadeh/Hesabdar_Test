using Hesabdar.Application.DTOs.LeaveTypes;
using MediatR;
using System.Collections.Generic;

namespace Hesabdar.Application.Features.LeaveTypes.Requests.Queries
{
	public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDto>>
	{

	}
}
