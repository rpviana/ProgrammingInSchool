from pessoas import Pessoa
import json

nome_do_ficheiro = "lista_pessoas.json" #inicio de criacao do ficheiro
pessoas = [] #dicionario vazio

if __name__ == "__main__": #executa so esse codigo no proprio ficheiro, caso importado nao executes #main porque e o principal, se fosse feito print __name__ em outro ficheiro mostraria o ficheiro que e chamado de main
    for i in range(3): #de 0 a 2(3 nums)
        nome = input(f"Digite o nome da pessoa n{i+1}: ") #vai somando ate a pessoa 2
        idade = int(input(f"Digite a idade da pessoa n{i+1}: ")) #vai somando ate a pessoa 2
        pessoas.append(Pessoa(nome, idade).__dict__) #append para adecionar alguma coisa a lista e __dict__ para transformar em dicionario

    with open(nome_do_ficheiro,"w",encoding="utf8") as f: #com o que criamos, metemos w(write), enconding permite que metemos caracteres especiais sem dar desformatacao e depois metemos "as f" que representa file 
        json.dump(pessoas,f,ensure_ascii=False,indent=2) #o ensure_ascii completa o utf8 para garantir que fica direito e o indent para organizar melhor, da 2 espacos no inicio de cada coisa
    #quando correr cria ficheiro
    print("dados guardados com sucesso")#confirma que funcionou
