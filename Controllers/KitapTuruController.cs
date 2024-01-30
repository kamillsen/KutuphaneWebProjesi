using Microsoft.AspNetCore.Mvc;
using WebUygulama1.Models;
using WebUygulama1.Utility;

namespace WebUygulama1.Controllers
{
    public class KitapTuruController : Controller
    {   
        private readonly UygulamaDbContext _uygulamaDbContext;

        public KitapTuruController(UygulamaDbContext context)
        {
            _uygulamaDbContext = context;
        }

        public IActionResult Index()
        {

            List<KitapTuru> objKitapTuruList = _uygulamaDbContext.KitapTurleri.ToList();
            return View(objKitapTuruList);
        }

        
        public IActionResult Ekle()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Ekle(KitapTuru kitapturu)
        {

            if(ModelState.IsValid)
            {
                _uygulamaDbContext.KitapTurleri.Add(kitapturu);
                _uygulamaDbContext.SaveChanges(); // bunu yapmazsak bilgiler veritabanına eklenmez
                return RedirectToAction("Index", "KitapTuru");  // aynı controllerda olduğumuzdan yazmasakta olurdu  
            }
            return View();  
             
        }

        public IActionResult Guncelle(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            KitapTuru? KitapTuruVt = _uygulamaDbContext.KitapTurleri.Find(id);
            if(KitapTuruVt == null) 
            {
                return NotFound(); 
            }
            return View();
        }

        [HttpPost]
        public IActionResult Guncelle(KitapTuru kitapturu)
        {

            if (ModelState.IsValid)
            {
                _uygulamaDbContext.KitapTurleri.Add(kitapturu);
                _uygulamaDbContext.SaveChanges(); // bunu yapmazsak bilgiler veritabanına eklenmez
                return RedirectToAction("Index", "KitapTuru");  // aynı controllerda olduğumuzdan yazmasakta olurdu  
            }
            return View();

        }
    }
}
