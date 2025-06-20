def new_product(produto, preco, iva):#criar a funcao add com atributos product,price,tax

    return { 'product': produto, 'price': preco, 'tax': iva}

def update_final_price(dicionario):
    dicionario['final_price'] = round(dicionario['price']) * (1+dicionario['tax'])

def print_product(p):
    print(f'{p['product']}; Preco: {p['price']}',sep="")
    print(f'IVA: {p['tax']*100}%, Preco final: {p['final_price']}')

titulo = "Bem vindo aos nossos produtos"