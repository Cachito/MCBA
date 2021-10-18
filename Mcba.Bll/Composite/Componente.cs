namespace Mcba.Bll.Composite
{
    public abstract class Componente
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public bool EsCompuesto { set; get; }
    }
}