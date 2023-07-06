using RestSharp;

namespace MauiShell
{
    internal class Data
    {
        private string _baseUrl = "https://redsixapidev.pdsglobal.com";
        //private string _baseUrl = "http://192.168.1.6:7230";


        public async Task<SocialFeedPayload> GetUserFeed()
        {
            var res = await GetAsync<SocialFeedPayload>(_baseUrl, "RedSix/GetUserFeed2");
            return res;
        }

        public async Task<T> GetAsync<T>(string baseUrl, string endpointPath)
        {
            var request = new RestRequest(endpointPath, Method.Get);


            try
            {
                RestClient restClient = new RestClient(baseUrl);

                if (Connectivity.Current.NetworkAccess != NetworkAccess.None)
                {
                    var response = await restClient.GetAsync<T>(request);
                    return response;
                }
                else
                    throw new Exception("Oops");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                throw;
            }
        }

    }
}
