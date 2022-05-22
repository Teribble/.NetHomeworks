namespace Delivery
{
    public abstract class Food
    {
        public abstract FoodType Type { get;}
        public abstract string Name { get; set; }
        public abstract float Calories { get; set; }
        public abstract decimal Price { get; set; }
        public override string ToString()
        {
            return "Type: " + Type + "\nName: " + Name + "\nCalories: " + Calories + "\nPrice: " + Price;
        }
    }
}
