using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace check

{

    public class AzureClient
    {
        private IMobileServiceClient client;
        private IMobileServiceTable<LISTA> table;

        public AzureClient()
        {
            client = new MobileServiceClient("http://stevendiplomado.azurewebsites.net");
        }

        public Task<IEnumerable<LISTA>> GetActivities()
        {
            return table.ToEnumerableAsync();
        }

    }
}
