using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hafina.Core.Entities;
using Hafina.Infrastructure.Data;
using Hafina.Web.Interfaces;
using Hafina.Web.ViewModels;

namespace Hafina.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinancialReportController : ControllerBase
    {
        private readonly IFinancialReportViewModelService _financialReportViewModelService;

        public FinancialReportController(IFinancialReportViewModelService financialReportViewModelService)
        {
            _financialReportViewModelService = financialReportViewModelService;
        }

        // GET: api/FinancialReport/ree
        [HttpGet("{companyCode}")]
        public async Task<ActionResult<FinancialReportViewModel>> GetFinancialReport(string companyCode, string type = "quarter", int page = 0)
        {
            var financialReport = await _financialReportViewModelService.GetFinancialReportByCompany(companyCode, type, page, Constants.QUARTER_PER_COMPANY);

            if (financialReport == null)
            {
                return NotFound();
            }

            return financialReport;
        }
    }
}
