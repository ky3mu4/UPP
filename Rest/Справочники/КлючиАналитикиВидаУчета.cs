﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//KlyuchiAnalitikiVidaUcheta
	[Маршрут("Справочники/КлючиАналитикиВидаУчета","")]
	public class КлючиАналитикиВидаУчетаЗапрос: V82.СправочникиСсылка.КлючиАналитикиВидаУчета,IReturn<КлючиАналитикиВидаУчетаЗапрос>
	{
	}
	[Маршрут("Справочники/КлючиАналитикиВидаУчета/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/КлючиАналитикиВидаУчета/ПоСсылке","{Ссылка}")]
	public class КлючиАналитикиВидаУчетаНайтиПоСсылке: V82.СправочникиСсылка.КлючиАналитикиВидаУчета,IReturn<КлючиАналитикиВидаУчетаНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/КлючиАналитикиВидаУчета/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/КлючиАналитикиВидаУчета/ПоНаименованию","{Наименование}")]
	public class КлючиАналитикиВидаУчетаНайтиПоНаименованию: V82.СправочникиСсылка.КлючиАналитикиВидаУчета,IReturn<КлючиАналитикиВидаУчетаНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/КлючиАналитикиВидаУчета/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/КлючиАналитикиВидаУчета/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/КлючиАналитикиВидаУчета/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class КлючиАналитикиВидаУчетаВыбратьПоСсылке: V82.СправочникиСсылка.КлючиАналитикиВидаУчета,IReturn<КлючиАналитикиВидаУчетаВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/КлючиАналитикиВидаУчета/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/КлючиАналитикиВидаУчета/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/КлючиАналитикиВидаУчета/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class КлючиАналитикиВидаУчетаВыбратьПоНаименованию: V82.СправочникиСсылка.КлючиАналитикиВидаУчета,IReturn<КлючиАналитикиВидаУчетаВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/КлючиАналитикиВидаУчета/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class КлючиАналитикиВидаУчетаСтраницаПоСсылке: V82.СправочникиСсылка.КлючиАналитикиВидаУчета,IReturn<КлючиАналитикиВидаУчетаСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/КлючиАналитикиВидаУчета/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class КлючиАналитикиВидаУчетаСтраницаПоНаименованию: V82.СправочникиСсылка.КлючиАналитикиВидаУчета,IReturn<КлючиАналитикиВидаУчетаСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class КлючиАналитикиВидаУчетаОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class КлючиАналитикиВидаУчетаСервис : Service
	{
		
		public object Get(КлючиАналитикиВидаУчетаЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(КлючиАналитикиВидаУчетаНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(КлючиАналитикиВидаУчетаНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(КлючиАналитикиВидаУчетаВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.КлючиАналитикиВидаУчета.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(КлючиАналитикиВидаУчетаВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(КлючиАналитикиВидаУчетаСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(КлючиАналитикиВидаУчетаСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(КлючиАналитикиВидаУчетаЗапрос Запрос)
		{
			return new КлючиАналитикиВидаУчетаОтвет {Ответ = "КлючиАналитикиВидаУчета, "};
		}

		public object Post(КлючиАналитикиВидаУчетаЗапрос ЗапросКлючиАналитикиВидаУчета)
		{
			var Ссылка = (СправочникиСсылка.КлючиАналитикиВидаУчета)ЗапросКлючиАналитикиВидаУчета;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}