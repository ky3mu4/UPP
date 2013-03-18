﻿Ext.define('Документы.ВводПостоянногоНачисленияИлиУдержания.ФормаДокумента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:640px;height:578px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: '',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:640px;height:25px;',
			items:
			[
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:553px;width:640px;height:25px;',
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
			name: 'НадписьНомер',
			text: 'Номер:',
			style: 'position:absolute;left:8px;top:33px;width:84px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Номер',
			style: 'position:absolute;left:95px;top:33px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДата',
			text: 'от:',
			style: 'position:absolute;left:177px;top:33px;width:17px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Дата',
			style: 'position:absolute;left:195px;top:33px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКомментарий',
			text: 'Комментарий:',
			style: 'position:absolute;left:8px;top:526px;width:84px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Комментарий',
			style: 'position:absolute;left:92px;top:526px;width:540px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОтветственный',
			text: 'Ответственный:',
			style: 'position:absolute;left:326px;top:33px;width:84px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Ответственный',
			style: 'position:absolute;left:412px;top:33px;width:220px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:8px;top:237px;width:624px;height:24px;',
			items:
			[
				{
					text:'Списком сотрудников',
				},
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:262px;width:624px;height:258px;',
			height: 258,width: 624,
			columns:
			[
				{
					text:'№',
					width:'28',
				},
				{
					text:'Сотрудник',
					width:'120',
				},
				{
					text:'Показатель',
					width:'125',
				},
				{
					text:'Установлен',
					width:'80',
				},
				{
					text:'Установлена валюта',
					width:'45',
				},
				{
					text:'Показатель для ТР',
					width:'125',
				},
				{
					text:'Установлен тарифный разряд',
					width:'125',
				},
				{
					text:'Показатель',
					width:'125',
				},
				{
					text:'Установлен',
					width:'80',
				},
				{
					text:'Установлена валюта',
					width:'45',
				},
				{
					text:'Показатель для ТР',
					width:'125',
				},
				{
					text:'Установлен тарифный разряд',
					width:'125',
				},
				{
					text:'Показатель',
					width:'125',
				},
				{
					text:'Установлен',
					width:'80',
				},
				{
					text:'Установлена валюта',
					width:'45',
				},
				{
					text:'Показатель для ТР',
					width:'125',
				},
				{
					text:'Установлен тарифный разряд',
					width:'125',
				},
				{
					text:'Показатель',
					width:'125',
				},
				{
					text:'Установлен',
					width:'80',
				},
				{
					text:'Установлена валюта',
					width:'45',
				},
				{
					text:'Показатель для ТР',
					width:'125',
				},
				{
					text:'Установлен тарифный разряд',
					width:'125',
				},
				{
					text:'Показатель',
					width:'125',
				},
				{
					text:'Установлен',
					width:'80',
				},
				{
					text:'Установлена валюта',
					width:'45',
				},
				{
					text:'Показатель для ТР',
					width:'125',
				},
				{
					text:'Установлен тарифный разряд',
					width:'125',
				},
				{
					text:'Показатель',
					width:'125',
				},
				{
					text:'Установлен',
					width:'80',
				},
				{
					text:'Установлена валюта',
					width:'45',
				},
				{
					text:'Показатель для ТР',
					width:'125',
				},
				{
					text:'Установлен тарифный разряд',
					width:'125',
				},
				{
					text:'Документ основание',
					width:'100',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:85px;width:624px;height:127px;',
			height: 127,width: 624,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ВидРасчета',
			style: 'position:absolute;left:296px;top:32px;width:220px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДатаДействия',
			style: 'position:absolute;left:296px;top:78px;width:96px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДатаДействияКонец',
			style: 'position:absolute;left:420px;top:78px;width:96px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДатаНачала',
			text: 'с:',
			style: 'position:absolute;left:282px;top:78px;width:11px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'НадписьДатаДействияКонец',
			text: 'по:',
			style: 'position:absolute;left:397px;top:78px;width:20px;height:19px;text-align:left;',
		},
		{
			xtype: 'radio',
			boxLabel: 'Внести или изменить начисление ',
			style: 'position:absolute;left:18px;top:31px;width:221px;height:19px;',
		},
		{
			xtype: 'radio',
			boxLabel: 'Прекратить начисление',
			style: 'position:absolute;left:18px;top:54px;width:221px;height:19px;',
		},
		{
			xtype: 'radio',
			boxLabel: 'Внести или изменить удержание ',
			style: 'position:absolute;left:18px;top:77px;width:221px;height:19px;',
		},
		{
			xtype: 'radio',
			boxLabel: 'Прекратить удержание',
			style: 'position:absolute;left:18px;top:100px;width:221px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьПодразделение',
			text: 'Подразделение:',
			style: 'position:absolute;left:8px;top:59px;width:83px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Подразделение',
			style: 'position:absolute;left:95px;top:59px;width:220px;height:19px;',
		},
	]
});