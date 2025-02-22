class CasaVazia : Peça
{

    public CasaVazia(string imagem, int x, int y) : base(imagem, x, y)
        {
        
        PictureBox casa = new PictureBox();
        casa.Location = new Point(x, y);
        casa.Size = new Size(50, 50); //construtor que cria os objetos com imagens
        casa.SizeMode = PictureBoxSizeMode.StretchImage;

        try{
            string path = Path.Combine(Application.StartupPath, "imagens", imagem);
            MessageBox.Show("Tentando carregar: " + path);
            casa.Image = Image.FromFile(path);

        }

        catch (Exception ex){
            MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
        }
            
        }


     public override bool VerificarMovimento() {return true;}
        
    
}