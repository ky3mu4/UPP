﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//TarifyBankovNaDenezhnyePerevody
	[Маршрут("Справочники/ТарифыБанковНаДенежныеПереводы","")]
	public class ТарифыБанковНаДенежныеПереводыЗапрос: V82.СправочникиСсылка.ТарифыБанковНаДенежныеПереводы,IReturn<ТарифыБанковНаДенежныеПереводыЗапрос>
	{
	}
	[Маршрут("Справочники/ТарифыБанковНаДенежныеПереводы/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ТарифыБанковНаДенежныеПереводы/ПоСсылке","{Ссылка}")]
	public class ТарифыБанковНаДенежныеПереводыНайтиПоСсылке: V82.СправочникиСсылка.ТарифыБанковНаДенежныеПереводы,IReturn<ТарифыБанковНаДенежныеПереводыНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ТарифыБанковНаДенежныеПереводы/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ТарифыБанковНаДенежныеПереводы/ПоКоду","{Код}")]
	public class ТарифыБанковНаДенежныеПереводыНайтиПоКоду: V82.СправочникиСсылка.ТарифыБанковНаДенежныеПереводы,IReturn<ТарифыБанковНаДенежныеПереводыНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ТарифыБанковНаДенежныеПереводы/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ТарифыБанковНаДенежныеПереводы/ПоНаименованию","{Наименование}")]
	public class ТарифыБанковНаДенежныеПереводыНайтиПоНаименованию: V82.СправочникиСсылка.ТарифыБанковНаДенежныеПереводы,IReturn<ТарифыБанковНаДенежныеПереводыНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ТарифыБанковНаДенежныеПереводы/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ТарифыБанковНаДенежныеПереводы/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ТарифыБанковНаДенежныеПереводы/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ТарифыБанковНаДенежныеПереводыВыбратьПоСсылке: V82.СправочникиСсылка.ТарифыБанковНаДенежныеПереводы,IReturn<ТарифыБанковНаДенежныеПереводыВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ТарифыБанковНаДенежныеПереводы/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ТарифыБанковНаДенежныеПереводы/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ТарифыБанковНаДенежныеПереводы/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ТарифыБанковНаДенежныеПереводыВыбратьПоКоду: V82.СправочникиСсылка.ТарифыБанковНаДенежныеПереводы,IReturn<ТарифыБанковНаДенежныеПереводыВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ТарифыБанковНаДенежныеПереводы/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ТарифыБанковНаДенежныеПереводы/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ТарифыБанковНаДенежныеПереводы/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ТарифыБанковНаДенежныеПереводыВыбратьПоНаименованию: V82.СправочникиСсылка.ТарифыБанковНаДенежныеПереводы,IReturn<ТарифыБанковНаДенежныеПереводыВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ТарифыБанковНаДенежныеПереводы/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ТарифыБанковНаДенежныеПереводыСтраницаПоСсылке: V82.СправочникиСсылка.ТарифыБанковНаДенежныеПереводы,IReturn<ТарифыБанковНаДенежныеПереводыСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ТарифыБанковНаДенежныеПереводы/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ТарифыБанковНаДенежныеПереводыСтраницаПоКоду: V82.СправочникиСсылка.ТарифыБанковНаДенежныеПереводы,IReturn<ТарифыБанковНаДенежныеПереводыСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ТарифыБанковНаДенежныеПереводы/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ТарифыБанковНаДенежныеПереводыСтраницаПоНаименованию: V82.СправочникиСсылка.ТарифыБанковНаДенежныеПереводы,IReturn<ТарифыБанковНаДенежныеПереводыСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ТарифыБанковНаДенежныеПереводыОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ТарифыБанковНаДенежныеПереводыСервис : Service
	{
		
		public object Get(ТарифыБанковНаДенежныеПереводыЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ТарифыБанковНаДенежныеПереводыНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ТарифыБанковНаДенежныеПереводыНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ТарифыБанковНаДенежныеПереводы.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ТарифыБанковНаДенежныеПереводыОтвет() {Ответ = "ТарифыБанковНаДенежныеПереводы c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(ТарифыБанковНаДенежныеПереводыНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ТарифыБанковНаДенежныеПереводыВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.ТарифыБанковНаДенежныеПереводы.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(ТарифыБанковНаДенежныеПереводыВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ТарифыБанковНаДенежныеПереводыВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ТарифыБанковНаДенежныеПереводыСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ТарифыБанковНаДенежныеПереводыСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ТарифыБанковНаДенежныеПереводыСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ТарифыБанковНаДенежныеПереводыЗапрос Запрос)
		{
			return new ТарифыБанковНаДенежныеПереводыОтвет {Ответ = "ТарифыБанковНаДенежныеПереводы, "};
		}

		public object Post(ТарифыБанковНаДенежныеПереводыЗапрос ЗапросТарифыБанковНаДенежныеПереводы)
		{
			var Ссылка = (СправочникиСсылка.ТарифыБанковНаДенежныеПереводы)ЗапросТарифыБанковНаДенежныеПереводы;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}