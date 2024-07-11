using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    public float UserLength { get; set; }
    public float UserWidth { get; set; }
    public float UserHeight { get; set; }
    public float UserVolume { get; set; }

    public Parcel(float length, float width, float height)
    {
      UserLength = length;
      UserWidth = width;
      UserHeight = height;
    }

    public void Volume()
    {
      UserVolume = UserLength * UserHeight * UserWidth;
    }
  }
}