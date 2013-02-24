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
	public partial class МедицинскиеСтраховыеПолисы:СправочникМенеджер
	{
		
		public static СправочникиСсылка.МедицинскиеСтраховыеПолисы НайтиПоКоду(string Код)
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
					,_Fld2539RRef [Физлицо]
					,_Fld2540RRef [Организация]
					,_Fld2541RRef [ВидСтрахования]
					,_Fld2542 [ДатаВыдачиПолиса]
					,_Fld2543 [ДатаОкончанияПолиса]
					,_Fld2544RRef [ПрограммаСтрахования]
					,_Fld2545 [СтрахованиеРодственника]
					,_Fld2546 [Родственник]
					,_Fld2547RRef [Пол]
					,_Fld2548 [ДатаРождения]
					,_Fld2549 [УдостоверениеЛичности]
					,_Fld2550 [АдресФактический]
					,_Fld2551 [ТелефонДомашний]
					,_Fld2552RRef [ДокументВид]
					,_Fld2553 [ДокументСерия]
					,_Fld2554 [ДокументНомер]
					,_Fld2555 [ДокументДатаВыдачи]
					,_Fld2556 [ДокументКемВыдан]
					,_Fld2557 [ДокументКодПодразделения]
					,_Fld2558 [Комментарий]
					From _Reference136(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.МедицинскиеСтраховыеПолисы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.Физлицо = new V82.СправочникиСсылка.ФизическиеЛица((byte[])Читалка.GetValue(6));
							//Ссылка.Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(7));
							Ссылка.ВидСтрахования = V82.Перечисления/*Ссылка*/.ВидыМедицинскогоСтрахования.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.ДатаВыдачиПолиса = Читалка.GetDateTime(9);
							Ссылка.ДатаОкончанияПолиса = Читалка.GetDateTime(10);
							//Ссылка.ПрограммаСтрахования = new V82.СправочникиСсылка.ПрограммыМедицинскогоСтрахования((byte[])Читалка.GetValue(11));
							Ссылка.СтрахованиеРодственника = ((byte[])Читалка.GetValue(12))[0]==1?true:false;
							Ссылка.Родственник = Читалка.GetString(13);
							Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Ссылка.ДатаРождения = Читалка.GetDateTime(15);
							Ссылка.УдостоверениеЛичности = Читалка.GetString(16);
							Ссылка.АдресФактический = Читалка.GetString(17);
							Ссылка.ТелефонДомашний = Читалка.GetString(18);
							//Ссылка.ДокументВид = new V82.СправочникиСсылка.ДокументыУдостоверяющиеЛичность((byte[])Читалка.GetValue(19));
							Ссылка.ДокументСерия = Читалка.GetString(20);
							Ссылка.ДокументНомер = Читалка.GetString(21);
							Ссылка.ДокументДатаВыдачи = Читалка.GetDateTime(22);
							Ссылка.ДокументКемВыдан = Читалка.GetString(23);
							Ссылка.ДокументКодПодразделения = Читалка.GetString(24);
							Ссылка.Комментарий = Читалка.GetString(25);
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
		
		public static СправочникиВыборка.МедицинскиеСтраховыеПолисы Выбрать()
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
					,_Fld2539RRef [Физлицо]
					,_Fld2540RRef [Организация]
					,_Fld2541RRef [ВидСтрахования]
					,_Fld2542 [ДатаВыдачиПолиса]
					,_Fld2543 [ДатаОкончанияПолиса]
					,_Fld2544RRef [ПрограммаСтрахования]
					,_Fld2545 [СтрахованиеРодственника]
					,_Fld2546 [Родственник]
					,_Fld2547RRef [Пол]
					,_Fld2548 [ДатаРождения]
					,_Fld2549 [УдостоверениеЛичности]
					,_Fld2550 [АдресФактический]
					,_Fld2551 [ТелефонДомашний]
					,_Fld2552RRef [ДокументВид]
					,_Fld2553 [ДокументСерия]
					,_Fld2554 [ДокументНомер]
					,_Fld2555 [ДокументДатаВыдачи]
					,_Fld2556 [ДокументКемВыдан]
					,_Fld2557 [ДокументКодПодразделения]
					,_Fld2558 [Комментарий]
					From _Reference136(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.МедицинскиеСтраховыеПолисы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.МедицинскиеСтраховыеПолисы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.Физлицо = new V82.СправочникиСсылка.ФизическиеЛица((byte[])Читалка.GetValue(6));
							//Ссылка.Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(7));
							Ссылка.ВидСтрахования = V82.Перечисления/*Ссылка*/.ВидыМедицинскогоСтрахования.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.ДатаВыдачиПолиса = Читалка.GetDateTime(9);
							Ссылка.ДатаОкончанияПолиса = Читалка.GetDateTime(10);
							//Ссылка.ПрограммаСтрахования = new V82.СправочникиСсылка.ПрограммыМедицинскогоСтрахования((byte[])Читалка.GetValue(11));
							Ссылка.СтрахованиеРодственника = ((byte[])Читалка.GetValue(12))[0]==1?true:false;
							Ссылка.Родственник = Читалка.GetString(13);
							Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Ссылка.ДатаРождения = Читалка.GetDateTime(15);
							Ссылка.УдостоверениеЛичности = Читалка.GetString(16);
							Ссылка.АдресФактический = Читалка.GetString(17);
							Ссылка.ТелефонДомашний = Читалка.GetString(18);
							//Ссылка.ДокументВид = new V82.СправочникиСсылка.ДокументыУдостоверяющиеЛичность((byte[])Читалка.GetValue(19));
							Ссылка.ДокументСерия = Читалка.GetString(20);
							Ссылка.ДокументНомер = Читалка.GetString(21);
							Ссылка.ДокументДатаВыдачи = Читалка.GetDateTime(22);
							Ссылка.ДокументКемВыдан = Читалка.GetString(23);
							Ссылка.ДокументКодПодразделения = Читалка.GetString(24);
							Ссылка.Комментарий = Читалка.GetString(25);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.МедицинскиеСтраховыеПолисы ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld2539RRef [Физлицо]
					,_Fld2540RRef [Организация]
					,_Fld2541RRef [ВидСтрахования]
					,_Fld2542 [ДатаВыдачиПолиса]
					,_Fld2543 [ДатаОкончанияПолиса]
					,_Fld2544RRef [ПрограммаСтрахования]
					,_Fld2545 [СтрахованиеРодственника]
					,_Fld2546 [Родственник]
					,_Fld2547RRef [Пол]
					,_Fld2548 [ДатаРождения]
					,_Fld2549 [УдостоверениеЛичности]
					,_Fld2550 [АдресФактический]
					,_Fld2551 [ТелефонДомашний]
					,_Fld2552RRef [ДокументВид]
					,_Fld2553 [ДокументСерия]
					,_Fld2554 [ДокументНомер]
					,_Fld2555 [ДокументДатаВыдачи]
					,_Fld2556 [ДокументКемВыдан]
					,_Fld2557 [ДокументКодПодразделения]
					,_Fld2558 [Комментарий]
					From _Reference136(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.МедицинскиеСтраховыеПолисы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.МедицинскиеСтраховыеПолисы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.Физлицо = new V82.СправочникиСсылка.ФизическиеЛица((byte[])Читалка.GetValue(6));
							//Ссылка.Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(7));
							Ссылка.ВидСтрахования = V82.Перечисления/*Ссылка*/.ВидыМедицинскогоСтрахования.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.ДатаВыдачиПолиса = Читалка.GetDateTime(9);
							Ссылка.ДатаОкончанияПолиса = Читалка.GetDateTime(10);
							//Ссылка.ПрограммаСтрахования = new V82.СправочникиСсылка.ПрограммыМедицинскогоСтрахования((byte[])Читалка.GetValue(11));
							Ссылка.СтрахованиеРодственника = ((byte[])Читалка.GetValue(12))[0]==1?true:false;
							Ссылка.Родственник = Читалка.GetString(13);
							Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Ссылка.ДатаРождения = Читалка.GetDateTime(15);
							Ссылка.УдостоверениеЛичности = Читалка.GetString(16);
							Ссылка.АдресФактический = Читалка.GetString(17);
							Ссылка.ТелефонДомашний = Читалка.GetString(18);
							//Ссылка.ДокументВид = new V82.СправочникиСсылка.ДокументыУдостоверяющиеЛичность((byte[])Читалка.GetValue(19));
							Ссылка.ДокументСерия = Читалка.GetString(20);
							Ссылка.ДокументНомер = Читалка.GetString(21);
							Ссылка.ДокументДатаВыдачи = Читалка.GetDateTime(22);
							Ссылка.ДокументКемВыдан = Читалка.GetString(23);
							Ссылка.ДокументКодПодразделения = Читалка.GetString(24);
							Ссылка.Комментарий = Читалка.GetString(25);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.МедицинскиеСтраховыеПолисы ВыбратьПоКоду(int Первые,string Мин,string Макс)
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
					,_Fld2539RRef [Физлицо]
					,_Fld2540RRef [Организация]
					,_Fld2541RRef [ВидСтрахования]
					,_Fld2542 [ДатаВыдачиПолиса]
					,_Fld2543 [ДатаОкончанияПолиса]
					,_Fld2544RRef [ПрограммаСтрахования]
					,_Fld2545 [СтрахованиеРодственника]
					,_Fld2546 [Родственник]
					,_Fld2547RRef [Пол]
					,_Fld2548 [ДатаРождения]
					,_Fld2549 [УдостоверениеЛичности]
					,_Fld2550 [АдресФактический]
					,_Fld2551 [ТелефонДомашний]
					,_Fld2552RRef [ДокументВид]
					,_Fld2553 [ДокументСерия]
					,_Fld2554 [ДокументНомер]
					,_Fld2555 [ДокументДатаВыдачи]
					,_Fld2556 [ДокументКемВыдан]
					,_Fld2557 [ДокументКодПодразделения]
					,_Fld2558 [Комментарий]
					From _Reference136(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.МедицинскиеСтраховыеПолисы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.МедицинскиеСтраховыеПолисы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.Физлицо = new V82.СправочникиСсылка.ФизическиеЛица((byte[])Читалка.GetValue(6));
							//Ссылка.Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(7));
							Ссылка.ВидСтрахования = V82.Перечисления/*Ссылка*/.ВидыМедицинскогоСтрахования.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.ДатаВыдачиПолиса = Читалка.GetDateTime(9);
							Ссылка.ДатаОкончанияПолиса = Читалка.GetDateTime(10);
							//Ссылка.ПрограммаСтрахования = new V82.СправочникиСсылка.ПрограммыМедицинскогоСтрахования((byte[])Читалка.GetValue(11));
							Ссылка.СтрахованиеРодственника = ((byte[])Читалка.GetValue(12))[0]==1?true:false;
							Ссылка.Родственник = Читалка.GetString(13);
							Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Ссылка.ДатаРождения = Читалка.GetDateTime(15);
							Ссылка.УдостоверениеЛичности = Читалка.GetString(16);
							Ссылка.АдресФактический = Читалка.GetString(17);
							Ссылка.ТелефонДомашний = Читалка.GetString(18);
							//Ссылка.ДокументВид = new V82.СправочникиСсылка.ДокументыУдостоверяющиеЛичность((byte[])Читалка.GetValue(19));
							Ссылка.ДокументСерия = Читалка.GetString(20);
							Ссылка.ДокументНомер = Читалка.GetString(21);
							Ссылка.ДокументДатаВыдачи = Читалка.GetDateTime(22);
							Ссылка.ДокументКемВыдан = Читалка.GetString(23);
							Ссылка.ДокументКодПодразделения = Читалка.GetString(24);
							Ссылка.Комментарий = Читалка.GetString(25);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.МедицинскиеСтраховыеПолисы ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_Fld2539RRef [Физлицо]
					,_Fld2540RRef [Организация]
					,_Fld2541RRef [ВидСтрахования]
					,_Fld2542 [ДатаВыдачиПолиса]
					,_Fld2543 [ДатаОкончанияПолиса]
					,_Fld2544RRef [ПрограммаСтрахования]
					,_Fld2545 [СтрахованиеРодственника]
					,_Fld2546 [Родственник]
					,_Fld2547RRef [Пол]
					,_Fld2548 [ДатаРождения]
					,_Fld2549 [УдостоверениеЛичности]
					,_Fld2550 [АдресФактический]
					,_Fld2551 [ТелефонДомашний]
					,_Fld2552RRef [ДокументВид]
					,_Fld2553 [ДокументСерия]
					,_Fld2554 [ДокументНомер]
					,_Fld2555 [ДокументДатаВыдачи]
					,_Fld2556 [ДокументКемВыдан]
					,_Fld2557 [ДокументКодПодразделения]
					,_Fld2558 [Комментарий]
					From _Reference136(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.МедицинскиеСтраховыеПолисы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.МедицинскиеСтраховыеПолисы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.Физлицо = new V82.СправочникиСсылка.ФизическиеЛица((byte[])Читалка.GetValue(6));
							//Ссылка.Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(7));
							Ссылка.ВидСтрахования = V82.Перечисления/*Ссылка*/.ВидыМедицинскогоСтрахования.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.ДатаВыдачиПолиса = Читалка.GetDateTime(9);
							Ссылка.ДатаОкончанияПолиса = Читалка.GetDateTime(10);
							//Ссылка.ПрограммаСтрахования = new V82.СправочникиСсылка.ПрограммыМедицинскогоСтрахования((byte[])Читалка.GetValue(11));
							Ссылка.СтрахованиеРодственника = ((byte[])Читалка.GetValue(12))[0]==1?true:false;
							Ссылка.Родственник = Читалка.GetString(13);
							Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Ссылка.ДатаРождения = Читалка.GetDateTime(15);
							Ссылка.УдостоверениеЛичности = Читалка.GetString(16);
							Ссылка.АдресФактический = Читалка.GetString(17);
							Ссылка.ТелефонДомашний = Читалка.GetString(18);
							//Ссылка.ДокументВид = new V82.СправочникиСсылка.ДокументыУдостоверяющиеЛичность((byte[])Читалка.GetValue(19));
							Ссылка.ДокументСерия = Читалка.GetString(20);
							Ссылка.ДокументНомер = Читалка.GetString(21);
							Ссылка.ДокументДатаВыдачи = Читалка.GetDateTime(22);
							Ссылка.ДокументКемВыдан = Читалка.GetString(23);
							Ссылка.ДокументКодПодразделения = Читалка.GetString(24);
							Ссылка.Комментарий = Читалка.GetString(25);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.МедицинскиеСтраховыеПолисы СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld2539RRef [Физлицо]
					,_Fld2540RRef [Организация]
					,_Fld2541RRef [ВидСтрахования]
					,_Fld2542 [ДатаВыдачиПолиса]
					,_Fld2543 [ДатаОкончанияПолиса]
					,_Fld2544RRef [ПрограммаСтрахования]
					,_Fld2545 [СтрахованиеРодственника]
					,_Fld2546 [Родственник]
					,_Fld2547RRef [Пол]
					,_Fld2548 [ДатаРождения]
					,_Fld2549 [УдостоверениеЛичности]
					,_Fld2550 [АдресФактический]
					,_Fld2551 [ТелефонДомашний]
					,_Fld2552RRef [ДокументВид]
					,_Fld2553 [ДокументСерия]
					,_Fld2554 [ДокументНомер]
					,_Fld2555 [ДокументДатаВыдачи]
					,_Fld2556 [ДокументКемВыдан]
					,_Fld2557 [ДокументКодПодразделения]
					,_Fld2558 [Комментарий]
					From _Reference136(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.МедицинскиеСтраховыеПолисы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.МедицинскиеСтраховыеПолисы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.Физлицо = new V82.СправочникиСсылка.ФизическиеЛица((byte[])Читалка.GetValue(6));
							//Ссылка.Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(7));
							Ссылка.ВидСтрахования = V82.Перечисления/*Ссылка*/.ВидыМедицинскогоСтрахования.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.ДатаВыдачиПолиса = Читалка.GetDateTime(9);
							Ссылка.ДатаОкончанияПолиса = Читалка.GetDateTime(10);
							//Ссылка.ПрограммаСтрахования = new V82.СправочникиСсылка.ПрограммыМедицинскогоСтрахования((byte[])Читалка.GetValue(11));
							Ссылка.СтрахованиеРодственника = ((byte[])Читалка.GetValue(12))[0]==1?true:false;
							Ссылка.Родственник = Читалка.GetString(13);
							Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Ссылка.ДатаРождения = Читалка.GetDateTime(15);
							Ссылка.УдостоверениеЛичности = Читалка.GetString(16);
							Ссылка.АдресФактический = Читалка.GetString(17);
							Ссылка.ТелефонДомашний = Читалка.GetString(18);
							//Ссылка.ДокументВид = new V82.СправочникиСсылка.ДокументыУдостоверяющиеЛичность((byte[])Читалка.GetValue(19));
							Ссылка.ДокументСерия = Читалка.GetString(20);
							Ссылка.ДокументНомер = Читалка.GetString(21);
							Ссылка.ДокументДатаВыдачи = Читалка.GetDateTime(22);
							Ссылка.ДокументКемВыдан = Читалка.GetString(23);
							Ссылка.ДокументКодПодразделения = Читалка.GetString(24);
							Ссылка.Комментарий = Читалка.GetString(25);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.МедицинскиеСтраховыеПолисы СтраницаПоКоду(int Размер,int Номер)
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
					,_Fld2539RRef [Физлицо]
					,_Fld2540RRef [Организация]
					,_Fld2541RRef [ВидСтрахования]
					,_Fld2542 [ДатаВыдачиПолиса]
					,_Fld2543 [ДатаОкончанияПолиса]
					,_Fld2544RRef [ПрограммаСтрахования]
					,_Fld2545 [СтрахованиеРодственника]
					,_Fld2546 [Родственник]
					,_Fld2547RRef [Пол]
					,_Fld2548 [ДатаРождения]
					,_Fld2549 [УдостоверениеЛичности]
					,_Fld2550 [АдресФактический]
					,_Fld2551 [ТелефонДомашний]
					,_Fld2552RRef [ДокументВид]
					,_Fld2553 [ДокументСерия]
					,_Fld2554 [ДокументНомер]
					,_Fld2555 [ДокументДатаВыдачи]
					,_Fld2556 [ДокументКемВыдан]
					,_Fld2557 [ДокументКодПодразделения]
					,_Fld2558 [Комментарий]
					From _Reference136(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.МедицинскиеСтраховыеПолисы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.МедицинскиеСтраховыеПолисы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.Физлицо = new V82.СправочникиСсылка.ФизическиеЛица((byte[])Читалка.GetValue(6));
							//Ссылка.Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(7));
							Ссылка.ВидСтрахования = V82.Перечисления/*Ссылка*/.ВидыМедицинскогоСтрахования.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.ДатаВыдачиПолиса = Читалка.GetDateTime(9);
							Ссылка.ДатаОкончанияПолиса = Читалка.GetDateTime(10);
							//Ссылка.ПрограммаСтрахования = new V82.СправочникиСсылка.ПрограммыМедицинскогоСтрахования((byte[])Читалка.GetValue(11));
							Ссылка.СтрахованиеРодственника = ((byte[])Читалка.GetValue(12))[0]==1?true:false;
							Ссылка.Родственник = Читалка.GetString(13);
							Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Ссылка.ДатаРождения = Читалка.GetDateTime(15);
							Ссылка.УдостоверениеЛичности = Читалка.GetString(16);
							Ссылка.АдресФактический = Читалка.GetString(17);
							Ссылка.ТелефонДомашний = Читалка.GetString(18);
							//Ссылка.ДокументВид = new V82.СправочникиСсылка.ДокументыУдостоверяющиеЛичность((byte[])Читалка.GetValue(19));
							Ссылка.ДокументСерия = Читалка.GetString(20);
							Ссылка.ДокументНомер = Читалка.GetString(21);
							Ссылка.ДокументДатаВыдачи = Читалка.GetDateTime(22);
							Ссылка.ДокументКемВыдан = Читалка.GetString(23);
							Ссылка.ДокументКодПодразделения = Читалка.GetString(24);
							Ссылка.Комментарий = Читалка.GetString(25);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.МедицинскиеСтраховыеПолисы СтраницаПоНаименованию(int Размер,int Номер)
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
					,_Fld2539RRef [Физлицо]
					,_Fld2540RRef [Организация]
					,_Fld2541RRef [ВидСтрахования]
					,_Fld2542 [ДатаВыдачиПолиса]
					,_Fld2543 [ДатаОкончанияПолиса]
					,_Fld2544RRef [ПрограммаСтрахования]
					,_Fld2545 [СтрахованиеРодственника]
					,_Fld2546 [Родственник]
					,_Fld2547RRef [Пол]
					,_Fld2548 [ДатаРождения]
					,_Fld2549 [УдостоверениеЛичности]
					,_Fld2550 [АдресФактический]
					,_Fld2551 [ТелефонДомашний]
					,_Fld2552RRef [ДокументВид]
					,_Fld2553 [ДокументСерия]
					,_Fld2554 [ДокументНомер]
					,_Fld2555 [ДокументДатаВыдачи]
					,_Fld2556 [ДокументКемВыдан]
					,_Fld2557 [ДокументКодПодразделения]
					,_Fld2558 [Комментарий]
					From _Reference136(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.МедицинскиеСтраховыеПолисы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.МедицинскиеСтраховыеПолисы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.Физлицо = new V82.СправочникиСсылка.ФизическиеЛица((byte[])Читалка.GetValue(6));
							//Ссылка.Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(7));
							Ссылка.ВидСтрахования = V82.Перечисления/*Ссылка*/.ВидыМедицинскогоСтрахования.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.ДатаВыдачиПолиса = Читалка.GetDateTime(9);
							Ссылка.ДатаОкончанияПолиса = Читалка.GetDateTime(10);
							//Ссылка.ПрограммаСтрахования = new V82.СправочникиСсылка.ПрограммыМедицинскогоСтрахования((byte[])Читалка.GetValue(11));
							Ссылка.СтрахованиеРодственника = ((byte[])Читалка.GetValue(12))[0]==1?true:false;
							Ссылка.Родственник = Читалка.GetString(13);
							Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Ссылка.ДатаРождения = Читалка.GetDateTime(15);
							Ссылка.УдостоверениеЛичности = Читалка.GetString(16);
							Ссылка.АдресФактический = Читалка.GetString(17);
							Ссылка.ТелефонДомашний = Читалка.GetString(18);
							//Ссылка.ДокументВид = new V82.СправочникиСсылка.ДокументыУдостоверяющиеЛичность((byte[])Читалка.GetValue(19));
							Ссылка.ДокументСерия = Читалка.GetString(20);
							Ссылка.ДокументНомер = Читалка.GetString(21);
							Ссылка.ДокументДатаВыдачи = Читалка.GetDateTime(22);
							Ссылка.ДокументКемВыдан = Читалка.GetString(23);
							Ссылка.ДокументКодПодразделения = Читалка.GetString(24);
							Ссылка.Комментарий = Читалка.GetString(25);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.МедицинскиеСтраховыеПолисы СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.МедицинскиеСтраховыеПолисы();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Родственник = "";
			Объект.УдостоверениеЛичности = "";
			Объект.АдресФактический = "";
			Объект.ТелефонДомашний = "";
			Объект.ДокументСерия = "";
			Объект.ДокументНомер = "";
			Объект.ДокументКемВыдан = "";
			Объект.ДокументКодПодразделения = "";
			Объект.Комментарий = "";
			Объект.Физлицо = new V82.СправочникиСсылка.ФизическиеЛица();
			Объект.Организация = new V82.СправочникиСсылка.Организации();
			Объект.ВидСтрахования = V82.Перечисления/*Ссылка*/.ВидыМедицинскогоСтрахования.ПустаяСсылка;
			Объект.ПрограммаСтрахования = new V82.СправочникиСсылка.ПрограммыМедицинскогоСтрахования();
			Объект.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка;
			Объект.ДокументВид = new V82.СправочникиСсылка.ДокументыУдостоверяющиеЛичность();
			return Объект;
		}
	}
}