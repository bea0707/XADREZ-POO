using System;

public class Cavalo : Peça
{
    public Cavalo(string cor, int x, int y) : base(cor, x, y) {}

    public override bool VerificarMovimento()
    {
        return true ; // lógica de movimentação do cavalo
    }


private void InitializeComponent()
    {
        PictureBox cavalo = new PictureBox();
        cavalo.Location = new Point(30, 30);
        cavalo.Size = new Size(30, 30);
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
        
    }
}