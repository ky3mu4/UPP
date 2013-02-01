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
	public partial class НастройкиОбменаССайтом: СправочникТест
	{

		public static void Создать1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("Создание 1000 элементов справочника НастройкиОбменаССайтом. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			for (var НомерЭлемента = 1;НомерЭлемента < 1000;НомерЭлемента++)
			{
				var Объект = V82.Справочники/*Менеджер*/.НастройкиОбменаССайтом.СоздатьЭлемент();
				Объект.Код = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3);//НомерЭлемента;
				Объект.Наименование = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 50);//"Наименование " + НомерЭлемента.ToString();

				Объект.ОбменТоварами = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ОбменЗаказами = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ВыгружатьТолькоИзменения = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ВыгружатьНаСайт = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.КаталогВыгрузки = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 255);
				Объект.HTTPОбменАдресСайта = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 255);
				Объект.HTTPОбменИмяПользователя = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 255);
				Объект.HTTPОбменПароль = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 255);
				Объект.HTTPОбменПроксиИспользование = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.HTTPОбменПроксиСервер = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 255);
				Объект.HTTPОбменПроксиПорт = ГенераторСлучайныхЧисел.Следующий(99999);
				Объект.HTTPОбменПроксиИмяПользователя = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 255);
				Объект.HTTPОбменПроксиПароль = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 255);
				Объект.ГруппаДляНовыхКонтрагентов = V82.Справочники/*Менеджер*/.Контрагенты.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.Контрагенты();
				Объект.ГруппаДляНовойНоменклатуры = V82.Справочники/*Менеджер*/.Номенклатура.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.Номенклатура();
				Объект.Организация = V82.Справочники/*Менеджер*/.Организации.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.Организации();
				Объект.Ответственный = V82.Справочники/*Менеджер*/.Пользователи.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.Пользователи();
				Объект.Подразделение = V82.Справочники/*Менеджер*/.Подразделения.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.Подразделения();
				Объект.ЗаписыватьДокументыТекущейДатой = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ПроводитьДокументы = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ПроводитьДокументыОперативно = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.СпособИдентификацииКонтрагентов = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 12);
				Объект.ЕдиницаИзмеренияНовойНоменклатуры = V82.Справочники/*Менеджер*/.КлассификаторЕдиницИзмерения.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(99)) ?? new V82.СправочникиСсылка.КлассификаторЕдиницИзмерения();
				Объект.ВыгружатьКартинки = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.Комментарий = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 255);
				Объект.РегламентноеЗадание = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 40);
				Объект.ИспользоватьРегламентныеЗадания = ГенераторСлучайныхЧисел.СледующееБулево();

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
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.НастройкиОбменаССайтом.Выбрать())
			{
				var Объект = Ссылка.ПолучитьОбъект();
				Объект.Удалить();
			}
		}

		public static void СериализацияProtoBuf1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("СериализацияProtoBuf 1000 элементов справочника НастройкиОбменаССайтом. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			using (var Поток = new MemoryStream())
			{
				var НомерЭлемента = 0;
				foreach (var Ссылка in V82.Справочники/*Менеджер*/.НастройкиОбменаССайтом.Выбрать())
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
			Console.WriteLine("СериализацияJson 1000 элементов справочника НастройкиОбменаССайтом. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			var НомерЭлемента = 0;
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.НастройкиОбменаССайтом.Выбрать())
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
