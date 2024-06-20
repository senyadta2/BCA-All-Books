#include<stdio.h>

int main() {
    int n, i, j;
    float x, l, v = 0, ax[10], fx[10], L[10];
    
    printf("Enter the number of points: ");
    scanf("%d", &n);
    
    printf("Enter the value of x: ");
    scanf("%f", &x);
    
    for (i = 0; i < n; i++) {
        printf("Enter the value of x and fx at i=%d: ", i);
        scanf("%f %f", &ax[i], &fx[i]);
    }
    
    for (i = 0; i < n; i++) {
        l = 1.0;
        
        for (j = 0; j < n; j++) {
            if (j != i) {
                l = l * ((x - ax[j]) / (ax[i] - ax[j]));
            }
        }
        
        L[i] = l;
    }
    
    for (i = 0; i < n; i++) {
        v = v + fx[i] * L[i];
    }
    
    printf("Interpolated value = %f", v);
    
    return 0;
}

