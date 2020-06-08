using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hafina.Web.Interfaces;
using Hafina.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Hafina.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForecastReportController : ControllerBase
    {
        private readonly IForecastReportViewModelService _forecastReportViewModelService;

        public ForecastReportController(IForecastReportViewModelService forecastReportViewModelService)
        {
            _forecastReportViewModelService = forecastReportViewModelService;
        }

        // GET: api/ForecastReport/ree
        [HttpGet("{companyCode}")]
        public async Task<ActionResult<ForecastReportViewModel>> GetForecastReport(string companyCode)
        {
            var financialReport = await _forecastReportViewModelService.GetForecastReportByCompany(companyCode);

            if (financialReport == null)
            {
                return NotFound();
            }

            return financialReport;
        }
    }
}
