using TeatroApi.Models;

namespace TeatroApi.Data
{
    public interface IEntradaRepository
    {
        void AddEntrada(Entrada entrada);
        Entrada GetEntrada(int entradaId);
        void UpdateEntrada(Entrada entrada);
        void RemoveEntrada(int entradaId);
        void SaveChanges();
        List<Entrada> GetEntradas();
    }
}