
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/KHranilishheDopolnitelnojjInformacii")]
	[Route("/Catalogs/KHranilishheDopolnitelnojjInformacii/FindById/{Id}")]
	[Route("/Catalogs/KHranilishheDopolnitelnojjInformacii/FindByCode/{Code}")]
	[Route("/Catalogs/KHranilishheDopolnitelnojjInformacii/FindByDescr/{Descr}")]
	public class KHranilishheDopolnitelnojjInformaciiRequest/*ХранилищеДополнительнойИнформацииЗапрос*/: V82.СправочникиСсылка.ХранилищеДополнительнойИнформации,IReturn<KHranilishheDopolnitelnojjInformaciiRequest>
	{
		public string Id { get; set; }
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KHranilishheDopolnitelnojjInformaciiResponse//ХранилищеДополнительнойИнформацииОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/KHranilishheDopolnitelnojjInformaciis")]
	[Route("/Catalogs/KHranilishheDopolnitelnojjInformaciis/{Codes}")]
	public class KHranilishheDopolnitelnojjInformaciisRequest/*ХранилищеДополнительнойИнформацииЗапрос*/: IReturn<List<KHranilishheDopolnitelnojjInformaciiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KHranilishheDopolnitelnojjInformaciisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KHranilishheDopolnitelnojjInformaciisResponse//ХранилищеДополнительнойИнформацииОтвет
	{
		public string Result {get;set;}
	}


	public class KHranilishheDopolnitelnojjInformaciiService /*ХранилищеДополнительнойИнформацииСервис*/ : Service
	{
		public object Any(KHranilishheDopolnitelnojjInformaciiRequest request)
		{
			return new KHranilishheDopolnitelnojjInformaciiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KHranilishheDopolnitelnojjInformaciiRequest request)
		{
			return null;
		}

		public object Get(KHranilishheDopolnitelnojjInformaciisRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.ХранилищеДополнительнойИнформации>();
			foreach (var Code in request.Codes)
			{
					Коллекция.Add(null);
			}
			return Коллекция;
		}

	}
}