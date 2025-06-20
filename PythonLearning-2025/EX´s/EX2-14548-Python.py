dados = [
{ 'nome': 'Marcelo', 'sexo': 'M', 'altura': 1.84, 'peso': 98 },
{ 'nome': 'Rui', 'sexo': 'M', 'altura': 1.94, 'peso': 83 },
{ 'nome': 'Joana', 'sexo': 'F', 'altura': 1.68, 'peso': 68 },
{ 'nome': 'Leonor', 'sexo': 'F', 'altura': 1.64, 'peso': 59 },
{ 'nome': 'Alfredo', 'sexo': 'M', 'altura': 1.87, 'peso': 105 }
]

lista_genero = map(lambda x: 1 if x['sexo'] == "M" else 0, dados)
print(list(lista_genero))
#OU
lista_genero = list(map(lambda x: 1 if x['sexo'] == "M" else 0, dados))
print(lista_genero)
#OU
lista_genero = list(map(lambda x: 1 if x['sexo'] == "M" else 0, dados))
print(f"A lista numerica sobre o sexo: {list(lista_genero)}")

lista2 = map(lambda ps: (ps['nome'],0) if ps['sexo'] == "F" else (ps['nome'],1),dados)
print(list(lista2))

#devolve uma tupla de tuplas com o nome
lista3 = map(lambda ps: (ps['nome'], ps['peso'] / (ps['altura']**2)), dados)
print(tuple(lista3))

#crie uma funcao que devolva uma tupla com a média do peso e da altura de todas as pessoas
def medias(pessoas):
    mediaPeso = 0
    mediaAltura = 0
    
    for pessoa in pessoas:
        mediaPeso += pessoa['peso']
        mediaAltura += pessoa['altura']
    mediaPeso /= len(pessoas)
    mediaAltura /= len(pessoas)
    return (mediaPeso,round(mediaAltura,2)) #round=arrendonda o num de casas decimais

print(medias(dados))

dados2 = {
'a': { 'nome': 'Marcelo', 'sexo': 'M', 'altura': 1.84, 'peso': 98 },
'b': { 'nome': 'Rui', 'sexo': 'M', 'altura': 1.94, 'peso': 83 },
'c': { 'nome': 'Joana', 'sexo': 'F', 'altura': 1.68, 'peso': 68 },
'd': { 'nome': 'Leonor', 'sexo': 'F', 'altura': 1.64, 'peso': 59 },
'e': { 'nome': 'Alfredo', 'sexo': 'M', 'altura': 1.87, 'peso': 105 }
}

#vai ficar ** pois ja e um dicionario e nao uma lista
#"**" serve para dizer que os argumentos tem um nome(em cima)
def medias2(**pessoas):
    mediaPeso = 0
    mediaAltura = 0
    
    for pessoa in pessoas.values():#quando recebo os argumentos manda tudo, com o values, ele separa a 
        mediaPeso += pessoa['peso']               #chave do valor, porque so queremos a media do valor
        mediaAltura += pessoa['altura']
    mediaPeso /= len(pessoas)
    mediaAltura /= len(pessoas)
    return (mediaPeso,round(mediaAltura,2)) #round=arrendonda o num de casas decimais

#os "**" servem para dizer que vai receber argumentos nomeados
print(medias2(**dados2))#servem para desmpacotar os dados, separa os dados por ","

