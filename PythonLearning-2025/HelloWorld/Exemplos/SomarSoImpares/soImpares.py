x = 3
def somar(y=4): #funcao tem parametro que por defenicao e 4
    #como usar/passar a variavel x que esta fora da funcao para dentro
    x = 2 #este x e diferente do que esta de fora da funcao
    s = x + y #se nao houver variavel x dentro da funcao mas houver fora, vai usar a de fora
    print(s)

print(somar()) #como funcao nao tem return, ao fazer isso o resultado ira ser "None"
somar(x) #da 5 pois no inicio x=3 e como temos defenido que somar é x(x=3) ele mete que y=3 e mete x + y= 2 + 3 = 5
somar() #ja esse da 6 pois como o parametro nao tem nenhum valor atribuido fica o que esta la(y=4) e faz a conta x + y= 2 + 4

def somar2(v1,v2=3,v3=None):
    if v3 is None: #so executa a funcao se v3="None"
        return v1 + v2 #se v3 for None faz v1 + v2
    else:
        return v1 + v2 + v3  #caso v3 seja algo diferente de "None" faz isso
s = somar2(8,10) #vai executar, v1=10, v2=10, caso metessemos um terceiro numero, faria o else porque v3!=None
q = somar2(8,10,10) #vai executar, v1=10, v2=10,v3=10 porque v3 ja tem valor
print(s)
print(q)

def somar3(*args):
    soma = 0
    for arg in args:
        soma = soma + arg
    return soma

def total_impares(*args):
    contagem = 0
    for arg in args:
        if arg % 2 == 1: # e impar
            contagem += 1
    return contagem

soma = lambda x,y: x + y
print(soma(3,2))
par = lambda x: "Par" if x % 2 == 0 else "Impar"
    