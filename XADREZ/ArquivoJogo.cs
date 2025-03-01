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

    public static void CarregarJogadas(int numeroJogadas)
    {
        string caminho = "jogadas.txt";
        string[] jogadasCarregar = new string[63];

        var lerJogadas = File.ReadAllLines(caminho);
        
        string jogadas = lerJogadas[lerJogadas.Length - 1];

        jogadasCarregar = jogadas.Split(new[] { ", " }, StringSplitOptions.None);            
        
    }
}