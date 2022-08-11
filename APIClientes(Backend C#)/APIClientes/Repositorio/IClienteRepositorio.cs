using APIClientes.Modelos.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIClientes.Repositorio
{
    public interface IClienteRepositorio
    {
        Task<List<ClienteDto>> GetCliente();
        Task<ClienteDto> GetClienteById(int id);
        Task<ClienteDto> CreateUpdate(ClienteDto clienteDto);
        Task<bool> DeleteCliente(int id);
    }
}
