from decimal import Decimal
from functools import reduce
import math

# returns the mean of a given array of integers
def mean(elements):
    return round(Decimal(reduce(lambda x, y: x + y,elements)/len(elements)),1)

# returns the standard deviation of a given arry of integers
def standard_deviation(elements, elements_mean):
    numerator = 0
    for element in elements:
        numerator += (element-elements_mean)**2
    variance=(numerator/len(elements))
    stdr_deviation=round(math.sqrt(variance),1)
    return stdr_deviation

if __name__ == '__main__':
    arr_length=int(input())
    elements=list(map(int,input().split()))

    elements_mean=mean(elements)
    elements_standard_deviation=standard_deviation(elements,elements_mean)
    print(elements_standard_deviation)