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
	///<summary>
	///(Общ)
	///</summary>
	public partial class РасходыБудущихПериодов: СправочникТест
	{

		public static void Создать1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("Создание 1000 элементов справочника РасходыБудущихПериодов. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			for (var НомерЭлемента = 1;НомерЭлемента < 1000;НомерЭлемента++)
			{
				var Объект = V82.Справочники/*Менеджер*/.РасходыБудущихПериодов.СоздатьЭлемент();
				Объект.Код = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,11);//НомерЭлемента;
				Объект.Наименование = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 100);//"Наименование " + НомерЭлемента.ToString();

				Объект.ВидРБП = (V82.Перечисления/*Ссылка*/.ВидыРБП)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.ВидыРБП));
				Объект.ДатаНачалаСписания = ГенераторСлучайныхЧисел.СледующаяДата();
				Объект.ДатаОкончанияСписания = ГенераторСлучайныхЧисел.СледующаяДата();
				Объект.НоменклатурнаяГруппа = V82.Справочники/*Менеджер*/.НоменклатурныеГруппы.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.НоменклатурныеГруппы();
				Объект.ОбъектСтроительства = V82.Справочники/*Менеджер*/.ОбъектыСтроительства.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.ОбъектыСтроительства();
				Объект.Подразделение = V82.Справочники/*Менеджер*/.Подразделения.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.Подразделения();
				Объект.ПодразделениеОрганизации = V82.Справочники/*Менеджер*/.ПодразделенияОрганизаций.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.ПодразделенияОрганизаций();
				Объект.Продукция = V82.Справочники/*Менеджер*/.Номенклатура.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.Номенклатура();
				Объект.СерияПродукции = V82.Справочники/*Менеджер*/.СерииНоменклатуры.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.СерииНоменклатуры();
				Объект.СтатьяЗатрат = V82.Справочники/*Менеджер*/.СтатьиЗатрат.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.СтатьиЗатрат();
				Объект.Сумма = ГенераторСлучайныхЧисел.Следующий(999999999);
				Объект.СпособПризнанияРасходов = (V82.Перечисления/*Ссылка*/.СпособыПризнанияРасходов)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.СпособыПризнанияРасходов));
				Объект.СпособРаспределенияЗатратНаВыпуск = V82.Справочники/*Менеджер*/.СпособыРаспределенияЗатратНаВыпуск.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск();
				Объект.СпособСтроительства = (V82.Перечисления/*Ссылка*/.СпособыСтроительства)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.СпособыСтроительства));
				Объект.ВидАктива = (V82.Перечисления/*Ссылка*/.ВидыАктивовДляРБП)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.ВидыАктивовДляРБП));

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
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.РасходыБудущихПериодов.Выбрать())
			{
				var Объект = Ссылка.ПолучитьОбъект();
				Объект.Удалить();
			}
		}

		public static void СериализацияProtoBuf1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("СериализацияProtoBuf 1000 элементов справочника РасходыБудущихПериодов. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			using (var Поток = new MemoryStream())
			{
				var НомерЭлемента = 0;
				foreach (var Ссылка in V82.Справочники/*Менеджер*/.РасходыБудущихПериодов.Выбрать())
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
			Console.WriteLine("СериализацияJson 1000 элементов справочника РасходыБудущихПериодов. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			var НомерЭлемента = 0;
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.РасходыБудущихПериодов.Выбрать())
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
