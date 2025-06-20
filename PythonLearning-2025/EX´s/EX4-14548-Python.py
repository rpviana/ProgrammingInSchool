products = []

#EXERCICIO 3
def add(produto, preco, iva):#criar a funcao add com atributos product,price,tax

    return { #faco logo return para poupar codigo
        'product': produto,
        'price': preco,
        'tax': iva
    }

#EXERCICIO 4
def update_final_price(dicionario):
    dicionario['final_price'] = round(dicionario['price']) * (1+dicionario['tax'])

for product in products:
    update_final_price(product)

#EXERCICIO 5
products.append(add("Martelo", 15.45,0.23))
products.append(add("Alicate", 13.45,0.23))
products.append(add("Martelo", 15.20,0.23))

#EXERCICIO 6
def print_product(p):
    print(f'{p['product']}; Preco: {p['price']}',sep="")
    print(f'IVA: {p['tax']*100}%, Preco final: {p['final_price']}')

#EXERCICIO 7
for product in products:
    update_final_price(product)
    print_product(product)
