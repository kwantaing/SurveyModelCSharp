using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SurveyWithModel.Models;

namespace SurveyWithModel.Controllers
{
    public class HomeController : Controller
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public ViewResult Index()
        {
            return View("Index");
        }
        public IActionResult Submit(Survey Submission){
            if(ModelState.IsValid){
                return View("Result",Submission);
            }else{
                return View("Index");
            }
        }
    }
}
