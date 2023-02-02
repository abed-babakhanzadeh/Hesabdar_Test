namespace WinFormsApp1.Forms
{
	using Hesabdar.Application.DTOs.LeaveRequests;
	using Hesabdar.Application.Features.LeaveRequests.Requests.Commands;

	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			var aas = new CreateLeaveRequestCommand();
			aas.LeaveRequestDto = new LeaveRequestDto() { RequestComments = "kkk" };
			MessageBox.Show(aas.LeaveRequestDto.RequestComments);
		}
	}
}
