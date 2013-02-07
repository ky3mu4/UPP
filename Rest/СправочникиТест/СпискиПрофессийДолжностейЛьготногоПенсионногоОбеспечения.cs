
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;
using ServiceStack.ServiceClient.Web;
using V82.Справочники;

namespace V82.Rest.СправочникиТест
{
	public class СпискиПрофессийДолжностейЛьготногоПенсионногоОбеспечения:V82.Rest.СправочникиТест.СправочникТест
	{
		public static void Получить()//Взять
		{
			var Урл = "http://localhost:1337/Catalogs/SpiskiProfessijjDolzhnostejjLgotnogoPensionnogoObespecheniya/043735824?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var all = Клиент.Get(new SpiskiProfessijjDolzhnostejjLgotnogoPensionnogoObespecheniyaRequest());
		}
		public static void ЗаписатьНовый()//Положить
		{
			var Урл = "http://localhost:1337/Catalogs/SpiskiProfessijjDolzhnostejjLgotnogoPensionnogoObespecheniya/043735824?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var all = Клиент.Post(new SpiskiProfessijjDolzhnostejjLgotnogoPensionnogoObespecheniyaRequest());
		}
		public static void Записать()//Обновить
		{
			var Урл = "http://localhost:1337/Catalogs/SpiskiProfessijjDolzhnostejjLgotnogoPensionnogoObespecheniya/043735824?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var all = Клиент.Put(new SpiskiProfessijjDolzhnostejjLgotnogoPensionnogoObespecheniyaRequest());
		}
		public static void Удалить()//
		{
			var Урл = "http://localhost:1337/Catalogs/SpiskiProfessijjDolzhnostejjLgotnogoPensionnogoObespecheniya/043735824?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var all = Клиент.Delete(new SpiskiProfessijjDolzhnostejjLgotnogoPensionnogoObespecheniyaRequest());
		}
	}
}