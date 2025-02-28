using System;
public class Rainha : Peça
{
    public Rainha(string imagem, int x, int y, enumCor cor) : base(imagem, x , y, cor) 
    {
           
    }

    public override bool VerificarMovimento(int DestinoX, int DestinoY) //metodo sobrescrito que verifica o movimento, falta criar a logica dele para cada peça
    {
        int DiferençaX = Math.Abs(DestinoX - x);
        int DiferençaY = Math.Abs(DestinoY - y);

        return DiferençaX > 0 && DiferençaY == 0 || DiferençaX == 0 && DiferençaY > 0 || (DiferençaX == DiferençaY);
    }

}

