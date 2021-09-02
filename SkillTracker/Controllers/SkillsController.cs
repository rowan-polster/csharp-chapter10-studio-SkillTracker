using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillTracker.Controllers
{
    public class SkillsController : Controller
    {
        [HttpGet]
        [Route("/skills")]
        public IActionResult Index()
        {

            string html = "<h1> Skills Tracker </h1>" +
                          "<h2> Programming Languages </h2>" +
                          "<ol>" +
                          "<li> C# </li>" +
                          "<li> JavaScript </li>" +
                          "<li> Python </li>";

            return Content(html, "text/html");
        }


        //the form page
        [HttpGet]
        [Route("/skills/form")]
        public IActionResult Form()
        {

            string html = "<form method='post' action='/skills/form'>" +
               "<label for='date'>Enter A Date</label><br />" +
               "<input type = 'date' id = 'date' name = 'date'><br />" +

               "<h2> Please select a skill level for each language." +

               "<h2> C# </h2>" + 
               "<select name='cSharp'> " +
               "<option value= 'Beginner'> Beginner </option>" +
               "<option value= 'Intermediate'> Intermediate </option>" +
               "<option value= 'Expert'> Expert </option>" +
               "</select>" +

               "<h2> JavaScript </h2>" +
               "<select name='javaScript'> " +
               "<option value= 'Beginner'> Beginner </option>" +
               "<option value= 'Intermediate'> Intermediate </option>" +
               "<option value= 'Expert'> Expert </option>" +
               "</select>" +


               "<h2> Python </h2>" + 
               "<select name='python'> " +
               "<option value= 'Beginner'> Beginner </option>" +
               "<option value= 'Intermediate'> Intermediate </option>" +
               "<option value= 'Expert'> Expert </option>" +
               "</select>" +


               "<input type='submit' value='Submit' />" +
                "</form>";

            return Content(html, "text/html");
        }


        //the results of selecting options on the form page
        [HttpPost]
        public IActionResult Form(string cSharp, string javaScript, string python, DateTime date)
        {
            string html =
                "<h1>" + date + "</h1>" +
                "<ol>" +
                "<li>JavaScript Skill Level: " + GetSkillLevel(javaScript) + "</li><br />" +
                "<li>C# Skill Level: " + GetSkillLevel(cSharp) + "</li><br />" +
                "<li>Python Skill Level: " + GetSkillLevel(python) + "</li>" +
                "</ol>";
            return Content(html, "text/html");
        }


        //determines the output of selections
        public static string GetSkillLevel(string level)
        {
            string skillLevel;

            if (level == "Beginner")
            {
                skillLevel = "Beginner";
            }
            else if (level == "Intermediate")
            {
                skillLevel = "Intermediate";
            }
            else if (level == "Expert")
            {
                skillLevel = "Expert";
            }
            else
            {
                skillLevel = "No data";
            }

            return skillLevel;
        }

    }
}
