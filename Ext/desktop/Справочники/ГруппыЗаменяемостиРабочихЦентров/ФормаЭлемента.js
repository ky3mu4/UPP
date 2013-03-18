﻿Ext.define('Справочники.ГруппыЗаменяемостиРабочихЦентров.ФормаЭлемента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:430px;height:353px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Группы заменяемости рабочих центров',
	
	items:
	[
		{
			xtype: 'label',
			name: 'НадписьКод',
			text: 'Код:',
			style: 'position:absolute;left:316px;top:33px;width:40px;height:19px;text-align:center;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Код',
			style: 'position:absolute;left:358px;top:33px;width:64px;height:19px;',
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
			style: 'position:absolute;left:94px;top:33px;width:220px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:430px;height:25px;',
			items:
			[
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:328px;width:430px;height:25px;',
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
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:60px;width:414px;height:260px;',
			height: 260,width: 414,
			items:
			[
				{
					title:'Состав группы',
					items:
					[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:6px;top:6px;width:400px;height:24px;',
			items:
			[
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:32px;width:400px;height:202px;',
			height: 202,width: 400,
			columns:
			[
				{
					text:'N',
					width:'28',
				},
				{
					text:'Рабочий центр',
					width:'200',
				},
				{
					text:'Приоритет применение рабочего центра',
					width:'100',
				},
			]
		},
					]
				},
				{
					title:'Подчиненные рабочие центры',
					items:
					[
		{
			xtype: 'checkbox',
			boxLabel: 'Требуется загрузка подчиненных рабочих центров',
			style: 'position:absolute;left:6px;top:6px;width:400px;height:15px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:53px;width:400px;height:181px;',
			height: 181,width: 400,
			columns:
			[
				{
					text:'N',
					width:'28',
				},
				{
					text:'Рабочий центр',
					width:'200',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:6px;top:26px;width:400px;height:24px;',
			items:
			[
			]
		},
					]
				},
			]
		},
	]
});