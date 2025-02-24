namespace XADREZ
{

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

            Rei rei = new Rei("rei.png", 0, 0);
            //rei.Size = new Size(50, 50); // cria o picturebox do rei
            //rei.Location = new Point(0, 0);
            //rei.SizeMode = PictureBoxSizeMode.StretchImage;

            /*
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
            */

            //grid[0,0] = rei;
            grid[rei.x, rei.y] = rei;
            this.Controls.Add(rei.pictureBox); //adiciona o picturebox do rei na tela (o metodo Controls so aceita tipos do winforms, por exemplo, o picture box)
            rei.pictureBox.BringToFront();
            rei.pictureBox.Click += (sender, args) => {OnCellClick(rei);};


            
            for (int linha = 0; linha < GridSize; linha++)
            {
                for (int coluna = 0; coluna < GridSize; coluna++)
                {
                    grid[linha, coluna] = new CasaVazia("casaVazia.png", linha * 50, coluna * 50);
                    this.Controls.Add(grid[linha, coluna].pictureBox);
                    grid[linha, coluna].pictureBox.Click += (sender, args) => {OnCellClick(grid[linha, coluna]);};
                }  
            }
    

            Tabuleiro tabuleiro = new Tabuleiro(); //chama os metodos Tabuleiro0 e InicializarTabuleiro, mas não será necessario (ate então) usar esses metodos (motivo comentado na clase)
            //tabuleiro.Tabuleiro0();

        

            #endregion
        }

        

    }


}