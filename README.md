Projet POO — Simulation de Zoo


Description

Ce projet consiste à développer une simulation de gestion de zoo en utilisant les principes de la programmation orientée objet (POO).

Le programme permet de gérer :

- le budget du zoo,
- les animaux,
- les habitats,
- l’alimentation,
- les achats et ventes liés au fonctionnement du zoo.

L’objectif est de modéliser un système réaliste en appliquant les concepts fondamentaux de la POO : classes, objets, encapsulation, relations entre objets.


 
Fonctionnalités
Zoo

Le zoo représente l’entité principale du programme.

Attributs :

- Budget du zoo
- Tarif adulte
- Tarif enfant

Responsabilités :

- Gérer les finances
- Centraliser les animaux et habitats
- Gérer les transactions (achat / vente)



Création d’animaux

Chaque animal possède des caractéristiques propres.

Attributs :

- Satiété de l’animal
- Type d’alimentation
- Quantité de nourriture (kg/jour)
- Espérance de vie
- Sexe
- Habitat associé

Objectifs :

- Simuler les besoins alimentaires
- Associer un animal à un habitat



Création d’habitats

Les habitats accueillent les animaux selon leur espèce.

Attributs :

- Nombre de résidents
- Espèce autorisée
- Probabilité de maladie

Objectifs :

- Regrouper les animaux compatibles
- Simuler les risques sanitaires



Aliment

Représente la nourriture utilisée pour nourrir les animaux.

Attributs :

-Type d’aliment
-Prix par kilogramme

Objectifs :

-Calculer le coût alimentaire quotidien



Achat

Gestion des achats effectués par le zoo.

Attributs :

-Type de bien acheté
-Coût

Exemples :

-Achat d’un animal
-Achat de nourriture
-Construction d’un habitat



Vente

Gestion des ventes réalisées par le zoo.

Attributs :

-Type de bien vendu
-Coût

Exemples :

-Vente d’un animal
-Vente d’équipements