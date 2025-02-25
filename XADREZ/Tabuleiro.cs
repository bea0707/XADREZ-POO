/*
public class Tabuleiro
{
    public Peça[,] Pecas { get; private set; }
    public Rainha[] Rainhas { get; private set; }
    public Rei[] reis { get; private set; }
    public Torre[] torres { get; private set; } //cria arrays e uma matriz genericos para armazenar as peças
    public Bispo[] bispos { get; private set; }
    public Cavalo[] cavalos { get; private set; }
    public Peao[] peaos { get; private set; }


     public void InicializarTabuleiro() //esse metodo cria objetos das peças em seus lugares em uma matriz, mas ela não os coloca na tela do winforms e nem pode, pois o winforms so aceita tipos proprios do winforms
     // as arrays la em baixo possuem objetos diferentes dos da matriz, se algo mudar na array, a matriz continua intacta pois elas não tem relação nenhuma
     //tudo isso me parece inutil mas não vou remover do codigo por enquanto, mas essa classe inteira não faz nada
     //talvez seja util no futuro
    {
        
        Pecas[0, 0] = new Torre("preto", 0, 0);     
        Pecas[0, 1] = new Cavalo("preto", 0, 1); 
        Pecas[0, 2] = new Bispo("preto", 0, 2); 
        Pecas[0, 3] = new Rainha("preto", 0, 3); //cria  objetos de todas as peças pretas em seus lugares na matriz das peças
        Pecas[0, 4] = new Rei("preto", 0, 4); 
        Pecas[0, 5] = new Bispo("preto", 0, 5);
        Pecas[0, 6] = new Cavalo("preto", 0, 6); 
        Pecas[0, 7] = new Torre("preto", 0, 7); 
        
      
        for (int i = 1; i < 8; i++)
        {
            Pecas[2, i] = new Peao("preto", 1, i); 
        }

        Pecas[7, 0] = new Torre("branco", 7, 0); 
        Pecas[7, 1] = new Cavalo("branco", 7, 1); 
        Pecas[7, 2] = new Bispo("branco", 7, 2);
        Pecas[7, 3] = new Rainha("branco", 7, 3); //cria  objetos de todas as peças brancas em seus lugares na matriz das peças
        Pecas[7, 4] = new Rei("branco", 7, 4); 
        Pecas[7, 5] = new Bispo("branco", 7, 5); 
        Pecas[7, 6] = new Cavalo("branco", 7, 6); 
        Pecas[7, 7] = new Torre("branco", 7, 7); 
        
        
        for (int i = 6; i < 8; i++)
        {
            Pecas[6, i] = new Peao("branco", 6, i); //loop que cria peoes brancos nos seus respectivos locais na matriz das peças
            
        }

        /*
        Rainhas[0] = new Rainha("preto", 0, 3);  
        Rainhas[1] = new Rainha("branco", 7, 3);

        reis[0] = new Rei("preto", 0, 4); 
        reis[1] = new Rei("branco", 7, 4); 

        torres[0] = new Torre("preto", 0, 0); 
        torres[1] = new Torre("preto", 0, 7); 
        torres[2] = new Torre("branco", 7, 0); 
        torres[3] = new Torre("branco", 7, 7); //cria novos objetos das peças em arrays para organizar as peças
        
        cavalos[0] = new Cavalo("preto", 0, 1);
        cavalos[1] = new Cavalo("preto", 0, 6); 
        cavalos[2] = new Cavalo("branco", 7, 1); 
        cavalos[3] = new Cavalo("branco", 7, 6); 

        bispos[0] = new Bispo("preto", 0, 2); 
        bispos[1] = new Bispo("preto", 0, 5); 
        bispos[2] = new Bispo("branco", 7, 2); 
        bispos[3] = new Bispo("branco", 7, 5); 
        
        
    }
    
    public void Tabuleiro0() //armazenar as peças em arrays não me parece ter utilidade alguma, provavelmente deveria ser excluido mas vou deixar ai (Vitor, 18/02)
    {
       
        Pecas = new Peça[8, 8];    
        Rainhas = new Rainha[2]; 
        cavalos = new Cavalo[4]; //dimensiona as arrays e matrizes criadas no começo da classe
        reis = new Rei[2]; 
        torres = new Torre[4]; 
        bispos = new Bispo[4];
        peaos = new Peao[16]; 
        

        InicializarTabuleiro();
    }
}
*/