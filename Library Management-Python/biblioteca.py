import json
from carte import Carte

class Biblioteca:
    def __init__(self):
        self.carti = []
        
    def adauga_carte(self, carte):
        self.carti.append(carte)
        
    def afiseaza_carti(self):
        if not self.carti:
            print("Nu exista cartea in bibliotecă")
        for carte in self.carti:
            print(carte)
            
    def cauta_dupa_titlu(self, titlu):
        rezultate = []
        for carte in self.carti:
            if titlu.lower() in carte.titlu.lower():
                rezultate.append(carte)
                
        # rezultatele pot fi obținute și cu o listă comprimată:
        # rezultate = [carte for carte in self.carti if titlu.lower() in carte.titlu.lower()]
        return rezultate
    
    def sterge_dupa_titlu(self, titlu):
        carti_ramase = []
        nr_sterse = 0

        for carte in self.carti:
            if titlu.lower() not in carte.titlu.lower():
                carti_ramase.append(carte)
            else:
                nr_sterse += 1

        self.carti = carti_ramase
        return nr_sterse
        
        # Cod alternativ (folosind list comprehensions)
        # initial = len(self.carti)
        # self.carti = [carte for carte in self.carti if titlu.lower() not in carte.titlu.lower()]
        # return initial - len(self.carti)

    def salveaza_in_fisier(self, nume_fisier):
        # Convertim fiecare obiect Carte într-un dicționar pentru a-l salva în fișier
        lista_carti = []
        for carte in self.carti:
            lista_carti.append(carte.__dict__)

        # Deschidem fișierul pentru scriere și salvăm datele în format JSON
        with open(nume_fisier, 'w', encoding='utf-8') as f:
            json.dump(lista_carti, f, indent=4, ensure_ascii=False)
    
    def incarca_din_fisier(self, nume_fisier):
        # Încarcă cărțile din fișierul JSON
        try:
            with open(nume_fisier, 'r', encoding='utf-8') as f:
                date_carti = json.load(f)

                # Reconstruim obiectele Carte din dicționare
                self.carti = []
                for date in date_carti:
                    carte = Carte(date["titlu"], date["autor"], date["an"], date["gen"])
                    self.carti.append(carte)

        except FileNotFoundError:
            # Dacă fișierul nu există, începem cu o listă goală
            self.carti = []
