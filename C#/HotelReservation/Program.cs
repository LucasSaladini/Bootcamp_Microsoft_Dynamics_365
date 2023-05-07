using System.Text;
using HotelReservation.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Person> guests = new List<Person>();

Person p1 = new Person(name: "Hospede 1");
Person p2 = new Person(name: "Hospede 2");

guests.Add(p1);
guests.Add(p2);

Suite suite = new Suite(suiteType: "Premium", capacity: 2, dailyValue: 30);

Reservation reservation = new Reservation(daysReserved: 20);
reservation.RegisterSuite(suite);
reservation.RegisterGuest(guests);

Console.WriteLine($"Hóspedes: {reservation.GetGuestsQuantity()}");
Console.WriteLine($"Valor diária: {reservation.CalculateDailyValue()}");