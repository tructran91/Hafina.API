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
                .Take(4)
                .ToListAsync();
            var balanceSheets = await _balanceSheetRepository.Query(t => t.Company.Code == companyCode && (t.EndDate.Month - t.StartDate.Month == 11) && !t.IsDeleted)
                .OrderByDescending(t => t.StartDate)
                .Take(4)
                .ToListAsync();

            var forecastBusinessResults = CalculateAverageIndicatorsBusinessResult(businessResults);
            var forecastBalanceSheets = CalculateAverageIndicatorsBalanceSheet(balanceSheets);

            var vm = new ForecastReportViewModel()
            {
                IndicatorsBalanceSheet = forecastBalanceSheets,
                IndicatorsBusinessResult = forecastBusinessResults,
                LatestBalanceSheetByAnnual = _mapper.Map<BalanceSheetViewModel>(balanceSheets.FirstOrDefault()),
                LatestBusinessResultByAnnual = _mapper.Map<BusinessResultViewModel>(businessResults.FirstOrDefault())
            };

            return vm;
        }

        private ForecastBusinessResultViewModel CalculateAverageIndicatorsBusinessResult(List<BusinessResult> businessResults)
        {
            var forecastBusinessResults = new List<ForecastBusinessResultViewModel>();
            var averageIndicators = new ForecastBusinessResultViewModel();
            for (int i = 0; i < businessResults.Count - 1; i++)
            {
                var forecast = new ForecastBusinessResultViewModel();
                var businessResultAfter = businessResults[i];
                var businessResultBefore = businessResults[i + 1];

                forecast.GrowthRateSalesOfGoodsAndServicesYoY = (businessResultAfter.SalesOfGoodsAndServices - businessResultBefore.SalesOfGoodsAndServices) / businessResultAfter.SalesOfGoodsAndServices * 100;
                forecast.GrowthRateCostOfGoodsSoldYoY = (businessResultAfter.CostOfGoodsSold - businessResultBefore.CostOfGoodsSold) / businessResultAfter.CostOfGoodsSold * 100;
                forecast.GrowthRateGrossProfitOfGoodsAndServicesYoY = (businessResultAfter.GrossProfitOfGoodsAndServices - businessResultBefore.GrossProfitOfGoodsAndServices) / businessResultAfter.GrossProfitOfGoodsAndServices * 100;
                forecast.GrowthRateOtherProfitsYoY = (businessResultAfter.OtherProfits - businessResultBefore.OtherProfits) / businessResultAfter.OtherProfits * 100;
                forecast.GrowthRateAccountingProfitBeforeTaxYoY = (businessResultAfter.AccountingProfitBeforeTax - businessResultBefore.AccountingProfitBeforeTax) / businessResultAfter.AccountingProfitBeforeTax * 100;
                forecast.GrowthRateProfitAfterTaxCorporateIncomeYoY = (businessResultAfter.ProfitAfterTaxCorporateIncome - businessResultBefore.ProfitAfterTaxCorporateIncome) / businessResultAfter.ProfitAfterTaxCorporateIncome * 100;

                forecastBusinessResults.Add(forecast);

                averageIndicators.GrowthRateSalesOfGoodsAndServicesYoY += forecast.GrowthRateSalesOfGoodsAndServicesYoY;
                averageIndicators.GrowthRateCostOfGoodsSoldYoY += forecast.GrowthRateCostOfGoodsSoldYoY;
                averageIndicators.GrowthRateGrossProfitOfGoodsAndServicesYoY += forecast.GrowthRateGrossProfitOfGoodsAndServicesYoY;
                averageIndicators.GrowthRateOtherProfitsYoY += forecast.GrowthRateOtherProfitsYoY;
                averageIndicators.GrowthRateAccountingProfitBeforeTaxYoY += forecast.GrowthRateAccountingProfitBeforeTaxYoY;
                averageIndicators.GrowthRateProfitAfterTaxCorporateIncomeYoY += forecast.GrowthRateProfitAfterTaxCorporateIncomeYoY;
            }
            averageIndicators.GrowthRateSalesOfGoodsAndServicesYoY = Math.Round(averageIndicators.GrowthRateSalesOfGoodsAndServicesYoY / forecastBusinessResults.Count, 4);
            averageIndicators.GrowthRateCostOfGoodsSoldYoY = Math.Round(averageIndicators.GrowthRateCostOfGoodsSoldYoY / forecastBusinessResults.Count, 4);
            averageIndicators.GrowthRateGrossProfitOfGoodsAndServicesYoY = Math.Round(averageIndicators.GrowthRateGrossProfitOfGoodsAndServicesYoY / forecastBusinessResults.Count, 4);
            averageIndicators.GrowthRateOtherProfitsYoY = Math.Round(averageIndicators.GrowthRateOtherProfitsYoY / forecastBusinessResults.Count, 4);
            averageIndicators.GrowthRateAccountingProfitBeforeTaxYoY = Math.Round(averageIndicators.GrowthRateAccountingProfitBeforeTaxYoY / forecastBusinessResults.Count, 4);
            averageIndicators.GrowthRateProfitAfterTaxCorporateIncomeYoY = Math.Round(averageIndicators.GrowthRateProfitAfterTaxCorporateIncomeYoY / forecastBusinessResults.Count, 4);

            return averageIndicators;
        }

        private ForecastBalanceSheetViewModel CalculateAverageIndicatorsBalanceSheet(List<BalanceSheet> balanceSheets)
        {
            var forecastBalanceSheets = new List<ForecastBalanceSheetViewModel>();
            var averageIndicators = new ForecastBalanceSheetViewModel();
            for (int i = 0; i < balanceSheets.Count - 1; i++)
            {
                var forecast = new ForecastBalanceSheetViewModel();
                var balanceSheetAfter = balanceSheets[i];
                var balanceSheetBefore = balanceSheets[i + 1];

                forecast.GrowthRateCurrentAssetsYoY = (balanceSheetAfter.CurrentAssets - balanceSheetBefore.CurrentAssets) / balanceSheetAfter.CurrentAssets * 100;
                forecast.GrowthRateTotalAssetsYoy = (balanceSheetAfter.TotalAssets - balanceSheetBefore.TotalAssets) / balanceSheetAfter.TotalAssets * 100;
                forecast.GrowthRateShortTermLiabilitiesYoY = (balanceSheetAfter.ShortTermLiabilities - balanceSheetBefore.ShortTermLiabilities) / balanceSheetAfter.ShortTermLiabilities * 100;
                forecast.GrowthRateLongTermLiabilitiesYoY = (balanceSheetAfter.LongTermLiabilities - balanceSheetBefore.LongTermLiabilities) / balanceSheetAfter.LongTermLiabilities * 100;
                forecast.GrowthRateOwnersEquityYoY = (balanceSheetAfter.OwnersEquity - balanceSheetBefore.OwnersEquity) / balanceSheetAfter.OwnersEquity * 100;

                forecastBalanceSheets.Add(forecast);

                averageIndicators.GrowthRateCurrentAssetsYoY += forecast.GrowthRateCurrentAssetsYoY;
                averageIndicators.GrowthRateTotalAssetsYoy += forecast.GrowthRateTotalAssetsYoy;
                averageIndicators.GrowthRateShortTermLiabilitiesYoY += forecast.GrowthRateShortTermLiabilitiesYoY;
                averageIndicators.GrowthRateLongTermLiabilitiesYoY += forecast.GrowthRateLongTermLiabilitiesYoY;
                averageIndicators.GrowthRateOwnersEquityYoY += forecast.GrowthRateOwnersEquityYoY;
            }
            averageIndicators.GrowthRateCurrentAssetsYoY = Math.Round(averageIndicators.GrowthRateCurrentAssetsYoY / forecastBalanceSheets.Count, 4);
            averageIndicators.GrowthRateTotalAssetsYoy = Math.Round(averageIndicators.GrowthRateTotalAssetsYoy / forecastBalanceSheets.Count, 4);
            averageIndicators.GrowthRateShortTermLiabilitiesYoY = Math.Round(averageIndicators.GrowthRateShortTermLiabilitiesYoY / forecastBalanceSheets.Count, 4);
            averageIndicators.GrowthRateLongTermLiabilitiesYoY = Math.Round(averageIndicators.GrowthRateLongTermLiabilitiesYoY / forecastBalanceSheets.Count, 4);
            averageIndicators.GrowthRateOwnersEquityYoY = Math.Round(averageIndicators.GrowthRateOwnersEquityYoY / forecastBalanceSheets.Count, 4);

            return averageIndicators;
        }
    }
}
