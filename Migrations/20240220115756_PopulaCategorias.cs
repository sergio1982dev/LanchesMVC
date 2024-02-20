using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMVC.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Categorias (CategoriaNome, Descricao) Values ('Normal', 'Lanche feito com ingredientes normais')");
            mb.Sql("INSERT INTO Categorias (CategoriaNome, Descricao) Values ('Natural', 'Lanche feito com ingredientes naturais e integrais')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Categorias");
        }
    }
}
