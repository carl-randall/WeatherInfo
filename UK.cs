﻿namespace WeatherInfo
{
    public class UnitedKingdom
    {
        public int Identifier { get; set; }       
        public required string Label {get; set;}
        
    }

     public record Coordinates(int Lat, int Lon);  

     
}
