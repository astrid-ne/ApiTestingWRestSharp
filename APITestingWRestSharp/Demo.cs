using Newtonsoft.Json;
using RestSharp;


namespace APITestingWRestSharp;
public class Demo
{
    public ListOfUsersDTO GetUsers()
    {
        var restClient = new RestClient("https://reqres.in/");
        var restRequest = new RestRequest("api/users?page=2", Method.Get);
        restRequest.AddHeader("Accept", "application/json");
        restRequest.RequestFormat = DataFormat.Json;

        var response = restClient.Execute(restRequest); //response.content=""
        var content = response.Content;

        ListOfUsersDTO users = JsonConvert.DeserializeObject<ListOfUsersDTO>(content);
        return users;
    }

}


