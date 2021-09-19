class VideoGame
{
    public string name { get; set; }
    public string publisher { get; set; }
    public string platform { get; set; }

    public double pricePounds {get; set;}

    public void PrintGame(string name, string publisher, string platform, double pricePounds)
    {
        System.Console.WriteLine($"Game name: {name}\nPublisher: {publisher}\nPlatform: {platform}\nPrice £{pricePounds}");
    }
}