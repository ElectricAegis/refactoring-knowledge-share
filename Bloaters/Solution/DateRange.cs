namespace Bloaters.Solution;

public record DateRange(DateTime Start, DateTime End)
{
    public bool InRange(DateTime date)
    {
        return Start <= date && date <= End;
    }
}