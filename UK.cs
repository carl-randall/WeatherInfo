namespace WeatherInfo
{
    public class UnitedKingdom
    {
        public int Identifier { get; set; }       
        public string Label {get; set;}
        
    }

     public record Coordinates(int Lat, int Lon);  

     
}
