using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMVC.Migrations
{
    /// <inheritdoc />
    public partial class PopularLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Lanches (CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, Nome, Preco) Values (1, 'Pão, hamburguer, ovo, presunto, queijo e batata palha', 'Delicioso pão de hamburguer com ovo frito, presunto e queijo de qualidade acompanhado com batata palha', 1, '~/images/lanche2.jpg', '~/images/lanche2.jpg', 0, 'Cheese Salada', 12.50 )");
            mb.Sql("Insert into Lanches (CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, Nome, Preco) Values (1, 'Pão, presunto, mussarela e tomate', 'Delicioso pão de hamburguer com presunto, mussarela e tomate', 1, '~/images/lanche3.jpg', '~/images/lanche3.jpg', 0, 'Misto Quente', 8.50 )");
            mb.Sql("Insert into Lanches (CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, Nome, Preco) Values (1, 'Pão, hamburguer, presunto, mussarela e batata palha', 'Delicioso pão de hamburguer com presunto, mussarela e batata palha', 1, '~/images/lanche4.jpg', '~/images/lanche4.jpg', 0, 'Cheese Burger', 11.00 )");
            mb.Sql("Insert into Lanches (CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, Nome, Preco) Values (2, 'Pão integral, queijo branco, peito de peru, cenoura e tomate', 'Delicioso pão integral com queijo branco, peito de peru, cenoura e tomate', 3, '~/images/lanche5.jpg', '~/images/lanche5.jpg', 1, 'lanche Natural', 15.00 )");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Lanches");
        }
    }
}
