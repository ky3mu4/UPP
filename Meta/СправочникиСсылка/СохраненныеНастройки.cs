﻿
using System;
using System.IO;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиСсылка
{
	[ProtoContract]
	[DataContract]
	public partial class СохраненныеНастройки:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("f9f2b5a1-8050-4cb5-bdaa-d5e15d3f3ca1");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20121221191256.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
		public static readonly long КонтрольнаяСуммаКласса = 123;
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		public string ВерсияДанных {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		public bool ПометкаУдаления {get;set;}
		public bool Предопределенный {get;set;}
		public string/*100*/ Наименование {get;set;}
		public V82.Перечисления/*Ссылка*/.ТипыНастроек ТипНастройки {get;set;}//Тип настройки
		public object НастраиваемыйОбъект {get;set;}//Настраиваемый объект
		public bool СохранятьАвтоматически {get;set;}//Сохранять автоматически
		public bool ИспользоватьПриОткрытии {get;set;}//Использовать при открытии
		public bool СохранятьПериод {get;set;}//Сохранять период
		public bool ОткрыватьПриЗапуске {get;set;}//Открывать при запуске
		public ХранилищеЗначения ХранилищеНастроек {get;set;}//Хранилище настроек
		public string/*(1000)*/ Описание {get;set;}
		public string/*(100)*/ КраткийСоставНастройки {get;set;}//Краткий состав настройки

		public V82.СправочникиОбъект.СохраненныеНастройки  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.СохраненныеНастройки();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.Наименование = Наименование;
			Объект.ТипНастройки = ТипНастройки;
			Объект.НастраиваемыйОбъект = НастраиваемыйОбъект;
			Объект.СохранятьАвтоматически = СохранятьАвтоматически;
			Объект.ИспользоватьПриОткрытии = ИспользоватьПриОткрытии;
			Объект.СохранятьПериод = СохранятьПериод;
			Объект.ОткрыватьПриЗапуске = ОткрыватьПриЗапуске;
			Объект.ХранилищеНастроек = ХранилищеНастроек;
			Объект.Описание = Описание;
			Объект.КраткийСоставНастройки = КраткийСоставНастройки;
			return Объект;
		}

		public void СериализацияProtoBuf(Stream Поток)
		{
			Serializer.Serialize(Поток,this);
		}

		public string СериализацияJson()
		{
			return this.ToJson();
		}

		public string СериализацияXml()
		{
			return this.ToXml();
		}
	}
}