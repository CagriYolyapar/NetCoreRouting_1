using Microsoft.AspNetCore.Mvc;

namespace NetCoreRouting_1.Controllers
{

    //Eger projenizdeki UI'da degişikliklerin proje kapanmadan gözükmesini istiyorsanız projenize sag tıklayarak open folder in file explorer deyin...Sonra ilgili yerden cmd ekranına gecin. Ve dotnet watch run komutunu kullanın...Proje calısmaya baslayacak ve UI degişiklikleri gözlemlenebilecektir.
    public class SimulationController : Controller
    {
        //List<string>    Eskişehir, İstanbul,Ankara

        // Dictionary<string,string>   sehirler=new Dictionary<string,string> (){          "34" "İstanbul" ,"06" "Ankara"};

        //string sehir = sehirler["34"]; //Ele gecirdiginiz deger İstanbul olacaktır...

        

        //Dictionary<string,object> TempData, ViewData patternidir

        //Dictionary<string,dynamic>     Viewbag        




        public IActionResult SimulationIndex()
        {

            RouteValueDictionary routeValues = RouteData.Values; ;


            string controllerName = routeValues["controller"].ToString();
            
            return View();
        }
    }
}
