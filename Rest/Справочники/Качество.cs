﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//Kachestvo
	[Маршрут("Справочники/Качество","")]
	public class КачествоЗапрос: V82.СправочникиСсылка.Качество,IReturn<КачествоЗапрос>
	{
	}
	[Маршрут("Справочники/Качество/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/Качество/ПоСсылке","{Ссылка}")]
	public class КачествоНайтиПоСсылке: V82.СправочникиСсылка.Качество,IReturn<КачествоНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/Качество/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/Качество/ПоКоду","{Код}")]
	public class КачествоНайтиПоКоду: V82.СправочникиСсылка.Качество,IReturn<КачествоНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/Качество/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/Качество/ПоНаименованию","{Наименование}")]
	public class КачествоНайтиПоНаименованию: V82.СправочникиСсылка.Качество,IReturn<КачествоНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/Качество/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/Качество/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Качество/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class КачествоВыбратьПоСсылке: V82.СправочникиСсылка.Качество,IReturn<КачествоВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/Качество/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/Качество/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Качество/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class КачествоВыбратьПоКоду: V82.СправочникиСсылка.Качество,IReturn<КачествоВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/Качество/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/Качество/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Качество/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class КачествоВыбратьПоНаименованию: V82.СправочникиСсылка.Качество,IReturn<КачествоВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/Качество/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class КачествоСтраницаПоСсылке: V82.СправочникиСсылка.Качество,IReturn<КачествоСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/Качество/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class КачествоСтраницаПоКоду: V82.СправочникиСсылка.Качество,IReturn<КачествоСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/Качество/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class КачествоСтраницаПоНаименованию: V82.СправочникиСсылка.Качество,IReturn<КачествоСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class КачествоОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class КачествоСервис : Service
	{
		
		public object Get(КачествоЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(КачествоНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(КачествоНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.Качество.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new КачествоОтвет() {Ответ = "Качество c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(КачествоНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(КачествоВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.Качество.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(КачествоВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(КачествоВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(КачествоСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(КачествоСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(КачествоСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(КачествоЗапрос Запрос)
		{
			return new КачествоОтвет {Ответ = "Качество, "};
		}

		public object Post(КачествоЗапрос ЗапросКачество)
		{
			var Ссылка = (СправочникиСсылка.Качество)ЗапросКачество;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}