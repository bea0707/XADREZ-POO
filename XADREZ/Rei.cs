using System;

public class Rei : Peça{
    public Rei(string cor, int x, int y) : base(cor,x ,y){}
    public override bool VerificarMovimento()
    {
        throw new NotImplementedException(); // lógica de movimentação do rei
    }
}