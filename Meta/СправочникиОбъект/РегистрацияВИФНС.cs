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
	public partial class РегистрацияВИФНС:СправочникОбъект
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
		public Guid Владелец {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public string/*4*/ Код {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public string/*50*/ Наименование {get;set;}
		///<summary>
		///Код причины постановки
		///</summary>
		[DataMember]
		[ProtoMember(9)]
		public string/*(9)*/ КПП {get;set;}
		[DataMember]
		[ProtoMember(10)]
		public string/*(254)*/ НаименованиеИФНС {get;set;}//Наименование ИФНС
		///<summary>
		///Представитель в территориальном органе ФНС
		///</summary>
		[DataMember]
		[ProtoMember(11)]
		public object Представитель {get;set;}
		///<summary>
		///Название документа, подтверждающего полномочия представителя
		///</summary>
		[DataMember]
		[ProtoMember(12)]
		public string/*(1000)*/ ДокументПредставителя {get;set;}//Документ представителя
		[DataMember]
		[ProtoMember(13)]
		public string/*(0)*/ УполномоченноеЛицоПредставителя {get;set;}//Уполномоченное лицо представителя
		///<summary>
		///Доверенность налогоплательщика на представителя
		///</summary>
		[DataMember]
		[ProtoMember(14)]
		public V82.СправочникиСсылка.ДоверенностиНалогоплательщика Доверенность {get;set;}
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
						Insert Into _Reference219(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_OwnerIDRRef
						,_Code
						,_Description
						,_Fld3366
						,_Fld3367
						,_Fld3369
						,_Fld3370
						,_Fld3371RRef)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Владелец
						,@Код
						,@Наименование
						,@КПП
						,@НаименованиеИФНС
						,@ДокументПредставителя
						,@УполномоченноеЛицоПредставителя
						,@Доверенность)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference219
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_OwnerIDRRef	= @Владелец
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld3366	= @КПП
						,_Fld3367	= @НаименованиеИФНС
						,_Fld3369	= @ДокументПредставителя
						,_Fld3370	= @УполномоченноеЛицоПредставителя
						,_Fld3371RRef	= @Доверенность
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Владелец", Владелец);
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("КПП", КПП);
					Команда.Parameters.AddWithValue("НаименованиеИФНС", НаименованиеИФНС);
					Команда.Parameters.AddWithValue("ДокументПредставителя", ДокументПредставителя);
					Команда.Parameters.AddWithValue("УполномоченноеЛицоПредставителя", УполномоченноеЛицоПредставителя);
					Команда.Parameters.AddWithValue("Доверенность", Доверенность.Ссылка);
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
					Команда.CommandText = @"Delete _Reference219
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/

		public void ПередЗаписью(/*Отказ*/)
		{
			if(true/*ОбменДанными.Загрузка*/)
			{
			}
			//флЭтоПБОЮЛ = РегламентированнаяОтчетность.ЭтоПБОЮЛ(Владелец);
			if(true/*ПустаяСтрока(Код)*/)
			{
				//ОбщегоНазначения.СообщитьОбОшибке("Не задан код налогового органа.", Отказ);
			}
			if(true/*НЕ флЭтоПБОЮЛ*/)
			{
				if(true/*ПустаяСтрока(КПП)*/)
				{
					//ОбщегоНазначения.СообщитьОбОшибке("Не заполнен КПП.", Отказ);
				}
			}
			//СуществующаяЗапись = РегламентированнаяОтчетность.ПолучитьПоКодамРегистрациюВИФНС(Владелец, Код, КПП);
			if(true/*СуществующаяЗапись <> Неопределено И СуществующаяЗапись <> Ссылка*/)
			{
				/*ОбщегоНазначения.СообщитьОбОшибке("Для данной организации уже существует запись с указанными кодом налогового органа" 
		+ ?(флЭтоПБОЮЛ, ".", " и КПП."), Отказ);*/
			}
			if(true/*ПустаяСтрока(НаименованиеИФНС)*/)
			{
				//ОбщегоНазначения.СообщитьОбОшибке("Не заполнено полное наименование налогового органа.", Отказ);
			}
			if(true/*ЗначениеЗаполнено(Представитель) И ПустаяСтрока(ДокументПредставителя)*/)
			{
				//ОбщегоНазначения.СообщитьОбОшибке("Не задан документ, подтверждающий полномочия представителя.", Отказ);
			}
			if(true/*НЕ Отказ*/)
			{
				if(true/*ПустаяСтрока(Наименование)*/)
				{
					//Наименование = НаименованиеИФНС;
				}
				if(true/*НЕ ЗначениеЗаполнено(Представитель)*/)
				{
					//ДокументПредставителя = "";
					//УполномоченноеЛицоПредставителя = "";
				}
			}
		}
	}
}