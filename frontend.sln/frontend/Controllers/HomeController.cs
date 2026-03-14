using frontend.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace frontend.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoStudio()
        {
            return View();
        }

        // ***************************************
        // COORDINAMENTO SICUREZZA
        // ***************************************
        public async Task<ActionResult> CoordinamentoSicurezza()
        {
            string apiUrl = "http://localhost:5285/api/project";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<List<Projects>>(json);
                        var filteredProjects = data.Where(p => p.ProjectParentFilter == "COORDINAMENTO_SICUREZZA").ToList();
                        return View(filteredProjects);
                    }
                    else
                    {
                        return View("Error", new HandleErrorInfo(
                            new Exception("Failed to get data from API. Status code: " + response.StatusCode),
                            "ApiController",
                            "Index"));
                    }
                }
                catch (Exception ex)
                {
                    return View("Error", new HandleErrorInfo(ex, "ApiController", "Index"));
                }
            }
        }

        public async Task<ActionResult> DettagliSicurezza(int id)
        {
            string apiUrl = "http://localhost:5285/api/project/" + id;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<Projects>(json);
                        return View(data);
                    }
                    else
                    {
                        return View("Error", new HandleErrorInfo(
                            new Exception("Failed to get data from API. Status code: " + response.StatusCode),
                            "ApiController",
                            "Index"));
                    }
                }
                catch (Exception ex)
                {
                    return View("Error", new HandleErrorInfo(ex, "ApiController", "Index"));
                }
            }
        }

        // ***************************************
        // DIREZIONE LAVORI
        // ***************************************
        public async Task<ActionResult> DirezioneLavori()
        {
            string apiUrl = "http://localhost:5285/api/project";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<List<Projects>>(json);
                        var filteredProjects = data.Where(p => p.ProjectParentFilter == "DIREZIONE_LAVORI").ToList();
                        return View(filteredProjects);
                    }
                    else
                    {
                        return View("Error", new HandleErrorInfo(
                            new Exception("Failed to get data from API. Status code: " + response.StatusCode),
                            "ApiController",
                            "Index"));
                    }
                }
                catch (Exception ex)
                {
                    return View("Error", new HandleErrorInfo(ex, "ApiController", "Index"));
                }
            }
        }

        public async Task<ActionResult> DettagliDirezioneLavori(int id)
        {
            string apiUrl = "http://localhost:5285/api/project/" + id;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<Projects>(json);
                        return View(data);
                    }
                    else
                    {
                        return View("Error", new HandleErrorInfo(
                            new Exception("Failed to get data from API. Status code: " + response.StatusCode),
                            "ApiController",
                            "Index"));
                    }
                }
                catch (Exception ex)
                {
                    return View("Error", new HandleErrorInfo(ex, "ApiController", "Index"));
                }
            }
        }

        public ActionResult Contatti()
        {
            return View();
        }

    }
}