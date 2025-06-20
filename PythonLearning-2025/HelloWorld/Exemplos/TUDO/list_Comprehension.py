lista = []
lista1 = [n for n in range(1,11)]#no python e sempre o valor posterior ao que queremos que apareca(para cada n de 1 a 10 mostra tudo)
print(lista1)

lista2 = [n*2 for n in range(21)]#multiplicar todos os numeros de 0 a 20 por 2(para cada n de 0 a 20, multiplica por 2)
print(lista2)

#lista com apenas num pares
lista3 = [
    num #elementos da lista
    for num in range(21) #elementos selecionados
    if num % 2 == 0 #filtro dos elementos 
]

soma = sum([n for n in range(4)])
print(soma)

from statistics import mean
media = mean([n for n in range(1,11)])
print(media)

produtos = [
    {"nome": "p1", "preco":20},
    {"nome": "p2", "preco":10},
    {"nome": "p3", "preco":30}
]

#Mapeamento:
novosProdutos = [
    {**produto, "preco": produto["preco"]* 1.05} #o "preco" vai ficar(toma valor) "preco" x 1.05
    if produto["preco"] > 20 else {**produto} # se o meu preco for maior que 20 multiplica por 1.05, caso contrario desmpacota e nao altera
    for produto in produtos #caso nao seja maior que 20 mantem o mesmo preco 
]

nums = [4,7,11,3,12,21]

novaLista = [
    num if num > 5 else 0
    for num in nums
    if num > 5
]

print(novaLista)