class canlı
{
    public DateTime dtarihi;
    public DateTime otarihi;
    public int yas;
    public canlı()
    {
        Console.WriteLine("canlılar karmaşıktır");
    }
}
class insan : canlı
{
    public int  kno;
    public char cinsiyet;
    public string isim;

    public insan() 
    {
      Console.WriteLine("insan");
    }
}
class ogrenci :insan
{
    
    public string okuduğuüniversite;
    public int mezuniyetyılı;
    public string aldığıdersler;
    public string aldığınotlar;


    public ogrenci(int ogrvize,int ogrfinal) 
    {
        okuduğuüniversite = okuduguuni;
        mezuniyetyılı = mezunolmayili;
        aldığıdersler = dersler;
        aldığınotlar = notları;



    }
    static void Main()
    {
        ogrenci nesne = new ogrenci(56, 23);
        Console.WriteLine(nesne. + " " + nesne.final);
    }
}
