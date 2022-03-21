using System;
using System.Collections.Generic;
using System.Collections;
namespace YieldPractice
{
    public class Agency 
    {
        public Car[] Cars { get; set; }

        //public bool MoveNext()
        //{
        //    int position = 0;
        //    position++;
        //    return (position < Cars.Length);
        //}


        public IEnumerator GetEnumerator()
        {
            IEnumerator enumerator = Cars.GetEnumerator();
            while (enumerator.MoveNext())
            {
                yield return enumerator.Current;
            }
        }

        public Car[] GetCars(string maker)
        {
             return Cars.Where(c => c.Maker == maker).ToArray();

        }

        //public Car[] GetCars(int modelYear)
        //{
        //    return Cars.Where(c => c.ModelYear == modelYear).ToArray();
        //}

        public IEnumerable<Car> GetCars(int modelYear)
        {
            foreach(var car in Cars)
            {
                if (car.ModelYear == modelYear)
                    yield return car;
            }
        }
    }
}



