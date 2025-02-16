using System;

public class Rei : Peça
{
    public Rei(string cor, int x, int y) : base(cor,x ,y){}
    public override bool VerificarMovimento()
    {
        throw new NotImplementedException(); // lógica de movimentação do rei
    }


private void InitializeComponent()
    {

        PictureBox rei = new PictureBox();
        rei.Location = new Point(30, 30);
        rei.Size = new Size(30, 30);
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
        
    }
}


