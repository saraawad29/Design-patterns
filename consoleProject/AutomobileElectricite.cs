using System;

public class AutomobileElectricite : Automobile
{
  public AutomobileElectricite(string modele, string
    couleur, int puissance, double espace) : base(modele,
    couleur, puissance, espace){}

  public override void afficheCaracteristiques()
  {
    Console.WriteLine(
      "Automobile electrique de modele : " + modele + 
      " de couleur : " + couleur + " de puissance : " +
      puissance + " d'espace : " + espace);
  }
}
