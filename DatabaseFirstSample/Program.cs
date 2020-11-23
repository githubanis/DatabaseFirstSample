using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DatabaseFirstSample
{
    class Program
    {

        static void Main(string[] args)
        {
            using (var db = new Entities())
            {
                
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Enter a name for a new Blog: ");
                    var name = Console.ReadLine();
                    var blog = new Blog { Name = name };
                    db.Blogs.Add(blog);
                }
                db.SaveChanges();

                var query = db.Blogs.OrderBy(n => n.Name);


                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
