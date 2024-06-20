#include <stdio.h>
#include <conio.h>
#include <graphics.h>

int main() {
    int gd = DETECT, gm;
    initgraph(&gd, &gm, "C:\\TURBOC3\\BGI");

    circle(175, 110, 50);
    circle(150, 110, 10);
    circle(200, 100, 10);
    rectangle(125, 170, 225, 230);
    rectangle(125, 240, 150, 290);
    rectangle(200, 240, 225, 290);
    arc(175, 110, 195, 345, 30);

    getch();
    closegraph();

    return 0;
}
