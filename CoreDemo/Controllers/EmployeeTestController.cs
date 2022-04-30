using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CoreDemo.Models;
using Newtonsoft.Json;

namespace CoreDemo.Controllers
{
    public class EmployeeTestController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44375/api/employees/getEmployees");
            var jsonString = await responseMessage.Content.ReadAsStringAsync();

            var values = JsonConvert.DeserializeObject<List<EmployeeModel>>(jsonString);



            return View(values);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(EmployeeModel employee)
        {
            var httpClient = new HttpClient();
            var employeeJson = JsonConvert.SerializeObject(employee);
            StringContent content = new StringContent(employeeJson, Encoding.UTF8, "application/json");

            var responseMessage =
                await httpClient.PostAsync("https://localhost:44375/api/employees/addEmployee", content);

            if (responseMessage.IsSuccessStatusCode)
                return RedirectToAction("Index");

            return View(employee);
        }

        [HttpGet]
        public async Task<IActionResult> EditEmployee(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage =
                await httpClient.GetAsync("https://localhost:44375/api/employees/getEmployeeById?id=" + id);

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonString = await responseMessage.Content.ReadAsStringAsync();
                EmployeeModel employee = JsonConvert.DeserializeObject<EmployeeModel>(jsonString);
                return View(employee);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> EditEmployee(EmployeeModel model)
        {
            var httpClient = new HttpClient();
            var employeeJson = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(employeeJson, Encoding.UTF8, "application/json");

            var responseMessage = await 
                httpClient.PutAsync("https://localhost:44375/api/employees/updateEmployee", content);

            if (responseMessage.IsSuccessStatusCode)
                return RedirectToAction("Index");

            return View(model);

        }

        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.DeleteAsync(
                "https://localhost:44375/api/employees/deleteEmployee?id=" + id);

            if (responseMessage.IsSuccessStatusCode)
                return RedirectToAction("Index");

            return View();
        }

    }
}
