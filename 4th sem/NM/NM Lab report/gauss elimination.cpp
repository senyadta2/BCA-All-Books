#include <stdio.h>
#include <math.h>
#include <conio.h>

int main()
{
    int n, i, k, j;
    float pivot, term, sum = 0, a[10][10], b[10], x[10];
    printf("Enter Dimension of System of equations\n");
    scanf("%d", &n);
    printf("Enter coefficients row-wise\n");
    for (i = 0; i < n; i++)
    {
        for (j = 0; j < n; j++)
        {
            scanf("%f", &a[i][j]);
        }
    }
    printf("Enter RHS vector\n");
    for (i = 0; i < n; i++)
    {
        scanf("%f", &b[i]);
    }
    for (k = 0; k <= n - 2; k++) //Forward Elimination //Multiply row k of coefficient matrix by a[i][k]/a[k][k] and subtract it from rowi
    {
        pivot = a[k][k];
        if (fabs(pivot) < 0.000001)
        {
            printf("Method failed\n");
        }
        else
        {
            for (i = k + 1; i < n; i++)
            {
                term = a[i][k] / pivot;
                for (j = 0; j < n; j++)
                {
                    a[i][j] = a[i][j] - a[k][j] * term;
                }
                //Multiply row k of B matrix by a[i][k]/a[k][k] and subtract it from row i
                b[i] = b[i] - b[k] * term;
            }
        }
    }

    x[n - 1] = b[n - 1] / a[n - 1][n - 1];

    for (i = n - 2; i >= 0; i--) // Back substitution
    {
        sum = 0;
        for (j = i + 1; j <= n - 1; j++)
        {
            sum = sum + a[i][j] * x[j];
        }
        x[i] = (b[i] - sum) / a[i][i];
    }
    printf("Solution:\n");
    for (i = 0; i < n; i++)
    {
        printf("x%d = %f\t", i + 1, x[i]);
    }
    getch();
    return 0;
}

