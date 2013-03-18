﻿Ext.define('Обработки.КалендарьБухгалтера.ФормаКалендаря',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:669px;height:571px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Календарь бухгалтера',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:669px;height:25px;',
			items:
			[
				{
					text:'Обновить',
				},
				'-',
				{
					text:'День',
				},
				'-',
				{
					text:'Неделя',
				},
				'-',
				{
					text:'Действие1',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:546px;width:669px;height:25px;',
			items:
			[
				{
					xtype: 'tbfill'
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьДляОрганизации',
			text: 'Для организации:',
			style: 'position:absolute;left:8px;top:33px;width:99px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДляОрганизации',
			style: 'position:absolute;left:110px;top:33px;width:180px;height:19px;',
		},
		{
			xtype: 'combobox',
			style: 'position:absolute;left:532px;top:91px;width:130px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьГод',
			text: 'Год:',
			style: 'position:absolute;left:533px;top:66px;width:23px;height:15px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Год',
			style: 'position:absolute;left:573px;top:63px;width:89px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:63px;width:514px;height:480px;',
			height: 480,width: 514,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'День',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:6px;width:502px;height:469px;',
			height: 469,width: 502,
			columns:
			[
				{
					text:'',
					width:'21',
				},
				{
					text:'В срок до',
					width:'63',
				},
				{
					text:'Период',
					width:'85',
				},
				{
					text:'Название отчета/налога',
					width:'250',
				},
				{
					text:'Налогоплательщик',
					width:'250',
				},
			]
		},
					]
				},
				{
					title:'Неделя',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:295px;top:28px;width:218px;height:24px;',
			items:
			[
				{
					text:'Открыть',
				},
				{
					text:'Оповещение',
				},
				{
					text:'Перейти к дате',
				},
			]
		},
		{
			xtype: 'label',
			name: 'Надпись1',
			text: '  Сдача отчетности',
			style: 'position:absolute;left:522px;top:450px;width:140px;height:21px;',
		},
		{
			xtype: 'label',
			name: 'Надпись2',
			text: '  Уплата налога',
			style: 'position:absolute;left:522px;top:474px;width:140px;height:21px;',
		},
		{
			xtype: 'label',
			name: 'Надпись3',
			text: '  Ближайшее событие',
			style: 'position:absolute;left:522px;top:498px;width:140px;height:21px;',
		},
		{
			xtype: 'label',
			name: 'Надпись4',
			text: '  Напомнить',
			style: 'position:absolute;left:522px;top:522px;width:140px;height:21px;',
		},
	]
});