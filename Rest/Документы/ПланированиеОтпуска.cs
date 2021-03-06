﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//PlanirovanieOtpuska
	[Маршрут("Документы/ПланированиеОтпуска","")]
	public class ПланированиеОтпускаЗапрос: V82.ДокументыСсылка.ПланированиеОтпуска,IReturn<ПланированиеОтпускаЗапрос>
	{
	}
	[Маршрут("Документы/ПланированиеОтпуска/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ПланированиеОтпуска/ПоСсылке","{Ссылка}")]
	public class ПланированиеОтпускаНайтиПоСсылке: V82.ДокументыСсылка.ПланированиеОтпуска,IReturn<ПланированиеОтпускаНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ПланированиеОтпуска/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ПланированиеОтпуска/ПоНомеру","{Номер}")]
	public class ПланированиеОтпускаНайтиПоНомеру: V82.ДокументыСсылка.ПланированиеОтпуска,IReturn<ПланированиеОтпускаНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ПланированиеОтпуска/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ПланированиеОтпуска/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ПланированиеОтпуска/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ПланированиеОтпускаВыбратьПоСсылке: V82.ДокументыСсылка.ПланированиеОтпуска,IReturn<ПланированиеОтпускаВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ПланированиеОтпуска/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ПланированиеОтпуска/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ПланированиеОтпуска/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ПланированиеОтпускаВыбратьПоНомеру: V82.ДокументыСсылка.ПланированиеОтпуска,IReturn<ПланированиеОтпускаВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ПланированиеОтпуска/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ПланированиеОтпускаСтраницаПоСсылке: V82.ДокументыСсылка.ПланированиеОтпуска,IReturn<ПланированиеОтпускаСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ПланированиеОтпуска/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ПланированиеОтпускаСтраницаПоНомеру: V82.ДокументыСсылка.ПланированиеОтпуска,IReturn<ПланированиеОтпускаСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ПланированиеОтпускаОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ПланированиеОтпускаСервис : Service
	{
		
		public object Get(ПланированиеОтпускаЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ПланированиеОтпускаНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ПланированиеОтпуска.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ПланированиеОтпускаОтвет() { Ответ = "ПланированиеОтпуска c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПланированиеОтпускаНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ПланированиеОтпуска.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ПланированиеОтпускаОтвет() {Ответ = "ПланированиеОтпуска c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПланированиеОтпускаВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ПланированиеОтпуска.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ПланированиеОтпускаВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ПланированиеОтпускаСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПланированиеОтпускаСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ПланированиеОтпускаЗапрос Запрос)
		{
			return new ПланированиеОтпускаОтвет {Ответ = "ПланированиеОтпуска, "};
		}

		public object Post(ПланированиеОтпускаЗапрос ЗапросПланированиеОтпуска)
		{
			var Ссылка = (ДокументыСсылка.ПланированиеОтпуска)ЗапросПланированиеОтпуска;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}