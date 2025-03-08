using System;
using System.Xml;

object height = 1.88; // object에 double 형식의 값을 저장한다.
object name = "Amir"; // object에 string 형식의 값을 저장한다.
Console.WriteLine($"{name} is {height} meters tall.");

// int length1 = name.Length; // 컴파일 에러 발생!
int length2 = ((string)name).Length; // string 멤버 사용을 위해 명시적으로 형식을 변환한다.
Console.WriteLine($"{name} has {length2} characters.");

// dynamic 변수에 string 값을 저장한다.
// string은 Length 속성을 가진다.
dynamic something = "Ahmed";
// int는 Length 속성이 없다.
// something = 12;
// array 형식은 Length 속성을 가진다.
something = new[] {3, 5, 7};

// 컴파일은 되지많 Length 속성이 없는 데이터 형식을 저장하면 
// 런타임 예외가 발생한다.
Console.WriteLine($"Length is {something.Length}");

// 지역 변수
// int population = 66_000_000; // 영국 인구는 6,600만이다.
// double weight = 1.88; // 킬로그램
// decimal price = 5.0M;
// string fruit = "Apples";
// char letter = 'Z'; // char는 작은 따옴표를 사용한다.
// bool happy = true; // bool은 true나 false 값을 가짐.

var population = 66_000_000; // 영국 인구는 6,600만이다.
var weight = 1.88; // 킬로그램
var price = 5.0M;
var fruit = "Apples";
var letter = 'Z'; // char는 작은 따옴표를 사용한다.
var happy = true; // bool은 true나 false 값을 가짐.

// var 사용의 좋은 예
var xml1 = new XmlDocument();
// XmlDocumnet를 불필요하게 반복함.
XmlDocument xml2 = new XmlDocument();

// var 사용의 나쁜 예. file1은 어떤 타입인가?
// var file1 = File.CreateText(@"C:\something.txt");
// var 사용의 좋은 예
// StreamWriter file2 = File.CreateText(@"C:\something.txt");

XmlDocument xml3 = new(); // 대상으로 형식화된 new(C# 9이상)


Person kim = new();
kim.BirthDate = new(1967, 12, 26); // new DateTime(1967, 12, 26) 대신 사용

Console.WriteLine($"defualt(int) = {default(int)}");
Console.WriteLine($"defatul(bool) = {default(bool)}");
Console.WriteLine($"defualt(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");


int number = 13;
Console.WriteLine($"number has been set to: {number}");
number = default;
Console.WriteLine($"number has been reset to its default: {number}");


// 배열의 크기를 선언
string[] names = new string[4];
// 각 인덱스 위치에 사람 이름을 저장한다. 
names[0] = "Kate";
names[1] = "Jack";
names[2] = "Rebecca";
names[3] = "Tom";
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

string[] names2 = new[] { "Kate", "Jack", "Rebedcca", "Tom" };


// 책과 다르게 클래스 선언이 아래에 들어가네? 
class Person
{
    public DateTime BirthDate;
}

