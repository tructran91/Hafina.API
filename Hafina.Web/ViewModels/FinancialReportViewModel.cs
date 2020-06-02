using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hafina.Web.ViewModels
{
    public class FinancialReportViewModel
    {
        public IEnumerable<BusinessResultViewModel> BusinessResults { get; set; }
        public IEnumerable<BalanceSheetViewModel> BalanceSheets { get; set; }
        public PaginationViewModel Pagination { get; set; }
    }
}
