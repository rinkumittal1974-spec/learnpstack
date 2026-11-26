namespace PCInsuranceDomain.Models;

public enum DomainCategory
{
    BusinessEntity,
    LineOfBusiness,
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
    public string CategoryLabel => Category switch
    {
        DomainCategory.BusinessEntity => "Business Entity",
        DomainCategory.LineOfBusiness => "Line of Business",
        _ => "Key Stakeholder"
    };

    public string ResponsibilitiesHeading => Category switch
    {
        DomainCategory.BusinessEntity => "What it does",
        DomainCategory.LineOfBusiness => "What it covers",
        _ => "What they do"
    };
}
