namespace PCInsuranceDomain.Models;

public enum DomainCategory
{
    BusinessEntity,
    Stakeholder
}

public record RealWorldExample(string Name, string Note);

public record DomainItem(
    string Slug,
    string Name,
    DomainCategory Category,
    string Icon,
    string Accent,
    string Tagline,
    string Overview,
    IReadOnlyList<string> Responsibilities,
    IReadOnlyList<string> KeyTerms,
    IReadOnlyList<string> RelatedSlugs)
{
    public string CategoryLabel => Category == DomainCategory.BusinessEntity
        ? "Business Entity"
        : "Key Stakeholder";
}
