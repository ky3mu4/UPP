﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//RazdelyAnkety
	[Маршрут("Справочники/РазделыАнкеты","")]
	public class РазделыАнкетыЗапрос: V82.СправочникиСсылка.РазделыАнкеты,IReturn<РазделыАнкетыЗапрос>
	{
	}
	[Маршрут("Справочники/РазделыАнкеты/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/РазделыАнкеты/ПоСсылке","{Ссылка}")]
	public class РазделыАнкетыНайтиПоСсылке: V82.СправочникиСсылка.РазделыАнкеты,IReturn<РазделыАнкетыНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/РазделыАнкеты/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/РазделыАнкеты/ПоКоду","{Код}")]
	public class РазделыАнкетыНайтиПоКоду: V82.СправочникиСсылка.РазделыАнкеты,IReturn<РазделыАнкетыНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/РазделыАнкеты/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/РазделыАнкеты/ПоНаименованию","{Наименование}")]
	public class РазделыАнкетыНайтиПоНаименованию: V82.СправочникиСсылка.РазделыАнкеты,IReturn<РазделыАнкетыНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/РазделыАнкеты/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/РазделыАнкеты/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/РазделыАнкеты/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class РазделыАнкетыВыбратьПоСсылке: V82.СправочникиСсылка.РазделыАнкеты,IReturn<РазделыАнкетыВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/РазделыАнкеты/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/РазделыАнкеты/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/РазделыАнкеты/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class РазделыАнкетыВыбратьПоКоду: V82.СправочникиСсылка.РазделыАнкеты,IReturn<РазделыАнкетыВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/РазделыАнкеты/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/РазделыАнкеты/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/РазделыАнкеты/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class РазделыАнкетыВыбратьПоНаименованию: V82.СправочникиСсылка.РазделыАнкеты,IReturn<РазделыАнкетыВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/РазделыАнкеты/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class РазделыАнкетыСтраницаПоСсылке: V82.СправочникиСсылка.РазделыАнкеты,IReturn<РазделыАнкетыСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/РазделыАнкеты/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class РазделыАнкетыСтраницаПоКоду: V82.СправочникиСсылка.РазделыАнкеты,IReturn<РазделыАнкетыСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/РазделыАнкеты/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class РазделыАнкетыСтраницаПоНаименованию: V82.СправочникиСсылка.РазделыАнкеты,IReturn<РазделыАнкетыСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class РазделыАнкетыОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class РазделыАнкетыСервис : Service
	{
		
		public object Get(РазделыАнкетыЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(РазделыАнкетыНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(РазделыАнкетыНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.РазделыАнкеты.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new РазделыАнкетыОтвет() {Ответ = "РазделыАнкеты c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(РазделыАнкетыНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(РазделыАнкетыВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.РазделыАнкеты.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(РазделыАнкетыВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(РазделыАнкетыВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(РазделыАнкетыСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(РазделыАнкетыСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(РазделыАнкетыСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(РазделыАнкетыЗапрос Запрос)
		{
			return new РазделыАнкетыОтвет {Ответ = "РазделыАнкеты, "};
		}

		public object Post(РазделыАнкетыЗапрос ЗапросРазделыАнкеты)
		{
			var Ссылка = (СправочникиСсылка.РазделыАнкеты)ЗапросРазделыАнкеты;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}