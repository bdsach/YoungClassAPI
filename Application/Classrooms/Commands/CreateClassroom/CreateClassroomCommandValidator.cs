using FluentValidation;

namespace Application.Classrooms.Commands.CreateClassroom;

public class CreateClassroomCommandValidator : AbstractValidator<CreateClassroomCommand>
{
    public CreateClassroomCommandValidator()
    {
        RuleFor(dto => dto.Name)
            .Length(3, 100);
    }
}