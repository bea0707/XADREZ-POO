public class Torre : Peça
{
    public Torre(string imagem, int x, int y) : base(imagem,x,y)
    {
            PictureBox torre = new PictureBox();
            torre.Location = new Point(30, 30);
            torre.Size = new Size(30, 30);
            torre.SizeMode = PictureBoxSizeMode.StretchImage;

            try{
                string path = Path.Combine(Application.StartupPath, "imagens", imagem);
                MessageBox.Show("Tentando carregar: " + path);
                torre.Image = Image.FromFile(path);

            }

            catch (Exception ex){
                MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
            }
        }

        
    
    public override bool VerificarMovimento() //metodo sobrescrito que verifica o movimento, falta criar a logica dele para cada peça
    {
        // Implementar a lógica para verificar se o movimento do peão é válido
        return true; // Exemplo simples, substitua com lógica real
    }


}