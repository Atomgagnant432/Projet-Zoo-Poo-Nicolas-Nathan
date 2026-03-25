# Simulation de Zoo — Projet POO

> Simulation de gestion de zoo développée en c#, appliquant les principes fondamentaux de la programmation orientée objet.

---

## Description

Ce projet modélise un système de gestion de zoo réaliste. Il permet de gérer le budget, les animaux, leurs habitats, leur alimentation, ainsi que les achats et ventes liés au fonctionnement du zoo.

Concepts POO appliqués : classes & objets, encapsulation, relations entre objets.

---
## Arborescence
```
├── cmd/
│   └── Program.cs
├── internal/
│   ├── Animals.cs
│   ├── enlocure.cs
│   ├── Event.cs
│   ├── menu.cs
│   ├── month.Cs
│   ├── Object.cs
│   ├── Storage.cs
│   └── Zoo.cs
├── .gitignore
├── Projet-Zoo-Poo-Nicolas-Nathan.csproj
├── Projet-Zoo-Poo-Nicolas-Nathan.sln
└── README.md

```


---
## Fonctionnalités

### Zoo

Entité principale du programme.

**Attributs :** `money`, `childPrice`, `adultPrice`, `animals`, `enclosures`, `storage`

**Responsabilités :** gérer le budget du zoo, coordonner les tours de jeu, gérer les animaux et les enclos, appliquer les revenus (visites, subventions) et déclencher les événements aléatoires.

---

### Animal

Chaque animal possède des caractéristiques et des besoins propres.

**Attributs :** `age`, `lifeTime`, `actualHunger`, `maxHunger`, `foodType`, `dailyFoodNeed`, `buyPrice`, `sellPrice`, `sexe`, `homeID`, `alive`

**Objectifs :** gérer la vie de l’animal (vieillissement, faim, mort), adapter son prix selon l’âge et gérer son alimentation.

---

### Habitat

Les habitats accueillent les animaux selon leur espèce.

**Attributs :** `idEnclosure`, `enclosureType`, `animalType`, `maxResident`, `residents`, `purchasePrice`, `sellingPrice`, `probaSick`

**Objectifs :** héberger les animaux compatibles, limiter le nombre de résidents, gérer le surpeuplement et ses conséquences.

---

### Aliment

Représente la nourriture utilisée pour nourrir les animaux.

**Attributs :** `label`, `quantity`, `cost`

**Objectif :** permettre l’achat de nourriture et alimenter le stockage du zoo (viande ou graines).

---

### Achat

Gestion des acquisitions effectuées par le zoo.

**Attributs :** `cost`, `quantity`

**Objectifs :** vérifier les fonds disponibles, débiter le joueur et ajouter l’élément acheté (animal, nourriture ou enclos).

---

### Vente

Gestion des cessions réalisées par le zoo.

**Attributs :** `sellPrice`

**Objectifs :** permettre au joueur de vendre des animaux ou des enclos et récupérer de l’argent.

---

## Evenement

Création d’événements aléatoires impactant la partie.

**Attributs :** `type`, `proba`

**Objectifs :** ajouter de l’imprévu dans le jeu en appliquant des conséquences (perte de ressources, destruction, vol, etc.).
---

## Téléchargement et Lancement du projet 

- git clone https://github.com/Atomgagnant432/Projet-Zoo-Poo-Nicolas-Nathan.git 

- dotnet run 

- Navigué ensuite grace au chiffre indiqué dans le terminal 