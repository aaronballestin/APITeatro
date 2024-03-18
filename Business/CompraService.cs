using TeatroApi.Data;
using TeatroApi.Models;

namespace TeatroApi.Business
{
    public class CompraService : ICompraService
    {
        private readonly ICompraRepository _repository;

        public CompraService(ICompraRepository repository)
        {
            _repository = repository;
        }

        public List<Compra> GetComprasBySesion(int sesionId)
        {
            return _repository.GetComprasBySesion(sesionId);
        }


        public List<Compra> GetComprasByUsuario(int usuarioId)
        {
            return _repository.GetComprasByUsuario(usuarioId);
        }

        public int AddCompra(CompraDTO compraDTO)
        {
            try
            {
                // Aquí puedes agregar lógica para validar la compra antes de realizarla,
                // como verificar la disponibilidad de asientos, calcular el precio total, etc.

                // Por simplicidad, simplemente guardamos la compra en la base de datos
                var compra = new Compra
                {
                    SesionId = compraDTO.SesionId,
                    // Aquí podrías agregar más propiedades según sea necesario
                };

                _repository.AddCompra(compra);
                _repository.SaveChanges();

                // Una vez que la compra se ha realizado con éxito, puedes devolver la compra creada
                return 1;
            }
            catch (Exception ex)
            {
                // Si ocurre algún error durante la realización de la compra, lo capturamos y devolvemos un resultado de error
                // return ServiceResult<CompraDTO>.Failure($"Error al realizar la compra: {ex.Message}");
                throw;
            }
        }

        public CompraDTO GetCompra(int compraId)
        {
            try
            {
                var compra = _repository.GetCompra(compraId);
                if (compra == null)
                {
                
                }

                // Mapear la entidad Compra a un DTO CompraDTO y devolverla
                var compraDTO = new CompraDTO
                {
                    CompraId = compra.CompraId,
                    SesionId = compra.SesionId,
                    // Aquí podrías incluir más propiedades en el DTO según sea necesario
                };

                return compraDTO;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<CompraDTO> GetCompras(){
            try
            {
                var compras = _repository.GetCompras().Select(c => new CompraDTO
                {
                    CompraId = c.CompraId,
                    SesionId = c.SesionId,
                    
                }).ToList();

                return compras;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
