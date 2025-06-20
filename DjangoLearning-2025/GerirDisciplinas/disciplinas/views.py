from django.shortcuts import render
from .models import Disciplina

# Create your views here.
def index(request):
    return render(
        request,
        'disciplinas/index.html'
    )

def disciplinas_25h_ativada(request):
    d = Disciplina.objects.all().filter(horas = 25,ativada = True)
    contexto = { 
        "title": "Página Inicial",
        "Disciplinas": d
        }
    return render (
        request,
        'disciplinas/disciplinas.html',#estou em templates, tenho de entrar na pasta contact e depois em index.html
        contexto
    )