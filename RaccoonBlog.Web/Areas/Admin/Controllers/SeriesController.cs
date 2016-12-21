using System.Linq;
using System.Net;
using System.Web.Mvc;
using RaccoonBlog.Web.Helpers.Attributes;
using RaccoonBlog.Web.Models;

namespace RaccoonBlog.Web.Areas.Admin.Controllers
{
    public partial class SeriesController : AdminController
    {
        public virtual ActionResult Index()
        {
            var seriess = RavenSession.Query<Series>()
                .OrderBy(x => x.Id)
                .ToList();

            return View("List", seriess);
        }

        [HttpGet]
        public virtual ActionResult Add()
        {
            return View("Edit", new Series());
        }

        [HttpGet]
        public virtual ActionResult Edit(string id)
        {
            var series = RavenSession.Load<Series>(id);
            if (series == null)
                return HttpNotFound("Series does not exist.");

            return View(series);
        }

        [HttpPost]
        public virtual ActionResult Activate(string id, bool activate)
        {
            var series = RavenSession.Load<Series>(id);
            if (series == null)
                return HttpNotFound("Series does not exist.");



            OutputCacheManager.RemoveItems(MVC.Series.Name);

            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        [HttpPost]
        public virtual ActionResult Update(Series series)
        {
            if (!ModelState.IsValid)
                return View("Edit", series);

            RavenSession.Store(series);

            OutputCacheManager.RemoveItems(MVC.Series.Name);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public virtual ActionResult Delete(string id)
        {
            var series = RavenSession.Load<Series>(id);
            if (series == null)
                return HttpNotFound("Series does not exist.");

            RavenSession.Delete(series);

            OutputCacheManager.RemoveItems(MVC.Series.Name);

            if (Request.IsAjaxRequest())
            {
                return Json(new { Success = true });
            }
            return RedirectToAction("Index");
        }

        [AjaxOnly]
        [HttpPost]
        public virtual ActionResult SetPosition(string id, int newPosition)
        {
            var series = RavenSession.Load<Series>(id);
            if (series == null)
                return Json(new { success = false, message = string.Format("There is no post with id {0}", id) });


            OutputCacheManager.RemoveItems(MVC.Series.Name);

            return Json(new { success = true });
        }
    }
}
