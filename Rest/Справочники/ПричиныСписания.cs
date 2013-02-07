
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/PrichinySpisaniya")]
	[Route("/Catalogs/PrichinySpisaniya/FindById/{Id}")]
	[Route("/Catalogs/PrichinySpisaniya/FindByCode/{Code}")]
	[Route("/Catalogs/PrichinySpisaniya/FindByDescr/{Descr}")]
	public class PrichinySpisaniyaRequest/*ПричиныСписанияЗапрос*/: V82.СправочникиСсылка.ПричиныСписания,IReturn<PrichinySpisaniyaRequest>
	{
		public string Id { get; set; }
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class PrichinySpisaniyaResponse//ПричиныСписанияОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/PrichinySpisaniyas")]
	[Route("/Catalogs/PrichinySpisaniyas/{Codes}")]
	public class PrichinySpisaniyasRequest/*ПричиныСписанияЗапрос*/: IReturn<List<PrichinySpisaniyaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public PrichinySpisaniyasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class PrichinySpisaniyasResponse//ПричиныСписанияОтвет
	{
		public string Result {get;set;}
	}


	public class PrichinySpisaniyaService /*ПричиныСписанияСервис*/ : Service
	{
		public object Any(PrichinySpisaniyaRequest request)
		{
			return new PrichinySpisaniyaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(PrichinySpisaniyaRequest request)
		{
			string СтрокаКод = System.Uri.UnescapeDataString(request.Code);
			var Ссылка = V82.Справочники.ПричиныСписания.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new PrichinySpisaniyaResponse() {Result = "ПричиныСписания c кодом '" + request.Code+"' не найдено."};
			}
			return Ссылка;
		}

		public object Get(PrichinySpisaniyasRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.ПричиныСписания>();
			foreach (var Code in request.Codes)
			{
				string СтрокаКод = System.Uri.UnescapeDataString(Code);
				var Ссылка = V82.Справочники.ПричиныСписания.НайтиПоКоду(СтрокаКод);
				if (Ссылка != null)
				{
					Коллекция.Add(Ссылка);
				}
			}
			return Коллекция;
		}

	}
}