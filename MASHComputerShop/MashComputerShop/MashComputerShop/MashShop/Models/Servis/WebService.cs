using MashComputerShop.MashShop.Models.User;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Json;
using Windows.UI.Popups;
using Windows.Web.Http;
using Windows.Web.Http.Headers;

namespace MashComputerShop.MashShop.Models.Servis
{
    class WebService
    {
        public static string serviceURL = "http://localhost:63073/";
        public static string productServicePage = "api/ProductService/";
        public static string userServicePage = "api/RegisteredUserService/";

        private List<RegisteredUser> registeredUsers;
        public List<RegisteredUser> RegisteredUsers
        {
            get { return registeredUsers; }
            set { registeredUsers = value; }
        }

        private List<Product> products;
        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        RegisteredUser User { get; set; }
        Product Product { get; set; }


        public WebService() { }

    
        // Post zahtjev prema servisu za dodavanje novog korisnika
        public async void addNewUser(RegisteredUser newUser)
        {
            string userID = newUser.Id.ToString();
            string resourceAdress = serviceURL + userServicePage;
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Accept.Add(new HttpMediaTypeWithQualityHeaderValue("application/json"));

                string jsonContents = JsonConvert.SerializeObject(newUser);
                Debug.Write(jsonContents);

                HttpResponseMessage response = await httpClient.PostAsync(new Uri(resourceAdress), new HttpStringContent(jsonContents, Windows.Storage.Streams.UnicodeEncoding.Utf8, "application/json"));

            } catch(System.Runtime.InteropServices.COMException e)
            {
                var dialog = new MessageDialog("Nije uspostavljena konekcija sa web servisom. Potrebno je pokrenuti web servis DatabaseService.sln za pravilan rad aplikacije.", "Web servis nije pronadjen");
                await dialog.ShowAsync();
            }
        }


        public async void getAllUsers(Action callback)
        {
            // Alociranje liste za cuvanje korisnika
            registeredUsers = new List<RegisteredUser>();

            string resourceAdress = serviceURL + userServicePage;

            try
            {
                HttpClient httpClient = new HttpClient();
                string response = await httpClient.GetStringAsync(new Uri(resourceAdress));
                

                JsonArray value = JsonValue.Parse(response).GetArray();

                for (uint i = 0; i < value.Count; i++)
                {
                    RegisteredUser novi = new RegisteredUser();
                    JsonObject jObject = value.GetObjectAt(i);

                    novi.Id = Convert.ToInt32(value.GetObjectAt(i).GetNamedNumber("Id"));

                    IJsonValue jsonValue;

                    if (value.GetObjectAt(i).TryGetValue("FirstName", out jsonValue))
                        novi.FirstName = jsonValue.GetString();
                    if (value.GetObjectAt(i).TryGetValue("LastName", out jsonValue))
                        novi.LastName = jsonValue.GetString();
                    if (value.GetObjectAt(i).TryGetValue("Username", out jsonValue))
                        novi.Username = jsonValue.GetString();
                    if (value.GetObjectAt(i).TryGetValue("Password", out jsonValue))
                        novi.Password = jsonValue.GetString();
                    if (value.GetObjectAt(i).TryGetValue("Email", out jsonValue))
                        novi.Email = jsonValue.GetString();
                    if (value.GetObjectAt(i).TryGetValue("Address", out jsonValue))
                        novi.Address = jsonValue.GetString();
                    if (value.GetObjectAt(i).TryGetValue("TelephoneNumber", out jsonValue))
                        novi.TelephoneNumber = jsonValue.GetString();
                    if (value.GetObjectAt(i).TryGetValue("CreditCard", out jsonValue))
                        novi.CreditCard = "";
                    if (value.GetObjectAt(i).TryGetValue("ProfileImage", out jsonValue))
                        novi.ProfileImage = jsonValue.GetString();

                    registeredUsers.Add(novi);
                }

                callback();
            }catch(System.Runtime.InteropServices.COMException e)
            {
                //var dialog = new MessageDialog("Nije uspostavljena konekcija sa web servisom. Potrebno je pokrenuti web servis DatabaseService.sln za pravilan rad aplikacije.", "Web servis nije pronadjen");
                //await dialog.ShowAsync();

            }
        }


        // Metoda za dobavljanje korisnika sa datim ID-em
        public async void getUser(int UserId, Action callback)
        {
            try
            {
                string resourceAdress = serviceURL + userServicePage + UserId.ToString();

                HttpClient httpClient = new HttpClient();
                string response = await httpClient.GetStringAsync(new Uri(resourceAdress));

                JsonObject value = JsonValue.Parse(response).GetObject();

                User = new RegisteredUser();
                User.Id = Convert.ToInt32(value.GetNamedNumber("Id"));

                IJsonValue jsonValue;

                if (value.TryGetValue("FirstName", out jsonValue))
                    User.FirstName = jsonValue.GetString();
                if (value.TryGetValue("LastName", out jsonValue))
                    User.LastName = jsonValue.GetString();
                if (value.TryGetValue("Username", out jsonValue))
                    User.Username = jsonValue.GetString();
                if (value.TryGetValue("Password", out jsonValue))
                    User.Password = jsonValue.GetString();
                if (value.TryGetValue("Email", out jsonValue))
                    User.Email = jsonValue.GetString();
                if (value.TryGetValue("Address", out jsonValue))
                    User.Address = jsonValue.GetString();
                if (value.TryGetValue("TelephoneNumber", out jsonValue))
                    User.TelephoneNumber = jsonValue.GetString();
                if (value.TryGetValue("CreditCard", out jsonValue))
                    User.CreditCard = jsonValue.GetString();
                if (value.TryGetValue("ProfileImage", out jsonValue))
                    User.ProfileImage = jsonValue.GetString();
                

                callback();
            }catch(System.Runtime.InteropServices.COMException e)
            {
                var dialog = new MessageDialog("Nije uspostavljena konekcija sa web servisom. Potrebno je pokrenuti web servis DatabaseService.sln za pravilan rad aplikacije.", "Web servis nije pronadjen");
                await dialog.ShowAsync();

            }
        }
        


        public async void getAllProducts(Action callback)
        {
            // Alociranje liste za cuvanje korisnika
            products = new List<Product>();

            string resourceAdress = serviceURL + productServicePage;

            try
            {
                HttpClient httpClient = new HttpClient();
                string response = await httpClient.GetStringAsync(new Uri(resourceAdress));


                JsonArray value = JsonValue.Parse(response).GetArray();

                for (uint i = 0; i < value.Count; i++)
                {
                    Product novi = new Product();
                    JsonObject jObject = value.GetObjectAt(i);

                    novi.Id = Convert.ToInt32(value.GetObjectAt(i).GetNamedNumber("Id"));

                    IJsonValue jsonValue;

                    if (value.GetObjectAt(i).TryGetValue("ProductType", out jsonValue))
                        novi.ProductType = jsonValue.GetString();
                    if (value.GetObjectAt(i).TryGetValue("Name", out jsonValue))
                        novi.Name = jsonValue.GetString();
                    if (value.GetObjectAt(i).TryGetValue("Price", out jsonValue))
                        novi.Price = jsonValue.GetString();
                    if (value.GetObjectAt(i).TryGetValue("ProductImage", out jsonValue))
                        novi.ProductImage = jsonValue.GetString();
                    if (value.GetObjectAt(i).TryGetValue("Description", out jsonValue))
                        novi.Description = jsonValue.GetString();
                    if (value.GetObjectAt(i).TryGetValue("QuantityInStorage", out jsonValue))
                        novi.QuantityInStorage = jsonValue.GetString();
                    if (value.GetObjectAt(i).TryGetValue("QuantityInStorage", out jsonValue))
                        novi.Grade = Convert.ToInt32(jsonValue.GetString());

                    products.Add(novi);
                }

                callback();
            }catch(System.Runtime.InteropServices.COMException e)
            {
                var dialog = new MessageDialog("Nije uspostavljena konekcija sa web servisom. Potrebno je pokrenuti web servis DatabaseService.sln za pravilan rad aplikacije.", "Web servis nije pronadjen");
                await dialog.ShowAsync();

            }
        }
    }
}
