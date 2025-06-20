#Exercicio 1
#lista com apenas num pares de 1 a 10
listaPares = [
    num #elementos da lista
    for num in range(11) #elementos selecionados
    if num % 2 == 0 #filtro dos elementos 
]
print(listaPares)

#OU

listaPares1 = [n*2 for n in range(6)]#multiplicar todos os numeros de 0 a 5 por 2(para cada n de 0 a 5, multiplica por 2)
print(listaPares1)

#Exercicio 2
#Criar uma lista com os quadrados dos números de 1 a 10.
listaQuadrado = [n*n for n in range(11)]# mesma coisa do multiplicar todos os numeros por 2 mas com n*n ao inves de n*2
print(listaQuadrado)

#Exercicio 3
#Dada uma lista de palavras, crie uma nova lista que indique o tamanho de cada palavra.
palavras = ['Alicate', 'Martelo', 'Chave de fendas', 'Serra']

novaLista = [
    len(caracteres)
    for caracteres in palavras
]
    

print(novaLista)

#Exercicio 4
#Com uma lista de números, crie uma lista apenas com os números maiores que 5.
listaNum = [1, 3, 9, 25, 0, 4, 5, 7 ]

novaLista1 = [
    num if num > 5 else 0
    for num in listaNum
    if num > 5
]

print(novaLista1)

#Exercicio 5
#Crie uma lista com as letras maiúsculas de uma string. (nome = 'MarcelO ViEiRa amorIM')
nomes = "RoDrIgo ViaNa"
nome_modificado = [
    char for char in nomes if char.isupper()
]
print(nome_modificado)

#Exercicio 6
#Dada uma lista de números, crie uma nova lista onde se o número for múltiplo de 3, é apresentado o dobro deste caso contrário aparece o mesmo número da lista original.
nums = [1, 4, 8, 12, 24, 25, 27]
multiplos = [n*2 if n % 3 == 0 else n for n in nums]
print(multiplos)