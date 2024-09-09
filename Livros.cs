using System;
using System.Collections.Generic;

public class Livro
{
    public string Id { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Ano { get; set; }
    public string Editora { get; set; }
    public decimal Preco { get; set; }
}

public class Biblioteca
{
    public List<Livro> Livros { get; set; }
}