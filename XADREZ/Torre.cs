public class Torre : Peça, IMovivel
{
    public Torre(string imagem, int x, int y, enumCor cor) : base(imagem,x,y,cor)
    {

        }
        

        
    
    public bool VerificarMovimento() //metodo sobrescrito que verifica o movimento, falta criar a logica dele para cada peça
    {
        // Implementar a lógica para verificar se o movimento do peão é válido
        return true; // Exemplo simples, substitua com lógica real
    }


}