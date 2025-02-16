using System;
public class Rainha : Peça 
{
    public Rainha(string cor, int x, int y) : base(cor, x , y) {}

    public override bool VerificarMovimento()
    {
        throw new NotImplementedException(); // lógica de movimentação da rainha
    }


    private void InitializeComponent()
    {
            PictureBox rainha = new PictureBox();
            rainha.Location = new Point(30, 30);
            rainha.Size = new Size(30, 30);
            rainha.SizeMode = PictureBoxSizeMode.StretchImage;

            try
            {
                string path = Path.Combine(Application.StartupPath, "imagens", "rainha.png");
                MessageBox.Show("Tentando carregar: " + path);
                rainha.Image = Image.FromFile(path);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
            }

            this.Controls.Add(rainha);
            
    }
}

