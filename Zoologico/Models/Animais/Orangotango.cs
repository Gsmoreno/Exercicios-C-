using Zoologico.Interfaces.RealInterfaces;

namespace Zoologico.Models
{
    public class Orangotango : Animal, IArvore
    {
        public string SobeArvore()
        {
            return this.GetType().Name + "O animal é o Tarzan";
        }
    }
}