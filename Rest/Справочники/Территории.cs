﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//Territorii
	[Маршрут("Справочники/Территории","")]
	public class ТерриторииЗапрос: V82.СправочникиСсылка.Территории,IReturn<ТерриторииЗапрос>
	{
	}
	[Маршрут("Справочники/Территории/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/Территории/ПоСсылке","{Ссылка}")]
	public class ТерриторииНайтиПоСсылке: V82.СправочникиСсылка.Территории,IReturn<ТерриторииНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/Территории/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/Территории/ПоКоду","{Код}")]
	public class ТерриторииНайтиПоКоду: V82.СправочникиСсылка.Территории,IReturn<ТерриторииНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/Территории/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/Территории/ПоНаименованию","{Наименование}")]
	public class ТерриторииНайтиПоНаименованию: V82.СправочникиСсылка.Территории,IReturn<ТерриторииНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/Территории/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/Территории/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Территории/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ТерриторииВыбратьПоСсылке: V82.СправочникиСсылка.Территории,IReturn<ТерриторииВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/Территории/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/Территории/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Территории/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ТерриторииВыбратьПоКоду: V82.СправочникиСсылка.Территории,IReturn<ТерриторииВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/Территории/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/Территории/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Территории/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ТерриторииВыбратьПоНаименованию: V82.СправочникиСсылка.Территории,IReturn<ТерриторииВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/Территории/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ТерриторииСтраницаПоСсылке: V82.СправочникиСсылка.Территории,IReturn<ТерриторииСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/Территории/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ТерриторииСтраницаПоКоду: V82.СправочникиСсылка.Территории,IReturn<ТерриторииСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/Территории/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ТерриторииСтраницаПоНаименованию: V82.СправочникиСсылка.Территории,IReturn<ТерриторииСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ТерриторииОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ТерриторииСервис : Service
	{
		
		public object Get(ТерриторииЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ТерриторииНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.Территории.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ТерриторииОтвет() { Ответ = "Территории c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ТерриторииНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.Территории.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ТерриторииОтвет() {Ответ = "Территории c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ТерриторииНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ТерриторииВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.Территории.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ТерриторииВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ТерриторииВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ТерриторииСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ТерриторииСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ТерриторииСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ТерриторииЗапрос Запрос)
		{
			return new ТерриторииОтвет {Ответ = "Территории, "};
		}

		public object Post(ТерриторииЗапрос ЗапросТерритории)
		{
			var Ссылка = (СправочникиСсылка.Территории)ЗапросТерритории;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}