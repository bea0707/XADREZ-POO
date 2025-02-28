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


                for (int linha = 0; linha < GridSize; linha++)
                {
                    for (int coluna = 0; coluna < GridSize; coluna++)
                    {
                        int tempLinha = linha;
                        int tempColuna = coluna;
                        grid[linha, coluna] = new CasaVazia("casaVazia.png", linha * 50, coluna * 50, enumCor.vazio);
                        this.Controls.Add(grid[linha, coluna].pictureBox); 
                        grid[tempLinha, tempColuna].pictureBox.BringToFront();
                        grid[tempLinha, tempColuna].pictureBox.Click += (sender, args) => {OnCellClick(grid[tempLinha, tempColuna]);}; 

                    }  

                }

                Rei rei = new Rei("rei.png", 4 * 50, 7 * 50, enumCor.branco); // cria o rei branco
                grid[rei.x, rei.y] = rei;
                this.Controls.Add(rei.pictureBox); 
                rei.pictureBox.BringToFront();
                rei.pictureBox.Click += (sender, args) => {OnCellClick(rei);};

                Rei reiP = new Rei("rei_p.png", 3 * 50, 0 * 50, enumCor.preto); // cria rei preto
                grid[reiP.x, reiP.y] = reiP;
                this.Controls.Add(reiP.pictureBox);
                reiP.pictureBox.BringToFront();
                reiP.pictureBox.Click += (sender, args) => {OnCellClick(reiP);};

                
                for(int i = 0; i < 8; i++) //loop que cria os peões brancos
                {
                    int coluna = i;
                    Peao peao = new Peao("peao.png", coluna * 50, 6 * 50, enumCor.branco);
                    grid[peao.x, peao.y] = peao;
                    this.Controls.Add(peao.pictureBox);
                    peao.pictureBox.BringToFront();
                    peao.pictureBox.Click += (sender, args) => {OnCellClick(peao);};
                }

                for(int i = 0; i < 8; i++) //loop que cria os peões brancos
                {
                    int coluna = i;
                    Peao peaoP = new Peao("peao_p.png", coluna * 50, 1 * 50, enumCor.preto);
                    grid[peaoP.x, peaoP.y] = peaoP;
                    this.Controls.Add(peaoP.pictureBox);
                    peaoP.pictureBox.BringToFront();
                    peaoP.pictureBox.Click += (sender, args) => {OnCellClick(peaoP);};
                }



        

            #endregion
        }

        

    }


