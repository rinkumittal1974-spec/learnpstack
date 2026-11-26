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

    static readonly Dictionary<string, ProcessGuide> BySlug = new()
    {
        ["claim-workflow"] = ClaimWorkflow
    };

    public static ProcessGuide? For(string slug) =>
        BySlug.TryGetValue(slug, out var guide) ? guide : null;
}
