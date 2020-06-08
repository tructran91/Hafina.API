using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hafina.Web.ViewModels
{
    public class ForecastReportViewModel
    {
        public IEnumerable<ForecastBusinessResultViewModel> ForecastBusinessResults { get; set; }
        public IEnumerable<ForecastBalanceSheetViewModel> ForecastBalanceSheets { get; set; }
    }
}
