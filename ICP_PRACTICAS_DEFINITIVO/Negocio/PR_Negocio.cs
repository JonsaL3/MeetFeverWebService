using ICP_PRACTICAS_DEFINITIVO.Data;
using MeetFeverWebService.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

namespace MeetFeverWebService.Negocio
{
    public class PR_Negocio
    {
		// Metodos relacionados con las personas
		public DefaultResult ObtenerPersonasQueQuizasConozca(object request)
		{
			DefaultResult response = new DefaultResult();

			try
			{
				using (var ctx = new MeetFeverDatos())
				{

					ObjectParameter paramJsonOUT = new ObjectParameter("JSON_OUT", typeof(string));
					ObjectParameter paramRetcode = new ObjectParameter("RETCODE", typeof(int));
					ObjectParameter paramMensaje = new ObjectParameter("MENSAJE", typeof(string));

					int invoker = 1;

					var r = ctx.PAGA_Personas_Que_Quizas_Conozca(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerTopPersonasConMasSeguidores()
		{
			DefaultResult response = new DefaultResult();

			try
			{
				using (var ctx = new MeetFeverDatos())
				{

					ObjectParameter paramJsonOUT = new ObjectParameter("JSON_OUT", typeof(string));
					ObjectParameter paramRetcode = new ObjectParameter("RETCODE", typeof(int));
					ObjectParameter paramMensaje = new ObjectParameter("MENSAJE", typeof(string));

					int invoker = 1;

					var r = ctx.PAG_Top_10_Personas(paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		// Metodos relacionados con empresa
		public DefaultResult ObtenerTop4ExperienciasMasOpinadas()
		{
			DefaultResult response = new DefaultResult();

			try
			{
				using (var ctx = new MeetFeverDatos())
				{

					ObjectParameter paramJsonOUT = new ObjectParameter("JSON_OUT", typeof(string));
					ObjectParameter paramRetcode = new ObjectParameter("RETCODE", typeof(int));
					ObjectParameter paramMensaje = new ObjectParameter("MENSAJE", typeof(string));

					int invoker = 1;

					var r = ctx.PAGA_Obtener_4_Experiencias_Mas_Mencionadas_En_Opiniones(paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerTopEmpresasConMasSeguidores()
		{
			DefaultResult response = new DefaultResult();

			try
			{
				using (var ctx = new MeetFeverDatos())
				{

					ObjectParameter paramJsonOUT = new ObjectParameter("JSON_OUT", typeof(string));
					ObjectParameter paramRetcode = new ObjectParameter("RETCODE", typeof(int));
					ObjectParameter paramMensaje = new ObjectParameter("MENSAJE", typeof(string));

					int invoker = 1;

					var r = ctx.PAG_Top_10_Empresas(paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		// Métodos relacionados con usuarios genéricos
		public DefaultResult IniciarSesion(object request)
		{
			DefaultResult response = new DefaultResult();

			try
			{
				using (var ctx = new MeetFeverDatos())
				{

					ObjectParameter paramJsonOUT = new ObjectParameter("JSON_OUT", typeof(string));
					ObjectParameter paramRetcode = new ObjectParameter("RETCODE", typeof(int));
					ObjectParameter paramMensaje = new ObjectParameter("MENSAJE", typeof(string));

					int invoker = 1;

					var r = ctx.PAG_Iniciar_Sesion(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerEmpresaPorId(object request)
		{
			DefaultResult response = new DefaultResult();

			try
			{
				using (var ctx = new MeetFeverDatos())
				{

					ObjectParameter paramJsonOUT = new ObjectParameter("JSON_OUT", typeof(string));
					ObjectParameter paramRetcode = new ObjectParameter("RETCODE", typeof(int));
					ObjectParameter paramMensaje = new ObjectParameter("MENSAJE", typeof(string));

					int invoker = 1;

					var r = ctx.PA_Obtener_Empresa_Por_ID(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		// Métodos que tratan las respuestas y las excepciones
		public DefaultResult HandlerResponse(ObjectParameter paramJsonOut, ObjectParameter paramRetcode, ObjectParameter paramMensaje)
		{
			DefaultResult response = new DefaultResult();

			if (paramRetcode.Value != null)
			{
				response.RETCODE = int.Parse(paramRetcode.Value.ToString());
				response.MENSAJE = paramMensaje.Value.ToString();
				response.JSON_OUT = paramJsonOut.Value.ToString();
			}

			return response;
		}

		public DefaultResult HandlerException(Exception ex)
		{
			DefaultResult response = new DefaultResult();

			response.RETCODE = -1;
			response.MENSAJE = ex.Message;

			return response;
		}
	}
}