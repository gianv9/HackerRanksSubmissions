from decimal import Decimal

# returns the median and the left and right set of elements
def median(elements):
    elements.sort()
    num_of_elem=len(elements)
    evenNumber=num_of_elem %2 == 0
    median=0
    result = None
    if not evenNumber:
        index=int((num_of_elem+1)/2)-1
        median=elements[index]
        result=(elements[0:index],median,elements[index+1:num_of_elem])
    else:
        middle_right_index=int(num_of_elem/2)
        middle_left_index=middle_right_index-1
        middle_left=elements[middle_left_index]
        middle_right=elements[middle_right_index]
        median=Decimal((middle_left+middle_right)/2.0)
        result=(elements[0:middle_left_index+1],median,elements[middle_right_index:num_of_elem])
    return result

if __name__ == '__main__':
    num_of_elem=int(input())
    elements=list(map(int,input().split()))
    r2=median(elements)
    r1=median(r2[0])
    r3=median(r2[2])
    print(r1[1])
    print(r2[1])
    print(r3[1])