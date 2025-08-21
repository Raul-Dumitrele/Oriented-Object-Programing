from biblioteca import Biblioteca
from carte import Carte

def afiseaza_meniu():
    print("\n--- Meniu Biblioteca ---")
    print("1. Adaugă carte")
    print("2. Afișează toate cărțile")
    print("3. Caută carte după titlu")
    print("4. Șterge carte după titlu")
    print("5. Salvează în fișier")
    print("6. Încarcă din fișier")
    print("0. Ieșire")
    
    
biblioteca = Biblioteca()

while True:
    afiseaza_meniu()
    alegere = input("Alege o optiune:")

    if alegere == "1":
        titlu = input("Titlul cărții: ")
        autor = input("Autorul: ")
        an = input("Anul publicării: ")
        gen = input("Genul: ")
        carte = Carte(titlu, autor, an, gen)
        biblioteca.adauga_carte(carte)
        print("✅ Cartea a fost adăugată.")
    
    elif alegere == "2":
        print("\n📚 Lista cărților din bibliotecă:")
        biblioteca.afiseaza_carti()
        
    elif alegere == "3":
        prtitlu = input("Introdu titlul (sau o parte din el): ")
        rezultate = biblioteca.cauta_dupa_titlu(prtitlu)
        if rezultate:
            print("📖 Cărți găsite:")
            for carte in rezultate:
                print(carte)
        else:
            print("❌ Nu am găsit nicio carte cu acel titlu.")
            
    elif alegere == "4":
        titlu = input("Titlul cărții de șters: ")
        sterse = biblioteca.sterge_dupa_titlu(titlu)
        print(f"🗑️ Cărți șterse: {sterse}")

    elif alegere == "5":
        biblioteca.salveaza_in_fisier("carti.json")
        print("💾 Cărțile au fost salvate în fișier.")

    elif alegere == "6":
        biblioteca.incarca_din_fisier("carti.json")
        print("📂 Cărțile au fost încărcate din fișier.")

    elif alegere == "0":
        print("👋 La revedere!")
        break

    else:
        print("⚠️ Opțiune invalidă. Te rog încearcă din nou.")
