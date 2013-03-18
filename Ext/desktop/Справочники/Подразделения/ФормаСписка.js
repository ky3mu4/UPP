﻿Ext.define('Справочники.Подразделения.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:858px;height:580px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Структура предприятия',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:858px;height:25px;',
			items:
			[
				{
					text:'Закрыть',
				},
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:82px;width:410px;height:490px;',
			height: 490,width: 410,
			columns:
			[
				{
					text:'Наименование',
					width:'181',
				},
				{
					text:'Код',
					width:'76',
				},
				{
					text:'Подразделения юридических лиц',
					width:'207',
				},
				{
					text:'Порядок',
					width:'100',
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьСтруктураПредприятия',
			text: ' Структура Предприятия',
			style: 'position:absolute;left:8px;top:33px;width:410px;height:20px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСтруктураПодразделенийОрганизаций',
			text: ' Подразделения организаций (юридических лиц)',
			style: 'position:absolute;left:433px;top:33px;width:417px;height:20px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:433px;top:58px;width:322px;height:24px;',
			items:
			[
				{
					text:'Упорядочить по: Код',
				},
				{
					text:'Упорядочить по: Наименование',
				},
				{
					text:'Упорядочить по: Порядок',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:8px;top:58px;width:410px;height:24px;',
			items:
			[
				'-',
				{
					text:'Изменить',
				},
				{
					text:'',
				},
				'-',
				'-',
				{
					text:'',
				},
				{
					text:'',
				},
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:433px;top:82px;width:417px;height:490px;',
			height: 490,width: 417,
			columns:
			[
				{
					text:'Организация',
					width:'137',
				},
				{
					text:'Наименование',
					width:'195',
				},
				{
					text:'Код',
					width:'65',
				},
				{
					text:'Подразделения',
					width:'135',
				},
				{
					text:'Несколько подразделений',
					width:'100',
				},
				{
					text:'Порядок',
					width:'49',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:755px;top:58px;width:95px;height:24px;',
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					text:'Организации...',
				},
			]
		},
	]
});