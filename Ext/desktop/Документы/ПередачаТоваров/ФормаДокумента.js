﻿Ext.define('Документы.ПередачаТоваров.ФормаДокумента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:666px;height:400px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Передача товаров',
	
	items:
	[
		{
			xtype: 'label',
			name: 'НадписьНомер',
			text: 'Номер:',
			style: 'position:absolute;left:8px;top:33px;width:88px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'НадписьДата',
			text: 'от:',
			style: 'position:absolute;left:176px;top:33px;width:20px;height:19px;text-align:center;',
		},
		{
			xtype: 'label',
			name: 'НадписьКомментарий',
			text: 'Комментарий:',
			style: 'position:absolute;left:8px;top:348px;width:88px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Номер',
			style: 'position:absolute;left:96px;top:33px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Дата',
			style: 'position:absolute;left:196px;top:33px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Комментарий',
			style: 'position:absolute;left:96px;top:348px;width:562px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:666px;height:25px;',
			items:
			[
			]
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Флажок',
			style: 'position:absolute;left:425px;top:33px;width:70px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Флажок',
			style: 'position:absolute;left:499px;top:33px;width:69px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:127px;width:650px;height:213px;',
			height: 213,width: 650,
			items:
			[
				{
					title:'Товары',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:4px;top:25px;width:640px;height:162px;',
			height: 162,width: 640,
			columns:
			[
				{
					text:'№',
					width:'30',
				},
				{
					text:'Код',
					width:'60',
				},
				{
					text:'Артикул',
					width:'120',
				},
				{
					text:'Номенклатура',
					width:'250',
				},
				{
					text:'Характеристика номенклатуры',
					width:'250',
				},
				{
					text:'Серия номенклатуры',
					width:'250',
				},
				{
					text:'Ед. мест',
					width:'50',
				},
				{
					text:'К.мест',
					width:'45',
				},
				{
					text:'Мест',
					width:'67',
				},
				{
					text:'Количество',
					width:'70',
				},
				{
					text:'Ед.',
					width:'50',
				},
				{
					text:'К.',
					width:'45',
				},
				{
					text:'Цена',
					width:'80',
				},
				{
					text:'Сумма',
					width:'80',
				},
				{
					text:'Счет учета (БУ)',
					width:'90',
				},
				{
					text:'Счет учета (НУ)',
					width:'90',
				},
				{
					text:'Номер ГТД',
					width:'100',
				},
				{
					text:'Страна происхождения',
					width:'100',
				},
				{
					text:'Счет передачи (БУ)',
					width:'100',
				},
				{
					text:'Счет передачи (НУ)',
					width:'100',
				},
				{
					text:'Качество',
					width:'100',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:4px;top:0px;width:640px;height:24px;',
			items:
			[
				{
					text:'Поиск по штрихкоду',
				},
				'-',
				'-',
				'-',
				{
					text:'Подбор',
				},
				'-',
				{
					text:'Изменить',
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьОтветственный',
			text: 'Ответственный:',
			style: 'position:absolute;left:335px;top:30px;width:100px;height:19px;',
		},
					]
				},
				{
					title:'Тара',
					items:
					[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:4px;top:0px;width:640px;height:24px;',
			items:
			[
				'-',
				{
					text:'Подбор',
				},
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:4px;top:25px;width:640px;height:162px;',
			height: 162,width: 640,
			columns:
			[
				{
					text:'№',
					width:'30',
				},
				{
					text:'Код',
					width:'60',
				},
				{
					text:'Артикул',
					width:'120',
				},
				{
					text:'Номенклатура',
					width:'251',
				},
				{
					text:'Количество',
					width:'65',
				},
				{
					text:'Цена',
					width:'80',
				},
				{
					text:'Ед. хранения',
					width:'52',
				},
				{
					text:'Сумма',
					width:'80',
				},
				{
					text:'Счет учета (БУ)',
					width:'90',
				},
				{
					text:'Счет учета (НУ)',
					width:'100',
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьСчетУчетаРасчетовПоТаре',
			text: 'Счет учета расчетов по таре:',
			style: 'position:absolute;left:8px;top:6px;width:186px;height:19px;text-align:left;',
		},
					]
				},
				{
					title:'Счета учета расчетов',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СчетУчетаРасчетовПоТаре',
			style: 'position:absolute;left:196px;top:6px;width:100px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСуммаВзаиморасчетов',
			text: 'Сумма <нет валюты>:',
			style: 'position:absolute;left:3px;top:30px;width:100px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СчетУчетаДоходовПоТареБУ',
			style: 'position:absolute;left:196px;top:57px;width:100px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СчетУчетаРасходовПоТареБУ',
			style: 'position:absolute;left:196px;top:81px;width:100px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СчетУчетаДоходовПоТареНУ',
			style: 'position:absolute;left:542px;top:57px;width:100px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СчетУчетаРасходовПоТареНУ',
			style: 'position:absolute;left:542px;top:81px;width:100px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СтатьяПрочихДоходовРасходовПоТаре',
			style: 'position:absolute;left:196px;top:105px;width:446px;height:19px;',
		},
					]
				},
				{
					title:'Дополнительно',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Ответственный',
			style: 'position:absolute;left:435px;top:30px;width:209px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СуммаВзаиморасчетов',
			style: 'position:absolute;left:103px;top:30px;width:87px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Грузоотправитель',
			style: 'position:absolute;left:107px;top:59px;width:204px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Грузополучатель',
			style: 'position:absolute;left:435px;top:57px;width:209px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'АдресДоставки',
			style: 'position:absolute;left:108px;top:83px;width:536px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДополнениеКАдресуДоставки',
			style: 'position:absolute;left:108px;top:108px;width:536px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьДоговор',
			text: 'Договор:',
			style: 'position:absolute;left:8px;top:105px;width:88px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'НадписьКонтрагент',
			text: 'Контрагент:',
			style: 'position:absolute;left:336px;top:81px;width:88px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДоговорКонтрагента',
			style: 'position:absolute;left:96px;top:105px;width:220px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Контрагент',
			style: 'position:absolute;left:425px;top:81px;width:233px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОрганизация',
			text: 'Организация:',
			style: 'position:absolute;left:8px;top:57px;width:88px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:96px;top:57px;width:220px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Заказ',
			style: 'position:absolute;left:96px;top:81px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьЗаказ',
			text: 'Заказ:',
			style: 'position:absolute;left:8px;top:81px;width:88px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Склад',
			style: 'position:absolute;left:425px;top:57px;width:233px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОтраженияВУчете',
			text: 'Отразить в:',
			style: 'position:absolute;left:336px;top:33px;width:88px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'ИнфНадписьДолга',
			text: 'По договору 250 USD, 1 USD = 30 руб.',
			style: 'position:absolute;left:336px;top:105px;width:304px;height:19px;text-align:right;',
		},
		{
			xtype: 'button',
			name: 'КнопкаПерерассчитатьДолг',
			text: '',
			style: 'position:absolute;left:643px;top:105px;width:15px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:375px;width:666px;height:25px;',
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					text:'Печать',
				},
				'-',
				{
					text:'ОК',
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
			xtype: 'checkbox',
			boxLabel: 'налог. учете',
			style: 'position:absolute;left:572px;top:33px;width:86px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ВидПередачи',
			style: 'position:absolute;left:336px;top:57px;width:88px;height:19px;',
		},
	]
});