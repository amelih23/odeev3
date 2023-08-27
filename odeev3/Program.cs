using System.Threading.Channels;

public abstract class Hayvanlar
{
    public string isim;
    public string tur;
    public int yas;
    public Hayvanlar()
    {
        
    }
    public Hayvanlar(string isim,string tur,int yas)
    {
        this.isim = isim;
        this.tur = tur;
        this.yas = yas;
    }
    public void bilgiler()
    {
        Console.WriteLine($"Hayvanın adı:{isim}\nHayvanın türü:{tur}\nHayvanın yaşı:{yas}");
    }
    public virtual void sescikar()
    {
        Console.WriteLine("ses çıkarıyorum");
    }
}
public class Kus : Hayvanlar
{
    public Kus()
    {
        this.isim = "bay kus";
        this.tur = "kuş";
        this.yas = 1;
    }
    public override void sescikar()
    {
        Console.WriteLine("cik cik cik"); ;
    }
}
public class Kedi : Hayvanlar
{
    public Kedi()
    {
        this.isim = "bay kedi";
        this.tur = "kedi";
        this.yas=2;
    }
    public override void sescikar()
    {
        Console.WriteLine("miyav miyav miyav");
    }

}
public class Kopek : Hayvanlar
{
    public Kopek()
    {
        this.isim = "bay köpek";
        this.tur = "köpek";
        this.yas = 2;
    }
    public override void sescikar()
    {
        Console.WriteLine("hav hav hav");
    }

}
class AMP
{
   static void Main(string[] args)
    {
        Kus k1=new Kus();
        k1.bilgiler();
        k1.sescikar();
        Kopek k2= new Kopek();
        k2.bilgiler();
        k2.sescikar();
        Kedi k3= new Kedi();
        k3.bilgiler();
        k3.sescikar();
        
    }
}

