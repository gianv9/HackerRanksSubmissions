import re

lines=int(input())
regex=''
while lines > 0:
    line=input()
    valid=bool(re.search(r'^[_\.]\d+[a-zA-Z]*_?$',line))
    if valid :
        print('VALID')
    else:
        print('INVALID')
    lines-=1