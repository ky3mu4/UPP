
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/RazdelyAnkety")]
	[Route("/Catalogs/RazdelyAnkety/FindById/{Id}")]
	[Route("/Catalogs/RazdelyAnkety/FindByCode/{Code}")]
	[Route("/Catalogs/RazdelyAnkety/FindByDescr/{Descr}")]
	public class RazdelyAnketyRequest/*РазделыАнкетыЗапрос*/: V82.СправочникиСсылка.РазделыАнкеты,IReturn<RazdelyAnketyRequest>
	{
		public string Id { get; set; }
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class RazdelyAnketyResponse//РазделыАнкетыОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/RazdelyAnketys")]
	[Route("/Catalogs/RazdelyAnketys/{Codes}")]
	public class RazdelyAnketysRequest/*РазделыАнкетыЗапрос*/: IReturn<List<RazdelyAnketyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public RazdelyAnketysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class RazdelyAnketysResponse//РазделыАнкетыОтвет
	{
		public string Result {get;set;}
	}


	public class RazdelyAnketyService /*РазделыАнкетыСервис*/ : Service
	{
		public object Any(RazdelyAnketyRequest request)
		{
			return new RazdelyAnketyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(RazdelyAnketyRequest request)
		{
			string СтрокаКод = System.Uri.UnescapeDataString(request.Code);
			var Ссылка = V82.Справочники.РазделыАнкеты.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new RazdelyAnketyResponse() {Result = "РазделыАнкеты c кодом '" + request.Code+"' не найдено."};
			}
			return Ссылка;
		}

		public object Get(RazdelyAnketysRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.РазделыАнкеты>();
			foreach (var Code in request.Codes)
			{
				string СтрокаКод = System.Uri.UnescapeDataString(Code);
				var Ссылка = V82.Справочники.РазделыАнкеты.НайтиПоКоду(СтрокаКод);
				if (Ссылка != null)
				{
					Коллекция.Add(Ссылка);
				}
			}
			return Коллекция;
		}

	}
}