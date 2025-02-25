using System;

public enum enumCor{branco = 0, preto = 1, vazio = 2};

public abstract class Peça{
    public string imagem {get; set;} // cor da peça
    public int x{get; set;} // linha 
    public int y {get; set;} // coluna
    public enumCor cor {get; set;}

    public PictureBox pictureBox = new PictureBox();

   
    public Peça(string imagem, int x, int y, enumCor cor){
        this.imagem = imagem;
        this.x = x/50;
        this.y = y/50;
        this.cor = cor;

        pictureBox.Location = new Point(x , y);
        pictureBox.Size = new Size(50, 50); // O Tamanho é fixo
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        
        try
        {
            this.imagem = Path.Combine(Application.StartupPath, "imagens", imagem);
            pictureBox.Image = Image.FromFile(this.imagem); 
             
        }catch (Exception ex)
        {
            MessageBox.Show("Erro ao carregar imagem: " + ex.Message);  
        }
    }
    

}