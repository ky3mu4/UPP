
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/NastrojjkiFormirovaniyaDokumentovPoOrderam")]
	[Route("/Catalogs/NastrojjkiFormirovaniyaDokumentovPoOrderam/FindById/{Id}")]
	[Route("/Catalogs/NastrojjkiFormirovaniyaDokumentovPoOrderam/FindByCode/{Code}")]
	[Route("/Catalogs/NastrojjkiFormirovaniyaDokumentovPoOrderam/FindByDescr/{Descr}")]
	public class NastrojjkiFormirovaniyaDokumentovPoOrderamRequest/*НастройкиФормированияДокументовПоОрдерамЗапрос*/: V82.СправочникиСсылка.НастройкиФормированияДокументовПоОрдерам,IReturn<NastrojjkiFormirovaniyaDokumentovPoOrderamRequest>
	{
		public string Id { get; set; }
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NastrojjkiFormirovaniyaDokumentovPoOrderamResponse//НастройкиФормированияДокументовПоОрдерамОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NastrojjkiFormirovaniyaDokumentovPoOrderams")]
	[Route("/Catalogs/NastrojjkiFormirovaniyaDokumentovPoOrderams/{Codes}")]
	public class NastrojjkiFormirovaniyaDokumentovPoOrderamsRequest/*НастройкиФормированияДокументовПоОрдерамЗапрос*/: IReturn<List<NastrojjkiFormirovaniyaDokumentovPoOrderamRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NastrojjkiFormirovaniyaDokumentovPoOrderamsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NastrojjkiFormirovaniyaDokumentovPoOrderamsResponse//НастройкиФормированияДокументовПоОрдерамОтвет
	{
		public string Result {get;set;}
	}


	public class NastrojjkiFormirovaniyaDokumentovPoOrderamService /*НастройкиФормированияДокументовПоОрдерамСервис*/ : Service
	{
		public object Any(NastrojjkiFormirovaniyaDokumentovPoOrderamRequest request)
		{
			return new NastrojjkiFormirovaniyaDokumentovPoOrderamResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NastrojjkiFormirovaniyaDokumentovPoOrderamRequest request)
		{
			return null;
		}

		public object Get(NastrojjkiFormirovaniyaDokumentovPoOrderamsRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.НастройкиФормированияДокументовПоОрдерам>();
			foreach (var Code in request.Codes)
			{
					Коллекция.Add(null);
			}
			return Коллекция;
		}

	}
}