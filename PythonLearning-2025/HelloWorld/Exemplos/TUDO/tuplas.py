lista = [1, 2, 3]
lista2 = lista
print(lista2)
a=1
b=2
c=3
a,b,c=1,2,3
a,b,c=lista
print(a,b,c)
#ou
lista = [1,2,3]
tupla = ('a', 'b')
l = list(tupla)
l[0] = 'c'
tupla = tuple(l)
print(tupla)