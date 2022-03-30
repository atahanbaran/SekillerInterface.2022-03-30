Robot robot = new Robot();
robot.MaasAl();

Bot bot = new Bot();
bot.Calis();
interface ICalisan
{
    void Calis();
    void YemekYe();

    void MaasAl();
}

class Yonetici : ICalisan
{
    public void Calis()
    {
        Console.WriteLine("Yönetici çalıştır.");
    }

    public void MaasAl()
    {
        Console.WriteLine("Yönetici maaş alır.");
    }

    public void YemekYe()
    {
        Console.WriteLine("Yönetici bol bol yemek yer.");
    }
}
class Calisan : ICalisan
{
    public void Calis()
    {
        Console.WriteLine("Calisan çalıştır.");
    }

    public void MaasAl()
    {
        Console.WriteLine("Calisan maaş alır.");
    }

    public void YemekYe()
    {
        Console.WriteLine("Calisan az az yemek yer.");
    }
}

class Robot : ICalisan
{
    public void Calis()
    {
        throw new NotImplementedException();
    }

    public void MaasAl()
    {
        throw new NotImplementedException();
    }

    public void YemekYe()
    {
        throw new NotImplementedException();
    }
}

interface ICalis
{
    void Calis();
}
interface IYemekYe
{
    void YemekYe();
}
interface IMaasAl
{
    void MaasAl();
}

class Isci : ICalis, IYemekYe, IMaasAl
{
    public void Calis()
    {
        Console.WriteLine("Isci çalıştır.");
    }

    public void MaasAl()
    {
        Console.WriteLine("Isci maaş alır.");
    }

    public void YemekYe()
    {
        Console.WriteLine("Isci az az yemek yer.");
    }
}

class Bot : ICalis
{
    public void Calis()
    {
        Console.WriteLine("Robot çalışır.");

    }
}
