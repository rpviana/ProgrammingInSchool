from django.urls import path
from disciplinas import views

app_name = 'disciplinas'

urlpatterns = [
    path('disciplinas/', views.disciplinas_25h_ativada, name='disciplinas'),
    path('', views.index, name='index')
]   

