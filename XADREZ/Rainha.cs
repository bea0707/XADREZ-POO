using System;
public class Rainha : Peça, IMovivel
{
    public Rainha(string imagem, int x, int y) : base(imagem, x , y) 
    {
           
    }

    public bool VerificarMovimento() //metodo sobrescrito que verifica o movimento, falta criar a logica dele para cada peça
    {
        return true ; // lógica de movimentação do cavalo
    }

}

