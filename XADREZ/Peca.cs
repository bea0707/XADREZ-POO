using System;

public abstract class Peça{
    public string Cor {get; set;} // cor da peça
    public int X{get; set;} // linha 
    public int Y {get; set;} // coluna

    public Peça(string cor, int x, int y){
        this.Cor = cor;
        this.X = x;
        this.Y = Y;
    }

    public abstract bool VerificarMovimento(); // esse metodo precisa ser sobrescrito em todas as classes filhas e ao sobrescrever, tem que criar uma logica para verificar se o movimento é valido pra aquela peça
}