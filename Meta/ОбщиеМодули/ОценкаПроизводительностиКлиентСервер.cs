﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ОценкаПроизводительностиКлиентСервер
	{
		// Начать замер времени выполнения ключевой операции
		//
		// Параметры:
		//  КодКлючевойОперации - Строка, код элемента справочника "КлючевыеОперации"
		//
		// Возвращаемое значение:
		//  Число - время начала замера
		//

		public object НачатьЗамерВремени(/*КлючеваяОперация*/)
		{
			/*#Если Клиент Тогда
		ВызовСКлиента = Истина;*/
			//ПодключитьОбработчикОжидания("ЗакончитьЗамерВремениАвто", 0.1, Истина);
			/*#Иначе
		ВызовСКлиента = Ложь;*/
			/*#КонецЕсли
	
	ВремяНачала = ОценкаПроизводительностиВызовСервера.ЗафиксироватьВремяНачала(КлючеваяОперация, ВызовСКлиента);*/
			return null;
		}
		// Закончить замер времени выполнения ключевой операции
		//
		// Возвращаемое значение:
		//  Число - время окончания замера
		//

		public object ЗакончитьЗамерВремени(/*КлючеваяОперация = Неопределено*/)
		{
			return null;
		}
	}
}

