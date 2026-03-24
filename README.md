# Simulation de Zoo — Projet POO

> Simulation de gestion de zoo développée en c#, appliquant les principes fondamentaux de la programmation orientée objet.

---

## Description

Ce projet modélise un système de gestion de zoo réaliste. Il permet de gérer le budget, les animaux, leurs habitats, leur alimentation, ainsi que les achats et ventes liés au fonctionnement du zoo.

Concepts POO appliqués : classes & objets, encapsulation, relations entre objets.

---
## Arborescence
```
a

```


---
## Fonctionnalités

### Zoo

Entité principale du programme.

**Attributs :** `budget`, `tarifAdulte`, `tarifEnfant`

**Responsabilités :** gérer les finances, centraliser les animaux et habitats, coordonner les transactions.

---

### Animal

Chaque animal possède des caractéristiques et des besoins propres.

**Attributs :** `satiete`, `typeAlimentation`, `quantiteNourriture` , `esperanceVie`, `sexe`, `habitat`

**Objectifs :** simuler les besoins alimentaires et associer chaque animal à son habitat.

---

### Habitat

Les habitats accueillent les animaux selon leur espèce.

**Attributs :** `nbResidents`, `especeAutorisee`, `probabiliteMaladie`

**Objectifs :** regrouper les animaux compatibles et simuler les risques sanitaires.

---

### Aliment

Représente la nourriture utilisée pour nourrir les animaux.

**Attributs :** `type`, `prixKg`

**Objectif :** calculer le coût alimentaire quotidien du zoo.

---

### Achat

Gestion des acquisitions effectuées par le zoo.

**Attributs :** `typeBien`, `cout`

**Exemples :** achat d'un animal, achat de nourriture, construction d'un habitat.

---

### Vente

Gestion des cessions réalisées par le zoo.

**Attributs :** `typeBien`, `cout`

**Exemples :** vente d'un animal, vente d'habitat.

---

## Evenement

création d'evenement que le joueur ne peut pas gérer, pour ne pas avoir une partie trop répétitive.

**Attributs :**`typeEvent`,`proba`, 

**Exemples :** Nuisibles, Incendie, Vol, Viande avariée

---

## Téléchargement et Lancement du projet 

- git clone https://github.com/Atomgagnant432/Projet-Zoo-Poo-Nicolas-Nathan.git 

- dotnet run 

- Navigué ensuite grace au chiffre indiqué dans le terminal 