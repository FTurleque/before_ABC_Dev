# coding:utf-8

class Humain:
    """
    Class des etre humains
    """

    humains_crees = 0

    def __init__(self, c_prenom, c_age):
        print("Création d'un humain....")
        self.prenom = c_prenom
        self.age = c_age
        Humain.humains_crees += 1


print("Lancement du programme...")

h1 = Humain("Jojo", 34)
print("Prénom de h1 : {}".format(h1.prenom))
print("Age de h1 : {}".format(h1.age))

h2 = Humain("Albert", 17)
print("Prénom de h1 : {}".format(h2.prenom))
print("Age de h1 : {}".format(h2.age))

print("Humains existants : {}".format(Humain.humains_crees))