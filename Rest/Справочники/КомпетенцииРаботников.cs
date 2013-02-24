﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//KompetenciiRabotnikov
	[Маршрут("Справочники/КомпетенцииРаботников","")]
	public class КомпетенцииРаботниковЗапрос: V82.СправочникиСсылка.КомпетенцииРаботников,IReturn<КомпетенцииРаботниковЗапрос>
	{
	}
	[Маршрут("Справочники/КомпетенцииРаботников/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/КомпетенцииРаботников/ПоСсылке","{Ссылка}")]
	public class КомпетенцииРаботниковНайтиПоСсылке: V82.СправочникиСсылка.КомпетенцииРаботников,IReturn<КомпетенцииРаботниковНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/КомпетенцииРаботников/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/КомпетенцииРаботников/ПоНаименованию","{Наименование}")]
	public class КомпетенцииРаботниковНайтиПоНаименованию: V82.СправочникиСсылка.КомпетенцииРаботников,IReturn<КомпетенцииРаботниковНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/КомпетенцииРаботников/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/КомпетенцииРаботников/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/КомпетенцииРаботников/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class КомпетенцииРаботниковВыбратьПоСсылке: V82.СправочникиСсылка.КомпетенцииРаботников,IReturn<КомпетенцииРаботниковВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/КомпетенцииРаботников/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/КомпетенцииРаботников/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/КомпетенцииРаботников/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class КомпетенцииРаботниковВыбратьПоНаименованию: V82.СправочникиСсылка.КомпетенцииРаботников,IReturn<КомпетенцииРаботниковВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/КомпетенцииРаботников/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class КомпетенцииРаботниковСтраницаПоСсылке: V82.СправочникиСсылка.КомпетенцииРаботников,IReturn<КомпетенцииРаботниковСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/КомпетенцииРаботников/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class КомпетенцииРаботниковСтраницаПоНаименованию: V82.СправочникиСсылка.КомпетенцииРаботников,IReturn<КомпетенцииРаботниковСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class КомпетенцииРаботниковОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class КомпетенцииРаботниковСервис : Service
	{
		
		public object Get(КомпетенцииРаботниковЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(КомпетенцииРаботниковНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(КомпетенцииРаботниковНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(КомпетенцииРаботниковВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.КомпетенцииРаботников.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(КомпетенцииРаботниковВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(КомпетенцииРаботниковСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(КомпетенцииРаботниковСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(КомпетенцииРаботниковЗапрос Запрос)
		{
			return new КомпетенцииРаботниковОтвет {Ответ = "КомпетенцииРаботников, "};
		}

		public object Post(КомпетенцииРаботниковЗапрос ЗапросКомпетенцииРаботников)
		{
			var Ссылка = (СправочникиСсылка.КомпетенцииРаботников)ЗапросКомпетенцииРаботников;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}