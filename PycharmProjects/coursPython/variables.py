# coding:utf-8

"""
Types standards         : entier numerique (int)
                          nombre flottant (float)
                          chaine de charactere (str)
                          booleen (bool)

Fonction vues           : print()       -> afficher a l'ecran
                          input()       -> lire le clavier
                          type()        -> retourne le type d'une donnee, var ect ...
                          int(), float(), str(), bool() -> "caster" une donnee, la convertir.
                          str.format()  -> formater une chaine
"""

# agePersonne = 14
# agePersonne2 = "14"
# prixHT = 120.14
# continuer_partie = True

# print(type(agePersonne))
# print(type(agePersonne2))

# texte = "L'age de la personne est {} et le prix est de {}$."
# print(texte.format(agePersonne, prixHT))

nomJoueur = input("Choisissez un nom : ")

print("Bienvenue,", nomJoueur)
