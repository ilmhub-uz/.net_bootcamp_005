using System.Collections;

namespace Dars_8;

public  static partial class Calculator
{

    public static double Add(params double[] sonlar)
        => sonlar.Length == 0 ? 0 : sonlar.Sum();

    public static double Divide(params double[] sonlar)
    {
        if (sonlar == null || sonlar.Length == 0) throw new NolYokidaNullException("Nol yokida Null Kiriting");

        var answer = sonlar[0];
        for (var index = 0; index < sonlar.Length - 1; index++)
        {
            if (index == 0 && (sonlar[0] == 0 || sonlar[0] == 0.0)) return 0;
            if (sonlar[index + 1] == 0 || sonlar[index + 1] == 0.0) throw new DivideByZeroException();
            answer /= sonlar[index + 1];
        }

        return answer;
    }


}