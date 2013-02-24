﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//Nagrady
	[Маршрут("Справочники/Награды","")]
	public class НаградыЗапрос: V82.СправочникиСсылка.Награды,IReturn<НаградыЗапрос>
	{
	}
	[Маршрут("Справочники/Награды/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/Награды/ПоСсылке","{Ссылка}")]
	public class НаградыНайтиПоСсылке: V82.СправочникиСсылка.Награды,IReturn<НаградыНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/Награды/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/Награды/ПоНаименованию","{Наименование}")]
	public class НаградыНайтиПоНаименованию: V82.СправочникиСсылка.Награды,IReturn<НаградыНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/Награды/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/Награды/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Награды/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class НаградыВыбратьПоСсылке: V82.СправочникиСсылка.Награды,IReturn<НаградыВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/Награды/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/Награды/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Награды/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class НаградыВыбратьПоНаименованию: V82.СправочникиСсылка.Награды,IReturn<НаградыВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/Награды/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class НаградыСтраницаПоСсылке: V82.СправочникиСсылка.Награды,IReturn<НаградыСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/Награды/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class НаградыСтраницаПоНаименованию: V82.СправочникиСсылка.Награды,IReturn<НаградыСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class НаградыОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class НаградыСервис : Service
	{
		
		public object Get(НаградыЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(НаградыНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(НаградыНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(НаградыВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.Награды.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(НаградыВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(НаградыСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(НаградыСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(НаградыЗапрос Запрос)
		{
			return new НаградыОтвет {Ответ = "Награды, "};
		}

		public object Post(НаградыЗапрос ЗапросНаграды)
		{
			var Ссылка = (СправочникиСсылка.Награды)ЗапросНаграды;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}