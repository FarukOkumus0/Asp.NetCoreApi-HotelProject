﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BookingController : ControllerBase
	{
		private readonly IBookingService _bookingService;

		public BookingController(IBookingService bookingService)
		{
			_bookingService = bookingService;
		}

		[HttpGet]
		public IActionResult BookingList()
		{
			var values = _bookingService.TGetList();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult AddBooking(Booking booking)
		{
			_bookingService.TInsert(booking);
			return Ok();
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteBooking(int id)
		{
			var values = _bookingService.TGetById(id);
			_bookingService.TDelete(values);
			return Ok();
		}
		[HttpPut("UpdateBooking")]
		public IActionResult UpdateBooking(Booking booking)
		{
			_bookingService.TUpdate(booking);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetBooking(int id)
		{
			var values = _bookingService.TGetById(id);
			return Ok(values);
		}


		//[HttpPut("aaaa")]
		//public IActionResult aaaa(Booking booking)
		//{
		//	_bookingService.TBookingStatusChangeApproved(booking);
		//	return Ok();
		//}

		//[HttpPut("bbbb")]
		//public IActionResult bbbb(int id)
		//{
		//	_bookingService.TBookingStatusChangeApproved2(id);
		//	return Ok();
		//}

		[HttpGet("Last6Booking")]
		public IActionResult Last6Booking()
		{
			var values = _bookingService.TLast6Bookings();
			return Ok(values);
		}


		[HttpGet("BookingApproved")]
		//[HttpPut("BookingApproved")]
		public IActionResult BookingApproved(int id)
		{
			_bookingService.TBookingStatusChaneApproved3(id);
			return Ok();
		}

		[HttpGet("BookingCancel")]
		//[HttpPut("BookingApproved")]
		public IActionResult BookingCancel(int id)
		{
			_bookingService.TBookingStatusChaneCancel(id);
			return Ok();
		}

		[HttpGet("BookingWait")]
		//[HttpPut("BookingApproved")]
		public IActionResult BookingWait(int id)
		{
			_bookingService.TBookingStatusChangeWait(id);
			return Ok();
		}
	}
}
