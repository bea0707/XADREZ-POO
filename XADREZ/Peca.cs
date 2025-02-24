using System;

public abstract class Peça{
    public string imagem {get; set;} // cor da peça
    public int x{get; set;} // linha 
    public int y {get; set;} // coluna
    public PictureBox pictureBox = new PictureBox();

   
    public Peça(string imagem, int x, int y){
        this.imagem = imagem;
        this.x = x/50;
        this.y = y/50;

        pictureBox.Location = new Point(x , y);
        pictureBox.Size = new Size(50, 50); // O Tamanho é fixo
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        
        try{
            this.imagem = Path.Combine(Application.StartupPath, "imagens", imagem);
             pictureBox.Image = Image.FromFile(this.imagem); 
             
        }catch (Exception ex){
            MessageBox.Show("Erro ao carregar imagem: " + ex.Message);  
        }
    }
    

   // public abstract bool VerificarMovimento(); // esse metodo precisa ser sobrescrito em todas as classes filhas e ao sobrescrever, tem que criar uma logica para verificar se o movimento é valido pra aquela peça
}