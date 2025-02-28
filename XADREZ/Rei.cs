using System;

public class Rei : Peça
{
  
    public Rei(string imagem, int x, int y,enumCor cor) : base(imagem,x ,y, cor) 
    {
        
        
    }
    
    public override bool VerificarMovimento(int DestinoX, int DestinoY) //metodo sobrescrito que verifica o movimento, falta criar a logica dele para cada peça
    {

        int DiferençaX = Math.Abs(DestinoX - x);
        int DiferençaY = Math.Abs(DestinoY - y);

        return DiferençaX <= 1 && DiferençaY <= 1;
    }


}


