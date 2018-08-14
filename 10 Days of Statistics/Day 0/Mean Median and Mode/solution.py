from functools import reduce
from decimal import Decimal

# From stdin:
# num_of_elem=int(input())
# elements=list(map(int,input().split()))

# From a file:
num_of_elem=0
elements=""
with open('input/input03.txt','r') as file_in:
    file_lines=file_in.readlines()
    num_of_elem=int(file_lines[0])
    elements=file_lines[1]
elements=list(map(int,elements.split()))


mean=Decimal(reduce(lambda x, y: x + y,elements)/num_of_elem)
oddNumber=num_of_elem %2 == 0
median=0
if not oddNumber :
    median=elements[int((num_of_elem+1)/2)-1]
else:
    elements.sort()
    middle_left=elements[int(num_of_elem/2)-1]
    middle_right=elements[int(num_of_elem/2)]
    median=Decimal((middle_left+middle_right)/2.0)

elements_set=sorted(set(elements))

mode=None
mode_index_number=None

mode = count = elements.count(elements_set[0])
mode_index_number = elements_set[0]

for i in elements_set[1:len(elements_set)]:
    count = elements.count(i)
    if count > mode:
        mode = count
        mode_index_number = i
    elif count == mode and i < mode_index_number:
        mode_index_number = i

print(round(mean,1))
print(round(median,1))
print(mode_index_number)