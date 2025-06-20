from django.contrib import admin
from disciplinas import models

@admin.register(models.Disciplina)#registar modelo
class DisciplinaAdmin(admin.ModelAdmin):
    list_display = ('denominacao','horas','ativada')
    ordering = ('-denominacao',)

