using PCInsuranceDomain.Models;
using static PCInsuranceDomain.Models.DomainCategory;

namespace PCInsuranceDomain.Data;

public static class DomainCatalog
{
    public static readonly IReadOnlyList<DomainItem> All = new List<DomainItem>
    {
        // ---------- Business entities ----------
        new("policy", "Policy", BusinessEntity, "📄",
            "The contract that defines what is insured and on what terms.",
            "A policy is the legally binding contract between an insurer and a policyholder. It records who is insured, what property or liability is covered, the period of coverage, the limits and deductibles, and the premium. In P&C insurance, most policies run for a fixed term, commonly six or twelve months, and are renewed or re-underwritten at the end of that term.",
            new[]
            {
                "Identifies the named insured, the insured property or activity, and the policy period.",
                "States the coverages, limits (maximum payout), and deductibles (the amount the insured pays first).",
                "Is changed over its life through endorsements and is renewed, cancelled, or non-renewed at term end."
            },
            new[] { "Declarations page", "Named insured", "Policy period", "Limit", "Deductible", "Cancellation / non-renewal" },
            new[] { "coverage", "premium", "endorsement", "claim" }),

        new("coverage", "Coverage", BusinessEntity, "🛡️",
            "The specific protections a policy provides and the perils it responds to.",
            "A coverage is a single protection within a policy, such as dwelling protection on a homeowners policy or bodily injury liability on an auto policy. Each coverage defines the perils or events it responds to, the exclusions that remove certain losses, and the limit it pays up to. Coverage wording decides whether a claim is paid, so it is the most closely read part of any policy.",
            new[]
            {
                "Defines the insured perils (what causes covered loss) and the exclusions (what is not covered).",
                "Sets a limit for each coverage, and may carry a sub-limit for specific items.",
                "Forms the basis for deciding whether a reported loss is a covered claim."
            },
            new[] { "Insuring agreement", "Peril", "Exclusion", "Sub-limit", "Coverage line (personal auto, homeowners, commercial property, general liability, workers' comp)" },
            new[] { "policy", "claim" }),

        new("premium", "Premium", BusinessEntity, "💲",
            "The price the policyholder pays for coverage, based on how risky the exposure is.",
            "The premium is the amount charged for the insurance. It is calculated from the estimated risk, using rating factors such as location, building age, driving record, and claims history. Written premium is what is billed on policies sold. Earned premium is the part of that charge that corresponds to coverage already provided. The gap between the two matters for accounting and for measuring profitability.",
            new[]
            {
                "Is set by applying rating factors and rating rules to the exposure being insured.",
                "Is billed and collected, often in installments, and is the insurer's main source of revenue.",
                "Is recognized as earned over the policy period, which drives financial reporting."
            },
            new[] { "Rating factors", "Written premium", "Earned premium", "Unearned premium", "Installment billing", "Rate filing" },
            new[] { "policy", "underwriter", "actuary" }),

        new("claim", "Claim", BusinessEntity, "📋",
            "A policyholder's request for payment after a covered loss.",
            "A claim is the formal request for the insurer to pay for a loss covered by a policy. It moves through a set path: first notice of loss (FNOL), coverage confirmation, investigation and damage valuation, settlement, and closing. Most claims are paid by the insurer, and some are denied if the loss falls outside the coverage or an exclusion applies.",
            new[]
            {
                "Starts when the policyholder reports a loss, which is logged as first notice of loss.",
                "Is checked against the policy to confirm coverage and determine the amount owed after deductibles and limits.",
                "Ends with a settlement payment or a denial, and sometimes goes to litigation or appraisal."
            },
            new[] { "First notice of loss (FNOL)", "Loss date", "Coverage verification", "Settlement", "Subrogation", "Salvage", "Denial" },
            new[] { "policy", "coverage", "reserve", "claims-adjuster" }),

        new("reserve", "Reserve", BusinessEntity, "🏦",
            "The money an insurer sets aside to pay claims it expects to owe.",
            "Insurers must hold money for claims they expect to pay, including claims that have been reported but not yet settled, and claims that have happened but not yet been reported. These amounts are called reserves. Reserves are estimates that change as claims develop, so they are updated regularly and reviewed closely by finance, claims, and actuarial teams.",
            new[]
            {
                "Is set when a claim is opened, based on the adjuster's estimate of the expected cost.",
                "Is adjusted up or down as the claim develops, and is released when the claim closes.",
                "Includes incurred but not reported (IBNR) reserves for losses that have happened but are not yet known to the insurer."
            },
            new[] { "Case reserve", "IBNR", "Loss adjustment expense (LAE)", "Reserve development", "Adequacy" },
            new[] { "claim", "actuary" }),

        new("endorsement", "Endorsement", BusinessEntity, "✏️",
            "A change made to an existing policy after it is issued.",
            "An endorsement, sometimes called a rider, changes the terms of a policy during its term. Examples include adding a new vehicle to an auto policy, raising a coverage limit, or adding a named driver. Each endorsement can change the premium, so it is recorded on the policy and its premium impact is calculated and billed.",
            new[]
            {
                "Modifies coverage, limits, insureds, or other terms of an active policy.",
                "Often triggers a premium change, either an additional charge or a refund.",
                "Becomes part of the policy record, which is what gets checked when a claim is reported."
            },
            new[] { "Additional insured", "Rider", "Mid-term change", "Pro-rata premium" },
            new[] { "policy", "premium" }),

        // ---------- Key stakeholders ----------
        new("policyholder", "Policyholder / Insured", Stakeholder, "🧑‍💼",
            "The person or business that buys the insurance and is protected by it.",
            "The policyholder is the party who buys the policy and pays the premium. The insured is the person or property covered, and in many cases the two are the same. Policyholders expect fair pricing, clear coverage, prompt claim handling, and honest communication about what is and is not covered.",
            new[]
            {
                "Chooses coverage levels and pays premiums on time.",
                "Reports losses promptly and provides documentation for claims.",
                "Receives claim payments, and can dispute decisions through the complaint or appraisal process."
            },
            new[] { "Named insured", "Additional insured", "Loss of use", "Appraisal", "Premium financing" },
            new[] { "policy", "claim", "agent-broker" }),

        new("agent-broker", "Agent / Broker", Stakeholder, "🤝",
            "The intermediary who sells and services insurance for customers.",
            "Agents and brokers are the main channel through which most P&C policies are sold. An agent usually represents one insurer and sells its products. A broker usually represents the customer and shops across several insurers. Both are paid commissions on the premium, and both handle policy changes, renewals, and customer questions.",
            new[]
            {
                "Recommends coverage and places business with insurers.",
                "Handles endorsements, renewals, and billing questions for customers.",
                "Often the first point of contact when a customer has a loss, before the claim reaches the insurer."
            },
            new[] { "Captive agent", "Independent agent", "Broker", "Commission", "Producer", "Binder" },
            new[] { "policy", "premium", "policyholder" }),

        new("insurer", "Insurer / Carrier", Stakeholder, "🏢",
            "The company that takes on the risk and pays claims.",
            "The insurer, also called the carrier, is the company that accepts the risk in exchange for premium. It designs products, sets prices, underwrites risks, pays claims, and holds reserves. Insurers are regulated closely, because they must be able to pay future claims. Their profitability depends on both how well they price risk and how well they manage claims costs.",
            new[]
            {
                "Designs insurance products and files rates with regulators.",
                "Underwrites risk, issues policies, and collects premiums.",
                "Pays claims, holds reserves, and manages capital to stay solvent."
            },
            new[] { "Combined ratio", "Loss ratio", "Expense ratio", "Solvency", "Admitted / surplus lines", "Line of business" },
            new[] { "underwriter", "claims-adjuster", "reinsurer", "regulator" }),

        new("underwriter", "Underwriter", Stakeholder, "🔍",
            "The person who decides whether to accept a risk and what to charge for it.",
            "Underwriters evaluate each application to decide whether the insurer should take on the risk, under what conditions, and at what price. They review applicant information, loss history, property inspections, and other data. Good underwriting keeps the book of business profitable and avoids adverse selection, where only the riskiest applicants buy coverage.",
            new[]
            {
                "Reviews applications and decides to accept, decline, or accept with conditions.",
                "Sets the premium using rating rules and judgment for unusual risks.",
                "Monitors the portfolio and renews or non-renews policies."
            },
            new[] { "Submission", "Quote", "Bind", "Risk selection", "Adverse selection", "Authority limit" },
            new[] { "policy", "premium", "insurer" }),

        new("claims-adjuster", "Claims Adjuster", Stakeholder, "🔧",
            "The professional who investigates claims and determines what the insurer owes.",
            "Claims adjusters investigate reported losses. They confirm coverage, inspect damage, estimate repair or replacement costs, and negotiate settlements. Adjusters work for the insurer, while independent adjusters are hired on contract. They are often the most direct point of contact for a policyholder during a stressful event.",
            new[]
            {
                "Confirms coverage and investigates the cause and extent of the loss.",
                "Estimates damages and sets claim reserves.",
                "Negotiates settlements, and refers complex or disputed claims to specialists or counsel."
            },
            new[] { "Independent adjuster", "Field adjuster", "Desk adjuster", "Estimate", "Total loss", "Catastrophe (CAT) response" },
            new[] { "claim", "reserve", "policyholder" }),

        new("reinsurer", "Reinsurer", Stakeholder, "🌐",
            "The insurer's insurer, which takes on part of the risk for a fee.",
            "A reinsurer provides insurance to an insurance company. Primary insurers buy reinsurance to protect themselves against very large losses, such as hurricanes or earthquakes, and to limit their exposure to a single event. The primary insurer pays the reinsurer a share of the premium and receives help covering losses that exceed its retention.",
            new[]
            {
                "Accepts a share of the primary insurer's risk through treaty or facultative agreements.",
                "Pays its share of losses under the reinsurance contract.",
                "Helps the primary insurer stay solvent after large or catastrophic events."
            },
            new[] { "Treaty", "Facultative", "Retention", "Cession", "Excess of loss", "Catastrophe reinsurance" },
            new[] { "insurer", "premium", "actuary" }),

        new("regulator", "Regulator", Stakeholder, "⚖️",
            "The government body that oversees insurers to protect consumers and keep the market stable.",
            "P&C insurance is regulated mainly at the state level in the United States. The state insurance department approves rates, licenses insurers and agents, examines financial strength, and handles consumer complaints. Regulators check that prices are fair and adequate, and that insurers can pay claims when they are due.",
            new[]
            {
                "Licenses insurers, agents, and adjusters, and monitors their conduct.",
                "Reviews and approves rate filings and policy forms.",
                "Examines insurers' financial condition and handles consumer complaints."
            },
            new[] { "Rate filing", "Solvency examination", "Market conduct", "Guaranty fund", "NAIC" },
            new[] { "insurer", "agent-broker", "premium" }),

        new("actuary", "Actuary", Stakeholder, "📊",
            "The specialist who uses statistics and financial models to price risk and estimate reserves.",
            "Actuaries measure risk using data, probability, and financial modeling. In P&C insurance they help set rates, estimate the reserves needed for future claims, plan reinsurance, and assess the company's financial health. Their work connects pricing, claims, and finance, so their assumptions shape many business decisions.",
            new[]
            {
                "Builds rating models and recommends rate changes.",
                "Estimates loss reserves, including IBNR, and tests their adequacy.",
                "Supports capital planning, reinsurance purchasing, and regulatory filings."
            },
            new[] { "Loss development", "Loss triangle", "Rate adequacy", "IBNR", "Catastrophe model" },
            new[] { "premium", "reserve", "reinsurer" })
    };

    public static DomainItem? FindBySlug(string slug) =>
        All.FirstOrDefault(item => item.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));
}
