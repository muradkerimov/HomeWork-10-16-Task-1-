using System;

namespace HomeWork_10_16_Task_1_
{
    class Advertisement : IComparable
    {
        public string AddName { get; set; }
        public double Price { get; set; }
        public string OwnerAdd { get; set; }

        public Category category;

        public Advertisement()
        {

        }

        public Advertisement(string addName, double price, string ownerAdd)
        {
            AddName = addName;
            Price = price;
            OwnerAdd = ownerAdd;
        }

        public override string ToString()
        {
            return $"{AddName} {Price} {OwnerAdd}";
        }

        public static bool operator <(Advertisement ad1, Advertisement ad2)
        {
            return ad1.Price < ad2.Price;
        }

        public static bool operator >(Advertisement ad1, Advertisement ad2)
        {
            return ad1.Price > ad2.Price;
        }

        public int CompareTo(object obj)
        {
            return Price.CompareTo(((Advertisement)obj).Price);
        }
    }
}
