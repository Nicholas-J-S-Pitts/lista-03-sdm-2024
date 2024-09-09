using System;
using System.Collections.Generic;

public class Peca
{
    public string Id { get; set; }
    public string Nome { get; set; }
    public int Quantidade { get; set; }
    public string Categoria { get; set; }
    public decimal PrecoUnitario { get; set; }
}

public class Deposito
{
    public string Nome { get; set; }
    public string Localizacao { get; set; }
    public List<Peca> Pecas { get; set; }
}