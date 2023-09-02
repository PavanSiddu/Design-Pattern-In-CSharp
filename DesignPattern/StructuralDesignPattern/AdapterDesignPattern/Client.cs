using System;

namespace DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    public class Client
    {
        public static void Main(string[] args)
        {
            GalleryApp gallery = new GalleryApp();

            gallery.Show("jpeg", "naruto.jpeg");
            gallery.Show("png", "sasuke.png");
            gallery.Show("jpg", "jiraya.jpg");
            gallery.Show("gif", "sakura.gif");

            Console.ReadLine();
        }
    }

    //The Adapter Design Pattern is a structural design pattern and is also known as the Wrapper Design Pattern.
    //This design pattern acts as a bridge between two different interfaces.
    //It can convert the interface of a class, to make it compatible with a client who is expecting a different interface, without changing the source code of the class.
}
