using System.Collections.Generic;

namespace Tamagochi.Models
{
  public class Pet
  {
    private string _breed;
    private int _id;
    private static List<Pet> _instances = new List<Pet> {};

    public Pet (string breed)
    {
      _breed = breed;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetBreed()
    {
      return _breed;
    }

    public void SetBreed(string newBreed)
    {
      _breed = newBreed;
    }

    public static List<Pet> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public int GetId()
    {
     return _id;
    }

    public static Pet Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}
