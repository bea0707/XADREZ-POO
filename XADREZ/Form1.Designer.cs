namespace XADREZ;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private const int GridSize = 8;
    private Button[,] grid = new Button[GridSize, GridSize]; //cria uma matriz generica com 8/8 de tamanho para armazenar os botões
   


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

        this.Controls.Add(rei); //adiciona o picturebox do rei na tela (o metodo Controls so aceita tipos do winforms, por exemplo, o picture box)



        for (int linha = 0; linha < GridSize; linha++)
        {
            for (int coluna = 0; coluna < GridSize; coluna++)
            {
                Button botao = new Button();
                botao.Size = new Size(50, 50);
                botao.Location = new Point(50 * linha, 50 * coluna); //loop que cria os botoes na tela
               
                int x = linha;
                int y = coluna;
               
                grid[linha, coluna] = botao;
                this.Controls.Add(botao);
            }  
        }
    
    

        Tabuleiro tabuleiro = new Tabuleiro(); //chama os metodos Tabuleiro0 e InicializarTabuleiro, mas não será necessario (ate então) usar esses metodos (motivo comentado na clase)
        //tabuleiro.Tabuleiro0();



        


        #endregion
    }
}


