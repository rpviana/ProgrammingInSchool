from django.db import models

class Disciplina(models.Model):
    denominacao = models.CharField(max_length=100)
    horas = models.IntegerField()
    ativada = models.BooleanField(True)


