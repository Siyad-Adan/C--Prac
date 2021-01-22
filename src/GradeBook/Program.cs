using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      var book = new Book("Tester");
      var grades = new List<double>() { 12.2, 23, 25, 23 };
      book.AddGrade(45);
      foreach (var number in grades)
      {
        book.AddGrade(number);
      }

      book.computeStats();


    }
  }
}
