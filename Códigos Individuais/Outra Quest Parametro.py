# Quest 01 - Tendo como parâmetros a altura e o sexo de uma pessoa (M - Masculino e F - Feminino), crie uma função que calcule o peso ideal de uma pessoa utilizando as seguintes fórmulas: - para homens: (72.7*h) - 58 - para mulheres: (62.1*h) - 44.7

sexo = input("Digite seu sexo, M para Masculino e F para Feminino: ")
if sexo == "M" or sexo == "m":
    alt = float(input("Digite sua altura em cm: "))
    peso = (alt * 72.7) - 58
    print("Seu peso ideal é ", peso)
elif sexo == "F" or sexo == "f":
    alt = float(input("Digite sua altura em cm: "))
    peso = (alt * 62.1) - 44.7
    print("Seu peso ideal é ", peso)
    
# 2. Escrever uma procedimento que l� um conjunto de 4 valores: i, a, b, c, onde i � um valor inteiro e positivo e a, b, c, s�o quaisquer valores reais e os escreva. A seguir: a) Se i==1 escrever os tr�s valores a, b, c em ordem crescente. b) Se i==2 escrever os tr�s valores a, b, c em ordem decrescente. c) Se i==3 escrever os tr�s valores a, b, c de forma que o maior entre a, b, c fique dentre os dois.
# 3. Crie um procedimento que recebe como par�metros o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se ela poder� ou n�o votar este ano (n�o � necess�rio considerar o m�s em que a pessoa nasceu).
    