using Zoologico.Interfaces.RealInterfaces;

namespace Zoologico.Models
{
    public class Leao : Animal, IAndar
    {
        public string Anda()
        {
            return this.GetType().Name + "O animal é terrestre";
        }
    }
}