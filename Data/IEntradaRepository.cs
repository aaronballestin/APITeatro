using TeatroApi.Models;

namespace TeatroApi.Data
{
    public interface IEntradaRepository
    {
        void AddEntrada(Entrada entrada);
        Entrada GetEntrada(int entradaId);
        List<Entrada> GetEntradasByObra(int obraId);
        List<Entrada> GetEntradasByUsuario(int usuarioId);
        void UpdateEntrada(Entrada entrada);
        void RemoveEntrada(int entradaId);
        void SaveChanges();
        List<Entrada> GetEntradas();
    }
}