from decimal import Decimal

n=int(input())
x=list(map(int,input().split()))
w=list(map(int,input().split()))
numerator=0
denominator=0
for i in range(n):
    numerator+=x[i]*w[i]
    denominator+=w[i]
    
result=Decimal(numerator/denominator)

print(round(result,1))