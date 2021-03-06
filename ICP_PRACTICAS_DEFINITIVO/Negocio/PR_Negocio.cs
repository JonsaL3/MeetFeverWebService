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

		/*
		 * Los negocios se usan para hacer llamadas a los procedimientos almacenados que a su vez hacen llamadaas a los datos
		 * que existen dentro de la BBDD, para ello los negocios los estamos ordenando cada uno con su respectiva tabla, los
		 * emoticonos, empleados, usuarios, etc...
		 * */

		// Métodos realcionados con los emoticonos

		public DefaultResult ActualizarEmoticono(object request)
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

					var r = ctx.PA_Actualizar_Emoticono(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult BorradoLogicoEmoticono(object request)
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

					var r = ctx.PA_Borrado_Logico_Emoticono_Por_ID(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult BorradoRealEmoticono(object request)
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

					var r = ctx.PA_Borrado_Real_Emoticono_Por_ID(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult InsertarEmoticono(object request)
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

					var r = ctx.PA_Insertar_Emoticono(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerTodosLosEmoticonos()
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

					var r = ctx.PA_Obtener_Todos_Emoticonos(paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerTodosLosEmoticonosSinBorrado()
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

					var r = ctx.PA_Obtener_Todos_Emoticonos_Sin_Borrado(paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ReactivarEmoticono(object request)
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

					var r = ctx.PA_Reactivar_Emoticono(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		// Métodos relacionados con los empleados

		public DefaultResult ActualizarEmpleado(object request)
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

					var r = ctx.PA_Actualizar_Empleado(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult BorradoLogicoEmpleado(object request)
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

					var r = ctx.PA_Borrado_Logico_Empleado_Por_ID(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult BorradoRealEmpleado(object request)
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

					var r = ctx.PA_Borrado_Real_Empleado_Por_ID(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult InsertarEmpleado(object request)
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

					var r = ctx.PA_Insertar_Empleado(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}
		
		public DefaultResult ObtenerEmpleadosPorIdEmpresa(object request)
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

					var r = ctx.PA_Obtener_Empelados_Por_Empresa(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}
		
		public DefaultResult ObtenerVentasPorMesPorIdEmpresa(object request)
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

					var r = ctx.PAJ_Obtener_Ventas_Agrupadas_Por_Mes_De_Una_Empresa(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}


		// Métodos relacionados con las personas

		public DefaultResult ActualizarPersona(object request)
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

					var r = ctx.PA_Actualizar_Persona(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult BorradoLogicoPersona(object request)
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

					var r = ctx.PA_Borrado_Logico_Persona_Por_ID(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult BorradoRealPersona(object request)
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

					var r = ctx.PA_Borrado_Real_Persona_Por_ID(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult InsertarPersona(object request)
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

					var r = ctx.PA_Insertar_Persona(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerPersonaPorCorreo(object request)
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

					var r = ctx.PA_Obtener_Persona_Por_Correo(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerPersonaPorID(object request)
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

					var r = ctx.PA_Obtener_Persona_Por_ID(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerPersonaPorNick(object request)
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

					var r = ctx.PA_Obtener_Persona_Por_Nick(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerPersonaPorNombre(object request)
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

					var r = ctx.PA_Obtener_Persona_Por_Nombre(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

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

		public DefaultResult ObtenerTodasLasPersonasQueQuizasConozca(object request)
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

		public DefaultResult ObtenerTodasLasPersonas()
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

					var r = ctx.PA_Obtener_Todas_Personas(paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerPersonaGeneral(object request)
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

					var r = ctx.PA_Obtener_Persona_General(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerTodasPersonasSinRestriccion()
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

					var r = ctx.PA_Obtener_Todas_Personas_Sin_Restriccion(paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerTodasPersonasSinBorrado()
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

					var r = ctx.PA_Obtener_Todas_Personas_Sin_Borrado(paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ReactivarPersona(object request)
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

					var r = ctx.PA_Reactivar_Persona(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerEntradasPorPersona(object request)
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

					var r = ctx.PA_Obtener_Entradas_Por_Usuario(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerPersonasActivas()
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

					var r = ctx.PA_Personas_Activas(paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerPersonasRegistradas()
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

					var r = ctx.PA_Personas_Registrados(paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		// Métodos relacionados con empresa

		public DefaultResult ActualizarEmpresa(object request)
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

					var r = ctx.PA_Actualizar_Empresa(JsonConvert.SerializeObject(request), invoker, paramRetcode, paramMensaje, paramJsonOUT);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult BorradoLogicoEmpresa(object request)
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

					var r = ctx.PA_Borrado_Logico_Empresa_Por_ID(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult BorradoRealEmpresa(object request)
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

					var r = ctx.PA_Borrado_Real_Empresa_Por_ID(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult InsertarEmpresa(object request)
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

					var r = ctx.PA_Insertar_Empresa(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
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

		public DefaultResult ObtenerEmpresaPorCif(object request)
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

					var r = ctx.PA_Obtener_Empresa_Por_Cif(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerEmpresaPorCorreo(object request)
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

					var r = ctx.PA_Obtener_Empresa_Por_Correo(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerEmpresaPorNick(object request)
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

					var r = ctx.PA_Obtener_Empresa_Por_Nick(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
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

		public DefaultResult ObtenerTodasLasEmpresas()
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

					var r = ctx.PA_Obtener_Todas_Empresas(paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerEmpresaGeneral(object request)
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

					var r = ctx.PA_Obtener_Empresa_General(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerEmpresasSinRestriccion()
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

					var r = ctx.PA_Obtener_Todas_Empresas_Sin_Restriccion(paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ReactivarEmpresa(object request)
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

					var r = ctx.PA_Reactivar_Empresa(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerEmpresasSinBorrado()
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

					var r = ctx.PA_Obtener_Todas_Empresas_Sin_Borrado(paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerEmpresasActivas()
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

					var r = ctx.PA_Empresas_Activas(paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerEmpresasRegistradas()
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

					var r = ctx.PA_Empresas_Registrados(paramJsonOUT, invoker, paramRetcode, paramMensaje);
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

		public DefaultResult ObtenerSeguidores(object request)
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

					var r = ctx.PA_Obtener_Seguidores_Usuario_ID(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerSeguidos(object request)
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

					var r = ctx.PA_Obtener_Seguidos_Usuario_ID(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult SeguirAUnUsuario(object request)
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

					var r = ctx.PA_Seguir(JsonConvert.SerializeObject(request), invoker, paramRetcode, paramMensaje, paramJsonOUT);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult BorradoRealSeguidor(object request)
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

					var r = ctx.PA_Borrado_Real_seguidor_Por_ID(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult IsFollow(object request)
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

					var r = ctx.PA_Is_Follow(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		// Métodos relacionados con las experiencias

		public DefaultResult ActualizarExperiencia(object request)
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

					var r = ctx.PA_Actualizar_Experiencia(JsonConvert.SerializeObject(request), invoker, paramRetcode, paramMensaje, paramJsonOUT);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult SolicitarBorradoEperiencia(object request)
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

					var r = ctx.PA_Borrado_Aprobado_Experiencia_Por_ID(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}
		public DefaultResult BorradoLogicoEXperiencia(object request)
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

					var r = ctx.PA_Borrado_Logico_Experiencia_Por_ID(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult BorradoRealEXperiencia(object request)
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

					var r = ctx.PA_Borrado_Real_Experiencia_Por_ID(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult InsertarEXperiencia(object request)
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

					var r = ctx.PA_Insertar_Experiencia(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerExperienciaPorId(object request)
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

					var r = ctx.PA_Obtener_Experiencias_Por_ID(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerExperienciasPorEmpresa(object request)
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

					var r = ctx.PA_Obtener_Experiencias_Por_Empresa(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerTodasLasExperiencias()
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

					var r = ctx.PA_Obtener_Todas_Experiencias(paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}
		
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

		public DefaultResult ObtenerTop6ExperienciasMasOpinadas()
		{
			DefaultResult response = new DefaultResult();

			try
			{
				using (var ctx = new MeetFeverDatos())
				{

					ObjectParameter paramJsonOUT = new ObjectParameter("JSON_OUT", typeof(string));
					ObjectParameter paramRetcode = new ObjectParameter("RETCODE", typeof(int));
					ObjectParameter paramMensaje = new ObjectParameter("MENSAJE", typeof(string));

					int invoker = 2;

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

		public DefaultResult ComprarExperiencia(object request)
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

					var r = ctx.PA_Insertar_Entrada_Persona(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerEntradasPorExperiencia(object request)
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

					var r = ctx.PA_Obtener_Entradas_Por_Experiencia(JsonConvert.SerializeObject(request),paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerExperienciaGeneral(object request)
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

					var r = ctx.PA_Obtener_Experiencia_General(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerExperienciasPorTitulo(object request)
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

					var r = ctx.PA_Obtener_Experiencias_Por_Titulo(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerTodasExperienciasSinRestricciones()
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

					var r = ctx.PA_Obtener_Todas_Experiencias_Sin_Restriccion( paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerTodasExperienciasSinBorrado()
		{
			DefaultResult response = new DefaultResult();

			try
			{
				using (var ctx = new MeetFeverDatos())
				{

					ObjectParameter paramJsonOUT = new ObjectParameter("JSON_OUT", typeof(string));
					ObjectParameter paramRetcode = new ObjectParameter("RETCODE", typeof(int));
					ObjectParameter paramMensaje = new ObjectParameter("MENSAJE", typeof(string));

					int invoker = 2;

					var r = ctx.PA_Obtener_Todas_Experiencias_Sin_Borrado(paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ReactivarExperiencia(object request)
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

					var r = ctx.PA_Reactivar_Experiencia(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		// Métodos que tratan las opiniones

		public DefaultResult ActualizarOpinion(object request)
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

					var r = ctx.PA_Actualizar_Opinion(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult BorradoLogicoOpinion(object request)
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

					var r = ctx.PA_Borrado_Logico_Opinion_Por_ID(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult BorradoRealOpinion(object request)
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

					var r = ctx.PA_Borrado_Real_Opinion_Por_ID(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult InsertarOpinion(object request)
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

					var r = ctx.PA_Insertar_Opinion(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}
		 
		public DefaultResult ObtenerOpinionPorIdAutor(object request)
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

					var r = ctx.PA_Obtener_Opinion_Por_Autor(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerOpinionPorId(object request)
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

					var r = ctx.PA_Obtener_Opinion_Por_ID(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerOpinionPorEmpresa(object request)
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

					var r = ctx.PA_Obtener_Opinion_Por_Id_Empresa(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerOpinionPorExperiencia(object request)
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

					var r = ctx.PA_Obtener_Opinion_Por_Id_Experiencia(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerTodasLasOpiniones()
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

					var r = ctx.PA_Obtener_Todas_Opiniones( paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerTodasLasOpinionesReferenteAUsuario(object request)
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

					var r = ctx.PA_Obtener_Todas_Opiniones_Referente_A_Usuario(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerOpinionesMasGustadas24Horas(object request)
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

					var r = ctx.PAGA_Obtener_100_Opiniones_Mas_MG_Ultimas_24h(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObetenerOpinionGeneral(object request)
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

					var r = ctx.PA_Obtener_Opinion_General(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerTodasOpinionesSinRestricciones(object request)
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

					var r = ctx.PA_Obtener_Todas_Opiniones_Sin_Restriccion(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerTodasLasOpinionesSinBorrado()
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

					var r = ctx.PA_Obtener_Todas_Opiniones_Sin_Borrado(paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ReactivarOpinion(object request)
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

					var r = ctx.PA_Reactivar_Opinion(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		// Métodos que tratan los perfiles

		public DefaultResult ActualizarPerfil(object request)
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

					var r = ctx.PA_Actualizar_Perfil(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult BorradoLogicoPerfil(object request)
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

					var r = ctx.PA_Borrado_Logico_Perfil_Por_ID(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult BorradoRealPerfil(object request)
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

					var r = ctx.PA_Borrado_Real_Perfil_Por_ID(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult InsertarPerfil(object request)
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

					var r = ctx.PA_Insertar_Perfil(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerTodosLosPerfiles()
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

					var r = ctx.PA_Obtener_Todos_Perfiles( paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		// Métodos que tratan los Sexos

		public DefaultResult ActualizarSexo(object request)
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

					var r = ctx.PA_Actualizar_Sexo(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult BorradoLogicoSexo(object request)
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

					var r = ctx.PA_Borrado_Logico_Sexo_Por_ID(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult BorradoRealSexo(object request)
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

					var r = ctx.PA_Borrado_Real_Sexo_Por_ID(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult InsertarSexo(object request)
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

					var r = ctx.PA_Insertar_Sexo(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerTodosLosSexos()
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

					var r = ctx.PA_Obtener_Todos_Sexos(paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerTodosLosSexosSinBorrado()
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

					var r = ctx.PA_Obtener_Todos_Sexos_Sin_Borrado(paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ReactivarSexo(object request)
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

					var r = ctx.PA_Reactivar_Sexo(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		// Métodos que tratan los MeGustas

		public DefaultResult ObtenerMegustasDeUnaOpinion(object request)
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

					var r = ctx.PA_Obtener_MeGustas_Por_ID_Opinion(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult DarMeGusta(object request)
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

					var r = ctx.PA_MeGusta(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult BorradoRealMeGusta(object request)
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

					var r = ctx.PA_Borrado_Real_MeGusta_Por_ID(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult IsMeGusta(object request)
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

					var r = ctx.PA_Is_MeGusta(JsonConvert.SerializeObject(request),paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		// Método que trata el registro de los errores

		public DefaultResult InsertarRegistroDeError(object request)
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

					var r = ctx.PA_Insertar_Registro_De_Error(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult BorrarRegistroDeError(object request)
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

					var r = ctx.PA_Borrar_Registro_De_Error(JsonConvert.SerializeObject(request), paramJsonOUT, invoker, paramRetcode, paramMensaje);
					response = HandlerResponse(paramJsonOUT, paramRetcode, paramMensaje);
				}
			}
			catch (Exception ex)
			{
				response = HandlerException(ex);
			}

			return response;
		}

		public DefaultResult ObtenerRegistros()
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

					var r = ctx.PA_Obtener_Registros(paramJsonOUT, invoker, paramRetcode, paramMensaje);
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
			response.MENSAJE = ex.StackTrace;

			return response;
		}
	}
}