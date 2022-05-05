using MeetFeverWebService.Negocio;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using System.Web.Http.Cors;

namespace MeetFeverWebService.Controllers
{
	[RoutePrefix("api/meetfever/experiencia")]
	//[EnableCors(origins: "*", headers: "*", methods: "*")]
	public class ExperienciaController : ApiController
	{
		[HttpGet]
		[Route("ObtenerTodasLasExperiencias")]
		public HttpResponseMessage ObtenerTodasLasExperiencias()
		{
			try
			{
				PR_Negocio negocio = new PR_Negocio();
				var response = negocio.ObtenerTodasLasExperiencias();
				return Request.CreateResponse(HttpStatusCode.OK, new { data = response });
			}
			catch (Exception ex)
			{
				return Request.CreateResponse(HttpStatusCode.InternalServerError, new { isError = true, data = ex.Message });
			}
		}

		[HttpGet]
		[Route("ObtenerTop4ExperienciasMasOpinadas")]
		public HttpResponseMessage ObtenerTop4ExperienciasMasOpinadas()
		{
			try
			{
				PR_Negocio negocio = new PR_Negocio();
				var response = negocio.ObtenerTop4ExperienciasMasOpinadas();
				return Request.CreateResponse(HttpStatusCode.OK, new { data = response });
			}
			catch (Exception ex)
			{
				return Request.CreateResponse(HttpStatusCode.InternalServerError, new { isError = true, data = ex.Message });
			}
		}
	}
}