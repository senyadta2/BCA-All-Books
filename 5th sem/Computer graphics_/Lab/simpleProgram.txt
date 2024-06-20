#include <graphics.h>
#include <conio.h>

void main() {
    // this line is must for every graphics program
    int gd = DETECT, gm; 
    // this line is must for every graphics program and path is defined as Turbo 
    // installation.
    // declaration of any variables must be done before calling initgraph()function.
    initgraph(&gd, &gm, "C:\\TURBOC3\\BGI");
    circle(200, 100, 75); // Using 75 as radius for a circle with diameter 150
    getch();
    closegraph();
}
