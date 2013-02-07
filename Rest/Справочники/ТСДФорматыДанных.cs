
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/TSDFormatyDannykh")]
	[Route("/Catalogs/TSDFormatyDannykh/FindById/{Id}")]
	[Route("/Catalogs/TSDFormatyDannykh/FindByCode/{Code}")]
	[Route("/Catalogs/TSDFormatyDannykh/FindByDescr/{Descr}")]
	public class TSDFormatyDannykhRequest/*ТСДФорматыДанныхЗапрос*/: V82.СправочникиСсылка.ТСДФорматыДанных,IReturn<TSDFormatyDannykhRequest>
	{
		public string Id { get; set; }
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class TSDFormatyDannykhResponse//ТСДФорматыДанныхОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/TSDFormatyDannykhs")]
	[Route("/Catalogs/TSDFormatyDannykhs/{Codes}")]
	public class TSDFormatyDannykhsRequest/*ТСДФорматыДанныхЗапрос*/: IReturn<List<TSDFormatyDannykhRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public TSDFormatyDannykhsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class TSDFormatyDannykhsResponse//ТСДФорматыДанныхОтвет
	{
		public string Result {get;set;}
	}


	public class TSDFormatyDannykhService /*ТСДФорматыДанныхСервис*/ : Service
	{
		public object Any(TSDFormatyDannykhRequest request)
		{
			return new TSDFormatyDannykhResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(TSDFormatyDannykhRequest request)
		{
			string СтрокаКод = System.Uri.UnescapeDataString(request.Code);
			var Ссылка = V82.Справочники.ТСДФорматыДанных.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new TSDFormatyDannykhResponse() {Result = "ТСДФорматыДанных c кодом '" + request.Code+"' не найдено."};
			}
			return Ссылка;
		}

		public object Get(TSDFormatyDannykhsRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.ТСДФорматыДанных>();
			foreach (var Code in request.Codes)
			{
				string СтрокаКод = System.Uri.UnescapeDataString(Code);
				var Ссылка = V82.Справочники.ТСДФорматыДанных.НайтиПоКоду(СтрокаКод);
				if (Ссылка != null)
				{
					Коллекция.Add(Ссылка);
				}
			}
			return Коллекция;
		}

	}
}