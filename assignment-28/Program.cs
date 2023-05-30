namespace assignment_28
{
	public class Car
	{
		public string name;
		public float mileage;
		public float maxSpeed;
        public Car(string name, float mileage, float maxSpeed)
        {
            this.name = name;
			this.mileage = mileage; 
			this.maxSpeed = maxSpeed;
        }
    }
	internal class Program
	{
		static void Main(string[] args)
		{
			Car car = new Car("Honda", 40, 200);
            Console.WriteLine("Name : " + car.name);
            Console.WriteLine("Mileage : " + car.mileage);
            Console.WriteLine("Max Speed : " + car.maxSpeed);
        }
	}
}