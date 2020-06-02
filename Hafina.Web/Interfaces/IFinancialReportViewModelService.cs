using Hafina.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hafina.Web.Interfaces
{
    public interface IFinancialReportViewModelService
    {
        Task<FinancialReportViewModel> GetFinancialReportByCompany(string companyCode, string type, int pageIndex, int itemsPage);
    }
}
