﻿
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/SertifikatyEHCP")]
	[Route("/Catalogs/SertifikatyEHCP/{Code}")]
	public class SertifikatyEHCPRequest/*СертификатыЭЦПЗапрос*/: V82.СправочникиСсылка.СертификатыЭЦП,IReturn<SertifikatyEHCPRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SertifikatyEHCPResponse//СертификатыЭЦПОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/SertifikatyEHCPs")]
	[Route("/Catalogs/SertifikatyEHCPs/{Codes}")]
	public class SertifikatyEHCPsRequest/*СертификатыЭЦПЗапрос*/: IReturn<List<SertifikatyEHCPRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SertifikatyEHCPsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SertifikatyEHCPsResponse//СертификатыЭЦПОтвет
	{
		public string Result {get;set;}
	}


	public class SertifikatyEHCPService /*СертификатыЭЦПСервис*/ : Service
	{
		public object Any(SertifikatyEHCPRequest request)
		{
			return new SertifikatyEHCPResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SertifikatyEHCPRequest request)
		{
			return null;
		}

		public object Get(SertifikatyEHCPsRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.СертификатыЭЦП>();
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
