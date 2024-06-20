#include <stdio.h>
#include <conio.h> // Only needed for Windows platform

#define f(x, y) (2 * y / x)

int main() {
    float x, xp, x0, y0, y, h; // Corrected variable names
    printf("Enter initial values of x & y:\n");
    scanf("%f %f", &x0, &y0);

    printf("Enter x at which function to be Evaluated:\n");
    scanf("%f", &xp);

    printf("Enter the step size:\n");
    scanf("%f", &h); // Fixed variable name here

    y = y0;
    x = x0;

    while (x < xp) { // Changed the loop condition to use 'xp'
        y = y + f(x, y) * h;
        x = x + h;
    }

    printf("Function value at x = %f is %f\n", xp, y);

    getch(); // Only needed for Windows platform
    return 0;
}

