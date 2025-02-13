using System;
public class Rainha : Peça 
{
    public Rainha(string cor, int x, int y) : base(cor, x , y) {}

    public override bool VerificarMovimento()
    {
        throw new NotImplementedException(); // lógica de movimentação da rainha
    }
}