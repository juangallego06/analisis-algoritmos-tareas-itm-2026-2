# Taller - Análisis de Algoritmos

Problemas resueltos en LeetCode con el correo: **juangallegolopez2002@gmail.com**

## 56. Merge Intervals

- **Código:** [merge-intervals/merge-intervals.cs](merge-intervals/merge-intervals.cs)
- **Evidencia:** [merge-intervals-accepted.png](evidencias/merge-intervals-accepted.png)
- **Familia:** Ordenamiento + intervalos (greedy).
- **Idea:** Ordenar por inicio y recorrer; si el intervalo actual se solapa con el último guardado, se extiende su fin; si no, se agrega como nuevo.
- **Complejidad:** Tiempo O(n log n) por el ordenamiento, espacio O(n).

## 200. Number of Islands

- **Código:** [number-of-islands/number-of-islands.cs](number-of-islands/number-of-islands.cs)
- **Evidencia:** [Accepted](evidencias/number-of-islands-accepted.png)
- **Familia:** Grafos / matrices (DFS, componentes conexas).
- **Idea:** Recorrer la matriz; al encontrar un '1' se cuenta una isla y se "hunde" toda la tierra conectada (DFS iterativo con pila) marcándola como '0'.
- **Complejidad:** Tiempo O(m·n), espacio O(m·n) en el peor caso.

## 1143. Longest Common Subsequence

- **Código:** [longest-common-subsequence/longest-common-subsequence.cs](longest-common-subsequence/longest-common-subsequence.cs)
- **Evidencia:** [Accepted](evidencias/longest-common-subsequence-accepted.png)
- **Familia:** Programación dinámica (2D sobre cadenas).
- **Idea:** `dp[i,j]` es la LCS de los prefijos `text1[0..i)` y `text2[0..j)`; si los caracteres coinciden se suma 1 a la diagonal, si no se toma el máximo entre arriba e izquierda.
- **Complejidad:** Tiempo O(m·n), espacio O(m·n).

## 435. Non-overlapping Intervals

- **Código:** [non-overlapping-intervals/non-overlapping-intervals.cs](non-overlapping-intervals/non-overlapping-intervals.cs)
- **Evidencia:** [Accepted](evidencias/non-overlapping-intervals-accepted.png)
- **Familia:** Greedy + ordenamiento (intervalos).
- **Idea:** Ordenar por fin y conservar siempre el intervalo que termina primero; si el actual empieza antes del último fin conservado, se solapa y se elimina.
- **Complejidad:** Tiempo O(n log n), espacio O(1) extra.

## 39. Combination Sum

- **Código:** [combination-sum/combination-sum.cs](combination-sum/combination-sum.cs)
- **Evidencia:** [Accepted](evidencias/combination-sum-accepted.png)
- **Familia:** Backtracking.
- **Idea:** Construir combinaciones probando candidatos desde un índice `start`; se reutiliza el mismo índice para permitir repetir números y nunca se retrocede para evitar duplicados. Al llegar el restante a 0 se guarda la combinación.
- **Complejidad:** Tiempo exponencial ~O(n^(T/m)), espacio O(T/m) por la profundidad de recursión.
