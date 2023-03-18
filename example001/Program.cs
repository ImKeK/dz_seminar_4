int Metod(string message)
{
  System.Console.WriteLine(message);
  string read = Console.ReadLine()!;
  int result = Convert.ToInt32(read);
  return result;
}

int Power(int powerBase, int exponent)
{
  int power = 1;
  for(int i = 0; i < exponent; i++)
  {
    power *= powerBase;
  }
  return power;
}

bool ValidateExponent(int exponent)
{
  if(exponent < 0)
  {
    System.Console.WriteLine("Показатель не должен был быть меньше нуля.");
    return false;
  }
  return true;
}

int powerBase = Metod("Введите основание: ");
int exponent = Metod("Введите показатель степени: ");
if(ValidateExponent(exponent))
{
  System.Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
}