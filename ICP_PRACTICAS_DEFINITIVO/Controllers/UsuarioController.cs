using MeetFeverWebService.Negocio;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using System.Web.Http.Cors;

namespace MeetFeverWebService.Controllers
{
	[RoutePrefix("api/meetfever/usuario")]
	//[EnableCors(origins: "*", headers: "*", methods: "*")]
	public class UsuarioController : ApiController
	{
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