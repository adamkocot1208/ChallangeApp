﻿var name = "Kon";
var sex = false;
var age = 30;

if (sex == true) //kobieta
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else
    {
        if (age == 33 && name =="Ewa")
        {
            Console.WriteLine("Ewa, lat 33");
        }
        else
        {
            Console.WriteLine("Kobieta w wieku 30 lat lub więcej");
        }
    }

}
else //mezczyzna
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni Mężczyzna");
    }
    else
    {
        Console.WriteLine("Pełnoletni Mężczyzna");
            }
}