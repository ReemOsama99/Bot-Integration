using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Task.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Collections.Specialized;
using System.Web;
using Microsoft.AspNetCore.WebUtilities;

namespace Task.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /*public IActionResult Index()
        {
            return View();
        }*/

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        public async Task<string> Index()
        {
            //Consuming the given Sample API 
            OriginalFile rootObj = new OriginalFile();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://reqres.in/api/users"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    rootObj = JsonConvert.DeserializeObject<OriginalFile>(apiResponse);
                }
            }

            //Building JSON Object for the Facebook Response
            
            var FacebookResponse = new FacebookResponse
            {
                messaging_type = "RESPONSE",
                recipient = new Recipient
                {
                    id = "{PSID}"
                },
                message = new Message
                {
                    attachment = new Attachment
                    {
                        type = "template",
                        payload = new Payload
                        {
                            template_type = "generic",
                            elements = new List<Element>()
                            {
                                  //Only 1 generic template, chose it to be the third user, with 1 button
                                    new Element()
                                    {
                                        title = rootObj.data[2].first_name,
                                        image_url = rootObj.data[2].avatar,
                                        subtitle = rootObj.data[2].last_name,
                                        default_action= new DefaultAction
                                        {
                                           type="web_url",
                                           url="mailto:"+rootObj.data[2].email+"?Subject=Hello",
                                           webview_height_ratio="tall"
                                        },
                                        buttons = new List<Button>()
                                        {
                                           new Button()
                                           {
                                             type = "web_url",
                                             url = "mailto:"+rootObj.data[2].email+"?Subject=Hello",
                                             title = "Send Email"
                                           }
                                        }
                                    }
                            }
                        }
                    }
                }
            };
            //Converting to a JSON object and returning it
            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(FacebookResponse);
            return jsonString;
        }
        
    }
}
