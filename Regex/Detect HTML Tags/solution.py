import re
lines = int(input())
tags=[]
regex='<\s*(?P<tag>[a-z0-9]+)(?:\s*|.*?)>'
html_fragment=''
# collect the whole fragment line by line
while lines > 0:
    html_fragment+=input()
    lines-=1

result=re.findall(regex,html_fragment)
result_set=set(result)
result=sorted(result_set)
IFS=';'
for index,tag in enumerate(result):
    if index == len(result)-1 :
        IFS=''
    print(tag,end=IFS)