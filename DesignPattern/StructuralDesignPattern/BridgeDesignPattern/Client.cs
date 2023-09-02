using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralDesignPattern.BridgeDesignPattern
{
    public class Client
    {
        public static void Main(string[] args)
        {
            IResource my_artist = new Artist();
            View artist_view = new LongView(my_artist);

            IResource my_album = new Album();
            View album_view = new LongView(my_album);
            artist_view.Show();
            album_view.Show();

            Console.ReadLine();
        }
    }

    //The bridge design pattern is a type of structural design pattern which is used to split a large class into two separate inheritance hierarchies(a collection of 'is-a' relationships);
    //one for the implementations and one for the abstractions.
    //These hierarchies are then connected to each other via object composition, forming a bridge-like structure. This pattern is also known as the Handle-Body Design Pattern.
}
