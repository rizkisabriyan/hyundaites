using hyundaiClient.Models;
using Newtonsoft.Json;
using System.Net;
using System.Security.Policy;
using System.Text;

namespace hyundaiClient
{
    public class APIGateway
    {
        private string url = "http://localhost:5178/api/Customer";
        private string url2 = "http://localhost:5178/api/Cars";
        private HttpClient httpClient = new HttpClient();

        public List<Customer> ListCustomers()
        {
            List<Customer> customers = new List<Customer>(); 
            if(url.Trim().Substring(0, 5).ToLower() == "https")
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            try
            {
                HttpResponseMessage response = httpClient.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    String result = response.Content.ReadAsStringAsync().Result;
                    var datacol = JsonConvert.DeserializeObject<List<Customer>>(result);
                    if (datacol != null)
                        customers = datacol;
                }
                else
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    throw new Exception("Error Occured at the API endpoint, Error info. " + result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured at the API endpoint, Error info. " + ex.Message);
            }
            finally { }

            return customers;
        }

        public Customer CreateCustomer(Customer customer)
        {
            if (url.Trim().Substring(0, 5).ToLower() == "https")
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string json = JsonConvert.SerializeObject(customer);
            try
            {
                HttpResponseMessage response = httpClient.PostAsync(url, new StringContent(json, Encoding.UTF8, "application/json")).Result;
                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    var data = JsonConvert.DeserializeObject<Customer>(result);
                    if (data != null)
                        customer = data;
                }
                else
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    throw new Exception("Error Occured at the API endpoint, Error info. " + result);
                }
            }
            catch(Exception ex) 
            { 
                throw new Exception("Error Occured at the API endpoint, Error info. " + ex.Message); 
            }
            finally { }
            return customer;
        }


        public Customer GetCustomer(int id)
        {
            Customer customer = new Customer();
            url = url + "/" + id;
            if (url.Trim().Substring(0, 5).ToLower() == "https")
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            try
            {
                HttpResponseMessage response = httpClient.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    String result = response.Content.ReadAsStringAsync().Result;
                    var data = JsonConvert.DeserializeObject<Customer>(result);
                    if (data != null)
                        customer = data;
                }
                else
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    throw new Exception("Error Occured at the API endpoint, Error info. " + result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured at the API endpoint, Error info. " + ex.Message);
            }
            finally { }

            return customer;
        }


        public void UpdateCustomer(Customer customer)
        {
            if (url.Trim().Substring(0, 5).ToLower() == "https")
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            int id = customer.id;
            url = url + "/" + id;
            string json = JsonConvert.SerializeObject(customer);
            try
            {
                HttpResponseMessage response = httpClient.PutAsync(url, new StringContent(json, Encoding.UTF8, "application/json")).Result;
                if (!response.IsSuccessStatusCode)
                {
                    String result = response.Content.ReadAsStringAsync().Result;
                    throw new Exception("Error Occured at the API endpoint, Error info. " + result);
                }
            }
            catch (Exception ex)
            {
                //throw new Exception("Error Occured at the API endpoint, Error info. " + ex.Message);
            }
            finally { }

            return;
        }



        public void DeleteCustomer(int id)
        {
            if (url.Trim().Substring(0, 5).ToLower() == "https")
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            url = url + "/" + id;
            try
            {
                HttpResponseMessage response = httpClient.DeleteAsync(url).Result;
                if (!response.IsSuccessStatusCode)
                {
                    String result = response.Content.ReadAsStringAsync().Result;
                    throw new Exception("Error Occured at the API endpoint, Error info. " + result);
                }
            }
            catch (Exception ex)
            {
                //throw new Exception("Error Occured at the API endpoint, Error info. " + ex.Message);
            }
            finally { }

            return;
        }


        public List<Cars> ListCars()
        {
            List<Cars> cars = new List<Cars>();
            if (url2.Trim().Substring(0, 5).ToLower() == "https")
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            try
            {
                HttpResponseMessage response = httpClient.GetAsync(url2).Result;
                if (response.IsSuccessStatusCode)
                {
                    String result = response.Content.ReadAsStringAsync().Result;
                    var datacol = JsonConvert.DeserializeObject<List<Cars>>(result);
                    if (datacol != null)
                        cars = datacol;
                }
                else
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    throw new Exception("Error Occured at the API endpoint, Error info. " + result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured at the API endpoint, Error info. " + ex.Message);
            }
            finally { }

            return cars;
        }

        public Cars CreateCars(Cars cars)
        {
            if (url2.Trim().Substring(0, 5).ToLower() == "https")
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string json = JsonConvert.SerializeObject(cars);
            try
            {
                HttpResponseMessage response = httpClient.PostAsync(url2, new StringContent(json, Encoding.UTF8, "application/json")).Result;
                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    var data = JsonConvert.DeserializeObject<Cars>(result);
                    if (data != null)
                        cars = data;
                }
                else
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    throw new Exception("Error Occured at the API endpoint, Error info. " + result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured at the API endpoint, Error info. " + ex.Message);
            }
            finally { }
            return cars;
        }


        public Cars GetCars(int id)
        {
            Cars cars = new Cars();
            url2 = url2 + "/" + id;
            if (url2.Trim().Substring(0, 5).ToLower() == "https")
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            try
            {
                HttpResponseMessage response = httpClient.GetAsync(url2).Result;
                if (response.IsSuccessStatusCode)
                {
                    String result = response.Content.ReadAsStringAsync().Result;
                    var data = JsonConvert.DeserializeObject<Cars>(result);
                    if (data != null)
                        cars = data;
                }
                else
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    throw new Exception("Error Occured at the API endpoint, Error info. " + result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured at the API endpoint, Error info. " + ex.Message);
            }
            finally { }

            return cars;
        }


        public void UpdateCars(Cars cars)
        {
            if (url2.Trim().Substring(0, 5).ToLower() == "https")
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            int id = cars.id;
            url2 = url2 + "/" + id;
            string json = JsonConvert.SerializeObject(cars);
            try
            {
                HttpResponseMessage response = httpClient.PutAsync(url2, new StringContent(json, Encoding.UTF8, "application/json")).Result;
                if (!response.IsSuccessStatusCode)
                {
                    String result = response.Content.ReadAsStringAsync().Result;
                    throw new Exception("Error Occured at the API endpoint, Error info. " + result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured at the API endpoint, Error info. " + ex.Message);
            }
            finally { }

            return;
        }



        public void DeleteCars(int id)
        {
            if (url2.Trim().Substring(0, 5).ToLower() == "https")
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            url2 = url2 + "/" + id;
            try
            {
                HttpResponseMessage response = httpClient.DeleteAsync(url2).Result;
                if (!response.IsSuccessStatusCode)
                {
                    String result = response.Content.ReadAsStringAsync().Result;
                    throw new Exception("Error Occured at the API endpoint, Error info. " + result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured at the API endpoint, Error info. " + ex.Message);
            }
            finally { }

            return;
        }


    }
}
