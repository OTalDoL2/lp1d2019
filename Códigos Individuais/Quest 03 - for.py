num1 = 1
num2 = num1 + 1

for num in range(49):
    num3 = num2 + num1
    print('{0} + {1} = {2}'.format(num1, num2, num3))
    num1 += 1
    num2 += 1
press = input("Pressione para encerrar a aplicação")
