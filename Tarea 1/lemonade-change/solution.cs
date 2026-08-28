int[] billsOk = { 5, 5, 5, 10, 20 };
int[] billsFail = { 5, 5, 10, 10, 20 };

BillValidator validator1 = new BillValidator();
BillValidator validator2 = new BillValidator();

bool approvedOk = validator1.Validate(billsOk);
bool approvedFail = validator2.Validate(billsFail);

Console.WriteLine($"Aprobado caso OK: {approvedOk}");
Console.WriteLine($"Aprobado caso FAIL: {approvedFail}");


public class BillValidator
{
    public bool Validate(int[] bills)
    {
        int five = 0;
        int ten = 0;

        foreach (int bill in bills)
        {
            switch (bill)
            {
                case 5:
                    five++;
                    break;

                case 10:
                    if (five == 0)
                        return false;

                    five--;
                    ten++;
                    break;

                case 20:
                    // Necesitamos devolver $15
                    if (ten > 0 && five > 0)
                    {
                        // Preferimos $10 + $5
                        ten--;
                        five--;
                    }
                    else if (five >= 3)
                    {
                        // Alternativa: 3 billetes de $5
                        five -= 3;
                    }
                    else
                    {
                        return false;
                    }

                    break;
            }
        }

        return true;
    }
}
