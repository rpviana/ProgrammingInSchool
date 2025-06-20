#EX1 
def Num5e10(*args):
    valor=0
    for num in args:
        if 5<num<10:
            valor = num + valor
    return valor

print(Num5e10(1,2,3,4,5,6,7,10,11))

#EX2
verifica_Pos_Neg = lambda Pos_Neg: "P" if    Pos_Neg > 0 else "N"

print(verifica_Pos_Neg(1))
print(verifica_Pos_Neg(0))
print(verifica_Pos_Neg(-1))

#EX3
num = 123

def Inverter(num):
    inverso = 0
    while num != 0:
        inverso = inverso * 10 + num % 10
        num = num // 10

    return inverso

print(Inverter(321))

#EX4
contarDigitos = lambda contar: len(str(contar))
print(contarDigitos(12345))

#EX5
def NumPerfeito(num):
    soma = 0
    for divisor in range(1,num):
        if num % divisor == 0:
            soma = soma + divisor
    if num == soma:
        print("Numero Perfeito")
    else:
        print("Numero Imperfeito")

NumPerfeito(5)
NumPerfeito(6)

