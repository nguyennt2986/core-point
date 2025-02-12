using CorePoint.Domain.Enums;

namespace CorePoint.Domain.Entities;

public record MultiChoiceColumn : ChoiceColumn
{
    public new ChoiceFormat Format => ChoiceFormat.CheckBox;
}
