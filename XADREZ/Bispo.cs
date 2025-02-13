using System;

public class Bispo : Peça
{
    public Bispo(string cor, int x, int y) : base(cor, x, y){}
    public override bool VerificarMovimento()
    {
        throw new NotImplementedException(); // lógica de movimentação do bispo 
    }
}