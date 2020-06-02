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
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyViewModelService _companyViewModelService;

        public CompanyController(ICompanyViewModelService companyViewModelService)
        {
            _companyViewModelService = companyViewModelService;
        }

        // GET: api/Companies
        [HttpGet]
        public async Task<ActionResult<List<CompanyViewModel>>> GetCompanies()
        {
            return await _companyViewModelService.GetCompanies();
        }

        // GET: api/Company/ree
        [HttpGet("{companyCode}")]
        public async Task<ActionResult<CompanyViewModel>> GetCompany(string companyCode)
        {
            var company = await _companyViewModelService.GetCompany(companyCode);

            if (company == null)
            {
                return NotFound();
            }

            return company;
        }
    }
}
