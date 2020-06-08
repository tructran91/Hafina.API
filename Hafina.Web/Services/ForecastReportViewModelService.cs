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
    public class ForecastReportViewModelService : IForecastReportViewModelService
    {
        private readonly IRepository<BusinessResult> _businessResultRepository;
        private readonly IRepository<BalanceSheet> _balanceSheetRepository;
        private readonly IMapper _mapper;

        public ForecastReportViewModelService(IRepository<BusinessResult> businessResultRepository,
            IRepository<BalanceSheet> balanceSheetRepository,
            IMapper mapper)
        {
            _businessResultRepository = businessResultRepository;
            _balanceSheetRepository = balanceSheetRepository;
            _mapper = mapper;
        }

        public async Task<ForecastReportViewModel> GetForecastReportByCompany(string companyCode)
        {
            var businessResults = await _businessResultRepository.Query(t => t.Company.Code == companyCode && (t.EndDate.Month - t.StartDate.Month == 11) && !t.IsDeleted)
                .OrderByDescending(t => t.StartDate)
                .Take(5)
                .ToListAsync();
            var balanceSheets = await _balanceSheetRepository.Query(t => t.Company.Code == companyCode && (t.EndDate.Month - t.StartDate.Month == 11) && !t.IsDeleted)
                .OrderByDescending(t => t.StartDate)
                .Take(5)
                .ToListAsync();

            var forecastBusinessResults = CalculateForecastBusinessResult(businessResults);
            var forecastBalanceSheets = CalculateForecastBalanceSheet(balanceSheets);

            var vm = new ForecastReportViewModel()
            {
                ForecastBusinessResults = _mapper.Map<List<ForecastBusinessResultViewModel>>(forecastBusinessResults).OrderBy(t => t.StartDate),
                ForecastBalanceSheets = _mapper.Map<List<ForecastBalanceSheetViewModel>>(forecastBalanceSheets).OrderBy(t => t.StartDate)
            };

            return vm;
        }

        private List<ForecastBusinessResultViewModel> CalculateForecastBusinessResult(List<BusinessResult> businessResults)
        {
            var forecastBusinessResults = new List<ForecastBusinessResultViewModel>();
            for (int i = 0; i < businessResults.Count - 1; i++)
            {
                var forecast = new ForecastBusinessResultViewModel();
                var businessResultAfter = businessResults[i];
                var businessResultBefore = businessResults[i + 1];

                forecast.GrowthRateSalesOfGoodsAndServicesYoY = Math.Round((businessResultAfter.SalesOfGoodsAndServices - businessResultBefore.SalesOfGoodsAndServices) / businessResultAfter.SalesOfGoodsAndServices * 100, 4);
                forecast.GrowthRateCostOfGoodsSoldYoY = Math.Round((businessResultAfter.CostOfGoodsSold - businessResultBefore.CostOfGoodsSold) / businessResultAfter.CostOfGoodsSold * 100, 4);
                forecast.GrowthRateGrossProfitOfGoodsAndServicesYoY = Math.Round((businessResultAfter.GrossProfitOfGoodsAndServices - businessResultBefore.GrossProfitOfGoodsAndServices) / businessResultAfter.GrossProfitOfGoodsAndServices * 100, 4);
                forecast.GrowthRateOtherProfitsYoY = Math.Round((businessResultAfter.OtherProfits - businessResultBefore.OtherProfits) / businessResultAfter.OtherProfits * 100, 4);
                forecast.GrowthRateAccountingProfitBeforeTaxYoY = Math.Round((businessResultAfter.AccountingProfitBeforeTax - businessResultBefore.AccountingProfitBeforeTax) / businessResultAfter.AccountingProfitBeforeTax * 100, 4);
                forecast.GrowthRateProfitAfterTaxCorporateIncomeYoY = Math.Round((businessResultAfter.ProfitAfterTaxCorporateIncome - businessResultBefore.ProfitAfterTaxCorporateIncome) / businessResultAfter.ProfitAfterTaxCorporateIncome * 100, 4);

                forecast.Duration = businessResultAfter.Duration;
                forecast.StartDate = businessResultAfter.StartDate;
                forecast.EndDate = businessResultAfter.EndDate;

                forecastBusinessResults.Add(forecast);
            }
            return forecastBusinessResults;
        }

        private List<ForecastBalanceSheetViewModel> CalculateForecastBalanceSheet(List<BalanceSheet> balanceSheets)
        {
            var forecastBalanceSheets = new List<ForecastBalanceSheetViewModel>();
            for (int i = 0; i < balanceSheets.Count - 1; i++)
            {
                var forecast = new ForecastBalanceSheetViewModel();
                var balanceSheetAfter = balanceSheets[i];
                var balanceSheetBefore = balanceSheets[i + 1];

                forecast.GrowthRateCurrentAssetsYoY = Math.Round((balanceSheetAfter.CurrentAssets - balanceSheetBefore.CurrentAssets) / balanceSheetAfter.CurrentAssets * 100, 4);
                forecast.GrowthRateTotalAssetsYoy = Math.Round((balanceSheetAfter.TotalAssets - balanceSheetBefore.TotalAssets) / balanceSheetAfter.TotalAssets * 100, 4);
                forecast.GrowthRateShortTermLiabilitiesYoY = Math.Round((balanceSheetAfter.ShortTermLiabilities - balanceSheetBefore.ShortTermLiabilities) / balanceSheetAfter.ShortTermLiabilities * 100, 4);
                forecast.GrowthRateLongTermLiabilitiesYoY = Math.Round((balanceSheetAfter.LongTermLiabilities - balanceSheetBefore.LongTermLiabilities) / balanceSheetAfter.LongTermLiabilities * 100, 4);
                forecast.GrowthRateOwnersEquityYoY = Math.Round((balanceSheetAfter.OwnersEquity - balanceSheetBefore.OwnersEquity) / balanceSheetAfter.OwnersEquity * 100, 4);

                forecast.Duration = balanceSheetAfter.Duration;
                forecast.StartDate = balanceSheetAfter.StartDate;
                forecast.EndDate = balanceSheetAfter.EndDate;

                forecastBalanceSheets.Add(forecast);
            }
            return forecastBalanceSheets;
        }
    }
}
