using System;
namespace ChinOfResponsibilityPractice
{
    public class Car
    {
        public string Model { get; set; }

        public bool HasProblam { get; set; }

        public string Error { get; set; }

    }

    public abstract class Check
    {
        protected Check _Next;

        public void SetNext(Check next)
        {
            _Next = next;
        }

        public abstract void HandleRequest(Car car);
    }

    public class BasicCarHandler :Check
    {
        public override void HandleRequest(Car car)
        {
            int testResult = new Random().Next(1, 10);
            if (testResult <= 5)
            {
                car.HasProblam = true;
                car.Error = "Problam found in Basic Check ";
            }
            else
            {
                car.HasProblam = false;
                if(_Next !=null)
                {
                    _Next.HandleRequest(car);
                }
            }
        }
        
    }

    class MechanicHandler : Check
    {

        public override void HandleRequest(Car car)
        {
            int testResult = new Random().Next(1, 10);
            if (testResult <= 5)
            {
                car.HasProblam = true;
                car.Error = "Problam found in Mechanic Check ";
            }
            else
            {
                car.HasProblam = false;
                if (_Next != null)
                {
                    _Next.HandleRequest(car);
                }
            }
        }
    }

    class ElectricianHandler : Check
    {

        public override void HandleRequest(Car car)
        {
            int testResult = new Random().Next(1, 10);
            if (testResult <= 5)
            {
                car.HasProblam = true;
                car.Error = "Problam found in Electrican Check ";
            }
            else
            {
                car.HasProblam = false;
                if (_Next != null)
                {
                    _Next.HandleRequest(car);
                }
            }
        }

    }

    class ExpertHandler : Check
    {

        public override void HandleRequest(Car car)
        {
            int testResult = new Random().Next(1, 10);
            if (testResult <= 5)
            {
                car.HasProblam = true;
                car.Error = "Problam found in Expert Check ";
            }
            else
            {
                car.HasProblam = false;
                if (_Next != null)
                {
                    _Next.HandleRequest(car);
                }
            }
        }

    }





}

