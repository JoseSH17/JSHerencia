namespace JSHerencia
{
    public abstract class ClsForma
    {
        private string Nombre = "";        
        private string Color = "";
        public static double Pi => 3.14;
        public abstract void Imprimir();
        public virtual void SetNombre(string Nombre) { this.Nombre = Nombre; }
        public virtual string GetNombre() { return Nombre; }
        public virtual void SetColor(string Color) { this.Color = Color; }
        public virtual string GetColor() { return Color; }
    }
}
