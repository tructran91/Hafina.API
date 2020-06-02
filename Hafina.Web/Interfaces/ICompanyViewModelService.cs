using Hafina.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hafina.Web.Interfaces
{
    public interface ICompanyViewModelService
    {
        Task<List<CompanyViewModel>> GetCompanies();

        Task<CompanyViewModel> GetCompany(string companyCode);
    }
}
