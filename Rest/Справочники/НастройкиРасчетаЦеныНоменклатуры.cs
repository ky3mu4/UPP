﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//NastrojjkiRaschetaCenyNomenklatury
	[Маршрут("Справочники/НастройкиРасчетаЦеныНоменклатуры","")]
	public class НастройкиРасчетаЦеныНоменклатурыЗапрос: V82.СправочникиСсылка.НастройкиРасчетаЦеныНоменклатуры,IReturn<НастройкиРасчетаЦеныНоменклатурыЗапрос>
	{
	}
	[Маршрут("Справочники/НастройкиРасчетаЦеныНоменклатуры/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/НастройкиРасчетаЦеныНоменклатуры/ПоСсылке","{Ссылка}")]
	public class НастройкиРасчетаЦеныНоменклатурыНайтиПоСсылке: V82.СправочникиСсылка.НастройкиРасчетаЦеныНоменклатуры,IReturn<НастройкиРасчетаЦеныНоменклатурыНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/НастройкиРасчетаЦеныНоменклатуры/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/НастройкиРасчетаЦеныНоменклатуры/ПоНаименованию","{Наименование}")]
	public class НастройкиРасчетаЦеныНоменклатурыНайтиПоНаименованию: V82.СправочникиСсылка.НастройкиРасчетаЦеныНоменклатуры,IReturn<НастройкиРасчетаЦеныНоменклатурыНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/НастройкиРасчетаЦеныНоменклатуры/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/НастройкиРасчетаЦеныНоменклатуры/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/НастройкиРасчетаЦеныНоменклатуры/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class НастройкиРасчетаЦеныНоменклатурыВыбратьПоСсылке: V82.СправочникиСсылка.НастройкиРасчетаЦеныНоменклатуры,IReturn<НастройкиРасчетаЦеныНоменклатурыВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/НастройкиРасчетаЦеныНоменклатуры/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/НастройкиРасчетаЦеныНоменклатуры/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/НастройкиРасчетаЦеныНоменклатуры/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class НастройкиРасчетаЦеныНоменклатурыВыбратьПоНаименованию: V82.СправочникиСсылка.НастройкиРасчетаЦеныНоменклатуры,IReturn<НастройкиРасчетаЦеныНоменклатурыВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/НастройкиРасчетаЦеныНоменклатуры/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class НастройкиРасчетаЦеныНоменклатурыСтраницаПоСсылке: V82.СправочникиСсылка.НастройкиРасчетаЦеныНоменклатуры,IReturn<НастройкиРасчетаЦеныНоменклатурыСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/НастройкиРасчетаЦеныНоменклатуры/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class НастройкиРасчетаЦеныНоменклатурыСтраницаПоНаименованию: V82.СправочникиСсылка.НастройкиРасчетаЦеныНоменклатуры,IReturn<НастройкиРасчетаЦеныНоменклатурыСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/НастройкиРасчетаЦеныНоменклатуры/ИерархияВыбратьПоСсылке","{___Родитель}/{___Режим}/{___Первые}")]
	[Маршрут("Справочники/НастройкиРасчетаЦеныНоменклатуры/ИерархияВыбратьПоСсылке","{___Родитель}/{___Режим}/{___Первые}/{___Мин}")]
	[Маршрут("Справочники/НастройкиРасчетаЦеныНоменклатуры/ИерархияВыбратьПоСсылке","{___Родитель}/{___Режим}/{___Первые}/{___Мин}/{___Макс}")]
	public class НастройкиРасчетаЦеныНоменклатурыИерархияВыбратьПоСсылке: V82.СправочникиСсылка.НастройкиРасчетаЦеныНоменклатуры,IReturn<НастройкиРасчетаЦеныНоменклатурыИерархияВыбратьПоСсылке>
	{
		public Guid ___Родитель {get; set;}
		public int ___Режим {get; set;}
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/НастройкиРасчетаЦеныНоменклатуры/ИерархияСтраницаПоСсылке","{___Родитель}/{___Режим}/{___Размер}/{___Номер}")]
	public class НастройкиРасчетаЦеныНоменклатурыИерархияСтраницаПоСсылке: V82.СправочникиСсылка.НастройкиРасчетаЦеныНоменклатуры,IReturn<НастройкиРасчетаЦеныНоменклатурыИерархияСтраницаПоСсылке>
	{
		public Guid ___Родитель {get; set;}
		public int ___Режим {get; set;}
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class НастройкиРасчетаЦеныНоменклатурыОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class НастройкиРасчетаЦеныНоменклатурыСервис : Service
	{
		
		public object Get(НастройкиРасчетаЦеныНоменклатурыЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(НастройкиРасчетаЦеныНоменклатурыНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.НастройкиРасчетаЦеныНоменклатуры.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new НастройкиРасчетаЦеныНоменклатурыОтвет() { Ответ = "НастройкиРасчетаЦеныНоменклатуры c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(НастройкиРасчетаЦеныНоменклатурыНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(НастройкиРасчетаЦеныНоменклатурыВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.НастройкиРасчетаЦеныНоменклатуры.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(НастройкиРасчетаЦеныНоменклатурыВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(НастройкиРасчетаЦеныНоменклатурыСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(НастройкиРасчетаЦеныНоменклатурыСтраницаПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(НастройкиРасчетаЦеныНоменклатурыИерархияВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.НастройкиРасчетаЦеныНоменклатуры.ИерархияВыбратьПоСсылке(Запрос.___Родитель,Запрос.___Режим,Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(НастройкиРасчетаЦеныНоменклатурыИерархияСтраницаПоСсылке Запрос)
		{
			return null;
		}

		public object Any(НастройкиРасчетаЦеныНоменклатурыЗапрос Запрос)
		{
			return new НастройкиРасчетаЦеныНоменклатурыОтвет {Ответ = "НастройкиРасчетаЦеныНоменклатуры, "};
		}

		public object Post(НастройкиРасчетаЦеныНоменклатурыЗапрос ЗапросНастройкиРасчетаЦеныНоменклатуры)
		{
			var Ссылка = (СправочникиСсылка.НастройкиРасчетаЦеныНоменклатуры)ЗапросНастройкиРасчетаЦеныНоменклатуры;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}