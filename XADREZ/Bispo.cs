using System;

public class Bispo : Peça
{
    public Bispo(string cor, int x, int y) : base(cor, x, y){}
    public override bool VerificarMovimento()
    {
        throw new NotImplementedException(); // lógica de movimentação do bispo 
    }


    private void InitializeComponent()
{
        PictureBox bispo = new PictureBox();
        bispo.Location = new Point(30, 30);
        bispo.Size = new Size(30, 30);
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
        
    }

}