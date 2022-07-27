using YourGarage;
{
	//Build a collection of all vehicles that fly
	Boeing747 wesPlane = new Boeing747(100, "Ruby Red", 350, false, true);
	Boeing747 mikePlane = new Boeing747(25, "Yellow", 25, true, false);
	List<Boeing747> flyers = new List<Boeing747>()
	{
		wesPlane,
		mikePlane
	};

	//With a single `foreach1, have each vehicle Fly()
	foreach(Boeing747 flyer in flyers) { flyer.Flying(); }

	//Build a collection of all vehicles that operate on roads
	Car semiTruck = new Car();
	Car sedan = new Car();
	List<Car> cars = new List<Car>()
    {
		semiTruck,
		sedan
    };
	//With a single `foreach`, have each road vehicle Drive()
	foreach(Car car in cars) { car.Driving(); }

	//Build a collection of all vehicles that operate on water
	Watercraft boat = new Watercraft();
	Watercraft sailBoat = new Watercraft();
	List<Watercraft> watercrafts = new List<Watercraft>()
	{
		boat,
		sailBoat
	};

	//With a single `foreach, have each water vehicle Drive()

	foreach (Watercraft watercraft1 in watercrafts) { watercraft1.Driving(); }
}