﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ПроверкаЛегальностиПолученияОбновленияКлиент
	{
		// Запрашивает у пользователя диалог с подтверждением легальности полученного
		// обновления и завершает работу системы если обновление получено не легально
		// (см. параметр ЗавершатьРаботуСистемы).
		//
		// Параметры
		//  ЗавершатьРаботуСистемы - Булево - завершать работу системы, если пользователь
		//					указал что обновление получено не легально
		//
		// Возвращаемое значение:
		//   Булево   - Истина, если проверка завершилась успешно (пользователь
		//				подтвердил, что обновление получено легально)
		//

		public object ПроверитьЛегальностьПолученияОбновления(/*знач ЗавершатьРаботуСистемы = Ложь*/)
		{
			if(true/*СтандартныеПодсистемыКлиентПовтИсп.ПараметрыРаботыКлиента().ЭтоБазоваяВерсияКонфигурации*/)
			{
			}
			/*Результат = ОткрытьФормуМодально("Обработка.ЛегальностьПолученияОбновлений.Форма",
							Новый Структура("ПоказыватьПредупреждениеОПерезапуске,ПринудительныйЗапуск", 
											?(ЗавершатьРаботуСистемы, Истина, Ложь),
											Истина) );*/
			if(true/*Результат <> Истина*/)
			{
				if(true/*ЗавершатьРаботуСистемы*/)
				{
					//ПропуститьПредупреждениеПередЗавершениемРаботыСистемы = Истина;
					//ЗавершитьРаботуСистемы(Ложь);
				}
			}
			return null;
		}
		// Процедура для проверки легальности получения обновления.
		// Должна вызываться перед обновлением информационной базы.
		//

		public object ПодтвердитьЛегальностьПолученияОбновления(/**/)
		{
			//ПараметрыРаботыКлиента = СтандартныеПодсистемыКлиентПовтИсп.ПараметрыРаботыКлиента();
			if(true/*ПараметрыРаботыКлиента.ПервыйЗапуск
	 ИЛИ НЕ ПараметрыРаботыКлиента.НеобходимоОбновлениеИнформационнойБазы
	 ИЛИ НЕ ПараметрыРаботыКлиента.ЭтоГлавныйУзел*/)
			{
			}
			return null;
		}
	}
}

