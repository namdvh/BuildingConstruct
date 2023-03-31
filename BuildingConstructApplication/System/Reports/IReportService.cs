using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.MaterialStore;
using ViewModels.Pagination;

namespace Application.System.Reports
{
    public interface IReportService
    {
        Task<BasePagination<List<ReportProductDTO>>> GetAllReportProduct(PaginationFilter filter, Guid userId);

        Task<bool> ReportProduct(int productId);
    }
}
