using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Order.Domain.Interfaces.Services;
using Order.Domain.Models;
using Order.Domain.Interfaces.Repositories;
using Order.Domain.Validations;
using Order.Domain.Validations.Base;

namespace Order.Domain.Services
{
    public class ClientService : IClientService
    {

        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public async Task<Response> CreateAsync(ClientModel client)
        {
            var response = new Response();
            var validation = new ClientValidations();
            var errors = validation.Validate(client).GetErrors();

            if (errors.Report.Count > 0)
                return errors;

            await _clientRepository.CreateAsync(client);
            return response;
        }

        public async Task<Response> DeleteAsync(string idClient)
        {
            var response = new Response();

            var exists = await _clientRepository.ExistsByIdyAsync(idClient);
            if (!exists)
            {
                response.Report.Add(Report.Create($"Client {idClient} not exists!"));
                return response;
            }

            await _clientRepository.DeleteAsync(idClient);
            return response;
        }

        public async Task<Response<ClientModel>> GetByIdAsync(string idClient)
        {
            var response = new Response<ClientModel>();

            var exists = await _clientRepository.ExistsByIdyAsync(idClient);
            if (!exists)
            {
                response.Report.Add(Report.Create($"Client {idClient} not exists!"));
                return response;
            }

            var data = await _clientRepository.GetByIdAsync(idClient);
            response.Data = data;
            return response;
        }

        public async Task<Response<List<ClientModel>>> ListByFilterIdAsync(string idClient = null, string name = null)
        {
            var response = new Response<List<ClientModel>>();

            if (!string.IsNullOrWhiteSpace(idClient))
            {
                var exists = await _clientRepository.ExistsByIdyAsync(idClient);
                if (!exists)
                {
                    response.Report.Add(Report.Create($"Client {idClient} not exists!"));
                    return response;
                }
            }
            var data = await _clientRepository.ListByFilterAsync(idClient, name);
            response.Data = data;
            return response;
        }

        public async Task<Response> UpdadeAsync(ClientModel client)
        {
            var response = new Response();
            var validation = new ClientValidations();
            var errors = validation.Validate(client).GetErrors();

            if (errors.Report.Count > 0)
                return errors;

            var exists = await _clientRepository.ExistsByIdyAsync(client.Id);
            if (!exists)
            {
                response.Report.Add(Report.Create($"Client {client.Id} not exists!"));
                return response;
            }

            await _clientRepository.UpdadeAsync(client);
            return response;
        }
    }
}