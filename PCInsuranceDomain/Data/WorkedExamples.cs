using PCInsuranceDomain.Models;

namespace PCInsuranceDomain.Data;

public static class WorkedExamples
{
    static CalculationLine L(string label, string value) => new(label, value);

    static readonly Dictionary<string, IReadOnlyList<WorkedExample>> BySlug = new()
    {
        ["insurance-math"] = new[]
        {
            new WorkedExample(
                "Written vs. earned premium",
                "Earned premium = written premium × (months of coverage provided ÷ months in the term)",
                "A homeowner buys a 12-month policy on April 1 for $1,200. The insurer closes its books on December 31.",
                new[]
                {
                    L("Written premium (billed on April 1)", "$1,200"),
                    L("Months of coverage provided by December 31", "9 of 12"),
                    L("Earned premium: $1,200 × 9 ÷ 12", "$900"),
                    L("Unearned premium: $1,200 − $900", "$300")
                },
                "By year end the insurer has earned $900 and holds a $300 unearned premium reserve.",
                "The insurer can't count the $300 as income yet. It still owes three months of coverage, and it would refund that amount if the policy were cancelled."),

            new WorkedExample(
                "Incurred losses",
                "Incurred losses = losses paid + change in case reserves + change in IBNR reserves",
                "During the year an insurer pays $50 million in claims. Its case reserves on open claims rise by $8 million. Its estimate of claims that have happened but are not yet reported (IBNR) rises by $4 million.",
                new[]
                {
                    L("Losses paid", "$50M"),
                    L("Increase in case reserves", "+ $8M"),
                    L("Increase in IBNR reserves", "+ $4M"),
                    L("Incurred losses", "$62M")
                },
                "Incurred losses for the year are $62 million, not the $50 million paid.",
                "Paid losses lag behind reality. Incurred losses count the cost of every claim that belongs to the year, including what will be paid later."),

            new WorkedExample(
                "Loss ratio, expense ratio, and combined ratio",
                "Combined ratio = (incurred losses + loss adjustment expense + underwriting expense) ÷ earned premium",
                "The same insurer earned $100 million in premium. It spent $8 million handling claims (adjusters, lawyers, inspections) and $28 million on commissions, salaries, and premium taxes.",
                new[]
                {
                    L("Loss and LAE ratio: ($62M + $8M) ÷ $100M", "70%"),
                    L("Expense ratio: $28M ÷ $100M", "28%"),
                    L("Combined ratio: 70% + 28%", "98%"),
                    L("Underwriting profit: $100M − $62M − $8M − $28M", "$2M")
                },
                "The combined ratio is 98%, so the insurer kept 2 cents of underwriting profit per premium dollar.",
                "Below 100% means underwriting made money. Above 100% means the insurer paid out more in claims and costs than it earned in premium. Published statutory figures divide expenses by written premium instead of earned, so the numbers differ slightly."),

            new WorkedExample(
                "Making money with a combined ratio over 100%",
                "Operating income = underwriting result + investment income",
                "A bad hail year pushes the combined ratio to 103% on $100 million of earned premium. The insurer holds $250 million of invested assets, mostly premium and reserves waiting to be paid out as claims (the float). Those assets earn 3%.",
                new[]
                {
                    L("Underwriting loss: $100M × (100% − 103%)", "− $3.0M"),
                    L("Investment income: $250M × 3%", "+ $7.5M"),
                    L("Operating income before tax", "$4.5M")
                },
                "The insurer still makes $4.5 million because investment income covers the underwriting loss.",
                "Lines with slow-paying claims, such as liability and workers' comp, hold money longer and earn more on it. That is why they can run combined ratios above 100% and still be profitable. Fast-paying property lines have far less room."),

            new WorkedExample(
                "Loss development and IBNR",
                "Ultimate losses = reported losses × age-to-ultimate factor; IBNR = ultimate − reported",
                "For claims from accident year 2024, reported losses (paid plus case reserves) are $40 million at 12 months. History shows this line keeps growing: ×1.15 from 12 to 24 months, ×1.05 from 24 to 36 months, and ×1.035 after that.",
                new[]
                {
                    L("Age-to-ultimate factor: 1.15 × 1.05 × 1.035", "1.25"),
                    L("Ultimate losses: $40M × 1.25", "$50M"),
                    L("IBNR reserve: $50M − $40M", "$10M")
                },
                "The actuary expects the year to cost $50 million in total and books $10 million of IBNR.",
                "Claims keep coming in and growing for years after an accident year ends. A loss development triangle shows that pattern, and the factors drawn from it turn today's numbers into an estimate of the final cost."),

            new WorkedExample(
                "Home claim: ACV, RCV, and recoverable depreciation",
                "ACV = replacement cost − depreciation; first payment = ACV − deductible",
                "A hailstorm ruins a 10-year-old roof that should last 25 years. A new roof costs $20,000. The policy pays replacement cost and has a $2,000 deductible.",
                new[]
                {
                    L("Replacement cost value (RCV)", "$20,000"),
                    L("Depreciation: 10 ÷ 25 × $20,000", "− $8,000"),
                    L("Actual cash value (ACV)", "$12,000"),
                    L("First payment: $12,000 − $2,000 deductible", "$10,000"),
                    L("Recoverable depreciation, paid after the roof is replaced", "$8,000"),
                    L("Total paid by the insurer", "$18,000")
                },
                "The homeowner gets $10,000 now and $8,000 more once the roof is replaced. They pay the $2,000 deductible.",
                "Holding back depreciation until repairs are done makes sure the money goes into the home. If the homeowner never replaces the roof, the insurer pays only the ACV."),

            new WorkedExample(
                "Commercial property coinsurance penalty",
                "Payment = (insurance carried ÷ insurance required) × loss − deductible",
                "A building is worth $1,000,000. The policy has an 80% coinsurance clause, so the owner must insure at least $800,000. The owner bought only $600,000 of coverage. A fire causes a $200,000 loss, and the deductible is $5,000.",
                new[]
                {
                    L("Insurance required: 80% × $1,000,000", "$800,000"),
                    L("Ratio carried to required: $600,000 ÷ $800,000", "75%"),
                    L("Covered share of the loss: 75% × $200,000", "$150,000"),
                    L("Payment after the $5,000 deductible", "$145,000")
                },
                "The insurer pays $145,000. The owner absorbs $55,000 even though the loss is well under the policy limit.",
                "Coinsurance pushes owners to insure close to full value. Underinsuring saves premium, but every partial loss is then paid in proportion.")
        }
    };

    public static IReadOnlyList<WorkedExample> For(string slug) =>
        BySlug.TryGetValue(slug, out var list) ? list : Array.Empty<WorkedExample>();
}
