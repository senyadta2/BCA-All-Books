#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <pthread.h>

int g = 0;

void *myThreadFun(void *vargp)
{
    int *myid = (int *)vargp;
    static int s = 0;
    ++s;
    ++g;
    printf("Thread ID: %d, Static: %d, Global: %d\n", *myid, s, g);
}

int main()
{
    int i;
    pthread_t tid[3]; // Array of thread IDs

    for (i = 0; i < 3; i++)
    {
        int thread_id = i; // Create a separate thread ID for each thread
        pthread_create(&tid[i], NULL, myThreadFun, (void *)&thread_id);
    }

    for (i = 0; i < 3; i++)
    {
        pthread_join(tid[i], NULL);
    }

    return 0;
}

