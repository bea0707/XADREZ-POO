class CasaVazia : Peça, IMovivel
{

    public CasaVazia(string imagem, int x, int y, enumCor cor) : base(imagem, x, y, cor)
        {

        }


     public bool VerificarMovimento() {return true;}
        
    
}