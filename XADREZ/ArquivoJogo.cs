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
                
            
                if (i == 0 && j ==0) 
                {
                    File.AppendAllText(caminho, entrada.ToString()); // Não coloca vírgula no primeiro item

                }
                else
                {
                    File.AppendAllText(caminho, "," + entrada.ToString());
                }
            }
        }

        File.AppendAllText(caminho, Environment.NewLine);
        
        
    }
}