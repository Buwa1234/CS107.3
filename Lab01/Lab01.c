#include <stdio.h>

int main() {
    int num, sum = 0, i;
    float avg;

    printf("Enter five numbers: ");
    for (i = 0; i < 5; i++) {
        scanf("%d", &num);
        sum = sum + num;
    }

    //Calculate the average 
    avg = sum / (float)5; 
    printf("Average = %.2f", avg);
    return 0;
}
