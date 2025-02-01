class Forma:#superclasse
    def __init__(self, numLados, cor, igual):
        self.numLados = numLados
        self.cor = cor
        self.igual = igual

    def escrever(self):
        print(f"Metodo da classe Forma")

class Quadrado(Forma):
    def __init__(self, numLados, cor, diagonal):
        super().__init__(numLados, cor,)
        self.diagonal = diagonal

    def escrever(self):
        print(f"Metodo da classe Quadrado")

q = Quadrado(4, "Azul", True)
q.escrever()
