namespace CorePoint.Domain.Entities;

public record NoteColumn : Column
{
    public int NumLines { get; init; }
    public bool IsRichText { get; init; }
}
