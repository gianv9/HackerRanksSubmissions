import re
regex = '^[A-Z]{5}[0-9]{4}[A-Z]$'

length = int(input())
while length > 0:
    PAN = input()
    matches = bool(re.search(regex,PAN))
    if matches :
        print('YES')
    else:
        print('NO')
    length -= 1