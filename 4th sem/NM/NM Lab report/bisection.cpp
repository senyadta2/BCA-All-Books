#include<stdio.h>
#include<math.h>
#include<stdbool.h>
int a0,a1,a2,a3;
float f(float x)
{
	return (a3*x*x*x+a2*x*x+a1*x+a0);
}
int main(){
	float xl,xm,xu,fxl,fxu,fxm,e,era;
	printf("Enter cofficient of eqn");
	scanf("%d%d%d%d",&a3,&a2,&a1,&a0);
	printf("Enter initial conditions:");
	scanf("%f%f",&xl,&xu);
	printf("Enter error margin");
	scanf("%f",&e);
	while(true)
	{
		fxu = f(xl);
		fxu = f(xu);
		xm = (xl+xu)/2;
		fxm = f(xm);
		if((fxl* fxm)==0)
		{
			printf("Root = %f\n",xm);
			break;
		}
		else if((fxl * fxm)<0){
			xu = xm;
		}
		else{
			xl = xm;
		}
		era = (xu - xl)/xu;
		if(era<e)
		{
			printf("Root = %f\n",xm);
			break;
		}
	}
}
