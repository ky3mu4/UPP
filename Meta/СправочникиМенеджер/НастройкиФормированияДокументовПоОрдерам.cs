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
	public partial class НастройкиФормированияДокументовПоОрдерам:СправочникМенеджер
	{


		public static СправочникиВыборка.НастройкиФормированияДокументовПоОрдерам Выбрать()
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
					,_Description [Наименование],_Fld2882 [ФормироватьДокументыАвтоматически],_Fld2883 [РегламентноеЗадание],_Fld2884 [НастройкиКомпоновщика],_Fld2885 [Комментарий],_Fld2886RRef [ПериодДетализации],_Fld2887 [ОтражатьВУправленческомУчете],_Fld2888 [ОтражатьВБухгалтерскомУчете],_Fld2889 [ОтражатьВНалоговомУчете],_Fld2890 [ГраницаОбработки],_Fld2891RRef [ШаблонРегулярногоДокумента],_Fld2892 [ВидРегулярногоДокумента],_Fld2893 [НеОбрабатыватьВсеДокументы],_Fld2894 [Задержка]
		 From _Reference160(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НастройкиФормированияДокументовПоОрдерам();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиФормированияДокументовПоОрдерам();
		
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Наименование = Читалка.GetString(4);
							Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(5))[0]==1?true:false;
							Ссылка.РегламентноеЗадание = Читалка.GetString(6);
							Ссылка.Комментарий = Читалка.GetString(8);
							Ссылка.ПериодДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(10))[0]==1?true:false;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(11))[0]==1?true:false;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(12))[0]==1?true:false;
							Ссылка.ГраницаОбработки = Читалка.GetDateTime(13);
							Ссылка.ВидРегулярногоДокумента = Читалка.GetString(15);
							Ссылка.НеОбрабатыватьВсеДокументы = ((byte[])Читалка.GetValue(16))[0]==1?true:false;
							Ссылка.Задержка = Читалка.GetDecimal(17);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}

		public static V82.СправочникиОбъект.НастройкиФормированияДокументовПоОрдерам СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.НастройкиФормированияДокументовПоОрдерам();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.РегламентноеЗадание = "";
			Объект.Комментарий = "";
			Объект.ВидРегулярногоДокумента = "";
			Объект.ПериодДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка;
			return Объект;
		}
	}
}
