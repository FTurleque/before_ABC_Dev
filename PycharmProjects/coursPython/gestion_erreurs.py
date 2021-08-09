# coding:utf-8

"""
Gérer les exceptions : try/except (+ else, finally)
"""

ageUtilisateur = input("Quel age as-tu ? ")

try:
    ageUtilisateur = int(ageUtilisateur)
except:
    print("L'age indiqué est incorrect !")
else:
    print("Tu as", ageUtilisateur, "ans")
finally:
    print("Fin de programme...")
