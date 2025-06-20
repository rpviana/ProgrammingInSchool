from products import new_product,update_final_price,print_product

products = []

products.append(new_product('Martelo',12.23,0.06))
products.append(new_product('Chave de fendas',21.10,0.13))
products.append(new_product('Alicate',9.78,0.13))

for product in products:
    update_final_price(product)
    print_product(product)