namespace Atividade_ListaAtivos.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }   
        public bool IsDeleted { get; set; } 
        public bool DeletedAt { get; set; }

    }
}
