using AutoMapper;
using Hesabdar.Application.DTOs.LeaveTypes;
using Hesabdar.Application.Features.LeaveTypes.Requests.Queries;
using Hesabdar.Application.Persistence.Contracts;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Hesabdar.Application.Features.LeaveTypes.Handlers.Queries
{
	public class GetLeaveTypeListRequestHandler : IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDto>>
	{
		/// <summary>
		/// سازنده
		/// </summary>
		private readonly ILeaveTypeRepository _leaveTypeRepository;
		private readonly IMapper _mapper;

		public GetLeaveTypeListRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
		{
			_leaveTypeRepository = leaveTypeRepository;
			_mapper = mapper;
		}

		//-------------------------------

		public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
		{
			var leaveTypeList = await _leaveTypeRepository.GetAll();
			return _mapper.Map<List<LeaveTypeDto>>(leaveTypeList);
		}
	}
}
