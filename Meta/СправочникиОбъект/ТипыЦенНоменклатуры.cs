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
	///<summary>
	///(Упр)
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class ТипыЦенНоменклатуры:СправочникОбъект
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
		public string/*9*/ Код {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public string/*25*/ Наименование {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(8)]
		public V82.СправочникиСсылка.Валюты ВалютаЦены {get;set;}//Валюта цены по умолчанию
		///<summary>
		///(Общ) Тип цен, от которого рассчитываются цены данного типа, если не выбран, то цены задаются вручную
		///</summary>
		[DataMember]
		[ProtoMember(9)]
		public V82.СправочникиСсылка.ТипыЦенНоменклатуры БазовыйТипЦен {get;set;}//Базовый тип цен
		///<summary>
		///(Общ) Истина - цены автоматически рассчитываются (не хранятся) на основании цен базового типа
		///</summary>
		[DataMember]
		[ProtoMember(10)]
		public bool Рассчитывается {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(11)]
		public decimal/*(5.2)*/ ПроцентСкидкиНаценки {get;set;}//Процент скидки или наценки по умолчанию
		///<summary>
		///(Общ) Истина - цена включает НДС, ложь - не включает
		///</summary>
		[DataMember]
		[ProtoMember(12)]
		public bool ЦенаВключаетНДС {get;set;}//Цена включает НДС
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(13)]
		public V82.Перечисления/*Ссылка*/.ПорядкиОкругления ПорядокОкругления {get;set;}//Порядок округления
		///<summary>
		///(Общ) Истина, то при порядке округления "5" 0.01 будет округлена до 5, ложь - округление по арифметическим правилам
		///</summary>
		[DataMember]
		[ProtoMember(14)]
		public bool ОкруглятьВБольшуюСторону {get;set;}//Округлять в большую сторону
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		[DataMember]
		[ProtoMember(15)]
		public string/*(0)*/ Комментарий {get;set;}
		[DataMember]
		[ProtoMember(16)]
		public V82.Перечисления/*Ссылка*/.СпособыРасчетаЦены СпособРасчетаЦены {get;set;}//Способ расчета цены
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
						Insert Into _Reference269(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld3965RRef
						,_Fld3966RRef
						,_Fld3967
						,_Fld3968
						,_Fld3969
						,_Fld3970RRef
						,_Fld3971
						,_Fld3972
						,_Fld3973RRef)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Код
						,@Наименование
						,@ВалютаЦены
						,@БазовыйТипЦен
						,@Рассчитывается
						,@ПроцентСкидкиНаценки
						,@ЦенаВключаетНДС
						,@ПорядокОкругления
						,@ОкруглятьВБольшуюСторону
						,@Комментарий
						,@СпособРасчетаЦены)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference269
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld3965RRef	= @ВалютаЦены
						,_Fld3966RRef	= @БазовыйТипЦен
						,_Fld3967	= @Рассчитывается
						,_Fld3968	= @ПроцентСкидкиНаценки
						,_Fld3969	= @ЦенаВключаетНДС
						,_Fld3970RRef	= @ПорядокОкругления
						,_Fld3971	= @ОкруглятьВБольшуюСторону
						,_Fld3972	= @Комментарий
						,_Fld3973RRef	= @СпособРасчетаЦены
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("ВалютаЦены", ВалютаЦены.Ссылка);
					Команда.Parameters.AddWithValue("БазовыйТипЦен", БазовыйТипЦен.Ссылка);
					Команда.Parameters.AddWithValue("Рассчитывается", Рассчитывается);
					Команда.Parameters.AddWithValue("ПроцентСкидкиНаценки", ПроцентСкидкиНаценки);
					Команда.Parameters.AddWithValue("ЦенаВключаетНДС", ЦенаВключаетНДС);
					Команда.Parameters.AddWithValue("ПорядокОкругления", ПорядокОкругления.Ключ());
					Команда.Parameters.AddWithValue("ОкруглятьВБольшуюСторону", ОкруглятьВБольшуюСторону);
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
					Команда.Parameters.AddWithValue("СпособРасчетаЦены", СпособРасчетаЦены.Ключ());
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
					Команда.CommandText = @"Delete _Reference269
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/
		// Обработчик события ПередЗаписью объекта.
		//

		public void ПередЗаписью(/*Отказ*/)
		{
			if(true/*НЕ ОбменДанными.Загрузка И ЗначениеЗаполнено(БазовыйТипЦен)*/)
			{
				/*// Если цена расчетная и введена на основании расчетной- это неправильно - записывать нельзя
*/
				if(true/*БазовыйТипЦен.Рассчитывается*/)
				{
					//ОбщегоНазначения.СообщитьОбОшибке("Базовый тип цен не может быть динамическим!", Отказ);
				}
			}
			if(true/*НЕ ОбменДанными.Загрузка И Не ЭтоГруппа*/)
			{
				if(true/*Рассчитывается*/)
				{
					/*// Если цена расчетная и на основании её введена уже расчетная - это неправильно - записывать нельзя
*/
					//Запрос = Новый Запрос;
					//Запрос.УстановитьПараметр("ТекущийТипЦен", ЭтотОбъект.Ссылка);
					/*Запрос.Текст =
			"ВЫБРАТЬ
			|	ТипЦен.Рассчитывается КАК Рассчитывается,
			|	ТипЦен.БазовыйТипЦен КАК БазовыйТипЦен
			|ИЗ
			|	Справочник.ТипыЦенНоменклатуры КАК ТипЦен
			|
			|ГДЕ
			|	ТипЦен.БазовыйТипЦен = &ТекущийТипЦен
			| И ТипЦен.Рассчитывается = Истина";*/
					//ВыборкаЦен = Запрос.Выполнить().Выбрать();
					if(true/*ВыборкаЦен.Следующий()*/)
					{
						//ОбщегоНазначения.СообщитьОбОшибке("Этот тип цен уже используется как базовый, он уже не может быть динамическим!", Отказ);
					}
				}
			}
			if(true/*НЕ ОбменДанными.Загрузка*/)
			{
				//НастройкаПравДоступа.ПередЗаписьюНовогоОбъектаСПравамиДоступаПользователей(ЭтотОбъект, Отказ, Родитель);
			}
		}
	}
}