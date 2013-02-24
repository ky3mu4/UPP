﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//SposobyRaspredeleniyaZatratNaVypusk
	[Маршрут("Справочники/СпособыРаспределенияЗатратНаВыпуск","")]
	public class СпособыРаспределенияЗатратНаВыпускЗапрос: V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск,IReturn<СпособыРаспределенияЗатратНаВыпускЗапрос>
	{
	}
	[Маршрут("Справочники/СпособыРаспределенияЗатратНаВыпуск/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/СпособыРаспределенияЗатратНаВыпуск/ПоСсылке","{Ссылка}")]
	public class СпособыРаспределенияЗатратНаВыпускНайтиПоСсылке: V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск,IReturn<СпособыРаспределенияЗатратНаВыпускНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/СпособыРаспределенияЗатратНаВыпуск/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/СпособыРаспределенияЗатратНаВыпуск/ПоКоду","{Код}")]
	public class СпособыРаспределенияЗатратНаВыпускНайтиПоКоду: V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск,IReturn<СпособыРаспределенияЗатратНаВыпускНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/СпособыРаспределенияЗатратНаВыпуск/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/СпособыРаспределенияЗатратНаВыпуск/ПоНаименованию","{Наименование}")]
	public class СпособыРаспределенияЗатратНаВыпускНайтиПоНаименованию: V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск,IReturn<СпособыРаспределенияЗатратНаВыпускНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/СпособыРаспределенияЗатратНаВыпуск/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/СпособыРаспределенияЗатратНаВыпуск/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СпособыРаспределенияЗатратНаВыпуск/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class СпособыРаспределенияЗатратНаВыпускВыбратьПоСсылке: V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск,IReturn<СпособыРаспределенияЗатратНаВыпускВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/СпособыРаспределенияЗатратНаВыпуск/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/СпособыРаспределенияЗатратНаВыпуск/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СпособыРаспределенияЗатратНаВыпуск/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class СпособыРаспределенияЗатратНаВыпускВыбратьПоКоду: V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск,IReturn<СпособыРаспределенияЗатратНаВыпускВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СпособыРаспределенияЗатратНаВыпуск/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/СпособыРаспределенияЗатратНаВыпуск/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СпособыРаспределенияЗатратНаВыпуск/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class СпособыРаспределенияЗатратНаВыпускВыбратьПоНаименованию: V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск,IReturn<СпособыРаспределенияЗатратНаВыпускВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СпособыРаспределенияЗатратНаВыпуск/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class СпособыРаспределенияЗатратНаВыпускСтраницаПоСсылке: V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск,IReturn<СпособыРаспределенияЗатратНаВыпускСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/СпособыРаспределенияЗатратНаВыпуск/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class СпособыРаспределенияЗатратНаВыпускСтраницаПоКоду: V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск,IReturn<СпособыРаспределенияЗатратНаВыпускСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/СпособыРаспределенияЗатратНаВыпуск/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class СпособыРаспределенияЗатратНаВыпускСтраницаПоНаименованию: V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск,IReturn<СпособыРаспределенияЗатратНаВыпускСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class СпособыРаспределенияЗатратНаВыпускОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class СпособыРаспределенияЗатратНаВыпускСервис : Service
	{
		
		public object Get(СпособыРаспределенияЗатратНаВыпускЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(СпособыРаспределенияЗатратНаВыпускНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СпособыРаспределенияЗатратНаВыпускНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.СпособыРаспределенияЗатратНаВыпуск.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new СпособыРаспределенияЗатратНаВыпускОтвет() {Ответ = "СпособыРаспределенияЗатратНаВыпуск c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(СпособыРаспределенияЗатратНаВыпускНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СпособыРаспределенияЗатратНаВыпускВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.СпособыРаспределенияЗатратНаВыпуск.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(СпособыРаспределенияЗатратНаВыпускВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СпособыРаспределенияЗатратНаВыпускВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СпособыРаспределенияЗатратНаВыпускСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СпособыРаспределенияЗатратНаВыпускСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СпособыРаспределенияЗатратНаВыпускСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(СпособыРаспределенияЗатратНаВыпускЗапрос Запрос)
		{
			return new СпособыРаспределенияЗатратНаВыпускОтвет {Ответ = "СпособыРаспределенияЗатратНаВыпуск, "};
		}

		public object Post(СпособыРаспределенияЗатратНаВыпускЗапрос ЗапросСпособыРаспределенияЗатратНаВыпуск)
		{
			var Ссылка = (СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск)ЗапросСпособыРаспределенияЗатратНаВыпуск;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}