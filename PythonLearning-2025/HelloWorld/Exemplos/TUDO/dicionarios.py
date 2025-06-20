'''aluno = {
    'nome': 'Marcelo',
    'notaMat': 12.5,
    'notaPT': 13.25,
    'outrasNotas': [13,14.25,17.25,8.25]
}

print(aluno['outrasNotas'][1]) 

for key in aluno: #imprime a chave
    print (key)
print('-------------------------------------------------------------')
for value in aluno.values(): #imprime os valores
    print(value)
print('-------------------------------------------------------------')
for key,value in  aluno.items():
    print(f'{key}: {value}') 

alunos = [
            {
                'nome': 'Marcelo',
                'notaMat': 12.5,
                'notaPT': 13.25,
                'outrasNotas': [13,14.25,17.25,8.25]
            },
             {
                'nome': 'Ana',
                'notaMat': 17.5,
                'notaPT': 8.25,
                'outrasNotas': [12,11.25,17.5,8.25]
            }
]

print(alunos[1]['nome']) #output: Ana

nomes = ['marcelo', 'ana', 'joao'] #ir buscar uma letra de um nome especifico de uma lista
print(nomes[0][2])'''

aluno = {
    'nome': 'Rodrigo Viana',
    'psi': 13.25,
    'port': 14.50,
    'mat': 11.33    
}

def mediafinal(**valores):
    media = 0.0
    i = 0
    for diciplina, nota in valores.items():
        if isinstance(nota,float):
            print(f'{diciplina}: {nota} valores')
            media += nota
            i += 1
            print(i)
            print(media)

    media = media / i
    return media
    
m = mediafinal(**aluno)
print(m)

# aluno = {
#     'nome': 'Lucas Soares',
#     'psi': 13.25,
#     'port': 14.50,
#     'mat': 11.33
# }

# def mediafinal(**valores):
#     media = 0.0
#     i = 0
#     for disciplina, nota in valores.items():
#         if isinstance(nota,float): # percorre o dicionario e pega apenas os valores do tipo float
#             media += nota
#             i += 1
#     return media/i

# m = mediafinal(**aluno)
# print(m)