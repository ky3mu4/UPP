
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/ZanyatiyaKursovObucheniya")]
	[Route("/Catalogs/ZanyatiyaKursovObucheniya/FindById/{Id}")]
	[Route("/Catalogs/ZanyatiyaKursovObucheniya/FindByCode/{Code}")]
	[Route("/Catalogs/ZanyatiyaKursovObucheniya/FindByDescr/{Descr}")]
	public class ZanyatiyaKursovObucheniyaRequest/*ЗанятияКурсовОбученияЗапрос*/: V82.СправочникиСсылка.ЗанятияКурсовОбучения,IReturn<ZanyatiyaKursovObucheniyaRequest>
	{
		public string Id { get; set; }
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ZanyatiyaKursovObucheniyaResponse//ЗанятияКурсовОбученияОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/ZanyatiyaKursovObucheniyas")]
	[Route("/Catalogs/ZanyatiyaKursovObucheniyas/{Codes}")]
	public class ZanyatiyaKursovObucheniyasRequest/*ЗанятияКурсовОбученияЗапрос*/: IReturn<List<ZanyatiyaKursovObucheniyaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ZanyatiyaKursovObucheniyasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ZanyatiyaKursovObucheniyasResponse//ЗанятияКурсовОбученияОтвет
	{
		public string Result {get;set;}
	}


	public class ZanyatiyaKursovObucheniyaService /*ЗанятияКурсовОбученияСервис*/ : Service
	{
		public object Any(ZanyatiyaKursovObucheniyaRequest request)
		{
			return new ZanyatiyaKursovObucheniyaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ZanyatiyaKursovObucheniyaRequest request)
		{
			return null;
		}

		public object Get(ZanyatiyaKursovObucheniyasRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.ЗанятияКурсовОбучения>();
			foreach (var Code in request.Codes)
			{
					Коллекция.Add(null);
			}
			return Коллекция;
		}

	}
}