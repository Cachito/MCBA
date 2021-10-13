using Mcba.Entidad.Enums;

namespace Mcba.Entidad.Composite
{
    public abstract class Componente
    {
        public int Id { set; get; }
        public string Modulo { set; get; }
        public bool EsCompuesto { set; get; }
    }
}