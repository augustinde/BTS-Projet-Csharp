# Récupérer le projet pour la premiere fois

 * git clone https://github.com/augustinde/LAB7.git

# Récupérer le projet mis à jour

 * git pull

# Envoie des modifications sur GIT

 * git add .
 * git commit -m "Message"
 * git push -u origin <branch>


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

# TO DO

* Files to comment
  * <del>Component</del>
    * <del>BaseDonnee</del>
    * <del>CheckForm</del>
    * <del>CreatePDF</del>
  * <del>Entity</del>
    * <del>Client</del>
    * <del>Employe</del>
    * <del>FicheAsPieceDet</del>
    * <del>FicheDeReparation</del>
    * <del>InfoLabSept</del>
    * <del>MainOeuvre</del>
    * <del>Marque</del>
    * <del>Modele</del>
    * <del>PieceDetachee</del>
    * <del>Statut</del>
    * <del>Tva</del>
  * Form
    * <del>FmAccueil</del>
    * FmAddPiece
    * FmAdmin
    * FmConnexion
    * FmCreateClient
    * FmCreateFicheRepa
    * FmCreateMarque
    * FmCreateModele
    * FmFicheEnd
    * FmGestionEmploye
    * FmInfoLab
    * FmListeClient
    * FmListeMarque
    * FmListeModele
    * FmMainOeuvre
    * FmPieceDetaFmPreviewFiche
    * FmTechos
    * FmTva
    * FmUpdateClient
    * FmUpdateMarque
    * FmUpdateModele
  * <del>Manager</del>
    * <del>ClientManager</del>
    * <del>EmployeManager</del>
    * <del>FicheAsPieceDetManager</del>
    * <del>FicheManager</del>
    * <del>InfoManager</del>
    * <del>MainOeuvreManager</del>
    * <del>MarqueManager</del>
    * <del>ModeleManager</del>
    * <del>PieceDetacheeManager</del>
    * <del>TvaManager</del>
