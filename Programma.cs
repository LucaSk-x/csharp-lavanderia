﻿// See https://aka.ms/new-console-template for more information
public abstract class Programma
{
    //costruttore
    public Programma(string nome, int costo, int durata)
    {
        Nome = nome;
        Costo = costo;
        Durata = durata;
    }

    //properties
    public string Nome { get; set; }
    public int Costo { get; set; }
    public int Durata { get; set; }
}