﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ТипыОтветаНаВопросАнкеты
	{
		ПустаяСсылка = - 1,
		Строка = 0,//строки
		Число = 1,//числа
		Дата = 2,//даты
		Булево = 3,//да/нет
		ОдинИзВариантовОтвета = 4,//одного из вариантов
		НесколькоВариантовОтвета = 5,//нескольких вариантов из списка
		УдалитьАдрес = 6,//адреса
		УдалитьТелефон = 7,//телефонного номера
		УдалитьАдресЭлектроннойПочты = 8,//адреса электронной почты
		УдалитьВебСтраница = 9,//ссылки на веб-страницу
		УдалитьДругое = 10,//другой контактной информации
		Табличный = 11,//таблицы
		Текст = 12,//текста
		КонтактнаяИнформация = 14,//контактной информации
	}
	public static partial class ТипыОтветаНаВопросАнкеты_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Строка = new Guid("a34c30a7-c5c6-e4f1-4306-224fa626e124");//строки
		public static readonly Guid Число = new Guid("cb445ab9-9bc6-71d4-4bf3-e2e0bc109286");//числа
		public static readonly Guid Дата = new Guid("a5d5dd9a-7d3a-2acb-4180-a9e4f797b5f5");//даты
		public static readonly Guid Булево = new Guid("033eddb9-d9cd-6110-45a3-c86b6114768f");//да/нет
		public static readonly Guid ОдинИзВариантовОтвета = new Guid("b025f48f-85a9-57d0-4cf8-ae2d6a2372dd");//одного из вариантов
		public static readonly Guid НесколькоВариантовОтвета = new Guid("1860a695-a8bb-abb3-4de2-80d614dbd1dc");//нескольких вариантов из списка
		public static readonly Guid УдалитьАдрес = new Guid("7d019a8c-6d63-c3ea-4210-eeed89f9da8e");//адреса
		public static readonly Guid УдалитьТелефон = new Guid("fdc28e81-30b3-3627-4d42-0c28b7c59df6");//телефонного номера
		public static readonly Guid УдалитьАдресЭлектроннойПочты = new Guid("d6d6d6a3-b8db-2dcb-4e44-b24ed421e10c");//адреса электронной почты
		public static readonly Guid УдалитьВебСтраница = new Guid("787019bf-b911-e896-4a27-a26359f25c1f");//ссылки на веб-страницу
		public static readonly Guid УдалитьДругое = new Guid("e0b7aeb2-a865-7f1e-4ea7-8bf37e53bbb2");//другой контактной информации
		public static readonly Guid Табличный = new Guid("172db5af-d99a-8259-40dc-6b657140eab7");//таблицы
		public static readonly Guid Текст = new Guid("6d2f9a9c-a2c6-5686-4969-f8d8cf471838");//текста
		public static readonly Guid КонтактнаяИнформация = new Guid("ee0ceb8e-0130-1099-4c66-3fc3d52eda4e");//контактной информации
		public static ТипыОтветаНаВопросАнкеты Получить(this ТипыОтветаНаВопросАнкеты Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ТипыОтветаНаВопросАнкеты Получить(this ТипыОтветаНаВопросАнкеты Значение, Guid Ссылка)
		{
			if(Ссылка == Строка)
			{
				return ТипыОтветаНаВопросАнкеты.Строка;
			}
			else if(Ссылка == Число)
			{
				return ТипыОтветаНаВопросАнкеты.Число;
			}
			else if(Ссылка == Дата)
			{
				return ТипыОтветаНаВопросАнкеты.Дата;
			}
			else if(Ссылка == Булево)
			{
				return ТипыОтветаНаВопросАнкеты.Булево;
			}
			else if(Ссылка == ОдинИзВариантовОтвета)
			{
				return ТипыОтветаНаВопросАнкеты.ОдинИзВариантовОтвета;
			}
			else if(Ссылка == НесколькоВариантовОтвета)
			{
				return ТипыОтветаНаВопросАнкеты.НесколькоВариантовОтвета;
			}
			else if(Ссылка == УдалитьАдрес)
			{
				return ТипыОтветаНаВопросАнкеты.УдалитьАдрес;
			}
			else if(Ссылка == УдалитьТелефон)
			{
				return ТипыОтветаНаВопросАнкеты.УдалитьТелефон;
			}
			else if(Ссылка == УдалитьАдресЭлектроннойПочты)
			{
				return ТипыОтветаНаВопросАнкеты.УдалитьАдресЭлектроннойПочты;
			}
			else if(Ссылка == УдалитьВебСтраница)
			{
				return ТипыОтветаНаВопросАнкеты.УдалитьВебСтраница;
			}
			else if(Ссылка == УдалитьДругое)
			{
				return ТипыОтветаНаВопросАнкеты.УдалитьДругое;
			}
			else if(Ссылка == Табличный)
			{
				return ТипыОтветаНаВопросАнкеты.Табличный;
			}
			else if(Ссылка == Текст)
			{
				return ТипыОтветаНаВопросАнкеты.Текст;
			}
			else if(Ссылка == КонтактнаяИнформация)
			{
				return ТипыОтветаНаВопросАнкеты.КонтактнаяИнформация;
			}
			return ТипыОтветаНаВопросАнкеты.ПустаяСсылка;
		}
		public static byte[] Ключ(this ТипыОтветаНаВопросАнкеты Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ТипыОтветаНаВопросАнкеты Значение)
		{
			switch (Значение)
			{
				case ТипыОтветаНаВопросАнкеты.Строка: return Строка;
				case ТипыОтветаНаВопросАнкеты.Число: return Число;
				case ТипыОтветаНаВопросАнкеты.Дата: return Дата;
				case ТипыОтветаНаВопросАнкеты.Булево: return Булево;
				case ТипыОтветаНаВопросАнкеты.ОдинИзВариантовОтвета: return ОдинИзВариантовОтвета;
				case ТипыОтветаНаВопросАнкеты.НесколькоВариантовОтвета: return НесколькоВариантовОтвета;
				case ТипыОтветаНаВопросАнкеты.УдалитьАдрес: return УдалитьАдрес;
				case ТипыОтветаНаВопросАнкеты.УдалитьТелефон: return УдалитьТелефон;
				case ТипыОтветаНаВопросАнкеты.УдалитьАдресЭлектроннойПочты: return УдалитьАдресЭлектроннойПочты;
				case ТипыОтветаНаВопросАнкеты.УдалитьВебСтраница: return УдалитьВебСтраница;
				case ТипыОтветаНаВопросАнкеты.УдалитьДругое: return УдалитьДругое;
				case ТипыОтветаНаВопросАнкеты.Табличный: return Табличный;
				case ТипыОтветаНаВопросАнкеты.Текст: return Текст;
				case ТипыОтветаНаВопросАнкеты.КонтактнаяИнформация: return КонтактнаяИнформация;
			}
			return Guid.Empty;
		}
	}
}
