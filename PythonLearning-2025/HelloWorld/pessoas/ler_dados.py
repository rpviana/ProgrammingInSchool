import json
from gravar_dados import nome_do_ficheiro
from pessoas import Pessoa 

pessoas = []

with open(nome_do_ficheiro,"r",encoding="utf8") as f:
    pessoas = json.load(f)

    print(*pessoas, sep="\n")