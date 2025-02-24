using System;

public class Rei : Peça
{
    public Rei(string imagem, int x, int y) : base(imagem,x ,y) 
    {
        
        
    }
    public override bool VerificarMovimento() //metodo sobrescrito que verifica o movimento, falta criar a logica dele para cada peça
    {
        throw new NotImplementedException(); // lógica de movimentação do rei
    }


}


