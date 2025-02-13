public class Tabuleiro
{
    public Peça[,] Pecas { get; private set; }
    public Rainha[] Rainhas { get; private set; }
    public Rei[] reis { get; private set; }
    public Torre[] torres { get; private set; }
    public Bispo[] bispos { get; private set; }
    public Cavalo[] cavalos { get; private set; }
    public Peao[] peaos { get; private set; }
}
    public Tabuleiro()
    {
        Pecas = new Peça[8, 8];
        Rainhas = new Rainha[2]; 
        cavalos = new Cavalo[4];
        reis = new Rei[2]; 
        torres = new Torre[4]; 
        bispos = new Bispo[4];
        peaos = new Peao[16]; 
        InicializarTabuleiro();
    }

    private void InicializarTabuleiro()
    {
    
        Pecas[1, 1] = new Torre("preto", 1, 1); 
        Pecas[1, 2] = new Cavalo("black", 1, 2); 
        Pecas[1, 3] = new Bispo("preto", 1, 3); 
        Pecas[1, 4] = new Rainha("black", 1, 4); 
        Pecas[1, 5] = new Rei("preto", 1, 5); 
        Pecas[1, 6] = new Bispo("preto", 1, 6); 
        Pecas[1, 7] = new Cavalo("black", 1, 7); 
        Pecas[1, 8] = new Torre("preto", 1, 8); 
    }

      
        for (int i = 2; i < 9; i++)
        {
            Pecas[2, i] = new Peao("black", 2, i); 

        Pecas[8, 1] = new Torre("white", 8, 1); 
        Pecas[8, 2] = new Cavalo("white", 8, 2); 
        Pecas[8, 4] = new Rainha("white", 8, 4); 
        Pecas[8, 5] = new Rei("white", 8, 5); 
        Pecas[8, 6] = new Bispo("white", 8, 6); 
        Pecas[8, 7] = new Cavalo("white", 8, 7); 
        Pecas[8, 8] = new Torre("white", 8, 8); 

        for (int i = 7; i < 9; i++)
        {
            Pecas[7, i] = new Peao("white", 7, i);

        Rainhas[1] = new Rainha("black", 1, 4);  
        Rainhas[2] = new Rainha("branco", 8, 4);


        reis[1] = new Rei("preto", 1, 5); 
        reis[2] = new Rei("white", 8, 5); 

        torres[1] = new Torre("black", 1, 1); 
        torres[2] = new Torre("preto", 1, 8); 
        torres[3] = new Torre("white", 8, 1); 
        torres[4] = new Torre("branco", 8, 8); 
        
        cavalos[1] = new Cavalo("preto", 1, 2);
        cavalos[2] = new Cavalo("black", 1, 7); 
        cavalos[3] = new Cavalo("white", 8, 2); 
        cavalos[4] = new Cavalo("branca", 8, 7); 

        bispos[1] = new Bispo("black", 1, 3); 
        bispos[2] = new Bispo("preto", 1, 6); 
        bispos[3] = new Bispo("white", 8, 3); 
        bispos[4] = new Bispo("branca", 8, 6); 
    }
}