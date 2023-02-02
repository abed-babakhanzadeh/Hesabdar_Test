using Hesabdar.Application.Features.LeaveTypes.Requests.Queries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Forms
{
	using AutoMapper;

	using Hesabdar.Application.DTOs.LeaveRequests;
	using Hesabdar.Application.Features.LeaveRequests.Handlers.Commands;
	using Hesabdar.Application.Features.LeaveRequests.Requests.Commands;

	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			var aas =new CreateLeaveRequestCommand();
			aas.LeaveRequestDto = new LeaveRequestDto() { RequestComments = "kkk" };
			MessageBox.Show(aas.LeaveRequestDto.RequestComments);
		}
	}
}
