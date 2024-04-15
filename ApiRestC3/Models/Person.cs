namespace ApiRestCS.Models
{
    public class Person
    {
        private long id;
        private  string nombre;
        private int edad;



        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
