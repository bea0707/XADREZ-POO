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
                        this.Controls.Add(grid[linha, coluna].pictureBox); // se clicar em uma casa vazia aparece esse erro "System.IndexOutOfRangeException: Index was outside the bounds of the array."
                        grid[tempLinha, tempColuna].pictureBox.BringToFront();
                        grid[tempLinha, tempColuna].pictureBox.Click += (sender, args) => {OnCellClick(grid[tempLinha, tempColuna]);}; // local do erro " at XADREZ.Form1.<>c__DisplayClass8_2.<InitializeComponent>b__1(Object sender, EventArgs args) in C:\Users\vidro\OneDrive\Área de Trabalho\meus codigos\projetos\XADREZ-POO\XADREZ\Form1.Designer.cs:line 58"

                    }  

                }

            
            Rei rei = new Rei("rei.png", 0, 0, enumCor.branco);
            
            grid[rei.x, rei.y] = rei;
            this.Controls.Add(rei.pictureBox); //adiciona o picturebox do rei na tela (o metodo Controls so aceita tipos do winforms, por exemplo, o picture box)
            rei.pictureBox.BringToFront();
            rei.pictureBox.Click += (sender, args) => {OnCellClick(rei);};

            Rei reiP = new Rei("rei_p.png", 5 * 50, 5 * 50, enumCor.preto);
            grid[reiP.x, reiP.y] = reiP;
            this.Controls.Add(reiP.pictureBox);
            reiP.pictureBox.BringToFront();
            reiP.pictureBox.Click += (sender, args) => {OnCellClick(reiP);};




        

            #endregion
        }

        

    }


