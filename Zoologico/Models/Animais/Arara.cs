using Zoologico.Interfaces.RealInterfaces;

namespace Zoologico.Models
{
    public class Arara : Animal, IVoar
    {
        public string Vaozada()
        {
            return this.GetType().Name + "O animal VOAAAAAAAAA";
        }
    }
}