public class Peao : Peça
{
    public bool primeiraJogada = true;

    public Peao(string imagem, int x, int y, enumCor cor) : base(imagem, x, y, cor) 
    {
      
    
    }

    public override bool VerificarMovimento(int DestinoX, int DestinoY) //metodo sobrescrito que verifica o movimento, falta criar a logica dele para cada peça
    {
        int DiferençaY = DestinoY - y;
        int DiferençaX = Math.Abs(DestinoX - x);
        
        if(cor == enumCor.branco)
        {
            if(primeiraJogada)
            {
                primeiraJogada = false;
                return DiferençaY >= -2 && DiferençaX == 0;               
            }
            else
            {
                return DiferençaY == -1 && DiferençaX == 0;
            }
        }
        else
        {
            if(primeiraJogada)
            {
                primeiraJogada = false;
                return DiferençaY <= 2 && DiferençaX == 0;               
            }
            else
            {
                return DiferençaY == 1 && DiferençaX == 0;
            }
        }


    }


}