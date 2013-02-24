﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//NormativyObsluzhivaniyaOS
	[Маршрут("Справочники/НормативыОбслуживанияОС","")]
	public class НормативыОбслуживанияОСЗапрос: V82.СправочникиСсылка.НормативыОбслуживанияОС,IReturn<НормативыОбслуживанияОСЗапрос>
	{
	}
	[Маршрут("Справочники/НормативыОбслуживанияОС/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/НормативыОбслуживанияОС/ПоСсылке","{Ссылка}")]
	public class НормативыОбслуживанияОСНайтиПоСсылке: V82.СправочникиСсылка.НормативыОбслуживанияОС,IReturn<НормативыОбслуживанияОСНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/НормативыОбслуживанияОС/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/НормативыОбслуживанияОС/ПоКоду","{Код}")]
	public class НормативыОбслуживанияОСНайтиПоКоду: V82.СправочникиСсылка.НормативыОбслуживанияОС,IReturn<НормативыОбслуживанияОСНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/НормативыОбслуживанияОС/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/НормативыОбслуживанияОС/ПоНаименованию","{Наименование}")]
	public class НормативыОбслуживанияОСНайтиПоНаименованию: V82.СправочникиСсылка.НормативыОбслуживанияОС,IReturn<НормативыОбслуживанияОСНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/НормативыОбслуживанияОС/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/НормативыОбслуживанияОС/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/НормативыОбслуживанияОС/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class НормативыОбслуживанияОСВыбратьПоСсылке: V82.СправочникиСсылка.НормативыОбслуживанияОС,IReturn<НормативыОбслуживанияОСВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/НормативыОбслуживанияОС/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/НормативыОбслуживанияОС/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/НормативыОбслуживанияОС/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class НормативыОбслуживанияОСВыбратьПоКоду: V82.СправочникиСсылка.НормативыОбслуживанияОС,IReturn<НормативыОбслуживанияОСВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/НормативыОбслуживанияОС/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/НормативыОбслуживанияОС/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/НормативыОбслуживанияОС/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class НормативыОбслуживанияОСВыбратьПоНаименованию: V82.СправочникиСсылка.НормативыОбслуживанияОС,IReturn<НормативыОбслуживанияОСВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/НормативыОбслуживанияОС/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class НормативыОбслуживанияОССтраницаПоСсылке: V82.СправочникиСсылка.НормативыОбслуживанияОС,IReturn<НормативыОбслуживанияОССтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/НормативыОбслуживанияОС/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class НормативыОбслуживанияОССтраницаПоКоду: V82.СправочникиСсылка.НормативыОбслуживанияОС,IReturn<НормативыОбслуживанияОССтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/НормативыОбслуживанияОС/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class НормативыОбслуживанияОССтраницаПоНаименованию: V82.СправочникиСсылка.НормативыОбслуживанияОС,IReturn<НормативыОбслуживанияОССтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class НормативыОбслуживанияОСОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class НормативыОбслуживанияОССервис : Service
	{
		
		public object Get(НормативыОбслуживанияОСЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(НормативыОбслуживанияОСНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(НормативыОбслуживанияОСНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.НормативыОбслуживанияОС.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new НормативыОбслуживанияОСОтвет() {Ответ = "НормативыОбслуживанияОС c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(НормативыОбслуживанияОСНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(НормативыОбслуживанияОСВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.НормативыОбслуживанияОС.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(НормативыОбслуживанияОСВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(НормативыОбслуживанияОСВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(НормативыОбслуживанияОССтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(НормативыОбслуживанияОССтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(НормативыОбслуживанияОССтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(НормативыОбслуживанияОСЗапрос Запрос)
		{
			return new НормативыОбслуживанияОСОтвет {Ответ = "НормативыОбслуживанияОС, "};
		}

		public object Post(НормативыОбслуживанияОСЗапрос ЗапросНормативыОбслуживанияОС)
		{
			var Ссылка = (СправочникиСсылка.НормативыОбслуживанияОС)ЗапросНормативыОбслуживанияОС;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}