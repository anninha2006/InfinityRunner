using FFImageLoading.Maui;

namespace InfinityRunner;
public class Animacao
{
    protected List <String> animacao1=new List<String>();
	protected List <String> animacao2=new List<String>();
	protected List <String> animacao3=new List<String>();
	protected bool loop=true;
	protected int animacaoAtiva=1;
    bool parado=true;
	int frameAtual=1;
	protected CachedImageView imageView; 
    
	public Animacao (CachedImageView a)
	{
		imageView=a;
	}
    public void Stop()
    {
        parado=true;
    }
    public void Play()
    {
        parado=false;
    }
    public void SetAnimacaoAtiva(int a)
    {
        animacaoAtiva=a;
    }
    public void Desenha()
    {
        if(parado)
            return;
        string nomeArquivo = "";
        int tamanhoanimacao = 0;
        if(animacaoAtiva==1)
        {
            nomeArquivo= animacao1[frameAtual];
            tamanhoanimacao=animacao1.Count;
        }
         else if (animacaoAtiva == 2)
        {
            nomeArquivo = animacao2 [frameAtual];
            tamanhoanimacao = animacao2.Count;
        }
        else if (animacaoAtiva==3)
        {
            nomeArquivo=animacao3[frameAtual];
            tamanhoanimacao=animacao3.Count;
        }
        imageView.Source=ImageSource.FromFile(nomeArquivo);
        frameAtual++;
        if(frameAtual >= tamanhoanimacao)
        {
            if(loop)
                frameAtual=0;
            else
            {
                parado=true;
                QuandoParar();
            }
        }
    }

    public virtual void QuandoParar()
    {

    }
}