using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueteLesConstructeurs
{
    public class Building
    {
        private int _nombreDEtages { get; set; }
        private int _hauter { get; set; }
        public Building(int nombreDEtages, int hauter) {
            _nombreDEtages = nombreDEtages;
            _hauter = hauter;
        }   

        public Building(int nombreDEtages) {
            _nombreDEtages = nombreDEtages;
            _hauter = 3 * nombreDEtages;
        }

        public int GetFloorMaxSize()
        {
            return _hauter/_nombreDEtages;   
        }

        public int GetFloorCount()
        {
            return _nombreDEtages;
        }

        public int GetSize()
        {
            return _hauter;
        }

        public void Display()
        {
            Console.WriteLine("The Max floorsize is " + GetFloorMaxSize());
            Console.WriteLine("The floor count is " + GetFloorCount());
            Console.WriteLine("The size of the building is " + GetSize());
        }
    }
}
