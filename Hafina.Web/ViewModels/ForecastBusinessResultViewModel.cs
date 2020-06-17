using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hafina.Web.ViewModels
{
    public class ForecastBusinessResultViewModel
    {
        // Tốc độ tăng trưởng doanh thu bán hàng và cung cấp dịch vụ hàng năm
        public decimal GrowthRateSalesOfGoodsAndServicesYoY { get; set; }

        // Tốc độ tăng trưởng giá vốn hàng bán hàng năm
        public decimal GrowthRateCostOfGoodsSoldYoY { get; set; }

        // Tốc độ tăng trưởng lợi nhuận gộp về bán hàng và cung cấp dịch vụ hàng năm
        public decimal GrowthRateGrossProfitOfGoodsAndServicesYoY { get; set; }

        // Tốc độ tăng trưởng lợi nhuận khác hàng năm
        public decimal GrowthRateOtherProfitsYoY { get; set; }

        // Tốc độ tăng trưởng tổng lợi nhuận kế toán trước thuế hàng năm
        public decimal GrowthRateAccountingProfitBeforeTaxYoY { get; set; }

        // Tốc độ tăng trưởng lợi nhuận sau thuế thu nhập doanh nghiệp hàng năm
        public decimal GrowthRateProfitAfterTaxCorporateIncomeYoY { get; set; }

        public string Duration { get; set; }
    }
}
