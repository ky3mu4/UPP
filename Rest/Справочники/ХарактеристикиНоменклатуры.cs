﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//KHarakteristikiNomenklatury
	[Маршрут("Справочники/ХарактеристикиНоменклатуры","")]
	public class ХарактеристикиНоменклатурыЗапрос: V82.СправочникиСсылка.ХарактеристикиНоменклатуры,IReturn<ХарактеристикиНоменклатурыЗапрос>
	{
	}
	[Маршрут("Справочники/ХарактеристикиНоменклатуры/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ХарактеристикиНоменклатуры/ПоСсылке","{Ссылка}")]
	public class ХарактеристикиНоменклатурыНайтиПоСсылке: V82.СправочникиСсылка.ХарактеристикиНоменклатуры,IReturn<ХарактеристикиНоменклатурыНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ХарактеристикиНоменклатуры/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ХарактеристикиНоменклатуры/ПоНаименованию","{Наименование}")]
	public class ХарактеристикиНоменклатурыНайтиПоНаименованию: V82.СправочникиСсылка.ХарактеристикиНоменклатуры,IReturn<ХарактеристикиНоменклатурыНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ХарактеристикиНоменклатуры/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ХарактеристикиНоменклатуры/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ХарактеристикиНоменклатуры/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ХарактеристикиНоменклатурыВыбратьПоСсылке: V82.СправочникиСсылка.ХарактеристикиНоменклатуры,IReturn<ХарактеристикиНоменклатурыВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ХарактеристикиНоменклатуры/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ХарактеристикиНоменклатуры/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ХарактеристикиНоменклатуры/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ХарактеристикиНоменклатурыВыбратьПоНаименованию: V82.СправочникиСсылка.ХарактеристикиНоменклатуры,IReturn<ХарактеристикиНоменклатурыВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ХарактеристикиНоменклатуры/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ХарактеристикиНоменклатурыСтраницаПоСсылке: V82.СправочникиСсылка.ХарактеристикиНоменклатуры,IReturn<ХарактеристикиНоменклатурыСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ХарактеристикиНоменклатуры/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ХарактеристикиНоменклатурыСтраницаПоНаименованию: V82.СправочникиСсылка.ХарактеристикиНоменклатуры,IReturn<ХарактеристикиНоменклатурыСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ХарактеристикиНоменклатурыОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ХарактеристикиНоменклатурыСервис : Service
	{
		
		public object Get(ХарактеристикиНоменклатурыЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ХарактеристикиНоменклатурыНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ХарактеристикиНоменклатурыНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ХарактеристикиНоменклатурыВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.ХарактеристикиНоменклатуры.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(ХарактеристикиНоменклатурыВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ХарактеристикиНоменклатурыСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ХарактеристикиНоменклатурыСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ХарактеристикиНоменклатурыЗапрос Запрос)
		{
			return new ХарактеристикиНоменклатурыОтвет {Ответ = "ХарактеристикиНоменклатуры, "};
		}

		public object Post(ХарактеристикиНоменклатурыЗапрос ЗапросХарактеристикиНоменклатуры)
		{
			var Ссылка = (СправочникиСсылка.ХарактеристикиНоменклатуры)ЗапросХарактеристикиНоменклатуры;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}