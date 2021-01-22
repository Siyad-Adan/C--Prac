using System;
using System.Collections.Generic;

namespace GradeBook
{
  public class Book
  {
    private List<double> grades;
    private string name;
    public Book(string name)
    {
      this.name = name;
      grades = new List<double>();
    }
    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    public void computeStats()
    {
      var result = GetStats();

      Console.WriteLine($"Average { result.Average} , High { result.High}, Low {result.Low}");

    }

    public Statistics GetStats()
    {
      var result = new Statistics();

      foreach (var grade in grades)
      {
        result.High = Math.Max(grade, result.High);
        result.Low = Math.Min(grade, result.Low);
        result.Average += grade;
      }

      result.Average /= grades.Count;

      return result;
    }
  }
}
