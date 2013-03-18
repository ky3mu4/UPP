﻿Ext.define('Отчеты.СведенияОРасходахНаПроизводствоИПродажуПродукции.ФормаВыгрузкаСведенийОЗатратах',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:298px;height:132px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Выгрузка сведений о затратах предприятия',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:106px;width:298px;height:25px;',
			items:
			[
				{
					xtype: 'tbfill'
				},
				'-',
				{
					text:'Выполнить',
				},
				'-',
				{
					text:'Закрыть',
				},
			]
		},
		{
			xtype: 'label',
			name: 'ТекстПутьКФайлуВыгрузки',
			text: 'Путь к файлу выгрузки:',
			style: 'position:absolute;left:8px;top:9px;width:181px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПутьКФайлуВыгрузки',
			style: 'position:absolute;left:8px;top:34px;width:282px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Инд',
			text: ' ',
			style: 'position:absolute;left:205px;top:57px;width:85px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'ТекстВыгружено',
			text: 'Выгружено:',
			style: 'position:absolute;left:8px;top:57px;width:160px;height:19px;text-align:left;',
		},
	]
});