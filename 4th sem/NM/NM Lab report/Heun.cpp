#include <stdio.h>
#include <conio.h> // Only needed for Windows platform

#define f(x, y) (2 * (y) / (x)) // Corrected the macro definition

int main() {
    float x, xp, x0, y0, h, m1, m2, y; // Added 'y' declaration
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
        m2 = f(x + h, y + h * m1);
        y = y + h / 2 * (m1 + m2); // Added multiplication operator (*) here
        x = x + h;
    }

    printf("Function value at x = %f is %f\n", xp, y);

    getch(); // Only needed for Windows platform
    return 0;
}

