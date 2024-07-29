namespace CarData
{
    public class Car
    {
        public string Make { set; get; }
        public string Model { set; get; }
        public decimal RentalPrice { set; get; }
        public bool Rented { set; get; }
        public Car(string make, string model, decimal rentalPrice, bool rented)
        {
            Make = make;
            Model = model;
            RentalPrice = rentalPrice;
            Rented = rented;
        }

        public void Rent()
        {
            Rented = true;
        }

        public void Return()
        {
            Rented = false;
        }

        public string CarName()
        {
            return $"{Make} {Model}";
        }

        public override string ToString()
        {
            string rentedStatus = Rented ? "Rented" : "Available";
            return $"{CarName()} (Rental Price: {RentalPrice}/day) - {rentedStatus}";
        }
    }
}
