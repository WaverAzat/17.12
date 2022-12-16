using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tum13
{
    public class Buiding
    {
        public Buiding() { }
        public uint id, height, floors, flat_count, entrance_count;
        private static HashSet<uint> Last_Random_ID = new HashSet<uint>(0);
        public Buiding(uint id, uint height, uint floors, uint flat_count, uint entrance_count)
        {
            this.id = id;
            this.height = height;
            this.floors = floors;
            this.flat_count = flat_count;
            this.entrance_count = entrance_count;
        }
        public uint new_id()
        {
            Random r = new Random();
            id = (uint)r.Next(0, 255);
            if (!Last_Random_ID.Contains(id))
            {
                id++;
            }
            return id;
        }

        public void HeightOfFloor()
        {
            Console.WriteLine($"Height of floor is: {(double)height / (double)floors}");
        }
        public void FlatCountPerEntrance()
        {
            Console.WriteLine($"Flats per entrance: {flat_count / entrance_count}");
        }
        public void FlatCountPerFloor()
        {
            Console.WriteLine($"Flats per floor : {flat_count / entrance_count / floors}");
        }
        public void Print() => Console.WriteLine($"ID: {id}\nHeight: {height}\nFloors: {floors}\nAmount of flats: {flat_count}\nAmount of entrances: {entrance_count}");
    }
}
