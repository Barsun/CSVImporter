using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CVSImporter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadFile()
        {
            //open file
            if (Request.Files.Count == 1)
            {
                //get file
                var postedFile = Request.Files[0];
                if (postedFile.ContentLength > 0)
                {
                    //read data from input stream
                    using (var csvReader = new System.IO.StreamReader(postedFile.InputStream))
                    {
                        string inputLine = "";

                        //read each line
                        while ((inputLine = csvReader.ReadLine()) != null)
                        {
                            //get lines values
                            string[] values = inputLine.Split(new char[] { ',' });

                            for (int x = 0; x < values.Length; x++)
                            {
                                //do something with each line and split value
                            }
                        }

                        csvReader.Close();
                    }
                }
            }

            return Redirect("/home/uploadfilepage");
        }
    }
}