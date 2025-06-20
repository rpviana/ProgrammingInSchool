lista = []
lista1 = [n for n in range(1,11)]#no python e sempre o valor posterior ao que queremos que apareca
print(lista1)

lista2 = [n*2 for n in range(21)]#multiplicar todos os numeros de 0 a 20 por 2
print(lista2)

lista3 = [
    num
    for num in range(21)
    if num % 2 == 0 
]
print(lista3)