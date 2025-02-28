class ArquivoJogo
{
    
    public static void SalvarJogadas(Peça[,] grid)
    {
        string caminho = "jogadas.txt";
        for(int i = 0; i < 8; i++)
        {
            for(int j = 0; j < 8; j++)
            {
                Peça entrada = grid[i, j];
                File.AppendAllText(caminho, entrada + Environment.NewLine);
            }
        }
        
        
    }
}