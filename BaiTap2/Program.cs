using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
}

class BaiTap2
{
    static void Main()
    {
        Console.Write("Nhap so luong hoc sinh: ");
        int studentCount = int.Parse(Console.ReadLine());
        Console.WriteLine();

        List<Student> sinhviens = new List<Student>();
        for (int i = 0; i < studentCount; i++)
        {
            Console.WriteLine("Nhap thong tin hoc sinh thu " + (i + 1) + ":");

            Console.Write("Nhap ID hoc sinh: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nhap ten hoc sinh: ");
            string name = Console.ReadLine();

            Console.Write("Nhap tuoi hoc sinh: ");
            int age = int.Parse(Console.ReadLine());

            sinhviens.Add(new Student(id, name, age));

            Console.WriteLine();
        }

        Console.WriteLine("Thong tin sinh vien:");
        sinhviens.ForEach(sv => Console.WriteLine(sv.Id + " - " + sv.Name + " - " + sv.Age + " tuoi"));

        var agelimitsv = sinhviens.Where(s => s.Age <= 18 && s.Age >= 15).ToList();
        Console.WriteLine("\nCac hoc sinh tu 15 den 18:");
        agelimitsv.ForEach(s => Console.WriteLine(s.Id + " - " + s.Name + " - " + s.Age + " tuoi"));

        var namestarta = sinhviens.Where(a => a.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();
        Console.WriteLine("\nHoc sinh co ten bat dau bang chu A:");
        if (namestarta.Any())
        {
            namestarta.ForEach(s => Console.WriteLine(s.Id + " - " + s.Name + " - " + s.Age + " tuoi"));
        }
        else
        {
            Console.WriteLine("Khong co hoc sinh nao co ten bat dau bang chu A.");
        }


        int tage = sinhviens.Sum(s => s.Age);
        Console.WriteLine("\nTong tuoi cua hoc sinh la: " + tage);

        var maxage = sinhviens.OrderByDescending(s => s.Age).FirstOrDefault();
        Console.WriteLine("\nHoc sinh tuoi lon nhat la: " + maxage.Id + " - " + maxage.Name + " - " + maxage.Age + " tuoi");

        var sortage = sinhviens.OrderBy(s => s.Age).ToList();
        Console.WriteLine("\nDanh sach hoc sinh theo tuoi tang dan la:");
        sortage.ForEach(s => Console.WriteLine(s.Id + " - " + s.Name + " - " + s.Age + " tuoi"));
    }
}
