#include <stdio.h>
#include <conio.h> // Only needed for Windows platform
#include <math.h>

#define f(x, y) ( pow(x,2) + pow(y,2)) // Corrected the macro definition

int main() {
    float x, xp, x0, y0, y, h, m1, m2, m3, m4; // Added 'y' declaration
    printf("Enter initial values of x & y:\n");
    scanf("%f %f", &x0, &y0);

    printf("Enter the value of x at which function to be evaluated:\n");
    scanf("%f", &xp);

    printf("Enter the step size:\n");
    scanf("%f", &h);

    y = y0; // Initialize y to y0
    x = x0; // Initialize x to x0

    while (x < xp) { // Changed the loop condition to use 'xp'
        m1 = f(x, y);
        m2 = f(x + 0.5 * h, y + 0.5 * h * m1);
        m3 = f(x + 0.5 * h, y + 0.5 * h * m2);
        m4 = f(x + h, y + h * m3);
        y = y + h / 6 * (m1 + 2 * m2 + 2 * m3 + m4);
        x = x + h;
    }

    printf("Function value at x = %f is %f\n", xp, y);

    getch(); // Only needed for Windows platform
    return 0;
}

