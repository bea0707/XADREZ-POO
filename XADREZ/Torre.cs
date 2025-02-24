public class Torre : Peça
{
    public Torre(string imagem, int x, int y) : base(imagem,x,y)
    {

        }
        

        
    
    public override bool VerificarMovimento() //metodo sobrescrito que verifica o movimento, falta criar a logica dele para cada peça
    {
        // Implementar a lógica para verificar se o movimento do peão é válido
        return true; // Exemplo simples, substitua com lógica real
    }


}