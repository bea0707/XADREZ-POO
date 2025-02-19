using System;

public class Rei : Peça
{
    public Rei(string cor, int x, int y) : base(cor,x ,y) 
    {
        PictureBox rei = new PictureBox();
        rei.Location = new Point(30, 30); //construtor que cria os objetos com imagens
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

        
    }
    public override bool VerificarMovimento() //metodo sobrescrito que verifica o movimento, falta criar a logica dele para cada peça
    {
        throw new NotImplementedException(); // lógica de movimentação do rei
    }


}


