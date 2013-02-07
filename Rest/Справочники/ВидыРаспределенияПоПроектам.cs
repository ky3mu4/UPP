
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/VidyRaspredeleniyaPoProektam")]
	[Route("/Catalogs/VidyRaspredeleniyaPoProektam/FindById/{Id}")]
	[Route("/Catalogs/VidyRaspredeleniyaPoProektam/FindByCode/{Code}")]
	[Route("/Catalogs/VidyRaspredeleniyaPoProektam/FindByDescr/{Descr}")]
	public class VidyRaspredeleniyaPoProektamRequest/*ВидыРаспределенияПоПроектамЗапрос*/: V82.СправочникиСсылка.ВидыРаспределенияПоПроектам,IReturn<VidyRaspredeleniyaPoProektamRequest>
	{
		public string Id { get; set; }
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VidyRaspredeleniyaPoProektamResponse//ВидыРаспределенияПоПроектамОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VidyRaspredeleniyaPoProektams")]
	[Route("/Catalogs/VidyRaspredeleniyaPoProektams/{Codes}")]
	public class VidyRaspredeleniyaPoProektamsRequest/*ВидыРаспределенияПоПроектамЗапрос*/: IReturn<List<VidyRaspredeleniyaPoProektamRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VidyRaspredeleniyaPoProektamsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VidyRaspredeleniyaPoProektamsResponse//ВидыРаспределенияПоПроектамОтвет
	{
		public string Result {get;set;}
	}


	public class VidyRaspredeleniyaPoProektamService /*ВидыРаспределенияПоПроектамСервис*/ : Service
	{
		public object Any(VidyRaspredeleniyaPoProektamRequest request)
		{
			return new VidyRaspredeleniyaPoProektamResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VidyRaspredeleniyaPoProektamRequest request)
		{
			string СтрокаКод = System.Uri.UnescapeDataString(request.Code);
			var Ссылка = V82.Справочники.ВидыРаспределенияПоПроектам.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new VidyRaspredeleniyaPoProektamResponse() {Result = "ВидыРаспределенияПоПроектам c кодом '" + request.Code+"' не найдено."};
			}
			return Ссылка;
		}

		public object Get(VidyRaspredeleniyaPoProektamsRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.ВидыРаспределенияПоПроектам>();
			foreach (var Code in request.Codes)
			{
				string СтрокаКод = System.Uri.UnescapeDataString(Code);
				var Ссылка = V82.Справочники.ВидыРаспределенияПоПроектам.НайтиПоКоду(СтрокаКод);
				if (Ссылка != null)
				{
					Коллекция.Add(Ссылка);
				}
			}
			return Коллекция;
		}

	}
}