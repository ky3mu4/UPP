﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ОбменСведениямиОПособияхСФССПолныеПрава
	{

		public object ДанныеСотрудникаДляЗаявленияНаВыплатуПособия(/*Организация, Сотрудник, Дата, Режим = "ДляДокумента"*/)
		{
			//Запрос = Новый Запрос;
			/*Запрос.Текст = 
	"ВЫБРАТЬ
	|	СотрудникиОрганизаций.Физлицо,
	|	СотрудникиОрганизаций.Ссылка,
	|	СотрудникиОрганизаций.ВидЗанятости
	|ПОМЕСТИТЬ ВТФизлицо
	|ИЗ
	|	Справочник.СотрудникиОрганизаций КАК СотрудникиОрганизаций
	|ГДЕ
	|	СотрудникиОрганизаций.Ссылка В(&Ссылка)
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|ВЫБРАТЬ
	|	НачислениеПоБольничномуЛисту.Ссылка,
	|	НачислениеПоБольничномуЛисту.Дата,
	|	НачислениеПоБольничномуЛисту.ПеречислятьПособиеПочтовымПереводом,
	|	НачислениеПоБольничномуЛисту.Банк,
	|	НачислениеПоБольничномуЛисту.НаименованиеБанка,
	|	НачислениеПоБольничномуЛисту.БИКБанка,
	|	НачислениеПоБольничномуЛисту.КоррСчетБанка,
	|	НачислениеПоБольничномуЛисту.НомерЛицевогоСчета,
	|	НачислениеПоБольничномуЛисту.АдресПочтовый,
	|	НачислениеПоБольничномуЛисту.НаименованиеДокументаНаПроживание,
	|	НачислениеПоБольничномуЛисту.СерияДокументаНаПроживание,
	|	НачислениеПоБольничномуЛисту.НомерДокументаНаПроживание,
	|	НачислениеПоБольничномуЛисту.ДатаВыдачиДокументаНаПроживание,
	|	НачислениеПоБольничномуЛисту.Телефон,
	|	НачислениеПоБольничномуЛисту.АдресРегистрации,
	|	НачислениеПоБольничномуЛисту.АдресПочтовыйКодПоКЛАДР,
	|	НачислениеПоБольничномуЛисту.АдресРегистрацииКодПоКЛАДР
	|ПОМЕСТИТЬ ВТДокументыПособий
	|ИЗ
	|	Документ.НачислениеПоБольничномуЛисту КАК НачислениеПоБольничномуЛисту
	|ГДЕ
	|	НачислениеПоБольничномуЛисту.Физлицо В
	|			(ВЫБРАТЬ
	|				Физлица.Физлицо
	|			ИЗ
	|				ВТФизлицо КАК Физлица)
	|	И НачислениеПоБольничномуЛисту.Организация = &Организация
	|	И (НачислениеПоБольничномуЛисту.ПричинаНетрудоспособности <> ЗНАЧЕНИЕ(Перечисление.ПричиныНетрудоспособности.ОбщееЗаболевание)
	|			ИЛИ ДОБАВИТЬКДАТЕ(НачислениеПоБольничномуЛисту.ДатаНачалаСобытия, ДЕНЬ, НачислениеПоБольничномуЛисту.ДнейОплатыРаботодателем) <= НачислениеПоБольничномуЛисту.ДатаОкончания)
	|	И НачислениеПоБольничномуЛисту.ПериодРегистрации >= &ДатаПередачиФССВыплатыПособий
	|
	|ОБЪЕДИНИТЬ ВСЕ
	|
	|ВЫБРАТЬ
	|	НачислениеОтпускаРаботникамОрганизаций.Ссылка,
	|	НачислениеОтпускаРаботникамОрганизаций.Дата,
	|	НачислениеОтпускаРаботникамОрганизаций.ПеречислятьПособиеПочтовымПереводом,
	|	НачислениеОтпускаРаботникамОрганизаций.Банк,
	|	НачислениеОтпускаРаботникамОрганизаций.НаименованиеБанка,
	|	НачислениеОтпускаРаботникамОрганизаций.БИКБанка,
	|	НачислениеОтпускаРаботникамОрганизаций.КоррСчетБанка,
	|	НачислениеОтпускаРаботникамОрганизаций.НомерЛицевогоСчета,
	|	НачислениеОтпускаРаботникамОрганизаций.АдресПочтовый,
	|	"""",
	|	"""",
	|	"""",
	|	ДАТАВРЕМЯ(1, 1, 1),
	|	НачислениеОтпускаРаботникамОрганизаций.Телефон,
	|	НачислениеОтпускаРаботникамОрганизаций.АдресРегистрации,
	|	"""",
	|	""""
	|ИЗ
	|	Документ.НачислениеОтпускаРаботникамОрганизаций КАК НачислениеОтпускаРаботникамОрганизаций
	|ГДЕ
	|	НачислениеОтпускаРаботникамОрганизаций.ВидРасчетаДополнительногоОтпуска.ВидПособияСоциальногоСтрахования = ЗНАЧЕНИЕ(Перечисление.ВидыПособийСоциальногоСтрахования.ДополнительныйОтпускПослеНесчастныхСлучаев)
	|	И НачислениеОтпускаРаботникамОрганизаций.Физлицо В
	|			(ВЫБРАТЬ
	|				Физлица.Физлицо
	|			ИЗ
	|				ВТФизлицо КАК Физлица)
	|	И НачислениеОтпускаРаботникамОрганизаций.Организация = &Организация
	|	И НачислениеОтпускаРаботникамОрганизаций.ПериодРегистрации >= &ДатаПередачиФССВыплатыПособий
	|
	|ОБЪЕДИНИТЬ ВСЕ
	|
	|ВЫБРАТЬ
	|	ОтпускПоУходуЗаРебенком.Ссылка,
	|	ОтпускПоУходуЗаРебенком.Дата,
	|	ОтпускПоУходуЗаРебенком.ПеречислятьПособиеПочтовымПереводом,
	|	ОтпускПоУходуЗаРебенком.Банк,
	|	ОтпускПоУходуЗаРебенком.НаименованиеБанка,
	|	ОтпускПоУходуЗаРебенком.БИКБанка,
	|	ОтпускПоУходуЗаРебенком.КоррСчетБанка,
	|	ОтпускПоУходуЗаРебенком.НомерЛицевогоСчета,
	|	ОтпускПоУходуЗаРебенком.АдресПочтовый,
	|	ОтпускПоУходуЗаРебенком.НаименованиеДокументаНаПроживание,
	|	ОтпускПоУходуЗаРебенком.СерияДокументаНаПроживание,
	|	ОтпускПоУходуЗаРебенком.НомерДокументаНаПроживание,
	|	ОтпускПоУходуЗаРебенком.ДатаВыдачиДокументаНаПроживание,
	|	ОтпускПоУходуЗаРебенком.Телефон,
	|	ОтпускПоУходуЗаРебенком.АдресРегистрации,
	|	ОтпускПоУходуЗаРебенком.АдресПочтовыйКодПоКЛАДР,
	|	""""
	|ИЗ
	|	Документ.ОтпускПоУходуЗаРебенком КАК ОтпускПоУходуЗаРебенком
	|ГДЕ
	|	ОтпускПоУходуЗаРебенком.Физлицо В
	|			(ВЫБРАТЬ
	|				Физлица.Физлицо
	|			ИЗ
	|				ВТФизлицо КАК Физлица)
	|	И ОтпускПоУходуЗаРебенком.Организация = &Организация
	|	И ОтпускПоУходуЗаРебенком.ВыплачиватьПособиеДоПолутораЛет
	|	И ОтпускПоУходуЗаРебенком.ДатаОкончанияПособияДоПолутораЛет >= &ДатаПередачиФССВыплатыПособий
	|
	|ОБЪЕДИНИТЬ ВСЕ
	|
	|ВЫБРАТЬ
	|	РеестрСведенийВФССОПособияхПоНетрудоспособностиРаботникиОрганизации.Ссылка,
	|	РеестрСведенийВФССОПособияхПоНетрудоспособностиРаботникиОрганизации.Ссылка.Дата,
	|	РеестрСведенийВФССОПособияхПоНетрудоспособностиРаботникиОрганизации.ПеречислятьПособиеПочтовымПереводом,
	|	РеестрСведенийВФССОПособияхПоНетрудоспособностиРаботникиОрганизации.Банк,
	|	РеестрСведенийВФССОПособияхПоНетрудоспособностиРаботникиОрганизации.НаименованиеБанка,
	|	РеестрСведенийВФССОПособияхПоНетрудоспособностиРаботникиОрганизации.БИКБанка,
	|	РеестрСведенийВФССОПособияхПоНетрудоспособностиРаботникиОрганизации.КоррСчетБанка,
	|	РеестрСведенийВФССОПособияхПоНетрудоспособностиРаботникиОрганизации.НомерЛицевогоСчета,
	|	РеестрСведенийВФССОПособияхПоНетрудоспособностиРаботникиОрганизации.АдресПочтовый,
	|	РеестрСведенийВФССОПособияхПоНетрудоспособностиРаботникиОрганизации.НаименованиеДокументаНаПроживание,
	|	РеестрСведенийВФССОПособияхПоНетрудоспособностиРаботникиОрганизации.СерияДокументаНаПроживание,
	|	РеестрСведенийВФССОПособияхПоНетрудоспособностиРаботникиОрганизации.НомерДокументаНаПроживание,
	|	РеестрСведенийВФССОПособияхПоНетрудоспособностиРаботникиОрганизации.ДатаВыдачиДокументаНаПроживание,
	|	"""",
	|	РеестрСведенийВФССОПособияхПоНетрудоспособностиРаботникиОрганизации.АдресРегистрации,
	|	РеестрСведенийВФССОПособияхПоНетрудоспособностиРаботникиОрганизации.АдресПочтовыйКодПоКЛАДР,
	|	РеестрСведенийВФССОПособияхПоНетрудоспособностиРаботникиОрганизации.АдресРегистрацииКодПоКЛАДР
	|ИЗ
	|	Документ.РеестрСведенийВФССОПособияхПоНетрудоспособности.РаботникиОрганизации КАК РеестрСведенийВФССОПособияхПоНетрудоспособностиРаботникиОрганизации
	|ГДЕ
	|	РеестрСведенийВФССОПособияхПоНетрудоспособностиРаботникиОрганизации.ФизЛицо В
	|			(ВЫБРАТЬ
	|				Физлица.Физлицо
	|			ИЗ
	|				ВТФизлицо КАК Физлица)
	|	И РеестрСведенийВФССОПособияхПоНетрудоспособностиРаботникиОрганизации.Ссылка.Организация = &Организация
	|
	|ОБЪЕДИНИТЬ ВСЕ
	|
	|ВЫБРАТЬ
	|	РеестрСведенийВФССОПособияхПриРожденииРебенкаРаботникиОрганизации.Ссылка,
	|	РеестрСведенийВФССОПособияхПриРожденииРебенкаРаботникиОрганизации.Ссылка.Дата,
	|	РеестрСведенийВФССОПособияхПриРожденииРебенкаРаботникиОрганизации.ПеречислятьПособиеПочтовымПереводом,
	|	РеестрСведенийВФССОПособияхПриРожденииРебенкаРаботникиОрганизации.Банк,
	|	РеестрСведенийВФССОПособияхПриРожденииРебенкаРаботникиОрганизации.НаименованиеБанка,
	|	РеестрСведенийВФССОПособияхПриРожденииРебенкаРаботникиОрганизации.БИКБанка,
	|	РеестрСведенийВФССОПособияхПриРожденииРебенкаРаботникиОрганизации.КоррСчетБанка,
	|	РеестрСведенийВФССОПособияхПриРожденииРебенкаРаботникиОрганизации.НомерЛицевогоСчета,
	|	РеестрСведенийВФССОПособияхПриРожденииРебенкаРаботникиОрганизации.АдресПочтовый,
	|	РеестрСведенийВФССОПособияхПриРожденииРебенкаРаботникиОрганизации.НаименованиеДокументаНаПроживание,
	|	РеестрСведенийВФССОПособияхПриРожденииРебенкаРаботникиОрганизации.СерияДокументаНаПроживание,
	|	РеестрСведенийВФССОПособияхПриРожденииРебенкаРаботникиОрганизации.НомерДокументаНаПроживание,
	|	РеестрСведенийВФССОПособияхПриРожденииРебенкаРаботникиОрганизации.ДатаВыдачиДокументаНаПроживание,
	|	РеестрСведенийВФССОПособияхПриРожденииРебенкаРаботникиОрганизации.Телефон,
	|	РеестрСведенийВФССОПособияхПриРожденииРебенкаРаботникиОрганизации.АдресРегистрации,
	|	РеестрСведенийВФССОПособияхПриРожденииРебенкаРаботникиОрганизации.АдресПочтовыйКодПоКЛАДР,
	|	""""
	|ИЗ
	|	Документ.РеестрСведенийВФССОПособияхПриРожденииРебенка.РаботникиОрганизации КАК РеестрСведенийВФССОПособияхПриРожденииРебенкаРаботникиОрганизации
	|ГДЕ
	|	РеестрСведенийВФССОПособияхПриРожденииРебенкаРаботникиОрганизации.ФизЛицо В
	|			(ВЫБРАТЬ
	|				Физлица.Физлицо
	|			ИЗ
	|				ВТФизлицо КАК Физлица)
	|	И РеестрСведенийВФССОПособияхПриРожденииРебенкаРаботникиОрганизации.Ссылка.Организация = &Организация
	|
	|ОБЪЕДИНИТЬ ВСЕ
	|
	|ВЫБРАТЬ
	|	РеестрСведенийВФССОЕжемесячныхПособияхПоУходуРаботникиОрганизации.Ссылка,
	|	РеестрСведенийВФССОЕжемесячныхПособияхПоУходуРаботникиОрганизации.Ссылка.Дата,
	|	РеестрСведенийВФССОЕжемесячныхПособияхПоУходуРаботникиОрганизации.ПеречислятьПособиеПочтовымПереводом,
	|	РеестрСведенийВФССОЕжемесячныхПособияхПоУходуРаботникиОрганизации.Банк,
	|	РеестрСведенийВФССОЕжемесячныхПособияхПоУходуРаботникиОрганизации.НаименованиеБанка,
	|	РеестрСведенийВФССОЕжемесячныхПособияхПоУходуРаботникиОрганизации.БИКБанка,
	|	РеестрСведенийВФССОЕжемесячныхПособияхПоУходуРаботникиОрганизации.КоррСчетБанка,
	|	РеестрСведенийВФССОЕжемесячныхПособияхПоУходуРаботникиОрганизации.НомерЛицевогоСчета,
	|	РеестрСведенийВФССОЕжемесячныхПособияхПоУходуРаботникиОрганизации.АдресПочтовый,
	|	РеестрСведенийВФССОЕжемесячныхПособияхПоУходуРаботникиОрганизации.НаименованиеДокументаНаПроживание,
	|	РеестрСведенийВФССОЕжемесячныхПособияхПоУходуРаботникиОрганизации.СерияДокументаНаПроживание,
	|	РеестрСведенийВФССОЕжемесячныхПособияхПоУходуРаботникиОрганизации.НомерДокументаНаПроживание,
	|	РеестрСведенийВФССОЕжемесячныхПособияхПоУходуРаботникиОрганизации.ДатаВыдачиДокументаНаПроживание,
	|	"""",
	|	РеестрСведенийВФССОЕжемесячныхПособияхПоУходуРаботникиОрганизации.АдресРегистрации,
	|	РеестрСведенийВФССОЕжемесячныхПособияхПоУходуРаботникиОрганизации.АдресПочтовыйКодПоКЛАДР,
	|	""""
	|ИЗ
	|	Документ.РеестрСведенийВФССОЕжемесячныхПособияхПоУходу.РаботникиОрганизации КАК РеестрСведенийВФССОЕжемесячныхПособияхПоУходуРаботникиОрганизации
	|ГДЕ
	|	РеестрСведенийВФССОЕжемесячныхПособияхПоУходуРаботникиОрганизации.ФизЛицо В
	|			(ВЫБРАТЬ
	|				Физлица.Физлицо
	|			ИЗ
	|				ВТФизлицо КАК Физлица)
	|	И РеестрСведенийВФССОЕжемесячныхПособияхПоУходуРаботникиОрганизации.Ссылка.Организация = &Организация
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|ВЫБРАТЬ ПЕРВЫЕ 1
	|	ДокументыПособий.НомерЛицевогоСчета КАК НомерЛицевогоСчета,
	|	ДокументыПособий.БИКБанка КАК БИКБанка,
	|	ДокументыПособий.КоррСчетБанка,
	|	ДокументыПособий.НаименованиеБанка КАК НаименованиеБанка,
	|	ДокументыПособий.АдресПочтовый КАК АдресПочтовый,
	|	ДокументыПособий.ПеречислятьПособиеПочтовымПереводом КАК ПеречислятьПособиеПочтовымПереводом,
	|	ДокументыПособий.Банк КАК Банк,
	|	ДокументыПособий.Телефон,
	|	ДокументыПособий.АдресРегистрации,
	|	ДокументыПособий.АдресПочтовыйКодПоКЛАДР,
	|	ДокументыПособий.АдресРегистрацииКодПоКЛАДР
	|ПОМЕСТИТЬ ВТДанныеПоследнегоДокумента
	|ИЗ
	|	(ВЫБРАТЬ
	|		МАКСИМУМ(ДокументыПособий.Ссылка) КАК Ссылка
	|	ИЗ
	|		(ВЫБРАТЬ
	|			МАКСИМУМ(ДокументыПособий.Дата) КАК Дата
	|		ИЗ
	|			ВТДокументыПособий КАК ДокументыПособий
	|		ГДЕ
	|			ДокументыПособий.Дата < &Дата) КАК ДатаДокумента
	|			ВНУТРЕННЕЕ СОЕДИНЕНИЕ ВТДокументыПособий КАК ДокументыПособий
	|			ПО ДатаДокумента.Дата = ДокументыПособий.Дата) КАК ДокументСДанными
	|		ЛЕВОЕ СОЕДИНЕНИЕ ВТДокументыПособий КАК ДокументыПособий
	|		ПО ДокументСДанными.Ссылка = ДокументыПособий.Ссылка
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|ВЫБРАТЬ ПЕРВЫЕ 1
	|	ДокументыПособий.НаименованиеДокументаНаПроживание,
	|	ДокументыПособий.СерияДокументаНаПроживание,
	|	ДокументыПособий.НомерДокументаНаПроживание,
	|	ДокументыПособий.ДатаВыдачиДокументаНаПроживание
	|ПОМЕСТИТЬ ВТДанныеПоследнегоДокументаОПроживании
	|ИЗ
	|	(ВЫБРАТЬ
	|		МАКСИМУМ(ДокументыПособий.Ссылка) КАК Ссылка
	|	ИЗ
	|		(ВЫБРАТЬ
	|			МАКСИМУМ(ДокументыПособий.Дата) КАК Дата
	|		ИЗ
	|			ВТДокументыПособий КАК ДокументыПособий
	|		ГДЕ
	|			ДокументыПособий.Дата < &Дата
	|			И ДокументыПособий.ДатаВыдачиДокументаНаПроживание <> ДАТАВРЕМЯ(1, 1, 1)) КАК ДатаДокумента
	|			ВНУТРЕННЕЕ СОЕДИНЕНИЕ ВТДокументыПособий КАК ДокументыПособий
	|			ПО ДатаДокумента.Дата = ДокументыПособий.Дата) КАК ДокументСДанными
	|		ЛЕВОЕ СОЕДИНЕНИЕ ВТДокументыПособий КАК ДокументыПособий
	|		ПО ДокументСДанными.Ссылка = ДокументыПособий.Ссылка
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|ВЫБРАТЬ ПЕРВЫЕ 1
	|	ЛицевыеСчетаРаботниковОрганизации.НомерЛицевогоСчета,
	|	ЛицевыеСчетаРаботниковОрганизации.Банк.ОсновнойБанковскийСчет.Банк КАК Банк,
	|	ЛицевыеСчетаРаботниковОрганизации.Банк.ОсновнойБанковскийСчет.Банк.Наименование КАК Наименование,
	|	ЛицевыеСчетаРаботниковОрганизации.Банк.ОсновнойБанковскийСчет.Банк.Код КАК БИК,
	|	ЛицевыеСчетаРаботниковОрганизации.Банк.ОсновнойБанковскийСчет.Банк.КоррСчет КАК КоррСчет,
	|	ЛицевыеСчетаРаботниковОрганизации.Банк КАК БанкИзмерение
	|ПОМЕСТИТЬ ВТДанныеЗарплатногоСчета
	|ИЗ
	|	РегистрСведений.ЛицевыеСчетаРаботниковОрганизации КАК ЛицевыеСчетаРаботниковОрганизации
	|ГДЕ
	|	ЛицевыеСчетаРаботниковОрганизации.Организация = &Организация
	|	И ЛицевыеСчетаРаботниковОрганизации.ФизЛицо В
	|			(ВЫБРАТЬ
	|				Физлица.Физлицо
	|			ИЗ
	|				ВТФизлицо КАК Физлица)
	|
	|УПОРЯДОЧИТЬ ПО
	|	ЛицевыеСчетаРаботниковОрганизации.Банк
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|ВЫБРАТЬ
	|	КонтактнаяИнформация.Объект,
	|	КонтактнаяИнформация.Тип,
	|	КонтактнаяИнформация.Вид,
	|	КонтактнаяИнформация.Представление,
	|	КонтактнаяИнформация.Поле1,
	|	КонтактнаяИнформация.Поле2,
	|	КонтактнаяИнформация.Поле3,
	|	КонтактнаяИнформация.Поле4,
	|	КонтактнаяИнформация.Поле5,
	|	КонтактнаяИнформация.Поле6,
	|	КонтактнаяИнформация.Поле7,
	|	КонтактнаяИнформация.Поле8,
	|	КонтактнаяИнформация.Поле9,
	|	КонтактнаяИнформация.Поле10,
	|	КонтактнаяИнформация.Комментарий,
	|	КонтактнаяИнформация.ЗначениеПоУмолчанию,
	|	КонтактнаяИнформация.ТипДома,
	|	КонтактнаяИнформация.ТипКорпуса,
	|	КонтактнаяИнформация.ТипКвартиры
	|ПОМЕСТИТЬ ВТКонтактнаяИнформация
	|ИЗ
	|	РегистрСведений.КонтактнаяИнформация КАК КонтактнаяИнформация
	|ГДЕ
	|	КонтактнаяИнформация.Объект В
	|			(ВЫБРАТЬ
	|				Физлица.Физлицо
	|			ИЗ
	|				ВТФизлицо КАК Физлица)
	|	И КонтактнаяИнформация.Тип В (ЗНАЧЕНИЕ(Перечисление.ТипыКонтактнойИнформации.Адрес), ЗНАЧЕНИЕ(Перечисление.ТипыКонтактнойИнформации.Телефон))
	|	И КонтактнаяИнформация.Вид В (ЗНАЧЕНИЕ(Справочник.ВидыКонтактнойИнформации.ФактАдресФизЛица), ЗНАЧЕНИЕ(Справочник.ВидыКонтактнойИнформации.ЮрАдресФизЛица), ЗНАЧЕНИЕ(Справочник.ВидыКонтактнойИнформации.ТелефонФизЛица))
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|ВЫБРАТЬ
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Сотрудник,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.ВидРасчета,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Показатель1,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Валюта1,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.ТарифныйРазряд1,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Показатель2,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Валюта2,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.ТарифныйРазряд2,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Показатель3,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Валюта3,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.ТарифныйРазряд3,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Показатель4,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Валюта4,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.ТарифныйРазряд4,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Показатель5,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Валюта5,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.ТарифныйРазряд5,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Показатель6,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Валюта6,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.ТарифныйРазряд6,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Действие,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.ПериодЗавершения,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.ВидРасчетаЗавершения,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Показатель1Завершения,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Показатель2Завершения,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Показатель3Завершения,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Показатель4Завершения,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Показатель5Завершения,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Показатель6Завершения,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Валюта1Завершения,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Валюта2Завершения,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Валюта3Завершения,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Валюта4Завершения,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Валюта5Завершения,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Валюта6Завершения,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.ТарифныйРазряд1Завершения,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.ТарифныйРазряд2Завершения,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.ТарифныйРазряд3Завершения,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.ТарифныйРазряд4Завершения,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.ТарифныйРазряд5Завершения,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.ТарифныйРазряд6Завершения,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.ДействиеЗавершения
	|ПОМЕСТИТЬ ВТДанныеРегистра
	|ИЗ
	|	РегистрСведений.ПлановыеНачисленияРаботниковОрганизаций.СрезПоследних(
	|			&Дата,
	|			ВидРасчетаИзмерение = НЕОПРЕДЕЛЕНО
	|				И Сотрудник В
	|					(ВЫБРАТЬ
	|						Физлица.Ссылка
	|					ИЗ
	|						ВТФизлицо КАК Физлица)) КАК ПлановыеНачисленияРаботниковОрганизацийСрезПоследних
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|ВЫБРАТЬ РАЗРЕШЕННЫЕ
	|	МАКСИМУМ(ВЫБОР
	|			КОГДА Показатели.НомерСтроки = 1
	|				ТОГДА Показатели.Показатель
	|			ИНАЧЕ NULL
	|		КОНЕЦ) КАК Показатель1,
	|	МАКСИМУМ(ВЫБОР
	|			КОГДА Показатели.НомерСтроки = 2
	|				ТОГДА Показатели.Показатель
	|			ИНАЧЕ NULL
	|		КОНЕЦ) КАК Показатель2,
	|	МАКСИМУМ(ВЫБОР
	|			КОГДА Показатели.НомерСтроки = 3
	|				ТОГДА Показатели.Показатель
	|			ИНАЧЕ NULL
	|		КОНЕЦ) КАК Показатель3,
	|	МАКСИМУМ(ВЫБОР
	|			КОГДА Показатели.НомерСтроки = 4
	|				ТОГДА Показатели.Показатель
	|			ИНАЧЕ NULL
	|		КОНЕЦ) КАК Показатель4,
	|	МАКСИМУМ(ВЫБОР
	|			КОГДА Показатели.НомерСтроки = 5
	|				ТОГДА Показатели.Показатель
	|			ИНАЧЕ NULL
	|		КОНЕЦ) КАК Показатель5,
	|	МАКСИМУМ(ВЫБОР
	|			КОГДА Показатели.НомерСтроки = 6
	|				ТОГДА Показатели.Показатель
	|			ИНАЧЕ NULL
	|		КОНЕЦ) КАК Показатель6,
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Сотрудник КАК Сотрудник
	|ПОМЕСТИТЬ ВТПоказатели
	|ИЗ
	|	ВТДанныеРегистра КАК ПлановыеНачисленияРаботниковОрганизацийСрезПоследних
	|		ВНУТРЕННЕЕ СОЕДИНЕНИЕ ПланВидовРасчета.ОсновныеНачисленияОрганизаций.Показатели КАК Показатели
	|		ПО (ВЫБОР
	|				КОГДА ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.ПериодЗавершения <= &Дата
	|						И ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.ПериодЗавершения <> ДАТАВРЕМЯ(1, 1, 1)
	|					ТОГДА ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.ВидРасчетаЗавершения
	|				ИНАЧЕ ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.ВидРасчета
	|			КОНЕЦ = Показатели.Ссылка)
	|ГДЕ
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.ВидРасчета.ЗачетОтработанногоВремени
	|
	|СГРУППИРОВАТЬ ПО
	|	ПлановыеНачисленияРаботниковОрганизацийСрезПоследних.Сотрудник
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|ВЫБРАТЬ РАЗРЕШЕННЫЕ
	|	ЕСТЬNULL(ВЫБОР
	|			КОГДА ПлановыеНачисленияРаботниковСрез.ПериодЗавершения <= &Дата
	|					И ПлановыеНачисленияРаботниковСрез.ПериодЗавершения <> ДАТАВРЕМЯ(1, 1, 1, 0, 0, 0)
	|				ТОГДА ВЫБОР
	|						КОГДА ПлановыеНачисленияРаботниковСрез.ВидРасчетаЗавершения.ТребуетВводаТарифногоРазряда
	|							ТОГДА РазмерТарифныхСтавокСрезПоследних.Размер
	|						ИНАЧЕ ВЫБОР
	|								КОГДА ПлановыеНачисленияРаботниковСрез.ВидРасчета.ПроизвольнаяФормулаРасчета
	|									ТОГДА ВЫБОР
	|											КОГДА Показатели.Показатель1 В (&ТарифнаяСтавкаОклад)
	|													ИЛИ Показатели.Показатель1.ТарифнаяСтавка
	|												ТОГДА ПлановыеНачисленияРаботниковСрез.Показатель1Завершения
	|											КОГДА Показатели.Показатель2 В (&ТарифнаяСтавкаОклад)
	|													ИЛИ Показатели.Показатель2.ТарифнаяСтавка
	|												ТОГДА ПлановыеНачисленияРаботниковСрез.Показатель2Завершения
	|											КОГДА Показатели.Показатель3 В (&ТарифнаяСтавкаОклад)
	|													ИЛИ Показатели.Показатель3.ТарифнаяСтавка
	|												ТОГДА ПлановыеНачисленияРаботниковСрез.Показатель3Завершения
	|											КОГДА Показатели.Показатель4 В (&ТарифнаяСтавкаОклад)
	|													ИЛИ Показатели.Показатель4.ТарифнаяСтавка
	|												ТОГДА ПлановыеНачисленияРаботниковСрез.Показатель4Завершения
	|											КОГДА Показатели.Показатель5 В (&ТарифнаяСтавкаОклад)
	|													ИЛИ Показатели.Показатель5.ТарифнаяСтавка
	|												ТОГДА ПлановыеНачисленияРаботниковСрез.Показатель5Завершения
	|											КОГДА Показатели.Показатель6 В (&ТарифнаяСтавкаОклад)
	|													ИЛИ Показатели.Показатель6.ТарифнаяСтавка
	|												ТОГДА ПлановыеНачисленияРаботниковСрез.Показатель6Завершения
	|											ИНАЧЕ 0
	|										КОНЕЦ
	|								ИНАЧЕ ПлановыеНачисленияРаботниковСрез.Показатель1Завершения
	|							КОНЕЦ
	|					КОНЕЦ
	|			ИНАЧЕ ВЫБОР
	|					КОГДА ПлановыеНачисленияРаботниковСрез.ВидРасчета.ТребуетВводаТарифногоРазряда
	|						ТОГДА РазмерТарифныхСтавокСрезПоследних.Размер
	|					ИНАЧЕ ВЫБОР
	|							КОГДА ПлановыеНачисленияРаботниковСрез.ВидРасчета.ПроизвольнаяФормулаРасчета
	|								ТОГДА ВЫБОР
	|										КОГДА Показатели.Показатель1 В (&ТарифнаяСтавкаОклад)
	|												ИЛИ Показатели.Показатель1.ТарифнаяСтавка
	|											ТОГДА ПлановыеНачисленияРаботниковСрез.Показатель1
	|										КОГДА Показатели.Показатель2 В (&ТарифнаяСтавкаОклад)
	|												ИЛИ Показатели.Показатель2.ТарифнаяСтавка
	|											ТОГДА ПлановыеНачисленияРаботниковСрез.Показатель2
	|										КОГДА Показатели.Показатель3 В (&ТарифнаяСтавкаОклад)
	|												ИЛИ Показатели.Показатель3.ТарифнаяСтавка
	|											ТОГДА ПлановыеНачисленияРаботниковСрез.Показатель3
	|										КОГДА Показатели.Показатель4 В (&ТарифнаяСтавкаОклад)
	|												ИЛИ Показатели.Показатель4.ТарифнаяСтавка
	|											ТОГДА ПлановыеНачисленияРаботниковСрез.Показатель4
	|										КОГДА Показатели.Показатель5 В (&ТарифнаяСтавкаОклад)
	|												ИЛИ Показатели.Показатель5.ТарифнаяСтавка
	|											ТОГДА ПлановыеНачисленияРаботниковСрез.Показатель5
	|										КОГДА Показатели.Показатель6 В (&ТарифнаяСтавкаОклад)
	|												ИЛИ Показатели.Показатель6.ТарифнаяСтавка
	|											ТОГДА ПлановыеНачисленияРаботниковСрез.Показатель6
	|										ИНАЧЕ 0
	|									КОНЕЦ
	|							ИНАЧЕ ПлановыеНачисленияРаботниковСрез.Показатель1
	|						КОНЕЦ
	|				КОНЕЦ
	|		КОНЕЦ, 0) КАК ТарифнаяСтавкаОклад,
	|	ПлановыеНачисленияРаботниковСрез.Сотрудник
	|ПОМЕСТИТЬ ВТТарифныеСтавки
	|ИЗ
	|	ВТДанныеРегистра КАК ПлановыеНачисленияРаботниковСрез
	|		ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.РазмерТарифныхСтавок.СрезПоследних(&Дата, ) КАК РазмерТарифныхСтавокСрезПоследних
	|		ПО (ВЫБОР
	|				КОГДА ПлановыеНачисленияРаботниковСрез.ПериодЗавершения <= &Дата
	|						И ПлановыеНачисленияРаботниковСрез.ПериодЗавершения <> ДАТАВРЕМЯ(1, 1, 1, 0, 0, 0)
	|					ТОГДА ПлановыеНачисленияРаботниковСрез.ТарифныйРазряд1Завершения
	|				ИНАЧЕ ПлановыеНачисленияРаботниковСрез.ТарифныйРазряд1
	|			КОНЕЦ = РазмерТарифныхСтавокСрезПоследних.ТарифныйРазряд)
	|		ЛЕВОЕ СОЕДИНЕНИЕ ВТПоказатели КАК Показатели
	|		ПО ПлановыеНачисленияРаботниковСрез.Сотрудник = Показатели.Сотрудник
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|ВЫБРАТЬ
	|	ФизическиеЛица.Наименование,
	|	ФИОФизЛицСрезПоследних.Фамилия,
	|	ФИОФизЛицСрезПоследних.Имя,
	|	ФИОФизЛицСрезПоследних.Отчество,
	|	ВЫБОР
	|		КОГДА ДанныеПоследнегоДокумента.АдресРегистрации ЕСТЬ НЕ NULL 
	|			ТОГДА ДанныеПоследнегоДокумента.АдресРегистрации
	|		ИНАЧЕ "","" + АдресаРегистрации.Поле1 + "","" + АдресаРегистрации.Поле2 + "","" + АдресаРегистрации.Поле3 + "","" + АдресаРегистрации.Поле4 + "","" + АдресаРегистрации.Поле5 + "","" + АдресаРегистрации.Поле6 + "","" + АдресаРегистрации.Поле7 + "","" + АдресаРегистрации.Поле8 + "","" + АдресаРегистрации.Поле9 + "","" + ВЫБОР
	|				КОГДА АдресаРегистрации.ТипДома В (ЗНАЧЕНИЕ(Перечисление.ТипыДомов.Дом), ЗНАЧЕНИЕ(Перечисление.ТипыДомов.ПустаяСсылка))
	|					ТОГДА ""дом""
	|				ИНАЧЕ ""владение""
	|			КОНЕЦ + "","" + ВЫБОР
	|				КОГДА АдресаРегистрации.ТипКорпуса В (ЗНАЧЕНИЕ(Перечисление.ТипыКорпусов.Корпус), ЗНАЧЕНИЕ(Перечисление.ТипыКорпусов.ПустаяСсылка))
	|					ТОГДА ""корпус""
	|				ИНАЧЕ ""строение""
	|			КОНЕЦ + "","" + ВЫБОР
	|				КОГДА АдресаРегистрации.ТипКвартиры В (ЗНАЧЕНИЕ(Перечисление.ТипыКвартир.Квартира), ЗНАЧЕНИЕ(Перечисление.ТипыКвартир.ПустаяСсылка))
	|					ТОГДА ""кв.""
	|				ИНАЧЕ ""оф.""
	|			КОНЕЦ
	|	КОНЕЦ КАК АдресРегистрации,
	|	ВЫБОР
	|		КОГДА ДанныеПоследнегоДокумента.АдресРегистрацииКодПоКЛАДР ЕСТЬ НЕ NULL 
	|			ТОГДА ДанныеПоследнегоДокумента.АдресРегистрацииКодПоКЛАДР
	|		ИНАЧЕ """"
	|	КОНЕЦ КАК АдресРегистрацииКодПоКЛАДР,
	|	ВЫБОР
	|		КОГДА ДанныеПоследнегоДокумента.АдресПочтовый ЕСТЬ НЕ NULL 
	|			ТОГДА ДанныеПоследнегоДокумента.АдресПочтовый
	|		КОГДА АдресаФактические.Поле1 ЕСТЬ NULL 
	|			ТОГДА "","" + АдресаРегистрации.Поле1 + "","" + АдресаРегистрации.Поле2 + "","" + АдресаРегистрации.Поле3 + "","" + АдресаРегистрации.Поле4 + "","" + АдресаРегистрации.Поле5 + "","" + АдресаРегистрации.Поле6 + "","" + АдресаРегистрации.Поле7 + "","" + АдресаРегистрации.Поле8 + "","" + АдресаРегистрации.Поле9 + "","" + ВЫБОР
	|					КОГДА АдресаРегистрации.ТипДома В (ЗНАЧЕНИЕ(Перечисление.ТипыДомов.Дом), ЗНАЧЕНИЕ(Перечисление.ТипыДомов.ПустаяСсылка))
	|						ТОГДА ""дом""
	|					ИНАЧЕ ""владение""
	|				КОНЕЦ + "","" + ВЫБОР
	|					КОГДА АдресаРегистрации.ТипКорпуса В (ЗНАЧЕНИЕ(Перечисление.ТипыКорпусов.Корпус), ЗНАЧЕНИЕ(Перечисление.ТипыКорпусов.ПустаяСсылка))
	|						ТОГДА ""корпус""
	|					ИНАЧЕ ""строение""
	|				КОНЕЦ + "","" + ВЫБОР
	|					КОГДА АдресаРегистрации.ТипКвартиры В (ЗНАЧЕНИЕ(Перечисление.ТипыКвартир.Квартира), ЗНАЧЕНИЕ(Перечисление.ТипыКвартир.ПустаяСсылка))
	|						ТОГДА ""кв.""
	|					ИНАЧЕ ""оф.""
	|				КОНЕЦ
	|		ИНАЧЕ "","" + АдресаФактические.Поле1 + "","" + АдресаФактические.Поле2 + "","" + АдресаФактические.Поле3 + "","" + АдресаФактические.Поле4 + "","" + АдресаФактические.Поле5 + "","" + АдресаФактические.Поле6 + "","" + АдресаФактические.Поле7 + "","" + АдресаФактические.Поле8 + "","" + АдресаФактические.Поле9 + "","" + ВЫБОР
	|				КОГДА АдресаФактические.ТипДома В (ЗНАЧЕНИЕ(Перечисление.ТипыДомов.Дом), ЗНАЧЕНИЕ(Перечисление.ТипыДомов.ПустаяСсылка))
	|					ТОГДА ""дом""
	|				ИНАЧЕ ""владение""
	|			КОНЕЦ + "","" + ВЫБОР
	|				КОГДА АдресаФактические.ТипКорпуса В (ЗНАЧЕНИЕ(Перечисление.ТипыКорпусов.Корпус), ЗНАЧЕНИЕ(Перечисление.ТипыКорпусов.ПустаяСсылка))
	|					ТОГДА ""корпус""
	|				ИНАЧЕ ""строение""
	|			КОНЕЦ + "","" + ВЫБОР
	|				КОГДА АдресаФактические.ТипКвартиры В (ЗНАЧЕНИЕ(Перечисление.ТипыКвартир.Квартира), ЗНАЧЕНИЕ(Перечисление.ТипыКвартир.ПустаяСсылка))
	|					ТОГДА ""кв.""
	|				ИНАЧЕ ""оф.""
	|			КОНЕЦ
	|	КОНЕЦ КАК АдресПочтовый,
	|	ВЫБОР
	|		КОГДА ДанныеПоследнегоДокумента.АдресПочтовыйКодПоКЛАДР ЕСТЬ НЕ NULL 
	|			ТОГДА ДанныеПоследнегоДокумента.АдресПочтовыйКодПоКЛАДР
	|		ИНАЧЕ """"
	|	КОНЕЦ КАК АдресПочтовыйКодПоКЛАДР,
	|	ВЫБОР
	|		КОГДА ДанныеПоследнегоДокумента.Телефон ЕСТЬ НЕ NULL 
	|			ТОГДА ДанныеПоследнегоДокумента.Телефон
	|		ИНАЧЕ Телефоны.Представление
	|	КОНЕЦ КАК Телефон,
	|	ПаспортныеДанныеФизЛицСрезПоследних.ДокументВид КАК ВидДокумента,
	|	ПаспортныеДанныеФизЛицСрезПоследних.ДокументСерия КАК СерияДокумента,
	|	ПаспортныеДанныеФизЛицСрезПоследних.ДокументНомер КАК НомерДокумента,
	|	ПаспортныеДанныеФизЛицСрезПоследних.ДокументДатаВыдачи КАК ДатаВыдачиДокумента,
	|	ПаспортныеДанныеФизЛицСрезПоследних.ДокументКемВыдан КАК КемВыданДокумент,
	|	ЕСТЬNULL(ДанныеПоследнегоДокумента.НомерЛицевогоСчета, ДанныеЗарплатногоСчета.НомерЛицевогоСчета) КАК НомерЛицевогоСчета,
	|	ЕСТЬNULL(ДанныеПоследнегоДокумента.БИКБанка, ДанныеЗарплатногоСчета.БИК) КАК БИКБанка,
	|	ЕСТЬNULL(ДанныеПоследнегоДокумента.КоррСчетБанка, ДанныеЗарплатногоСчета.КоррСчет) КАК КоррСчетБанка,
	|	ЕСТЬNULL(ДанныеПоследнегоДокумента.НаименованиеБанка, ДанныеЗарплатногоСчета.Наименование) КАК НаименованиеБанка,
	|	ЕСТЬNULL(ДанныеПоследнегоДокумента.ПеречислятьПособиеПочтовымПереводом, ЛОЖЬ) КАК ПеречислятьПособиеПочтовымПереводом,
	|	ЕСТЬNULL(ДанныеПоследнегоДокумента.Банк, ДанныеЗарплатногоСчета.Банк) КАК Банк,
	|	Физлица.Ссылка КАК СотрудникЗаполнения,
	|	ЕСТЬNULL(СтатусыНалогоплательщика.Статус, ЗНАЧЕНИЕ(Перечисление.СтатусыНалогоплательщиковПоНДФЛ.Резидент)) КАК СтатусНалогоплательщика,
	|	ФизическиеЛица.Ссылка КАК ФизЛицо,
	|	ФизическиеЛица.ИНН,
	|	ФизическиеЛица.СтраховойНомерПФР,
	|	ФизическиеЛица.Пол,
	|	ФизическиеЛица.ДатаРождения,
	|	Физлица.ВидЗанятости,
	|	ДанныеПоследнегоДокументаОПроживании.НаименованиеДокументаНаПроживание,
	|	ДанныеПоследнегоДокументаОПроживании.СерияДокументаНаПроживание,
	|	ДанныеПоследнегоДокументаОПроживании.НомерДокументаНаПроживание,
	|	ДанныеПоследнегоДокументаОПроживании.ДатаВыдачиДокументаНаПроживание,
	|	ТарифныеСтавки.ТарифнаяСтавкаОклад
	|ИЗ
	|	ВТФизлицо КАК Физлица
	|		ЛЕВОЕ СОЕДИНЕНИЕ Справочник.ФизическиеЛица КАК ФизическиеЛица
	|		ПО Физлица.Физлицо = ФизическиеЛица.Ссылка
	|		ЛЕВОЕ СОЕДИНЕНИЕ ВТКонтактнаяИнформация КАК АдресаФактические
	|		ПО Физлица.Физлицо = АдресаФактические.Объект
	|			И (АдресаФактические.Вид = ЗНАЧЕНИЕ(Справочник.ВидыКонтактнойИнформации.ФактАдресФизЛица))
	|			И (АдресаФактические.Тип = ЗНАЧЕНИЕ(Перечисление.ТипыКонтактнойИнформации.Адрес))
	|		ЛЕВОЕ СОЕДИНЕНИЕ ВТКонтактнаяИнформация КАК АдресаРегистрации
	|		ПО Физлица.Физлицо = АдресаРегистрации.Объект
	|			И (АдресаРегистрации.Вид = ЗНАЧЕНИЕ(Справочник.ВидыКонтактнойИнформации.ЮрАдресФизЛица))
	|			И (АдресаРегистрации.Тип = ЗНАЧЕНИЕ(Перечисление.ТипыКонтактнойИнформации.Адрес))
	|		ЛЕВОЕ СОЕДИНЕНИЕ ВТКонтактнаяИнформация КАК Телефоны
	|		ПО Физлица.Физлицо = Телефоны.Объект
	|			И (Телефоны.Вид = ЗНАЧЕНИЕ(Справочник.ВидыКонтактнойИнформации.ТелефонФизЛица))
	|			И (Телефоны.Тип = ЗНАЧЕНИЕ(Перечисление.ТипыКонтактнойИнформации.Телефон))
	|		ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.ПаспортныеДанныеФизЛиц.СрезПоследних(
	|				&Дата,
	|				Физлицо В
	|					(ВЫБРАТЬ
	|						Физлица.Физлицо
	|					ИЗ
	|						ВТФизлицо КАК Физлица)) КАК ПаспортныеДанныеФизЛицСрезПоследних
	|		ПО Физлица.Физлицо = ПаспортныеДанныеФизЛицСрезПоследних.ФизЛицо
	|		ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.СтатусФизЛицКакНалогоплательщиковНДФЛ.СрезПоследних(
	|				&Дата,
	|				ФизЛицо В
	|					(ВЫБРАТЬ
	|						Физлица.Физлицо
	|					ИЗ
	|						ВТФизлицо КАК Физлица)) КАК СтатусыНалогоплательщика
	|		ПО Физлица.Физлицо = СтатусыНалогоплательщика.ФизЛицо
	|		ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.ФИОФизЛиц.СрезПоследних(
	|				&Дата,
	|				Физлицо В
	|					(ВЫБРАТЬ
	|						Физлица.Физлицо
	|					ИЗ
	|						ВТФизлицо КАК Физлица)) КАК ФИОФизЛицСрезПоследних
	|		ПО Физлица.Физлицо = ФИОФизЛицСрезПоследних.ФизЛицо
	|		ЛЕВОЕ СОЕДИНЕНИЕ ВТДанныеПоследнегоДокумента КАК ДанныеПоследнегоДокумента
	|		ПО (ИСТИНА)
	|		ЛЕВОЕ СОЕДИНЕНИЕ ВТДанныеПоследнегоДокументаОПроживании КАК ДанныеПоследнегоДокументаОПроживании
	|		ПО (ИСТИНА)
	|		ЛЕВОЕ СОЕДИНЕНИЕ ВТДанныеЗарплатногоСчета КАК ДанныеЗарплатногоСчета
	|		ПО (ИСТИНА)
	|		ЛЕВОЕ СОЕДИНЕНИЕ ВТТарифныеСтавки КАК ТарифныеСтавки
	|		ПО Физлица.Ссылка = ТарифныеСтавки.Сотрудник";*/
			//Запрос.УстановитьПараметр("Организация", Организация);
			//Запрос.УстановитьПараметр("Ссылка", Сотрудник);
			//Запрос.УстановитьПараметр("Дата", Дата);
			//Запрос.УстановитьПараметр("ДатаПередачиФССВыплатыПособий", ПроцедурыУправленияПерсоналом.ЗначениеУчетнойПолитикиПоПерсоналуОрганизации(глЗначениеПеременной("глУчетнаяПолитикаПоПерсоналуОрганизации"), Организация, "ДатаПередачиФССВыплатыПособий"));
			//СписокПоказателей = Новый Массив;
			//СписокПоказателей.Добавить(Справочники.ПоказателиСхемМотивации.ТарифнаяСтавкаДневная);
			//СписокПоказателей.Добавить(Справочники.ПоказателиСхемМотивации.ТарифнаяСтавкаМесячная);
			//СписокПоказателей.Добавить(Справочники.ПоказателиСхемМотивации.ТарифнаяСтавкаЧасовая);
			//Запрос.УстановитьПараметр("ТарифнаяСтавкаОклад", СписокПоказателей);
			//Результат = Запрос.Выполнить();
			if(true/*Режим = "ДляДокумента"*/)
			{
				//Выборка = Результат.Выбрать();
				/*ДанныеСотрудника = Новый Структура("Фамилия, Имя, Отчество, АдресПочтовый, АдресПочтовыйКодПоКЛАДР, АдресРегистрации, АдресРегистрацииКодПоКЛАДР, Телефон"
			+ ", ВидДокумента, СерияДокумента, НомерДокумента, ДатаВыдачиДокумента, КемВыданДокумент" 
			+ ", БИКБанка, КоррСчетБанка, НаименованиеБанка, НомерЛицевогоСчета, ПеречислятьПособиеПочтовымПереводом, Банк" 
			+ ", ФизЛицо, ИНН, СтраховойНомерПФР, Пол, ДатаРождения, ВидЗанятости, СтатусНалогоплательщика"
			+ ", ТарифнаяСтавкаОклад" 
			+ ", НаименованиеДокументаНаПроживание, СерияДокументаНаПроживание, НомерДокументаНаПроживание, ДатаВыдачиДокументаНаПроживание");*/
				if(true/*Выборка.Следующий()*/)
				{
					//ЗаполнитьЗначенияСвойств(ДанныеСотрудника, Выборка);
					if(true/*ЗначениеЗаполнено(ДанныеСотрудника.АдресПочтовый) И Не ЗначениеЗаполнено(ДанныеСотрудника.АдресПочтовыйКодПоКЛАДР)*/)
					{
						//ДанныеСотрудника.АдресПочтовыйКодПоКЛАДР = ОбменСведениямиОПособияхСФСС.КодАдресаПоКЛАДРдляФСС(ДанныеСотрудника.АдресПочтовый);
					}
					if(true/*ЗначениеЗаполнено(ДанныеСотрудника.АдресРегистрации) И Не ЗначениеЗаполнено(ДанныеСотрудника.АдресРегистрацииКодПоКЛАДР)*/)
					{
						//ДанныеСотрудника.АдресРегистрацииКодПоКЛАДР = ОбменСведениямиОПособияхСФСС.КодАдресаПоКЛАДРдляФСС(ДанныеСотрудника.АдресРегистрации);
					}
				}
			}
			return null;
		}
	}
}

