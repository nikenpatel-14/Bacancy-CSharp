using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Assignment.Services
{
    internal class GenericSwapRepository
    {
        void genericSwap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;

        }
         public void run()
        {

            //generic swap code
            int a = 10;
            int b = 30;
            Console.WriteLine($"number a : {a}, number b : {b}");
            genericSwap(ref a, ref b);

            Console.WriteLine("after swap");
            Console.WriteLine($"number a : {a}, number b : {b}");

            string c = "Niken";
            string d = "Mann";

            Console.WriteLine($"name c : {c}, name d : {d}");
            genericSwap(ref c, ref d);
            Console.WriteLine("after swap");
            Console.WriteLine($"name c : {c}, name d : {d}");


            //generic repository
            GenericRepository<int> intRepo = new GenericRepository<int>();

            intRepo.add(1);
            intRepo.add(2);
            intRepo.add(3);


            intRepo.remove(1);

            Console.WriteLine(string.Join(",", intRepo.getAll()));

            GenericRepository<string> stringRepo = new GenericRepository<string>();

            stringRepo.add("niken");
            stringRepo.add("mann");
            stringRepo.add("aayush");

            stringRepo.remove("mann");

            Console.WriteLine(string.Join(",", stringRepo.getAll()));



        }

    }

    class GenericRepository<T>
    {
        public List<T> repo = new List<T>();

        public void add(T item)
        {

            repo.Add(item);
        }
        public void remove(T item)
        {
            repo.Remove(item);
        }
        
        public List<T> getAll()
        {
            return repo;
        }

    }
}
