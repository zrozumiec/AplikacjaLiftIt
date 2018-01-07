using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using LiftIt.Data;
using LiftIt.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Builder;
using System.Text.RegularExpressions;
using System.Globalization;

namespace LiftIt.Controllers
{
    public class WagaController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private ApplicationDbContext _db;
        TwoModelsWaga wynik = new TwoModelsWaga();
        
        public WagaController(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            List<Double> BMI = new List<double>();
            List<string> BMI2 = new List<string>();
            List<Double> miesnie = new List<double>();
            List<string> miesnie2 = new List<string>();
            List<Double> kosci = new List<double>();
            List<string> kosci2 = new List<string>();
            List<Double> woda = new List<double>();
            List<string> woda2 = new List<string>();
            List<Double> tluszcz = new List<double>();
            List<string> tluszcz2 = new List<string>();
            List<Double> wagaCiala = new List<double>();
            List<string> wagaCiala2 = new List<string>();
            List<DateTime> data = new List<DateTime>();
            List<string> data2 = new List<string>();
            string dataWaga = string.Empty;
            string BMIWaga = string.Empty;
            string wagaCialaWaga = string.Empty;
            string miesnieWaga = string.Empty;
            string tluszczWaga = string.Empty;
            string koscizWaga = string.Empty;
            string wodaWaga = string.Empty;

            wynik.SelectWaga = _db.Waga.Where(c => c.UserId == user.Id);


            data = (wynik.SelectWaga.Select(c => c.DataPomiaru)).ToList();
            foreach (var item in data)
            {
                data2.Add(@"""" + item.ToString("dd-MM-yyyy") + @"""");
            }
            dataWaga = string.Join(",", data2);
            ViewBag.DataWaga = dataWaga.ToString();

            BMI = (wynik.SelectWaga.Select(c => c.BMI)).ToList();
            foreach(var item in BMI)
            {
                string sitem = item.ToString("0.00");
                sitem = sitem.Replace(",", ".");
                BMI2.Add(sitem);
            }
            BMIWaga = string.Join(",", BMI2);
            ViewBag.BMIWaga = BMIWaga.Trim();

            wagaCiala = (wynik.SelectWaga.Select(c => c.WagaCiala)).ToList();
            foreach (var item in wagaCiala)
            {
                string sitem = item.ToString("0.00");
                sitem = sitem.Replace(",", ".");
                wagaCiala2.Add(sitem);
            }
            wagaCialaWaga = string.Join(",", wagaCiala2);
            ViewBag.WagaCiala = wagaCialaWaga.Trim();

            miesnie = (wynik.SelectWaga.Select(c => c.Miesnie)).ToList();
            foreach (var item in miesnie)
            {
                string sitem = item.ToString("0.00");
                sitem = sitem.Replace(",", ".");
                miesnie2.Add(sitem);
            }
            miesnieWaga = string.Join(",", miesnie2);
            ViewBag.MiesnieWaga = miesnieWaga.Trim();

            tluszcz = (wynik.SelectWaga.Select(c => c.Tluszcz)).ToList();
            foreach (var item in tluszcz)
            {
                string sitem = item.ToString("0.00");
                sitem = sitem.Replace(",", ".");
                tluszcz2.Add(sitem);
            }
            tluszczWaga = string.Join(",", tluszcz2);
            ViewBag.TluszczWaga = tluszczWaga.Trim();

            kosci = (wynik.SelectWaga.Select(c => c.Kosci)).ToList();
            foreach (var item in kosci)
            {
                string sitem = item.ToString("0.00");
                sitem = sitem.Replace(",", ".");
                kosci2.Add(sitem);
            }
            koscizWaga = string.Join(",", kosci2);
            ViewBag.KosciWaga = koscizWaga.Trim();

            woda = (wynik.SelectWaga.Select(c => c.Woda)).ToList();
            foreach (var item in woda)
            {
                string sitem = item.ToString("0.00");
                sitem = sitem.Replace(",", ".");
                woda2.Add(sitem);
            }
            wodaWaga = string.Join(",", woda2);
            ViewBag.WodaWaga = wodaWaga.Trim();

            return View(wynik);
        }

        public async Task<IActionResult> InsertRecords(Waga wagaModel)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            string dataPomiaruString = wagaModel.StringDataPomiaru + DateTime.Now.ToString("HH:mm:ss");
            DateTime dataPomiaru = DateTime.ParseExact(dataPomiaruString.Trim(), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Waga waga = new Waga();

            waga.BMI = wagaModel.BMI;
            waga.DataPomiaru =  dataPomiaru;
            waga.Kosci = wagaModel.Kosci;
            waga.Miesnie = wagaModel.Miesnie;
            waga.Tluszcz = wagaModel.Tluszcz;
            waga.UserId = user.Id;
            waga.WagaCiala = wagaModel.WagaCiala;
            waga.Woda = wagaModel.Woda;

            _db.Waga.Add(waga);
            _db.SaveChanges();

            return View("InsertDataOK");
        }
    }
}