using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {
    [Route("/price")]
    public ActionResult Price (string length, string width, string height, string weight)
    {
      float l = float.Parse(length);
      float wi = float.Parse(width);
      float h = float.Parse(height);
      float we = float.Parse(weight)
      Parcel newParcel = new Parcel (l, wi, h, we);
      newParcel.Volume();
      return View(newParcel);
    }
  }
}