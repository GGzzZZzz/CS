using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelLibrary;
using ExcelLibrary.SpreadSheet;


class StudentTest
{
    public static void Main()
    {
        List<Student> students = new List<Student>();

        StreamReader reader = new StreamReader("..\\..\\Students-data.txt");

        using (reader)
        {
            string skip = reader.ReadLine();

            for (int i = 0; i < 1000; i++)
            {
                string line = reader.ReadLine();
                string[] props = line.Split('\t');
                Student student = new Student(int.Parse(props[0]), props[1], props[2], props[3], props[4], props[5], int.Parse(props[6]), int.Parse(props[7]), int.Parse(props[8]), float.Parse(props[9]), int.Parse(props[10]), float.Parse(props[11]));

                students.Add(student);
            }
        }

        var sortedOnline =
            from student in students
            where student.StudentType == "Online"
            orderby student.Result descending
            select student;

        StreamWriter writer = new StreamWriter("Result.txt");
        using (writer)
        {
            foreach (var student in sortedOnline)
            {
                writer.WriteLine(student);
            }
        }

        //create new xls file
        string file = "newdoc.xls";
        Workbook workbook = new Workbook();
        Worksheet worksheet = new Worksheet("First Sheet");
        worksheet.Cells[0, 1] = new Cell((short)1);
        worksheet.Cells[2, 0] = new Cell(9999999);
        worksheet.Cells[3, 3] = new Cell((decimal)3.45);
        worksheet.Cells[2, 2] = new Cell("Text string");
        worksheet.Cells[2, 4] = new Cell("Second string");
        worksheet.Cells[4, 0] = new Cell(32764.5, "#,##0.00");
        worksheet.Cells[5, 1] = new Cell(DateTime.Now, @"YYYY\-MM\-DD");
        worksheet.Cells.ColumnWidth[0, 1] = 3000;
        workbook.Worksheets.Add(worksheet);
        workbook.Save(file);

    }
}

