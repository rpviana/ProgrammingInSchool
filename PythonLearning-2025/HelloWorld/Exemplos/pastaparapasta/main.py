#import modules = importar o ficheiro modules 
#import modules as m = importar o ficheiro modules como nome m
from modules import soma#importar o ficheiro modules com funcoes mult e soma
from sys import platform #permite ter acesso a varias infos do sistema
#from pastapapasta.main import soma = caso estivesse em outra pasta chamariamos a pasta


boasvindas = "Ola Python"
#print(modules.soma(3,4)) = chamar modules e funcao soma(primeiro caso)
#print(m.soma(3,4)) = chamar modulo(m) e funcao soma(segundo caso)
print(soma(3,4)) #chamar modulo(m) e funcao

platform = "Minha plataforma"
print(platform)#esse atributo sobrepoem-se a libraria sys que mostraria o sistema, mas nesse caso mostraria "Minha Plataforma"