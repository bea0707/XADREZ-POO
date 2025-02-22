using System;

public abstract class Peça{
    public string imagem {get; set;} // cor da peça
    public int x{get; set;} // linha 
    public int y {get; set;} // coluna

    public Peça(string imagem, int x, int y){
        this.imagem = imagem;
        this.x = x;
        this.y = y;
    }

    public abstract bool VerificarMovimento(); // esse metodo precisa ser sobrescrito em todas as classes filhas e ao sobrescrever, tem que criar uma logica para verificar se o movimento é valido pra aquela peça
}