using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_Web_Proto.Models;

namespace ASP_Web_Proto.Controllers
{
    public class CharacterCreatorController : Controller
    {
        public List<RPGCharacter> HistoricalCharacters = new List<RPGCharacter>();
        // GET: CharacterCreator
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            List<RPGCharacter> characters = new List<RPGCharacter>();
            CharacterModel newCharModel = new CharacterModel();
            Random j = new Random();


            characters.Add(new RPGCharacter
            {
                Name = newCharModel.names[j.Next(0, newCharModel.names.Length)],
                Class = "Adventurer"
            });

            characters.Add(new RPGCharacter
            {
                Name = newCharModel.names[j.Next(0, newCharModel.names.Length)],
                Class = "Rogue"
            });

            characters.Add(new RPGCharacter
            {
                Name = newCharModel.names[j.Next(0, newCharModel.names.Length)],
                Class = "Fighter"
            });

            return View(characters);
        }
        [HttpPost]
        public ActionResult SaveCharacter(string Name, string Class)
        {
            RPGCharacter newCharacter = new RPGCharacter();

            var charmodel = new CharacterModel();
            newCharacter.Name = Name;
            newCharacter.Class = Class;

            charmodel.newPlayer = newCharacter;
            charmodel.newPlayer.Name = Name;
            charmodel.newPlayer.Class = Class;

            return Json(charmodel, JsonRequestBehavior.AllowGet);
        }
    }
}