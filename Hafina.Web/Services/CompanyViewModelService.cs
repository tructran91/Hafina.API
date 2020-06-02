using AutoMapper;
using Hafina.Core.Entities;
using Hafina.Core.Interfaces;
using Hafina.Web.Interfaces;
using Hafina.Web.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hafina.Web.Services
{
    public class CompanyViewModelService : ICompanyViewModelService
    {
        private readonly IRepository<Company> _companyRepository;
        private readonly IMapper _mapper;

        public CompanyViewModelService(IRepository<Company> companyRepository,
            IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public async Task<List<CompanyViewModel>> GetCompanies()
        {
            var companies = await _companyRepository.Query(t => !t.IsDeleted).ToListAsync();

            var vm = (companies == null) ? null : _mapper.Map<List<CompanyViewModel>>(companies);

            return vm;
        }

        public async Task<CompanyViewModel> GetCompany(string companyCode)
        {
            var company = await _companyRepository.Query(t => t.Code == companyCode && !t.IsDeleted).FirstOrDefaultAsync();

            var vm = (company == null) ? null : _mapper.Map<CompanyViewModel>(company);

            return vm;
        }
    }
}
