
# L'importation de l’ensemble des éléments du paquet tkinter :
from tkinter import *

# Création d'une fenêtre avec la classe Tk :
fenetre = Tk()

# Ajout d'un titre a la fenetre
fenetre.title("Test App")

# Définir un icone :
# fenetre.iconbitmap("logo.ico") on doit convertir le logo qu’on veut définir en extension

# Personnaliser la couleur de l'arrière-plan de la fenêtre principale :
fenetre.config(bg = "#87CEEB")

# Définir les dimensions par défaut la fenêtre principale :
fenetre.geometry("640x480")

# Limiter les dimensions d’affichage de la fenêtre principale :
fenetre.maxsize(800,600)
fenetre.minsize(300,400)

# Création d'un cadre dans la fenêtre :
cadre1 = Frame(fenetre)
cadre1.pack()

# Ajout d'un texte dans la fenêtre :
texte1 = Label(fenetre, text="Nom")
texte2 = Label(fenetre, text="Prénom")
texte3 = Label(fenetre, text="Age")
texte1.pack()
texte2.pack()

# Ajout d'un bouton dans la fenêtre :
bouton1 = Button(fenetre, text="Cliquez ici")
bouton1.pack()

# Création d'un champ de saisie de l'utilisateur dans la fenêtre :
entree1 = Entry(fenetre)
entree1.pack()

# Création des cases à cocher "Checkbutton" dans la fenêtre :
case_cocher1 = Checkbutton(fenetre, text="choix 1")
case_cocher2 = Checkbutton(fenetre, text="choix 2")
case_cocher3 = Checkbutton(fenetre, text="choix 3")
case_cocher1.pack()
case_cocher2.pack()
case_cocher3.pack()

# Création des cases à cocher "Radiobutton" dans la fenêtre :
case_cocher1 = Radiobutton(fenetre, text="choix 1")
case_cocher2 = Radiobutton(fenetre, text="choix 2")
case_cocher3 = Radiobutton(fenetre, text="choix 3")
case_cocher1.pack()
case_cocher2.pack()
case_cocher3.pack()

# Création d'une liste dans la fenêtre :
# la méthode insert() sert à inserer des valeur à la liste :
liste1 = Listbox(fenetre)
liste1.insert(1, "valeur 1")
liste1.insert(2, "valeur 2")
liste1.insert(3, "valeur 3")
liste1.insert(4, "valeur 4")
liste1.pack()

# Création d'un Spinbox dans la fenêtre :
liste1 = Spinbox(fenetre)
liste1.pack()

# Création d'une barre de menu dans la fenêtre :
menu1 = Menu(fenetre)
menu1.add_cascade(label="Fichier")
menu1.add_cascade(label="Options")
menu1.add_cascade(label="Aide")
# Configuration du menu dans la fenêtre
fenetre.config(menu=menu1)

# Affichage de la fenêtre créée :
fenetre.mainloop()