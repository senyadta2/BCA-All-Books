#include<stdio.h>
#include<graphics.h>
#include<dos.h>
#include<conio.h>
void floodFill(int x,int y,int oldcolor,int newcolor)
{
if(getpixel(x,y) == oldcolor)
{
putpixel(x,y,newcolor);
floodFill(x+1,y,oldcolor,newcolor);
floodFill(x,y+1,oldcolor,newcolor);
floodFill(x-1,y,oldcolor,newcolor);
floodFill(x,y-1,oldcolor,newcolor);
}
}


int main(){
int gd= DETECT,gm;
int x,y,r;
initgraph(&gd,&gm,"C:\\TURBOC3\\BGI");
printf("enter 2 values:");
scanf("%d%d",&x,&y);
printf("enter the radiu");
scanf("%d",&r);
circle(x,y,r);
floodFill(x,y,4,15);
//delay(50);
getch();
closegraph();
return 0;
}