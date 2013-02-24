﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//ObshherossijjskijjKlassifikatorOsnovnykhFondov
	[Маршрут("Справочники/ОбщероссийскийКлассификаторОсновныхФондов","")]
	public class ОбщероссийскийКлассификаторОсновныхФондовЗапрос: V82.СправочникиСсылка.ОбщероссийскийКлассификаторОсновныхФондов,IReturn<ОбщероссийскийКлассификаторОсновныхФондовЗапрос>
	{
	}
	[Маршрут("Справочники/ОбщероссийскийКлассификаторОсновныхФондов/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ОбщероссийскийКлассификаторОсновныхФондов/ПоСсылке","{Ссылка}")]
	public class ОбщероссийскийКлассификаторОсновныхФондовНайтиПоСсылке: V82.СправочникиСсылка.ОбщероссийскийКлассификаторОсновныхФондов,IReturn<ОбщероссийскийКлассификаторОсновныхФондовНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ОбщероссийскийКлассификаторОсновныхФондов/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ОбщероссийскийКлассификаторОсновныхФондов/ПоКоду","{Код}")]
	public class ОбщероссийскийКлассификаторОсновныхФондовНайтиПоКоду: V82.СправочникиСсылка.ОбщероссийскийКлассификаторОсновныхФондов,IReturn<ОбщероссийскийКлассификаторОсновныхФондовНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ОбщероссийскийКлассификаторОсновныхФондов/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ОбщероссийскийКлассификаторОсновныхФондов/ПоНаименованию","{Наименование}")]
	public class ОбщероссийскийКлассификаторОсновныхФондовНайтиПоНаименованию: V82.СправочникиСсылка.ОбщероссийскийКлассификаторОсновныхФондов,IReturn<ОбщероссийскийКлассификаторОсновныхФондовНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ОбщероссийскийКлассификаторОсновныхФондов/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ОбщероссийскийКлассификаторОсновныхФондов/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОбщероссийскийКлассификаторОсновныхФондов/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ОбщероссийскийКлассификаторОсновныхФондовВыбратьПоСсылке: V82.СправочникиСсылка.ОбщероссийскийКлассификаторОсновныхФондов,IReturn<ОбщероссийскийКлассификаторОсновныхФондовВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОбщероссийскийКлассификаторОсновныхФондов/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ОбщероссийскийКлассификаторОсновныхФондов/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОбщероссийскийКлассификаторОсновныхФондов/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ОбщероссийскийКлассификаторОсновныхФондовВыбратьПоКоду: V82.СправочникиСсылка.ОбщероссийскийКлассификаторОсновныхФондов,IReturn<ОбщероссийскийКлассификаторОсновныхФондовВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОбщероссийскийКлассификаторОсновныхФондов/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ОбщероссийскийКлассификаторОсновныхФондов/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОбщероссийскийКлассификаторОсновныхФондов/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ОбщероссийскийКлассификаторОсновныхФондовВыбратьПоНаименованию: V82.СправочникиСсылка.ОбщероссийскийКлассификаторОсновныхФондов,IReturn<ОбщероссийскийКлассификаторОсновныхФондовВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОбщероссийскийКлассификаторОсновныхФондов/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ОбщероссийскийКлассификаторОсновныхФондовСтраницаПоСсылке: V82.СправочникиСсылка.ОбщероссийскийКлассификаторОсновныхФондов,IReturn<ОбщероссийскийКлассификаторОсновныхФондовСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ОбщероссийскийКлассификаторОсновныхФондов/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ОбщероссийскийКлассификаторОсновныхФондовСтраницаПоКоду: V82.СправочникиСсылка.ОбщероссийскийКлассификаторОсновныхФондов,IReturn<ОбщероссийскийКлассификаторОсновныхФондовСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ОбщероссийскийКлассификаторОсновныхФондов/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ОбщероссийскийКлассификаторОсновныхФондовСтраницаПоНаименованию: V82.СправочникиСсылка.ОбщероссийскийКлассификаторОсновныхФондов,IReturn<ОбщероссийскийКлассификаторОсновныхФондовСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ОбщероссийскийКлассификаторОсновныхФондовОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ОбщероссийскийКлассификаторОсновныхФондовСервис : Service
	{
		
		public object Get(ОбщероссийскийКлассификаторОсновныхФондовЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ОбщероссийскийКлассификаторОсновныхФондовНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ОбщероссийскийКлассификаторОсновныхФондовНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ОбщероссийскийКлассификаторОсновныхФондов.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ОбщероссийскийКлассификаторОсновныхФондовОтвет() {Ответ = "ОбщероссийскийКлассификаторОсновныхФондов c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(ОбщероссийскийКлассификаторОсновныхФондовНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ОбщероссийскийКлассификаторОсновныхФондовВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.ОбщероссийскийКлассификаторОсновныхФондов.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(ОбщероссийскийКлассификаторОсновныхФондовВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ОбщероссийскийКлассификаторОсновныхФондовВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ОбщероссийскийКлассификаторОсновныхФондовСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ОбщероссийскийКлассификаторОсновныхФондовСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ОбщероссийскийКлассификаторОсновныхФондовСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ОбщероссийскийКлассификаторОсновныхФондовЗапрос Запрос)
		{
			return new ОбщероссийскийКлассификаторОсновныхФондовОтвет {Ответ = "ОбщероссийскийКлассификаторОсновныхФондов, "};
		}

		public object Post(ОбщероссийскийКлассификаторОсновныхФондовЗапрос ЗапросОбщероссийскийКлассификаторОсновныхФондов)
		{
			var Ссылка = (СправочникиСсылка.ОбщероссийскийКлассификаторОсновныхФондов)ЗапросОбщероссийскийКлассификаторОсновныхФондов;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}