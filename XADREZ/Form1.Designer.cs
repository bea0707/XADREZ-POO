namespace XADREZ;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private const int GridSize = 8;
    private Peça[,] grid = new Peça[GridSize, GridSize]; //cria uma matriz generica com 8/8 de tamanho para armazenar os botões
   
    //<summary>
        
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }


    #region Windows Form Designer generated code


    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; //cria a tela
        this.ClientSize = new System.Drawing.Size(400, 400);
        this.Text = "xadrez";

        PictureBox rei = new PictureBox();
        rei.Size = new Size(50, 50); // cria o picturebox do rei
        rei.Location = new Point(0, 0);
        rei.SizeMode = PictureBoxSizeMode.StretchImage;

        try
        {
            string path = Path.Combine(Application.StartupPath, "imagens", "rei.png");
            MessageBox.Show("Tentando carregar: " + path); //tratamento de exeção pra carregar a imagem do rei
            rei.Image = Image.FromFile(path);

        }

        catch (Exception ex)
        {
            MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
        }

        //grid[0,0] = rei;
        this.Controls.Add(rei); //adiciona o picturebox do rei na tela (o metodo Controls so aceita tipos do winforms, por exemplo, o picture box)
        rei.Click += (sender, args) => {OnCellClick(0, 0);};


        for (int linha = 0; linha < GridSize; linha++)
        {
            for (int coluna = 0; coluna < GridSize; coluna++)
            {
                grid[linha, coluna] = new CasaVazia(linha * 50, coluna * 50);
                this.Controls.Add(grid[linha, coluna].Button);
            }  
        }
    
        void OnCellClick(int linha, int coluna)
         {
        // Lógica a ser executada quando a célula for clicada
            MessageBox.Show($"Célula clicada: {linha}, {coluna}");
        }

        Tabuleiro tabuleiro = new Tabuleiro(); //chama os metodos Tabuleiro0 e InicializarTabuleiro, mas não será necessario (ate então) usar esses metodos (motivo comentado na clase)
        //tabuleiro.Tabuleiro0();

        private int origemX = -1, origemY = -1;

        public void cliqueTabuleiro (Peça peca)
        {
            if(origemX == -1 && origemY == -1) // verifica se é o primeiro clique
            {
                if(peca is not CasaVazia)
                {
                    origemX = peca.x;
                    origemY = peca.y;
                }
            }
            else
            {
                Peca pecaOrigem, pecaDestino;

                pecaOrigem = grid[origemX, origemY];
                pecaDestino = grid[peca.x, peca.y];

                if (pecaDestino is CasaVazia) // Se o destino estiver vazio, apenas move a peça
                    {
                        // Atualiza a matriz
                            // Atualiza a matriz
                            tabuleiro[origemX, origemY] = new CasaVazia(origemX * 50, origemY * 50, "casaVazia.png");
                            tabuleiro[peca.x, peca.y] = pecaOrigem;

                            // Atualiza as coordenadas da peça movida
                            pecaOrigem.x = peca.x;
                            pecaOrigem.y = peca.y;

                            // Atualiza a posição visualmente
                            pecaOrigem.pictureBox.Location = new Point(peca.x * 50, peca.y * 50);
                    }
             else // Se houver outra peça, troca as posições
                {
                // Remover peça do tabuleiro
                this.Controls.Remove(pecaDestino.pictureBox);

                // Substitui a peça no tabuleiro
                tabuleiro[peca.x, peca.y] = pecaOrigem;
                tabuleiro[origemX, origemY] = new CasaVazia(origemX * 50, origemY * 50, "casaVazia.png");

                // Atualiza a posição visualmente
                pecaOrigem.x = peca.x;
                pecaOrigem.y = peca.y;
                pecaOrigem.pictureBox.Location = new Point(peca.x * 50, peca.y * 50);
                }
        

        
            }

        #endregion
    }
}


