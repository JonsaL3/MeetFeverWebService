﻿using MeetFeverWebService.Negocio;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using System.Web.Http.Cors;

namespace MeetFeverWebService.Controllers
{
	[RoutePrefix("api/meetfever/empresa")]
	//[EnableCors(origins: "*", headers: "*", methods: "*")]
	public class EmpresaController : ApiController
	{
		[HttpGet]
		[Route("ObtenerTopEmpresasConMasSeguidores")]
		public HttpResponseMessage ObtenerTopEmpresasConMasSeguidores()
		{
			try
			{
				PR_Negocio negocio = new PR_Negocio();
				var response = negocio.ObtenerTopEmpresasConMasSeguidores();
				return Request.CreateResponse(HttpStatusCode.OK, new { data = response });
			}
			catch (Exception ex)
			{
				return Request.CreateResponse(HttpStatusCode.InternalServerError, new { isError = true, data = ex.Message });
			}
		}

		[HttpPost]
		[Route("ObtenerEmpresaPorId")]
		public HttpResponseMessage ObtenerEmpresaPorId([FromBody] object request)
		{
			try
			{
				PR_Negocio negocio = new PR_Negocio();
				var response = negocio.ObtenerEmpresaPorId(request);
				return Request.CreateResponse(HttpStatusCode.OK, new { data = response });
			}
			catch (Exception ex)
			{
				return Request.CreateResponse(HttpStatusCode.InternalServerError, new { isError = true, data = ex.Message });
			}
		}

		[HttpPost]
		[Route("IniciarSesion")]
		public HttpResponseMessage IniciarSesion([FromBody] object request)
		{
			try
			{
				PR_Negocio negocio = new PR_Negocio();
				var response = negocio.IniciarSesion(request);
				return Request.CreateResponse(HttpStatusCode.OK, new { data = response });
			}
			catch (Exception ex)
			{
				return Request.CreateResponse(HttpStatusCode.InternalServerError, new { isError = true, data = ex.Message });
			}
		}
	}
}