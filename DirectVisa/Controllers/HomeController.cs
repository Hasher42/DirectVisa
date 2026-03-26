using System.Diagnostics;
using DirectVisa.Models;
using Microsoft.AspNetCore.Mvc;

namespace DirectVisa.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() => View();
        public IActionResult Index2() => View();
        public IActionResult Index3() => View();
        public IActionResult Index4() => View();
        public IActionResult IndexOnePage() => View();
        public IActionResult IndexTwoPage() => View();
        public IActionResult IndexThreePage() => View();
        public IActionResult IndexFourPage() => View();
        public IActionResult About() => View();
        public IActionResult Contact() => View();
        public IActionResult Service() => View();
        public IActionResult ServiceDetails(string? key)
        {
            var serviceKey = string.IsNullOrWhiteSpace(key) ? "visit-visas" : key.Trim().ToLowerInvariant();

            var model = serviceKey switch
            {
                "visit-visas" => new ServiceDetailsViewModel
                {
                    Key = "visit-visas",
                    Title = "Visit Visas",
                    ImageUrl = "/assets/img/service/visit-visas.jpg",
                    Overview = "We provide clear guidance and end-to-end support for UK visit visa applications — from eligibility checks and itinerary planning to document preparation and submission.",
                    Bullets = new[]
                    {
                        "Standard Visitor (tourism/family/business/medical)",
                        "Permitted Paid Engagement",
                        "Short-term study (English language)",
                    }
                },
                "student-graduate" => new ServiceDetailsViewModel
                {
                    Key = "student-graduate",
                    Title = "Student & Graduate",
                    ImageUrl = "/assets/img/service/student-graduate.jpg",
                    Overview = "End-to-end support from CAS to visa, dependants, and post-study options. We help you prepare a consistent application that matches your study plans.",
                    Bullets = new[]
                    {
                        "Student (Child/General)",
                        "Graduate route",
                        "Switching to work routes",
                    }
                },
                "family-settlement" => new ServiceDetailsViewModel
                {
                    Key = "family-settlement",
                    Title = "Family & Settlement",
                    ImageUrl = "/assets/img/service/family-settlement.jpg",
                    Overview = "Join or remain with loved ones and progress to Indefinite Leave to Remain (ILR) and citizenship with clear evidence and well-prepared supporting documents.",
                    Bullets = new[]
                    {
                        "Spouse/Partner (Appendix FM)",
                        "Parent/Child & Adult Dependent Relative",
                        "Fiancé(e)/Proposed Civil Partner",
                        "Family reunion (protection route)",
                        "EU Settlement Scheme family permits",
                        "Long residence ILR (10-year), Naturalisation",
                    }
                },
                "skilled-worker-health-care" => new ServiceDetailsViewModel
                {
                    Key = "skilled-worker-health-care",
                    Title = "Skilled Worker & Health Care",
                    ImageUrl = "/assets/img/service/skilled-worker-health-care.png",
                    Overview = "We support sponsored work routes with eligibility checks, document preparation, and end-to-end submission support for applicants and dependants.",
                    Bullets = new[]
                    {
                        "Skilled Worker",
                        "Health & Care Worker",
                        "Scale-up Worker",
                        "Creative Worker (T5) / Sportsperson",
                        "Skilled Worker Dependant",
                        "ILR on work routes",
                    }
                },
                "business-investment" => new ServiceDetailsViewModel
                {
                    Key = "business-investment",
                    Title = "Business & Investment",
                    ImageUrl = "/assets/img/service/business-investment.png",
                    Overview = "Launch or scale innovative ventures and relocate senior talent to the UK. We guide you through route selection, evidence, and application submission.",
                    Bullets = new[]
                    {
                        "Innovator Founder",
                        "Global Talent (Tech, Arts, Academia)",
                        "Global Business Mobility (all sub-routes)",
                        "UK Ancestry",
                    }
                },
                "temporary-youth-routes" => new ServiceDetailsViewModel
                {
                    Key = "temporary-youth-routes",
                    Title = "Temporary & Youth Routes",
                    ImageUrl = "/assets/img/service/temporary-youth-routes.png",
                    Overview = "Short-term work and cultural exchange routes for individuals and sponsors. We help you understand sponsorship requirements and prepare a compliant application.",
                    Bullets = new[]
                    {
                        "Seasonal Worker",
                        "Government Authorised Exchange",
                        "Charity/Religious Workers",
                        "International Sportsperson",
                        "Youth Mobility Scheme",
                    }
                },
                "appeal-and-reviews" => new ServiceDetailsViewModel
                {
                    Key = "appeal-and-reviews",
                    Title = "Appeal and Reviews",
                    ImageUrl = "/assets/img/service/appeal-and-reviews.png",
                    Overview = "If a decision is refused or contains an error, we can advise on the most suitable remedy and help you prepare a strong case.",
                    Bullets = new[]
                    {
                        "Pre-Action Protocol",
                        "Judicial Review",
                        "Appeals",
                        "Administrative Review",
                    }
                },
                _ => new ServiceDetailsViewModel
                {
                    Key = "visit-visas",
                    Title = "Visit Visas",
                    ImageUrl = "/assets/img/service/visit-visas.jpg",
                    Overview = "We provide clear guidance and end-to-end support for UK visit visa applications — from eligibility checks and itinerary planning to document preparation and submission.",
                    Bullets = new[]
                    {
                        "Standard Visitor (tourism/family/business/medical)",
                        "Permitted Paid Engagement",
                        "Short-term study (English language)",
                    }
                }
            };

            return View(model);
        }
        public IActionResult Country() => View();
        public IActionResult CountryDetails() => View();
        public IActionResult Coaching() => View();
        public IActionResult CoachingDetails() => View();
        public IActionResult Team() => View();
        public IActionResult TeamDetails() => View();
        public IActionResult Faq() => View();
        public IActionResult Error404() => View();
        public IActionResult News() => View();
        public IActionResult NewsGrid() => View();
        public IActionResult NewsDetails() => View();

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
