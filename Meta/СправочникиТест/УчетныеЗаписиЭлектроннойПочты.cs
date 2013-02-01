﻿
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.IO;
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.Справочники;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиТест
{
	public partial class УчетныеЗаписиЭлектроннойПочты: СправочникТест
	{

		public static void Создать1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("Создание 1000 элементов справочника УчетныеЗаписиЭлектроннойПочты. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			for (var НомерЭлемента = 1;НомерЭлемента < 1000;НомерЭлемента++)
			{
				var Объект = V82.Справочники/*Менеджер*/.УчетныеЗаписиЭлектроннойПочты.СоздатьЭлемент();
				Объект.Код = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,9);//НомерЭлемента;
				Объект.Наименование = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 150);//"Наименование " + НомерЭлемента.ToString();

				Объект.SMTPСервер = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 100);
				Объект.POP3Сервер = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 100);
				Объект.ПортSMTP = ГенераторСлучайныхЧисел.Следующий(9999);
				Объект.ПортPOP3 = ГенераторСлучайныхЧисел.Следующий(9999);
				Объект.Логин = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 200);
				Объект.Пароль = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 200);
				Объект.ТребуетсяSMTPАутентификация = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ЛогинSMTP = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 200);
				Объект.ПарольSMTP = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 200);
				Объект.ВремяОжиданияСервера = ГенераторСлучайныхЧисел.Следующий(9999);
				Объект.ОставлятьКопииСообщенийНаСервере = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.УдалятьПисьмаССервераЧерез = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.КоличествоДнейУдаленияПисемССервера = ГенераторСлучайныхЧисел.Следующий(999);
				Объект.АдресЭлектроннойПочты = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 150);
				Объект.ГруппаВходящие = V82.Справочники/*Менеджер*/.ГруппыПисемЭлектроннойПочты.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.ГруппыПисемЭлектроннойПочты();
				Объект.ГруппаИсходящие = V82.Справочники/*Менеджер*/.ГруппыПисемЭлектроннойПочты.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.ГруппыПисемЭлектроннойПочты();
				Объект.ГруппаУдаленные = V82.Справочники/*Менеджер*/.ГруппыПисемЭлектроннойПочты.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.ГруппыПисемЭлектроннойПочты();
				Объект.ГруппаЧерновики = V82.Справочники/*Менеджер*/.ГруппыПисемЭлектроннойПочты.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.ГруппыПисемЭлектроннойПочты();
				Объект.ГруппаНежелательные = V82.Справочники/*Менеджер*/.ГруппыПисемЭлектроннойПочты.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.ГруппыПисемЭлектроннойПочты();
				Объект.ФорматТекстаПисьмаПоУмолчанию = (V82.Перечисления/*Ссылка*/.ВидыТекстовЭлектронныхПисем)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.ВидыТекстовЭлектронныхПисем));
				Объект.ТекстПодписи = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 255);
				Объект.ДобавлятьПодписьКИсходящимПисьмам = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ДобавлятьПодписьКОтветамИПересылкам = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.АвтоПолучениеОтправкаСообщений = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ИнтервалАвтоПолученияОтправкиСообщений = ГенераторСлучайныхЧисел.Следующий(99);
				Объект.ОтветственныйЗаАвтоПолучениеОтправкуСообщений = V82.Справочники/*Менеджер*/.Пользователи.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.Пользователи();
				Объект.ПомещатьОтветыИПереадресацииВТужеГруппу = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ДействиеАвтополученияОтправкиСообщений = (V82.Перечисления/*Ссылка*/.ВидыДействийАвтоПолученияОтправкиЭлектронныхПисем)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.ВидыДействийАвтоПолученияОтправкиЭлектронныхПисем));
				Объект.АвтоматическаяУстановкаПометкиРассмотрено = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ИнтервалАвтоматическойУстановкиОтметкиРассмотрено = ГенераторСлучайныхЧисел.Следующий(99);
				Объект.АвтоматическаяУстановкаПометкиРассмотреноПриОтвете = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.АвтоматическаяУстановкаПометкиРассмотреноПриПолученииОтвета = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ИспользоватьКлассификациюПисемПоПредметам = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ЗаполнятьПустойПредметДляНовыхПисемИзТемыПисьма = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ДляВходящихОтветовИПереадресацийИскатьПисьмаОснованияИЗаполнятьПредмет = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ДляВходящихОтветовИПереадресацийИскатьПисьмаОснованияИЗаполнятьОснованиеНовогоПисьма = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ДляВходящихОтветовИПереадресацийИскатьПисьмаОснованияИЗаполнятьГруппуПисемНовогоПисьма = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.АвтосохранениеПисем = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ИнтервалАвтосохраненияПисем = ГенераторСлучайныхЧисел.Следующий(999);
				Объект.ФорматПисьмаДляОтветовИПереадресацийБратьИзИсходного = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.КодировкаПисемПоУмолчанию = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 200);
				Объект.КодировкуПисьмаДляОтветовБратьИзИсходного = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ЗаполнятьОбъектыИзАдресовПервогоПисьма = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.НазначениеУчетнойЗаписи = (V82.Перечисления/*Ссылка*/.НазначенияУчетнойЗаписи)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.НазначенияУчетнойЗаписи));
				Объект.ИспользоватьДляОтправки = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ИспользоватьДляПолучения = ГенераторСлучайныхЧисел.СледующееБулево();

				Объект.Записать();
				Console.Write("Выполнено: " + НомерЭлемента.ToString() + "%.");
				Console.CursorLeft = 0;
			}
			var Финиш = DateTime.Now;
			Console.WriteLine("Закончено " + Math.Round(((Финиш - Старт).TotalMilliseconds / 1000), 3).ToString() + " сек. Финиш: " + Финиш.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			Console.WriteLine("-------------------------------------------------------------------- -");
		}

		public static void Удалить1000()
		{
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.УчетныеЗаписиЭлектроннойПочты.Выбрать())
			{
				var Объект = Ссылка.ПолучитьОбъект();
				Объект.Удалить();
			}
		}

		public static void СериализацияProtoBuf1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("СериализацияProtoBuf 1000 элементов справочника УчетныеЗаписиЭлектроннойПочты. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			using (var Поток = new MemoryStream())
			{
				var НомерЭлемента = 0;
				foreach (var Ссылка in V82.Справочники/*Менеджер*/.УчетныеЗаписиЭлектроннойПочты.Выбрать())
				{
					НомерЭлемента++;
					Ссылка.СериализацияProtoBuf(Поток);
					Console.Write("Выполнено: " + НомерЭлемента.ToString() + "%.");
					Console.CursorLeft = 0;
				}
			}
			var Финиш = DateTime.Now;
			Console.WriteLine("Закончено " + Math.Round(((Финиш - Старт).TotalMilliseconds / 1000), 3).ToString() + " сек. Финиш: " + Финиш.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			Console.WriteLine("-------------------------------------------------------------------- -");
		}

		public static void СериализацияJson1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("СериализацияJson 1000 элементов справочника УчетныеЗаписиЭлектроннойПочты. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			var НомерЭлемента = 0;
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.УчетныеЗаписиЭлектроннойПочты.Выбрать())
			{
				НомерЭлемента++;
				Ссылка.СериализацияJson();
				Console.Write("Выполнено: " + НомерЭлемента.ToString() + "%.");
				Console.CursorLeft = 0;
			}
			var Финиш = DateTime.Now;
			Console.WriteLine("Закончено " + Math.Round(((Финиш - Старт).TotalMilliseconds / 1000), 3).ToString() + " сек. Финиш: " + Финиш.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			Console.WriteLine("-------------------------------------------------------------------- -");
		}
	}
}
