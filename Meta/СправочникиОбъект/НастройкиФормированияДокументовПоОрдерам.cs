﻿
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.СправочникиОбъект;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиОбъект
{
	[ProtoContract]
	[DataContract]
	public partial class НастройкиФормированияДокументовПоОрдерам:СправочникОбъект
	{
		public bool _ЭтоНовый;
		public bool ЭтоНовый()
		{
			return _ЭтоНовый;
		}
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		[DataMember]
		[ProtoMember(3)]
		public string ВерсияДанных {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		[DataMember]
		[ProtoMember(4)]
		public bool ПометкаУдаления {get;set;}
		[DataMember]
		[ProtoMember(5)]
		public bool Предопределенный {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public Guid Родитель {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public bool ЭтоГруппа {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public string/*100*/ Наименование {get;set;}
		///<summary>
		///Формировать документы автоматически (регламентным заданием)
		///</summary>
		[DataMember]
		[ProtoMember(9)]
		public bool ФормироватьДокументыАвтоматически {get;set;}//Формировать документы автоматически
		///<summary>
		///Уникальный идентификатор регламентного задания
		///</summary>
		[DataMember]
		[ProtoMember(10)]
		public string/*(36)*/ РегламентноеЗадание {get;set;}//Регламентное задание
		[DataMember]
		[ProtoMember(11)]
		public ХранилищеЗначения НастройкиКомпоновщика {get;set;}//Настройки компоновщика
		[DataMember]
		[ProtoMember(12)]
		public string/*(0)*/ Комментарий {get;set;}
		[DataMember]
		[ProtoMember(13)]
		public V82.Перечисления/*Ссылка*/.Периодичность ПериодДетализации {get;set;}//Период детализации
		[DataMember]
		[ProtoMember(14)]
		public bool ОтражатьВУправленческомУчете {get;set;}//Отражать в управленческом учете
		[DataMember]
		[ProtoMember(15)]
		public bool ОтражатьВБухгалтерскомУчете {get;set;}//Отражать в бухгалтерском учете
		[DataMember]
		[ProtoMember(16)]
		public bool ОтражатьВНалоговомУчете {get;set;}//Отражать в налоговом учете
		///<summary>
		///Дата, по которую учтены данные в сформированных документах
		///</summary>
		[DataMember]
		[ProtoMember(17)]
		public DateTime ГраницаОбработки {get;set;}//Граница обработки
		[DataMember]
		[ProtoMember(18)]
		public object ШаблонРегулярногоДокумента {get;set;}//Шаблон регулярного документа
		[DataMember]
		[ProtoMember(19)]
		public string/*(50)*/ ВидРегулярногоДокумента {get;set;}//Вид регулярного документа
		[DataMember]
		[ProtoMember(20)]
		public bool НеОбрабатыватьВсеДокументы {get;set;}//Не обрабатывать все документы
		///<summary>
		///Количество дней после окончания периода, по истечении которых формируются документы
		///</summary>
		[DataMember]
		[ProtoMember(21)]
		public decimal/*(2)*/ Задержка {get;set;}
		public void Записать()
		{
			//Установка блокировки элемента на горизантально масштабированный кластер.
			//Опционально введение тайм аута на запись одного и того же объекта, не чаще раза в 5-секунд. Защита от спама. упращение алгоритма блокировки.
			//Выделение сервиса для блокировки элемента и генерации кода
			//Выполнение операций контроля без обращений к sql-серверу.
			//Контроль конфликта блокировок.
			//Контроль загрузки булкинсертом гетерогенной коллекции.
			//Контроль уникальности кода для справочников.
			//Контроль уникальности номера для документов, в границах префикса.
			//Контроль владельца, он не может быть группой.
			//Контроль владельца он должен быть задан.
			//Контроль родителя он должен быть группой.
			//Контроль количества уровней, должен соотвествовать метаданным.
			//Контроль версии, объект не должен был быть записан перед чтением текущей записи, алгоритм версионника.
			//Контроль уникальности ссылки
			//Контроль зацикливания
			//Опционально контроль битых ссылок.
			//Соблюдейние транзакционности. ПередЗаписью. Открытие транзации. Валидации. ПриЗаписи. Фиксация транзакции. Информирование о записи элемента.
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					if(_ЭтоНовый)
					{
						Команда.CommandText = @"
						Insert Into _Reference160(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_ParentIDRRef
						,_Folder
						,_Description
						,_Fld2882
						,_Fld2883
						,_Fld2884
						,_Fld2885
						,_Fld2886RRef
						,_Fld2887
						,_Fld2888
						,_Fld2889
						,_Fld2890
						,_Fld2892
						,_Fld2893
						,_Fld2894)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Родитель
						,@ЭтоГруппа
						,@Наименование
						,@ФормироватьДокументыАвтоматически
						,@РегламентноеЗадание
						,@НастройкиКомпоновщика
						,@Комментарий
						,@ПериодДетализации
						,@ОтражатьВУправленческомУчете
						,@ОтражатьВБухгалтерскомУчете
						,@ОтражатьВНалоговомУчете
						,@ГраницаОбработки
						,@ВидРегулярногоДокумента
						,@НеОбрабатыватьВсеДокументы
						,@Задержка)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference160
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_ParentIDRRef	= @Родитель
						,_Folder	= @ЭтоГруппа
						,_Description	= @Наименование
						,_Fld2882	= @ФормироватьДокументыАвтоматически
						,_Fld2883	= @РегламентноеЗадание
						,_Fld2884	= @НастройкиКомпоновщика
						,_Fld2885	= @Комментарий
						,_Fld2886RRef	= @ПериодДетализации
						,_Fld2887	= @ОтражатьВУправленческомУчете
						,_Fld2888	= @ОтражатьВБухгалтерскомУчете
						,_Fld2889	= @ОтражатьВНалоговомУчете
						,_Fld2890	= @ГраницаОбработки
						,_Fld2892	= @ВидРегулярногоДокумента
						,_Fld2893	= @НеОбрабатыватьВсеДокументы
						,_Fld2894	= @Задержка
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Родитель", Родитель);
					Команда.Parameters.AddWithValue("ЭтоГруппа", ЭтоГруппа?new byte[]{0}:new byte[]{1});
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("ФормироватьДокументыАвтоматически", ФормироватьДокументыАвтоматически);
					Команда.Parameters.AddWithValue("РегламентноеЗадание", РегламентноеЗадание);
					Команда.Parameters.AddWithValue("НастройкиКомпоновщика",new byte[0]);
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
					Команда.Parameters.AddWithValue("ПериодДетализации", ПериодДетализации.Ключ());
					Команда.Parameters.AddWithValue("ОтражатьВУправленческомУчете", ОтражатьВУправленческомУчете);
					Команда.Parameters.AddWithValue("ОтражатьВБухгалтерскомУчете", ОтражатьВБухгалтерскомУчете);
					Команда.Parameters.AddWithValue("ОтражатьВНалоговомУчете", ОтражатьВНалоговомУчете);
					Команда.Parameters.AddWithValue("ГраницаОбработки", ГраницаОбработки);
					Команда.Parameters.AddWithValue("ВидРегулярногоДокумента", ВидРегулярногоДокумента);
					Команда.Parameters.AddWithValue("НеОбрабатыватьВсеДокументы", НеОбрабатыватьВсеДокументы);
					Команда.Parameters.AddWithValue("Задержка", Задержка);
					Команда.ExecuteNonQuery();
				}
			}
		}
		public void Удалить()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Delete _Reference160
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/
		////////////////////////////////////////////////////////////////////////////////
		// ОБЩИЕ ПРОЦЕДУРЫ И ФУНКЦИИ
		// Выполняет проверку заполненности реквизитов.
		//
		// Параметры
		//	Заголовок - заголовок сообщения об ошибке
		//
		// Возвращаемое значение
		//	Истина  - все проверяемые реквизиты заполнены
		//	Ложь	- не все проверяемые реквизиты заполнены

		public object РеквизитыЗаполнены(/*Знач Заголовок*/)
		{
			if(true/*ЭтотОбъект.ЭтоГруппа*/)
			{
			}
			//Отказ = Ложь;
			/*// Должны быть заполнены обязательные реквизиты
*/
			//СтруктураОбязательныхПолей = Новый Структура();
			//СтруктураОбязательныхПолей.Вставить("ПериодДетализации",	"Не указан период детализации формируемых документов");
			//СтруктураОбязательныхПолей.Вставить("ВидРегулярногоДокумента",	"Не указан вид формируемых документов");
			//ЗаполнениеДокументов.ПроверитьЗаполнениеШапкиДокумента(ЭтотОбъект, СтруктураОбязательныхПолей, Отказ, Заголовок);
			/*// Документ должен принадлежать хотя бы к одному виду учета (управленческий, бухгалтерский, налоговый)
*/
			//СтруктураШапкиДокумента = Новый Структура("ОтражатьВУправленческомУчете,ОтражатьВБухгалтерскомУчете,ОтражатьВНалоговомУчете");
			//ЗаполнитьЗначенияСвойств(СтруктураШапкиДокумента, ЭтотОбъект);
			//ОбщегоНазначения.ПроверитьПринадлежностьКВидамУчета(СтруктураШапкиДокумента, Отказ, Заголовок);
			return null;
		}
		// Подготавливает заголовок сообщений об ошибках при записи
		//
		// Возвращаемое значение
		//  Строка, заголовок сообщений

		public object ЗаголовокПриЗаписи(/**/)
		{
			return null;
		}
		// Возвращает имя объекта метаданных для создания регл. задания
		//
		// Возвращаемое значение
		//	Строка  - имя объекта метаданных

		public object ИмяРегламентногоЗадания(/**/)
		{
			return null;
		}

		public void ПередЗаписью(/*Отказ*/)
		{
			/*// Проверим заполнение реквизитов
*/
			//Заголовок = ЗаголовокПриЗаписи();
			//Отказ = НЕ РеквизитыЗаполнены(Заголовок);
		}
		//Функция проверяет корректность отборов:
		//	отбор по виду операции должен соответствовать отбору по направлению
		//Возвращаемое значение - булево (истина - отбор корректен, ложь - обнаружены несоответствия)

		public object ПроверитьНастройкиОтбора(/**/)
		{
			//КомпоновщикНастроек = Новый КомпоновщикНастроекКомпоновкиДанных;
			//ТекНастройкиКомпоновщика = НастройкиКомпоновщика.Получить();
			//КомпоновщикНастроек.ЗагрузитьНастройки(ТекНастройкиКомпоновщика);
			//ОтборКомпоновщикНастроек = КомпоновщикНастроек.Настройки.Отбор.Элементы;
			//ОтборНаправление = Неопределено;
			/*//значение отбора по полю Направление
*/
			//МассивОтборВидОперации = Новый Массив;
			/*//массив значений отбора по полю ВидОперации
*/
			if(true/*ОтборНаправление = Неопределено ИЛИ МассивОтборВидОперации.Количество() = 0*/)
			{
			}
			//ЗначениеОтборНаправление = НРег(СокрЛП(ОтборНаправление.ПравоеЗначение));
			if(true/*ЗначениеОтборНаправление = "приход"*/)
			{
				//ТипЗначенияВидОперации = Тип("ПеречислениеСсылка.ВидыОперацийПриходныйОрдер");
			}
			return null;
		}

		public void ОбработатьГруппуЭлементовОтбора(/*ГруппаЭлементовОтбора, ОтборНаправление, МассивОтборВидОперации*/)
		{
		}

		public void ОбработатьЭлементОтбора(/*ЭлементОтбора, ОтборНаправление, МассивОтборВидОперации*/)
		{
			if(true/*НЕ ЭлементОтбора.Использование*/)
			{
			}
			if(true/*НРег(СокрЛП(ЭлементОтбора.ЛевоеЗначение)) = "направление"*/)
			{
				//ОтборНаправление = ЭлементОтбора;
			}
		}
	}
}