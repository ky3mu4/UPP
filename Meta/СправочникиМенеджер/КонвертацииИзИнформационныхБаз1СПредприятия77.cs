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
	///<summary>
	///Конвертации из информационных баз 1С:Предприятия
	///</summary>
	public partial class КонвертацииИзИнформационныхБаз1СПредприятия77:СправочникМенеджер
	{
		
		public static СправочникиСсылка.КонвертацииИзИнформационныхБаз1СПредприятия77 НайтиПоКоду(string Код)
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
					,_Fld2436 [ИдентификаторКонфигурации]
					,_Fld2437 [Конфигурация]
					,_Fld2438 [НомерРелиза]
					,_Fld2439 [КонвертацияПомощник]
					,_Fld2440 [КонвертацияОбработка]
					,_Fld2441 [КонвертацияПравила]
					,_Fld2442 [ХранилищеПомощник]
					,_Fld2443 [ХранилищеОписаниеПомощника]
					,_Fld2444 [ХранилищеОбработка]
					,_Fld2445 [ХранилищеПравила]
					,_Fld2446 [ИдентификаторЭлемента]
					From _Reference127(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КонвертацииИзИнформационныхБаз1СПредприятия77();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.ИдентификаторКонфигурации = Читалка.GetString(6);
							Ссылка.Конфигурация = Читалка.GetString(7);
							Ссылка.НомерРелиза = Читалка.GetString(8);
							Ссылка.КонвертацияПомощник = Читалка.GetString(9);
							Ссылка.КонвертацияОбработка = Читалка.GetString(10);
							Ссылка.КонвертацияПравила = Читалка.GetString(11);
							Ссылка.ИдентификаторЭлемента = Читалка.GetString(16);
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
		
		public static СправочникиВыборка.КонвертацииИзИнформационныхБаз1СПредприятия77 Выбрать()
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
					,_Fld2436 [ИдентификаторКонфигурации]
					,_Fld2437 [Конфигурация]
					,_Fld2438 [НомерРелиза]
					,_Fld2439 [КонвертацияПомощник]
					,_Fld2440 [КонвертацияОбработка]
					,_Fld2441 [КонвертацияПравила]
					,_Fld2442 [ХранилищеПомощник]
					,_Fld2443 [ХранилищеОписаниеПомощника]
					,_Fld2444 [ХранилищеОбработка]
					,_Fld2445 [ХранилищеПравила]
					,_Fld2446 [ИдентификаторЭлемента]
					From _Reference127(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.КонвертацииИзИнформационныхБаз1СПредприятия77();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КонвертацииИзИнформационныхБаз1СПредприятия77();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.ИдентификаторКонфигурации = Читалка.GetString(6);
							Ссылка.Конфигурация = Читалка.GetString(7);
							Ссылка.НомерРелиза = Читалка.GetString(8);
							Ссылка.КонвертацияПомощник = Читалка.GetString(9);
							Ссылка.КонвертацияОбработка = Читалка.GetString(10);
							Ссылка.КонвертацияПравила = Читалка.GetString(11);
							Ссылка.ИдентификаторЭлемента = Читалка.GetString(16);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.КонвертацииИзИнформационныхБаз1СПредприятия77 ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld2436 [ИдентификаторКонфигурации]
					,_Fld2437 [Конфигурация]
					,_Fld2438 [НомерРелиза]
					,_Fld2439 [КонвертацияПомощник]
					,_Fld2440 [КонвертацияОбработка]
					,_Fld2441 [КонвертацияПравила]
					,_Fld2442 [ХранилищеПомощник]
					,_Fld2443 [ХранилищеОписаниеПомощника]
					,_Fld2444 [ХранилищеОбработка]
					,_Fld2445 [ХранилищеПравила]
					,_Fld2446 [ИдентификаторЭлемента]
					From _Reference127(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.КонвертацииИзИнформационныхБаз1СПредприятия77();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КонвертацииИзИнформационныхБаз1СПредприятия77();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.ИдентификаторКонфигурации = Читалка.GetString(6);
							Ссылка.Конфигурация = Читалка.GetString(7);
							Ссылка.НомерРелиза = Читалка.GetString(8);
							Ссылка.КонвертацияПомощник = Читалка.GetString(9);
							Ссылка.КонвертацияОбработка = Читалка.GetString(10);
							Ссылка.КонвертацияПравила = Читалка.GetString(11);
							Ссылка.ИдентификаторЭлемента = Читалка.GetString(16);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.КонвертацииИзИнформационныхБаз1СПредприятия77 ВыбратьПоКоду(int Первые,string Мин,string Макс)
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
					,_Fld2436 [ИдентификаторКонфигурации]
					,_Fld2437 [Конфигурация]
					,_Fld2438 [НомерРелиза]
					,_Fld2439 [КонвертацияПомощник]
					,_Fld2440 [КонвертацияОбработка]
					,_Fld2441 [КонвертацияПравила]
					,_Fld2442 [ХранилищеПомощник]
					,_Fld2443 [ХранилищеОписаниеПомощника]
					,_Fld2444 [ХранилищеОбработка]
					,_Fld2445 [ХранилищеПравила]
					,_Fld2446 [ИдентификаторЭлемента]
					From _Reference127(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.КонвертацииИзИнформационныхБаз1СПредприятия77();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КонвертацииИзИнформационныхБаз1СПредприятия77();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.ИдентификаторКонфигурации = Читалка.GetString(6);
							Ссылка.Конфигурация = Читалка.GetString(7);
							Ссылка.НомерРелиза = Читалка.GetString(8);
							Ссылка.КонвертацияПомощник = Читалка.GetString(9);
							Ссылка.КонвертацияОбработка = Читалка.GetString(10);
							Ссылка.КонвертацияПравила = Читалка.GetString(11);
							Ссылка.ИдентификаторЭлемента = Читалка.GetString(16);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.КонвертацииИзИнформационныхБаз1СПредприятия77 ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_Fld2436 [ИдентификаторКонфигурации]
					,_Fld2437 [Конфигурация]
					,_Fld2438 [НомерРелиза]
					,_Fld2439 [КонвертацияПомощник]
					,_Fld2440 [КонвертацияОбработка]
					,_Fld2441 [КонвертацияПравила]
					,_Fld2442 [ХранилищеПомощник]
					,_Fld2443 [ХранилищеОписаниеПомощника]
					,_Fld2444 [ХранилищеОбработка]
					,_Fld2445 [ХранилищеПравила]
					,_Fld2446 [ИдентификаторЭлемента]
					From _Reference127(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.КонвертацииИзИнформационныхБаз1СПредприятия77();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КонвертацииИзИнформационныхБаз1СПредприятия77();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.ИдентификаторКонфигурации = Читалка.GetString(6);
							Ссылка.Конфигурация = Читалка.GetString(7);
							Ссылка.НомерРелиза = Читалка.GetString(8);
							Ссылка.КонвертацияПомощник = Читалка.GetString(9);
							Ссылка.КонвертацияОбработка = Читалка.GetString(10);
							Ссылка.КонвертацияПравила = Читалка.GetString(11);
							Ссылка.ИдентификаторЭлемента = Читалка.GetString(16);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.КонвертацииИзИнформационныхБаз1СПредприятия77 СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld2436 [ИдентификаторКонфигурации]
					,_Fld2437 [Конфигурация]
					,_Fld2438 [НомерРелиза]
					,_Fld2439 [КонвертацияПомощник]
					,_Fld2440 [КонвертацияОбработка]
					,_Fld2441 [КонвертацияПравила]
					,_Fld2442 [ХранилищеПомощник]
					,_Fld2443 [ХранилищеОписаниеПомощника]
					,_Fld2444 [ХранилищеОбработка]
					,_Fld2445 [ХранилищеПравила]
					,_Fld2446 [ИдентификаторЭлемента]
					From _Reference127(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.КонвертацииИзИнформационныхБаз1СПредприятия77();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КонвертацииИзИнформационныхБаз1СПредприятия77();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.ИдентификаторКонфигурации = Читалка.GetString(6);
							Ссылка.Конфигурация = Читалка.GetString(7);
							Ссылка.НомерРелиза = Читалка.GetString(8);
							Ссылка.КонвертацияПомощник = Читалка.GetString(9);
							Ссылка.КонвертацияОбработка = Читалка.GetString(10);
							Ссылка.КонвертацияПравила = Читалка.GetString(11);
							Ссылка.ИдентификаторЭлемента = Читалка.GetString(16);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.КонвертацииИзИнформационныхБаз1СПредприятия77 СтраницаПоКоду(int Размер,int Номер)
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
					,_Fld2436 [ИдентификаторКонфигурации]
					,_Fld2437 [Конфигурация]
					,_Fld2438 [НомерРелиза]
					,_Fld2439 [КонвертацияПомощник]
					,_Fld2440 [КонвертацияОбработка]
					,_Fld2441 [КонвертацияПравила]
					,_Fld2442 [ХранилищеПомощник]
					,_Fld2443 [ХранилищеОписаниеПомощника]
					,_Fld2444 [ХранилищеОбработка]
					,_Fld2445 [ХранилищеПравила]
					,_Fld2446 [ИдентификаторЭлемента]
					From _Reference127(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.КонвертацииИзИнформационныхБаз1СПредприятия77();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КонвертацииИзИнформационныхБаз1СПредприятия77();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.ИдентификаторКонфигурации = Читалка.GetString(6);
							Ссылка.Конфигурация = Читалка.GetString(7);
							Ссылка.НомерРелиза = Читалка.GetString(8);
							Ссылка.КонвертацияПомощник = Читалка.GetString(9);
							Ссылка.КонвертацияОбработка = Читалка.GetString(10);
							Ссылка.КонвертацияПравила = Читалка.GetString(11);
							Ссылка.ИдентификаторЭлемента = Читалка.GetString(16);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.КонвертацииИзИнформационныхБаз1СПредприятия77 СтраницаПоНаименованию(int Размер,int Номер)
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
					,_Fld2436 [ИдентификаторКонфигурации]
					,_Fld2437 [Конфигурация]
					,_Fld2438 [НомерРелиза]
					,_Fld2439 [КонвертацияПомощник]
					,_Fld2440 [КонвертацияОбработка]
					,_Fld2441 [КонвертацияПравила]
					,_Fld2442 [ХранилищеПомощник]
					,_Fld2443 [ХранилищеОписаниеПомощника]
					,_Fld2444 [ХранилищеОбработка]
					,_Fld2445 [ХранилищеПравила]
					,_Fld2446 [ИдентификаторЭлемента]
					From _Reference127(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.КонвертацииИзИнформационныхБаз1СПредприятия77();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КонвертацииИзИнформационныхБаз1СПредприятия77();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.ИдентификаторКонфигурации = Читалка.GetString(6);
							Ссылка.Конфигурация = Читалка.GetString(7);
							Ссылка.НомерРелиза = Читалка.GetString(8);
							Ссылка.КонвертацияПомощник = Читалка.GetString(9);
							Ссылка.КонвертацияОбработка = Читалка.GetString(10);
							Ссылка.КонвертацияПравила = Читалка.GetString(11);
							Ссылка.ИдентификаторЭлемента = Читалка.GetString(16);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.КонвертацииИзИнформационныхБаз1СПредприятия77 СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.КонвертацииИзИнформационныхБаз1СПредприятия77();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ИдентификаторКонфигурации = "";
			Объект.Конфигурация = "";
			Объект.НомерРелиза = "";
			Объект.КонвертацияПомощник = "";
			Объект.КонвертацияОбработка = "";
			Объект.КонвертацияПравила = "";
			Объект.ИдентификаторЭлемента = "";
			return Объект;
		}
	}
}