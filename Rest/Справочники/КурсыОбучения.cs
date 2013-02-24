﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//KursyObucheniya
	[Маршрут("Справочники/КурсыОбучения","")]
	public class КурсыОбученияЗапрос: V82.СправочникиСсылка.КурсыОбучения,IReturn<КурсыОбученияЗапрос>
	{
	}
	[Маршрут("Справочники/КурсыОбучения/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/КурсыОбучения/ПоСсылке","{Ссылка}")]
	public class КурсыОбученияНайтиПоСсылке: V82.СправочникиСсылка.КурсыОбучения,IReturn<КурсыОбученияНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/КурсыОбучения/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/КурсыОбучения/ПоНаименованию","{Наименование}")]
	public class КурсыОбученияНайтиПоНаименованию: V82.СправочникиСсылка.КурсыОбучения,IReturn<КурсыОбученияНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/КурсыОбучения/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/КурсыОбучения/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/КурсыОбучения/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class КурсыОбученияВыбратьПоСсылке: V82.СправочникиСсылка.КурсыОбучения,IReturn<КурсыОбученияВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/КурсыОбучения/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/КурсыОбучения/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/КурсыОбучения/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class КурсыОбученияВыбратьПоНаименованию: V82.СправочникиСсылка.КурсыОбучения,IReturn<КурсыОбученияВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/КурсыОбучения/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class КурсыОбученияСтраницаПоСсылке: V82.СправочникиСсылка.КурсыОбучения,IReturn<КурсыОбученияСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/КурсыОбучения/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class КурсыОбученияСтраницаПоНаименованию: V82.СправочникиСсылка.КурсыОбучения,IReturn<КурсыОбученияСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class КурсыОбученияОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class КурсыОбученияСервис : Service
	{
		
		public object Get(КурсыОбученияЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(КурсыОбученияНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(КурсыОбученияНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(КурсыОбученияВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.КурсыОбучения.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(КурсыОбученияВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(КурсыОбученияСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(КурсыОбученияСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(КурсыОбученияЗапрос Запрос)
		{
			return new КурсыОбученияОтвет {Ответ = "КурсыОбучения, "};
		}

		public object Post(КурсыОбученияЗапрос ЗапросКурсыОбучения)
		{
			var Ссылка = (СправочникиСсылка.КурсыОбучения)ЗапросКурсыОбучения;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}