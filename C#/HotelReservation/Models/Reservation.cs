using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservation.Models
{
    public class Reservation
    {
        public List<Person> Guests { get; set; }
        public Suite Suite { get; set; }
        public int ReservedDays { get; set; }

        public Reservation() { }

        public Reservation(int daysReserved)
        {
            ReservedDays = daysReserved;
        }

        public void RegisterGuest(List<Person> guests)
        {
            if (Suite.Capacity >= guests.Count)
            {
                Guests = guests;
            }
            else
            {
                throw new Exception("Capacidade menor do que o número de hóspedes");
            }
        }

        public void RegisterSuite(Suite suite)
        {
            Suite = suite;
        }

        public int GetGuestsQuantity()
        {
            return Guests.Count;
        }

        public decimal CalculateDailyValue()
        {
            decimal value = ReservedDays * Suite.DailyValue;

            if (ReservedDays >= 10)
            {
                value -= Decimal.Divide(Decimal.Multiply(value, 10), 100);
            }

            return value;
        }
    }
}