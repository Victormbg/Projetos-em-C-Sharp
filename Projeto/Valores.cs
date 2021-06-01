class Valores
{
    private string valor1;
    private string valor2;

    public string Valor1
    {
        get { return valor1; }
        set { valor1 = value; }
    }
    public string Valor2
    {
        get { return valor2; }
        set { valor2 = value; }
    }
    public int soma(int a, int b)
    {
        return a + b;
    }
    public int subtracao(int a, int b)
    {
        return a - b;
    }
    public int multiplicacao(int a, int b)
    {
        return a * b;
    }
    public int divisao(int a, int b)
    {
        return a / b;
    }
}