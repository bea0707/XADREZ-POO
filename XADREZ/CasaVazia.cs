class CasaVazia : Peça
{

    public CasaVazia(string imagem, int x, int y, enumCor cor) : base(imagem, x, y, cor)
        {

        }


     public override bool VerificarMovimento(int DestinoX, int DestinoY) {return true;}
        
    
}