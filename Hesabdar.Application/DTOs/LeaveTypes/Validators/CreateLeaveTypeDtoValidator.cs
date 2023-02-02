namespace Hesabdar.Application.DTOs.LeaveTypes.Validators
{
	using FluentValidation;

	public class CreateLeaveTypeDtoValidator : AbstractValidator<CreateLeaveTypeDto>
	{
		public CreateLeaveTypeDtoValidator()
		{
			RuleFor(p => p.Name).NotEmpty().WithMessage("{PropertyName} is required")
				.NotNull().MaximumLength(50)
				.WithMessage("{PropertyName} Max is 50");

			RuleFor(p => p.DefaultDay).NotEmpty().WithMessage("{PropertyName} is required")
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0")
				.LessThan(100).WithMessage("{PropertyName} must be less than 100");
		}

	}
}
