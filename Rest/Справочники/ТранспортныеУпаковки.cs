﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//TransportnyeUpakovki
	[Маршрут("Справочники/ТранспортныеУпаковки","")]
	public class ТранспортныеУпаковкиЗапрос: V82.СправочникиСсылка.ТранспортныеУпаковки,IReturn<ТранспортныеУпаковкиЗапрос>
	{
	}
	[Маршрут("Справочники/ТранспортныеУпаковки/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ТранспортныеУпаковки/ПоСсылке","{Ссылка}")]
	public class ТранспортныеУпаковкиНайтиПоСсылке: V82.СправочникиСсылка.ТранспортныеУпаковки,IReturn<ТранспортныеУпаковкиНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ТранспортныеУпаковки/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ТранспортныеУпаковки/ПоКоду","{Код}")]
	public class ТранспортныеУпаковкиНайтиПоКоду: V82.СправочникиСсылка.ТранспортныеУпаковки,IReturn<ТранспортныеУпаковкиНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ТранспортныеУпаковки/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ТранспортныеУпаковки/ПоНаименованию","{Наименование}")]
	public class ТранспортныеУпаковкиНайтиПоНаименованию: V82.СправочникиСсылка.ТранспортныеУпаковки,IReturn<ТранспортныеУпаковкиНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ТранспортныеУпаковки/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ТранспортныеУпаковки/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ТранспортныеУпаковки/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ТранспортныеУпаковкиВыбратьПоСсылке: V82.СправочникиСсылка.ТранспортныеУпаковки,IReturn<ТранспортныеУпаковкиВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ТранспортныеУпаковки/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ТранспортныеУпаковки/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ТранспортныеУпаковки/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ТранспортныеУпаковкиВыбратьПоКоду: V82.СправочникиСсылка.ТранспортныеУпаковки,IReturn<ТранспортныеУпаковкиВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public decimal ___Мин {get; set;}
		public decimal ___Макс {get; set;}
	}
	[Маршрут("Справочники/ТранспортныеУпаковки/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ТранспортныеУпаковки/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ТранспортныеУпаковки/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ТранспортныеУпаковкиВыбратьПоНаименованию: V82.СправочникиСсылка.ТранспортныеУпаковки,IReturn<ТранспортныеУпаковкиВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ТранспортныеУпаковки/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ТранспортныеУпаковкиСтраницаПоСсылке: V82.СправочникиСсылка.ТранспортныеУпаковки,IReturn<ТранспортныеУпаковкиСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ТранспортныеУпаковки/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ТранспортныеУпаковкиСтраницаПоКоду: V82.СправочникиСсылка.ТранспортныеУпаковки,IReturn<ТранспортныеУпаковкиСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ТранспортныеУпаковки/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ТранспортныеУпаковкиСтраницаПоНаименованию: V82.СправочникиСсылка.ТранспортныеУпаковки,IReturn<ТранспортныеУпаковкиСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ТранспортныеУпаковкиОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ТранспортныеУпаковкиСервис : Service
	{
		
		public object Get(ТранспортныеУпаковкиЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ТранспортныеУпаковкиНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ТранспортныеУпаковкиНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			decimal СтрокаКод = Запрос.Код;
			var Ссылка = V82.Справочники.ТранспортныеУпаковки.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ТранспортныеУпаковкиОтвет() {Ответ = "ТранспортныеУпаковки c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(ТранспортныеУпаковкиНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ТранспортныеУпаковкиВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.ТранспортныеУпаковки.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(ТранспортныеУпаковкиВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ТранспортныеУпаковкиВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ТранспортныеУпаковкиСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ТранспортныеУпаковкиСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ТранспортныеУпаковкиСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ТранспортныеУпаковкиЗапрос Запрос)
		{
			return new ТранспортныеУпаковкиОтвет {Ответ = "ТранспортныеУпаковки, "};
		}

		public object Post(ТранспортныеУпаковкиЗапрос ЗапросТранспортныеУпаковки)
		{
			var Ссылка = (СправочникиСсылка.ТранспортныеУпаковки)ЗапросТранспортныеУпаковки;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}