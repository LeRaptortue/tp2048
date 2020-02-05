using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Les informations générales relatives à un assembly dépendent de
// l'ensemble d'attributs suivant. Changez les valeurs de ces attributs pour modifier les informations
// associées à un assembly.
[assembly: AssemblyTitle("2048")]
[assembly: AssemblyDescription("Le but du jeu est de faire glisser des tuiles sur la grille, pour combiner les tuiles de mêmes valeurs et créer ainsi une tuile portant le nombre 2048." +
    "           " +
    "Le joueur peut toutefois continuer à jouer après cet objectif atteint pour faire le meilleur score possible.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Ce jeu à été réalisé en APAII 27")]
[assembly: AssemblyProduct("2048")]
[assembly: AssemblyCopyright("CFA - CFP La Joliverie | 2019 - 2020")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// L'affectation de la valeur false à ComVisible rend les types invisibles dans cet assembly
// aux composants COM. Si vous devez accéder à un type dans cet assembly à partir de
// COM, affectez la valeur true à l'attribut ComVisible sur ce type.
[assembly: ComVisible(false)]

// Le GUID suivant est pour l'ID de la typelib si ce projet est exposé à COM
[assembly: Guid("4383fea2-b25c-4b50-8911-8e52c79a8f5c")]

// Les informations de version pour un assembly se composent des quatre valeurs suivantes :
//
//      Version principale
//      Version secondaire
//      Numéro de build
//      Révision
//
// Vous pouvez spécifier toutes les valeurs ou indiquer les numéros de build et de révision par défaut
// en utilisant '*', comme indiqué ci-dessous :
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

[assembly: log4net.Config.XmlConfigurator(Watch =true)]
