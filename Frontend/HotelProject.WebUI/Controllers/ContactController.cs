﻿using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.ContactDto;
using HotelProject.WebUI.Dtos.MessageCategoryDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
	[AllowAnonymous]
	public class ContactController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public ContactController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:5239/api/MessageCategory");

			var jsonData = await responseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<List<ResultMessageCategoryDto>>(jsonData);
			List<SelectListItem> values2 = (from x in values
											select new SelectListItem
											{
												Text = x.MessageCategoryName,
												Value = x.MessageCategoryID.ToString()
											}).ToList();
			ViewBag.v = values2;
			return View();
		}

		[HttpGet]
		public PartialViewResult SendMessage()
		{
			return PartialView();
		}

		[HttpPost]
		public async Task<IActionResult> SendMessage(CreateContactDto createContactDto)
		{
			createContactDto.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
			//createContactDto.Description = string.Empty;
			var client = _httpClientFactory.CreateClient();
			var JsonData = JsonConvert.SerializeObject(createContactDto);
			StringContent stringContent = new StringContent(JsonData, Encoding.UTF8, "application/json");
			await client.PostAsync("http://localhost:5239/api/Contact", stringContent);
			return RedirectToAction("Index", "Default");
		}
	}
}
