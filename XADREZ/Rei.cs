using System;

public class Rei : Peça, IMovivel
{
    public Rei(string imagem, int x, int y) : base(imagem,x ,y) 
    {
        
        
    }
    public bool VerificarMovimento() //metodo sobrescrito que verifica o movimento, falta criar a logica dele para cada peça
    {
        throw new NotImplementedException(); // lógica de movimentação do rei
    }


}


