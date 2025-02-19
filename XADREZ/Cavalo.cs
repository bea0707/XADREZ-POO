using System;

public class Cavalo : Peça
{
    public Cavalo(string cor, int x, int y) : base(cor, x, y)
     {
        PictureBox cavalo = new PictureBox();
        cavalo.Location = new Point(30, 30);
        cavalo.Size = new Size(30, 30); //construtor que cria os objetos com imagens
        cavalo.SizeMode = PictureBoxSizeMode.StretchImage;

        try{
            string path = Path.Combine(Application.StartupPath, "imagens", "cavalo.png");
            MessageBox.Show("Tentando carregar: " + path);
            cavalo.Image = Image.FromFile(path);

        }

        catch (Exception ex){
            MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
        }

     }

    public override bool VerificarMovimento() //metodo sobrescrito que verifica o movimento, falta criar a logica dele para cada peça
    {
        return true ; // lógica de movimentação do cavalo
    }

}