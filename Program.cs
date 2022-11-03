// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Random rd = new Random();

Macchina Lavatrice1 = new Macchina(rd.Next(5, 30), true, rd.Next(20), rd.Next(500), rd.Next(1000));
Macchina Lavatrice2 = new Macchina(rd.Next(5, 30), false, rd.Next(20), rd.Next(500), rd.Next(1000));
Macchina Lavatrice3 = new Macchina(rd.Next(5, 30), false, rd.Next(20), rd.Next(500), rd.Next(1000));
Macchina Lavatrice4 = new Macchina(rd.Next(5, 30), false, rd.Next(20), rd.Next(500), rd.Next(1000));
Macchina Lavatrice5 = new Macchina(rd.Next(5, 30), true, rd.Next(20), rd.Next(500), rd.Next(1000));

Macchina Asciugatrice1 = new Macchina(rd.Next(5, 30), true, rd.Next(20));
Macchina Asciugatrice2 = new Macchina(rd.Next(5, 30), false, rd.Next(20));
Macchina Asciugatrice3 = new Macchina(rd.Next(5, 30), true, rd.Next(20));
Macchina Asciugatrice4 = new Macchina(rd.Next(5, 30), false, rd.Next(20));
Macchina Asciugatrice5 = new Macchina(rd.Next(5, 30), true, rd.Next(20));

Console.WriteLine(Lavatrice5.Ammorbidente);
Console.WriteLine(Lavatrice5.Gettoni);
Console.WriteLine(Lavatrice1.Ammorbidente);
Console.WriteLine(Asciugatrice5.Gettoni);
Console.WriteLine(Asciugatrice3.Gettoni);


public class Macchina
{
    private int gettoni;
    private bool inUso;
    private int tempo;
    private int ammorbidente;
    private int detersivo;


    //Lavatrice
    public Macchina(int gettoni, bool inUso, int tempo, int ammorbidente, int detersivo)
    {
        this.Gettoni = gettoni;
        this.InUso = inUso;
        this.Tempo = tempo;
        this.Ammorbidente = ammorbidente;
        this.Detersivo = detersivo;
    }

    //Asciugatrice
    public Macchina(int gettoni, bool inUso, int tempo)
    {
        this.Gettoni = gettoni;
        this.InUso = inUso;
        this.Tempo = tempo;
    }


    //Gettoni
    public int Gettoni { get; set; }

    //InUso
    public bool InUso { get; set; }

    //Tempo
    public int Tempo { get; set; }

    //Ammorbidente
    public int Ammorbidente { get; set; }

    //Detersivo
    public int Detersivo { get; set; }

    public string stampaStato()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i < 5)
            {
                if (Lavatrice1.InUso == true)
            }
        }
    }
}