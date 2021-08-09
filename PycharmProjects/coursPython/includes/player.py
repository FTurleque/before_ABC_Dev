# coding:utf-8

def parler(personnage, message):
    print("{} : {}".format(personnage, message))


def au_revoir():
    print("Au revoir :) !")


# Pour tester le module player

if __name__ == "__main__":
    print("Phase de test")
    
    parler("jason", "Bonjour tout le monde")
    au_revoir()
