﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//Rabotodateli
	[Маршрут("Справочники/Работодатели","")]
	public class РаботодателиЗапрос: V82.СправочникиСсылка.Работодатели,IReturn<РаботодателиЗапрос>
	{
	}
	[Маршрут("Справочники/Работодатели/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/Работодатели/ПоСсылке","{Ссылка}")]
	public class РаботодателиНайтиПоСсылке: V82.СправочникиСсылка.Работодатели,IReturn<РаботодателиНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/Работодатели/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/Работодатели/ПоКоду","{Код}")]
	public class РаботодателиНайтиПоКоду: V82.СправочникиСсылка.Работодатели,IReturn<РаботодателиНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/Работодатели/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/Работодатели/ПоНаименованию","{Наименование}")]
	public class РаботодателиНайтиПоНаименованию: V82.СправочникиСсылка.Работодатели,IReturn<РаботодателиНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/Работодатели/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/Работодатели/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Работодатели/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class РаботодателиВыбратьПоСсылке: V82.СправочникиСсылка.Работодатели,IReturn<РаботодателиВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/Работодатели/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/Работодатели/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Работодатели/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class РаботодателиВыбратьПоКоду: V82.СправочникиСсылка.Работодатели,IReturn<РаботодателиВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/Работодатели/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/Работодатели/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Работодатели/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class РаботодателиВыбратьПоНаименованию: V82.СправочникиСсылка.Работодатели,IReturn<РаботодателиВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/Работодатели/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class РаботодателиСтраницаПоСсылке: V82.СправочникиСсылка.Работодатели,IReturn<РаботодателиСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/Работодатели/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class РаботодателиСтраницаПоКоду: V82.СправочникиСсылка.Работодатели,IReturn<РаботодателиСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/Работодатели/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class РаботодателиСтраницаПоНаименованию: V82.СправочникиСсылка.Работодатели,IReturn<РаботодателиСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class РаботодателиОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class РаботодателиСервис : Service
	{
		
		public object Get(РаботодателиЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(РаботодателиНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(РаботодателиНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.Работодатели.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new РаботодателиОтвет() {Ответ = "Работодатели c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(РаботодателиНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(РаботодателиВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.Работодатели.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(РаботодателиВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(РаботодателиВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(РаботодателиСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(РаботодателиСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(РаботодателиСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(РаботодателиЗапрос Запрос)
		{
			return new РаботодателиОтвет {Ответ = "Работодатели, "};
		}

		public object Post(РаботодателиЗапрос ЗапросРаботодатели)
		{
			var Ссылка = (СправочникиСсылка.Работодатели)ЗапросРаботодатели;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}