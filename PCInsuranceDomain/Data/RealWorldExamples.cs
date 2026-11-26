using PCInsuranceDomain.Models;

namespace PCInsuranceDomain.Data;

public static class RealWorldExamples
{
    static RealWorldExample E(string name, string note) => new(name, note);

    static readonly Dictionary<string, IReadOnlyList<RealWorldExample>> BySlug = new()
    {
        ["policy"] = new[]
        {
            E("ISO Homeowners 3 (HO-3) policy", "The most widely used standard form for owner-occupied homes in the U.S."),
            E("Personal Auto Policy (PAP)", "The standard ISO auto contract used by many personal-lines carriers."),
            E("Business Owners Policy (BOP)", "A bundled commercial policy for small businesses, offered by carriers such as The Hartford and Travelers."),
            E("ACORD application forms", "Industry-standard forms used to apply for and document policies.")
        },
        ["coverage"] = new[]
        {
            E("Coverage A: Dwelling", "The part of a homeowners policy that pays to rebuild the house."),
            E("Bodily injury and property damage liability", "The core auto liability coverages, often shown as limits like 100/300/100."),
            E("Commercial General Liability (CGL)", "Covers a business's liability for third-party injury and property damage."),
            E("Flood coverage via NFIP", "Flood is excluded from standard homeowners policies and is sold through the National Flood Insurance Program.")
        },
        ["premium"] = new[]
        {
            E("Progressive Snapshot", "A usage-based auto program that adjusts premium using driving data."),
            E("State Farm Drive Safe & Save", "A telematics discount program that lowers auto premium for safe driving."),
            E("NAIC statutory annual statement", "Where insurers report written and earned premium each year."),
            E("Rate filings", "Insurers file proposed rate changes with state departments of insurance before using them.")
        },
        ["claim"] = new[]
        {
            E("Hurricane Ian (2022) claims", "Produced well over a million property claims, mostly in Florida."),
            E("GEICO and State Farm auto claims", "High-volume personal auto claims handled through mobile photo estimates."),
            E("Verisk ClaimSearch", "An industry database insurers use to check claims history and detect fraud."),
            E("Xactimate", "Estimating software used to price property repair claims.")
        },
        ["reserve"] = new[]
        {
            E("Case reserves", "Estimates set by an adjuster for a specific open claim."),
            E("IBNR reserves", "Reserves for losses that have occurred but are not yet reported."),
            E("Schedule P", "The NAIC annual statement schedule that shows how loss reserves developed over time."),
            E("Asbestos and environmental reserve strengthening", "A well-known long-tail example where carriers repeatedly increased reserves.")
        },
        ["endorsement"] = new[]
        {
            E("Scheduled personal property endorsement", "Adds higher limits for items such as jewelry and art."),
            E("Additional insured endorsement", "Common on commercial policies when a client or landlord must be covered."),
            E("Water backup endorsement", "Adds sewer and drain backup coverage that homeowners policies usually exclude."),
            E("Roadside assistance add-on", "A common auto endorsement offered by carriers such as Allstate and Nationwide.")
        },
        ["quote"] = new[]
        {
            E("Progressive and GEICO online quote tools", "Let a shopper get an auto quote in a few minutes."),
            E("Applied Rater and EZLynx", "Agency software that pulls quotes from many carriers at once."),
            E("Comparative raters for independent agents", "Show one risk priced across several carriers side by side."),
            E("LexisNexis and Verisk data prefill", "Fills in vehicle, driver, and property details to speed up quoting.")
        },
        ["insured-risk"] = new[]
        {
            E("A single-family home in a coastal Florida ZIP code", "A typical wind and flood exposure used in property underwriting."),
            E("A fleet of delivery vans", "A commercial auto risk rated on vehicle count, use, and driver records."),
            E("A restaurant", "A small commercial risk with fire, liability, and food-spoilage exposures."),
            E("CoreLogic and Verisk property data", "Commercial sources of roof, construction, and hazard data used to assess a risk.")
        },
        ["loss-event"] = new[]
        {
            E("Hurricane Katrina (2005)", "A landmark catastrophe that reshaped property insurance and reinsurance pricing."),
            E("Northridge earthquake (1994)", "Led many California insurers to stop writing new homeowners policies."),
            E("2021 Texas winter storm (Uri)", "Caused widespread freeze and burst-pipe losses."),
            E("PCS catastrophe designations", "Verisk's Property Claim Services numbers industry-wide events above a loss threshold.")
        },
        ["policyholder"] = new[]
        {
            E("A homeowner insured by State Farm or Allstate", "A typical personal-lines policyholder."),
            E("A small business owner with a BOP", "A typical commercial policyholder."),
            E("A municipality insured through a risk pool", "Public entities often pool liability and property risk together."),
            E("A condo association", "A group policyholder that buys a master policy for shared property.")
        },
        ["agent-broker"] = new[]
        {
            E("State Farm and Allstate agents", "Captive agents who sell one carrier's products."),
            E("Marsh McLennan Agency and Aon", "Large brokers that place commercial and specialty risks."),
            E("Gallagher and Brown & Brown", "Major U.S. independent agencies and brokerages."),
            E("Lloyd's brokers", "Specialist brokers who place risks with Lloyd's syndicates.")
        },
        ["insurer"] = new[]
        {
            E("State Farm", "The largest U.S. personal-lines P&C writer by premium."),
            E("Progressive and GEICO", "Large auto insurers known for direct-to-consumer sales."),
            E("Chubb and Travelers", "Major commercial and high-net-worth carriers."),
            E("Berkshire Hathaway Specialty Insurance", "A large specialty arm of Berkshire Hathaway.")
        },
        ["underwriter"] = new[]
        {
            E("Commercial property underwriter at a carrier like Chubb", "Reviews submissions and sets terms for large property risks."),
            E("Lloyd's syndicate underwriters", "Underwrite specialty and catastrophe risks at the Lloyd's market."),
            E("Guidewire PolicyCenter", "A widely used system that supports underwriting rules and referrals."),
            E("Verisk ISO loss-cost data", "Reference data that underwriters use to price and select risks.")
        },
        ["claims-adjuster"] = new[]
        {
            E("Staff adjusters at State Farm and Allstate", "Employee adjusters who handle claims directly."),
            E("Crawford & Company", "A large independent adjusting firm used after catastrophes."),
            E("Sedgwick", "A global claims management and adjusting company."),
            E("Public adjusters", "Licensed adjusters hired by the policyholder, not the insurer.")
        },
        ["reinsurer"] = new[]
        {
            E("Munich Re and Swiss Re", "The two largest reinsurers in the world."),
            E("Hannover Re and SCOR", "Other major global reinsurers."),
            E("Lloyd's of London", "A market where syndicates write a large share of reinsurance."),
            E("Catastrophe bonds", "Insurance-linked securities that move peak risk to capital markets investors.")
        },
        ["regulator"] = new[]
        {
            E("California Department of Insurance", "Regulates rates and market conduct in the largest U.S. state market."),
            E("New York DFS", "The Department of Financial Services supervises insurers licensed in New York."),
            E("NAIC", "The National Association of Insurance Commissioners sets model laws and reporting standards."),
            E("Federal Insurance Office (U.S. Treasury)", "Monitors the industry and advises on federal policy.")
        },
        ["actuary"] = new[]
        {
            E("Casualty Actuarial Society (CAS)", "The professional body for P&C actuaries."),
            E("Milliman and Oliver Wyman", "Consulting firms that provide reserving and pricing analysis."),
            E("Verisk ISO loss costs", "Advisory loss costs that many carriers use in their rate models."),
            E("Chain-ladder method", "A standard technique for projecting ultimate losses from reported data.")
        },
        ["third-party-claimant"] = new[]
        {
            E("A driver injured by an insured driver", "The classic auto liability third-party claimant."),
            E("A customer who slips in an insured store", "A common general liability claim."),
            E("A neighbor whose fence is damaged by an insured's tree", "A homeowners liability property damage claim."),
            E("A pedestrian hit by a delivery van", "A commercial auto bodily injury claim.")
        },
        ["mortgagee-lienholder"] = new[]
        {
            E("Wells Fargo and Rocket Mortgage", "Large mortgage servicers named on homeowners policies."),
            E("Ally Financial and Toyota Financial Services", "Auto lenders listed as lienholders on auto policies."),
            E("Fannie Mae and Freddie Mac", "Set insurance requirements for the loans they back."),
            E("Lender-placed (force-placed) insurance", "Coverage a lender buys when the borrower's policy lapses.")
        },
        ["investors-shareholders"] = new[]
        {
            E("Berkshire Hathaway", "A conglomerate with large P&C holdings including GEICO."),
            E("Progressive Corporation (NYSE: PGR)", "A publicly traded auto insurer."),
            E("Chubb Limited (NYSE: CB)", "A publicly traded global P&C insurer."),
            E("Mutual policyholders", "At mutuals such as State Farm, the policyholders are the owners.")
        },
        ["rating-agency"] = new[]
        {
            E("AM Best", "The rating agency most focused on insurers, with letter grades such as A++ to D."),
            E("S&P Global Ratings", "Publishes insurer financial strength ratings."),
            E("Moody's", "Rates insurers and the debt they issue."),
            E("Fitch Ratings", "Rates insurers and monitors sector outlooks.")
        },
        ["claims-vendors"] = new[]
        {
            E("CCC Intelligent Solutions", "Provides auto damage estimating and total-loss valuation."),
            E("Servpro and ServiceMaster Restore", "Water and fire restoration contractors."),
            E("Copart and IAA", "Salvage auction companies for total-loss vehicles."),
            E("Safelite", "A glass repair and replacement provider used in many auto programs.")
        },
        ["claim-workflow"] = new[]
        {
            E("EagleView aerial roof measurements", "Aerial roof reports that adjusters and contractors use to measure roof size and pitch."),
            E("LexisNexis CLUE claims history", "The claim-history database that insurers check when they price or write a policy."),
            E("Xactimate estimating", "Estimating software used to build line-item repair estimates for property claims."),
            E("Hurricane and hail CAT response", "Catastrophe teams that handle claim surges after large storms, with extended hours and field staff.")
        },
        ["restoration-contractor"] = new[]
        {
            E("SERVPRO franchise network", "A franchised water, fire, and mold restoration network that many insurers use for emergency mitigation."),
            E("ServiceMaster Restore", "A restoration brand that handles water, fire, and storm losses for homeowners and businesses."),
            E("Paul Davis Restoration", "A franchised restoration company that handles fire, water, and storm damage repair."),
            E("Direction to pay", "A document that lets the insurer pay the restoration contractor directly, instead of the policyholder.")
        }
    };

    public static IReadOnlyList<RealWorldExample> For(string slug) =>
        BySlug.TryGetValue(slug, out var list) ? list : Array.Empty<RealWorldExample>();
}
