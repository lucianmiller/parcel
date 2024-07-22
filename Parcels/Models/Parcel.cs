using System.Collections.Generic;
using System;

namespace Parcels.Models
{
  public class Parcel
  {
    public float UserLength { get; set; }
    public float UserWidth { get; set; }
    public float UserHeight { get; set; }
    public float UserWeight { get; set; }
    public float UserVolume { get; set; }
    public float UserPrice { get; set; }

    public Parcel(float length, float width, float height, float weight)
    {
      UserLength = length;
      UserWidth = width;
      UserHeight = height;
      UserWeight = weight;
    }

    public void Volume()
    {
      UserVolume = UserLength * UserHeight * UserWidth;
    }

    public void CostToShip()
    {
      double price = UserVolume * (UserWeight * 1.50);
      UserPrice = (float)Math.Round(price,2);
    }
  }
}