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
	///(Упр)
	///</summary>
	public partial class Проекты:СправочникМенеджер
	{
		
		public static СправочникиСсылка.Проекты НайтиПоСсылке(Guid _Ссылка)
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
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1655 [ДатаНачала]
					,_Fld1656 [ДатаОкончания]
					,_Fld1657RRef [Ответственный]
					,_Fld1658 [Описание]
					From _Reference129(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Проекты();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.Проекты.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ДатаНачала = Читалка.GetDateTime(8);
								Ссылка.ДатаОкончания = Читалка.GetDateTime(9);
								Ссылка.Ответственный = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.Описание = Читалка.GetString(11);
							}
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
		
		public static СправочникиСсылка.Проекты НайтиПоКоду(string Код)
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
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1655 [ДатаНачала]
					,_Fld1656 [ДатаОкончания]
					,_Fld1657RRef [Ответственный]
					,_Fld1658 [Описание]
					From _Reference129(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Проекты();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.Проекты.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ДатаНачала = Читалка.GetDateTime(8);
								Ссылка.ДатаОкончания = Читалка.GetDateTime(9);
								Ссылка.Ответственный = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.Описание = Читалка.GetString(11);
							}
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
		
		public static СправочникиВыборка.Проекты Выбрать()
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
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1655 [ДатаНачала]
					,_Fld1656 [ДатаОкончания]
					,_Fld1657RRef [Ответственный]
					,_Fld1658 [Описание]
					From _Reference129(NOLOCK)  Where _Folder = 0x01 ";
					var Выборка = new V82.СправочникиВыборка.Проекты();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Проекты();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.Проекты.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ДатаНачала = Читалка.GetDateTime(8);
								Ссылка.ДатаОкончания = Читалка.GetDateTime(9);
								Ссылка.Ответственный = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.Описание = Читалка.GetString(11);
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.Проекты ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1655 [ДатаНачала]
					,_Fld1656 [ДатаОкончания]
					,_Fld1657RRef [Ответственный]
					,_Fld1658 [Описание]
					From _Reference129(NOLOCK)
					Where _IDRRef between @Мин and @Макс  -- and _Folder = 0x01 
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.Проекты();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Проекты();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.Проекты.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ДатаНачала = Читалка.GetDateTime(8);
								Ссылка.ДатаОкончания = Читалка.GetDateTime(9);
								Ссылка.Ответственный = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.Описание = Читалка.GetString(11);
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.Проекты ВыбратьПоКоду(int Первые,string Мин,string Макс)
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
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1655 [ДатаНачала]
					,_Fld1656 [ДатаОкончания]
					,_Fld1657RRef [Ответственный]
					,_Fld1658 [Описание]
					From _Reference129(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.Проекты();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Проекты();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.Проекты.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ДатаНачала = Читалка.GetDateTime(8);
								Ссылка.ДатаОкончания = Читалка.GetDateTime(9);
								Ссылка.Ответственный = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.Описание = Читалка.GetString(11);
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.Проекты ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1655 [ДатаНачала]
					,_Fld1656 [ДатаОкончания]
					,_Fld1657RRef [Ответственный]
					,_Fld1658 [Описание]
					From _Reference129(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.Проекты();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Проекты();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.Проекты.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ДатаНачала = Читалка.GetDateTime(8);
								Ссылка.ДатаОкончания = Читалка.GetDateTime(9);
								Ссылка.Ответственный = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.Описание = Читалка.GetString(11);
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.Проекты СтраницаПоСсылке(int Размер,int Номер)
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
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1655 [ДатаНачала]
					,_Fld1656 [ДатаОкончания]
					,_Fld1657RRef [Ответственный]
					,_Fld1658 [Описание]
					From _Reference129(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.Проекты();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Проекты();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.Проекты.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ДатаНачала = Читалка.GetDateTime(8);
								Ссылка.ДатаОкончания = Читалка.GetDateTime(9);
								Ссылка.Ответственный = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.Описание = Читалка.GetString(11);
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.Проекты СтраницаПоКоду(int Размер,int Номер)
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
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1655 [ДатаНачала]
					,_Fld1656 [ДатаОкончания]
					,_Fld1657RRef [Ответственный]
					,_Fld1658 [Описание]
					From _Reference129(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.Проекты();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Проекты();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.Проекты.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ДатаНачала = Читалка.GetDateTime(8);
								Ссылка.ДатаОкончания = Читалка.GetDateTime(9);
								Ссылка.Ответственный = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.Описание = Читалка.GetString(11);
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.Проекты СтраницаПоНаименованию(int Размер,int Номер)
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
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1655 [ДатаНачала]
					,_Fld1656 [ДатаОкончания]
					,_Fld1657RRef [Ответственный]
					,_Fld1658 [Описание]
					From _Reference129(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.Проекты();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Проекты();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.Проекты.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ДатаНачала = Читалка.GetDateTime(8);
								Ссылка.ДатаОкончания = Читалка.GetDateTime(9);
								Ссылка.Ответственный = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.Описание = Читалка.GetString(11);
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.Проекты СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.Проекты();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.Описание = "";
			Объект.Ответственный = new V82.СправочникиСсылка.Пользователи();
			return Объект;
		}
		
		public static V82.СправочникиОбъект.Проекты СоздатьГруппу()
		{
			var Объект = new V82.СправочникиОбъект.Проекты();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = true;
			Объект.Описание = "";
			Объект.Ответственный = new V82.СправочникиСсылка.Пользователи();
			return Объект;
		}
		
		public static СправочникиВыборка.Проекты ИерархияВыбратьПоСсылке(Guid Родитель,int Режим,int Первые,Guid Мин,Guid Макс)
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
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1655 [ДатаНачала]
					,_Fld1656 [ДатаОкончания]
					,_Fld1657RRef [Ответственный]
					,_Fld1658 [Описание]
					From _Reference129(NOLOCK)
					Where _IDRRef between @Мин and @Макс  -- and _Folder = 0x01 
					AND _ParentIDRRef = @Родитель
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Родитель", Родитель);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.Проекты();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Проекты();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.Проекты.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ДатаНачала = Читалка.GetDateTime(8);
								Ссылка.ДатаОкончания = Читалка.GetDateTime(9);
								Ссылка.Ответственный = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.Описание = Читалка.GetString(11);
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.Проекты ИерархияСтраницаПоСсылке(Guid Родитель,int Режим,int Размер,int Номер)
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
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1655 [ДатаНачала]
					,_Fld1656 [ДатаОкончания]
					,_Fld1657RRef [Ответственный]
					,_Fld1658 [Описание]
					From _Reference129(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.Проекты();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Проекты();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.Проекты.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ДатаНачала = Читалка.GetDateTime(8);
								Ссылка.ДатаОкончания = Читалка.GetDateTime(9);
								Ссылка.Ответственный = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.Описание = Читалка.GetString(11);
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
	}
}