namespace eduardolopez.Model
{
    public class Submarino : Vehiculo
    {
        public float profundidadMaxima;
        public float ProfundidadMaxima
        {
            get { return profundidadMaxima; }
            set { profundidadMaxima = value; }
        }

        public override void encenter()
        {

        }
        public override void apagar()
        {

        }
        public void Sumergir(float metros)
        {

        }
        public Submarino(){}
        public Submarino(float velocidadMaxima, float velocidadMinima, string marca, string modelo)=>
        (base.VelocidadMaxima, base.VelocidadMinima, base.Marca, base.Modelo)=
        (velocidadMaxima, velocidadMinima, marca, modelo);
    }
}