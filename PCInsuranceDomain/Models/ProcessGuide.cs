namespace PCInsuranceDomain.Models;

public record ProcessStep(
    string Phase,
    string Title,
    string Actor,
    string Timeframe,
    string Summary,
    IReadOnlyList<string> Details);

public record ProcessDiagram(
    string Title,
    string Caption,
    string MermaidSource);

public record ProcessGuide(
    string Intro,
    IReadOnlyList<ProcessStep> Steps,
    IReadOnlyList<ProcessDiagram> Diagrams);
