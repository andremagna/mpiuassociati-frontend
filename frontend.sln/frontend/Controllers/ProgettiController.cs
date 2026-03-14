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
    public class ProgettiController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // ***************************************
        // INGEGNERIA
        // ***************************************
        public async Task<ActionResult> Stradale()
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
                        var filteredProjects = data.Where(p => p.ProjectParentFilter == "INGEGNERIA" && p.ProjectChildFilter == "STRDALE").ToList();
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

        public async Task<ActionResult> DettagliStradale(int id)
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
        
        public async Task<ActionResult> Aeroportuale()
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
                        var filteredProjects = data.Where(p => p.ProjectParentFilter == "INGEGNERIA" && p.ProjectChildFilter == "AEROPORTUALE").ToList();
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

        public async Task<ActionResult> DettagliAeroportuale(int id)
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
        
        public async Task<ActionResult> Fognature()
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
                        var filteredProjects = data.Where(p => p.ProjectParentFilter == "INGEGNERIA" && p.ProjectChildFilter == "FOGNATURE").ToList();
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

        public async Task<ActionResult> DettagliFognature(int id)
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

        public async Task<ActionResult> Idraulica()
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
                        var filteredProjects = data.Where(p => p.ProjectParentFilter == "INGEGNERIA" && p.ProjectChildFilter == "IDRAULICA").ToList();
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

        public async Task<ActionResult> DettagliIdraulica(int id)
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
        // ARCHITETTURA
        // ***************************************
        public async Task<ActionResult> Terziario()
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
                        var filteredProjects = data.Where(p => p.ProjectParentFilter == "ARCHITETTURA" && p.ProjectChildFilter == "TERZIARIO").ToList();
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

        public async Task<ActionResult> DettagliTerziario(int id)
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

        public async Task<ActionResult> Sport()
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
                        var filteredProjects = data.Where(p => p.ProjectParentFilter == "ARCHITETTURA" && p.ProjectChildFilter == "SPORT").ToList();
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

        public async Task<ActionResult> DettagliSport(int id)
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

        public async Task<ActionResult> Scuole()
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
                        var filteredProjects = data.Where(p => p.ProjectParentFilter == "ARCHITETTURA" && p.ProjectChildFilter == "SCUOLE").ToList();
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

        public async Task<ActionResult> DettagliScuole(int id)
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

        public async Task<ActionResult> Sanita()
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
                        var filteredProjects = data.Where(p => p.ProjectParentFilter == "ARCHITETTURA" && p.ProjectChildFilter == "SANITA").ToList();
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

        public async Task<ActionResult> DettagliSanita(int id)
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
    }
}