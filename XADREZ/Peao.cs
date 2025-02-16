using System;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
public class Peao : Peça{
    public Peao(string cor, int x, int y) : base(cor, x, y) {}

    public override bool VerificarMovimento()
    {
        return true; // logica de movimentação do peão
    }


private void InitializeComponent()
{
        PictureBox peao = new PictureBox();
        peao.Location = new Point(30, 30);
        peao.Size = new Size(30, 30);
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

}