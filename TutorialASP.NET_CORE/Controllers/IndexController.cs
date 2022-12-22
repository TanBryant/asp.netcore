using Microsoft.AspNetCore.Mvc;
using TutorialASP.NET_CORE.Models;

namespace TutorialASP.NET_CORE.Controllers
{
	public class IndexController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult W(int a,int b)
		{
			int c = a + b;
			ViewData["c"] = c;
			/*ViewData["id"] = idd;*/
			return View();
		}

		public IActionResult Add(int a, int b) 
		{
			int result = a + b;
            MathViewModel math = new MathViewModel
            {
				a = a,
				b = b,
                result = result,
			};
			ViewData["a"] = a;
            ViewData["b"] = b;
			ViewData["result"] = result;
            return View(math);
		}

		public IActionResult List()
		{
			LopHocViewModel model = new LopHocViewModel
			{
				ListLopHoc = new List<Data.LopHoc> 
				{ 
					new Data.LopHoc() 
					{ 
						Id=1, TenLopHoc="CNTTK18"
					},

                    new Data.LopHoc()
                    {
                        Id=1, TenLopHoc="CNTTK19"
                    },

                    new Data.LopHoc()
                    {
                        Id=1, TenLopHoc="CNTTK20"
                    },

                    new Data.LopHoc()
                    {
                        Id=1, TenLopHoc="CNTTK21"
                    },
                }
			};
			return View(model);
		}
		public IActionResult AddLopHoc()
		{
			return View();
		}
    }
}
