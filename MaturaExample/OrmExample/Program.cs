using System.IO.Compression;
using Models;
using Models.DB;

namespace OrmExample {
    public class Program {
        public static void Main(string[] args){
            
            using(OrmContext con = new OrmContext()){
                User u1 = new User("John Pork", new DateTime(2004, 12, 3));
                con.Users.Add(u1);

                Address a1 = new Address("6234", "Schweinestrasse", "40");
                con.Addresses.Add(a1);

                Newsletter n1 = new Newsletter("Porkers Newsletter EU", "www.porkers.eu");
                con.Newsletters.Add(n1);

                Newsletter n2 = new Newsletter("Kochkurs", "www.kochenlernen.de");
                con.Newsletters.Add(n2);

                u1.Address = a1;
                u1.Newsletters.Add(n1);
                u1.Newsletters.Add(n2);

                User u2 = new User("DJ DIESEL", new DateTime(1900, 1, 1));
                con.Users.Add(u2);

                u2.Address = a1;

                con.SaveChanges();



            }

        }
    }
}