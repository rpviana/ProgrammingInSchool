# naves.py

class NaveModelo:
    def __init__(self, nome, cor, perda_energia, letra):
        self.nome = nome
        self.cor = cor
        self.energia = 100
        self.perda_energia = perda_energia
        self.letra = letra

    def perder_energia(self):
        """Reduz a energia da nave pela quantidade de perda especificada"""
        self.energia -= self.perda_energia
        if self.energia < 0:
            self.energia = 0

    def mostrar_energia(self):
        """Retorna a energia atual da nave"""
        return self.energia


class NaveExtra(NaveModelo):
    def __init__(self, nome, cor, perda_energia, letra, energia_extra):
        super().__init__(nome, cor, perda_energia, letra)
        self.energia_extra = energia_extra

    def adicionar_energia_extra(self):
        """Adiciona a energia extra à nave, sem ultrapassar 100"""
        self.energia = min(100, self.energia + self.energia_extra)

    def mostrar_dados(self):
        """Mostra os dados da nave (nome, energia, letra)"""
        return f"{self.nome} - Energia: {self.mostrar_energia()} - Letra: {self.letra}"
