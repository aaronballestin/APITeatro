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

        public int AddCompra(CompraPostDTO compraDTO)
        {
            try
            {

                var id = _repository.AddCompra(compraDTO);
                _repository.SaveChanges();


                foreach (var asientoId in compraDTO.asientos)
                {
                    var detalleCompra = new DetallesCompra
                    {
                        CompraId = id,
                        AsientoId = asientoId, 
                        SesionId = compraDTO.sesionId               
                    };

                    _repository.AddDetallesCompra(detalleCompra);
                }

                _repository.SaveChanges();

                return 1;
            }
            catch (Exception ex)
            {
                // Si ocurre algún error durante la realización de la compra, lo capturamos y devolvemos un resultado de error
                Console.WriteLine(ex.Message);
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

                var compraDTO = new CompraDTO
                {
                    CompraId = compra.CompraId,
                    SesionId = compra.SesionId,
                    UsuarioId = compra.UsuarioId,
                    precio = compra.PrecioCompra,
                    fecha = compra.FechaCompra
                };

                return compraDTO;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<CompraDTO> GetCompras()
        {
            try
            {
                var compras = _repository.GetCompras().Select(c => new CompraDTO
                {
                    CompraId = c.CompraId,
                    SesionId = c.SesionId,
                    UsuarioId = c.UsuarioId,
                    precio = c.PrecioCompra

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
