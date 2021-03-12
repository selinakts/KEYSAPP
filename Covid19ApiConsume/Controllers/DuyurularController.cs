using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Net.Http;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Script.Serialization;
using DuyuruModels.Models;

namespace Covid19ApiConsume.Controllers
{
    public class DuyurularController
    {
        public ActionResult Index()
        {
            ViewBag.Data = GetApiData();

            return View();
        }

        public List<DuyuruModel> GetApiData()
        {

            var apiUrl = "https://rallycoding.herokuapp.com/api/music_albums";

            //Connect API
            Uri url = new Uri(apiUrl);
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;

            string json = client.DownloadString(url);
            //END

            //JSON Parse START
            JavaScriptSerializer ser = new JavaScriptSerializer();
            List<DuyuruModel> jsonList = ser.Deserialize<List<DuyuruModel>>(json);
            //END

            return jsonList;
        }
    }
}