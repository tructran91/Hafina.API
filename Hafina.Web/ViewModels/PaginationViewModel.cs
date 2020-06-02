using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hafina.Web.ViewModels
{
    public class PaginationViewModel
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int ActualPage { get; set; }
        public int TotalPages { get; set; }
        public bool IsPrevious { get; set; }
        public bool IsNext { get; set; }
    }
}
