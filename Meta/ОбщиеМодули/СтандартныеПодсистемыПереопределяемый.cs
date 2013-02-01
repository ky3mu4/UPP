﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class СтандартныеПодсистемыПереопределяемый
	{
		/////////////////////////////////////////////////////////////////////////////////
		// БазоваяФункциональность
		//
		// Возвращает список процедур-обработчиков обновления библиотеки.
		//
		// Здесь в алфавитном порядке размещаются только процедуры-обработчики обновления
		// библиотечных подсистем, которые используются в данной конфигурации.
		// Процедуры-обработчики обновления самой конфигурации следует размещать в функции
		// ОбработчикиОбновления общего модуля ОбновлениеИнформационнойБазыПереопределяемый.
		//
		// Возвращаемое значение:
		//   ТаблицаЗначений - описание полей структуры см. в функции
		//               ОбновлениеИнформационнойБазы.НоваяТаблицаОбработчиковОбновления()
		//

		public object ОбработчикиОбновленияСтандартныхПодсистем(/**/)
		{
			//Обработчики = ОбновлениеИнформационнойБазы.НоваяТаблицаОбработчиковОбновления();
			/*// Подключаются процедуры-обработчики обновления библиотеки
*/
			/*// БазоваяФункциональность
*/
			//СтандартныеПодсистемыСервер.ЗарегистрироватьОбработчикиОбновления(Обработчики);
			/*// Конец БазоваяФункциональность
*/
			/*// ОбновлениеКонфигурации
*/
			//ОбновлениеКонфигурации.ЗарегистрироватьОбработчикиОбновления(Обработчики);
			/*// Конец ОбновлениеКонфигурации
*/
			/*// ПолучениеФайловИзИнтернета
*/
			//ПолучениеФайловИзИнтернета.ЗарегистрироватьОбработчикиОбновления(Обработчики);
			/*// Конец ПолучениеФайловИзИнтернета
*/
			return null;
		}
		// Возвращает признак, является ли конфигурация базовой.
		//
		// Пример реализации:
		//  Если конфигурации выпускаются парами, то в имени базовой версии
		//  может включаться дополнительное слово "Базовая". Тогда логика
		//  определения базовой версии выглядит таким образом:
		//
		//	Возврат Найти(ВРег(Метаданные.Имя), "БАЗОВАЯ") > 0;
		//
		// Возвращаемое значение:
		//   Булево   - Истина, если конфигурация - базовая.
		//

		public object ЭтоБазоваяВерсияКонфигурации(/**/)
		{
			return null;
		}
		// Возвращает соответствие имен параметров сеанса и обработчиков для их инициализации.
		//

		public object ОбработчикиИнициализацииПараметровСеансаСтандартныхПодсистем(/**/)
		{
			/*// Для задания обработчиков параметров сеанса следует использовать шаблон:
*/
			/*// Обработчики.Вставить("<ИмяПараметраСеанса>|<НачалоИмениПараметраСеанса*>", "Обработчик");
*/
			/*//
*/
			/*// Примечание. Символ '*'используется в конце имени параметра сеанса и обозначает,
*/
			/*//             что один обработчик будет вызван для инициализации всех параметров сеанса
*/
			/*//             с именем, начинающимся на слово НачалоИмениПараметраСеанса
*/
			/*//
*/
			//Обработчики = Новый Соответствие;
			/*// ОценкаПроизводительности
*/
			//Обработчики.Вставить("ТекущийЗамерВремени", "ОценкаПроизводительностиВызовСервера.УстановкаПараметровСеанса");
			/*// Конец ОценкаПроизводительности
*/
			return null;
		}
		// Возвращает список имен объектов метаданных, данные которых могут содержать ссылки на различные объекты метаданных,
		// но при этом эти ссылки не должны учитываться в бизнес-логике приложения.
		//
		// Возвращаемое значение:
		//  Массив       - массив строк, например, "РегистрСведений.ВерсииОбъектов".
		//

		public object ИсключенияПоискаСсылок(/**/)
		{
			//Массив = Новый Массив;
			/*// ВерсионированиеОбъектов
*/
			//Массив.Добавить(Метаданные.РегистрыСведений.ВерсииОбъектов.ПолноеИмя());
			/*// Конец ВерсионированиеОбъектов
*/
			return null;
		}
		// Устанавливает текстовое описание предмета
		//
		// Параметры
		//  СсылкаНаПредмет  – ЛюбаяСсылка – объект ссылочного типа.
		//  Представление	 - Строка - сюда необходимо поместить текстовое описание.

		public void УстановитьПредставлениеПредмета(/*СсылкаНаПредмет, Представление*/)
		{
		}
		// Переопределяет массив реквизитов объекта, относительно которых разрешается устанавливать время напоминания.
		// Например, можно скрыть те реквизиты с датами, которые являются служебными или не имеют смысла для
		// установки напоминаний: дата документа или задачи и прочие.
		//
		// Параметры
		//  Источник	 - Любая ссылка - Ссылка на объект, для которого формируется массив реквизитов с датами
		//  МассивРеквизитов - Массив - Массив имён реквизитов (из метаданных), содержащих даты
		//

		public void ПриЗаполненииСпискаРеквизитовИсточникаСДатамиДляНапоминания(/*Источник, МассивРеквизитов*/)
		{
		}
	}
}

