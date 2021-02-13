using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> regularGuests = new HashSet<string>();
            HashSet<string> vipGuests = new HashSet<string>();

            string guestNumber = Console.ReadLine();

            while (guestNumber != "PARTY")
            {
                if (Char.IsDigit(guestNumber[0]))
                {
                    vipGuests.Add(guestNumber);
                }

                else
                {
                    regularGuests.Add(guestNumber);
                }

                guestNumber = Console.ReadLine();
            }

            string guest = Console.ReadLine();

            while (guest != "END")
            {
                if (vipGuests.Contains(guest))
                {
                    vipGuests.Remove(guest);
                }

                else if (regularGuests.Contains(guest))
                {
                    regularGuests.Remove(guest);
                }

                guest = Console.ReadLine();
            }

            Console.WriteLine(vipGuests.Count + regularGuests.Count);

            foreach (var eachGuest in vipGuests)
            {
                Console.WriteLine(eachGuest);
            }

            foreach (var eachGuest in regularGuests)
            {
                Console.WriteLine(eachGuest);
            }

        }
    }
}
