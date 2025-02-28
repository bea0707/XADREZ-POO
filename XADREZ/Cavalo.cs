using System;

public class Cavalo : Peça
{
    public Cavalo(string imagem, int x, int y, enumCor cor) : base(imagem, x, y, cor)
     {
       
     }

    public override bool VerificarMovimento(int DestinoX, int DestinoY) //metodo sobrescrito que verifica o movimento, falta criar a logica dele para cada peça
    {
        return true ; // lógica de movimentação do cavalo
    }

}