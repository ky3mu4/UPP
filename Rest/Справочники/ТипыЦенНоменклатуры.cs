﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//TipyCenNomenklatury
	[Маршрут("Справочники/ТипыЦенНоменклатуры","")]
	public class ТипыЦенНоменклатурыЗапрос: V82.СправочникиСсылка.ТипыЦенНоменклатуры,IReturn<ТипыЦенНоменклатурыЗапрос>
	{
	}
	[Маршрут("Справочники/ТипыЦенНоменклатуры/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ТипыЦенНоменклатуры/ПоСсылке","{Ссылка}")]
	public class ТипыЦенНоменклатурыНайтиПоСсылке: V82.СправочникиСсылка.ТипыЦенНоменклатуры,IReturn<ТипыЦенНоменклатурыНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ТипыЦенНоменклатуры/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ТипыЦенНоменклатуры/ПоКоду","{Код}")]
	public class ТипыЦенНоменклатурыНайтиПоКоду: V82.СправочникиСсылка.ТипыЦенНоменклатуры,IReturn<ТипыЦенНоменклатурыНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ТипыЦенНоменклатуры/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ТипыЦенНоменклатуры/ПоНаименованию","{Наименование}")]
	public class ТипыЦенНоменклатурыНайтиПоНаименованию: V82.СправочникиСсылка.ТипыЦенНоменклатуры,IReturn<ТипыЦенНоменклатурыНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ТипыЦенНоменклатуры/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ТипыЦенНоменклатуры/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ТипыЦенНоменклатуры/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ТипыЦенНоменклатурыВыбратьПоСсылке: V82.СправочникиСсылка.ТипыЦенНоменклатуры,IReturn<ТипыЦенНоменклатурыВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ТипыЦенНоменклатуры/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ТипыЦенНоменклатуры/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ТипыЦенНоменклатуры/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ТипыЦенНоменклатурыВыбратьПоКоду: V82.СправочникиСсылка.ТипыЦенНоменклатуры,IReturn<ТипыЦенНоменклатурыВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ТипыЦенНоменклатуры/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ТипыЦенНоменклатуры/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ТипыЦенНоменклатуры/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ТипыЦенНоменклатурыВыбратьПоНаименованию: V82.СправочникиСсылка.ТипыЦенНоменклатуры,IReturn<ТипыЦенНоменклатурыВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ТипыЦенНоменклатуры/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ТипыЦенНоменклатурыСтраницаПоСсылке: V82.СправочникиСсылка.ТипыЦенНоменклатуры,IReturn<ТипыЦенНоменклатурыСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ТипыЦенНоменклатуры/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ТипыЦенНоменклатурыСтраницаПоКоду: V82.СправочникиСсылка.ТипыЦенНоменклатуры,IReturn<ТипыЦенНоменклатурыСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ТипыЦенНоменклатуры/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ТипыЦенНоменклатурыСтраницаПоНаименованию: V82.СправочникиСсылка.ТипыЦенНоменклатуры,IReturn<ТипыЦенНоменклатурыСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ТипыЦенНоменклатурыОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ТипыЦенНоменклатурыСервис : Service
	{
		
		public object Get(ТипыЦенНоменклатурыЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ТипыЦенНоменклатурыНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ТипыЦенНоменклатурыНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ТипыЦенНоменклатуры.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ТипыЦенНоменклатурыОтвет() {Ответ = "ТипыЦенНоменклатуры c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(ТипыЦенНоменклатурыНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ТипыЦенНоменклатурыВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.ТипыЦенНоменклатуры.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(ТипыЦенНоменклатурыВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ТипыЦенНоменклатурыВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ТипыЦенНоменклатурыСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ТипыЦенНоменклатурыСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ТипыЦенНоменклатурыСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ТипыЦенНоменклатурыЗапрос Запрос)
		{
			return new ТипыЦенНоменклатурыОтвет {Ответ = "ТипыЦенНоменклатуры, "};
		}

		public object Post(ТипыЦенНоменклатурыЗапрос ЗапросТипыЦенНоменклатуры)
		{
			var Ссылка = (СправочникиСсылка.ТипыЦенНоменклатуры)ЗапросТипыЦенНоменклатуры;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}