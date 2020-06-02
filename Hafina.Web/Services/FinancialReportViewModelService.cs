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
    public class FinancialReportViewModelService : IFinancialReportViewModelService
    {
        private readonly IRepository<BusinessResult> _businessResultRepository;
        private readonly IRepository<BalanceSheet> _balanceSheetRepository;
        private readonly IMapper _mapper;

        public FinancialReportViewModelService(IRepository<BusinessResult> businessResultRepository,
            IRepository<BalanceSheet> balanceSheetRepository,
            IMapper mapper)
        {
            _businessResultRepository = businessResultRepository;
            _balanceSheetRepository = balanceSheetRepository;
            _mapper = mapper;
        }

        public async Task<FinancialReportViewModel> GetFinancialReportByCompany(string companyCode, string type, int pageIndex, int itemsPage)
        {
            var businessResultQuery = _businessResultRepository.Query(t => t.Company.Code == companyCode && (type == "year" ? (t.EndDate.Month - t.StartDate.Month) == 11 : (t.EndDate.Month - t.StartDate.Month) == 2) && !t.IsDeleted);
            var businessResults = await businessResultQuery
                .OrderByDescending(t => t.StartDate)
                .Skip(itemsPage * pageIndex)
                .Take(itemsPage)
                .ToListAsync();
            var balanceSheets = await _balanceSheetRepository.Query(t => t.Company.Code == companyCode && (type == "year" ? (t.EndDate.Month - t.StartDate.Month) == 11 : (t.EndDate.Month - t.StartDate.Month) == 2) && !t.IsDeleted)
                .OrderByDescending(t => t.StartDate)
                .Skip(itemsPage * pageIndex)
                .Take(itemsPage)
                .ToListAsync();

            var totalItems = businessResultQuery.Count();

            var vm = new FinancialReportViewModel()
            {
                BusinessResults = _mapper.Map<List<BusinessResultViewModel>>(businessResults).OrderBy(t => t.StartDate),
                BalanceSheets = _mapper.Map<List<BalanceSheetViewModel>>(balanceSheets).OrderBy(t => t.StartDate),
                Pagination = new PaginationViewModel()
                {
                    ActualPage = pageIndex,
                    ItemsPerPage = businessResults.Count,
                    TotalItems = totalItems,
                    TotalPages = int.Parse(Math.Ceiling(((decimal)totalItems / itemsPage)).ToString())
                }
            };
            vm.Pagination.IsNext = (vm.Pagination.ActualPage == vm.Pagination.TotalPages - 1) ? false : true;
            vm.Pagination.IsPrevious = (vm.Pagination.ActualPage == 0) ? false : true;

            return vm;
        }
    }
}
