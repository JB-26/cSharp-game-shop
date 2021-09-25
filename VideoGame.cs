class VideoGame
{
    public string name { get; set; }
    public string publisher { get; set; }
    public string platform { get; set; }

    public double pricePounds {get; set;}

    public double id {get; set;}

    public void PrintGame()
    {
        System.Console.WriteLine($"ID: {this.id}\nGame name: {this.name}\nPublisher: {this.publisher}\nPlatform: {this.platform}\nPrice £{this.pricePounds}");
    }

    public string GameDetails()
    {
        return ($"ID: {this.id}\nGame name: {this.name}\nPublisher: {this.publisher}\nPlatform: {this.platform}\nPrice £{this.pricePounds}\n\n");
    }
}