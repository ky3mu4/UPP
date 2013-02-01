﻿
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/PodklyuchaemoeOborudovanie")]
	[Route("/Catalogs/PodklyuchaemoeOborudovanie/{Code}")]
	public class PodklyuchaemoeOborudovanieRequest/*ПодключаемоеОборудованиеЗапрос*/: V82.СправочникиСсылка.ПодключаемоеОборудование,IReturn<PodklyuchaemoeOborudovanieRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class PodklyuchaemoeOborudovanieResponse//ПодключаемоеОборудованиеОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/PodklyuchaemoeOborudovanies")]
	[Route("/Catalogs/PodklyuchaemoeOborudovanies/{Codes}")]
	public class PodklyuchaemoeOborudovaniesRequest/*ПодключаемоеОборудованиеЗапрос*/: IReturn<List<PodklyuchaemoeOborudovanieRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public PodklyuchaemoeOborudovaniesRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class PodklyuchaemoeOborudovaniesResponse//ПодключаемоеОборудованиеОтвет
	{
		public string Result {get;set;}
	}


	public class PodklyuchaemoeOborudovanieService /*ПодключаемоеОборудованиеСервис*/ : Service
	{
		public object Any(PodklyuchaemoeOborudovanieRequest request)
		{
			return new PodklyuchaemoeOborudovanieResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(PodklyuchaemoeOborudovanieRequest request)
		{
			return null;
		}

		public object Get(PodklyuchaemoeOborudovaniesRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.ПодключаемоеОборудование>();
			foreach (var Code in request.Codes)
			{
				decimal СтрокаКод = 0;
				if (decimal.TryParse(Code, out СтрокаКод))
				{
					Коллекция.Add(null);
				}
			}
			return Коллекция;
		}

	}
}
