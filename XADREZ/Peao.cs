using System;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
public class Peao : Peça{
    public Peao(string cor, int x, int y) : base(cor, x, y) 
    {
        PictureBox peao = new PictureBox();
        peao.Location = new Point(30, 30);
        peao.Size = new Size(30, 30); //construtor que cria os objetos com imagens
        peao.SizeMode = PictureBoxSizeMode.StretchImage;

        try{
            string path = Path.Combine(Application.StartupPath, "imagens", "peao.png");
            MessageBox.Show("Tentando carregar: " + path);
            peao.Image = Image.FromFile(path);

        }

        catch (Exception ex){
            MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
        }

    }

    public override bool VerificarMovimento() //metodo sobrescrito que verifica o movimento, falta criar a logica dele para cada peça
    {
        return true; // logica de movimentação do peão
    }


}