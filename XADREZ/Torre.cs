public class Torre : Peça
{
    public Torre(string cor, int x, int y) : base(cor,x,y){}
    public override bool VerificarMovimento()
    {
        // Implementar a lógica para verificar se o movimento do peão é válido
        return true; // Exemplo simples, substitua com lógica real
    }
}