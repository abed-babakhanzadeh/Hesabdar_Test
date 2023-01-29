using AutoMapper;
using Hesabdar.Application.DTOs.LeaveTypes;
using Hesabdar.Application.Features.LeaveTypes.Requests.Queries;
using Hesabdar.Application.Persistence.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Hesabdar.Application.Features.LeaveTypes.Handlers.Queries
{
	public class GetLeaveTypeDetailRequestHandler : IRequestHandler<GetLeaveTypeDetailRequest, LeaveTypeDto>
	{
		/// <summary>
		/// سازنده
		/// </summary>
		private readonly ILeaveTypeRepository _leaveType;
		private readonly IMapper _mapper;

		public GetLeaveTypeDetailRequestHandler(ILeaveTypeRepository leaveType, IMapper mapper)
		{
			_leaveType = leaveType;
			_mapper = mapper;
		}
		//----------------------------------------------------


		public async Task<LeaveTypeDto> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
		{
			var leaveType = await _leaveType.Get(request.Id);
			return _mapper.Map<LeaveTypeDto>(leaveType);
		}
	}
}
