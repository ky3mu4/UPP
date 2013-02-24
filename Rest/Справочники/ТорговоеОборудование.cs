﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//TorgovoeOborudovanie
	[Маршрут("Справочники/ТорговоеОборудование","")]
	public class ТорговоеОборудованиеЗапрос: V82.СправочникиСсылка.ТорговоеОборудование,IReturn<ТорговоеОборудованиеЗапрос>
	{
	}
	[Маршрут("Справочники/ТорговоеОборудование/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ТорговоеОборудование/ПоСсылке","{Ссылка}")]
	public class ТорговоеОборудованиеНайтиПоСсылке: V82.СправочникиСсылка.ТорговоеОборудование,IReturn<ТорговоеОборудованиеНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ТорговоеОборудование/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ТорговоеОборудование/ПоКоду","{Код}")]
	public class ТорговоеОборудованиеНайтиПоКоду: V82.СправочникиСсылка.ТорговоеОборудование,IReturn<ТорговоеОборудованиеНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ТорговоеОборудование/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ТорговоеОборудование/ПоНаименованию","{Наименование}")]
	public class ТорговоеОборудованиеНайтиПоНаименованию: V82.СправочникиСсылка.ТорговоеОборудование,IReturn<ТорговоеОборудованиеНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ТорговоеОборудование/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ТорговоеОборудование/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ТорговоеОборудование/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ТорговоеОборудованиеВыбратьПоСсылке: V82.СправочникиСсылка.ТорговоеОборудование,IReturn<ТорговоеОборудованиеВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ТорговоеОборудование/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ТорговоеОборудование/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ТорговоеОборудование/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ТорговоеОборудованиеВыбратьПоКоду: V82.СправочникиСсылка.ТорговоеОборудование,IReturn<ТорговоеОборудованиеВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ТорговоеОборудование/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ТорговоеОборудование/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ТорговоеОборудование/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ТорговоеОборудованиеВыбратьПоНаименованию: V82.СправочникиСсылка.ТорговоеОборудование,IReturn<ТорговоеОборудованиеВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ТорговоеОборудование/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ТорговоеОборудованиеСтраницаПоСсылке: V82.СправочникиСсылка.ТорговоеОборудование,IReturn<ТорговоеОборудованиеСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ТорговоеОборудование/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ТорговоеОборудованиеСтраницаПоКоду: V82.СправочникиСсылка.ТорговоеОборудование,IReturn<ТорговоеОборудованиеСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ТорговоеОборудование/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ТорговоеОборудованиеСтраницаПоНаименованию: V82.СправочникиСсылка.ТорговоеОборудование,IReturn<ТорговоеОборудованиеСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ТорговоеОборудованиеОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ТорговоеОборудованиеСервис : Service
	{
		
		public object Get(ТорговоеОборудованиеЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ТорговоеОборудованиеНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ТорговоеОборудованиеНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ТорговоеОборудование.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ТорговоеОборудованиеОтвет() {Ответ = "ТорговоеОборудование c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(ТорговоеОборудованиеНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ТорговоеОборудованиеВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.ТорговоеОборудование.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(ТорговоеОборудованиеВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ТорговоеОборудованиеВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ТорговоеОборудованиеСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ТорговоеОборудованиеСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ТорговоеОборудованиеСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ТорговоеОборудованиеЗапрос Запрос)
		{
			return new ТорговоеОборудованиеОтвет {Ответ = "ТорговоеОборудование, "};
		}

		public object Post(ТорговоеОборудованиеЗапрос ЗапросТорговоеОборудование)
		{
			var Ссылка = (СправочникиСсылка.ТорговоеОборудование)ЗапросТорговоеОборудование;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}