using System.Diagnostics;
using System.Diagnostics.Contracts;


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
        Debug.Assert(title.Length< 200);
        Debug.Assert(title != null);
        Random r = new Random();
        this.id = r.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }
    public void increasePlayCount(int tambahan)
    {
        Debug.Assert(tambahan <25000000);
        Debug.Assert(tambahan >= 0);
        try
        {

        this.playCount+= tambahan;
        }
        catch (Exception e)
        {

            Console.WriteLine(e.ToString);
        }
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
    public SayaTubeUser(String Username)
    {  Debug.Assert(Username != null);
            Debug.Assert(Username.Length <= 100);


        Random r = new Random();
        this.id = r.Next(10000, 99999);
        this.Username= Username;
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
        Debug.Assert(video != null);
        Debug.Assert(video.getPlayCount() <99999999);


        this.uploadedVideos.Add(video);
    }
    public void printAllVideoPlayCount()
    {
        Console.WriteLine("User: "+ this.Username);
        Contract.Ensures(uploadedVideos.Count <= 8);
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
        for (int i = 0; i < 777; i++)
        {
            sayaTubeUser.getSayaTubeVideos()[2].increasePlayCount(1000000);
        }
    }
}