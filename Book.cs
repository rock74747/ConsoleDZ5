using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace ConsoleDZ5
{
    public class Book( string name, string autor)
    {
        public string Name { get; set; } = name;
        public string Author { get; set; } = autor;
     

       
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public static bool operator ==(Book p1, Book p2)
        {
            return p1.Equals(p2);
        }
        public static bool operator !=(Book p1, Book p2)
        {
            return !(p1 == p2);
        }

        public override string ToString() 
        {
            return $" Название: {Name}, Автор: {Author}";
        }



    }
}
