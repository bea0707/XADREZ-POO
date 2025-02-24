using System;

public class Bispo : Peça
{
    public Bispo(string imagem, int x, int y) : base(imagem, x, y)
    {
       /*
        PictureBox bispo = new PictureBox();
        bispo.Location = new Point(30, 30); //construtor que cria os objetos com imagens
        bispo.Size = new Size(30, 30);
        bispo.SizeMode = PictureBoxSizeMode.StretchImage;

        try{
            string path = Path.Combine(Application.StartupPath, "imagens", imagem);
            MessageBox.Show("Tentando carregar: " + path);
            bispo.Image = Image.FromFile(path);

        }

        catch (Exception ex){
            MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
        }
*/

    }

    public override bool VerificarMovimento() //metodo sobrescrito que verifica o movimento, falta criar a logica dele para cada peça
    {
        return true ; // lógica de movimentação do cavalo
    }

}