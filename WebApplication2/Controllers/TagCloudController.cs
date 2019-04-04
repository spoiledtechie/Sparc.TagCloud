namespace WebExample.Controllers
{
    using System.Web.Mvc;
    using Sparc.TagCloud;
    using WebApplication2.Properties;

    public class TagCloudController : Controller
    {
        public ActionResult Index()
        {
            var phrases = new string[] { Resources.CloudInput};
            var model = new TagCloudAnalyzer()
                .ComputeTagCloud(phrases)
                .Shuffle();
            return View(model);
        }
    }
}
