using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Transform.position=new Vector2D(100.0f, 100.0f);
            Bossenemy boss = new Bossenemy("b");
            boss.Firebullet();
            boss.Transform.position = new Vector2D(70.0f, 98.0f);
            Enemy genemy = new Enemy("g");
            Enemy renemy = new Enemy("r");
            Console.WriteLine(player.ToString());
            Console.WriteLine(genemy.ToString());
            genemy.Transform.position = new Vector2D(70.0f,98.0f);
            Console.WriteLine(renemy.ToString());
            genemy.Firebullet();
            renemy.Firebullet();
            renemy.Transform.position = new Vector2D(70.0f, 98.0f);
        }
    }
}
