using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Registar.BusinessLayer;
using Registar.BusinessLayer.Contracts;
using Registar.Models;
using Registar.Mappers;
using Registar.DomainModel;

namespace Registar.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //get params from query string
            string colour = this.Request.QueryString["colour"];
            string model = this.Request.QueryString["model"];
            string producer = this.Request.QueryString["producer"];

            //call BL
            BikeSearchCommand _command = new BikeSearchCommand();
            _command.Colour = colour;
            _command.Producer = producer;

            BikeSearchResult _result = CommandInvoker.InvokeCommand<BikeSearchCommand, BikeSearchResult>(_command);          

            List<BikeModel> result = new List<BikeModel>(_result.Result.Capacity);
            BikeModel temp;

            MapperManager.CreateMap<Bike, BikeModel>();
            for (int i = 0; i < _result.Result.Count; ++i)
            {
                temp = MapperManager.GetModel<Bike, BikeModel>(_result.Result[i]);
                result.Add(temp);
            }

            return View(result);
        }

        public ActionResult Index2()
        {
            List<BikeModel> _result = new List<BikeModel>();
            _result.Add(new BikeModel() { Colour = "red", Model = "R1", Producer = "Specialized", RegNumber = "007" });
            _result.Add(new BikeModel() { Colour = "red", Model = "R1", Producer = "Specialized", RegNumber = "007" });
            _result.Add(new BikeModel() { Colour = "red", Model = "R1", Producer = "Specialized", RegNumber = "007" });
            _result.Add(new BikeModel() { Colour = "red", Model = "R1", Producer = "Specialized", RegNumber = "007" });
            //
            this.ViewBag.SomeNewProperty = "theValue";
            this.ViewData["SomeNewProperty"] = "theValue";
            //
            return View("Index", _result);
        }

    }
}
