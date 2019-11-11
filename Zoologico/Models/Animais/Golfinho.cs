using Zoologico.Interfaces.RealInterfaces;

namespace Zoologico.Models
{
    public class Golfinho : Animal, IAquaRespiration, IAquatico
    {
        public string Nada()
        {
            return this.GetType().Name + "O animal sabe nadar";
        }

        public string RespiraNaAgua()
        {
            return this.GetType().Name + "O animal Respira em baixo d'agua";
        }
    }
}