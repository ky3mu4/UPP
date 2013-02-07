
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;
using ServiceStack.ServiceClient.Web;
using V82.Справочники;

namespace V82.Rest.СправочникиТест
{
	public class ПерепискаСКонтролирующимиОрганами:V82.Rest.СправочникиТест.СправочникТест
	{
		public static void Получить()//Взять
		{
			var Урл = "http://localhost:1337/Catalogs/PerepiskaSKontroliruyushhimiOrganami/043735824?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var all = Клиент.Get(new PerepiskaSKontroliruyushhimiOrganamiRequest());
		}
		public static void ЗаписатьНовый()//Положить
		{
			var Урл = "http://localhost:1337/Catalogs/PerepiskaSKontroliruyushhimiOrganami/043735824?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var all = Клиент.Post(new PerepiskaSKontroliruyushhimiOrganamiRequest());
		}
		public static void Записать()//Обновить
		{
			var Урл = "http://localhost:1337/Catalogs/PerepiskaSKontroliruyushhimiOrganami/043735824?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var all = Клиент.Put(new PerepiskaSKontroliruyushhimiOrganamiRequest());
		}
		public static void Удалить()//
		{
			var Урл = "http://localhost:1337/Catalogs/PerepiskaSKontroliruyushhimiOrganami/043735824?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var all = Клиент.Delete(new PerepiskaSKontroliruyushhimiOrganamiRequest());
		}
	}
}