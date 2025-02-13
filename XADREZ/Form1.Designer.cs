namespace XADREZ;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private const int GridSize = 8;
    private Button[,] grid = new Button[GridSize, GridSize];
   


    /// <summary>
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
        for (int linha = 0; linha < GridSize; linha++)
        {
            for (int coluna = 0; coluna < GridSize; coluna++)
            {
                Button botao = new Button();
                botao.Size = new Size(50, 50);
                botao.Location = new Point(50 * linha, 50 * coluna);
               
                int x = linha;
                int y = coluna;
               
                grid[linha, coluna] = botao;
                this.Controls.Add(botao);
            }
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(850, 850);
        this.Text = "xadrez";


        PictureBox rei = new PictureBox();
        rei.Location = new Point(50, 50);
        rei.Size = new Size(50, 50);
        rei.SizeMode = PictureBoxSizeMode.StretchImage;


        try{
            string path = Path.Combine(Application.StartupPath, "imagens", "rei.png");
            MessageBox.Show("Tentando carregar: " + path);
            rei.Image = Image.FromFile(path);


        }


        catch (Exception ex){
            MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
        }


        this.Controls.Add(rei);


        PictureBox rainha = new PictureBox();
        rainha.Location = new Point(50, 50);
        rainha.Size = new Size(50, 50);
        rainha.SizeMode = PictureBoxSizeMode.StretchImage;


        try{
            string path = Path.Combine(Application.StartupPath, "imagens", "rainha.png");
            MessageBox.Show("Tentando carregar: " + path);
            rainha.Image = Image.FromFile(path);


        }


        catch (Exception ex){
            MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
        }


        this.Controls.Add(rainha);


        PictureBox torre = new PictureBox();
        torre.Location = new Point(50, 50);
        torre.Size = new Size(50, 50);
        torre.SizeMode = PictureBoxSizeMode.StretchImage;


        try{
            string path = Path.Combine(Application.StartupPath, "imagens", "torre.png");
            MessageBox.Show("Tentando carregar: " + path);
            torre.Image = Image.FromFile(path);


        }


        catch (Exception ex){
            MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
        }


        this.Controls.Add(torre);


        PictureBox cavalo = new PictureBox();
        cavalo.Location = new Point(50, 50);
        cavalo.Size = new Size(50, 50);
        cavalo.SizeMode = PictureBoxSizeMode.StretchImage;


        try{
            string path = Path.Combine(Application.StartupPath, "imagens", "cavalo.png");
            MessageBox.Show("Tentando carregar: " + path);
            cavalo.Image = Image.FromFile(path);


        }


        catch (Exception ex){
            MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
        }


        this.Controls.Add(cavalo);
       
        PictureBox bispo = new PictureBox();
        bispo.Location = new Point(50, 50);
        bispo.Size = new Size(50, 50);
        bispo.SizeMode = PictureBoxSizeMode.StretchImage;


        try{
            string path = Path.Combine(Application.StartupPath, "imagens", "bispo.png");
            MessageBox.Show("Tentando carregar: " + path);
            bispo.Image = Image.FromFile(path);


        }


        catch (Exception ex){
            MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
        }


        this.Controls.Add(bispo);
       
        PictureBox peao = new PictureBox();
        peao.Location = new Point(50, 50);
        peao.Size = new Size(50, 50);
        peao.SizeMode = PictureBoxSizeMode.StretchImage;


        try{
            string path = Path.Combine(Application.StartupPath, "imagens", "peao.png");
            MessageBox.Show("Tentando carregar: " + path);
            peao.Image = Image.FromFile(path);


        }


        catch (Exception ex){
            MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
        }


        this.Controls.Add(peao);
       
    }


    #endregion
}
}


