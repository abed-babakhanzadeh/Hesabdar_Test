namespace Hesabdar.Application.Features.LeaveRequests.Requests.Commands
{
	using MediatR;

	public class DeleteLeaveRequestCommand : IRequest
	{
		public int Id { get; set; }
	}
}
