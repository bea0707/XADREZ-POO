public class Torre : Peça
{
    public Torre(string cor, int x, int y) : base(cor,x,y){}
    public override bool VerificarMovimento()
    {
        // Implementar a lógica para verificar se o movimento do peão é válido
        return true; // Exemplo simples, substitua com lógica real
    }


private void InitializeComponent()
{
        PictureBox torre = new PictureBox();
        torre.Location = new Point(30, 30);
        torre.Size = new Size(30, 30);
        torre.SizeMode = PictureBoxSizeMode.StretchImage;

        try{
            string path = Path.Combine(Application.StartupPath, "imagens", "torre.png");
            MessageBox.Show("Tentando carregar: " + path);
            torre.Image = Image.FromFile(path);

        }

        catch (Exception ex){
            MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
        }

        this.Controls.Add(torre);
        
    }

}