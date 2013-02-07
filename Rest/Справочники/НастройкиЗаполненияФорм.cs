
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/NastrojjkiZapolneniyaForm")]
	[Route("/Catalogs/NastrojjkiZapolneniyaForm/FindById/{Id}")]
	[Route("/Catalogs/NastrojjkiZapolneniyaForm/FindByCode/{Code}")]
	[Route("/Catalogs/NastrojjkiZapolneniyaForm/FindByDescr/{Descr}")]
	public class NastrojjkiZapolneniyaFormRequest/*НастройкиЗаполненияФормЗапрос*/: V82.СправочникиСсылка.НастройкиЗаполненияФорм,IReturn<NastrojjkiZapolneniyaFormRequest>
	{
		public string Id { get; set; }
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NastrojjkiZapolneniyaFormResponse//НастройкиЗаполненияФормОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NastrojjkiZapolneniyaForms")]
	[Route("/Catalogs/NastrojjkiZapolneniyaForms/{Codes}")]
	public class NastrojjkiZapolneniyaFormsRequest/*НастройкиЗаполненияФормЗапрос*/: IReturn<List<NastrojjkiZapolneniyaFormRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NastrojjkiZapolneniyaFormsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NastrojjkiZapolneniyaFormsResponse//НастройкиЗаполненияФормОтвет
	{
		public string Result {get;set;}
	}


	public class NastrojjkiZapolneniyaFormService /*НастройкиЗаполненияФормСервис*/ : Service
	{
		public object Any(NastrojjkiZapolneniyaFormRequest request)
		{
			return new NastrojjkiZapolneniyaFormResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NastrojjkiZapolneniyaFormRequest request)
		{
			return null;
		}

		public object Get(NastrojjkiZapolneniyaFormsRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.НастройкиЗаполненияФорм>();
			foreach (var Code in request.Codes)
			{
					Коллекция.Add(null);
			}
			return Коллекция;
		}

	}
}