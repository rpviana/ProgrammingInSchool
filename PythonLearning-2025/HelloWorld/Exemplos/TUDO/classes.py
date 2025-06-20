class ContaBancaria:
    #CONSTRUTOR
    def __init__(self, cliente, saldo, agencia):
        self.cliente = cliente
        self.saldoInicial = saldo
        self.agencia = agencia
        self.emprestimo = False

    #METODOS
    def depositar(self,valor):
        self.saldoInicial = self.saldoInicial + valor #mete o saldo + valor escolhido pela pessoa

    def levantar(self,valor):
        if self.saldoInicial > valor:
            self.saldoInicial -= valor #mete o saldo - valor escolhido pela pessoa
        else:
            print("Saldo Insufeciente, pobre")#a pessoa pode nao ter a quantia que deseja levantar, logo nao daria

c1 = ContaBancaria("Viana", 100.0, "Fafe")
c2 = ContaBancaria("Ana", 1000.0, "Santo Tirso")
c2.depositar(200)
#print(c1.saldoInicial)#mostra o saldo Inicial da conta, no caso como e 0, fica 0+200=200
print(c2.saldoInicial)#mostra o saldo Inicial da conta, no caso como e 1000, fica 1000+200=1200
c2.levantar(500) #1200-500 = 700
c1.levantar(500) #0-500 = "Saldo Insufeciente, pobre"
print("Saldo da conta: ", c2.saldoInicial)#como vai levantar 500, fica 1200(dos 1000+200(depositados)) 1200-500=700
print("Saldo da conta: ", c1.saldoInicial)#como nao vai conseguir levantar dinheiro o saldo vai se manter o mesmo
c2.levantar(300)

