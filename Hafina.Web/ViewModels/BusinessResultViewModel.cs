using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hafina.Web.ViewModels
{
    public class BusinessResultViewModel
    {
        public int BusinessResultId { get; set; }

        // Doanh thu bán hàng và cung cấp dịch vụ
        public decimal SalesOfGoodsAndServices { get; set; }

        // Các khoản giảm trừ doanh thu
        public decimal DeductibleRevenue { get; set; }

        // Doanh thu thuần về bán hàng và cung cấp dịch vụ
        public decimal NetSalesOfGoodsAndServices { get; set; }

        // Giá vốn hàng bán
        public decimal CostOfGoodsSold { get; set; }

        // Lợi nhuận gộp về bán hàng và cung cấp dịch vụ
        public decimal GrossProfitOfGoodsAndServices { get; set; }

        // Doanh thu hoạt động tài chính
        public decimal RevenueFromFinancialActivities { get; set; }

        // Chi phí tài chính
        public decimal FinancialExpenses { get; set; }

        // Chi phí lãi vay
        public decimal InterestExpenses { get; set; }

        // Phần lãi lỗ hoặc lỗ trong công ty liên doanh, liên kết
        public decimal ProfitOrLossInJointVenturesOrAssociates { get; set; }

        // Chi phí bán hàng
        public decimal SellingExpenses { get; set; }

        // Chi phí quản lý doanh nghiệp
        public decimal EnterpriseCostManagement { get; set; }

        // Lợi nhuận thuần từ hoạt động kinh doanh
        public decimal NetProfitFromBusinessActivities { get; set; }

        // Thu nhập khác
        public decimal OtherIncome { get; set; }

        // Chi phí khác
        public decimal OtherCosts { get; set; }

        // Lợi nhuận khác
        public decimal OtherProfits { get; set; }

        // Tổng lợi nhuận kế toán trước thuế
        public decimal AccountingProfitBeforeTax { get; set; }

        // Chi phí thuế TNDN hiện hành
        public decimal CurrentCorporateIncomeTaxExpense { get; set; }

        // Chi phí thuế TNDN hoãn lại
        public decimal DeferredCorporateIncomeTaxExpense { get; set; }

        // Lợi nhuận sau thuế thu nhập doanh nghiệp
        public decimal ProfitAfterTaxCorporateIncome { get; set; }

        // Lợi ích của cổ đông thiểu số
        public decimal BenefitsOfMinorityShareholders { get; set; }

        // Lợi nhuận sau thuế của công ty mẹ
        public decimal ProfitAfterTaxOfTheParentCompany { get; set; }

        // Lãi cơ bản trên cổ phiếu
        public decimal BasicEarningsPerShare { get; set; }

        // Lãi suy giảm trên cổ phiếu
        public decimal DeclineEarningsPerShare { get; set; }

        // Cổ tức
        public decimal Dividend { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Duration { get; set; }
    }
}
