multiplicando = int(input('Digite o número cuja tábua deseja ver: '))
multiplicador = 1
for num in range(10):
    produto = multiplicando * multiplicador
    print('{0} X {1} = {2}'.format(multiplicando, multiplicador, produto))
    multiplicador += 1
press = input("Pressione para encerrar a aplicação")
