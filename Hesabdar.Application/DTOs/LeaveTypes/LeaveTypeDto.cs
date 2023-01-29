using Hesabdar.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hesabdar.Application.DTOs.LeaveTypes
{
    public class LeaveTypeDto : BaseDto
    {
        public string Name { get; set; }
        public int DefaultDay { get; set; }
    }
}
