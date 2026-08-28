int[] g = { 1, 2, 3 };
int[] s = { 1, 1 };

CookieAssigner assigner = new CookieAssigner();

int result = assigner.FindContentChildren(g, s);

Console.WriteLine($"Niños satisfechos: {result}");


public class CookieAssigner
{
  public int FindContentChildren(int[] g, int[] s)
  {
    // Ordenamos los factores de codicia
    // y los tamaños de las galletas
    Array.Sort(g);
    Array.Sort(s);

    int child = 0;
    int cookie = 0;
    int satisfied = 0;

    while (child < g.Length && cookie < s.Length)
    {
      // La galleta puede satisfacer al niño
      if (s[cookie] >= g[child])
      {
        satisfied++;
        child++;
        cookie++;
      }
      else
      {
        // La galleta es demasiado pequeña,
        // buscamos una más grande
        cookie++;
      }
    }

    return satisfied;
  }
}
