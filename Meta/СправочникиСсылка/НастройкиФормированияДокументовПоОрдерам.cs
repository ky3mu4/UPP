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
	public partial class НастройкиФормированияДокументовПоОрдерам:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("a0880213-3adc-43d3-8a9a-415e2766ce31");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20121221191525.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public Guid Родитель {get;set;}
		public bool ЭтоГруппа {get;set;}
		public string/*100*/ Наименование {get;set;}
		///<summary>
		///Формировать документы автоматически (регламентным заданием)
		///</summary>
		public bool ФормироватьДокументыАвтоматически {get;set;}//Формировать документы автоматически
		///<summary>
		///Уникальный идентификатор регламентного задания
		///</summary>
		public string/*(36)*/ РегламентноеЗадание {get;set;}//Регламентное задание
		public ХранилищеЗначения НастройкиКомпоновщика {get;set;}//Настройки компоновщика
		public string/*(0)*/ Комментарий {get;set;}
		public V82.Перечисления/*Ссылка*/.Периодичность ПериодДетализации {get;set;}//Период детализации
		public bool ОтражатьВУправленческомУчете {get;set;}//Отражать в управленческом учете
		public bool ОтражатьВБухгалтерскомУчете {get;set;}//Отражать в бухгалтерском учете
		public bool ОтражатьВНалоговомУчете {get;set;}//Отражать в налоговом учете
		///<summary>
		///Дата, по которую учтены данные в сформированных документах
		///</summary>
		public DateTime ГраницаОбработки {get;set;}//Граница обработки
		public object ШаблонРегулярногоДокумента {get;set;}//Шаблон регулярного документа
		public string/*(50)*/ ВидРегулярногоДокумента {get;set;}//Вид регулярного документа
		public bool НеОбрабатыватьВсеДокументы {get;set;}//Не обрабатывать все документы
		///<summary>
		///Количество дней после окончания периода, по истечении которых формируются документы
		///</summary>
		public decimal/*(2)*/ Задержка {get;set;}

		public V82.СправочникиОбъект.НастройкиФормированияДокументовПоОрдерам  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.НастройкиФормированияДокументовПоОрдерам();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.Родитель = Родитель;
			Объект.ЭтоГруппа = ЭтоГруппа;
			Объект.Наименование = Наименование;
			Объект.ФормироватьДокументыАвтоматически = ФормироватьДокументыАвтоматически;
			Объект.РегламентноеЗадание = РегламентноеЗадание;
			Объект.НастройкиКомпоновщика = НастройкиКомпоновщика;
			Объект.Комментарий = Комментарий;
			Объект.ПериодДетализации = ПериодДетализации;
			Объект.ОтражатьВУправленческомУчете = ОтражатьВУправленческомУчете;
			Объект.ОтражатьВБухгалтерскомУчете = ОтражатьВБухгалтерскомУчете;
			Объект.ОтражатьВНалоговомУчете = ОтражатьВНалоговомУчете;
			Объект.ГраницаОбработки = ГраницаОбработки;
			Объект.ШаблонРегулярногоДокумента = ШаблонРегулярногоДокумента;
			Объект.ВидРегулярногоДокумента = ВидРегулярногоДокумента;
			Объект.НеОбрабатыватьВсеДокументы = НеОбрабатыватьВсеДокументы;
			Объект.Задержка = Задержка;
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