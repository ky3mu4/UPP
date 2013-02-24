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
	public partial class НастройкиОбменаДанными:СправочникОбъект
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
		public string/*3*/ Код {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public string/*150*/ Наименование {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public ПланОбменаСсылка УзелИнформационнойБазы {get;set;}//Узел информационной базы
		[DataMember]
		[ProtoMember(9)]
		public V82.Перечисления/*Ссылка*/.ТипыАвтоматическогоОбменаДанными ТипНастройки {get;set;}//Тип настройки
		[DataMember]
		[ProtoMember(10)]
		public bool ПроизводитьПриемСообщений {get;set;}//Производить прием сообщений
		[DataMember]
		[ProtoMember(11)]
		public bool ПроизводитьОтправкуСообщений {get;set;}//Производить отправку сообщений
		[DataMember]
		[ProtoMember(12)]
		public decimal/*(10)*/ КоличествоЭлементовВТранзакцииНаВыгрузкуДанных {get;set;}//Количество элементов в транзакции на выгрузку данных
		[DataMember]
		[ProtoMember(13)]
		public decimal/*(10)*/ КоличествоЭлементовВТранзакцииНаЗагрузкуДанных {get;set;}//Количество элементов в транзакции на загрузку данных
		[DataMember]
		[ProtoMember(14)]
		public bool ВыполнятьАрхивациюФайловОбмена {get;set;}//Выполнять архивацию файлов обмена
		[DataMember]
		[ProtoMember(15)]
		public string/*(0)*/ ПарольНаОтправку {get;set;}//Пароль на отправку
		[DataMember]
		[ProtoMember(16)]
		public string/*(0)*/ ПарольНаПрием {get;set;}//Пароль на прием
		[DataMember]
		[ProtoMember(17)]
		public string/*(0)*/ КаталогОбменаИнформацией {get;set;}//Каталог обмена информацией
		[DataMember]
		[ProtoMember(18)]
		public string/*(0)*/ FTPАдресОбмена {get;set;}//FTP адрес обмена
		[DataMember]
		[ProtoMember(19)]
		public decimal/*(10)*/ ПортFTPСоединения {get;set;}//Порт FTP соединения
		[DataMember]
		[ProtoMember(20)]
		public string/*(50)*/ ПользовательFTPСоединения {get;set;}//Пользователь FTP соединения
		[DataMember]
		[ProtoMember(21)]
		public string/*(50)*/ ПарольFTPСоединения {get;set;}//Пароль FTP соединения
		[DataMember]
		[ProtoMember(22)]
		public string/*(0)*/ Комментарий {get;set;}
		[DataMember]
		[ProtoMember(23)]
		public decimal/*(10)*/ МаксимальныйРазмерОтправляемогоПолучаемогоПакетаЧерезFTP {get;set;}//Максимальный размер отправляемого получаемого пакета через FTP
		[DataMember]
		[ProtoMember(24)]
		public bool ПассивноеFTPСоединение {get;set;}//Пассивное FTPСоединение
		[DataMember]
		[ProtoMember(25)]
		public string/*(0)*/ ПочтовыйАдресПолучателя {get;set;}//Почтовый адрес получателя
		[DataMember]
		[ProtoMember(26)]
		public V82.СправочникиСсылка.УчетныеЗаписиЭлектроннойПочты УчетнаяЗаписьПриемаОтправкиСообщений {get;set;}//Учетная запись приема отправки сообщений
		[DataMember]
		[ProtoMember(27)]
		public bool АвтоматическиЗакачиватьПочтуПриОбмене {get;set;}//Автоматически закачивать почту при обмене
		[DataMember]
		[ProtoMember(28)]
		public decimal/*(10)*/ МаксимальныйРазмерОтправляемогоПакетаЧерезПочту {get;set;}//Максимальный размер отправляемого пакета через почту
		[DataMember]
		[ProtoMember(29)]
		public ПланОбменаСсылка УзелФоновогоОбмена {get;set;}//Узел фонового обмена
		[DataMember]
		[ProtoMember(30)]
		public ХранилищеЗначения ПравилаОбмена {get;set;}//Правила обмена
		[DataMember]
		[ProtoMember(31)]
		public ХранилищеЗначения ПравилаОбменаДляПриемника {get;set;}//Правила обмена для приемника
		[DataMember]
		[ProtoMember(32)]
		public decimal/*(10)*/ ДобавлениеОбъектовИзФоновогоОбмена {get;set;}//Добавление объектов из фонового обмена
		[DataMember]
		[ProtoMember(33)]
		public decimal/*(10)*/ КоличествоОбъектовДляФоновогоОбмена {get;set;}//Количество объектов для фонового обмена
		[DataMember]
		[ProtoMember(34)]
		public bool OnLineОбмен {get;set;}//On line обмен
		[DataMember]
		[ProtoMember(35)]
		public bool ТипИнформационнойБазыДляПодключения {get;set;}//Тип информационной базы для подключения
		[DataMember]
		[ProtoMember(36)]
		public string/*(0)*/ КаталогИнформационнойБазыДляПодключения {get;set;}//Каталог информационной базы для подключения
		[DataMember]
		[ProtoMember(37)]
		public string/*(0)*/ ИмяСервераИнформационнойБазыДляПодключения {get;set;}//Имя сервера информационной базы для подключения
		[DataMember]
		[ProtoMember(38)]
		public string/*(0)*/ ИмяИнформационнойБазыНаСервереДляПодключения {get;set;}//Имя информационной базы на сервере для подключения
		[DataMember]
		[ProtoMember(39)]
		public bool АутентификацияWindowsИнформационнойБазыДляПодключения {get;set;}//Аутентификация windows информационной базы для подключения
		[DataMember]
		[ProtoMember(40)]
		public string/*(0)*/ ПользовательИнформационнойБазыДляПодключения {get;set;}//Пользователь информационной базы для подключения
		[DataMember]
		[ProtoMember(41)]
		public string/*(0)*/ ПарольИнформационнойБазыДляПодключения {get;set;}//Пароль информационной базы для подключения
		[DataMember]
		[ProtoMember(42)]
		public string/*(5)*/ ВерсияПлатформыИнформационнойБазыДляПодключения {get;set;}//Версия платформы информационной базы для подключения
		[DataMember]
		[ProtoMember(43)]
		public bool РежимОтладкиOnLineОбмена {get;set;}//Режим отладки on line обмена
		[DataMember]
		[ProtoMember(44)]
		public string/*(255)*/ ИмяФайлаПротоколаОбменаOnLineОбмен {get;set;}//Имя файла протокола обмена on line обмен
		[DataMember]
		[ProtoMember(45)]
		public ПланОбменаСсылка ТипУзлаИнформационнойБазы {get;set;}//Тип узла информационной базы
		[DataMember]
		[ProtoMember(46)]
		public V82.СправочникиСсылка.УчетныеЗаписиЭлектроннойПочты УчетнаяЗаписьОтправкиСообщенияОбОшибке {get;set;}//Учетная запись отправки сообщения об ошибке
		[DataMember]
		[ProtoMember(47)]
		public string/*(100)*/ АдресДляОтправкиСообщенийОбОшибке {get;set;}//Адрес для отправки сообщений об ошибке
		[DataMember]
		[ProtoMember(48)]
		public bool ПослеОшибкиОтложенногоПроведенияПрекратитьОперации {get;set;}//После ошибки отложенного проведения прекратить операции
		[DataMember]
		[ProtoMember(49)]
		public decimal/*(10)*/ КоличествоОшибокОтложенногоПроведенияДляПрекращенияОперации {get;set;}//Количество ошибок отложенного проведения для прекращения операции
		[DataMember]
		[ProtoMember(50)]
		public bool ВыполнятьДействияПодПолнымиПравами {get;set;}//Выполнять действия под полными правами
		[DataMember]
		[ProtoMember(51)]
		public bool ПроизводитьОтправкуТолькоПриУспешномПриеме {get;set;}//Производить отправку только при успешном приеме
		[DataMember]
		[ProtoMember(52)]
		public bool ВыполнитьОтложенноеПроведениеДокументовПоРасписанию {get;set;}//Выполнить отложенное проведение документов по расписанию
		[DataMember]
		[ProtoMember(53)]
		public string/*(50)*/ ПользовательПроксиFTP {get;set;}//Пользователь прокси FTP
		[DataMember]
		[ProtoMember(54)]
		public string/*(50)*/ ПарольПроксиFTP {get;set;}//Пароль прокси FTP
		[DataMember]
		[ProtoMember(55)]
		public string/*(50)*/ СерверПроксиFTP {get;set;}//Сервер прокси FTP
		[DataMember]
		[ProtoMember(56)]
		public decimal/*(10)*/ ПортПроксиFTP {get;set;}//Порт прокси FTP
		[DataMember]
		[ProtoMember(57)]
		public string/*(50)*/ ПротоколПроксиFTP {get;set;}//Протокол прокси FTP
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
						Insert Into _Reference153(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld2714RRef
						,_Fld2715
						,_Fld2716
						,_Fld2717
						,_Fld2718
						,_Fld2719
						,_Fld2720
						,_Fld2721
						,_Fld2722
						,_Fld2723
						,_Fld2724
						,_Fld2725
						,_Fld2726
						,_Fld2727
						,_Fld2728
						,_Fld2729
						,_Fld2730
						,_Fld2731RRef
						,_Fld2732
						,_Fld2733
						,_Fld2735
						,_Fld2736
						,_Fld2737
						,_Fld2738
						,_Fld2739
						,_Fld2740
						,_Fld2741
						,_Fld2742
						,_Fld2743
						,_Fld2744
						,_Fld2745
						,_Fld2746
						,_Fld2747
						,_Fld2748
						,_Fld2749
						,_Fld2751RRef
						,_Fld2752
						,_Fld2753
						,_Fld2754
						,_Fld2755
						,_Fld2756
						,_Fld2757
						,_Fld2758
						,_Fld2759
						,_Fld2760
						,_Fld2761
						,_Fld2762)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Код
						,@Наименование
						,@ТипНастройки
						,@ПроизводитьПриемСообщений
						,@ПроизводитьОтправкуСообщений
						,@КоличествоЭлементовВТранзакцииНаВыгрузкуДанных
						,@КоличествоЭлементовВТранзакцииНаЗагрузкуДанных
						,@ВыполнятьАрхивациюФайловОбмена
						,@ПарольНаОтправку
						,@ПарольНаПрием
						,@КаталогОбменаИнформацией
						,@FTPАдресОбмена
						,@ПортFTPСоединения
						,@ПользовательFTPСоединения
						,@ПарольFTPСоединения
						,@Комментарий
						,@МаксимальныйРазмерОтправляемогоПолучаемогоПакетаЧерезFTP
						,@ПассивноеFTPСоединение
						,@ПочтовыйАдресПолучателя
						,@УчетнаяЗаписьПриемаОтправкиСообщений
						,@АвтоматическиЗакачиватьПочтуПриОбмене
						,@МаксимальныйРазмерОтправляемогоПакетаЧерезПочту
						,@ПравилаОбмена
						,@ПравилаОбменаДляПриемника
						,@ДобавлениеОбъектовИзФоновогоОбмена
						,@КоличествоОбъектовДляФоновогоОбмена
						,@OnLineОбмен
						,@ТипИнформационнойБазыДляПодключения
						,@КаталогИнформационнойБазыДляПодключения
						,@ИмяСервераИнформационнойБазыДляПодключения
						,@ИмяИнформационнойБазыНаСервереДляПодключения
						,@АутентификацияWindowsИнформационнойБазыДляПодключения
						,@ПользовательИнформационнойБазыДляПодключения
						,@ПарольИнформационнойБазыДляПодключения
						,@ВерсияПлатформыИнформационнойБазыДляПодключения
						,@РежимОтладкиOnLineОбмена
						,@ИмяФайлаПротоколаОбменаOnLineОбмен
						,@УчетнаяЗаписьОтправкиСообщенияОбОшибке
						,@АдресДляОтправкиСообщенийОбОшибке
						,@ПослеОшибкиОтложенногоПроведенияПрекратитьОперации
						,@КоличествоОшибокОтложенногоПроведенияДляПрекращенияОперации
						,@ВыполнятьДействияПодПолнымиПравами
						,@ПроизводитьОтправкуТолькоПриУспешномПриеме
						,@ВыполнитьОтложенноеПроведениеДокументовПоРасписанию
						,@ПользовательПроксиFTP
						,@ПарольПроксиFTP
						,@СерверПроксиFTP
						,@ПортПроксиFTP
						,@ПротоколПроксиFTP)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference153
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld2714RRef	= @ТипНастройки
						,_Fld2715	= @ПроизводитьПриемСообщений
						,_Fld2716	= @ПроизводитьОтправкуСообщений
						,_Fld2717	= @КоличествоЭлементовВТранзакцииНаВыгрузкуДанных
						,_Fld2718	= @КоличествоЭлементовВТранзакцииНаЗагрузкуДанных
						,_Fld2719	= @ВыполнятьАрхивациюФайловОбмена
						,_Fld2720	= @ПарольНаОтправку
						,_Fld2721	= @ПарольНаПрием
						,_Fld2722	= @КаталогОбменаИнформацией
						,_Fld2723	= @FTPАдресОбмена
						,_Fld2724	= @ПортFTPСоединения
						,_Fld2725	= @ПользовательFTPСоединения
						,_Fld2726	= @ПарольFTPСоединения
						,_Fld2727	= @Комментарий
						,_Fld2728	= @МаксимальныйРазмерОтправляемогоПолучаемогоПакетаЧерезFTP
						,_Fld2729	= @ПассивноеFTPСоединение
						,_Fld2730	= @ПочтовыйАдресПолучателя
						,_Fld2731RRef	= @УчетнаяЗаписьПриемаОтправкиСообщений
						,_Fld2732	= @АвтоматическиЗакачиватьПочтуПриОбмене
						,_Fld2733	= @МаксимальныйРазмерОтправляемогоПакетаЧерезПочту
						,_Fld2735	= @ПравилаОбмена
						,_Fld2736	= @ПравилаОбменаДляПриемника
						,_Fld2737	= @ДобавлениеОбъектовИзФоновогоОбмена
						,_Fld2738	= @КоличествоОбъектовДляФоновогоОбмена
						,_Fld2739	= @OnLineОбмен
						,_Fld2740	= @ТипИнформационнойБазыДляПодключения
						,_Fld2741	= @КаталогИнформационнойБазыДляПодключения
						,_Fld2742	= @ИмяСервераИнформационнойБазыДляПодключения
						,_Fld2743	= @ИмяИнформационнойБазыНаСервереДляПодключения
						,_Fld2744	= @АутентификацияWindowsИнформационнойБазыДляПодключения
						,_Fld2745	= @ПользовательИнформационнойБазыДляПодключения
						,_Fld2746	= @ПарольИнформационнойБазыДляПодключения
						,_Fld2747	= @ВерсияПлатформыИнформационнойБазыДляПодключения
						,_Fld2748	= @РежимОтладкиOnLineОбмена
						,_Fld2749	= @ИмяФайлаПротоколаОбменаOnLineОбмен
						,_Fld2751RRef	= @УчетнаяЗаписьОтправкиСообщенияОбОшибке
						,_Fld2752	= @АдресДляОтправкиСообщенийОбОшибке
						,_Fld2753	= @ПослеОшибкиОтложенногоПроведенияПрекратитьОперации
						,_Fld2754	= @КоличествоОшибокОтложенногоПроведенияДляПрекращенияОперации
						,_Fld2755	= @ВыполнятьДействияПодПолнымиПравами
						,_Fld2756	= @ПроизводитьОтправкуТолькоПриУспешномПриеме
						,_Fld2757	= @ВыполнитьОтложенноеПроведениеДокументовПоРасписанию
						,_Fld2758	= @ПользовательПроксиFTP
						,_Fld2759	= @ПарольПроксиFTP
						,_Fld2760	= @СерверПроксиFTP
						,_Fld2761	= @ПортПроксиFTP
						,_Fld2762	= @ПротоколПроксиFTP
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("ТипНастройки", ТипНастройки.Ключ());
					Команда.Parameters.AddWithValue("ПроизводитьПриемСообщений", ПроизводитьПриемСообщений);
					Команда.Parameters.AddWithValue("ПроизводитьОтправкуСообщений", ПроизводитьОтправкуСообщений);
					Команда.Parameters.AddWithValue("КоличествоЭлементовВТранзакцииНаВыгрузкуДанных", КоличествоЭлементовВТранзакцииНаВыгрузкуДанных);
					Команда.Parameters.AddWithValue("КоличествоЭлементовВТранзакцииНаЗагрузкуДанных", КоличествоЭлементовВТранзакцииНаЗагрузкуДанных);
					Команда.Parameters.AddWithValue("ВыполнятьАрхивациюФайловОбмена", ВыполнятьАрхивациюФайловОбмена);
					Команда.Parameters.AddWithValue("ПарольНаОтправку", ПарольНаОтправку);
					Команда.Parameters.AddWithValue("ПарольНаПрием", ПарольНаПрием);
					Команда.Parameters.AddWithValue("КаталогОбменаИнформацией", КаталогОбменаИнформацией);
					Команда.Parameters.AddWithValue("FTPАдресОбмена", FTPАдресОбмена);
					Команда.Parameters.AddWithValue("ПортFTPСоединения", ПортFTPСоединения);
					Команда.Parameters.AddWithValue("ПользовательFTPСоединения", ПользовательFTPСоединения);
					Команда.Parameters.AddWithValue("ПарольFTPСоединения", ПарольFTPСоединения);
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
					Команда.Parameters.AddWithValue("МаксимальныйРазмерОтправляемогоПолучаемогоПакетаЧерезFTP", МаксимальныйРазмерОтправляемогоПолучаемогоПакетаЧерезFTP);
					Команда.Parameters.AddWithValue("ПассивноеFTPСоединение", ПассивноеFTPСоединение);
					Команда.Parameters.AddWithValue("ПочтовыйАдресПолучателя", ПочтовыйАдресПолучателя);
					Команда.Parameters.AddWithValue("УчетнаяЗаписьПриемаОтправкиСообщений", УчетнаяЗаписьПриемаОтправкиСообщений.Ссылка);
					Команда.Parameters.AddWithValue("АвтоматическиЗакачиватьПочтуПриОбмене", АвтоматическиЗакачиватьПочтуПриОбмене);
					Команда.Parameters.AddWithValue("МаксимальныйРазмерОтправляемогоПакетаЧерезПочту", МаксимальныйРазмерОтправляемогоПакетаЧерезПочту);
					Команда.Parameters.AddWithValue("ПравилаОбмена",new byte[0]);
					Команда.Parameters.AddWithValue("ПравилаОбменаДляПриемника",new byte[0]);
					Команда.Parameters.AddWithValue("ДобавлениеОбъектовИзФоновогоОбмена", ДобавлениеОбъектовИзФоновогоОбмена);
					Команда.Parameters.AddWithValue("КоличествоОбъектовДляФоновогоОбмена", КоличествоОбъектовДляФоновогоОбмена);
					Команда.Parameters.AddWithValue("OnLineОбмен", OnLineОбмен);
					Команда.Parameters.AddWithValue("ТипИнформационнойБазыДляПодключения", ТипИнформационнойБазыДляПодключения);
					Команда.Parameters.AddWithValue("КаталогИнформационнойБазыДляПодключения", КаталогИнформационнойБазыДляПодключения);
					Команда.Parameters.AddWithValue("ИмяСервераИнформационнойБазыДляПодключения", ИмяСервераИнформационнойБазыДляПодключения);
					Команда.Parameters.AddWithValue("ИмяИнформационнойБазыНаСервереДляПодключения", ИмяИнформационнойБазыНаСервереДляПодключения);
					Команда.Parameters.AddWithValue("АутентификацияWindowsИнформационнойБазыДляПодключения", АутентификацияWindowsИнформационнойБазыДляПодключения);
					Команда.Parameters.AddWithValue("ПользовательИнформационнойБазыДляПодключения", ПользовательИнформационнойБазыДляПодключения);
					Команда.Parameters.AddWithValue("ПарольИнформационнойБазыДляПодключения", ПарольИнформационнойБазыДляПодключения);
					Команда.Parameters.AddWithValue("ВерсияПлатформыИнформационнойБазыДляПодключения", ВерсияПлатформыИнформационнойБазыДляПодключения);
					Команда.Parameters.AddWithValue("РежимОтладкиOnLineОбмена", РежимОтладкиOnLineОбмена);
					Команда.Parameters.AddWithValue("ИмяФайлаПротоколаОбменаOnLineОбмен", ИмяФайлаПротоколаОбменаOnLineОбмен);
					Команда.Parameters.AddWithValue("УчетнаяЗаписьОтправкиСообщенияОбОшибке", УчетнаяЗаписьОтправкиСообщенияОбОшибке.Ссылка);
					Команда.Parameters.AddWithValue("АдресДляОтправкиСообщенийОбОшибке", АдресДляОтправкиСообщенийОбОшибке);
					Команда.Parameters.AddWithValue("ПослеОшибкиОтложенногоПроведенияПрекратитьОперации", ПослеОшибкиОтложенногоПроведенияПрекратитьОперации);
					Команда.Parameters.AddWithValue("КоличествоОшибокОтложенногоПроведенияДляПрекращенияОперации", КоличествоОшибокОтложенногоПроведенияДляПрекращенияОперации);
					Команда.Parameters.AddWithValue("ВыполнятьДействияПодПолнымиПравами", ВыполнятьДействияПодПолнымиПравами);
					Команда.Parameters.AddWithValue("ПроизводитьОтправкуТолькоПриУспешномПриеме", ПроизводитьОтправкуТолькоПриУспешномПриеме);
					Команда.Parameters.AddWithValue("ВыполнитьОтложенноеПроведениеДокументовПоРасписанию", ВыполнитьОтложенноеПроведениеДокументовПоРасписанию);
					Команда.Parameters.AddWithValue("ПользовательПроксиFTP", ПользовательПроксиFTP);
					Команда.Parameters.AddWithValue("ПарольПроксиFTP", ПарольПроксиFTP);
					Команда.Parameters.AddWithValue("СерверПроксиFTP", СерверПроксиFTP);
					Команда.Parameters.AddWithValue("ПортПроксиFTP", ПортПроксиFTP);
					Команда.Parameters.AddWithValue("ПротоколПроксиFTP", ПротоколПроксиFTP);
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
					Команда.CommandText = @"Delete _Reference153
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/
		// при записи

		public void ПриЗаписи(/*Отказ*/)
		{
			if(true/*ОбменДанными.Загрузка*/)
			{
			}
			/*// надо проверить наличие одной записи в регистре сведений
*/
			//НаборЗаписейПараметров = РегистрыСведений.ПараметрыОбменаДанными.СоздатьНаборЗаписей();
			//НаборЗаписейПараметров.Отбор.НастройкаОбменаДанными.Установить(Ссылка);
			//НаборЗаписейПараметров.Прочитать();
			if(true/*НаборЗаписейПараметров.Количество() = 1*/)
			{
				/*// запись есть, ничего делать не надо
*/
			}
			/*// добавляем только одну запись и все
*/
			//ЗаписьДатПараметров = НаборЗаписейПараметров.Добавить();
			//ЗаписьДатПараметров.НастройкаОбменаДанными = Ссылка;
		}

		public object ПолучитьДлинуСтрокиХранилища(/*Хранилище*/)
		{
			//ТекстПравилаОбмена = Хранилище.Получить();
			//РазмерСтроки = СтрДлина(ТекстПравилаОбмена);
			return null;
		}
		// Перед записью

		public void ПередЗаписью(/*Отказ*/)
		{
			if(true/*ОбменДанными.Загрузка*/)
			{
			}
			//БазоваяПоставка = (Найти(ВРег(Метаданные.Имя), "БАЗОВАЯ") > 0);
			if(true/*ПустаяСтрока(ВерсияПлатформыИнформационнойБазыДляПодключения)*/)
			{
				//ВерсияПлатформыИнформационнойБазыДляПодключения = "V81";
			}
			if(true/*НЕ ЗначениеЗаполнено(ТипНастройки)*/)
			{
				//ОбщегоНазначения.СообщитьОбОшибке("Не заполнено поле ""Тип настройки""", Отказ);
			}
			if(true/*НЕ ЗначениеЗаполнено(УзелИнформационнойБазы)*/)
			{
				//ОбщегоНазначения.СообщитьОбОшибке("Не заполнено поле ""Узел""", Отказ);
			}
			if(true/*БазоваяПоставка
		И ПроцедурыОбменаДанными.ОпределитьПоУзлуОбменаЭтоРИБ(УзелИнформационнойБазы)*/)
			{
				//ОбщегоНазначения.СообщитьОбОшибке("В базовой версии недоступен обмен через распределенную информационную базу", Отказ);
			}
			//ЭтотУзелОбмена = ПроцедурыОбменаДанными.ПолучитьТекущийУзелИБ(УзелИнформационнойБазы);
			if(true/*ЭтотУзелОбмена = УзелИнформационнойБазы*/)
			{
				//ОбщегоНазначения.СообщитьОбОшибке("В качестве узла обмена выбран узел, соответствующий текущей информационной базе.", Отказ);
			}
			if(true/*OnLineОбмен*/)
			{
				//РазмерОсновногоХранилищаПравил = ПолучитьДлинуСтрокиХранилища(ПравилаОбмена);
				if(true/*(ПроизводитьПриемСообщений
			ИЛИ ПроизводитьОтправкуСообщений)
			И РазмерОсновногоХранилищаПравил = 0*/)
				{
					//ОбщегоНазначения.СообщитьОбОшибке("Не заданы правила обмена данными для выгрузки в базу обмена", Отказ);
				}
				if(true/*ТипНастройки = Перечисления.ТипыАвтоматическогоОбменаДанными.ОбменЧерезComСоединение*/)
				{
					if(true/*БазоваяПоставка*/)
					{
						//ОбщегоНазначения.СообщитьОбОшибке("В базовой версии недоступен Режим обмена через COM - соединение", Отказ);
					}
					if(true/*ПроизводитьПриемСообщений*/)
					{
						//РазмерХранилищаПравилЗагрузки = ПолучитьДлинуСтрокиХранилища(ПравилаОбменаДляПриемника);
						if(true/*РазмерХранилищаПравилЗагрузки = 0*/)
						{
							//ОбщегоНазначения.СообщитьОбОшибке("Не заданы правила для выгрузки из базы обмена в текущую базу", Отказ);
						}
					}
					if(true/*ТипИнформационнойБазыДляПодключения*/)
					{
						if(true/*НЕ ЗначениеЗаполнено(КаталогИнформационнойБазыДляПодключения)*/)
						{
							//ОбщегоНазначения.СообщитьОбОшибке("Не заполнено поле ""Каталог информационной базы для подключения""", Отказ);
						}
					}
				}
			}
			/*// в зависимости от типа настройки очищаем настройки остальных типов
*/
			if(true/*ТипНастройки = Перечисления.ТипыАвтоматическогоОбменаДанными.ОбменЧерезФайловыйРесурс*/)
			{
				//КаталогОбменаИнформацией = СокрЛП(КаталогОбменаИнформацией);
			}
			if(true/*НЕ ПроизводитьПриемСообщений
		ИЛИ НЕ ПроизводитьОтправкуСообщений*/)
			{
				//ПроизводитьОтправкуТолькоПриУспешномПриеме = Ложь;
			}
			if(true/*Не Отказ*/)
			{
				//ТипУзлаИнформационнойБазы = Новый(ТипЗнч(УзелИнформационнойБазы));
			}
		}
	}
}