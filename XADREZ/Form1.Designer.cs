namespace XADREZ;


    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private const int GridSize = 8;
        public Peça[,] grid = new Peça[GridSize, GridSize]; //cria uma matriz generica com 8/8 de tamanho para armazenar os botões

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
            File.Delete("jogadas.txt");

                

                for (int linha = 0; linha < GridSize; linha++)
                {
                    for (int coluna = 0; coluna < GridSize; coluna++)
                    {
                        int tempLinha = linha;
                        int tempColuna = coluna;
                        

                        if((tempLinha % 2) == 0 ^ (tempColuna % 2) == 0)
                        {
                            grid[linha, coluna] = new CasaVazia("casa_azul.png", linha * 50, coluna * 50, enumCor.vazio);
                            this.Controls.Add(grid[linha, coluna].pictureBox); 
                            grid[tempLinha, tempColuna].pictureBox.BringToFront();
                            grid[tempLinha, tempColuna].pictureBox.Click += (sender, args) => {OnCellClick(grid[tempLinha, tempColuna]);};
                            
                        }
                        else 
                        {
                            grid[linha, coluna] = new CasaVazia("casa_rosa.png", linha * 50, coluna * 50, enumCor.vazio);
                            this.Controls.Add(grid[linha, coluna].pictureBox); 
                            grid[tempLinha, tempColuna].pictureBox.BringToFront();
                            grid[tempLinha, tempColuna].pictureBox.Click += (sender, args) => {OnCellClick(grid[tempLinha, tempColuna]);};
                            
                        }

                    }  

                }

                Rei rei = new Rei("rei.png", 3 * 50, 7 * 50, enumCor.branco); // cria o rei branco
                grid[rei.x, rei.y] = rei;
                this.Controls.Add(rei.pictureBox); 
                rei.pictureBox.BringToFront();
                rei.pictureBox.Click += (sender, args) => {OnCellClick(rei);};

                Rei reiP = new Rei("rei_p.png", 4 * 50, 0 * 50, enumCor.preto); // cria rei preto
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

                Torre torre = new Torre("torre.png", 0 * 50, 7 * 50, enumCor.branco);
                grid[torre.x, torre.y] = torre;
                this.Controls.Add(torre.pictureBox);
                torre.pictureBox.BringToFront();
                torre.pictureBox.Click += (sender, args) => {OnCellClick(torre);};

                Torre torre1 = new Torre("torre.png", 7 * 50, 7 * 50, enumCor.branco); // cria as torres brancas
                grid[torre1.x, torre1.y] = torre1;
                this.Controls.Add(torre1.pictureBox);
                torre1.pictureBox.BringToFront();
                torre1.pictureBox.Click += (sender, args) => {OnCellClick(torre1);};

                Torre torreP = new Torre("torre_p.png", 0, 0, enumCor.preto);
                grid[torreP.x, torreP.y] = torreP;
                this.Controls.Add(torreP.pictureBox);
                torreP.pictureBox.BringToFront();
                torreP.pictureBox.Click += (sender, args) => {OnCellClick(torreP);};

                Torre torreP1 = new Torre("torre_p.png", 7 * 50, 0, enumCor.preto);
                grid[torreP1.x, torreP1.y] = torreP1;
                this.Controls.Add(torreP1.pictureBox);
                torreP1.pictureBox.BringToFront();
                torreP1.pictureBox.Click += (sender, args) => {OnCellClick(torreP1);};

                Cavalo cavalo = new Cavalo("cavalo.png", 1 * 50, 7 * 50, enumCor.branco);
                grid[cavalo.x, cavalo.y] = cavalo;
                this.Controls.Add(cavalo.pictureBox);
                cavalo.pictureBox.BringToFront();
                cavalo.pictureBox.Click += (sender, args) => {OnCellClick(cavalo);};

                Cavalo cavalo1 = new Cavalo("cavalo.png", 6 * 50, 7 * 50, enumCor.branco);
                grid[cavalo1.x, cavalo1.y] = cavalo1;
                this.Controls.Add(cavalo1.pictureBox);
                cavalo1.pictureBox.BringToFront();
                cavalo1.pictureBox.Click += (sender, args) => {OnCellClick(cavalo1);};

                Cavalo cavaloP = new Cavalo("cavalo_p.png", 6 * 50, 0 * 50, enumCor.preto);
                grid[cavaloP.x, cavaloP.y] = cavaloP;
                this.Controls.Add(cavaloP.pictureBox);
                cavaloP.pictureBox.BringToFront();
                cavaloP.pictureBox.Click += (sender, args) => {OnCellClick(cavaloP);};

                Cavalo cavaloP1 = new Cavalo("cavalo_p.png", 1 * 50, 0 * 50, enumCor.preto);
                grid[cavaloP1.x, cavaloP1.y] = cavaloP1;
                this.Controls.Add(cavaloP1.pictureBox);
                cavaloP1.pictureBox.BringToFront();
                cavaloP1.pictureBox.Click += (sender, args) => {OnCellClick(cavaloP1);};

                Bispo bispo = new Bispo("bispo.png", 2 * 50, 7 * 50, enumCor.branco);
                grid[bispo.x, bispo.y] = bispo;
                this.Controls.Add(bispo.pictureBox);
                bispo.pictureBox.BringToFront();
                bispo.pictureBox.Click += (sender, args) => {OnCellClick(bispo);};

                Bispo bispo1 = new Bispo("bispo.png", 5 * 50, 7 * 50, enumCor.branco);
                grid[bispo1.x, bispo1.y] = bispo1;
                this.Controls.Add(bispo1.pictureBox);
                bispo1.pictureBox.BringToFront();
                bispo1.pictureBox.Click += (sender, args) => {OnCellClick(bispo1);};

                Bispo bispoP = new Bispo("bispo_p.png", 5 * 50, 0 * 50, enumCor.preto);
                grid[bispoP.x, bispoP.y] = bispoP;
                this.Controls.Add(bispoP.pictureBox);
                bispoP.pictureBox.BringToFront();
                bispoP.pictureBox.Click += (sender, args) => {OnCellClick(bispoP);};

                Bispo bispoP1 = new Bispo("bispo_p.png", 2 * 50, 0 * 50, enumCor.preto);
                grid[bispoP1.x, bispoP1.y] = bispoP1;
                this.Controls.Add(bispoP1.pictureBox);
                bispoP1.pictureBox.BringToFront();
                bispoP1.pictureBox.Click += (sender, args) => {OnCellClick(bispoP1);};

                Rainha rainha = new Rainha("rainha.png", 4 * 50, 7 * 50, enumCor.branco);
                grid[rainha.x, rainha.y] = rainha;
                this.Controls.Add(rainha.pictureBox);
                rainha.pictureBox.BringToFront();
                rainha.pictureBox.Click += (sender, args) => {OnCellClick(rainha);};

                Rainha rainhaP = new Rainha("rainha_p.png", 3 * 50, 0 * 50, enumCor.preto);
                grid[rainhaP.x, rainhaP.y] = rainhaP;
                this.Controls.Add(rainhaP.pictureBox);
                rainhaP.pictureBox.BringToFront();
                rainhaP.pictureBox.Click += (sender, args) => {OnCellClick(rainhaP);};


            #endregion
        }

        

    }


