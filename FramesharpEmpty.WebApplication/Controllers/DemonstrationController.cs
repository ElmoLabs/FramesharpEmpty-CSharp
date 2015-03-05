using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Framesharp.DomainService;
using Framesharp.Presentation.Web.Mvc;
using FramesharpEmpty.DomainService.Interfaces;

namespace FramesharpEmpty.WebApplication.Controllers
{
    public class DemonstrationController : BaseController
    {
        private readonly IDemonstrationDomainService _demonstrationDomainService;

        public DemonstrationController()
        {
            _demonstrationDomainService = DomainServiceFactory.Get<IDemonstrationDomainService>(OperationCallContext);
        }

        [HttpGet]
        public ActionResult Index()
        {
            Models.Demonstration demonstration = _demonstrationDomainService.GetDemonstration(1);

            return View(demonstration);
        }
    }
}
