
class Carte:
    def __init__(self, titlu, autor, an, gen):
        self.titlu = titlu
        self.autor = autor
        self.an = an
        self.gen = gen

    def __str__(self):
        return f"{self.titlu} de {self.autor} ({self.an}) - Gen: {self.gen}"
