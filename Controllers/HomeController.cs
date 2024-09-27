using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller 
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            ViewData["Selamlama"] = saat > 12 ? "İyi Günler" :"Günaydın";
            ViewData["UserName"] = "Cengizhan";

            var meetinginfo = new MeetingInfo(){
                Id = 1,
                Location = "İstanbul, Haliç Kongre Merkezi",
                Date = new DateTime(2024,01,20,20,0,0),
                NumberOfPeople = 100

            };



            return View(meetinginfo);
        }
    }
}