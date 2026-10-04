# CalculateurAge

Application mobile **.NET MAUI** qui calcule l'âge d'une personne à partir de son nom et de sa date de naissance.

TP1 : *Calculateur d'âge, Routing et MVVM* (Atelier de développement mobile, Activité 6).

## Objectif

Construire l'application d'abord en **code-behind**, ajouter une seconde page avec navigation (**Shell**), puis la réécrire en **MVVM** et l'enrichir de fonctionnalités.

## Fonctionnalités

- Saisie du nom et de la date de naissance
- Calcul de l'âge (en tenant compte de l'anniversaire pas encore passé cette année)
- Bouton **Calculer** grisé tant que le nom est vide
- Message **Majeur / Mineur**
- Bouton **Effacer** qui remet tous les champs à zéro
- Refus d'une date de naissance dans le futur, avec un message d'erreur

## Historique du projet

| Phase | Contenu |
|---|---|
| Phase A | Version code-behind (commit « Ajoutez des fichiers projet. ») |
| Phase B | Seconde page `ResultatPage` et navigation avec `Shell` et `GoToAsync` |
| Phase C | Réécriture en MVVM (`BaseViewModel`, `RelayCommand`, `CalculateurViewModel`) |
| Activité 6 | Fonctionnalité 1 : message Majeur/Mineur |
| Activité 6 | Fonctionnalité 2 : commande Effacer |
| Activité 6 | Fonctionnalité 3 : refus d'une date future |

## Architecture MVVM

```
CalculateurAge/
  Views/
    ResultatPage.xaml
    ResultatPage.xaml.cs
  ViewModels/
    BaseViewModel.cs
    RelayCommand.cs
    CalculateurViewModel.cs
  MainPage.xaml
  MainPage.xaml.cs
  AppShell.xaml
  AppShell.xaml.cs
  MauiProgram.cs
```

- **Vue** (`MainPage.xaml`) : uniquement l'affichage, avec des `{Binding}`.
- **ViewModel** (`CalculateurViewModel`) : l'état de l'écran et les actions, sans aucun contrôle d'interface.
- **Code-behind** (`MainPage.xaml.cs`) : une seule ligne utile, `BindingContext = new CalculateurViewModel();`.

## Lancer le projet

1. Ouvrir `CalculateurAge.slnx` dans Visual Studio (charge de travail **Développement .NET Multi-platform App UI**).
2. Choisir la cible **Windows Machine** ou un émulateur Android.
3. Lancer avec ▶.

## Technologies

- .NET MAUI
- C# et XAML
- Pattern MVVM (`INotifyPropertyChanged`, `ICommand`)
- Git et GitHub

## Auteur

Projet réalisé individuellement dans le cadre du cours de développement mobile.
