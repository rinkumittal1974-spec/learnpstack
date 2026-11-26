using PCInsuranceDomain.Models;

namespace PCInsuranceDomain.Data;

public static class ProcessGuides
{
    static readonly ProcessGuide ClaimWorkflow = new(
        Intro: "This walkthrough follows one home claim from the moment damage happens to final closure. The example is a storm that tears off part of a roof and lets rain into the living room, but the same steps apply to fire, water, and hail losses. Timeframes are typical, not guaranteed. Each state sets its own deadlines for claim handling, and each policy sets its own deadlines for reporting and repairs.",
        Steps: new[]
        {
            new ProcessStep(
                "Phase 1: The loss",
                "Make the home safe and stop further damage",
                "Policyholder",
                "Immediately, within hours",
                "Your first job is to keep people safe and limit the damage. Most policies require you to take reasonable steps to protect the property. The cost of those steps is usually covered as part of the claim.",
                new[]
                {
                    "Call 911 or the fire department for fire, gas smell, or a structure that may collapse. Leave the home if it is unsafe.",
                    "Shut off the water at the main valve for a burst pipe. Turn off electricity or gas if you can do it safely.",
                    "Tarp a damaged roof or board up broken windows. Keep the receipts for these emergency repairs.",
                    "Photograph and video all damage before you clean up or move anything. Keep damaged items until the adjuster has seen them.",
                    "Note the time of the storm, what you saw, and any witnesses.",
                    "If you need a place to stay, keep receipts for hotels, meals, and laundry. These may be covered as loss-of-use expenses."
                }),
            new ProcessStep(
                "Phase 1: The loss",
                "First Notice of Loss (FNOL): report the claim",
                "Policyholder, or the agent on their behalf",
                "Within hours to a few days. Check your policy for the reporting deadline.",
                "You report the loss to the insurer. This opens the claim file and starts the clock on the claim.",
                new[]
                {
                    "Report by the insurer's 24-hour phone line, the mobile app, the website, or through your agent.",
                    "Have ready: policy number, date and time of loss, address, cause of loss, the areas damaged, whether anyone was hurt, and any police or fire report number.",
                    "The insurer assigns a claim number and sends a confirmation, often by text or email. Write the number down.",
                    "Prompt notice matters. Most policies require it, and a long delay can put coverage at risk.",
                    "For a large regional event, such as a hurricane, the insurer may open a catastrophe (CAT) response with separate teams and extended hours."
                }),
            new ProcessStep(
                "Phase 2: Set up and check coverage",
                "Claim setup and triage",
                "Claims intake representative",
                "Same day to one business day",
                "The insurer confirms the policy covers this loss and sets up the claim so an adjuster can be assigned.",
                new[]
                {
                    "Confirms the policy was in force on the date of loss, the named insured, and the property address.",
                    "Identifies the coverages that may respond: dwelling (the house), other structures, personal property (contents), loss of use, and liability.",
                    "Checks the cause of loss against the policy. Wind, hail, and fire are usually covered. Flood and earth movement are usually excluded and need a separate policy.",
                    "Applies the deductible. Some policies and states use a percentage deductible for wind or hurricane losses.",
                    "Sets an initial reserve, which is the insurer's estimate of what it expects to pay. Reserves are updated as the claim develops.",
                    "Assigns an adjuster. If the claim has red flags, such as a loss soon after the policy was bought, it may be referred to the special investigations unit (SIU)."
                }),
            new ProcessStep(
                "Phase 2: Set up and check coverage",
                "Reservation of rights, if coverage is unclear",
                "Claims adjuster or coverage specialist",
                "Only when needed. The letter comes early, and the investigation can take weeks.",
                "If the insurer is not sure the loss is covered, it keeps investigating and tells you in writing that it reserves its rights. Most claims never reach this step.",
                new[]
                {
                    "The reservation of rights letter names the open question, such as late reporting, damage that existed before the storm, or a possible exclusion.",
                    "It does not deny the claim. It means the insurer will keep investigating and may still decide not to pay part or all of it.",
                    "Respond in writing, keep copies, and provide any documents that answer the question."
                }),
            new ProcessStep(
                "Phase 3: Investigate and value the damage",
                "Contact and inspection",
                "Adjuster and policyholder",
                "Contact usually within 24 to 72 hours. Inspection within days to two weeks. Longer during a CAT event.",
                "The adjuster contacts you, visits the home, and records what was damaged and why.",
                new[]
                {
                    "Adjuster calls to schedule a visit and explain the process.",
                    "On site, the adjuster checks the roof, attic, walls, ceilings, floors, and contents. Water-damaged areas are checked for moisture.",
                    "Photos and measurements are taken. Roof size is often measured from aerial images, such as EagleView or Hover reports.",
                    "The adjuster sketches the floor plan and asks about the home's condition before the storm, including past repairs and maintenance. Earlier photos or invoices help.",
                    "For structural problems or disputed causes, the insurer may hire an engineer.",
                    "For water losses, a mitigation company may record moisture readings and drying logs. These records support the claim."
                }),
            new ProcessStep(
                "Phase 3: Investigate and value the damage",
                "Estimate and valuation",
                "Adjuster, with contractor input",
                "Days to a few weeks",
                "The adjuster writes a line-item estimate of the cost to repair or replace what was damaged.",
                new[]
                {
                    "The estimate is written in estimating software, such as Xactimate, with each line for materials, labor, and time. Prices come from local price lists.",
                    "Overhead and profit (O&P) is added when several trades are needed and a general contractor coordinates the work. Many states require it in this case.",
                    "Actual cash value (ACV) policies deduct depreciation for age and wear. Replacement cost value (RCV) policies pay the depreciation later, after repairs are completed.",
                    "Ordinance or law coverage, if the policy includes it, pays the extra cost of rebuilding to current building codes.",
                    "Personal property is inventoried separately. Items may be paid at ACV or RCV depending on the policy."
                }),
            new ProcessStep(
                "Phase 3: Investigate and value the damage",
                "Loss of use, if the home is not livable",
                "Policyholder and adjuster",
                "For as long as the repairs take, up to the policy limit",
                "If the home cannot be lived in, the policy pays reasonable extra living costs while repairs are underway.",
                new[]
                {
                    "Covers hotel or rental costs, extra meals, laundry, and extra mileage above your normal costs.",
                    "Keep every receipt and a log of the extra costs.",
                    "The payment is limited by the policy's loss-of-use limit, and by the time the home is repaired or the family settles elsewhere."
                }),
            new ProcessStep(
                "Phase 4: Decide and pay",
                "Coverage decision",
                "Adjuster and claims supervisor",
                "Often 30 to 40 days after proof of loss, depending on state rules",
                "The insurer decides whether to pay, pay part, or deny the claim, and tells you in writing.",
                new[]
                {
                    "Compares the cause and extent of damage with the policy wording, exclusions, and limits.",
                    "Covered: the insurer approves payment for the agreed amount.",
                    "Partly covered: the insurer pays for covered items and explains in writing what is excluded.",
                    "Denied: a written letter states the policy language relied on and the appeal options. You can ask for a review and file a complaint with the state insurance department."
                }),
            new ProcessStep(
                "Phase 4: Decide and pay",
                "First payment: ACV less deductible",
                "Claims payments team",
                "Days after the decision",
                "The insurer issues the first payment, which is the agreed amount minus depreciation and the deductible.",
                new[]
                {
                    "Payment equals the approved amount, minus depreciation under an ACV policy, minus the deductible, minus any earlier payments.",
                    "If you have a mortgage, the lender is usually named on the check. Some lenders release funds in stages as repairs are completed.",
                    "Some insurers pay by direct deposit or an online payment platform.",
                    "Partial payments can be made while the estimate is still being finalized."
                }),
            new ProcessStep(
                "Phase 5: Repair and recover depreciation",
                "Repairs, supplements, and proof of completion",
                "Policyholder, contractor, and adjuster",
                "Weeks to months. Many RCV policies require repairs within a set period, often 180 days to two years.",
                "You repair the home. The insurer releases the held-back depreciation after the work is finished.",
                new[]
                {
                    "You usually choose the contractor. Some insurers have a direct repair program with preferred contractors, but you can decline it in most states.",
                    "Be careful with anyone who asks for the full insurance payment or your deductible up front. Some states restrict these practices.",
                    "Supplements: if the contractor finds hidden damage during demolition, such as rotted subflooring, it sends a supplement request with photos and measurements to the adjuster.",
                    "To get the depreciation (holdback) under an RCV policy, send the final invoice, completion photos, and any permits to the insurer.",
                    "Keep copies of everything you send and receive."
                }),
            new ProcessStep(
                "Phase 5: Repair and recover depreciation",
                "Disputes: appraisal, public adjuster, or complaint",
                "Policyholder, insurer, appraisers, and regulators",
                "Weeks to more than a year",
                "If you and the insurer cannot agree on the amount, the policy and state rules give you other ways to resolve it.",
                new[]
                {
                    "Appraisal: each side hires an appraiser, and the two appraisers choose an umpire. In most states, the appraisal decides the amount of loss. It does not decide whether the loss is covered.",
                    "Public adjuster: a licensed professional you hire to negotiate with the insurer. Fees are a percentage of the settlement, and many states cap them.",
                    "State insurance department complaint: free to file. The regulator reviews how the claim was handled.",
                    "Litigation: a lawsuit for breach of contract or bad faith. Some states allow extra damages or attorney fees in these cases."
                }),
            new ProcessStep(
                "Phase 6: Close the claim",
                "Subrogation and salvage",
                "Subrogation unit and salvage vendors",
                "Months to years. You do not need to act on this step.",
                "The insurer tries to recover money it paid from anyone responsible, and sells damaged items it no longer needs.",
                new[]
                {
                    "Subrogation: if a contractor, a manufacturer (for example, a defective water heater), or another party caused the loss, the insurer may pursue them for the money it paid. Your deductible is usually repaid from any recovery.",
                    "Salvage: damaged materials or equipment can be sold to a salvage buyer, which lowers the net cost of the claim."
                }),
            new ProcessStep(
                "Phase 6: Close the claim",
                "Final settlement, release, and closure",
                "Adjuster and policyholder",
                "Weeks to months after repairs are done",
                "The last amounts are paid and you sign a release. The claim is then closed.",
                new[]
                {
                    "The final payment covers any remaining holdback, approved supplements, and final invoices.",
                    "A release states that the claim is settled. Read it before you sign. Signing usually ends the claim, so ask about anything you have not yet been paid.",
                    "If hidden damage shows up after closure, you can usually ask to reopen the claim within the policy's time limits."
                }),
            new ProcessStep(
                "Phase 6: Close the claim",
                "Records, claim history, and reporting",
                "Claims system, underwriting, and actuarial teams",
                "Ongoing. Claim history is usually kept about seven years.",
                "The insurer records the outcome. The loss affects your future premiums and the insurer's financial reporting.",
                new[]
                {
                    "Reserves are released and the claim status moves to closed.",
                    "The claim is reported to industry claim-history databases, such as LexisNexis CLUE. Insurers may check this history when they price or write future policies.",
                    "Claim data feeds loss reserving and pricing. For large catastrophe events, the insurer also files reinsurance recovery requests."
                })
        },
        Diagrams: new[]
        {
            new ProcessDiagram(
                "The claim lifecycle at a glance",
                "Each decision point can send the claim back to an earlier step, for example when a reservation of rights is issued or a dispute is raised.",
                """
                flowchart TD
                  A["Damage happens: storm, fire, or burst pipe"] --> B["Make safe and stop further damage"]
                  B --> C["First Notice of Loss reported"]
                  C --> D["Claim set up and policy checked"]
                  D --> E{"Policy in force and cause covered?"}
                  E -- Unclear --> H["Reservation of rights while investigating"]
                  H --> E
                  E -- No --> F["Written denial with reasons"]
                  F --> G["Appeal or complaint to state regulator"]
                  E -- Yes --> I["Inspection and damage documentation"]
                  I --> J["Estimate and valuation"]
                  J --> K["Payment: ACV less deductible"]
                  K --> L["Repairs and supplements"]
                  L --> M{"Agreed on the amount?"}
                  M -- No --> N["Appraisal, public adjuster, or complaint"]
                  N --> M
                  M -- Yes --> O["Depreciation released after proof of repair"]
                  O --> P["Final release signed and claim closed"]
                  P --> Q["Subrogation, salvage, and claim history recorded"]
                """),
            new ProcessDiagram(
                "Who does what, step by step",
                "The sequence of messages between the policyholder, the insurer, and the parties who help settle the claim.",
                """
                sequenceDiagram
                  autonumber
                  participant P as Policyholder
                  participant A as Agent
                  participant I as Insurer Claims
                  participant J as Adjuster
                  participant C as Restoration Contractor
                  participant M as Mortgage Lender
                  P->>A: Report storm damage
                  P->>I: First notice of loss by app or phone
                  I-->>P: Claim number and next steps
                  I->>J: Assign adjuster
                  J->>P: Contact within 24 to 72 hours
                  J->>P: Inspect property and document damage
                  J->>I: Submit estimate and reserve
                  I-->>P: Coverage decision and ACV payment
                  I->>M: Payment check includes lender
                  P->>C: Hire contractor and start repairs
                  C->>J: Supplement for hidden damage
                  J->>I: Approve supplement
                  P->>I: Proof of completion
                  I-->>P: Depreciation released
                  I-->>P: Final release and claim closed
                """),
            new ProcessDiagram(
                "Claim status over time",
                "The states a claim can move through. A closed claim can be reopened if hidden damage appears.",
                """
                stateDiagram-v2
                  [*] --> Reported
                  Reported --> UnderReview: Set up and verified
                  UnderReview --> Denied: Not covered
                  UnderReview --> Investigating: Covered or unclear
                  Investigating --> Estimated: Inspection and estimate done
                  Estimated --> PartiallyPaid: ACV payment issued
                  PartiallyPaid --> Repairing: Repairs started
                  Repairing --> Disputed: Amount disagreed
                  Disputed --> Repairing: Resolved by agreement or appraisal
                  Denied --> Disputed: Appeal filed
                  Repairing --> Closed: Depreciation paid and release signed
                  Closed --> Reopened: Hidden damage found
                  Reopened --> Repairing
                  Closed --> [*]
                """)
        });

    static readonly ProcessGuide PolicyLifecycle = new(
        Intro: "This walkthrough follows one homeowners policy from the first quote through its renewal a year later. Auto and commercial policies follow the same path, with a few extra steps noted below. Notice periods and allowed reasons for cancellation are set by each state, so the timeframes here are typical, not universal.",
        Steps: new[]
        {
            new ProcessStep(
                "Phase 1: Shop and apply",
                "Request a quote",
                "Prospective policyholder, with an agent, broker, or the insurer's website",
                "Minutes to a few days",
                "The buyer gives basic facts about themselves and the property. The insurer uses those facts, plus outside data, to produce a price for a set of coverages.",
                new[]
                {
                    "The buyer gives the address, year built, square footage, roof age and type, construction, and any past claims.",
                    "Many insurers prefill property details from third-party property data, so the buyer only confirms or corrects them.",
                    "The buyer picks coverage limits, a deductible, and optional endorsements such as water backup or scheduled jewelry.",
                    "A quote is a price offer, not coverage. It is usually valid for 30 to 60 days and can change once the insurer verifies the facts."
                }),
            new ProcessStep(
                "Phase 1: Shop and apply",
                "Underwriting review",
                "Underwriter, often helped by automated rules",
                "Instant for simple risks, days or weeks for complex ones",
                "The insurer decides whether to accept the risk and at what price. Most personal-lines applications are approved by rules automatically. Unusual ones go to a human underwriter.",
                new[]
                {
                    "Orders reports: claim history (CLUE), a credit-based insurance score where state law allows it, and a motor vehicle record for auto.",
                    "Checks hazard data such as wildfire, flood zone, wind, hail, and distance to the nearest fire station.",
                    "Applies eligibility rules. Examples are roof age limits, no prior dog-bite claims, or no unrepaired damage.",
                    "Approves, declines, or makes a counter-offer, such as a higher deductible or a wind exclusion.",
                    "Commercial accounts usually go through a broker, who sends the submission to several insurers. Complex risks may need an engineering or loss-control survey."
                }),

            new ProcessStep(
                "Phase 2: Bind and issue",
                "Bind coverage",
                "Agent with binding authority, or the insurer",
                "Same day",
                "Binding is the moment coverage starts. The insurer is now on the risk, even before the full policy document exists.",
                new[]
                {
                    "The buyer signs the application and makes the first payment or down payment.",
                    "The agent issues a binder, a short temporary contract that proves coverage until the policy is issued.",
                    "For a home purchase, the lender needs proof of insurance before closing. The agent sends an evidence of insurance form naming the mortgagee.",
                    "False answers on the application can let the insurer void the policy later, so accuracy at this step matters."
                }),
            new ProcessStep(
                "Phase 2: Bind and issue",
                "Issue the policy",
                "Insurer's policy administration system",
                "Within days to a few weeks of binding",
                "The insurer produces the formal contract and sends it to the policyholder and to anyone else with an interest in the property.",
                new[]
                {
                    "The declarations page lists the named insured, address, policy period, coverages, limits, deductibles, and premium.",
                    "The policy forms and endorsements that make up the contract are attached.",
                    "The mortgagee is listed so claim checks include the lender, and the lender receives renewal and cancellation notices.",
                    "Auto policies also produce ID cards, which many states require drivers to carry."
                }),

            new ProcessStep(
                "Phase 3: During the term",
                "Billing and payment",
                "Policyholder, insurer billing team, and sometimes the mortgage servicer",
                "Throughout the term",
                "The policyholder pays in full or by installments. Many homeowners pay through an escrow account run by their mortgage servicer.",
                new[]
                {
                    "Pay plans include paid in full, monthly, quarterly, or escrow billing. Installment plans often add a small fee per payment.",
                    "A missed payment triggers a notice of cancellation for nonpayment. Most states require at least 10 days' notice before coverage ends.",
                    "If the policyholder pays before the cancellation date, coverage continues. Some insurers also reinstate shortly after, with or without a gap."
                }),
            new ProcessStep(
                "Phase 3: During the term",
                "Post-bind verification",
                "Underwriter and inspection vendor",
                "Usually within the first 60 days",
                "After binding, the insurer checks that the property matches the application. Problems found here can change the price or end the policy.",
                new[]
                {
                    "An exterior inspection or aerial image checks the roof, hazards such as a trampoline or an unfenced pool, and overall upkeep.",
                    "If the facts differ, the insurer may re-rate the policy, require repairs by a deadline, or cancel it.",
                    "Many states let insurers cancel a new policy for almost any reason during the first 60 days. After that, cancellation is limited to specific reasons such as nonpayment or fraud."
                }),
            new ProcessStep(
                "Phase 3: During the term",
                "Mid-term changes (endorsements)",
                "Policyholder or agent requests, and the insurer processes",
                "Any time during the term",
                "When something changes, the policy is amended by an endorsement instead of being rewritten.",
                new[]
                {
                    "Common changes are adding a car or driver, raising a dwelling limit after a renovation, scheduling new jewelry, or changing the mortgagee after a refinance.",
                    "The premium is adjusted pro rata. A change halfway through a 12-month term costs or saves half of the annual difference.",
                    "Each endorsement creates a new version of the declarations page."
                }),
            new ProcessStep(
                "Phase 3: During the term",
                "Premium audit (commercial policies)",
                "Premium auditor",
                "After the policy period ends",
                "Workers' comp and general liability premiums are based on estimates of payroll or sales. An audit replaces the estimate with the actual figures.",
                new[]
                {
                    "The auditor reviews payroll records, sales, or subcontractor costs for the expired term.",
                    "If actual exposure was higher than estimated, the insured owes additional premium. If lower, they get a refund.",
                    "Personal-lines policies, such as homeowners and auto, are not audited."
                }),

            new ProcessStep(
                "Phase 4: Ending a policy early",
                "Cancellation",
                "Policyholder or insurer",
                "Any time, with the notice the state requires",
                "Either side can end a policy before its expiration date. The rules differ depending on who cancels.",
                new[]
                {
                    "Policyholder cancellation: the insured asks to cancel, for example after selling the home. Most insurers refund the unused premium pro rata. Some subtract a short-rate penalty.",
                    "Insurer cancellation: allowed only for reasons the state permits, such as nonpayment, fraud, material misrepresentation, or a major increase in hazard.",
                    "The insurer must send written notice to the insured and the mortgagee. Common notice periods are 10 days for nonpayment and 20 to 30 days for other reasons.",
                    "A mortgaged home without insurance gets force-placed coverage bought by the lender. It is usually more expensive and protects only the lender's interest."
                }),

            new ProcessStep(
                "Phase 5: Renewal",
                "Renewal review",
                "Underwriter, actuarial rate changes, and automated rules",
                "60 to 90 days before expiration",
                "Before the term ends, the insurer decides whether to offer another term and at what price.",
                new[]
                {
                    "New rates filed with the state regulator apply at renewal, so the premium can change even with no claims.",
                    "Claims during the term, new hazard data, or a fresh inspection can change the price or the terms.",
                    "Many policies apply inflation guard, which raises the dwelling limit each year to keep up with rebuilding costs.",
                    "The insurer may offer a conditional renewal, for example with a higher wind deductible or a required roof replacement."
                }),
            new ProcessStep(
                "Phase 5: Renewal",
                "Renewal offer or non-renewal",
                "Insurer, then the policyholder",
                "Notice typically 30 to 60 days before expiration, longer in some states",
                "The insurer either sends a renewal offer or a notice that it will not renew.",
                new[]
                {
                    "A renewal offer shows the new premium and any changes. Most personal policies renew automatically when the bill is paid.",
                    "A non-renewal notice must give the reason in many states, and must arrive before a state-set deadline.",
                    "Some states ban or limit non-renewals after disasters. California, for example, has issued one-year moratoriums in ZIP codes near large wildfires.",
                    "A homeowner who can't find coverage in the normal market can turn to the state's residual market, such as a FAIR plan or Citizens in Florida."
                }),
            new ProcessStep(
                "Phase 5: Renewal",
                "Renew, shop, or lapse",
                "Policyholder and agent",
                "By the expiration date",
                "The policyholder accepts the renewal, moves to another insurer, or lets the policy lapse.",
                new[]
                {
                    "If the renewal is paid, a new term starts and the cycle repeats from the billing step.",
                    "Independent agents often shop the account with other insurers when the price rises sharply.",
                    "A lapse leaves a gap in coverage. Gaps raise future prices, especially for auto, and a mortgage lender will force-place coverage.",
                    "Everything that happened during the term, including claims, inspections, and payment history, feeds the next underwriting review."
                })
        },
        Diagrams: new[]
        {
            new ProcessDiagram(
                "Policy lifecycle at a glance",
                "The main path runs top to bottom. Side branches show where a policy can end early or leave the insurer.",
                """
                flowchart TD
                  A["Quote request"] --> B{"Underwriting review"}
                  B -- "Declined" --> X["No coverage offered"]
                  B -- "Approved" --> C["Bind coverage and take first payment"]
                  C --> D["Issue policy and declarations page"]
                  D --> E["Policy in force"]
                  E --> F["Endorsements and mid-term changes"]
                  F --> E
                  E --> G{"Post-bind check passed?"}
                  G -- "No" --> K["Cancellation"]
                  G -- "Yes" --> H["Renewal review"]
                  E -- "Missed payment or insured request" --> K
                  H --> I{"Offer renewal?"}
                  I -- "No" --> N["Non-renewal notice"]
                  I -- "Yes" --> J{"Policyholder pays?"}
                  J -- "Yes" --> E
                  J -- "No" --> L["Lapse"]
                  N --> M["Shop other insurers or the residual market"]
                  L --> M
                """),
            new ProcessDiagram(
                "Policy statuses",
                "The status a policy record moves through in a policy administration system.",
                """
                stateDiagram-v2
                  [*] --> Quoted
                  Quoted --> Bound: Application signed and paid
                  Quoted --> [*]: Quote expires or is declined
                  Bound --> InForce: Policy issued
                  InForce --> InForce: Endorsement
                  InForce --> PendingCancel: Missed payment
                  PendingCancel --> InForce: Paid before the deadline
                  PendingCancel --> Cancelled: Notice period ends
                  InForce --> Cancelled: Insured or insurer cancels
                  Cancelled --> InForce: Reinstated
                  InForce --> Renewed: Renewal offer paid
                  Renewed --> InForce: New term starts
                  InForce --> Expired: Non-renewed or not paid
                  Cancelled --> [*]
                  Expired --> [*]
                """)
        });

    static readonly Dictionary<string, ProcessGuide> BySlug = new()
    {
        ["claim-workflow"] = ClaimWorkflow,
        ["policy-lifecycle"] = PolicyLifecycle
    };

    public static ProcessGuide? For(string slug) =>
        BySlug.TryGetValue(slug, out var guide) ? guide : null;
}
