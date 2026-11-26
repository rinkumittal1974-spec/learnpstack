using PCInsuranceDomain.Models;
using static PCInsuranceDomain.Models.DomainCategory;

namespace PCInsuranceDomain.Data;

public static class DomainCatalog
{
    public static readonly IReadOnlyList<DomainItem> All = new List<DomainItem>
    {
        // ---------- Business entities ----------
        new("policy", "Policy", BusinessEntity, "file-earmark-text", "blue",
            "The contract that defines what is insured and on what terms.",
            "A policy is the legally binding contract between an insurer and a policyholder. It records who is insured, what property or liability is covered, the period of coverage, the limits and deductibles, and the premium. In P&C insurance, most policies run for a fixed term, commonly six or twelve months, and are renewed or re-underwritten at the end of that term.",
            new[]
            {
                "Identifies the named insured, the insured property or activity, and the policy period.",
                "States the coverages, limits (maximum payout), and deductibles (the amount the insured pays first).",
                "Is changed over its life through endorsements and is renewed, cancelled, or non-renewed at term end."
            },
            new[] { "Declarations page", "Named insured", "Policy period", "Limit", "Deductible", "Cancellation / non-renewal" },
            new[] { "coverage", "premium", "endorsement", "claim", "quote", "insured-risk", "policy-lifecycle" }),

        new("coverage", "Coverage", BusinessEntity, "shield-check", "green",
            "The specific protections a policy provides and the perils it responds to.",
            "A coverage is a single protection within a policy, such as dwelling protection on a homeowners policy or bodily injury liability on an auto policy. Each coverage defines the perils or events it responds to, the exclusions that remove certain losses, and the limit it pays up to. Coverage wording decides whether a claim is paid, so it is the most closely read part of any policy.",
            new[]
            {
                "Defines the insured perils (what causes covered loss) and the exclusions (what is not covered).",
                "Sets a limit for each coverage, and may carry a sub-limit for specific items.",
                "Forms the basis for deciding whether a reported loss is a covered claim."
            },
            new[] { "Insuring agreement", "Peril", "Exclusion", "Sub-limit", "Coverage line (personal auto, homeowners, commercial property, general liability, workers' comp)" },
            new[] { "policy", "claim", "homeowners", "personal-auto", "commercial-property", "general-liability" }),

        new("premium", "Premium", BusinessEntity, "cash-coin", "orange",
            "The price the policyholder pays for coverage, based on how risky the exposure is.",
            "The premium is the amount charged for the insurance. It is calculated from the estimated risk, using rating factors such as location, building age, driving record, and claims history. Written premium is what is billed on policies sold. Earned premium is the part of that charge that corresponds to coverage already provided. The gap between the two matters for accounting and for measuring profitability.",
            new[]
            {
                "Is set by applying rating factors and rating rules to the exposure being insured.",
                "Is billed and collected, often in installments, and is the insurer's main source of revenue.",
                "Is recognized as earned over the policy period, which drives financial reporting."
            },
            new[] { "Rating factors", "Written premium", "Earned premium", "Unearned premium", "Installment billing", "Rate filing" },
            new[] { "policy", "underwriter", "actuary", "insurance-math" }),

        new("claim", "Claim", BusinessEntity, "clipboard-check", "red",
            "A policyholder's request for payment after a covered loss.",
            "A claim is the formal request for the insurer to pay for a loss covered by a policy. It moves through a set path: first notice of loss (FNOL), coverage confirmation, investigation and damage valuation, settlement, and closing. Most claims are paid by the insurer, and some are denied if the loss falls outside the coverage or an exclusion applies.",
            new[]
            {
                "Starts when the policyholder reports a loss, which is logged as first notice of loss.",
                "Is checked against the policy to confirm coverage and determine the amount owed after deductibles and limits.",
                "Ends with a settlement payment or a denial, and sometimes goes to litigation or appraisal."
            },
            new[] { "First notice of loss (FNOL)", "Loss date", "Coverage verification", "Settlement", "Subrogation", "Salvage", "Denial" },
            new[] { "policy", "coverage", "reserve", "claims-adjuster", "loss-event", "third-party-claimant", "claims-vendors", "claim-workflow" }),

        new("claim-workflow", "Claim Workflow", BusinessEntity, "signpost-split", "green",
            "The end-to-end path a claim follows, from the moment damage happens to final closure.",
            "The claim workflow is the sequence of steps an insurer and policyholder follow after a covered loss. It starts with the loss and first notice, moves through coverage checks, inspection, estimating, payment, repairs, and disputes, and ends with final settlement and records. Each stage has its own owner, timeframe, and rules, and many of them differ by state. The detail page walks through the full lifecycle for a home loss, with diagrams.",
            new[]
            {
                "Sets the order of steps from loss to closure, so the policyholder and insurer know what happens next.",
                "Defines the decision points where a claim is covered, denied, paid in part, or disputed.",
                "Records each stage, so timeframes, payments, and reserves can be tracked and reported."
            },
            new[] { "First notice of loss", "Coverage verification", "Reservation of rights", "Actual cash value", "Replacement cost value", "Holdback", "Appraisal", "Subrogation", "Release" },
            new[] { "claim", "policy", "claims-adjuster", "coverage" }),

        new("reserve", "Reserve", BusinessEntity, "bank", "teal",
            "The money an insurer sets aside to pay claims it expects to owe.",
            "Insurers must hold money for claims they expect to pay, including claims that have been reported but not yet settled, and claims that have happened but not yet been reported. These amounts are called reserves. Reserves are estimates that change as claims develop, so they are updated regularly and reviewed closely by finance, claims, and actuarial teams.",
            new[]
            {
                "Is set when a claim is opened, based on the adjuster's estimate of the expected cost.",
                "Is adjusted up or down as the claim develops, and is released when the claim closes.",
                "Includes incurred but not reported (IBNR) reserves for losses that have happened but are not yet known to the insurer."
            },
            new[] { "Case reserve", "IBNR", "Loss adjustment expense (LAE)", "Reserve development", "Adequacy" },
            new[] { "claim", "actuary", "insurance-math" }),

        new("endorsement", "Endorsement", BusinessEntity, "pencil-square", "purple",
            "A change made to an existing policy after it is issued.",
            "An endorsement, sometimes called a rider, changes the terms of a policy during its term. Examples include adding a new vehicle to an auto policy, raising a coverage limit, or adding a named driver. Each endorsement can change the premium, so it is recorded on the policy and its premium impact is calculated and billed.",
            new[]
            {
                "Modifies coverage, limits, insureds, or other terms of an active policy.",
                "Often triggers a premium change, either an additional charge or a refund.",
                "Becomes part of the policy record, which is what gets checked when a claim is reported."
            },
            new[] { "Additional insured", "Rider", "Mid-term change", "Pro-rata premium" },
            new[] { "policy", "premium", "policy-lifecycle" }),

        new("quote", "Quote", BusinessEntity, "receipt", "blue",
            "The insurer's priced offer of coverage before a policy is bound.",
            "A quote is the insurer's priced offer of coverage in response to an application. The applicant supplies details about the risk, such as the property, drivers, or business operations. The underwriter uses those details to decide whether to offer terms, at what price, and with which limits and exclusions. A quote is valid for a limited time and becomes a policy only when the applicant accepts it and binds coverage.",
            new[]
            {
                "Captures the application data that describes the risk being insured.",
                "Carries a proposed premium, coverage limits, deductibles, and any conditions attached to the offer.",
                "Becomes a bound policy when the applicant accepts and pays or commits to the first premium."
            },
            new[] { "Application", "Quote validity period", "Bind", "Indication", "Declination", "Subjectivity" },
            new[] { "policy", "underwriter", "premium", "policy-lifecycle" }),

        new("insured-risk", "Insured Risk", BusinessEntity, "house-door", "green",
            "The specific property, vehicle, or activity that the policy protects.",
            "The insured risk is the object or exposure the policy is written to cover. In personal lines it is typically a home, a vehicle, or a personal liability exposure. In commercial lines it can be a building, a fleet, inventory, or a business operation. Each risk has characteristics such as location, construction, age, use, and occupancy. Those characteristics drive how likely a loss is and how much it could cost, so they are central to pricing and underwriting.",
            new[]
            {
                "Identifies what is insured, such as a dwelling, vehicle, or business operation, and where it is located.",
                "Holds risk characteristics like construction type, age, protection class, and vehicle use that feed rating.",
                "Anchors claims, because a reported loss is checked against the insured property or activity named on the policy."
            },
            new[] { "Exposure", "Protection class", "Construction type", "Occupancy", "Replacement cost", "VIN" },
            new[] { "policy", "coverage", "underwriter" }),

        new("loss-event", "Loss Event", BusinessEntity, "cloud-lightning-rain", "red",
            "The actual incident that causes damage or injury, which may lead to one or more claims.",
            "A loss event is the real-world occurrence that causes damage or injury, such as a fire, a collision, a storm, or a slip and fall. One loss event can produce several claims, for example a property claim and a liability claim from the same fire. Insurers record the date, cause, and location of each loss event, because the loss date decides which policy period and coverage apply. Tracking loss events also lets insurers spot patterns such as a hailstorm affecting many policyholders at once.",
            new[]
            {
                "Records the date, time, location, and cause of the incident.",
                "Determines which policy was in force and which coverage responds.",
                "Groups related claims so catastrophe events and multi-claim incidents can be measured together."
            },
            new[] { "Date of loss", "Cause of loss", "Peril", "Occurrence", "Catastrophe (CAT) event", "Multiple claims per occurrence" },
            new[] { "claim", "coverage", "policy" }),

        new("policy-lifecycle", "Policy Lifecycle", BusinessEntity, "arrow-repeat", "teal",
            "The path a policy follows from first quote through renewal, cancellation, or lapse.",
            "The policy lifecycle is the sequence of events in a policy's life. It starts with a quote and an underwriting decision. Coverage is then bound and the policy is issued. During the term the policy is billed, checked, and changed by endorsements. At the end it is renewed, non-renewed, or allowed to lapse, and it can be cancelled early by either side. State law sets many of the rules, especially the notice an insurer must give before it ends coverage. The detail page walks through each step, with diagrams.",
            new[]
            {
                "Defines when coverage starts, changes, and ends, and who has to be told at each point.",
                "Connects the quote, underwriting, billing, endorsement, and renewal processes into one path.",
                "Sets the decision points where an insurer can decline, re-rate, cancel, or non-renew a policy."
            },
            new[] { "Bind", "Binder", "Declarations page", "Post-bind inspection", "Pro rata", "Short rate", "Notice of cancellation", "Non-renewal", "Lapse", "Reinstatement", "Premium audit" },
            new[] { "policy", "quote", "underwriter", "endorsement", "premium", "mortgagee-lienholder" }),

        new("insurance-math", "Insurance Math", BusinessEntity, "calculator", "purple",
            "How insurers measure results, with worked examples of the key ratios and calculations.",
            "Insurance has its own math because the price is set before the cost is known. An insurer collects premium today and pays claims months or years later. That gap explains most of the key measures. Earned premium shows how much revenue belongs to a period. Incurred losses and reserves estimate the full cost of the claims that belong to it. The combined ratio shows whether underwriting made money, and investment income on the money held in the meantime can turn an underwriting loss into a profit. The detail page works through each idea with simple numbers.",
            new[]
            {
                "Measures underwriting profit through the loss ratio, the expense ratio, and the combined ratio.",
                "Matches revenue and cost to the right period using earned premium and incurred losses.",
                "Estimates claims that haven't been reported or settled yet, using reserves and loss development."
            },
            new[] { "Written premium", "Earned premium", "Unearned premium reserve", "Incurred losses", "IBNR", "Loss adjustment expense (LAE)", "Loss ratio", "Expense ratio", "Combined ratio", "Float", "Loss development factor", "Coinsurance" },
            new[] { "premium", "reserve", "actuary", "investors-shareholders", "claim" }),

        // ---------- Lines of business ----------
        new("homeowners", "Homeowners", LineOfBusiness, "house-heart", "green",
            "Protects a home, the owner's belongings, and the owner's liability to others.",
            "Homeowners insurance is a package policy. It covers damage to the house and other structures, the owner's personal belongings, extra living costs while the home is being repaired, and the owner's legal liability if someone is hurt. Most U.S. policies use standard ISO forms or close variations of them. The HO-3 form covers the dwelling against all risks except those excluded, and covers belongings only for listed perils. Flood and earthquake are excluded and must be bought separately. A mortgage lender almost always requires the borrower to carry homeowners coverage.",
            new[]
            {
                "Coverage A, dwelling: the house itself, usually at replacement cost.",
                "Coverage B, other structures: detached garages, fences, and sheds, often 10% of Coverage A.",
                "Coverage C, personal property: furniture, clothing, and electronics, with lower sub-limits for jewelry, firearms, and cash.",
                "Coverage D, loss of use: hotel, meals, and other extra costs while the home can't be lived in.",
                "Coverage E and F: personal liability and medical payments for injuries to others."
            },
            new[] { "HO-3 (special form)", "HO-5 (comprehensive)", "HO-4 (renters)", "HO-6 (condo)", "Open perils", "Named perils", "Replacement cost", "Wind/hail deductible", "Water backup endorsement", "Ordinance or law" },
            new[] { "flood", "personal-umbrella", "mortgagee-lienholder", "claim-workflow", "restoration-contractor", "insured-risk" }),

        new("personal-auto", "Personal Auto", LineOfBusiness, "car-front", "blue",
            "Covers drivers for injuries and damage they cause, and for damage to their own car.",
            "Personal auto is the largest P&C line in the U.S. by premium. Nearly every state requires drivers to carry liability coverage up to a minimum limit, such as 25/50/25. That means $25,000 per injured person, $50,000 per accident for injuries, and $25,000 for property damage. Collision and comprehensive coverages pay to fix the policyholder's own car, and lenders require them on financed vehicles. About a dozen states use a no-fault system, where each driver's own policy pays their medical costs first through personal injury protection (PIP). Pricing depends heavily on the driver, the vehicle, and where it is garaged.",
            new[]
            {
                "Bodily injury and property damage liability for harm the driver causes to others.",
                "Collision for damage to the insured car from a crash, regardless of fault.",
                "Comprehensive for theft, hail, flood, fire, glass, and hitting an animal.",
                "Uninsured and underinsured motorist coverage for injuries caused by a driver with little or no insurance.",
                "Medical payments or PIP for the insured's own medical bills."
            },
            new[] { "Split limits (25/50/25)", "Collision", "Comprehensive", "UM/UIM", "PIP", "No-fault state", "Total loss", "Telematics", "Motor vehicle record (MVR)", "Garaging address" },
            new[] { "personal-umbrella", "commercial-auto", "third-party-claimant", "claims-adjuster", "insured-risk" }),

        new("personal-umbrella", "Personal Umbrella", LineOfBusiness, "umbrella", "teal",
            "Extra liability protection above the limits of a home and auto policy.",
            "A personal umbrella policy adds liability coverage on top of the policyholder's homeowners and auto policies, usually in $1 million layers. It pays only after the underlying policy's limit is used up. A serious car crash or a dog bite can produce a judgment far above standard limits, and an umbrella protects the policyholder's savings and future income from that. Insurers require minimum underlying limits, for example $250,000 per person and $500,000 per accident on auto, and $300,000 on the home policy. Umbrellas also cover some claims the underlying policies don't, such as libel or slander.",
            new[]
            {
                "Pays liability claims after the home or auto policy limit is exhausted.",
                "Covers some personal injury claims, such as defamation, that underlying policies may exclude.",
                "Usually pays defense costs in addition to the limit."
            },
            new[] { "Excess liability", "Underlying limits", "Self-insured retention", "Drop-down coverage", "Following form" },
            new[] { "homeowners", "personal-auto", "third-party-claimant" }),

        new("flood", "Flood", LineOfBusiness, "water", "blue",
            "Covers flood damage, which standard home policies exclude.",
            "Flood is excluded from standard homeowners and commercial property policies, so it must be bought separately. Most U.S. flood policies are written through the National Flood Insurance Program (NFIP), run by FEMA. Private insurers sell and service NFIP policies under the Write Your Own program, but the federal government carries the risk. The NFIP covers up to $250,000 for a home's structure and $100,000 for its contents. A policy usually takes effect 30 days after purchase, so buyers can't wait until a storm is forecast. Lenders require flood coverage for mortgaged homes in high-risk flood zones. A growing private flood market offers higher limits and extra coverages.",
            new[]
            {
                "Building coverage for the structure, its systems, and built-in appliances.",
                "Contents coverage for belongings, bought separately.",
                "Limited coverage in basements, where finished walls and most contents are excluded under the NFIP."
            },
            new[] { "NFIP", "Write Your Own (WYO)", "Special Flood Hazard Area", "Flood zone", "Elevation certificate", "30-day waiting period", "Risk Rating 2.0", "Private flood" },
            new[] { "homeowners", "commercial-property", "mortgagee-lienholder", "regulator" }),

        new("commercial-property", "Commercial Property", LineOfBusiness, "buildings", "orange",
            "Protects a business's buildings, equipment, and inventory, and its income after a loss.",
            "Commercial property insurance covers the physical assets of a business and the income it loses when a covered loss shuts it down. A policy is built from a coverage form and a causes-of-loss form. The causes-of-loss form can be basic, broad, or special, which works like the all-risks HO-3. Most policies include a coinsurance clause, which reduces the claim payment if the business insured less than a set share of the property's value. Small businesses often buy property and liability together in a business owners policy (BOP). Large accounts use engineering inspections and are often shared among several insurers.",
            new[]
            {
                "Building coverage for the owned structure and permanent fixtures.",
                "Business personal property for equipment, furniture, and inventory.",
                "Business income and extra expense for lost profit and added costs while operations are suspended.",
                "Optional coverages such as equipment breakdown, spoilage, and ordinance or law."
            },
            new[] { "Building and personal property form", "Causes of loss (basic, broad, special)", "Coinsurance", "Agreed value", "Business income", "Extra expense", "Period of restoration", "Business owners policy (BOP)", "Statement of values" },
            new[] { "general-liability", "flood", "insured-risk", "underwriter", "reinsurer" }),

        new("general-liability", "General Liability", LineOfBusiness, "exclamation-triangle", "red",
            "Covers a business when its premises, operations, or products hurt someone or damage their property.",
            "Commercial general liability (CGL) insurance protects a business from lawsuits by people outside the company. Typical claims are a customer slipping in a store, a contractor damaging a client's home, or a defective product causing injury. The standard ISO form has three parts: bodily injury and property damage, personal and advertising injury, and medical payments. Most CGL policies are written on an occurrence basis, so the policy in force when the injury happened responds, even if the lawsuit comes years later. Defense costs are paid in addition to the limits. Limits are commonly $1 million per occurrence and $2 million aggregate.",
            new[]
            {
                "Coverage A: bodily injury and property damage to others caused by the business.",
                "Coverage B: personal and advertising injury, such as libel, slander, or copyright infringement in advertising.",
                "Coverage C: medical payments to injured members of the public, regardless of fault.",
                "Products and completed operations: injury caused by a product or by finished work."
            },
            new[] { "Occurrence vs. claims-made", "Per-occurrence limit", "General aggregate", "Products-completed operations", "Additional insured", "Certificate of insurance", "Duty to defend", "Contractual liability" },
            new[] { "third-party-claimant", "commercial-property", "claims-vendors", "insurance-math" }),

        new("workers-compensation", "Workers' Compensation", LineOfBusiness, "cone-striped", "orange",
            "Pays medical bills and lost wages for employees hurt on the job, as required by state law.",
            "Workers' compensation covers employees who are injured or become ill because of their work. Almost every state requires employers to carry it, and Texas is the main exception where it is optional. It is a no-fault system: the injured worker receives benefits without proving the employer was negligent. In return, the worker generally can't sue the employer, which is called the exclusive remedy rule. Each state sets its own benefit levels. The premium is driven by payroll, the job classification of each employee, and the employer's own claim history through an experience modification factor. Four states run monopolistic state funds, where private insurers can't sell the coverage.",
            new[]
            {
                "Part One: the medical, wage-replacement, rehabilitation, and death benefits set by state law.",
                "Part Two: employer's liability for the rare lawsuits that fall outside the workers' comp system.",
                "Return-to-work and medical management programs that reduce lost time."
            },
            new[] { "Exclusive remedy", "Statutory benefits", "Class code", "Rate per $100 of payroll", "Experience modification (mod)", "Premium audit", "NCCI", "Monopolistic state fund", "Temporary total disability" },
            new[] { "regulator", "actuary", "claims-adjuster", "insurance-math" }),

        new("commercial-auto", "Commercial Auto", LineOfBusiness, "truck", "indigo",
            "Covers vehicles a business owns or uses, from a single van to a trucking fleet.",
            "Commercial auto covers cars, vans, and trucks used for business, along with liability for accidents their drivers cause. It works like personal auto, but coverage is assigned using numbered symbols that define which vehicles are covered. It can also cover hired and non-owned vehicles, such as an employee driving their own car on a work errand. Interstate truckers must meet federal minimum liability limits, and their policies carry the MCS-90 endorsement. The line has had underwriting losses in most years of the past decade, driven by rising repair costs and very large jury verdicts.",
            new[]
            {
                "Liability for injuries and damage caused by business vehicles and drivers.",
                "Physical damage coverage for the business's own vehicles.",
                "Hired and non-owned auto coverage for rented vehicles and employees' personal cars used for work.",
                "Motor carrier filings and endorsements required by federal and state regulators."
            },
            new[] { "Covered auto symbols", "Hired and non-owned auto", "Fleet", "MCS-90", "Motor carrier", "Nuclear verdict", "Driver qualification", "Telematics" },
            new[] { "personal-auto", "general-liability", "third-party-claimant", "regulator" }),

        new("cyber", "Cyber", LineOfBusiness, "laptop", "purple",
            "Covers the costs of data breaches, ransomware, and other cyber incidents.",
            "Cyber insurance pays for the costs a business faces after a cyber incident, such as a data breach, a ransomware attack, or a fraudulent funds transfer. First-party coverage pays the business's own costs: forensic investigators, breach notification, data restoration, ransom payments where legal, and lost income while systems are down. Third-party coverage pays for lawsuits and regulatory actions from customers and authorities. Because attacks can hit thousands of companies at once, insurers worry about systemic events and use war and infrastructure exclusions to limit them. Underwriters now require basic controls such as multi-factor authentication, tested backups, and endpoint detection before they offer coverage.",
            new[]
            {
                "Incident response: forensics, legal advice, breach notification, and credit monitoring.",
                "Cyber extortion and ransomware costs, including negotiation and, where legal, payment.",
                "Business interruption and data restoration after a network outage.",
                "Privacy liability and regulatory defense for claims from customers and regulators."
            },
            new[] { "First-party vs. third-party", "Ransomware", "Business email compromise", "Breach response panel", "Systemic risk", "War exclusion", "Multi-factor authentication (MFA)", "Sublimit" },
            new[] { "general-liability", "underwriter", "reinsurer", "claims-vendors" }),

        // ---------- Key stakeholders ----------
        new("policyholder", "Policyholder / Insured", Stakeholder, "person-badge", "indigo",
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

        new("agent-broker", "Agent / Broker", Stakeholder, "people", "teal",
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

        new("insurer", "Insurer / Carrier", Stakeholder, "building", "blue",
            "The company that takes on the risk and pays claims.",
            "The insurer, also called the carrier, is the company that accepts the risk in exchange for premium. It designs products, sets prices, underwrites risks, pays claims, and holds reserves. Insurers are regulated closely, because they must be able to pay future claims. Their profitability depends on both how well they price risk and how well they manage claims costs.",
            new[]
            {
                "Designs insurance products and files rates with regulators.",
                "Underwrites risk, issues policies, and collects premiums.",
                "Pays claims, holds reserves, and manages capital to stay solvent."
            },
            new[] { "Combined ratio", "Loss ratio", "Expense ratio", "Solvency", "Admitted / surplus lines", "Line of business" },
            new[] { "underwriter", "claims-adjuster", "reinsurer", "regulator", "rating-agency", "investors-shareholders" }),

        new("underwriter", "Underwriter", Stakeholder, "search", "orange",
            "The person who decides whether to accept a risk and what to charge for it.",
            "Underwriters evaluate each application to decide whether the insurer should take on the risk, under what conditions, and at what price. They review applicant information, loss history, property inspections, and other data. Good underwriting keeps the book of business profitable and avoids adverse selection, where only the riskiest applicants buy coverage.",
            new[]
            {
                "Reviews applications and decides to accept, decline, or accept with conditions.",
                "Sets the premium using rating rules and judgment for unusual risks.",
                "Monitors the portfolio and renews or non-renews policies."
            },
            new[] { "Submission", "Quote", "Bind", "Risk selection", "Adverse selection", "Authority limit" },
            new[] { "policy", "premium", "insurer", "quote", "insured-risk" }),

        new("claims-adjuster", "Claims Adjuster", Stakeholder, "tools", "red",
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

        new("reinsurer", "Reinsurer", Stakeholder, "globe-americas", "purple",
            "The insurer's insurer, which takes on part of the risk for a fee.",
            "A reinsurer provides insurance to an insurance company. Primary insurers buy reinsurance to protect themselves against very large losses, such as hurricanes or earthquakes, and to limit their exposure to a single event. The primary insurer pays the reinsurer a share of the premium and receives help covering losses that exceed its retention.",
            new[]
            {
                "Accepts a share of the primary insurer's risk through treaty or facultative agreements.",
                "Pays its share of losses under the reinsurance contract.",
                "Helps the primary insurer stay solvent after large or catastrophic events."
            },
            new[] { "Treaty", "Facultative", "Retention", "Cession", "Excess of loss", "Catastrophe reinsurance" },
            new[] { "insurer", "premium", "actuary", "rating-agency" }),

        new("regulator", "Regulator", Stakeholder, "shield-lock", "green",
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

        new("actuary", "Actuary", Stakeholder, "graph-up", "pink",
            "The specialist who uses statistics and financial models to price risk and estimate reserves.",
            "Actuaries measure risk using data, probability, and financial modeling. In P&C insurance they help set rates, estimate the reserves needed for future claims, plan reinsurance, and assess the company's financial health. Their work connects pricing, claims, and finance, so their assumptions shape many business decisions.",
            new[]
            {
                "Builds rating models and recommends rate changes.",
                "Estimates loss reserves, including IBNR, and tests their adequacy.",
                "Supports capital planning, reinsurance purchasing, and regulatory filings."
            },
            new[] { "Loss development", "Loss triangle", "Rate adequacy", "IBNR", "Catastrophe model" },
            new[] { "premium", "reserve", "reinsurer", "insurance-math" }),

        new("third-party-claimant", "Third-Party Claimant", Stakeholder, "person-exclamation", "orange",
            "The injured person or damaged party who is not the policyholder but is owed compensation.",
            "A third-party claimant is someone outside the policy who suffers injury or property damage because of the policyholder. For example, the driver of the other car in an accident, or a visitor who slips on the policyholder's property. Their claim is paid under the policyholder's liability coverage, not under their own policy. Third-party claims are often the most complex and expensive, because they can involve medical bills, lost income, and litigation.",
            new[]
            {
                "Reports the injury or damage and provides evidence such as medical records or repair estimates.",
                "Negotiates or litigates compensation against the policyholder's liability coverage.",
                "Can bring a direct action against the insurer in some states, depending on local law."
            },
            new[] { "Bodily injury", "Property damage liability", "Demand letter", "Release", "Statute of limitations", "Settlement" },
            new[] { "claim", "coverage", "claims-adjuster" }),

        new("mortgagee-lienholder", "Mortgagee / Lienholder", Stakeholder, "key", "teal",
            "The lender with a financial interest in insured property who must be protected by the policy.",
            "A mortgagee is the bank or lender that holds a loan secured by the insured property. A lienholder is a party with a legal claim on a vehicle or other asset, usually because it financed the purchase. Their interest appears on the policy through a mortgage clause or loss payee clause. If the policyholder's claim is paid, the mortgagee is named on the check, because the lender's collateral must be restored or the loan repaid.",
            new[]
            {
                "Is named on the policy so it receives notice of cancellation or non-renewal.",
                "Is included on claim payments for damage to the collateral.",
                "Can pay premium or force-place coverage if the borrower lets the policy lapse."
            },
            new[] { "Mortgage clause", "Loss payee", "Lien", "Force-placed insurance", "Collateral", "Escrow" },
            new[] { "policy", "claim", "policyholder" }),

        new("investors-shareholders", "Investors / Shareholders", Stakeholder, "graph-up-arrow", "green",
            "The owners of the insurer who expect a return on the capital they provide.",
            "Investors and shareholders own the insurance company or fund it with capital. Because insurers collect premium before paying claims, they hold large pools of money, and investors care about how well that money is invested and managed. Shareholders judge the company by profitability, growth, and return on equity. Their expectations push management toward pricing discipline, reserve adequacy, and reinsurance decisions, sometimes in tension with the goal of stable, affordable coverage.",
            new[]
            {
                "Provide the capital that backs the insurer's promise to pay claims.",
                "Elect the board, which oversees management strategy and risk appetite.",
                "Receive dividends or see share value change based on underwriting and investment results."
            },
            new[] { "Capital", "Return on equity", "Dividend", "Investment portfolio", "Surplus", "Board of directors" },
            new[] { "insurer", "actuary", "reinsurer" }),

        new("rating-agency", "Rating Agency", Stakeholder, "award", "purple",
            "The independent firm that grades an insurer's financial strength and ability to pay claims.",
            "Rating agencies such as A.M. Best, S&P Global, and Moody's assess an insurer's financial strength and its ability to meet policyholder obligations. The insurer's rating affects how agents, brokers, lenders, and large commercial buyers view it. A downgrade can make it harder to write new business or to attract reinsurance. Rating agencies review capital adequacy, reserve quality, reinsurance, and management, and they publish their opinions to the market.",
            new[]
            {
                "Analyze the insurer's capital, reserves, reinsurance program, and operating performance.",
                "Assign financial strength ratings that signal creditworthiness to the market.",
                "Publish updates and outlooks, which can prompt insurers to strengthen capital or change strategy."
            },
            new[] { "Financial strength rating", "Outlook", "Downgrade", "Capital adequacy", "Risk-adjusted capital", "Issuer rating" },
            new[] { "insurer", "reinsurer", "investors-shareholders" }),

        new("claims-vendors", "Claims Vendors & Service Providers", Stakeholder, "wrench-adjustable", "indigo",
            "The repair shops, appraisers, and legal firms that help settle claims.",
            "Claims vendors are the outside firms that insurers hire to repair property, value losses, and defend claims. They include auto body shops, restoration contractors, appraisers who value damaged property, medical reviewers, salvage yards, and defense attorneys. Their speed and quality shape how fast policyholders are made whole and how much the insurer pays. Insurers manage them through approved networks, pricing agreements, and performance reviews.",
            new[]
            {
                "Repair or replace damaged property and report completion to the claims team.",
                "Provide independent valuations, such as appraisals, medical reviews, or engineering reports.",
                "Defend the policyholder or the insurer in litigation when a claim cannot be settled."
            },
            new[] { "Direct repair program", "Appraisal", "Salvage", "Defense counsel", "Vendor network", "Independent medical exam (IME)" },
            new[] { "claim", "claims-adjuster", "third-party-claimant", "restoration-contractor" }),

        new("restoration-contractor", "Restoration Contractor", Stakeholder, "hammer", "blue",
            "The specialist who stops further damage and rebuilds property after a covered loss.",
            "Restoration contractors respond after water, fire, smoke, mold, or storm damage. They first mitigate the loss by extracting water, drying structures, boarding openings, and removing smoke residue, so the damage does not get worse. Then they clean, repair, and rebuild the property to its pre-loss condition. Policies require the insured to protect property from further damage, so restoration work often starts within hours of a loss, before the insurer has inspected it. Insurers and policyholders both rely on restoration contractors to keep repair costs and claim time under control.",
            new[]
            {
                "Performs emergency mitigation, such as water extraction, drying, and board-up, to limit further damage.",
                "Documents the work with moisture readings, photos, and drying logs that support the claim.",
                "Prepares a scope of work and cost estimate, and submits supplements when hidden damage is found."
            },
            new[] { "Mitigation", "Water extraction", "Drying logs", "Scope of work", "Supplement", "Direction to pay", "Preferred vendor program" },
            new[] { "claim", "claims-adjuster", "claims-vendors", "policyholder" })
    };

    public static DomainItem? FindBySlug(string slug) =>
        All.FirstOrDefault(item => item.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));
}
