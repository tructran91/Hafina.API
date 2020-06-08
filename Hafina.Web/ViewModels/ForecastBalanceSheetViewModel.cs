using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hafina.Web.ViewModels
{
    public class ForecastBalanceSheetViewModel
    {
        // Tốc độ tăng trưởng tài sản ngắn hạn hàng năm
        public decimal GrowthRateCurrentAssetsYoY { get; set; }

        // Tốc độ tăng trưởng tổng cộng tài sản hàng năm
        public decimal GrowthRateTotalAssetsYoy { get; set; }

        // Tốc độ tăng trưởng nợ ngắn hạn hàng năm
        public decimal GrowthRateShortTermLiabilitiesYoY { get; set; }

        // Tốc độ tăng trưởng nợ dài hạn hàng năm
        public decimal GrowthRateLongTermLiabilitiesYoY { get; set; }

        // Tốc độ tăng trưởng vốn chủ sở hữu hàng năm
        public decimal GrowthRateOwnersEquityYoY { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Duration { get; set; }
    }
}
