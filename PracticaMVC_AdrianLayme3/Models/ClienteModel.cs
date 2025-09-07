namespace PracticaMVC_AdrianLayme3.Models
{
    public class ClienteModel
    {
        // Para hacer la migracion en base de datos
        // Tenemos que colocar Id
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }

        public ICollection<PedidoModel> Pedidos { get; set; }
    }
}
