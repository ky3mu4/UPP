﻿Ext.define('Справочники.КлючиАналитикиУчетаПрочихЗатрат.ФормаЭлемента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:610px;height:359px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Ключ аналитики учета прочих затрат',
	
	items:
	[
		{
			xtype: 'label',
			name: 'НадписьНаименование',
			text: 'Наименование:',
			style: 'position:absolute;left:8px;top:33px;width:86px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Наименование',
			style: 'position:absolute;left:95px;top:33px;width:506px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:610px;height:25px;',
			items:
			[
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:334px;width:610px;height:25px;',
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
			name: 'НадписьСчетУчета',
			text: 'Счет учета:',
			style: 'position:absolute;left:8px;top:212px;width:86px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СчетУчета',
			style: 'position:absolute;left:95px;top:212px;width:81px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСчетУчетаНУ',
			text: 'Счет учета (НУ):',
			style: 'position:absolute;left:309px;top:212px;width:92px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СчетУчетаНУ',
			style: 'position:absolute;left:401px;top:212px;width:81px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСубконто1',
			text: 'Субконто 1:',
			style: 'position:absolute;left:8px;top:238px;width:86px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСубконто2',
			text: 'Субконто 2:',
			style: 'position:absolute;left:8px;top:261px;width:86px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСубконто3',
			text: 'Субконто 3:',
			style: 'position:absolute;left:8px;top:286px;width:86px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Субконто1',
			style: 'position:absolute;left:95px;top:238px;width:200px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Субконто2',
			style: 'position:absolute;left:95px;top:261px;width:200px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Субконто3',
			style: 'position:absolute;left:95px;top:286px;width:200px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСубконтоНУ1',
			text: 'Субконто 1 (НУ):',
			style: 'position:absolute;left:309px;top:238px;width:92px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСубконтоНУ2',
			text: 'Субконто 2:',
			style: 'position:absolute;left:309px;top:261px;width:92px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСубконто6',
			text: 'Субконто 3:',
			style: 'position:absolute;left:309px;top:286px;width:92px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СубконтоНУ1',
			style: 'position:absolute;left:401px;top:238px;width:200px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СубконтоНУ2',
			style: 'position:absolute;left:401px;top:261px;width:200px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СубконтоНУ3',
			style: 'position:absolute;left:401px;top:286px;width:200px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОбъектСтроительства',
			text: 'Объект строительства:',
			style: 'position:absolute;left:8px;top:130px;width:86px;height:27px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ОбъектСтроительства',
			style: 'position:absolute;left:95px;top:134px;width:506px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСпособСтроительства',
			text: 'Способ строительства:',
			style: 'position:absolute;left:8px;top:158px;width:86px;height:27px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СпособСтроительства',
			style: 'position:absolute;left:95px;top:161px;width:506px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОрганизация',
			text: 'Организация:',
			style: 'position:absolute;left:8px;top:59px;width:86px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:95px;top:59px;width:506px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДатаИсправительнойЗаписи',
			text: 'Дата исправительной записи:',
			style: 'position:absolute;left:120px;top:84px;width:160px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДатаИсправительнойЗаписи',
			style: 'position:absolute;left:280px;top:84px;width:120px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: '',
			style: 'position:absolute;left:95px;top:84px;width:14px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИсправительнаяЗапись',
			text: 'Исправительная запись:',
			style: 'position:absolute;left:8px;top:79px;width:86px;height:30px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: '',
			style: 'position:absolute;left:8px;top:311px;width:14px;height:15px;',
		},
		{
			xtype: 'label',
			name: 'Надпись1',
			text: 'Считать разницы в оценке доходов и расходов постоянными',
			style: 'position:absolute;left:27px;top:311px;width:574px;height:15px;',
		},
	]
});