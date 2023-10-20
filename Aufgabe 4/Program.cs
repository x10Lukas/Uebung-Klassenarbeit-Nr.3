double kreisRadius = 5;
double rechteckLaenge = 4;
double rechteckBreite = 6;
double dreieckBasis = 4;
double dreieckHoehe = 6;
bool istDreieck = true;

double kreisFlaeche = Math.PI * kreisRadius * kreisRadius;
double rechteckFlaeche = rechteckLaenge * rechteckBreite;
double dreieckFlaeche = istDreieck ? 0.5 * dreieckBasis * dreieckHoehe : 0;

Console.WriteLine("Fläche des Kreises: " + kreisFlaeche);
Console.WriteLine("Fläche des Rechtecks: " + rechteckFlaeche);
Console.WriteLine("Fläche des Dreiecks: " + dreieckFlaeche);