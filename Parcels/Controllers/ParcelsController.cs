using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {
    [Route("/price")]
    public ActionResult Price (string length, string width, string height)
    {
      float l = float.Parse(length);
      float w = float.Parse(width);
      float h = float.Parse(height);
      Parcel newParcel = new Parcel (l, w, h);
      newParcel.Volume();
      return View(newParcel);
    }
  }
}