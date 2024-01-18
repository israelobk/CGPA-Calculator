// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Metrics;
using System.Reflection;

Console.WriteLine("Number of courses: ");
int noOfCourses = int.Parse(Console.ReadLine());

string grade;
int gradeUnit;
string remark;
int weightPt;
double Gpa;
int TotalGradeUnit = 0;
int TotalweightPt = 0;
int totalunitpass = 0;
int totalCourseUnit = 0;

List<string[]> studentRecords = new List<string[]>();


for (int i = 0; i < noOfCourses; i++)
{
    Console.WriteLine($"{i + 1}: Enter Course Code");
    var courseCode = Console.ReadLine();
    Console.Write($"{i + 1}: Enter Course Unit: ");
    int courseUnit = int.Parse(Console.ReadLine());
    Console.Write($"{i + 1}: Enter Course Score: ");
    int courseScore = int.Parse(Console.ReadLine());



    if (courseScore >= 70 && courseScore <= 100)
    {
        grade = "A";
        gradeUnit = 5;
        weightPt = courseUnit * gradeUnit;
        remark = "Excellent";
    }
    else if (courseScore >= 60 && courseScore <= 69)
    {
        grade = "B";
        gradeUnit = 4;
        weightPt = courseUnit * gradeUnit;
        remark = "Very Good";
    }
    else if (courseScore >= 50 && courseScore <= 59)
    {
        grade = "C";
        gradeUnit = 3;
        weightPt = courseUnit * gradeUnit;
        remark = "Good";
    }
    else if (courseScore >= 45 && courseScore <= 49)
    {
        grade = "D";
        gradeUnit = 2;
        weightPt = courseUnit * gradeUnit;
        remark = "Fair";
    }
    else if (courseScore >= 40 && courseScore <= 44)
    {
        grade = "E";
        gradeUnit = 1;
        weightPt = courseUnit * gradeUnit;
        remark = "Pass";
    }
    else
    {
        grade = "F";
        gradeUnit = 0;
        weightPt = courseUnit * gradeUnit;
        remark = "Fail";
    }

    if (courseScore >= 40)
    {
        totalunitpass += courseUnit;
    }
    totalCourseUnit += courseUnit;
    TotalweightPt += weightPt;
    TotalGradeUnit += gradeUnit;


    string[] courseRecord = new string[] { courseCode, courseUnit.ToString(), grade, gradeUnit.ToString(), weightPt.ToString(), remark };


    studentRecords.Add(courseRecord);
}

Gpa = TotalweightPt / TotalGradeUnit;


Console.WriteLine(" |------------------|-----------------|-----------|---------------|---------------|--------------|");
Console.WriteLine(" | COURSE & CODE    | COURSE UNIT     | GRADE     | GRADE-UNIT    | WEIGHT Pt     | REMARK       |");
Console.WriteLine(" |------------------|-----------------|-----------|---------------|---------------|--------------|");
foreach (string[] courseRecord in studentRecords)
{
    Console.WriteLine($" |    {courseRecord[0],-14}|     {courseRecord[1],-12}|     {courseRecord[2],-6}|    {courseRecord[3],-11}|    {courseRecord[4],-11}|    {courseRecord[5],-10}|");
}

Console.WriteLine("\n\n");
Console.WriteLine($"Total course Unit registered is {totalCourseUnit}");
Console.WriteLine($"Total course Unit passed is {totalunitpass}");
Console.WriteLine($"Total Weight point is {TotalweightPt}");
Console.WriteLine($"GPA is {Gpa:F2}");
