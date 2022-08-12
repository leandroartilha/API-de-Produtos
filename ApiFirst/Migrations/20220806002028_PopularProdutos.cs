using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiFirst.Migrations;

public partial class PopularProdutos : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,CategoriaId)" +
        "Values('Coca-Cola Diet','Refrigerante de Cola 350 ml',5.45,'cocacola.jpg',50,1)");

        migrationBuilder.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,CategoriaId)" +
            "Values('Lanche de Atum','Lanche de Atum com maionese',8.50,'atum.jpg',10,2)");

        migrationBuilder.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,CategoriaId)" +
           "Values('Pudim 100 g','Pudim de leite condensado 100g',6.75,'pudim.jpg',20,3)");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql("Delete from Produtos");
    }
}
