using System;
using System.Collections.Generic;

public class Veiculo
{
    public string Id { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public string Cor { get; set; }
    public decimal Preco { get; set; }
    public string Status { get; set; }
}

public class LojaDeAutomoveis
{
    public List<Veiculo> Veiculos { get; set; }
}