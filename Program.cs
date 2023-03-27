using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace modul6_1302210057
{
    
}

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random r = new Random();
        this.id = r.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }
    public void increasePlayCount(int tambahan)
    {
        this.playCount+= tambahan;
    }
    public void printVideoDetails()
    {
        Console.WriteLine(this.title);
        Console.WriteLine(this.id);
        Console.WriteLine(this.playCount);
    }
    public int getPlayCount()
    {
        return this.playCount;
    }
    public string getTitle() { 
    return this.title;
    }
}
public class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos = new List<SayaTubeVideo>();
    public string Username;
    public SayaTubeUser(string Userrname)
    {
        Random r = new Random();
        this.id = r.Next(10000, 99999);
        this.Username= Userrname;
    }
    public List<SayaTubeVideo> getSayaTubeVideos()
    {
        return uploadedVideos;
    }
    public void getTotalVideoPlayCount()
    {
        int total_play_count = 0;
        foreach (var video in uploadedVideos)
        {
            video.getPlayCount();
        }
    }public void AddVideo(SayaTubeVideo video)
    {
        this.uploadedVideos.Add(video);
    }
    public void printAllVideoPlayCount()
    {
        Console.WriteLine("User: "+ this.Username);
        foreach (var video in uploadedVideos)
        {
        Console.WriteLine("Video : "+ video.getTitle());

        }

    }
}

public class Program
{
    public static void Main()
    {
    SayaTubeUser sayaTubeUser = new SayaTubeUser("Tio Haidar");
        Console
            .WriteLine();
            
           

        for(int i = 1;i <= 10; i++)
        {
    sayaTubeUser.AddVideo(new SayaTubeVideo("judul " + i));

        }
        foreach (var film in sayaTubeUser.getSayaTubeVideos())
       
        {
            Console.WriteLine("Review Film " + film.getTitle() + " oleh " + sayaTubeUser.Username);
        }
        sayaTubeUser.printAllVideoPlayCount();

    }
}