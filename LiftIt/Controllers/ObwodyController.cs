using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using LiftIt.Data;
using LiftIt.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LiftIt.Controllers
{
    public class ObwodyController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private ApplicationDbContext _db;
        TwoModelsObwody wynik = new TwoModelsObwody();


        public ObwodyController(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            List<Double> lydka = new List<double>();
            List<string> lydka2 = new List<string>();
            List<Double> udo = new List<double>();
            List<string> udo2 = new List<string>();
            List<Double> biodro = new List<double>();
            List<string> biodro2 = new List<string>();
            List<Double> talia = new List<double>();
            List<string> talia2 = new List<string>();
            List<Double> klatka = new List<double>();
            List<string> klatka2 = new List<string>();
            List<Double> kark = new List<double>();
            List<string> kark2 = new List<string>();
            List<Double> biceps = new List<double>();
            List<string> biceps2 = new List<string>();
            List<Double> przedramie = new List<double>();
            List<string> przedramie2 = new List<string>();
            List<Double> nadgarstek = new List<double>();
            List<string> nadgarstek2 = new List<string>();
            List<DateTime> data = new List<DateTime>();
            List<string> data2 = new List<string>();
            string dataObwody= string.Empty;
            string lydkaObwody = string.Empty;
            string udoObwody = string.Empty;
            string biodroObwody = string.Empty;
            string taliaObwody = string.Empty;
            string klatkaObwody = string.Empty;
            string karkObwody = string.Empty;
            string bicepsObwody = string.Empty;
            string przedramieObwody = string.Empty;
            string nadgarstekObwody = string.Empty;


            wynik.SelectObwody = _db.Obwody.Where(c => c.UserId == user.Id);


            data = (wynik.SelectObwody.Select(c => c.DataPomiaru)).ToList();
            foreach (var item in data)
            {
                data2.Add(@"""" + item.ToString("dd-MM-yyyy") + @"""");
            }
            dataObwody = string.Join(",", data2);
            ViewBag.DataObwody = dataObwody.ToString();

            lydka = (wynik.SelectObwody.Select(c => c.Lydka)).ToList();
            foreach (var item in lydka)
            {
                string sitem = item.ToString("0.00");
                sitem = sitem.Replace(",", ".");
                lydka2.Add(sitem);
            }
            lydkaObwody = string.Join(",", lydka2);
            ViewBag.LydkaObwody = lydkaObwody.Trim();

            udo = (wynik.SelectObwody.Select(c => c.Udo)).ToList();
            foreach (var item in udo)
            {
                string sitem = item.ToString("0.00");
                sitem = sitem.Replace(",", ".");
                udo2.Add(sitem);
            }
            udoObwody = string.Join(",", udo2);
            ViewBag.UdoObwody = udoObwody.Trim();

            biodro = (wynik.SelectObwody.Select(c => c.Biodra)).ToList();
            foreach (var item in biodro)
            {
                string sitem = item.ToString("0.00");
                sitem = sitem.Replace(",", ".");
                biodro2.Add(sitem);
            }
            biodroObwody = string.Join(",", biodro2);
            ViewBag.BiodroObwody = biodroObwody.Trim();

            talia = (wynik.SelectObwody.Select(c => c.Talia)).ToList();
            foreach (var item in talia)
            {
                string sitem = item.ToString("0.00");
                sitem = sitem.Replace(",", ".");
                talia2.Add(sitem);
            }
            taliaObwody = string.Join(",", talia2);
            ViewBag.TaliaObwody = taliaObwody.Trim();

            klatka = (wynik.SelectObwody.Select(c => c.Klatka)).ToList();
            foreach (var item in klatka)
            {
                string sitem = item.ToString("0.00");
                sitem = sitem.Replace(",", ".");
                klatka2.Add(sitem);
            }
            klatkaObwody = string.Join(",", klatka2);
            ViewBag.KlatkaObwody = klatkaObwody.Trim();

            kark = (wynik.SelectObwody.Select(c => c.Kark)).ToList();
            foreach (var item in kark)
            {
                string sitem = item.ToString("0.00");
                sitem = sitem.Replace(",", ".");
                kark2.Add(sitem);
            }
            karkObwody = string.Join(",", kark2);
            ViewBag.KarkObwody = karkObwody.Trim();

            biceps = (wynik.SelectObwody.Select(c => c.Biceps)).ToList();
            foreach (var item in biceps)
            {
                string sitem = item.ToString("0.00");
                sitem = sitem.Replace(",", ".");
                biceps2.Add(sitem);
            }
            bicepsObwody = string.Join(",", biceps2);
            ViewBag.BicepsObwody = bicepsObwody.Trim();

            przedramie = (wynik.SelectObwody.Select(c => c.Przedramie)).ToList();
            foreach (var item in przedramie)
            {
                string sitem = item.ToString("0.00");
                sitem = sitem.Replace(",", ".");
                przedramie2.Add(sitem);
            }
            przedramieObwody = string.Join(",", przedramie2);
            ViewBag.PrzedramieObwody = przedramieObwody.Trim();

            nadgarstek = (wynik.SelectObwody.Select(c => c.Nadgarstek)).ToList();
            foreach (var item in nadgarstek)
            {
                string sitem = item.ToString("0.00");
                sitem = sitem.Replace(",", ".");
                nadgarstek2.Add(sitem);
            }
            nadgarstekObwody = string.Join(",", nadgarstek2);
            ViewBag.NadgarstekObwody = nadgarstekObwody.Trim();

            return View(wynik);
        }

        public async Task<IActionResult> InsertRecords(Obwody obwodyModel)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            string dataPomiaruString = obwodyModel.StringDataPomiaru + DateTime.Now.ToString("HH:mm:ss");
            DateTime dataPomiaru = DateTime.ParseExact(dataPomiaruString.Trim(), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Obwody obwody = new Obwody();

            obwody.Biceps = obwodyModel.Biceps;
            obwody.Biodra = obwodyModel.Biodra;
            obwody.DataPomiaru = dataPomiaru;
            obwody.Kark = obwodyModel.Kark;
            obwody.Klatka = obwodyModel.Klatka;
            obwody.Lydka = obwodyModel.Lydka;
            obwody.Nadgarstek = obwodyModel.Nadgarstek;
            obwody.Przedramie = obwodyModel.Przedramie;
            obwody.Talia = obwodyModel.Talia;
            obwody.Udo = obwodyModel.Udo;
            obwody.UserId = user.Id;

            _db.Obwody.Add(obwody);
            _db.SaveChanges();

            return View("InsertDataOK");
        }
    }
}