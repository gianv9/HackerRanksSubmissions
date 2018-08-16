import re

# receiving the lines
number_lines=int(input())
lines=[]
while number_lines > 0:
    lines.append(input())
    number_lines-=1
    
# receiving the sub string we want to search
search=int(input())
while search > 0:
    regex="\w(?P<sub_string>"+input()+")\w"
    found = 0
    for line in lines:
        found+=len(re.findall(regex,line))
    print(found)
    
    search-=1