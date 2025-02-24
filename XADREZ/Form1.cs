namespace XADREZ;

public partial class Form1 : Form
{
    private int origemX = -1, origemY = -1;

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
                        origemX = peca.x;
                        origemY = peca.y;
                        MessageBox.Show($"Peça selecionada em ({peca.x}, {peca.y})");
                    }
                else 
                {
                    origemX = -1;
                    origemY = -1;
                    MessageBox.Show("casa vazia)");
                }
            }
            else
            {
                Peça pecaOrigem = grid[origemX, origemY];               
                Peça pecaDestino = grid[peca.x, peca.y];
                MessageBox.Show($"Peça2 selecionada em ({peca.x}, {peca.y})");

                if (pecaDestino is CasaVazia && pecaDestino != pecaOrigem) // Se o destino estiver vazio, apenas move a peça
                    {
                        MessageBox.Show("é casa vazia");
                        grid[origemX, origemY] = new CasaVazia("casaVazia.png", origemX * 50, origemY * 50);
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
                    MessageBox.Show("não é casa vazia");
                    this.Controls.Remove(pecaDestino.pictureBox);

                    // Substitui a peça no tabuleiro
                    grid[peca.x, peca.y] = pecaOrigem;
                    grid[origemX, origemY] = new CasaVazia("casaVazia.png", origemX * 50, origemY * 50);

                    // Atualiza a posição visualmente
                    pecaOrigem.x = peca.x;
                    pecaOrigem.y = peca.y;
                    pecaOrigem.pictureBox.Location = new Point(peca.x * 50, peca.y * 50);
                    }
                    else 
                    {
                          MessageBox.Show("clicou no mesmo lugar");
                    }
            
                    origemX = -1;
                    origemY = -1;
            
            }
    }

}