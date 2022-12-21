sequencia = int(input('Digite quantos termos da sequência de Fibonacci deseja ver: '))

n = 0
f = 1

for i in range(sequencia):
    print(f)
    aux = f
    f = f + n
    n = aux
