﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//KHranilishheDopolnitelnojjInformacii
	[Маршрут("Справочники/ХранилищеДополнительнойИнформации","")]
	public class ХранилищеДополнительнойИнформацииЗапрос: V82.СправочникиСсылка.ХранилищеДополнительнойИнформации,IReturn<ХранилищеДополнительнойИнформацииЗапрос>
	{
	}
	[Маршрут("Справочники/ХранилищеДополнительнойИнформации/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ХранилищеДополнительнойИнформации/ПоСсылке","{Ссылка}")]
	public class ХранилищеДополнительнойИнформацииНайтиПоСсылке: V82.СправочникиСсылка.ХранилищеДополнительнойИнформации,IReturn<ХранилищеДополнительнойИнформацииНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ХранилищеДополнительнойИнформации/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ХранилищеДополнительнойИнформации/ПоНаименованию","{Наименование}")]
	public class ХранилищеДополнительнойИнформацииНайтиПоНаименованию: V82.СправочникиСсылка.ХранилищеДополнительнойИнформации,IReturn<ХранилищеДополнительнойИнформацииНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ХранилищеДополнительнойИнформации/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ХранилищеДополнительнойИнформации/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ХранилищеДополнительнойИнформации/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ХранилищеДополнительнойИнформацииВыбратьПоСсылке: V82.СправочникиСсылка.ХранилищеДополнительнойИнформации,IReturn<ХранилищеДополнительнойИнформацииВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ХранилищеДополнительнойИнформации/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ХранилищеДополнительнойИнформации/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ХранилищеДополнительнойИнформации/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ХранилищеДополнительнойИнформацииВыбратьПоНаименованию: V82.СправочникиСсылка.ХранилищеДополнительнойИнформации,IReturn<ХранилищеДополнительнойИнформацииВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ХранилищеДополнительнойИнформации/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ХранилищеДополнительнойИнформацииСтраницаПоСсылке: V82.СправочникиСсылка.ХранилищеДополнительнойИнформации,IReturn<ХранилищеДополнительнойИнформацииСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ХранилищеДополнительнойИнформации/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ХранилищеДополнительнойИнформацииСтраницаПоНаименованию: V82.СправочникиСсылка.ХранилищеДополнительнойИнформации,IReturn<ХранилищеДополнительнойИнформацииСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ХранилищеДополнительнойИнформацииОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ХранилищеДополнительнойИнформацииСервис : Service
	{
		
		public object Get(ХранилищеДополнительнойИнформацииЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ХранилищеДополнительнойИнформацииНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ХранилищеДополнительнойИнформацииНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ХранилищеДополнительнойИнформацииВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.ХранилищеДополнительнойИнформации.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(ХранилищеДополнительнойИнформацииВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ХранилищеДополнительнойИнформацииСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ХранилищеДополнительнойИнформацииСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ХранилищеДополнительнойИнформацииЗапрос Запрос)
		{
			return new ХранилищеДополнительнойИнформацииОтвет {Ответ = "ХранилищеДополнительнойИнформации, "};
		}

		public object Post(ХранилищеДополнительнойИнформацииЗапрос ЗапросХранилищеДополнительнойИнформации)
		{
			var Ссылка = (СправочникиСсылка.ХранилищеДополнительнойИнформации)ЗапросХранилищеДополнительнойИнформации;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}