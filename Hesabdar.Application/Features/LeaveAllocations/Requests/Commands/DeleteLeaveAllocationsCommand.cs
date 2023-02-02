using System;
using System.Collections.Generic;
using System.Text;

namespace Hesabdar.Application.Features.LeaveAllocations.Requests.Commands
{
	using MediatR;

	public class DeleteLeaveAllocationsCommand : IRequest
	{
		public int Id { get; set; }
	}
}
