using Microsoft.AspNetCore.Mvc;

namespace Readery.Components
{
    public class PaginationViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int currentPage, int totalPages)
        {
            var model = new PaginationModel()
            {
                CurrentPage = currentPage,
                TotalPages = totalPages
            };

            return View(model);
        }
    }

    public class PaginationModel
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
