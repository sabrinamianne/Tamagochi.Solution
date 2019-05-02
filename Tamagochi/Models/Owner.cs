using System.Collections.Generic;

namespace Tamagochi.Models
{
  public class Owner
  {
    private static List<Owner> _instances = new List<Owner> {};
    private string _name;
    private int _id;
    private List<Pet> _pets;

    public Owner(string ownerName)
    {
      _name = ownerName;
      _instances.Add(this);
      _id = _instances.Count;
      _pets = new List<Pet>{};
    }
    public string GetName()
     {
       return _name;
     }

     public int GetId()
    {
      return _id;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Owner> GetAll()
    {
      return _instances;
    }

    public static Owner Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public List<Pet> GetPets()
    {
      return _pets;
    }

    public void AddPet(Pet pet)
    {
      _pets.Add(pet);
    }

  }
}
