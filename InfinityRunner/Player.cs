using FFImageLoading.Maui;
namespace InfinityRunner;

public delegate void Callback();
public class Player : Animacao
{
    public Player (CachedImageView a) : base (a)
    {
        for (int i = 1; i <= 6; i++)
        {
            animacao1.Add ($"carro{i.ToString("D2")}.png");
        }
         for (int i = 1; i <=27 ; i++)
        {
           animacao2.Add ($"morte{i.ToString("D2")}.png");
        }
        SetAnimacaoAtiva(1);
    }
    public void Die()
    {
        loop = false;
        SetAnimacaoAtiva(2);
    }
    public void Run()
    {
        loop=true;
        SetAnimacaoAtiva(1);
        Play();
    }
     public void MoveY (int s)
     {
        imageView.TranslationY += s;
     }
     public double GetY()
     {
        return imageView.TranslationY;
     }

     public void SetY(double a)
     {
        imageView.TranslationY=a;
     }
}