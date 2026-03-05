using System;
using System.Data;
using System.Globalization;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("'''");
Point point = new Point();
point.x = 100;
point.y = 200;
Console.WriteLine($"X: {point.x} Y: {point.y}");
Console.WriteLine("'''\n");

Console.WriteLine("'''");
Product product = new Product();
product.Id = 1;
product.TItle = "좋은 책";
product.Price = 10000;
Console.WriteLine($"번호: {product.Id}");
Console.WriteLine($"상품명: {product.TItle}");
Console.WriteLine($"가격: {product.Price}");

Console.WriteLine("'''\n");

Console.WriteLine("'''");
BusinessCard card = new BusinessCard();
card.Name = "홍길동";
card.Age = 21;
card.Address = "서울시";
Console.WriteLine($"{card.Name}, {card.Age}, {card.Address}");

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Point1 point1 = new Point1(100,200);
Console.WriteLine($"X: {point1.x} Y: {point1.y}");

Console.WriteLine("'''\n");

Console.WriteLine("'''");
BusinessCard1[] card1 = new BusinessCard1[3];
card1[0].Name = "홍길동";
card1[0].Age = 17;
card1[1].Name = "백두산";
card1[1].Age = 102;
card1[2].Name = "임꺽정";
card1[2].Age = 31;

Console.WriteLine($"{card1[0].Name}은(는) {card1[0].Age}살 입니다");
Console.WriteLine($"{card1[1].Name}은(는) {card1[1].Age}살 입니다");
Console.WriteLine($"{card1[2].Name}은(는) {card1[2].Age}살 입니다");

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Score[] scores = new Score[3];
scores[0].Name = "홍길동"; scores[0].Kor = 100; scores[0].Eng = 90;
scores[1].Name = "백두산"; scores[1].Kor = 90; scores[1].Eng = 80;
scores[2].Name = "임꺽정"; scores[2].Kor = 80; scores[2].Eng = 70;
for (int i = 0; i < scores.Length; i++)
{
    scores[i].Total = scores[i].Kor + scores[i].Eng;
    scores[i].average = scores[i].Total / 2;
}
for (int i = 0;i < scores.Length; i++)
{
    Console.WriteLine($"{scores[i].Name}\t{scores[i].Total}\t{scores[i].average}");
}

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Member member = new Member();
member.Name = "백두산";
member.Age = 100;
void Print(Member member)
{
    Console.WriteLine($"이름: {member.Name}, 나이: {member.Age}");
}

Console.WriteLine("'''\n");


Console.WriteLine("'''");
Student[] students = new Student[3];

students[0].Num = 1;
students[0].Name = "홍길동";
students[0].Scores.Kor = 100;
students[0].Scores.Eng = 90;

students[1].Num = 2;
students[1].Name = "백두산";
students[1].Scores.Kor = 90;
students[1].Scores.Eng = 80;

students[2].Num = 3;
students[2].Name = "임꺽정";
students[2].Scores.Kor = 80;
students[2].Scores.Eng = 70;

for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine(
        $"{students[i].Num} - {students[i].Name} : " +
        $"{students[i].Scores.Kor}, {students[i].Scores.Eng}");
}

Console.WriteLine("'''\n");

Console.WriteLine("'''");
char upper = 'A';
char lower = 'a';
char digit = '1';
char space = ' ';

if (char.IsUpper(upper))
{
    Console.WriteLine($"{upper}은(는) 대문자");
}

if (char.IsLower(lower))
{
    Console.WriteLine($"{lower}은(는) 소문자");
}

if (char.IsDigit(digit))
{
    Console.WriteLine($"{digit}은(는) 숫자");
}

if (char.IsWhiteSpace(space))
{
    Console.WriteLine("공백 문자");
}

Console.WriteLine(char.ToLower(upper));  
Console.WriteLine(char.ToUpper(lower));  

Console.WriteLine("'''\n");

Console.WriteLine("'''");
DateTime now = DateTime.Now;
Console.WriteLine($"현재: {now}");
DateTime days = new DateTime(2000, 5, 15);
Console.WriteLine($"생일: {days}");
now.AddDays(7);
Console.WriteLine($"일주일 후: {days}");

Console.WriteLine("'''\n");

Console.WriteLine("'''");
PointStruct p1;
p1.X = 10;
PointStruct p2 = p1;  
p2.X = 20;

Console.WriteLine($"p1.X = {p1.X}");  
Console.WriteLine($"p2.X = {p2.X}");  

Console.WriteLine("'''\n");


struct PointStruct
{
    public int X;
}

struct Point
{
    public int x;
    public int y;
}

struct Product
{
    public int Id;
    public string TItle;
    public decimal Price;
}

struct BusinessCard
{
    public string Name;
    public int Age;
    public string Address;

}

struct Point1
{
    public int x;
    public int y;

    public Point1(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

struct BusinessCard1
{
    public string Name;
    public int Age;
}

struct Score
{
    public string Name;
    public int Kor;
    public int Eng;
    public int Total;
    public double average;
}

struct Member
{
    public string Name;
    public int Age;
}

struct Score1
{
    public int Kor;
    public int Eng;
}
struct Student
{
    public int Num;
    public string Name;
    public Score1 Scores;  
}