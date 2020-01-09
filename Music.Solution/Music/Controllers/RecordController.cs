using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;  
using Music.Models;

namespace Music.Controllers
{
  public class RecordController : Controller
  {
      [HttpGet("/record/new")]//First main user page;
      public ActionResult Template() { return View(); }

     [HttpPost("/record")]//
      public ActionResult Second(string title) 
      {
      Record myRecord = new Record(title);
      List<Record> allRecords = Record.GetAll();
      foreach(Record record in allRecords)
      {
        System.Console.WriteLine(title);
      }
      return View("Second",allRecords);
      }
    }
  }
