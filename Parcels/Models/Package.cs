using System.Collections.Generic;

namespace Parcels.Models
{
  public class Package
  {
    public string Length { get; set; }
    public string Height { get; set; }
    public string Width { get; set; }
    public string Weight { get; set; }
    private static List<Package> _instances = new List<Package> {};

    public Package (string description)
    {
      Description = description;
      _instances.Add(this);
    }

    public static List<Package> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}