﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	///<summary>
	///(Общ)
	///</summary>
	[DataContract]
	public enum КодыОперацийПартииМатериаловВЭксплуатации
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"05b7e346-5438-40d1-8ebc-4091a0133439\", \"Представление\":\"СписаниеПартийВЭксплуатацию\"}")]
		СписаниеПартийВЭксплуатацию = 0,//Списание партий в эксплуатацию
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"a5b6eb61-d9af-4eae-9777-1d73c5e55a25\", \"Представление\":\"ВозвратИзЭксплуатации\"}")]
		ВозвратИзЭксплуатации = 1,//Возврат из эксплуатации
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"5c9a30ea-a4f3-4597-8143-f96e57512a31\", \"Представление\":\"СписаниеИзЭксплуатации\"}")]
		СписаниеИзЭксплуатации = 2,//Списание из эксплуатации
		[EnumMember(Value = "{\"Ссылка\":\"52423b29-b3c2-4353-bf19-107dd6946ce0\", \"Представление\":\"ПогашениеСтоимости\"}")]
		ПогашениеСтоимости = 3,//Погашение стоимости
		[EnumMember(Value = "{\"Ссылка\":\"dcede0f6-77d2-4909-91cb-9fc4fd001b6b\", \"Представление\":\"ПеремещениеВЭксплуатации\"}")]
		ПеремещениеВЭксплуатации = 4,//Перемещение в эксплуатации
		[EnumMember(Value = "{\"Ссылка\":\"3c5356ee-6cfd-4112-a509-b9e59c9e8e2d\", \"Представление\":\"ПередачаМатериаловВЭксплуатацию\"}")]
		ПередачаМатериаловВЭксплуатацию = 5,//Передача материалов в эксплуатацию
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"6513f5d0-e0d3-48d7-91e4-822cc5e43eda\", \"Представление\":\"ВозвратИзЭксплуатацииФикс\"}")]
		ВозвратИзЭксплуатацииФикс = 6,//Возврат из эксплуатации по фиксированной стоимости
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"64559c4e-5040-479b-838f-07d589a6c96e\", \"Представление\":\"СписаниеИзЭксплуатацииФикс\"}")]
		СписаниеИзЭксплуатацииФикс = 7,//Списание из эксплуатации по фиксированной стоимости
		[EnumMember(Value = "{\"Ссылка\":\"380ca349-852d-4a5f-b271-892a6f1c779e\", \"Представление\":\"ПеремещениеВЭксплуатацииФикс\"}")]
		ПеремещениеВЭксплуатацииФикс = 8,//Перемещение в эксплуатации по фиксированной стоимости
	}
	public static partial class КодыОперацийПартииМатериаловВЭксплуатации_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid СписаниеПартийВЭксплуатацию = new Guid("9140bc8e-13a0-3934-40d1-543805b7e346");//Списание партий в эксплуатацию
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ВозвратИзЭксплуатации = new Guid("731d7797-e5c5-255a-4eae-d9afa5b6eb61");//Возврат из эксплуатации
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid СписаниеИзЭксплуатации = new Guid("6ef94381-5157-312a-4597-a4f35c9a30ea");//Списание из эксплуатации
		public static readonly Guid ПогашениеСтоимости = new Guid("7d1019bf-94d6-e06c-4353-b3c252423b29");//Погашение стоимости
		public static readonly Guid ПеремещениеВЭксплуатации = new Guid("c49fcb91-00fd-6b1b-4909-77d2dcede0f6");//Перемещение в эксплуатации
		public static readonly Guid ПередачаМатериаловВЭксплуатацию = new Guid("e5b909a5-9e9c-2d8e-4112-6cfd3c5356ee");//Передача материалов в эксплуатацию
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ВозвратИзЭксплуатацииФикс = new Guid("2c82e491-e4c5-da3e-48d7-e0d36513f5d0");//Возврат из эксплуатации по фиксированной стоимости
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid СписаниеИзЭксплуатацииФикс = new Guid("d5078f83-a689-6ec9-479b-504064559c4e");//Списание из эксплуатации по фиксированной стоимости
		public static readonly Guid ПеремещениеВЭксплуатацииФикс = new Guid("2a8971b2-1c6f-9e77-4a5f-852d380ca349");//Перемещение в эксплуатации по фиксированной стоимости
		public static КодыОперацийПартииМатериаловВЭксплуатации Получить(this КодыОперацийПартииМатериаловВЭксплуатации Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static КодыОперацийПартииМатериаловВЭксплуатации Получить(this КодыОперацийПартииМатериаловВЭксплуатации Значение, Guid Ссылка)
		{
			if(Ссылка == СписаниеПартийВЭксплуатацию)
			{
				return КодыОперацийПартииМатериаловВЭксплуатации.СписаниеПартийВЭксплуатацию;
			}
			else if(Ссылка == ВозвратИзЭксплуатации)
			{
				return КодыОперацийПартииМатериаловВЭксплуатации.ВозвратИзЭксплуатации;
			}
			else if(Ссылка == СписаниеИзЭксплуатации)
			{
				return КодыОперацийПартииМатериаловВЭксплуатации.СписаниеИзЭксплуатации;
			}
			else if(Ссылка == ПогашениеСтоимости)
			{
				return КодыОперацийПартииМатериаловВЭксплуатации.ПогашениеСтоимости;
			}
			else if(Ссылка == ПеремещениеВЭксплуатации)
			{
				return КодыОперацийПартииМатериаловВЭксплуатации.ПеремещениеВЭксплуатации;
			}
			else if(Ссылка == ПередачаМатериаловВЭксплуатацию)
			{
				return КодыОперацийПартииМатериаловВЭксплуатации.ПередачаМатериаловВЭксплуатацию;
			}
			else if(Ссылка == ВозвратИзЭксплуатацииФикс)
			{
				return КодыОперацийПартииМатериаловВЭксплуатации.ВозвратИзЭксплуатацииФикс;
			}
			else if(Ссылка == СписаниеИзЭксплуатацииФикс)
			{
				return КодыОперацийПартииМатериаловВЭксплуатации.СписаниеИзЭксплуатацииФикс;
			}
			else if(Ссылка == ПеремещениеВЭксплуатацииФикс)
			{
				return КодыОперацийПартииМатериаловВЭксплуатации.ПеремещениеВЭксплуатацииФикс;
			}
			return КодыОперацийПартииМатериаловВЭксплуатации.ПустаяСсылка;
		}
		public static byte[] Ключ(this КодыОперацийПартииМатериаловВЭксплуатации Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this КодыОперацийПартииМатериаловВЭксплуатации Значение)
		{
			switch (Значение)
			{
				case КодыОперацийПартииМатериаловВЭксплуатации.СписаниеПартийВЭксплуатацию: return СписаниеПартийВЭксплуатацию;
				case КодыОперацийПартииМатериаловВЭксплуатации.ВозвратИзЭксплуатации: return ВозвратИзЭксплуатации;
				case КодыОперацийПартииМатериаловВЭксплуатации.СписаниеИзЭксплуатации: return СписаниеИзЭксплуатации;
				case КодыОперацийПартииМатериаловВЭксплуатации.ПогашениеСтоимости: return ПогашениеСтоимости;
				case КодыОперацийПартииМатериаловВЭксплуатации.ПеремещениеВЭксплуатации: return ПеремещениеВЭксплуатации;
				case КодыОперацийПартииМатериаловВЭксплуатации.ПередачаМатериаловВЭксплуатацию: return ПередачаМатериаловВЭксплуатацию;
				case КодыОперацийПартииМатериаловВЭксплуатации.ВозвратИзЭксплуатацииФикс: return ВозвратИзЭксплуатацииФикс;
				case КодыОперацийПартииМатериаловВЭксплуатации.СписаниеИзЭксплуатацииФикс: return СписаниеИзЭксплуатацииФикс;
				case КодыОперацийПартииМатериаловВЭксплуатации.ПеремещениеВЭксплуатацииФикс: return ПеремещениеВЭксплуатацииФикс;
			}
			return Guid.Empty;
		}
	}
}