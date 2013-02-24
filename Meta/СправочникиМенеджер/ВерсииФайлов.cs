﻿
using System;
using System.Data.SqlClient;
using V82;
using V82.СправочникиСсылка;
using V82.Справочники;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.Справочники//Менеджер
{
	public partial class ВерсииФайлов:СправочникМенеджер
	{
		
		public static СправочникиСсылка.ВерсииФайлов НайтиПоКоду(string Код)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1895RRef [Автор]
					,_Fld1896 [ДатаМодификацииУниверсальная]
					,_Fld1897 [ДатаСоздания]
					,_Fld1898 [Зашифрован]
					,_Fld1899 [ИндексКартинки]
					,_Fld1900 [Комментарий]
					,_Fld1901 [НомерВерсии]
					,_Fld1902 [ПодписанЭЦП]
					,_Fld1903 [ПолноеНаименование]
					,_Fld1904 [ПутьКФайлу]
					,_Fld1905 [Размер]
					,_Fld1906 [Расширение]
					,_Fld1907RRef [РодительскаяВерсия]
					,_Fld1908RRef [СтатусИзвлеченияТекста]
					,_Fld1909 [ТекстХранилище]
					,_Fld1910RRef [ТипХраненияФайла]
					,_Fld1911RRef [Том]
					,_Fld1912 [ФайлХранилище]
					From _Reference44(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ВерсииФайлов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.Автор = new V82.СправочникиСсылка.Пользователи((byte[])Читалка.GetValue(6));
							Ссылка.ДатаМодификацииУниверсальная = Читалка.GetDateTime(7);
							Ссылка.ДатаСоздания = Читалка.GetDateTime(8);
							Ссылка.Зашифрован = ((byte[])Читалка.GetValue(9))[0]==1?true:false;
							Ссылка.ИндексКартинки = Читалка.GetDecimal(10);
							Ссылка.Комментарий = Читалка.GetString(11);
							Ссылка.НомерВерсии = Читалка.GetDecimal(12);
							Ссылка.ПодписанЭЦП = ((byte[])Читалка.GetValue(13))[0]==1?true:false;
							Ссылка.ПолноеНаименование = Читалка.GetString(14);
							Ссылка.ПутьКФайлу = Читалка.GetString(15);
							Ссылка.Размер = Читалка.GetDecimal(16);
							Ссылка.Расширение = Читалка.GetString(17);
							//Ссылка.РодительскаяВерсия = new V82.СправочникиСсылка.ВерсииФайлов((byte[])Читалка.GetValue(18));
							Ссылка.СтатусИзвлеченияТекста = V82.Перечисления/*Ссылка*/.СтатусыИзвлеченияТекстаФайлов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(19));
							Ссылка.ТипХраненияФайла = V82.Перечисления/*Ссылка*/.ТипыХраненияФайлов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(21));
							//Ссылка.Том = new V82.СправочникиСсылка.ТомаХраненияФайлов((byte[])Читалка.GetValue(22));
							return Ссылка;
						}
						else
						{
							return null;
						}
					}
				}
			}
		}
		
		public static СправочникиВыборка.ВерсииФайлов Выбрать()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1895RRef [Автор]
					,_Fld1896 [ДатаМодификацииУниверсальная]
					,_Fld1897 [ДатаСоздания]
					,_Fld1898 [Зашифрован]
					,_Fld1899 [ИндексКартинки]
					,_Fld1900 [Комментарий]
					,_Fld1901 [НомерВерсии]
					,_Fld1902 [ПодписанЭЦП]
					,_Fld1903 [ПолноеНаименование]
					,_Fld1904 [ПутьКФайлу]
					,_Fld1905 [Размер]
					,_Fld1906 [Расширение]
					,_Fld1907RRef [РодительскаяВерсия]
					,_Fld1908RRef [СтатусИзвлеченияТекста]
					,_Fld1909 [ТекстХранилище]
					,_Fld1910RRef [ТипХраненияФайла]
					,_Fld1911RRef [Том]
					,_Fld1912 [ФайлХранилище]
					From _Reference44(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ВерсииФайлов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ВерсииФайлов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.Автор = new V82.СправочникиСсылка.Пользователи((byte[])Читалка.GetValue(6));
							Ссылка.ДатаМодификацииУниверсальная = Читалка.GetDateTime(7);
							Ссылка.ДатаСоздания = Читалка.GetDateTime(8);
							Ссылка.Зашифрован = ((byte[])Читалка.GetValue(9))[0]==1?true:false;
							Ссылка.ИндексКартинки = Читалка.GetDecimal(10);
							Ссылка.Комментарий = Читалка.GetString(11);
							Ссылка.НомерВерсии = Читалка.GetDecimal(12);
							Ссылка.ПодписанЭЦП = ((byte[])Читалка.GetValue(13))[0]==1?true:false;
							Ссылка.ПолноеНаименование = Читалка.GetString(14);
							Ссылка.ПутьКФайлу = Читалка.GetString(15);
							Ссылка.Размер = Читалка.GetDecimal(16);
							Ссылка.Расширение = Читалка.GetString(17);
							//Ссылка.РодительскаяВерсия = new V82.СправочникиСсылка.ВерсииФайлов((byte[])Читалка.GetValue(18));
							Ссылка.СтатусИзвлеченияТекста = V82.Перечисления/*Ссылка*/.СтатусыИзвлеченияТекстаФайлов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(19));
							Ссылка.ТипХраненияФайла = V82.Перечисления/*Ссылка*/.ТипыХраненияФайлов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(21));
							//Ссылка.Том = new V82.СправочникиСсылка.ТомаХраненияФайлов((byte[])Читалка.GetValue(22));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ВерсииФайлов ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1895RRef [Автор]
					,_Fld1896 [ДатаМодификацииУниверсальная]
					,_Fld1897 [ДатаСоздания]
					,_Fld1898 [Зашифрован]
					,_Fld1899 [ИндексКартинки]
					,_Fld1900 [Комментарий]
					,_Fld1901 [НомерВерсии]
					,_Fld1902 [ПодписанЭЦП]
					,_Fld1903 [ПолноеНаименование]
					,_Fld1904 [ПутьКФайлу]
					,_Fld1905 [Размер]
					,_Fld1906 [Расширение]
					,_Fld1907RRef [РодительскаяВерсия]
					,_Fld1908RRef [СтатусИзвлеченияТекста]
					,_Fld1909 [ТекстХранилище]
					,_Fld1910RRef [ТипХраненияФайла]
					,_Fld1911RRef [Том]
					,_Fld1912 [ФайлХранилище]
					From _Reference44(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ВерсииФайлов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ВерсииФайлов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.Автор = new V82.СправочникиСсылка.Пользователи((byte[])Читалка.GetValue(6));
							Ссылка.ДатаМодификацииУниверсальная = Читалка.GetDateTime(7);
							Ссылка.ДатаСоздания = Читалка.GetDateTime(8);
							Ссылка.Зашифрован = ((byte[])Читалка.GetValue(9))[0]==1?true:false;
							Ссылка.ИндексКартинки = Читалка.GetDecimal(10);
							Ссылка.Комментарий = Читалка.GetString(11);
							Ссылка.НомерВерсии = Читалка.GetDecimal(12);
							Ссылка.ПодписанЭЦП = ((byte[])Читалка.GetValue(13))[0]==1?true:false;
							Ссылка.ПолноеНаименование = Читалка.GetString(14);
							Ссылка.ПутьКФайлу = Читалка.GetString(15);
							Ссылка.Размер = Читалка.GetDecimal(16);
							Ссылка.Расширение = Читалка.GetString(17);
							//Ссылка.РодительскаяВерсия = new V82.СправочникиСсылка.ВерсииФайлов((byte[])Читалка.GetValue(18));
							Ссылка.СтатусИзвлеченияТекста = V82.Перечисления/*Ссылка*/.СтатусыИзвлеченияТекстаФайлов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(19));
							Ссылка.ТипХраненияФайла = V82.Перечисления/*Ссылка*/.ТипыХраненияФайлов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(21));
							//Ссылка.Том = new V82.СправочникиСсылка.ТомаХраненияФайлов((byte[])Читалка.GetValue(22));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ВерсииФайлов ВыбратьПоКоду(int Первые,string Мин,string Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1895RRef [Автор]
					,_Fld1896 [ДатаМодификацииУниверсальная]
					,_Fld1897 [ДатаСоздания]
					,_Fld1898 [Зашифрован]
					,_Fld1899 [ИндексКартинки]
					,_Fld1900 [Комментарий]
					,_Fld1901 [НомерВерсии]
					,_Fld1902 [ПодписанЭЦП]
					,_Fld1903 [ПолноеНаименование]
					,_Fld1904 [ПутьКФайлу]
					,_Fld1905 [Размер]
					,_Fld1906 [Расширение]
					,_Fld1907RRef [РодительскаяВерсия]
					,_Fld1908RRef [СтатусИзвлеченияТекста]
					,_Fld1909 [ТекстХранилище]
					,_Fld1910RRef [ТипХраненияФайла]
					,_Fld1911RRef [Том]
					,_Fld1912 [ФайлХранилище]
					From _Reference44(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ВерсииФайлов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ВерсииФайлов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.Автор = new V82.СправочникиСсылка.Пользователи((byte[])Читалка.GetValue(6));
							Ссылка.ДатаМодификацииУниверсальная = Читалка.GetDateTime(7);
							Ссылка.ДатаСоздания = Читалка.GetDateTime(8);
							Ссылка.Зашифрован = ((byte[])Читалка.GetValue(9))[0]==1?true:false;
							Ссылка.ИндексКартинки = Читалка.GetDecimal(10);
							Ссылка.Комментарий = Читалка.GetString(11);
							Ссылка.НомерВерсии = Читалка.GetDecimal(12);
							Ссылка.ПодписанЭЦП = ((byte[])Читалка.GetValue(13))[0]==1?true:false;
							Ссылка.ПолноеНаименование = Читалка.GetString(14);
							Ссылка.ПутьКФайлу = Читалка.GetString(15);
							Ссылка.Размер = Читалка.GetDecimal(16);
							Ссылка.Расширение = Читалка.GetString(17);
							//Ссылка.РодительскаяВерсия = new V82.СправочникиСсылка.ВерсииФайлов((byte[])Читалка.GetValue(18));
							Ссылка.СтатусИзвлеченияТекста = V82.Перечисления/*Ссылка*/.СтатусыИзвлеченияТекстаФайлов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(19));
							Ссылка.ТипХраненияФайла = V82.Перечисления/*Ссылка*/.ТипыХраненияФайлов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(21));
							//Ссылка.Том = new V82.СправочникиСсылка.ТомаХраненияФайлов((byte[])Читалка.GetValue(22));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ВерсииФайлов ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1895RRef [Автор]
					,_Fld1896 [ДатаМодификацииУниверсальная]
					,_Fld1897 [ДатаСоздания]
					,_Fld1898 [Зашифрован]
					,_Fld1899 [ИндексКартинки]
					,_Fld1900 [Комментарий]
					,_Fld1901 [НомерВерсии]
					,_Fld1902 [ПодписанЭЦП]
					,_Fld1903 [ПолноеНаименование]
					,_Fld1904 [ПутьКФайлу]
					,_Fld1905 [Размер]
					,_Fld1906 [Расширение]
					,_Fld1907RRef [РодительскаяВерсия]
					,_Fld1908RRef [СтатусИзвлеченияТекста]
					,_Fld1909 [ТекстХранилище]
					,_Fld1910RRef [ТипХраненияФайла]
					,_Fld1911RRef [Том]
					,_Fld1912 [ФайлХранилище]
					From _Reference44(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ВерсииФайлов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ВерсииФайлов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.Автор = new V82.СправочникиСсылка.Пользователи((byte[])Читалка.GetValue(6));
							Ссылка.ДатаМодификацииУниверсальная = Читалка.GetDateTime(7);
							Ссылка.ДатаСоздания = Читалка.GetDateTime(8);
							Ссылка.Зашифрован = ((byte[])Читалка.GetValue(9))[0]==1?true:false;
							Ссылка.ИндексКартинки = Читалка.GetDecimal(10);
							Ссылка.Комментарий = Читалка.GetString(11);
							Ссылка.НомерВерсии = Читалка.GetDecimal(12);
							Ссылка.ПодписанЭЦП = ((byte[])Читалка.GetValue(13))[0]==1?true:false;
							Ссылка.ПолноеНаименование = Читалка.GetString(14);
							Ссылка.ПутьКФайлу = Читалка.GetString(15);
							Ссылка.Размер = Читалка.GetDecimal(16);
							Ссылка.Расширение = Читалка.GetString(17);
							//Ссылка.РодительскаяВерсия = new V82.СправочникиСсылка.ВерсииФайлов((byte[])Читалка.GetValue(18));
							Ссылка.СтатусИзвлеченияТекста = V82.Перечисления/*Ссылка*/.СтатусыИзвлеченияТекстаФайлов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(19));
							Ссылка.ТипХраненияФайла = V82.Перечисления/*Ссылка*/.ТипыХраненияФайлов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(21));
							//Ссылка.Том = new V82.СправочникиСсылка.ТомаХраненияФайлов((byte[])Читалка.GetValue(22));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ВерсииФайлов СтраницаПоСсылке(int Размер,int Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1895RRef [Автор]
					,_Fld1896 [ДатаМодификацииУниверсальная]
					,_Fld1897 [ДатаСоздания]
					,_Fld1898 [Зашифрован]
					,_Fld1899 [ИндексКартинки]
					,_Fld1900 [Комментарий]
					,_Fld1901 [НомерВерсии]
					,_Fld1902 [ПодписанЭЦП]
					,_Fld1903 [ПолноеНаименование]
					,_Fld1904 [ПутьКФайлу]
					,_Fld1905 [Размер]
					,_Fld1906 [Расширение]
					,_Fld1907RRef [РодительскаяВерсия]
					,_Fld1908RRef [СтатусИзвлеченияТекста]
					,_Fld1909 [ТекстХранилище]
					,_Fld1910RRef [ТипХраненияФайла]
					,_Fld1911RRef [Том]
					,_Fld1912 [ФайлХранилище]
					From _Reference44(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ВерсииФайлов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ВерсииФайлов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.Автор = new V82.СправочникиСсылка.Пользователи((byte[])Читалка.GetValue(6));
							Ссылка.ДатаМодификацииУниверсальная = Читалка.GetDateTime(7);
							Ссылка.ДатаСоздания = Читалка.GetDateTime(8);
							Ссылка.Зашифрован = ((byte[])Читалка.GetValue(9))[0]==1?true:false;
							Ссылка.ИндексКартинки = Читалка.GetDecimal(10);
							Ссылка.Комментарий = Читалка.GetString(11);
							Ссылка.НомерВерсии = Читалка.GetDecimal(12);
							Ссылка.ПодписанЭЦП = ((byte[])Читалка.GetValue(13))[0]==1?true:false;
							Ссылка.ПолноеНаименование = Читалка.GetString(14);
							Ссылка.ПутьКФайлу = Читалка.GetString(15);
							Ссылка.Размер = Читалка.GetDecimal(16);
							Ссылка.Расширение = Читалка.GetString(17);
							//Ссылка.РодительскаяВерсия = new V82.СправочникиСсылка.ВерсииФайлов((byte[])Читалка.GetValue(18));
							Ссылка.СтатусИзвлеченияТекста = V82.Перечисления/*Ссылка*/.СтатусыИзвлеченияТекстаФайлов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(19));
							Ссылка.ТипХраненияФайла = V82.Перечисления/*Ссылка*/.ТипыХраненияФайлов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(21));
							//Ссылка.Том = new V82.СправочникиСсылка.ТомаХраненияФайлов((byte[])Читалка.GetValue(22));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ВерсииФайлов СтраницаПоКоду(int Размер,int Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1895RRef [Автор]
					,_Fld1896 [ДатаМодификацииУниверсальная]
					,_Fld1897 [ДатаСоздания]
					,_Fld1898 [Зашифрован]
					,_Fld1899 [ИндексКартинки]
					,_Fld1900 [Комментарий]
					,_Fld1901 [НомерВерсии]
					,_Fld1902 [ПодписанЭЦП]
					,_Fld1903 [ПолноеНаименование]
					,_Fld1904 [ПутьКФайлу]
					,_Fld1905 [Размер]
					,_Fld1906 [Расширение]
					,_Fld1907RRef [РодительскаяВерсия]
					,_Fld1908RRef [СтатусИзвлеченияТекста]
					,_Fld1909 [ТекстХранилище]
					,_Fld1910RRef [ТипХраненияФайла]
					,_Fld1911RRef [Том]
					,_Fld1912 [ФайлХранилище]
					From _Reference44(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ВерсииФайлов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ВерсииФайлов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.Автор = new V82.СправочникиСсылка.Пользователи((byte[])Читалка.GetValue(6));
							Ссылка.ДатаМодификацииУниверсальная = Читалка.GetDateTime(7);
							Ссылка.ДатаСоздания = Читалка.GetDateTime(8);
							Ссылка.Зашифрован = ((byte[])Читалка.GetValue(9))[0]==1?true:false;
							Ссылка.ИндексКартинки = Читалка.GetDecimal(10);
							Ссылка.Комментарий = Читалка.GetString(11);
							Ссылка.НомерВерсии = Читалка.GetDecimal(12);
							Ссылка.ПодписанЭЦП = ((byte[])Читалка.GetValue(13))[0]==1?true:false;
							Ссылка.ПолноеНаименование = Читалка.GetString(14);
							Ссылка.ПутьКФайлу = Читалка.GetString(15);
							Ссылка.Размер = Читалка.GetDecimal(16);
							Ссылка.Расширение = Читалка.GetString(17);
							//Ссылка.РодительскаяВерсия = new V82.СправочникиСсылка.ВерсииФайлов((byte[])Читалка.GetValue(18));
							Ссылка.СтатусИзвлеченияТекста = V82.Перечисления/*Ссылка*/.СтатусыИзвлеченияТекстаФайлов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(19));
							Ссылка.ТипХраненияФайла = V82.Перечисления/*Ссылка*/.ТипыХраненияФайлов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(21));
							//Ссылка.Том = new V82.СправочникиСсылка.ТомаХраненияФайлов((byte[])Читалка.GetValue(22));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ВерсииФайлов СтраницаПоНаименованию(int Размер,int Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1895RRef [Автор]
					,_Fld1896 [ДатаМодификацииУниверсальная]
					,_Fld1897 [ДатаСоздания]
					,_Fld1898 [Зашифрован]
					,_Fld1899 [ИндексКартинки]
					,_Fld1900 [Комментарий]
					,_Fld1901 [НомерВерсии]
					,_Fld1902 [ПодписанЭЦП]
					,_Fld1903 [ПолноеНаименование]
					,_Fld1904 [ПутьКФайлу]
					,_Fld1905 [Размер]
					,_Fld1906 [Расширение]
					,_Fld1907RRef [РодительскаяВерсия]
					,_Fld1908RRef [СтатусИзвлеченияТекста]
					,_Fld1909 [ТекстХранилище]
					,_Fld1910RRef [ТипХраненияФайла]
					,_Fld1911RRef [Том]
					,_Fld1912 [ФайлХранилище]
					From _Reference44(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ВерсииФайлов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ВерсииФайлов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.Автор = new V82.СправочникиСсылка.Пользователи((byte[])Читалка.GetValue(6));
							Ссылка.ДатаМодификацииУниверсальная = Читалка.GetDateTime(7);
							Ссылка.ДатаСоздания = Читалка.GetDateTime(8);
							Ссылка.Зашифрован = ((byte[])Читалка.GetValue(9))[0]==1?true:false;
							Ссылка.ИндексКартинки = Читалка.GetDecimal(10);
							Ссылка.Комментарий = Читалка.GetString(11);
							Ссылка.НомерВерсии = Читалка.GetDecimal(12);
							Ссылка.ПодписанЭЦП = ((byte[])Читалка.GetValue(13))[0]==1?true:false;
							Ссылка.ПолноеНаименование = Читалка.GetString(14);
							Ссылка.ПутьКФайлу = Читалка.GetString(15);
							Ссылка.Размер = Читалка.GetDecimal(16);
							Ссылка.Расширение = Читалка.GetString(17);
							//Ссылка.РодительскаяВерсия = new V82.СправочникиСсылка.ВерсииФайлов((byte[])Читалка.GetValue(18));
							Ссылка.СтатусИзвлеченияТекста = V82.Перечисления/*Ссылка*/.СтатусыИзвлеченияТекстаФайлов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(19));
							Ссылка.ТипХраненияФайла = V82.Перечисления/*Ссылка*/.ТипыХраненияФайлов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(21));
							//Ссылка.Том = new V82.СправочникиСсылка.ТомаХраненияФайлов((byte[])Читалка.GetValue(22));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.ВерсииФайлов СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.ВерсииФайлов();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Комментарий = "";
			Объект.ПолноеНаименование = "";
			Объект.ПутьКФайлу = "";
			Объект.Расширение = "";
			Объект.Автор = new V82.СправочникиСсылка.Пользователи();
			Объект.РодительскаяВерсия = new V82.СправочникиСсылка.ВерсииФайлов();
			Объект.СтатусИзвлеченияТекста = V82.Перечисления/*Ссылка*/.СтатусыИзвлеченияТекстаФайлов.ПустаяСсылка;
			Объект.ТипХраненияФайла = V82.Перечисления/*Ссылка*/.ТипыХраненияФайлов.ПустаяСсылка;
			Объект.Том = new V82.СправочникиСсылка.ТомаХраненияФайлов();
			return Объект;
		}
	}
}