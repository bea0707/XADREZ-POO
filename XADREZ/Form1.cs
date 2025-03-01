namespace XADREZ;

public partial class Form1 : Form
{
    private int origemX = -1, origemY = -1;
    private bool vezBranco = true;
    public int numeroJogadas = 0;

    public Form1()
    {
        InitializeComponent();
    }


    void OnCellClick(Peça peca)
    {
        if(origemX == -1 && origemY == -1) // verifica se é o primeiro clique
            {

                if(peca is not CasaVazia)
                {
                    if(vezBranco && peca.cor == enumCor.branco)
                    {
                        origemX = peca.x;
                        origemY = peca.y;
                        MessageBox.Show($"Peça selecionada em ({peca.x}, {peca.y})");
                    }
                    else if(!vezBranco && peca.cor == enumCor.preto)
                    {
                        origemX = peca.x;
                        origemY = peca.y;
                        MessageBox.Show($"Peça selecionada em ({peca.x}, {peca.y})");
                    }
                    else
                    {
                        MessageBox.Show("vez do outro jogador");
                    }
                }
                else 
                {
                    origemX = -1;
                    origemY = -1;
                    
                }
            }
            else
            {
                Peça pecaOrigem = grid[origemX, origemY];               
                Peça pecaDestino = grid[peca.x, peca.y];
                MessageBox.Show($"Peça2 selecionada em ({peca.x}, {peca.y})");

                if(!pecaOrigem.VerificarMovimento(peca.x, peca.y))
                {
                    MessageBox.Show("movimento invalido");
                    origemX = -1;
                    origemY = -1;
                    return;

                }

                if(pecaOrigem.cor == pecaDestino.cor)
                {
                    MessageBox.Show("movimento invalido! não pode comer uma peça da mesma cor");
                    origemX = -1;
                    origemY = -1;
                    return;   
                }

                if (pecaDestino is CasaVazia && pecaDestino != pecaOrigem) // Se o destino estiver vazio, apenas move a peça
                    {
                        grid[origemX, origemY] = new CasaVazia("casaVazia.png", origemX * 50, origemY * 50, enumCor.vazio);
                        grid[peca.x, peca.y] = pecaOrigem;

                        // Atualiza as coordenadas da peça movida
                        pecaOrigem.x = peca.x;
                        pecaOrigem.y = peca.y;

                        // Atualiza a posição visualmente
                        pecaOrigem.pictureBox.Location = new Point(peca.x * 50, peca.y * 50);

                    }
                else if (pecaDestino != pecaOrigem) // Se houver outra peça, troca as posições
                    {
                    // Remover peça do tabuleiro
                    this.Controls.Remove(pecaDestino.pictureBox);

                    // Substitui a peça no tabuleiro
                    grid[peca.x, peca.y] = pecaOrigem;
                    grid[origemX, origemY] = new CasaVazia("casaVazia.png", origemX * 50, origemY * 50, enumCor.vazio);

                    // Atualiza a posição visualmente
                    pecaOrigem.x = peca.x;
                    pecaOrigem.y = peca.y;
                    pecaOrigem.pictureBox.Location = new Point(peca.x * 50, peca.y * 50);

                    if(pecaDestino is Rei)
                    {
                        switch (pecaDestino.cor)
                        {
                            case enumCor.branco:
                                MessageBox.Show("PARABENS! OS PRETOS GANHARAM!!!!");
                                Application.Exit();
                                break;

                            case enumCor.preto:
                                MessageBox.Show("PARABENS! OS BRANCOS GANHARAM!!!!");
                                Application.Exit();
                                break;
                        }
                    }
                    }
                    else 
                    {
                          MessageBox.Show("clicou no mesmo lugar");
                    }

                    switch(vezBranco)
                    {
                        case true: 
                            vezBranco = false;
                        break;
                        
                        case false:
                            vezBranco = true;
                        break;
                    }
                
                    ArquivoJogo.SalvarJogadas(grid);
                    origemX = -1;
                    origemY = -1;
                    numeroJogadas = numeroJogadas + 1;
                    ArquivoJogo.CarregarJogadas(numeroJogadas);
            
            }
    }

}