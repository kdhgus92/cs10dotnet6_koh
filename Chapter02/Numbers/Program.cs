// 부호 없는 정수(unsigned integer)는 양의 정수 또는 0을 의미한다..
uint naturalNumber = 0;
// 정수(integer)는 음수, 양의 정수 또는 0을 의미한다.
int integerNumber = -23;
// float은 단정밀도 부동 소수점을 의미한다.
// F 접미사를 사용하면 float 리터럴이 된다.
float realNumber = 2.3F;
// double은 배정밀도(double-precision) 부동 소수점을 의미한다.
double anotherRealNumber = 2.3; // double 리터럴

// 숫자 200만을 저장하는 3개의 변수
int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;
// 3개 변수가 모두 같은 값을 갖고 있다면 true 출력
Console.WriteLine($"{decimalNotation == binaryNotation}");
Console.WriteLine(
    $"{decimalNotation == hexadecimalNotation}");

// Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
// Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
// Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

double a = 0.1;
double b = 0.2;
if (a + b == 0.3)
{
    Console.WriteLine($"{a} + {b} equals 0.3");
}
else
{
    Console.WriteLine($"{a} + {b} does NOT equal 0.3");
}

Console.WriteLine("Using decimals:");
decimal c = 0.1M;
decimal d = 0.2M;
if (c + d == 0.3M)
{
    Console.WriteLine($"{c} + {d} equals 0.3");
}
else
{
    Console.WriteLine($"{c} + {d} does NOT equal 0.3");
}