class CasaVazia : Peça, IMovivel
{

    public CasaVazia(string imagem, int x, int y) : base(imagem, x, y)
        {

        }


     public bool VerificarMovimento() {return true;}
        
    
}