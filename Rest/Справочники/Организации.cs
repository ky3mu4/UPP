﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//Organizacii
	[Маршрут("Справочники/Организации","")]
	public class ОрганизацииЗапрос: V82.СправочникиСсылка.Организации,IReturn<ОрганизацииЗапрос>
	{
	}
	[Маршрут("Справочники/Организации/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/Организации/ПоСсылке","{Ссылка}")]
	public class ОрганизацииНайтиПоСсылке: V82.СправочникиСсылка.Организации,IReturn<ОрганизацииНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/Организации/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/Организации/ПоКоду","{Код}")]
	public class ОрганизацииНайтиПоКоду: V82.СправочникиСсылка.Организации,IReturn<ОрганизацииНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/Организации/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/Организации/ПоНаименованию","{Наименование}")]
	public class ОрганизацииНайтиПоНаименованию: V82.СправочникиСсылка.Организации,IReturn<ОрганизацииНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/Организации/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/Организации/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Организации/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ОрганизацииВыбратьПоСсылке: V82.СправочникиСсылка.Организации,IReturn<ОрганизацииВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/Организации/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/Организации/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Организации/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ОрганизацииВыбратьПоКоду: V82.СправочникиСсылка.Организации,IReturn<ОрганизацииВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/Организации/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/Организации/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Организации/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ОрганизацииВыбратьПоНаименованию: V82.СправочникиСсылка.Организации,IReturn<ОрганизацииВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/Организации/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ОрганизацииСтраницаПоСсылке: V82.СправочникиСсылка.Организации,IReturn<ОрганизацииСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/Организации/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ОрганизацииСтраницаПоКоду: V82.СправочникиСсылка.Организации,IReturn<ОрганизацииСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/Организации/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ОрганизацииСтраницаПоНаименованию: V82.СправочникиСсылка.Организации,IReturn<ОрганизацииСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ОрганизацииОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ОрганизацииСервис : Service
	{
		
		public object Get(ОрганизацииЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ОрганизацииНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ОрганизацииНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.Организации.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ОрганизацииОтвет() {Ответ = "Организации c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(ОрганизацииНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ОрганизацииВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.Организации.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(ОрганизацииВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ОрганизацииВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ОрганизацииСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ОрганизацииСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ОрганизацииСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ОрганизацииЗапрос Запрос)
		{
			return new ОрганизацииОтвет {Ответ = "Организации, "};
		}

		public object Post(ОрганизацииЗапрос ЗапросОрганизации)
		{
			var Ссылка = (СправочникиСсылка.Организации)ЗапросОрганизации;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}