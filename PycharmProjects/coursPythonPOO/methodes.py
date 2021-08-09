# coding:utf-8

"""
Méthodes "d'instance": fonction sur une instance (objet)
Méthodes de classe   : fonction sur une classe
Méthodes statique    : fonction indépendante mais "lié" à une classe
"""


class Humain:
    # classe qui definit un humain

    lieu_habitation = "Terre"

    def __init__(self, nom, age):
        self.nom = nom
        self.age = age

    def parler(self, message):  # self  = méthode standard
        print("{} a dit : {}".format(self.nom, message))

    def changer_planete(cls, nouvelle_planete):  # cls = méthode de classe
        Humain.lieu_habitation = nouvelle_planete

    changer_planete = classmethod(changer_planete)

    def definition():
        print("L'humain est classé comme étant le plus haut être-vivant de la chaîne alimentaire ...")

    definition = staticmethod(definition)


# Programme pricipal
h1 = Humain("Jason", 26)

# h1.parler("Bonjour à tous ! :)")
# h1.parler("Comment allez-vous ?")

print("Planète actuelle : {}".format(Humain.lieu_habitation))

Humain.changer_planete("Mars")

print("Planète actuelle : {}".format(Humain.lieu_habitation))

Humain.definition()
