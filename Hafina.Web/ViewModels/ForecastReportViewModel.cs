using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hafina.Web.ViewModels
{
    public class ForecastReportViewModel
    {
        public ForecastBusinessResultViewModel IndicatorsBusinessResult { get; set; }

        public ForecastBalanceSheetViewModel IndicatorsBalanceSheet { get; set; }

        public BusinessResultViewModel LatestBusinessResultByAnnual { get; set; }

        public BalanceSheetViewModel LatestBalanceSheetByAnnual { get; set; }
    }
}
