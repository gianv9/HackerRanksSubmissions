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
        result=(elements[0:index],Decimal(median),elements[index+1:num_of_elem])
    else:
        middle_right_index=int(num_of_elem/2)
        middle_left_index=middle_right_index-1
        middle_left=elements[middle_left_index]
        middle_right=elements[middle_right_index]
        median=Decimal((middle_left+middle_right)/2.0)
        result=(elements[0:middle_left_index+1],Decimal(median),elements[middle_right_index:num_of_elem])
    return result

# adds a number to a list given a frequecy
def add_to_list(number, frequency, numbers):
    elements=[number]*frequency
    numbers.extend(elements)
        
    
if __name__ == '__main__':
    num_of_elem=int(input())
    numbers=list(map(int,input().split()))
    frequency=list(map(int,input().split()))
    resulting_list=[]
    for i in range(num_of_elem):
        add_to_list(numbers[i],frequency[i],resulting_list)
    
    resulting_list.sort()
    r2=median(resulting_list)
    r1=median(r2[0])
    r3=median(r2[2])
    print(round(r3[1],1)-round(r1[1],1))