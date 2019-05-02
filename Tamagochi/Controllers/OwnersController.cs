using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Tamagochi.Models;

namespace Tamagochi.Controllers
{
  public class OwnersController : Controller
  {

    [HttpGet("/owners")]
    public ActionResult Index()
    {
      List<Owner> allOwners = Owner.GetAll();
      return View(allOwners);
    }

    [HttpGet("/owners/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/owners")]
     public ActionResult Create(string ownerName)
     {
       Owner newowner = new Owner(ownerName);
       List<Owner> allOwners = Owner.GetAll();
       return View("Index", allOwners);
     }


    [HttpPost("/owners/{ownerId}/pets")]
    public ActionResult Create(int ownerId, string petBreed)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Owner foundOwner = Owner.Find(ownerId);
      Pet newPet = new Pet(petBreed);
      foundOwner.AddPet(newPet);
      List<Pet> ownerPets = foundOwner.GetPets();
      model.Add("pets", ownerPets);
      model.Add("owner", foundOwner);
      return View("Show", model);
    }

    [HttpGet("/owners/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Owner selectedOwner = Owner.Find(id);
      List<Pet> ownerPets = selectedOwner.GetPets();
      model.Add("owner", selectedOwner);
      model.Add("pets", ownerPets);
      return View(model);
    }

  }
}
