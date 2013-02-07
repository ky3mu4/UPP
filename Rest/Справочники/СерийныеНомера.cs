
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/SerijjnyeNomera")]
	[Route("/Catalogs/SerijjnyeNomera/FindById/{Id}")]
	[Route("/Catalogs/SerijjnyeNomera/FindByCode/{Code}")]
	[Route("/Catalogs/SerijjnyeNomera/FindByDescr/{Descr}")]
	public class SerijjnyeNomeraRequest/*СерийныеНомераЗапрос*/: V82.СправочникиСсылка.СерийныеНомера,IReturn<SerijjnyeNomeraRequest>
	{
		public string Id { get; set; }
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SerijjnyeNomeraResponse//СерийныеНомераОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/SerijjnyeNomeras")]
	[Route("/Catalogs/SerijjnyeNomeras/{Codes}")]
	public class SerijjnyeNomerasRequest/*СерийныеНомераЗапрос*/: IReturn<List<SerijjnyeNomeraRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SerijjnyeNomerasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SerijjnyeNomerasResponse//СерийныеНомераОтвет
	{
		public string Result {get;set;}
	}


	public class SerijjnyeNomeraService /*СерийныеНомераСервис*/ : Service
	{
		public object Any(SerijjnyeNomeraRequest request)
		{
			return new SerijjnyeNomeraResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SerijjnyeNomeraRequest request)
		{
			string СтрокаКод = System.Uri.UnescapeDataString(request.Code);
			var Ссылка = V82.Справочники.СерийныеНомера.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new SerijjnyeNomeraResponse() {Result = "СерийныеНомера c кодом '" + request.Code+"' не найдено."};
			}
			return Ссылка;
		}

		public object Get(SerijjnyeNomerasRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.СерийныеНомера>();
			foreach (var Code in request.Codes)
			{
				string СтрокаКод = System.Uri.UnescapeDataString(Code);
				var Ссылка = V82.Справочники.СерийныеНомера.НайтиПоКоду(СтрокаКод);
				if (Ссылка != null)
				{
					Коллекция.Add(Ссылка);
				}
			}
			return Коллекция;
		}

	}
}