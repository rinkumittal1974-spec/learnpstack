namespace PCInsuranceDomain.Models;

public record CalculationLine(string Label, string Value);

public record WorkedExample(
    string Title,
    string Formula,
    string Scenario,
    IReadOnlyList<CalculationLine> Lines,
    string Answer,
    string Takeaway);
