using System;

namespace method
{
    class Program

    {
        public int id;
        public string name;
        public string pic;
        public string gender;
        public int status;
        public string supplier;
        public Program(int id, string name, string pic, string gender, int status, string supplier)
        {
            this.id = id;
            this.name = name;
            this.pic = pic;
            this.gender = gender;
            this.status = status;
            this.supplier = supplier;

        }

        public void Index()
        {
            Console.Write("Masukan ID : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukan Nama : ");
            name = Console.ReadLine();
            Console.Write("Masukan Pic : ");
            pic = Console.ReadLine();
            Console.Write("Masukan Jenis Kelamin : ");
            gender = Console.ReadLine();
            Console.Write("Masukan Status : ");
            //bool status = Convert.ToBoolean(Console.ReadLine());
            status = Convert.ToInt32(Console.ReadLine());


            supplier = "ID : " + id + "\n" + "Nama : " + name + "\n" + "Pic : " + pic + "\n" + "Jenis Kelamin : " + gender + "\n";
            //Console.WriteLine(supplier);
        }

        public void Info()
        {
            Console.Write(supplier);
        }

        public Boolean Plafon()
        {

            if (Convert.ToBoolean(status > 0))
            {
                Console.WriteLine(true);
                return true;
            }
            else
            {
                Console.WriteLine(false);
                return false;
            }


        }
        static void Main(string[] args)
        {
            Program Program = new Program(1, "nama", "pic", "gender", 1, "supplier");
            Program.Index();
            Console.WriteLine("\n");
            Program.Info();
            Console.WriteLine("\n");
            Program.Plafon();

        }

    }
}