'''x = "Rodrigo Viana"
n = 16

print("O meu nome é",x,"e a minha idade é:",n)
print("O meu nome é " + x + " e a minha idade é: "+ str(n))
print(f'O meu nome é {x} e a minha idade é: {n}')
#comentário
produto1 = "marcelo"
produto2 = "marcelo"
produto3 = "marcelo"

print(produto1, end=', ')
print(produto1, end=', ')
print(produto3)'''

#BIBLIOTECAS
'''import os # importa todas as funções do módulo
from random import randrange # importa apenas a função randerage do módulo random

num1 = randrange(1,10)
print(num1)
num2 = randrange(1,20)
print(num2)'''

#FORÇAR INT
'''num1 = input("Digite o primeiro valor: ")
num2 = input("Digite o segundo valor: ")
print("Soma =", int(num1) + int(num2))

#ou

num1 = int(input("Digite o primeiro valor: "))
num2 = int(input("Digite o segundo valor: "))
print("Soma =", num1 + num2)'''

#COMPRIMENTON E MANIPULAÇAO CARACTERES
'''frase = "Maioria dos alunos"
print(frase[0:12]) # primeiros 11 caracteres
print(frase[12:]) # do 12 caracter ate ao ultimo
print(len(frase)) # mostra total caracteres da frase'''

#DAR REPLACE NAS PALAVRAS E CRIAR LISTA, ENCONTRAR 
frase = "Maioria dos alunos"
frase2 = frase.replace("Maioria","Minoria")
print(frase2)

listaDePalavras = frase.split(" ")
print(type(listaDePalavras))
print(listaDePalavras)

for palavra in listaDePalavras:
    print(palavra)

for i in range(10):
    print(i)