using System;

public class Cavalo : Peça
{
    public Cavalo(string cor, int x, int y) : base(cor, x, y) {}

    public override bool VerificarMovimento()
    {
        return true ; // lógica de movimentação do cavalo
    }
}