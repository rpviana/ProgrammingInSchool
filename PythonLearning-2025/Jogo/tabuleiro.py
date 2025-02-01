# tabuleiro.py
import random

class Tabuleiro:
    def __init__(self, tipo="piramide"):
        # Define o tipo de tabuleiro a ser criado (padrão: pirâmide invertida)
        self.tipo = tipo
        self.tabuleiro = self._criar_tabuleiro()

    def _criar_tabuleiro(self):
        """Cria o layout do tabuleiro baseado no tipo selecionado."""
        if self.tipo == "piramide":
            # Pirâmide invertida: 3 níveis
            return {
                1: ['A', 'B', 'C', 'D', 'E'],
                2: ['B', 'C', 'D'],
                3: ['C']
            }
        # Outras opções de tabuleiro podem ser adicionadas aqui (exemplo de 3x3)
        elif self.tipo == "normal":
            return {
                1: ['A', 'B', 'C'],
                2: ['A', 'B', 'C'],
                3: ['A', 'B', 'C']
            }
        else:
            raise ValueError("Tipo de tabuleiro inválido.")

    def desenhar(self, naves_posicoes=None, tiros_posicoes=None):
        """
        Desenha o tabuleiro, mostrando as posições das naves e tiros.
        'naves_posicoes' e 'tiros_posicoes' são dicionários com coordenadas.
        """
        print("Tabuleiro:")
        for linha, colunas in self.tabuleiro.items():
            for coluna in colunas:
                pos = (linha, coluna)
                if naves_posicoes and pos in naves_posicoes:
                    print(naves_posicoes[pos], end=" ")  # Letra da nave
                elif tiros_posicoes and pos in tiros_posicoes:
                    print("X", end=" ")  # Indica posição de tiro
                else:
                    print("·", end=" ")  # Posições vazias
            print()

    def posicionar_nave(self):
        """Gera uma posição aleatória para a nave no tabuleiro."""
        linha = random.choice(list(self.tabuleiro.keys()))
        coluna = random.choice(self.tabuleiro[linha])
        return (linha, coluna)

    def posicionar_tiro(self):
        """Gera uma posição aleatória para o tiro no tabuleiro."""
        return self.posicionar_nave()  # Posicionamento semelhante
