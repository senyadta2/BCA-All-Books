#include <stdio.h>
#include <conio.h>
#include <math.h>

#define f(x) 3*(x)*(x) + 2*(x) - 5

int main() {
    int i, k;
    float a, h, x0, xn, fx0, fxn, term, v;

    printf("Enter lower & Upper limit:\n");
    scanf("%f%f", &x0, &xn);

    printf("Enter Number of segments:\n");
    scanf("%d", &k);

    h = (xn - x0) / k;
    fx0 = f(x0);
    fxn = f(xn);
    term = fx0 + fxn;

    for (i = 1; i < k; i++) {
        a = x0 + i * h;
        term = term + 2 * f(a);
    }

    v = h / 2 * term;
    
    printf("Value of Integration = %f\n", v);
    
    getch();  // Pause to view the result
    
    return 0;
}

