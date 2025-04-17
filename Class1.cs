using System;

    public class Box
    {
        public int Len { get; set; }  
        public int Wid { get; set; }    
        public int Hei { get; set; } 

        public Box(int length, int width, int height)
        {
            Len = length;
            Wid = width;
            Hei = height;
        }

        
        public Box(Box other)
        {
            Len = other.Len;
            Wid = other.Wid;
            Hei = other.Hei;
        }

        public int Product()
        {
            return Len * Wid * Hei;
        }

        public override string ToString()
        {
            return $"Параметры коробки: \nДлина = {Len} \nШирина = {Wid} \nВысота = {Hei}";
        }
    }