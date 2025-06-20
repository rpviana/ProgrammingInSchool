lista = [2, 3, 4]

# DOBRO DE UM NUM
dobro = map(lambda x: x * 2, lista)
print(list(dobro))

# AO INVES DE DAR 1,5 DA 1
metadeInteira = map(lambda x: x//2, lista)
print(list(metadeInteira))

# ELEVAR NUM A 2
quadrado = map(lambda x: x ** 2, lista)
print(tuple(quadrado))