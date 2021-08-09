# coding:utf-8
"""
compteur = 0

while compteur < 5:
    print("Je suis une phrase")
    compteur += 1
print("Je sort de la boucle.")
"""

"""
Boucle  : while / for
Mots-clés : break (casse boucle) / continue (revien au debut)
"""

jeu_lance = True
print("")

while jeu_lance:
    # Fais des instructions
    choixMenu = input("> ")

    if choixMenu == "again":
        continue
    elif choixMenu == "quit":
        jeu_lance = False
    elif choixMenu == "hello":
        print("Bonjour : ")
    else:
        print("commande introuvable")

print("A bientot...")
