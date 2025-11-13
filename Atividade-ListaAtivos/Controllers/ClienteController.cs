using Atividade_ListaAtivos.Data;
using Atividade_ListaAtivos.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;


namespace Atividade_ListaAtivos.Controllers
{
    public class ClienteController : Controller
    {

        private readonly Database db = new Database();

        public IActionResult Index()
        {

            using var conn = db.GetConnection();
            using var cmd = new MySqlCommand("select * from clientes where IsDeleted = 0", conn);
            using var reader = cmd.ExecuteReader();

            List<Cliente> lista = new List<Cliente>();

            while (reader.Read())
            {
                lista.Add(
                new Cliente()
                {
                    Id = reader.GetInt32("id"),
                    Nome = reader.GetString("nome"),
                    Email = reader.GetString("email"),
                    IsDeleted = reader.GetBoolean("IsDeleted")
                } );

            }
            return View(lista);
        }

        public void Excluir(int Id)
        {

            using var conn = db.GetConnection();
            using var cmd = new MySqlCommand("update clientes set isDeleted=1,DeletedAt= NOW() where Id = @id;", conn);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.ExecuteNonQuery();
        }

    }
}
