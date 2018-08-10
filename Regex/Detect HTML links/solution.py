# documentation user for solving this:
#   https://docs.python.org/3/howto/regex.html#grouping
import re
# this pattern finds the link
pattern1 = r'(<a.*(?P<href>(?<=href=\")[^\s]*(?=\")).*>)(?P<data>.*)(<\/a>)'
# (<a.*(?P<href>(?<=href=\")[^\s]*(?=\")).*>)(?P<data>.*)(<\/a>)
p1 = re.compile(pattern1)

lines = int(input())
while lines > 0:
    html_line = str(input())
    result = p1.search(html_line)
    # comma = "\n"
    if result is not None:
        print(result.group('href')+","+result.group('data'))
    # comma = "\n" if comma == "," else ","
    lines = lines - 1

# see this regex in action: https://regex101.com/r/WGgJwy/2