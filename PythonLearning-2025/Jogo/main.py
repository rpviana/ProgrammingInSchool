# main.py
from getpass import getpass
from random import randint
from colorama import Fore, Back, init
from naves import NaveExtra
from tabuleiro import Tabuleiro
import os

# Inicializa o colorama
init(autoreset=True)

# Função para exibir a capa e iniciar o jogo
def capa():
    print("===== BATALHA DE NAVES =====")
    print("Bem-vindo ao jogo!")
    print("Pressione qualquer tecla para continuar...")
    getpass("")

# Função para escolher o modo de jogo e o tabuleiro
def iniciar_jogo():
    os.system("cls")  # Limpa a tela
    capa()
    
    # Escolha do modo de jogo
    print("Escolha o modo de jogo:")
    print("1. Tiros controlados pelo jogador")
    print("2. Tiros aleatórios")
    modo = input("Digite o número do modo escolhido: ")

    # Escolha do tabuleiro
    print("\nEscolha o tabuleiro:")
    print("1. Pirâmide invertida")
    print("2. Tabuleiro normal")
    tipo_tabuleiro = input("Digite o número do tabuleiro escolhido: ")

    # Configuração do tabuleiro
    if tipo_tabuleiro == "1":
        tabuleiro = Tabuleiro(tipo="piramide")
    elif tipo_tabuleiro == "2":
        tabuleiro = Tabuleiro(tipo="normal")
    else:
        print("Opção inválida! O tabuleiro padrão (pirâmide invertida) será usado.")
        tabuleiro = Tabuleiro(tipo="piramide")

    # Criar naves com energia extra
    rosa = NaveExtra("Nave1", "Rosa", 10, "R", 12)
    vermelho = NaveExtra("Nave2", "Vermelho", 15, "V", 18)
    azul = NaveExtra("Nave3", "Azul", 18, "A", 24)

    # Dicionários para armazenar posições das naves e dos tiros
    naves_posicoes = {}
    tiros_posicoes = {}
    num_tiros = 0
    tiros_certeiros = 0

    # Função para exibir as naves com suas cores
    def mostrar_dados_com_cor(nave):
        cor = ""
        if nave.cor == "Rosa":
            cor = Fore.MAGENTA
        elif nave.cor == "Vermelho":
            cor = Fore.RED
        elif nave.cor == "Azul":
            cor = Fore.BLUE

        return f"{cor}{nave.nome} | Energia: {nave.energia} | Letra: {nave.letra}"

    # Loop do jogo
    while num_tiros < 100:
        os.system("cls")  # Limpar o ecrã antes de cada ronda

        # Posiciona as naves aleatoriamente
        naves_posicoes = {
            tabuleiro.posicionar_nave(): rosa.letra,
            tabuleiro.posicionar_nave(): vermelho.letra,
            tabuleiro.posicionar_nave(): azul.letra
        }

        # Posiciona os tiros de acordo com o modo selecionado
        if modo == "1":
            print("\nEscolha a posição do tiro:")
            linha = int(input("Digite o número da linha: "))
            coluna = input("Digite a letra da coluna: ").upper()
            posicao_tiro = (linha, coluna)
        else:
            posicao_tiro = tabuleiro.posicionar_tiro()
        
        tiros_posicoes[posicao_tiro] = "X"  # Marca o tiro
        num_tiros += 1

        # Verifica acertos e atualiza energia das naves
        for posicao, letra in naves_posicoes.items():
            if posicao == posicao_tiro:
                if letra == rosa.letra:
                    rosa.perder_energia()
                elif letra == vermelho.letra:
                    vermelho.perder_energia()
                elif letra == azul.letra:
                    azul.perder_energia()
                tiros_certeiros += 1

        # Desenha o tabuleiro e mostra informações
        print(f"RONDA DE TIROS Nº {num_tiros // 3 + 1}")
        tabuleiro.desenhar(naves_posicoes, tiros_posicoes)

        # Mostra dados das naves com cores
        print("\nEstado das Naves:")
        print(mostrar_dados_com_cor(rosa))
        print(mostrar_dados_com_cor(vermelho))
        print(mostrar_dados_com_cor(azul))

        # Mostra a eficácia dos tiros
        eficacia = (tiros_certeiros / num_tiros) * 100
        print(f"\nTotal de tiros dados: {num_tiros}")
        print(f"Tiros certeiros: {tiros_certeiros}")
        print(f"Eficácia dos tiros: {eficacia:.2f}%")

        # Adiciona energia extra às naves na rodada 45
        if num_tiros == 45:
            rosa.adicionar_energia_extra()
            vermelho.adicionar_energia_extra()
            azul.adicionar_energia_extra()

        # Espera pelo jogador para continuar com `getpass`
        getpass("\nPressione ENTER para continuar para a próxima rodada...")

        # Remove naves com energia zero do tabuleiro
        naves_posicoes = {pos: letra for pos, letra in naves_posicoes.items() if letra != " "}

        # Verifica se todas as naves foram destruídas
        if rosa.energia == 0 and vermelho.energia == 0 and azul.energia == 0:
            print("Todas as naves foram destruídas! Jogo terminado.")
            break
        elif num_tiros >= 105:
            print("Limite de tiros atingido. Jogo terminado.")
            break

# Iniciar o jogo
iniciar_jogo()
