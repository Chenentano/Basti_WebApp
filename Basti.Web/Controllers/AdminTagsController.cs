using Basti.Web.Data;
using Basti.Web.Models.Domain;
using Basti.Web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Basti.Web.Controllers
{
    public class AdminTagsController : Controller
    {
        private readonly BastiDbContext bastiDbContext;

        public AdminTagsController(BastiDbContext bastiDbContext)
        {
            this.bastiDbContext = bastiDbContext;
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddTagRequest addTagRequest)
        {
            // Mapping AddTagRequest to Tag domain model
            var tag = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName
            };

            bastiDbContext.Tags.Add(tag);
            bastiDbContext.SaveChanges();

            return View("Add");
        }
    }
}
