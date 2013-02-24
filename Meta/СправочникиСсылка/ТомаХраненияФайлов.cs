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
	///<summary>
	///Каталоги на диске для хранения файлов
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class ТомаХраненияФайлов:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("b9857000-21cf-4445-bd07-3fbcb0816986");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20121221191412.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public string/*9*/ Код {get;set;}
		public string/*150*/ Наименование {get;set;}
		///<summary>
		///Описание тома
		///</summary>
		public string/*(0)*/ Комментарий {get;set;}
		///<summary>
		///Максимальный размер файлов на томе, в Мб
		///</summary>
		public decimal/*(10)*/ МаксимальныйРазмер {get;set;}//Максимальный размер
		///<summary>
		///Полный путь в Linux
		///</summary>
		public string/*(0)*/ ПолныйПутьLinux {get;set;}//Полный путь linux
		///<summary>
		///Полный путь в UNC формате
		///</summary>
		public string/*(0)*/ ПолныйПутьWindows {get;set;}//Полный путь windows
		///<summary>
		///Определяет порядок заполнения томов - начинаем с наименьшего
		///</summary>
		public decimal/*(3)*/ ПорядокЗаполнения {get;set;}//Порядок заполнения

		public V82.СправочникиОбъект.ТомаХраненияФайлов  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.ТомаХраненияФайлов();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.Код = Код;
			Объект.Наименование = Наименование;
			Объект.Комментарий = Комментарий;
			Объект.МаксимальныйРазмер = МаксимальныйРазмер;
			Объект.ПолныйПутьLinux = ПолныйПутьLinux;
			Объект.ПолныйПутьWindows = ПолныйПутьWindows;
			Объект.ПорядокЗаполнения = ПорядокЗаполнения;
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