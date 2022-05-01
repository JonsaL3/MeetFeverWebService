using MeetFeverWebService.Negocio;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using System.Web.Http.Cors;

namespace MeetFeverWebService.Controllers
{
	[RoutePrefix("api/meetfever/persona")]
	//[EnableCors(origins: "*", headers: "*", methods: "*")]
	public class PersonaController : ApiController
	{
		[HttpPost] // ESTO DEBERÍA DE SER UN GET, INVESTIGAR COMO MANDAR UNA ID EN LA URL
		[Route("ObtenerPersonasQueQuizasConozca")]
		public HttpResponseMessage ObtenerPersonasQueQuizasConozca([FromBody] object request)
		{
			try
			{
				PR_Negocio negocio = new PR_Negocio();
				var response = negocio.ObtenerPersonasQueQuizasConozca(request);
				return Request.CreateResponse(HttpStatusCode.OK, new { data = response });
			}
			catch (Exception ex)
			{
				return Request.CreateResponse(HttpStatusCode.InternalServerError, new { isError = true, data = ex.Message });
			}
		}

		[HttpGet]
		[Route("ObtenerTopPersonasConMasSeguidores")]
		public HttpResponseMessage ObtenerTopPersonasConMasSeguidores()
		{
			try
			{
				PR_Negocio negocio = new PR_Negocio();
				var response = negocio.ObtenerTopPersonasConMasSeguidores();
				return Request.CreateResponse(HttpStatusCode.OK, new { data = response });
			}
			catch (Exception ex)
			{
				return Request.CreateResponse(HttpStatusCode.InternalServerError, new { isError = true, data = ex.Message });
			}
		}
	}
}