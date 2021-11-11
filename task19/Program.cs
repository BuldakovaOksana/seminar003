// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
 bool x=true;
bool y=false;
if   (!(x|y)==!x&!y)
{
    System.Console.WriteLine(true);
}
else
{
    System.Console.WriteLine(false);
}