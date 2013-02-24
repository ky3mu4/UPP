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
	public partial class ЭДПрисоединенныеФайлы:СправочникОбъект
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
		public string/*150*/ Наименование {get;set;}
		///<summary>
		///Автор - пользователь, добавивший файл
		///</summary>
		[DataMember]
		[ProtoMember(7)]
		public V82.СправочникиСсылка.Пользователи Автор {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public V82.Перечисления/*Ссылка*/.ВидыЭД ВидЭД {get;set;}//Вид ЭД
		[DataMember]
		[ProtoMember(9)]
		public object ВладелецФайла {get;set;}//Владелец файла
		[DataMember]
		[ProtoMember(10)]
		public DateTime ДатаДокументаОтправителя {get;set;}//Дата документа отправителя
		[DataMember]
		[ProtoMember(11)]
		public DateTime ДатаИзмененияСтатусаЭД {get;set;}//Дата изменения статуса ЭД
		[DataMember]
		[ProtoMember(12)]
		public DateTime ДатаМодификацииУниверсальная {get;set;}//Дата модификации универсальная
		///<summary>
		///Дата добавления файла в базу
		///</summary>
		[DataMember]
		[ProtoMember(13)]
		public DateTime ДатаСоздания {get;set;}//Дата создания
		[DataMember]
		[ProtoMember(14)]
		public DateTime ДатаФормированияЭДОтправителем {get;set;}//Дата формирования ЭД отправителем
		[DataMember]
		[ProtoMember(15)]
		public bool Загружен {get;set;}
		[DataMember]
		[ProtoMember(16)]
		public bool Зашифрован {get;set;}
		///<summary>
		///Пользователь, изменивший файл
		///</summary>
		[DataMember]
		[ProtoMember(17)]
		public V82.СправочникиСсылка.Пользователи Изменил {get;set;}
		///<summary>
		///Индекс иконки, соответствующей расширению файла, для показа в списке
		///</summary>
		[DataMember]
		[ProtoMember(18)]
		public decimal/*(10)*/ ИндексКартинки {get;set;}//Индекс картинки
		[DataMember]
		[ProtoMember(19)]
		public V82.СправочникиСсылка.Контрагенты Контрагент {get;set;}
		[DataMember]
		[ProtoMember(20)]
		public V82.Перечисления/*Ссылка*/.НаправленияЭД НаправлениеЭД {get;set;}//Направление ЭД
		[DataMember]
		[ProtoMember(21)]
		public decimal/*(3)*/ НомерВерсииЭД {get;set;}//Номер версии ЭД
		[DataMember]
		[ProtoMember(22)]
		public string/*(30)*/ НомерДокументаОтправителя {get;set;}//Номер документа отправителя
		[DataMember]
		[ProtoMember(23)]
		public string/*(150)*/ НомерЭД {get;set;}//Номер ЭД
		///<summary>
		///Описание файла
		///</summary>
		[DataMember]
		[ProtoMember(24)]
		public string/*(0)*/ Описание {get;set;}
		[DataMember]
		[ProtoMember(25)]
		public V82.СправочникиСсылка.Организации Организация {get;set;}
		[DataMember]
		[ProtoMember(26)]
		public V82.СправочникиСсылка.Пользователи Ответственный {get;set;}
		[DataMember]
		[ProtoMember(27)]
		public string/*(50)*/ ОтправительЭД {get;set;}//Отправитель ЭД
		[DataMember]
		[ProtoMember(28)]
		public bool ПодписанЭЦП {get;set;}//Подписан ЭЦП
		[DataMember]
		[ProtoMember(29)]
		public string/*(50)*/ ПолучательЭД {get;set;}//Получатель ЭД
		[DataMember]
		[ProtoMember(30)]
		public string/*(0)*/ ПричинаОтклонения {get;set;}//Причина отклонения
		///<summary>
		///Дополнительный путь к файлу на диске (в случае, если "Тип хранения файла" - на диске)
		///</summary>
		[DataMember]
		[ProtoMember(31)]
		public string/*(0)*/ ПутьКФайлу {get;set;}//Путь к файлу
		///<summary>
		///Размер файла
		///</summary>
		[DataMember]
		[ProtoMember(32)]
		public decimal/*(10)*/ Размер {get;set;}
		///<summary>
		///Расширение файла версии
		///</summary>
		[DataMember]
		[ProtoMember(33)]
		public string/*(10)*/ Расширение {get;set;}
		///<summary>
		///Пользователь, занявший файл для редактирования
		///</summary>
		[DataMember]
		[ProtoMember(34)]
		public V82.СправочникиСсылка.Пользователи Редактирует {get;set;}
		[DataMember]
		[ProtoMember(35)]
		public V82.СправочникиСсылка.СоглашенияОбИспользованииЭД СоглашениеЭД {get;set;}//Соглашение ЭД
		///<summary>
		///Статус извлечения текста - для фонового задания извлечения текста
		///</summary>
		[DataMember]
		[ProtoMember(36)]
		public V82.Перечисления/*Ссылка*/.СтатусыИзвлеченияТекстаФайлов СтатусИзвлеченияТекста {get;set;}//Статус извлечения текста
		[DataMember]
		[ProtoMember(37)]
		public V82.Перечисления/*Ссылка*/.СтатусыЭД СтатусЭД {get;set;}//Статус ЭД
		///<summary>
		///Текст, извлеченный из файла - для полнотекстового поиска
		///</summary>
		[DataMember]
		[ProtoMember(38)]
		public ХранилищеЗначения ТекстХранилище {get;set;}//Текст
		///<summary>
		///Где хранятся файлы - в базе как ХранилищеЗначения или в каталоге на диске
		///</summary>
		[DataMember]
		[ProtoMember(39)]
		public V82.Перечисления/*Ссылка*/.ТипыХраненияФайлов ТипХраненияФайла {get;set;}//Тип хранения файла
		[DataMember]
		[ProtoMember(40)]
		public V82.Перечисления/*Ссылка*/.ТипыЭлементовВерсииЭД ТипЭлементаВерсииЭД {get;set;}//Тип элемента версии ЭД
		///<summary>
		///Ссылка на том (в случае, если "Тип хранения файла" - на диске)
		///</summary>
		[DataMember]
		[ProtoMember(41)]
		public V82.СправочникиСсылка.ТомаХраненияФайлов Том {get;set;}
		[DataMember]
		[ProtoMember(42)]
		public string/*(36)*/ УникальныйИД {get;set;}//Уникальный ИД
		///<summary>
		///Служебное поле для обмена файлами в РИБ
		///</summary>
		[DataMember]
		[ProtoMember(43)]
		public ХранилищеЗначения ФайлХранилище {get;set;}//Файл хранилище
		[DataMember]
		[ProtoMember(44)]
		public V82.СправочникиСсылка.ЭДПрисоединенныеФайлы ЭлектронныйДокументВладелец {get;set;}//Электронный документ владелец
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
						Insert Into _Reference294(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Description
						,_Fld4272RRef
						,_Fld4273RRef
						,_Fld4275
						,_Fld4276
						,_Fld4277
						,_Fld4278
						,_Fld4279
						,_Fld4280
						,_Fld4281
						,_Fld4282RRef
						,_Fld4283
						,_Fld4284RRef
						,_Fld4285RRef
						,_Fld4286
						,_Fld4287
						,_Fld4288
						,_Fld4289
						,_Fld4290RRef
						,_Fld4291RRef
						,_Fld4292
						,_Fld4293
						,_Fld4294
						,_Fld4295
						,_Fld4296
						,_Fld4297
						,_Fld4298
						,_Fld4299RRef
						,_Fld4300RRef
						,_Fld4301RRef
						,_Fld4302RRef
						,_Fld4303
						,_Fld4304RRef
						,_Fld4305RRef
						,_Fld4306RRef
						,_Fld4307
						,_Fld4308
						,_Fld4309RRef)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Наименование
						,@Автор
						,@ВидЭД
						,@ДатаДокументаОтправителя
						,@ДатаИзмененияСтатусаЭД
						,@ДатаМодификацииУниверсальная
						,@ДатаСоздания
						,@ДатаФормированияЭДОтправителем
						,@Загружен
						,@Зашифрован
						,@Изменил
						,@ИндексКартинки
						,@Контрагент
						,@НаправлениеЭД
						,@НомерВерсииЭД
						,@НомерДокументаОтправителя
						,@НомерЭД
						,@Описание
						,@Организация
						,@Ответственный
						,@ОтправительЭД
						,@ПодписанЭЦП
						,@ПолучательЭД
						,@ПричинаОтклонения
						,@ПутьКФайлу
						,@Размер
						,@Расширение
						,@Редактирует
						,@СоглашениеЭД
						,@СтатусИзвлеченияТекста
						,@СтатусЭД
						,@ТекстХранилище
						,@ТипХраненияФайла
						,@ТипЭлементаВерсииЭД
						,@Том
						,@УникальныйИД
						,@ФайлХранилище
						,@ЭлектронныйДокументВладелец)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference294
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_Description	= @Наименование
						,_Fld4272RRef	= @Автор
						,_Fld4273RRef	= @ВидЭД
						,_Fld4275	= @ДатаДокументаОтправителя
						,_Fld4276	= @ДатаИзмененияСтатусаЭД
						,_Fld4277	= @ДатаМодификацииУниверсальная
						,_Fld4278	= @ДатаСоздания
						,_Fld4279	= @ДатаФормированияЭДОтправителем
						,_Fld4280	= @Загружен
						,_Fld4281	= @Зашифрован
						,_Fld4282RRef	= @Изменил
						,_Fld4283	= @ИндексКартинки
						,_Fld4284RRef	= @Контрагент
						,_Fld4285RRef	= @НаправлениеЭД
						,_Fld4286	= @НомерВерсииЭД
						,_Fld4287	= @НомерДокументаОтправителя
						,_Fld4288	= @НомерЭД
						,_Fld4289	= @Описание
						,_Fld4290RRef	= @Организация
						,_Fld4291RRef	= @Ответственный
						,_Fld4292	= @ОтправительЭД
						,_Fld4293	= @ПодписанЭЦП
						,_Fld4294	= @ПолучательЭД
						,_Fld4295	= @ПричинаОтклонения
						,_Fld4296	= @ПутьКФайлу
						,_Fld4297	= @Размер
						,_Fld4298	= @Расширение
						,_Fld4299RRef	= @Редактирует
						,_Fld4300RRef	= @СоглашениеЭД
						,_Fld4301RRef	= @СтатусИзвлеченияТекста
						,_Fld4302RRef	= @СтатусЭД
						,_Fld4303	= @ТекстХранилище
						,_Fld4304RRef	= @ТипХраненияФайла
						,_Fld4305RRef	= @ТипЭлементаВерсииЭД
						,_Fld4306RRef	= @Том
						,_Fld4307	= @УникальныйИД
						,_Fld4308	= @ФайлХранилище
						,_Fld4309RRef	= @ЭлектронныйДокументВладелец
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("Автор", Автор.Ссылка);
					Команда.Parameters.AddWithValue("ВидЭД", ВидЭД.Ключ());
					Команда.Parameters.AddWithValue("ДатаДокументаОтправителя", ДатаДокументаОтправителя);
					Команда.Parameters.AddWithValue("ДатаИзмененияСтатусаЭД", ДатаИзмененияСтатусаЭД);
					Команда.Parameters.AddWithValue("ДатаМодификацииУниверсальная", ДатаМодификацииУниверсальная);
					Команда.Parameters.AddWithValue("ДатаСоздания", ДатаСоздания);
					Команда.Parameters.AddWithValue("ДатаФормированияЭДОтправителем", ДатаФормированияЭДОтправителем);
					Команда.Parameters.AddWithValue("Загружен", Загружен);
					Команда.Parameters.AddWithValue("Зашифрован", Зашифрован);
					Команда.Parameters.AddWithValue("Изменил", Изменил.Ссылка);
					Команда.Parameters.AddWithValue("ИндексКартинки", ИндексКартинки);
					Команда.Parameters.AddWithValue("Контрагент", Контрагент.Ссылка);
					Команда.Parameters.AddWithValue("НаправлениеЭД", НаправлениеЭД.Ключ());
					Команда.Parameters.AddWithValue("НомерВерсииЭД", НомерВерсииЭД);
					Команда.Parameters.AddWithValue("НомерДокументаОтправителя", НомерДокументаОтправителя);
					Команда.Parameters.AddWithValue("НомерЭД", НомерЭД);
					Команда.Parameters.AddWithValue("Описание", Описание);
					Команда.Parameters.AddWithValue("Организация", Организация.Ссылка);
					Команда.Parameters.AddWithValue("Ответственный", Ответственный.Ссылка);
					Команда.Parameters.AddWithValue("ОтправительЭД", ОтправительЭД);
					Команда.Parameters.AddWithValue("ПодписанЭЦП", ПодписанЭЦП);
					Команда.Parameters.AddWithValue("ПолучательЭД", ПолучательЭД);
					Команда.Parameters.AddWithValue("ПричинаОтклонения", ПричинаОтклонения);
					Команда.Parameters.AddWithValue("ПутьКФайлу", ПутьКФайлу);
					Команда.Parameters.AddWithValue("Размер", Размер);
					Команда.Parameters.AddWithValue("Расширение", Расширение);
					Команда.Parameters.AddWithValue("Редактирует", Редактирует.Ссылка);
					Команда.Parameters.AddWithValue("СоглашениеЭД", СоглашениеЭД.Ссылка);
					Команда.Parameters.AddWithValue("СтатусИзвлеченияТекста", СтатусИзвлеченияТекста.Ключ());
					Команда.Parameters.AddWithValue("СтатусЭД", СтатусЭД.Ключ());
					Команда.Parameters.AddWithValue("ТекстХранилище",new byte[0]);
					Команда.Parameters.AddWithValue("ТипХраненияФайла", ТипХраненияФайла.Ключ());
					Команда.Parameters.AddWithValue("ТипЭлементаВерсииЭД", ТипЭлементаВерсииЭД.Ключ());
					Команда.Parameters.AddWithValue("Том", Том.Ссылка);
					Команда.Parameters.AddWithValue("УникальныйИД", УникальныйИД);
					Команда.Parameters.AddWithValue("ФайлХранилище",new byte[0]);
					Команда.Parameters.AddWithValue("ЭлектронныйДокументВладелец", ЭлектронныйДокументВладелец.Ссылка);
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
					Команда.CommandText = @"Delete _Reference294
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
	}
}