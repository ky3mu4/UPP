
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/SposobyOtrazheniyaZarplatyVReglUchete")]
	[Route("/Catalogs/SposobyOtrazheniyaZarplatyVReglUchete/FindById/{Id}")]
	[Route("/Catalogs/SposobyOtrazheniyaZarplatyVReglUchete/FindByCode/{Code}")]
	[Route("/Catalogs/SposobyOtrazheniyaZarplatyVReglUchete/FindByDescr/{Descr}")]
	public class SposobyOtrazheniyaZarplatyVReglUcheteRequest/*СпособыОтраженияЗарплатыВРеглУчетеЗапрос*/: V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете,IReturn<SposobyOtrazheniyaZarplatyVReglUcheteRequest>
	{
		public string Id { get; set; }
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SposobyOtrazheniyaZarplatyVReglUcheteResponse//СпособыОтраженияЗарплатыВРеглУчетеОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/SposobyOtrazheniyaZarplatyVReglUchetes")]
	[Route("/Catalogs/SposobyOtrazheniyaZarplatyVReglUchetes/{Codes}")]
	public class SposobyOtrazheniyaZarplatyVReglUchetesRequest/*СпособыОтраженияЗарплатыВРеглУчетеЗапрос*/: IReturn<List<SposobyOtrazheniyaZarplatyVReglUcheteRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SposobyOtrazheniyaZarplatyVReglUchetesRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SposobyOtrazheniyaZarplatyVReglUchetesResponse//СпособыОтраженияЗарплатыВРеглУчетеОтвет
	{
		public string Result {get;set;}
	}


	public class SposobyOtrazheniyaZarplatyVReglUcheteService /*СпособыОтраженияЗарплатыВРеглУчетеСервис*/ : Service
	{
		public object Any(SposobyOtrazheniyaZarplatyVReglUcheteRequest request)
		{
			return new SposobyOtrazheniyaZarplatyVReglUcheteResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SposobyOtrazheniyaZarplatyVReglUcheteRequest request)
		{
			return null;
		}

		public object Get(SposobyOtrazheniyaZarplatyVReglUchetesRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете>();
			foreach (var Code in request.Codes)
			{
					Коллекция.Add(null);
			}
			return Коллекция;
		}

	}
}