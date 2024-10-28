using System;

public class MyFrac
{
    public long Nom { get; private set; }
    public long Denom { get; private set; }

    public MyFrac(long nom_, long denom_)
    {
        if (denom_ == 0)
        {
            throw new ArgumentException("Denominator cannot be zero");
        }

        // Робимо знаменник завжди позитивним
        if (denom_ < 0)
        {
            nom_ = -nom_;
            denom_ = -denom_;
        }

        long gcd = GCD(Math.Abs(nom_), Math.Abs(denom_));
        Nom = nom_ / gcd;
        Denom = denom_ / gcd;
    }

    // Обчислення найбільшого спільного дільника
    private static long GCD(long a, long b)
    {
        while (b != 0)
        {
            long t = b;
            b = a % b;
            a = t;
        }
        return a;
    }

    public override string ToString()
    {
        return $"{Nom}/{Denom}";
    }

    public string ToStringWithIntPart()
    {
        long integerPart = Nom / Denom;
        long remainder = Nom % Denom;

        if (remainder == 0)
        {
            return $"{integerPart}";
        }
        
        if (integerPart == 0)
        {
            return $"{Nom}/{Denom}";
        }
       
        if (Nom < 0)
        {
            return $"-({Math.Abs(integerPart)}+({Math.Abs(remainder)}/{Denom}))";
        }

        return $"{integerPart}+({Math.Abs(remainder)}/{Denom})";
    }

    public double DoubleValue()
    {
        return (double)Nom / Denom;
    }

    // Методи для додавання, віднімання, множення та ділення
    public MyFrac Plus(MyFrac other)
    {
        return new MyFrac(Nom * other.Denom + Denom * other.Nom, Denom * other.Denom);
    }

    public MyFrac Minus(MyFrac other)
    {
        return new MyFrac(Nom * other.Denom - Denom * other.Nom, Denom * other.Denom);
    }

    public MyFrac Multiply(MyFrac other)
    {
        return new MyFrac(Nom * other.Nom, Denom * other.Denom);
    }

    public MyFrac Divide(MyFrac other)
    {
        return new MyFrac(Nom * other.Denom, Denom * other.Nom);
    }
}