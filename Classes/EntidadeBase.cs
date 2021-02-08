namespace dioseries.Classes
{
    public abstract class EntidadeBase
    {
        public int Id { get; protected set; }
        protected bool Excluido { get; set; }

        public void Excluir() => this.Excluido = true;
        public bool RetornaExcluido() => Excluido;
        public int RetornaId() => Id;
    }
}