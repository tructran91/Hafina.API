using System;
using System.ComponentModel.DataAnnotations;

namespace Hafina.Core.Entities
{
    // Kết quả kinh doanh
    public class BusinessResult : BaseEntity
    {
        [Required]
        public int BusinessResultId { get; set; }

        // Doanh thu bán hàng và cung cấp dịch vụ
        public decimal SalesOfGoodsAndServices { get; set; } = 0;

        // Các khoản giảm trừ doanh thu
        public decimal DeductibleRevenue { get; set; } = 0;

        // Doanh thu thuần về bán hàng và cung cấp dịch vụ
        public decimal NetSalesOfGoodsAndServices { get; set; } = 0;

        // Giá vốn hàng bán
        public decimal CostOfGoodsSold { get; set; } = 0;

        // Lợi nhuận gộp về bán hàng và cung cấp dịch vụ
        public decimal GrossProfitOfGoodsAndServices { get; set; } = 0;

        // Doanh thu hoạt động tài chính
        public decimal RevenueFromFinancialActivities { get; set; } = 0;

        // Chi phí tài chính
        public decimal FinancialExpenses { get; set; } = 0;

        // Chi phí lãi vay
        public decimal InterestExpenses { get; set; } = 0;

        // Phần lãi lỗ hoặc lỗ trong công ty liên doanh, liên kết
        public decimal ProfitOrLossInJointVenturesOrAssociates { get; set; } = 0;

        // Chi phí bán hàng
        public decimal SellingExpenses { get; set; } = 0;

        // Chi phí quản lý doanh nghiệp
        public decimal EnterpriseCostManagement { get; set; } = 0;

        // Lợi nhuận thuần từ hoạt động kinh doanh
        public decimal NetProfitFromBusinessActivities { get; set; } = 0;

        // Thu nhập khác
        public decimal OtherIncome { get; set; } = 0;

        // Chi phí khác
        public decimal OtherCosts { get; set; } = 0;

        // Lợi nhuận khác
        public decimal OtherProfits { get; set; } = 0;

        // Tổng lợi nhuận kế toán trước thuế
        public decimal AccountingProfitBeforeTax { get; set; } = 0;

        // Chi phí thuế TNDN hiện hành
        public decimal CurrentCorporateIncomeTaxExpense { get; set; } = 0;

        // Chi phí thuế TNDN hoãn lại
        public decimal DeferredCorporateIncomeTaxExpense { get; set; } = 0;

        // Lợi nhuận sau thuế thu nhập doanh nghiệp
        public decimal ProfitAfterTaxCorporateIncome { get; set; } = 0;

        // Lợi ích của cổ đông thiểu số
        public decimal BenefitsOfMinorityShareholders { get; set; } = 0;

        // Lợi nhuận sau thuế của công ty mẹ
        public decimal ProfitAfterTaxOfTheParentCompany { get; set; } = 0;

        // Lãi cơ bản trên cổ phiếu
        public decimal BasicEarningsPerShare { get; set; } = 0;

        // Lãi suy giảm trên cổ phiếu
        public decimal DeclineEarningsPerShare { get; set; } = 0;

        // Cổ tức
        public decimal Dividend { get; set; } = 0;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Duration { get; set; }

        public int CompanyId { get; set; }

        public Company Company { get; set; }
    }
}
