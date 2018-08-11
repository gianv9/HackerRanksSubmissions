# documentation user for solving this:
#   https://docs.python.org/3/howto/regex.html#grouping
import re
# this pattern finds the link
pattern1 = r'<a href=\"(?P<href>.*?)\".*?>((<[a-z]>)?\s?(?P<data>.*?)(<\/[a-z]>)?)<'
p1 = re.compile(pattern1)

lines = int(input())
html_lines = ""
while lines > 0:
    html_lines = html_lines + str(input())
    lines = lines - 1

result = p1.findall(html_lines)

for element in result:
    print(element[0]+","+element[3])

# # see this regex in action: https://regex101.com/r/WGgJwy/5