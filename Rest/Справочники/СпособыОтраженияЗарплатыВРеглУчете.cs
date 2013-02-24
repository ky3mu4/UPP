﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//SposobyOtrazheniyaZarplatyVReglUchete
	[Маршрут("Справочники/СпособыОтраженияЗарплатыВРеглУчете","")]
	public class СпособыОтраженияЗарплатыВРеглУчетеЗапрос: V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете,IReturn<СпособыОтраженияЗарплатыВРеглУчетеЗапрос>
	{
	}
	[Маршрут("Справочники/СпособыОтраженияЗарплатыВРеглУчете/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/СпособыОтраженияЗарплатыВРеглУчете/ПоСсылке","{Ссылка}")]
	public class СпособыОтраженияЗарплатыВРеглУчетеНайтиПоСсылке: V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете,IReturn<СпособыОтраженияЗарплатыВРеглУчетеНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/СпособыОтраженияЗарплатыВРеглУчете/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/СпособыОтраженияЗарплатыВРеглУчете/ПоНаименованию","{Наименование}")]
	public class СпособыОтраженияЗарплатыВРеглУчетеНайтиПоНаименованию: V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете,IReturn<СпособыОтраженияЗарплатыВРеглУчетеНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/СпособыОтраженияЗарплатыВРеглУчете/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/СпособыОтраженияЗарплатыВРеглУчете/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СпособыОтраженияЗарплатыВРеглУчете/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class СпособыОтраженияЗарплатыВРеглУчетеВыбратьПоСсылке: V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете,IReturn<СпособыОтраженияЗарплатыВРеглУчетеВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/СпособыОтраженияЗарплатыВРеглУчете/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/СпособыОтраженияЗарплатыВРеглУчете/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СпособыОтраженияЗарплатыВРеглУчете/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class СпособыОтраженияЗарплатыВРеглУчетеВыбратьПоНаименованию: V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете,IReturn<СпособыОтраженияЗарплатыВРеглУчетеВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СпособыОтраженияЗарплатыВРеглУчете/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class СпособыОтраженияЗарплатыВРеглУчетеСтраницаПоСсылке: V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете,IReturn<СпособыОтраженияЗарплатыВРеглУчетеСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/СпособыОтраженияЗарплатыВРеглУчете/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class СпособыОтраженияЗарплатыВРеглУчетеСтраницаПоНаименованию: V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете,IReturn<СпособыОтраженияЗарплатыВРеглУчетеСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class СпособыОтраженияЗарплатыВРеглУчетеОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class СпособыОтраженияЗарплатыВРеглУчетеСервис : Service
	{
		
		public object Get(СпособыОтраженияЗарплатыВРеглУчетеЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(СпособыОтраженияЗарплатыВРеглУчетеНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СпособыОтраженияЗарплатыВРеглУчетеНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СпособыОтраженияЗарплатыВРеглУчетеВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.СпособыОтраженияЗарплатыВРеглУчете.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(СпособыОтраженияЗарплатыВРеглУчетеВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СпособыОтраженияЗарплатыВРеглУчетеСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СпособыОтраженияЗарплатыВРеглУчетеСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(СпособыОтраженияЗарплатыВРеглУчетеЗапрос Запрос)
		{
			return new СпособыОтраженияЗарплатыВРеглУчетеОтвет {Ответ = "СпособыОтраженияЗарплатыВРеглУчете, "};
		}

		public object Post(СпособыОтраженияЗарплатыВРеглУчетеЗапрос ЗапросСпособыОтраженияЗарплатыВРеглУчете)
		{
			var Ссылка = (СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете)ЗапросСпособыОтраженияЗарплатыВРеглУчете;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}