num1 = int(input('Primeiro Número: '))
num2 = int(input('Segundo Número: '))
maior = 0
menor = 0
soma = 0

if num1 > num2:
    maior = num1
    menor = num2
else :
    maior = num2
    menor = num1

for i in range(menor, maior + 1):
    soma += i

print('A soma dos números entre {0} e {1} é {2}'.format(menor, maior, soma))
press = input("Pressione para encerrar a aplicação")