//using EFCoreEnigmaCamp.Database;

//class Program
//{
//    static void Main()
//    {
//        var student = new Student();
//        student.StudentCode = "TEST";
//        student.StudentName = "MUST";

//        var context = new SchoolContext(); // create object context dari SchoolContext
//        context.Add<Student>(student); // Menambah record baru
//        context.SaveChanges(); // Simpan perubahan

//        Console.WriteLine("Sukses menambah record Student");

//        //var student = new Student();
//        //student.StudentCode = "SIS-002";
//        //student.StudentName = "Itachi Uchiha";

//        //var context = new SchoolContext();
//        //context.Students.Add(student);
//        //context.SaveChanges();
//    }
//}

//using EFCoreEnigmaCamp.Database;
//class Program
//{
//    static void Main()
//    {
//        var student = new Student();
//        student.StudentId = 1;
//        student.StudentCode = "SNB-001";
//        student.StudentName = "Madara Uchiha";

//        var context = new SchoolContext();
//        context.Update<Student>(student);
//        context.SaveChanges();

//        Console.WriteLine("Suskes memperbaharui data Student");
//    }
//}

//using EFCoreEnigmaCamp.Database;
//class Program
//{
//    static void Main()
//    {
//        var context = new SchoolContext();

//        var student = context.Students.FirstOrDefault(w => w.StudentId == 3); // Get data student
//        try
//        {
//            context.Database.BeginTransaction(); // Transaction
//            context.Students.Remove(student); // remove data student;
//            context.SaveChanges();
//            context.Database.CommitTransaction();//Commit

//            Console.WriteLine("Suskes menghapus data Student");
//        }
//        catch
//        {
//            context.Database.RollbackTransaction();//Rollback
//        }
//    }
//}

//using EFCoreEnigmaCamp.Database;
//class Program
//{
//    static void Main()
//    {
//        var context = new SchoolContext();

//        var student = context.Students.FirstOrDefault(w => w.StudentId == 3); // Get data student
//        try
//        {
//            context.Database.BeginTransaction(); // Transaction
//            context.Students.Remove(student); // remove data student;
//            context.SaveChanges();
//            context.Database.CommitTransaction();//Commit

//            Console.WriteLine("Suskes menghapus data Student");
//        }
//        catch
//        {
//            context.Database.RollbackTransaction();//Rollback
//        }
//    }
//}

//using EFCoreEnigmaCamp.Database;
//class Program
//{
//    static void Main()
//    {
//        var context = new SchoolContext();

//        var listStudent = context.Students.ToList();

//        foreach (Student student in listStudent)
//        {
//            Console.WriteLine($"{student.StudentId} - {student.StudentCode} - {student.StudentName}");
//        }
//    }
//}

//using EFCoreEnigmaCamp.Database;
//class Program
//{
//    static void Main()
//    {
//        var context = new SchoolContext();

//        var student = new Student();
//        student.StudentCode = "SIS-003";
//        student.StudentName = "Sasuke Uchiha";

//        context.Students.Add(student); // Cara 1

//        context.Add<Student>(student); // Cara 2
//        context.SaveChanges();
//    }
//}

//using EFCoreEnigmaCamp.Database;
//class Program
//{
//    static void Main()
//    {
//        var context = new SchoolContext();

//        var student = new Student();
//        student.StudentCode = "SIS-003";
//        student.StudentName = "Sasuke Uchiha";

//        context.Students.Update(student); // Cara 1

//        context.Update<Student>(student); // Cara 2
//        context.SaveChanges();
//    }
//}

//using EFCoreEnigmaCamp.Database;
//class Program
//{
//    static void Main()
//    {
//        var context = new SchoolContext();

//        var student = new Student();
//        student.StudentCode = "SIS-003";
//        student.StudentName = "Sasuke Uchiha";

//        context.Students.Remove(student); // Cara 1

//        context.Remove<Student>(student); // Cara 2
//        context.SaveChanges();
//    }
//}


//using EFCoreEnigmaCamp.Database;
//using Microsoft.EntityFrameworkCore;

//class Program
//{
//    static void Main()
//    {
//        var context = new SchoolContext();

//        var student = context.Students.First(); // Nge get record pertama dalam sebuah table

//        Console.WriteLine($"{student.StudentCode} - {student.StudentName}");

//        var students = context
//                        .Students
//                        .FromSql($"SELECT * FROM Students WHERE StudentCode = 'SNB-001'")
//                        .FirstOrDefault(); // Menggunakan perintah SQL 

//        Console.WriteLine($"{students.StudentCode} - {students.StudentName}");

//        var listStudent = context.Students.Where(w => w.StudentId == 1);
//        var studentRepo = listStudent.FirstOrDefault();
//        Console.WriteLine($"{studentRepo.StudentCode} - {studentRepo.StudentName}");
//    }
//}


//using EFCoreEnigmaCamp.Database;
//using Microsoft.EntityFrameworkCore;

//class Program
//{
//    static void Main()
//    {
//        //var context = new SchoolContext();
//        //var student = context.Students
//        //    .Include(s => s.StudentAddress); // SELECT * FROM Student LEFT JOIN StudentAddress
//        //Console.ReadKey();

//        var context = new SchoolContext();
//        var viewStudentAddress = context.vw_StudentAddresses.ToList(); // SELECT ALL VIEW
//        foreach(var itemStudent in viewStudentAddress)
//        {
//            Console.WriteLine($"{itemStudent.StudentId} - {itemStudent.StudentName} - " +
//                $"{itemStudent.Address1} - {itemStudent.Address2}");
//        }
//    }
//}

//using EFCoreEnigmaCamp.Database;
//using Microsoft.EntityFrameworkCore;

//class Program
//{
//    static void Main()
//    {
//        // Perintah untuk mengeksekusi perintah Native SQL, sample adalah membuat View
//        var context = new SchoolContext();
//        context.Database.ExecuteSqlRaw(@"CREATE VIEW View_Student AS 
//                                            SELECT StudentId, StudentName
//                                        FROM Students");
//    }
//}

//using EFCoreEnigmaCamp.Database;
//using Microsoft.EntityFrameworkCore;

//class Program
//{
//    static void Main()
//    {
//        // Perintah untuk mengeksekusi perintah Native SQL, sample adalah membuat View
//        var context = new SchoolContext();
//        var students = context.Students.FromSqlRaw("SELECT * FROM Students WHERE StudentId = {Id}", 1).FirstOrDefault();

//        foreach (var student in students)
//        {
//            Console.WriteLine($"{student.StudentId} - {student.StudentName}");
//        }
//    }
//}

//using EFCoreEnigmaCamp.Database;
//using Microsoft.EntityFrameworkCore;

//class Program
//{
//    static void Main()
//    {
//        // Perintah untuk mengeksekusi perintah Native SQL, sample adalah membuat View
//        var context = new SchoolContext();
//        var student = context.Students.FromSqlRaw("SELECT * FROM Students WHERE StudentId = {0}", 1).FirstOrDefault();

//        Console.WriteLine($"{student.StudentId} - {student.StudentName}");
//    }
//}

//using EFCoreEnigmaCamp.Database;
//using Microsoft.EntityFrameworkCore;

//class Program
//{
//    static void Main()
//    {
//        var context = new SchoolContext();
//        var student = context.Students.FirstOrDefault(w => w.StudentId == 1);

//        student.StudentId = 1;
//        student.StudentCode = "STB-001";
//        student.StudentName = "Madara Uchiha";
//        student.DoB = DateTime.Now;
//        student.Gender = 1;

//        context.Students.Update(student);
//        context.SaveChanges();
//        Console.WriteLine("Updated!");

//        Console.WriteLine($"{student.StudentId} - {student.StudentName}");
//    }
//}


//using EFCoreEnigmaCamp.Database;
//using Microsoft.EntityFrameworkCore;

//class Program
//{
//    static void Main()
//    {
//        var context = new SchoolContext();
//        var student = context.Students.FirstOrDefault(w => w.StudentId == 1);

//        Console.WriteLine($"{student.StudentId} - {student.StudentName} - {student.Gender}");
//    }
//}

using EFCoreEnigmaCamp.Cores;
using EFCoreEnigmaCamp.Database;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;

class Program
{
    static void Main()
    {
        var context = new SchoolContext();
        var student1 = new Student();
        student1.StudentCode = "STB-003";
        student1.StudentName = "Momoshiki";
        student1.DoB = DateTime.Now;
        student1.Gender = Gender.Female;

        var student2 = new Student();
        student2.StudentCode = "STB-003";
        student2.StudentName = "Sasuke";
        student2.DoB = DateTime.Now;
        student2.Gender = Gender.Male;

        var studentList = new List<Student>();
        studentList.Add(student1);
        studentList.Add(student2);

        context.Students.AddRange(studentList); // Save multi record

        context.SaveChanges();

        Console.WriteLine("Multi insert EFCore");
    }
}