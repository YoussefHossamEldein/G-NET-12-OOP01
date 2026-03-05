using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01OOP
{
    internal class Ticket
    {
        public string? MovieName { get; set; }
        public TicketType Type { get; set; }
        public Seat Seat { get; set; }
        private double Price { get; set; }

        public Ticket(string movie,TicketType type,Seat seat,int price)
        {
            MovieName = movie;
            Type = type;
            Seat = seat;
            Price = price;
        }
        public Ticket(string movie) : this( movie,TicketType.Standard,new Seat('A',1), 50) { 
        }
        public Ticket() { }
        public void SetPrice(double price)
        {
            Price = price;
        }
        public double CalcTotal(double taxPercent)
        {
            return Price + (Price * (taxPercent/100.0));
        }
        public void ApplyDiscount (double discountAmmount)
        {
            if(discountAmmount > 0 && discountAmmount <= Price)
            {
                Price -= discountAmmount;
                discountAmmount = 0;
            }
        }
        public   void PrintTicket()
        {
            double tax;
            Console.WriteLine("===== Ticket Info =====");
            Console.WriteLine($"Movie      : {MovieName}");
            Console.WriteLine($"Type       : {Type}");
            Console.WriteLine($"Seat       : {Seat}");
            Console.WriteLine($"Price      : {Price:C}");
            
        }


    }
}
