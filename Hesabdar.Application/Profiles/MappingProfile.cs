using AutoMapper;
using Hesabdar.Application.DTOs.LeaveAllocations;
using Hesabdar.Application.DTOs.LeaveRequests;
using Hesabdar.Application.DTOs.LeaveTypes;
using Hesabdar.Domain;

namespace Hesabdar.Application.Profiles
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
			CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
			CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
			CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
		}
	}
}
