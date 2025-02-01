
import os
ferramentas = ['Alicate', 'Martelo', 'Chave de fendas', 'Serra']

print(ferramentas[0])
ferramentas[2] = 'Parafusadeira'
print(ferramentas[2])
print(ferramentas)
print(type(ferramentas))

#Adicionar elemento ao final da lista
ferramentas.append('Chave de fendas')
print(ferramentas)
#ou
ferramentas.insert(1,'Furadeira')
print(ferramentas)
os.system('cls')

#mostrar elementos apenas comecados em "C" ou "P"
'''for fr in ferramentas:
    if fr.startswith(('C','P')):
        print(f'x {fr}')'''

#mostrar elementos apenas acabados em "C" ou "P"
'''for fr in ferramentas:
    if fr.endswith(('C','P')):
        print(f'x {fr}')'''

#Remover elementos
ferramentas.pop()
print(ferramentas)

#Remover um elemento específico
ferramentas.pop(3)
print(ferramentas)
#ou
ferramentas.remove('Serra')
print(ferramentas)
