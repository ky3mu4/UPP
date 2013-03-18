﻿Ext.define('Справочники.НастройкиОбменаДанными.ФормаЭлемента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:507px;height:551px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Настройки обмена данными',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:507px;height:25px;',
			items:
			[
				{
					xtype: 'splitbutton',
					text:'Действия',
					menu: [
				{
					text:'Найти в списке',
				},
				'-',
				{
					text:'Перечитать',
				},
				{
					text:'Скопировать',
				},
				{
					text:'Записать',
				},
				{
					text:'Записать и закрыть',
				},
				'-',
				{
					text:'Ввести на основании...',
				},
				'-',
				{
					text:'Закрыть',
				},
				'-',
				{
					text:'Выполнить обмен',
				},
				{
					text:'Монитор обменов',
				},
				'-',
				{
					text:'Зарегистрировать для обмена',
				},
					]
				},
				'-',
				{
					text:'Найти в списке',
				},
				'-',
				{
					text:'Перечитать',
				},
				{
					text:'Скопировать',
				},
				{
					xtype: 'splitbutton',
					text:'Перейти',
					menu: [
				{
					text:'',
				},
				{
					text:'',
				},
					]
				},
				{
					text:'Ввести на основании...',
				},
				'-',
				{
					text:'Выполнить обмен',
				},
				'-',
				{
					text:'Монитор обменов',
				},
				{
					text:'Справка',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:526px;width:507px;height:25px;',
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					text:'OK',
				},
				'-',
				{
					text:'Записать',
				},
				'-',
				{
					text:'Закрыть',
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьКод',
			text: 'Код:',
			style: 'position:absolute;left:418px;top:33px;width:40px;height:19px;text-align:center;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Код',
			style: 'position:absolute;left:460px;top:33px;width:40px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНаименование',
			text: 'Наименование:',
			style: 'position:absolute;left:8px;top:33px;width:84px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Наименование',
			style: 'position:absolute;left:94px;top:33px;width:323px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКомментарий',
			text: 'Комментарий:',
			style: 'position:absolute;left:8px;top:500px;width:90px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Комментарий',
			style: 'position:absolute;left:102px;top:500px;width:398px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:57px;width:492px;height:438px;',
			height: 438,width: 492,
			items:
			[
				{
					title:'Основные',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьУзелИнформационнойБазы',
			text: 'Узел:',
			style: 'position:absolute;left:6px;top:6px;width:84px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'УзелИнформационнойБазы',
			style: 'position:absolute;left:93px;top:6px;width:391px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьТипНастройки',
			text: 'Тип обмена:',
			style: 'position:absolute;left:6px;top:160px;width:84px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ТипНастройки',
			style: 'position:absolute;left:93px;top:160px;width:391px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:6px;top:184px;width:478px;height:113px;',
			height: 113,width: 478,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Файловый',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьКаталогОбменаИнформацией',
			text: 'Каталог:',
			style: 'position:absolute;left:5px;top:0px;width:78px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'КаталогОбменаИнформацией',
			style: 'position:absolute;left:87px;top:0px;width:391px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПорт',
			text: 'Порт:',
			style: 'position:absolute;left:274px;top:0px;width:79px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'НадписьПравилаОбменаПриемник',
			text: 'Правила выгрузки из базы обмена в текущую базу',
			style: 'position:absolute;left:6px;top:0px;width:348px;height:19px;',
		},
					]
				},
				{
					title:'FTPОбмен',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьFTPАдресОбмена',
			text: 'Адрес:',
			style: 'position:absolute;left:6px;top:0px;width:79px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'FTPАдресОбмена',
			style: 'position:absolute;left:87px;top:0px;width:185px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'Проверить',
			text: 'Проверить...',
			style: 'position:absolute;left:277px;top:72px;width:159px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПользовательFTPСоединения',
			text: 'Пользователь:',
			style: 'position:absolute;left:6px;top:24px;width:79px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПользовательFTPСоединения',
			style: 'position:absolute;left:87px;top:24px;width:391px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПарольFTPСоединения',
			text: 'Пароль:',
			style: 'position:absolute;left:6px;top:48px;width:79px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПарольFTPСоединения',
			style: 'position:absolute;left:87px;top:48px;width:185px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПортFTPСоединения',
			style: 'position:absolute;left:358px;top:0px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьМаксимальныйРазмерПакетаЧерезFTP',
			text: 'Макс. пакет:',
			style: 'position:absolute;left:6px;top:72px;width:79px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'МаксимальныйРазмерОтправляемогоПолучаемогоПакетаЧерезFTP',
			style: 'position:absolute;left:87px;top:72px;width:185px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Пассивное FTP соединение',
			style: 'position:absolute;left:277px;top:48px;width:201px;height:19px;',
		},
					]
				},
				{
					title:'Почта',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьУчетнаяЗаписьПриемаОтпревкиСообщений',
			text: 'Учетная запись:',
			style: 'position:absolute;left:6px;top:24px;width:98px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'УчетнаяЗаписьПриемаОтправкиСообщений',
			style: 'position:absolute;left:106px;top:24px;width:372px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПочтовыйАдресПолучателя',
			text: 'Адрес получателя:',
			style: 'position:absolute;left:6px;top:0px;width:98px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПочтовыйАдресПолучателя',
			style: 'position:absolute;left:106px;top:0px;width:372px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Получать почту при обмене',
			style: 'position:absolute;left:6px;top:48px;width:158px;height:15px;',
		},
		{
			xtype: 'label',
			name: 'НадписьМаксимальныйРазмерПакетаЧерезПочту',
			text: 'Максимальный размер отправляемого пакета:',
			style: 'position:absolute;left:6px;top:68px;width:245px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'МаксимальныйРазмерОтправляемогоПакетаЧерезПочту',
			style: 'position:absolute;left:256px;top:68px;width:100px;height:19px;',
		},
					]
				},
				{
					title:'Обмен через COM',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьТипИнформационнойБазыДляПодключения',
			text: 'Тип инф. базы:',
			style: 'position:absolute;left:6px;top:24px;width:131px;height:19px;',
		},
		{
			xtype: 'combobox',
			style: 'position:absolute;left:140px;top:24px;width:182px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:6px;top:47px;width:472px;height:19px;',
			height: 19,width: 472,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Подключение файловая ИБ',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'КаталогИнформационнойБазыДляПодключения',
			style: 'position:absolute;left:133px;top:0px;width:339px;height:19px;',
		},
					]
				},
				{
					title:'Подключение серверная ИБ',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ИмяСервераИнформационнойБазыДляПодключения',
			style: 'position:absolute;left:133px;top:0px;width:145px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИмяИнформационнойБазы',
			text: 'Инф. база:',
			style: 'position:absolute;left:284px;top:0px;width:64px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ИмяИнформационнойБазыНаСервереДляПодключения',
			style: 'position:absolute;left:357px;top:0px;width:115px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Аутентификация Windows',
			style: 'position:absolute;left:6px;top:70px;width:155px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПользовательДляПодключения',
			text: 'Пользователь:',
			style: 'position:absolute;left:6px;top:94px;width:131px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПользовательИнформационнойБазыДляПодключения',
			style: 'position:absolute;left:139px;top:94px;width:146px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПароль',
			text: 'Пароль:',
			style: 'position:absolute;left:292px;top:94px;width:62px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПарольИнформационнойБазыДляПодключения',
			style: 'position:absolute;left:362px;top:94px;width:116px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'ТестПодключения',
			text: 'Проверить...',
			style: 'position:absolute;left:362px;top:70px;width:116px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'ЗагрузитьПравилаОбратныйОбмен',
			text: '',
			style: 'position:absolute;left:361px;top:0px;width:25px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'СохранитьПравилаОбратныйОбмен',
			text: '',
			style: 'position:absolute;left:391px;top:0px;width:25px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'ИнформацияОПравилах1',
			text: '',
			style: 'position:absolute;left:421px;top:0px;width:25px;height:19px;',
		},
		{
			xtype: 'combobox',
			style: 'position:absolute;left:328px;top:24px;width:150px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьУзелФоновогоОбмена',
			text: 'Узел фон:',
			style: 'position:absolute;left:6px;top:116px;width:84px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'УзелФоновогоОбмена',
			style: 'position:absolute;left:93px;top:116px;width:391px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьТипДобавленияДанныхИзФоновогоОбмена',
			text: 'Фоновый обмен:',
			style: 'position:absolute;left:6px;top:93px;width:88px;height:19px;',
		},
		{
			xtype: 'combobox',
			style: 'position:absolute;left:94px;top:93px;width:254px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКоличествоДополняемыхОбъектов',
			text: 'Количество:',
			style: 'position:absolute;left:351px;top:93px;width:65px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'КоличествоОбъектовДляФоновогоОбмена',
			style: 'position:absolute;left:419px;top:93px;width:65px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Обмен по правилам обмена',
			style: 'position:absolute;left:6px;top:50px;width:163px;height:15px;',
		},
		{
			xtype: 'button',
			name: 'ЗагрузитьПравила',
			text: '',
			style: 'position:absolute;left:250px;top:69px;width:25px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'СохранитьПравила',
			text: '',
			style: 'position:absolute;left:280px;top:69px;width:25px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'ПроверитьПравилаОбмена',
			text: 'Проверить правила...',
			style: 'position:absolute;left:338px;top:69px;width:139px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'ИнформацияОПравилах',
			text: '',
			style: 'position:absolute;left:309px;top:69px;width:25px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПарольНаПрием',
			style: 'position:absolute;left:250px;top:317px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПарольНаПрием',
			text: 'Пароль распаковки (при загрузке данных):',
			style: 'position:absolute;left:14px;top:317px;width:228px;height:19px;text-align:left;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Сжатие исходящего файла обмена',
			style: 'position:absolute;left:14px;top:340px;width:199px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПарольНаОтправку',
			style: 'position:absolute;left:250px;top:363px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПарольНаЗапись',
			text: 'Пароль сжатия (при выгрузке данных):',
			style: 'position:absolute;left:35px;top:363px;width:207px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'НадписьИнформацияПоАвтообмену',
			text: 'Автоматический обмен по настройке будет выполняться только в том случае, если она включена в одну из настроек выполнения обмена данными. Список всех настроек выполнения обмена:',
			style: 'position:absolute;left:6px;top:6px;width:478px;height:42px;',
		},
					]
				},
				{
					title:'Обмен по правилам',
					items:
					[
		{
			xtype: 'checkbox',
			boxLabel: 'Использовать режим отладки для обмена данными',
			style: 'position:absolute;left:6px;top:6px;width:284px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИмяФайлаПротокола',
			text: 'Имя файла, протокола:',
			style: 'position:absolute;left:6px;top:29px;width:132px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ИмяФайлаПротоколаОбмена',
			style: 'position:absolute;left:140px;top:29px;width:344px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'После ошибки отложенного проведения прекратить операции',
			style: 'position:absolute;left:6px;top:76px;width:339px;height:17px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКоличествоОшибокДляЗавершения',
			text: 'Количество ошибок для завершения:',
			style: 'position:absolute;left:21px;top:98px;width:191px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'КоличествоОшибокОтложенногоПроведенияДляПрекращенияОперации',
			style: 'position:absolute;left:220px;top:98px;width:98px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'ЗапуститьОтложенныеДвиженияДокументов',
			text: 'Выполнить отложенные движения..',
			style: 'position:absolute;left:6px;top:120px;width:210px;height:24px;',
		},
		{
			xtype: 'button',
			name: 'ЗапуститьОтложенныеДвиженияДокументовПодПолнымиПравами',
			text: 'Выполнить движения под полными правами..',
			style: 'position:absolute;left:222px;top:120px;width:260px;height:24px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Выполнять отложенные движения после загрузки данных',
			style: 'position:absolute;left:6px;top:52px;width:319px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:6px;top:146px;width:478px;height:266px;',
			height: 266,width: 478,
			items:
			[
				{
					title:'Настройки выгрузки',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:33px;width:464px;height:207px;',
			height: 207,width: 464,
			columns:
			[
				{
					text:'Выгрузка',
					width:'54',
				},
				{
					text:'Наименование объекта',
					width:'185',
				},
				{
					text:'Настройка выгрузки',
					width:'157',
				},
				{
					text:'Выгружать',
					width:'44',
				},
				{
					text:'Выгружать по ссылке',
					width:'74',
				},
				{
					text:'Код правила выгрузки',
					width:'92',
				},
				{
					text:'Код правила обмена',
					width:'100',
				},
				{
					text:'Настройка не поддерживается',
					width:'100',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:6px;top:6px;width:464px;height:24px;',
			items:
			[
				{
					text:'&Изменить',
				},
				{
					text:'Закончить редактирование',
				},
				'-',
				{
					text:'Изменить настройку',
				},
				'-',
				{
					text:'Загрузить настройки',
				},
			]
		},
					]
				},
				{
					title:'Сопоставление объектов',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:5px;top:33px;width:465px;height:207px;',
			height: 207,width: 465,
			columns:
			[
				{
					text:'Выгрузка',
					width:'60',
				},
				{
					text:'Наименование объекта',
					width:'130',
				},
				{
					text:'Настройка сопоставления',
					width:'140',
				},
				{
					text:'Описание',
					width:'130',
				},
				{
					text:'Имя настройки для алгоритма',
					width:'100',
				},
				{
					text:'Настройка не поддерживается',
					width:'100',
				},
				{
					text:'Вариант поиска не поддерживается',
					width:'100',
				},
				{
					text:'Код правила обмена',
					width:'100',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:5px;top:6px;width:465px;height:24px;',
			items:
			[
				{
					text:'&Изменить',
				},
				{
					text:'Закончить редактирование',
				},
				'-',
				{
					text:'Загрузить параметры выбора',
				},
			]
		},
					]
				},
			]
		},
					]
				},
				{
					title:'Интерактивный обмен',
					items:
					[
		{
			xtype: 'checkbox',
			boxLabel: 'Загружать данные',
			style: 'position:absolute;left:6px;top:47px;width:120px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Выгружать данные',
			style: 'position:absolute;left:6px;top:70px;width:120px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Выгружать данные только при успешной загрузке',
			style: 'position:absolute;left:16px;top:93px;width:279px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКоличествоЭлементовВТранзакцииНаЗапись1',
			text: 'Элементов в транзакции при загрузке данных:',
			style: 'position:absolute;left:6px;top:118px;width:245px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'КоличествоЭлементовВТранзакцииНаЗапись1',
			style: 'position:absolute;left:260px;top:118px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКоличествоЭлементовВТранзакцииНаЧтение1',
			text: 'Элементов в транзакции при выгрузке данных:',
			style: 'position:absolute;left:6px;top:142px;width:245px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'КоличествоЭлементовВТранзакцииНаЧтение1',
			style: 'position:absolute;left:260px;top:142px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьУчетнаяЗапись',
			text: 'Учетная запись:',
			style: 'position:absolute;left:16px;top:187px;width:130px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'УчетнаяЗаписьОтправкиСообщенияОбОшибке',
			style: 'position:absolute;left:148px;top:187px;width:336px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьАдресДляОтправкиСообщений',
			text: 'Адрес для отправки:',
			style: 'position:absolute;left:16px;top:211px;width:130px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'АдресДляОтправкиСообщенийОбОшибке',
			style: 'position:absolute;left:148px;top:211px;width:336px;height:19px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:16px;top:260px;width:468px;height:152px;',
			height: 152,width: 468,
			columns:
			[
				{
					text:'Тексты сообщений, которые не являются ошибками',
					width:'325',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:16px;top:234px;width:468px;height:24px;',
			items:
			[
				{
					text:'&Добавить',
				},
				{
					text:'&Скопировать',
				},
				{
					text:'&Изменить',
				},
				{
					text:'&Удалить',
				},
				{
					text:'Закончить редактирование',
				},
			]
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Выполнять обмен данными под полными правами',
			style: 'position:absolute;left:6px;top:26px;width:277px;height:16px;',
		},
					]
				},
				{
					title:'Автоматический обмен',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:76px;width:478px;height:336px;',
			height: 336,width: 478,
			columns:
			[
				{
					text:'',
					width:'24',
				},
				{
					text:'Код',
					width:'70',
				},
				{
					text:'Наименование',
					width:'362',
				},
				{
					text:'Комментарий',
					width:'169',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:6px;top:50px;width:478px;height:24px;',
			items:
			[
				{
					text:'&Добавить',
				},
				{
					text:'&Скопировать',
				},
				{
					text:'&Изменить',
				},
				'-',
				{
					text:'Установить отбор и сортировку списка...',
				},
				{
					text:'Отбор по значению в текущей колонке',
				},
				{
					xtype: 'splitbutton',
					text:'История отборов',
					menu: [
				{
					text:'(Список отборов)',
				},
				'-',
				{
					text:'(История отборов)',
				},
					]
				},
				{
					text:'Отключить отбор',
				},
				'-',
				{
					text:'Обновить',
				},
			]
		},
					]
				},
			]
		},
	]
});