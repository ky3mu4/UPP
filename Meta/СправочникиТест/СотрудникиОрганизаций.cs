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
	public partial class СотрудникиОрганизаций: СправочникТест
	{

		public static void Создать1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("Создание 1000 элементов справочника СотрудникиОрганизаций. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			for (var НомерЭлемента = 1;НомерЭлемента < 1000;НомерЭлемента++)
			{
				var Объект = V82.Справочники/*Менеджер*/.СотрудникиОрганизаций.СоздатьЭлемент();
				Объект.Код = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,10);//НомерЭлемента;
				Объект.Наименование = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 100);//"Наименование " + НомерЭлемента.ToString();

				Объект.Физлицо = V82.Справочники/*Менеджер*/.ФизическиеЛица.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.ФизическиеЛица();
				Объект.Актуальность = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.Организация = V82.Справочники/*Менеджер*/.Организации.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.Организации();
				Объект.ОбособленноеПодразделение = V82.Справочники/*Менеджер*/.Организации.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.Организации();
				Объект.ВидДоговора = (V82.Перечисления/*Ссылка*/.ВидыДоговоровСФизЛицами)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.ВидыДоговоровСФизЛицами));
				Объект.ВидЗанятости = (V82.Перечисления/*Ссылка*/.ВидыЗанятостиВОрганизации)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.ВидыЗанятостиВОрганизации));
				Объект.НомерДоговора = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 11);
				Объект.ДатаДоговора = ГенераторСлучайныхЧисел.СледующаяДата();
				Объект.ПодразделениеОрганизации = V82.Справочники/*Менеджер*/.ПодразделенияОрганизаций.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.ПодразделенияОрганизаций();
				Объект.Должность = V82.Справочники/*Менеджер*/.ДолжностиОрганизаций.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.ДолжностиОрганизаций();
				Объект.ЗанимаемыхСтавок = ГенераторСлучайныхЧисел.Следующий(9999);
				Объект.ДатаНачала = ГенераторСлучайныхЧисел.СледующаяДата();
				Объект.ДатаОкончания = ГенераторСлучайныхЧисел.СледующаяДата();
				Объект.ИспытательныйСрок = ГенераторСлучайныхЧисел.Следующий(9999);
				Объект.ТарифнаяСтавка = ГенераторСлучайныхЧисел.Следующий(999999999);
				Объект.ВалютаТарифнойСтавки = V82.Справочники/*Менеджер*/.Валюты.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(99)) ?? new V82.СправочникиСсылка.Валюты();
				Объект.ПостфиксНаименования = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 15);
				Объект.ТарифныйРазряд = V82.Справочники/*Менеджер*/.ТарифныеРазряды.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.ТарифныеРазряды();
				Объект.ТекущееОбособленноеПодразделение = V82.Справочники/*Менеджер*/.Организации.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.Организации();
				Объект.ТекущееПодразделениеОрганизации = V82.Справочники/*Менеджер*/.ПодразделенияОрганизаций.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.ПодразделенияОрганизаций();
				Объект.ТекущаяДолжностьОрганизации = V82.Справочники/*Менеджер*/.ДолжностиОрганизаций.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.ДолжностиОрганизаций();
				Объект.ДатаПриемаНаРаботу = ГенераторСлучайныхЧисел.СледующаяДата();
				Объект.ДатаУвольнения = ГенераторСлучайныхЧисел.СледующаяДата();
				Объект.ТекущееПодразделениеКомпании = V82.Справочники/*Менеджер*/.Подразделения.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.Подразделения();
				Объект.ТекущаяДолжностьКомпании = V82.Справочники/*Менеджер*/.ДолжностиОрганизаций.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.ДолжностиОрганизаций();
				Объект.ДатаПриемаНаРаботуВКомпанию = ГенераторСлучайныхЧисел.СледующаяДата();
				Объект.ДатаУвольненияИзКомпании = ГенераторСлучайныхЧисел.СледующаяДата();
				Объект.ЯвляетсяСтудентомРаботающимВСтудотряде = ГенераторСлучайныхЧисел.СледующееБулево();

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
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.СотрудникиОрганизаций.Выбрать())
			{
				var Объект = Ссылка.ПолучитьОбъект();
				Объект.Удалить();
			}
		}

		public static void СериализацияProtoBuf1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("СериализацияProtoBuf 1000 элементов справочника СотрудникиОрганизаций. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			using (var Поток = new MemoryStream())
			{
				var НомерЭлемента = 0;
				foreach (var Ссылка in V82.Справочники/*Менеджер*/.СотрудникиОрганизаций.Выбрать())
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
			Console.WriteLine("СериализацияJson 1000 элементов справочника СотрудникиОрганизаций. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			var НомерЭлемента = 0;
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.СотрудникиОрганизаций.Выбрать())
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
