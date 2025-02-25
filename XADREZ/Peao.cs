using System;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
public class Peao : Peça, IMovivel
{
    public Peao(string imagem, int x, int y, enumCor cor) : base(imagem, x, y, cor) 
    {
      
    
    }

    public bool VerificarMovimento() //metodo sobrescrito que verifica o movimento, falta criar a logica dele para cada peça
    {
        return true; // logica de movimentação do peão
    }


}