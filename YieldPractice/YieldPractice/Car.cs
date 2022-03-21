using System;
namespace YieldPractice
{
	public class Car 
	{
		public string Maker { get; set; }

		public int ModelYear { get; set; }

		public override string ToString()
        {
			return $"{ModelYear}, {Maker}";
		}


	}
}

