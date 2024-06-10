public class Paquetes{
  public  string Hotel {get; private set;}
  public string Aereo {get; private set;}
  public string Excursion {get; private set;}

  public Paquetes(string hotel, string aereo, string excursion){
    Hotel = hotel;
    Aereo = aereo;
    Excursion = excursion;
  }
}