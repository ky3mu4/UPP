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
	///(Общ)
	///</summary>
	public partial class Склады:СправочникМенеджер
	{
		
		public static СправочникиСсылка.Склады НайтиПоКоду(string Код)
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
					,_Fld3427 [Комментарий]
					,_Fld3428RRef [ТипЦенРозничнойТорговли]
					,_Fld3429RRef [Подразделение]
					,_Fld3430RRef [ВидСклада]
					,_Fld3431 [НомерСекции]
					,_Fld3432 [РасчетРозничныхЦенПоТорговойНаценке]
					From _Reference229(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Склады();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Комментарий = Читалка.GetString(6);
							//Ссылка.ТипЦенРозничнойТорговли = new V82.СправочникиСсылка.ТипыЦенНоменклатуры((byte[])Читалка.GetValue(7));
							//Ссылка.Подразделение = new V82.СправочникиСсылка.Подразделения((byte[])Читалка.GetValue(8));
							Ссылка.ВидСклада = V82.Перечисления/*Ссылка*/.ВидыСкладов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.НомерСекции = Читалка.GetDecimal(10);
							Ссылка.РасчетРозничныхЦенПоТорговойНаценке = ((byte[])Читалка.GetValue(11))[0]==1?true:false;
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
		
		public static СправочникиВыборка.Склады Выбрать()
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
					,_Fld3427 [Комментарий]
					,_Fld3428RRef [ТипЦенРозничнойТорговли]
					,_Fld3429RRef [Подразделение]
					,_Fld3430RRef [ВидСклада]
					,_Fld3431 [НомерСекции]
					,_Fld3432 [РасчетРозничныхЦенПоТорговойНаценке]
					From _Reference229(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.Склады();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Склады();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Комментарий = Читалка.GetString(6);
							//Ссылка.ТипЦенРозничнойТорговли = new V82.СправочникиСсылка.ТипыЦенНоменклатуры((byte[])Читалка.GetValue(7));
							//Ссылка.Подразделение = new V82.СправочникиСсылка.Подразделения((byte[])Читалка.GetValue(8));
							Ссылка.ВидСклада = V82.Перечисления/*Ссылка*/.ВидыСкладов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.НомерСекции = Читалка.GetDecimal(10);
							Ссылка.РасчетРозничныхЦенПоТорговойНаценке = ((byte[])Читалка.GetValue(11))[0]==1?true:false;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.Склады ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld3427 [Комментарий]
					,_Fld3428RRef [ТипЦенРозничнойТорговли]
					,_Fld3429RRef [Подразделение]
					,_Fld3430RRef [ВидСклада]
					,_Fld3431 [НомерСекции]
					,_Fld3432 [РасчетРозничныхЦенПоТорговойНаценке]
					From _Reference229(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.Склады();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Склады();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Комментарий = Читалка.GetString(6);
							//Ссылка.ТипЦенРозничнойТорговли = new V82.СправочникиСсылка.ТипыЦенНоменклатуры((byte[])Читалка.GetValue(7));
							//Ссылка.Подразделение = new V82.СправочникиСсылка.Подразделения((byte[])Читалка.GetValue(8));
							Ссылка.ВидСклада = V82.Перечисления/*Ссылка*/.ВидыСкладов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.НомерСекции = Читалка.GetDecimal(10);
							Ссылка.РасчетРозничныхЦенПоТорговойНаценке = ((byte[])Читалка.GetValue(11))[0]==1?true:false;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.Склады ВыбратьПоКоду(int Первые,string Мин,string Макс)
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
					,_Fld3427 [Комментарий]
					,_Fld3428RRef [ТипЦенРозничнойТорговли]
					,_Fld3429RRef [Подразделение]
					,_Fld3430RRef [ВидСклада]
					,_Fld3431 [НомерСекции]
					,_Fld3432 [РасчетРозничныхЦенПоТорговойНаценке]
					From _Reference229(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.Склады();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Склады();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Комментарий = Читалка.GetString(6);
							//Ссылка.ТипЦенРозничнойТорговли = new V82.СправочникиСсылка.ТипыЦенНоменклатуры((byte[])Читалка.GetValue(7));
							//Ссылка.Подразделение = new V82.СправочникиСсылка.Подразделения((byte[])Читалка.GetValue(8));
							Ссылка.ВидСклада = V82.Перечисления/*Ссылка*/.ВидыСкладов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.НомерСекции = Читалка.GetDecimal(10);
							Ссылка.РасчетРозничныхЦенПоТорговойНаценке = ((byte[])Читалка.GetValue(11))[0]==1?true:false;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.Склады ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_Fld3427 [Комментарий]
					,_Fld3428RRef [ТипЦенРозничнойТорговли]
					,_Fld3429RRef [Подразделение]
					,_Fld3430RRef [ВидСклада]
					,_Fld3431 [НомерСекции]
					,_Fld3432 [РасчетРозничныхЦенПоТорговойНаценке]
					From _Reference229(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.Склады();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Склады();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Комментарий = Читалка.GetString(6);
							//Ссылка.ТипЦенРозничнойТорговли = new V82.СправочникиСсылка.ТипыЦенНоменклатуры((byte[])Читалка.GetValue(7));
							//Ссылка.Подразделение = new V82.СправочникиСсылка.Подразделения((byte[])Читалка.GetValue(8));
							Ссылка.ВидСклада = V82.Перечисления/*Ссылка*/.ВидыСкладов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.НомерСекции = Читалка.GetDecimal(10);
							Ссылка.РасчетРозничныхЦенПоТорговойНаценке = ((byte[])Читалка.GetValue(11))[0]==1?true:false;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.Склады СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld3427 [Комментарий]
					,_Fld3428RRef [ТипЦенРозничнойТорговли]
					,_Fld3429RRef [Подразделение]
					,_Fld3430RRef [ВидСклада]
					,_Fld3431 [НомерСекции]
					,_Fld3432 [РасчетРозничныхЦенПоТорговойНаценке]
					From _Reference229(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.Склады();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Склады();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Комментарий = Читалка.GetString(6);
							//Ссылка.ТипЦенРозничнойТорговли = new V82.СправочникиСсылка.ТипыЦенНоменклатуры((byte[])Читалка.GetValue(7));
							//Ссылка.Подразделение = new V82.СправочникиСсылка.Подразделения((byte[])Читалка.GetValue(8));
							Ссылка.ВидСклада = V82.Перечисления/*Ссылка*/.ВидыСкладов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.НомерСекции = Читалка.GetDecimal(10);
							Ссылка.РасчетРозничныхЦенПоТорговойНаценке = ((byte[])Читалка.GetValue(11))[0]==1?true:false;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.Склады СтраницаПоКоду(int Размер,int Номер)
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
					,_Fld3427 [Комментарий]
					,_Fld3428RRef [ТипЦенРозничнойТорговли]
					,_Fld3429RRef [Подразделение]
					,_Fld3430RRef [ВидСклада]
					,_Fld3431 [НомерСекции]
					,_Fld3432 [РасчетРозничныхЦенПоТорговойНаценке]
					From _Reference229(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.Склады();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Склады();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Комментарий = Читалка.GetString(6);
							//Ссылка.ТипЦенРозничнойТорговли = new V82.СправочникиСсылка.ТипыЦенНоменклатуры((byte[])Читалка.GetValue(7));
							//Ссылка.Подразделение = new V82.СправочникиСсылка.Подразделения((byte[])Читалка.GetValue(8));
							Ссылка.ВидСклада = V82.Перечисления/*Ссылка*/.ВидыСкладов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.НомерСекции = Читалка.GetDecimal(10);
							Ссылка.РасчетРозничныхЦенПоТорговойНаценке = ((byte[])Читалка.GetValue(11))[0]==1?true:false;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.Склады СтраницаПоНаименованию(int Размер,int Номер)
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
					,_Fld3427 [Комментарий]
					,_Fld3428RRef [ТипЦенРозничнойТорговли]
					,_Fld3429RRef [Подразделение]
					,_Fld3430RRef [ВидСклада]
					,_Fld3431 [НомерСекции]
					,_Fld3432 [РасчетРозничныхЦенПоТорговойНаценке]
					From _Reference229(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.Склады();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Склады();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Комментарий = Читалка.GetString(6);
							//Ссылка.ТипЦенРозничнойТорговли = new V82.СправочникиСсылка.ТипыЦенНоменклатуры((byte[])Читалка.GetValue(7));
							//Ссылка.Подразделение = new V82.СправочникиСсылка.Подразделения((byte[])Читалка.GetValue(8));
							Ссылка.ВидСклада = V82.Перечисления/*Ссылка*/.ВидыСкладов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.НомерСекции = Читалка.GetDecimal(10);
							Ссылка.РасчетРозничныхЦенПоТорговойНаценке = ((byte[])Читалка.GetValue(11))[0]==1?true:false;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.Склады СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.Склады();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.Комментарий = "";
			Объект.ТипЦенРозничнойТорговли = new V82.СправочникиСсылка.ТипыЦенНоменклатуры();
			Объект.Подразделение = new V82.СправочникиСсылка.Подразделения();
			Объект.ВидСклада = V82.Перечисления/*Ссылка*/.ВидыСкладов.ПустаяСсылка;
			return Объект;
		}
		
		public static V82.СправочникиОбъект.Склады СоздатьГруппу()
		{
			var Объект = new V82.СправочникиОбъект.Склады();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = true;
			Объект.Комментарий = "";
			Объект.ТипЦенРозничнойТорговли = new V82.СправочникиСсылка.ТипыЦенНоменклатуры();
			Объект.Подразделение = new V82.СправочникиСсылка.Подразделения();
			Объект.ВидСклада = V82.Перечисления/*Ссылка*/.ВидыСкладов.ПустаяСсылка;
			return Объект;
		}
	}
}