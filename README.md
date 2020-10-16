# BookTP

Premier TP du module C# avancé.  

## Prérequis

* [Installer PostgreSQL](https://www.postgresql.org/download/)
* [Installer Postman](https://www.postman.com/downloads/)

## Marche à suivre  

* A la fin de l'installation de Pgsql, créer un base de données vide "BookTP" et set tous les mdp à "neobank". (Lancer PgAdmin dans le menu démarrer si sur windows)
* Ouvrir la solution, Taper "Add-Migration Init" puis "Update-Database" dans le package manager console avec le projet BookTP.DatabaseAccess par défaut.
* Lancer la solution sur le projet BookTP

## Appels

* https://localhost:44385/book - Tous les books en bdd  
* https://localhost:44385/shelve - Toutes les shelves en bdd
* https://localhost:44385/book/query?title=Lord&author=machin&howManyToSave=5 - Rechercher un livre contenant "Lord" dans le titre écrit par l'auteur "Machin", et save les 5 premiers en bdd.
* https://localhost:44385/shelve?name=helveS - POST - Créer une shelve nomée helveS
* https://localhost:44385/book/queryshelve?title=Lord&shelveId=5867b799-16c9-427b-96a9-59cd8b68685f&author=machin - Rechercher un livre contenant "Lord" dans le titre écrit par l'auteur "Machin", tout save en bdd et les ajouter dans la shelve avec l'id fourni.
