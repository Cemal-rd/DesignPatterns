using System;

// Hedef Arayüz
interface IMediaPlayer
{
    void Play(string fileName);
}

// Adapte Edilen Sınıf - MP3 Çalıcı
class Mp3Player
{
    public void PlayMp3(string fileName)
    {
        Console.WriteLine("MP3 dosyası çalınıyor: " + fileName);
    }
}

// Adaptör
class Mp3ToMediaPlayerAdapter : IMediaPlayer
{
    private Mp3Player mp3Player;

    public Mp3ToMediaPlayerAdapter(Mp3Player mp3Player)
    {
        this.mp3Player = mp3Player;
    }

    public void Play(string fileName)
    {
        mp3Player.PlayMp3(fileName);
    }
}

// İstemci
class Client
{
    public void Run(IMediaPlayer mediaPlayer, string fileName)
    {
        mediaPlayer.Play(fileName);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Adapte edilen sınıf örneği
        Mp3Player mp3Player = new Mp3Player();

        // Adaptör aracılığıyla Mp3Player sınıfının metodu IMediaPlayer arayüzüne dönüştürülüyor
        IMediaPlayer adapter = new Mp3ToMediaPlayerAdapter(mp3Player);

        // İstemci, hedef arayüz üzerinden işlem yapar
        Client client = new Client();
        client.Run(adapter, "song.mp3");

        Console.ReadLine();
    }
}
