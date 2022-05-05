using MeetFeverWebService.Negocio;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using System.Web.Http.Cors;

namespace MeetFeverWebService.Controllers
{
	[RoutePrefix("api/meetfever/opinion")]
	//[EnableCors(origins: "*", headers: "*", methods: "*")]
	public class OpinionController : ApiController
	{
		[HttpPost]
		[Route("ObtenerOpinionPorIdAutor")]
		public HttpResponseMessage ObtenerOpinionesMasGustadas24Horas([FromBody] object request)
		{
			try
			{
				PR_Negocio negocio = new PR_Negocio();
				var response = negocio.ObtenerOpinionPorIdAutor(request);
				return Request.CreateResponse(HttpStatusCode.OK, new { data = response });
			}
			catch (Exception ex)
			{
				return Request.CreateResponse(HttpStatusCode.InternalServerError, new { isError = true, data = ex.Message });
			}
		}

		[HttpGet]
		[Route("ObtenerOpinionesMasGustadas24Horas")]
		public HttpResponseMessage ObtenerOpinionesMasGustadas24Horas()
		{
			try
			{
				PR_Negocio negocio = new PR_Negocio();
				var response = negocio.ObtenerOpinionesMasGustadas24Horas();
				return Request.CreateResponse(HttpStatusCode.OK, new { data = response });
			}
			catch (Exception ex)
			{
				return Request.CreateResponse(HttpStatusCode.InternalServerError, new { isError = true, data = ex.Message });
			}
		}

	}
}