using Microsoft.AspNetCore.Mvc;
using Tamagochi.Models;
using System.Collections.Generic;

namespace Tamagochi.Controllers
{
  public class PetsController : Controller
  {

    [HttpGet("/owners/{ownerId}/pet/new")]
    public ActionResult New(int ownerId)
    {
       Owner owner = Owner.Find(ownerId);
       return View(owner);
    }

    [HttpGet("/owners/{ownerId}/pets/{petId}")]
    public ActionResult Show(int ownerId, int petId)
    {
      Pet pet = Pet.Find(petId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      Owner owner = Owner.Find(ownerId);
      model.Add("pet", pet);
      model.Add("owner", owner);
      return View(model);
    }

    [HttpPost("/pets/delete")]
    public ActionResult DeleteAll()
    {
      Pet.ClearAll();
      return View();
    }

    [HttpGet("/owners/{ownerId}/pets/{petId}/myPet_tamagochiGame")]
    public ActionResult MyPetTamagochiGame(int ownerId, int petId)
    {
      Pet pet = Pet.Find(petId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      Owner owner = Owner.Find(ownerId);
      model.Add("pet", pet);
      model.Add("owner", owner);
      return View(model);
    }


  }
}
