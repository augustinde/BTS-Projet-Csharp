# Projet C# de seconde année de BTS SIO

# Installer les packages nécessaires
  * Projet > Gérer les packages Nuget > Parcourir puis installé
    * iTextSharp
    * MySql.Data
    * MySqlConnector

# Configuration nécessaire
  * Ajouter la base de donnée sur phpmyadmin
  * Si le port de MySql n'est pas 3306 le changer dans les fichiers suivants en 3308
    * Component/BaseDonnee.cs
    * Fom/FmConnexion.cs (effectué un clique droit sur l'interface puis sur "Afficher le code")
    * Manager/InfoManager.cs
