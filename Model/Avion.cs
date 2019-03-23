namespace eduardolopez.Model
{
    public class Avion : Vehiculo
    {
        public float alturaMaxima;
        public float AlturaMaxima
        {
            get { return alturaMaxima; }
            set { alturaMaxima = value; }
        }

        public float alturaMinima;
        public float AlturaMinima
        {
            get { return alturaMinima; }
            set { alturaMinima = value; }
        }

        public void Despejar()
        {

        }

        public void Aterrizar()
        {

        }
        public void Disminuir (float pie)
        {

        }

        public override void encenter()
        {

        }
        public override void apagar()
        {

        }

        public Avion(){}
        public Avion(float velocidadMaxima, float velocidadMinima, string marca, string modelo)=>
        (base.VelocidadMaxima, base.VelocidadMinima, base.Marca, base.Modelo)=
        (velocidadMaxima, velocidadMinima, marca, modelo);
            
        

    }
}