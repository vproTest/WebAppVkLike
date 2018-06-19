using System;
using System.Linq;
using System.Web.Mvc;
using WebAppVkLike.EFClasses;
using WebAppVkLike.Models;

namespace WebAppVkLike.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }        
    
        public JsonResult SetLike(string id)
        {           
            try
            {
                using (LikeContext content = new LikeContext())
                {
                    Page page = content.Pages.FirstOrDefault(p => p.Name == id); // получаем ссылку на страницу 
                    Like like = new Like                                        // создаём объект-лайк 
                    {
                        LkDateTime = DateTime.Now,
                        PageId = page != null ? page.Id : 0
                    };
                    content.Likes.Add(like);                                    // добавляем лайк в набор сущностей
                    content.SaveChanges();                                      // сохраняем в базу данных
                    return Json(new                                             // возварщаем json-объект
                    {
                        Message = "Ok",                                         
                        Status = true
                    }, JsonRequestBehavior.AllowGet);
                }
            }
            catch(Exception ex)                                                 // обработка исключения
            {
                return Json(new
                {
                    Message = ex.Message,                                       // возварщаем json-объект
                    Status = false                                              // с информацией об ошибке
                }, JsonRequestBehavior.AllowGet);
            }       
        }

        public ActionResult FirstPage()
        {
            return View();
        }

        public ActionResult SecondPage()
        {
            return View();
        }
    }
}