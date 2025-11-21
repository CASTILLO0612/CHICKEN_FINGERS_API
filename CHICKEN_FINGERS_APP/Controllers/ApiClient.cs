using CHICKEN_FINGERS.Dto;
using CHICKEN_FINGERS_APP.Models.Repository;
using CHICKEN_FINGERS_APP.Models.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CHICKEN_FINGERS_APP.Controllers
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;

        public IRepository<ClienteDto> Clientes { get; }
        public IUserRepository LoginUsers { get; } 

        public ApiClient()
        { 
            string apiBaseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"]!;
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(apiBaseUrl)
            };
            Clientes = new Repository<ClienteDto>(_httpClient, "Clientes");
            LoginUsers = new UserRepository(_httpClient, "Auth/login");
        }

        internal void SetAuthToken(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }
    }
}
