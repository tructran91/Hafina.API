using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hafina.Web.ViewModels
{
    public class BalanceSheetViewModel
    {
        public int BalanceSheetId { get; set; }

        // Tài sản ngắn hạn
        public decimal CurrentAssets { get; set; }

        // Tiền và các khoản tương đương tiền
        public decimal CashAndCashEuivalents { get; set; }

        // Các khoản đầu tư tài chính ngắn hạn
        public decimal ShortTermFinancialInvestment { get; set; }

        // Các khoản phải thu ngắn hạn
        public decimal ShortTermAccountReceivables { get; set; }

        // Hàng tồn kho
        public decimal Inventory { get; set; }

        // Tài sản ngắn hạn khác
        public decimal OtherCurrentAssets { get; set; }

        // Tài sản dài hạn
        public decimal LongTermAssets { get; set; }

        // Các khoản phải thu dài hạn
        public decimal LongTermAccountReceivable { get; set; }

        // Tài sản cố định
        public decimal FixedAssets { get; set; }

        // Lợi thế thương mại
        public decimal CommercialAdvantage { get; set; }

        // Bất động sản đầu tư
        public decimal RealEstateInvestment { get; set; }

        // Các khoản đầu tư tài chính dài hạn
        public decimal LongTermFinacialInvestments { get; set; }

        // Tài sản dài hạn khác
        public decimal OtherLongTermAssets { get; set; }

        // Tổng cộng tài sản
        public decimal TotalAssets { get; set; }

        // Nợ ngắn hạn
        public decimal ShortTermLiabilities { get; set; }

        // Nợ dài hạn
        public decimal LongTermLiabilities { get; set; }

        // Vốn chủ sở hữu
        public decimal OwnersEquity { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Duration { get; set; }
    }
}
