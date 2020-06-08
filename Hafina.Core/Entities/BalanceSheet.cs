using System;
using System.ComponentModel.DataAnnotations;

namespace Hafina.Core.Entities
{
    // cân đối kế toán
    public class BalanceSheet : BaseEntity
    {
        [Required]
        public int BalanceSheetId { get; set; }

        // Tài sản ngắn hạn
        public decimal CurrentAssets { get; set; } = 0;

        // Tiền và các khoản tương đương tiền
        public decimal CashAndCashEuivalents { get; set; } = 0;

        // Các khoản đầu tư tài chính ngắn hạn
        public decimal ShortTermFinancialInvestment { get; set; } = 0;

        // Các khoản phải thu ngắn hạn
        public decimal ShortTermAccountReceivables { get; set; } = 0;

        // Hàng tồn kho
        public decimal Inventory { get; set; } = 0;

        // Tài sản ngắn hạn khác
        public decimal OtherCurrentAssets { get; set; } = 0;

        // Tài sản dài hạn
        public decimal LongTermAssets { get; set; } = 0;

        // Các khoản phải thu dài hạn
        public decimal LongTermAccountReceivable { get; set; } = 0;

        // Tài sản cố định
        public decimal FixedAssets { get; set; } = 0;

        // Lợi thế thương mại
        public decimal CommercialAdvantage { get; set; } = 0;

        // Bất động sản đầu tư
        public decimal RealEstateInvestment { get; set; } = 0;

        // Các khoản đầu tư tài chính dài hạn
        public decimal LongTermFinacialInvestments { get; set; } = 0;

        // Tài sản dài hạn khác
        public decimal OtherLongTermAssets { get; set; } = 0;

        // Tổng cộng tài sản
        public decimal TotalAssets { get; set; } = 0;

        // Nợ ngắn hạn
        public decimal ShortTermLiabilities { get; set; } = 0;

        // Nợ dài hạn
        public decimal LongTermLiabilities { get; set; } = 0;

        // Vốn chủ sở hữu
        public decimal OwnersEquity { get; set; } = 0;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Duration { get; set; }

        public int CompanyId { get; set; }

        public Company Company { get; set; }
    }
}
