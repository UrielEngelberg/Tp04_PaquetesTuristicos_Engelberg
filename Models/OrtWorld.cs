public class OrtWorld{
   public static List<string> ListaDestinos {get; private set;} = new List<string>() {"Madrid","Nottingham","Londres","Buenos Aires","Sydney","Roma","Miami","Nueva York","Tokyo","AbuDhabi"};
   public static List<string> ListaHoteles {get; private set;} = new List<string>(){"Palace","Bentick","Russell","Wyndham","49911_exterior_dusk_2.avif","Anatara","Colony","Time squeare","640px-Imperial_Hotel_TOKYO_2007.jpg","emirtes palace" };
   public static List<string> ListaAereos {get; private set;} = new List<string>(){"Iberia","british","jetBlue","Aerolineas","Qantas","Aitalia","American","United","japan airlaines","saudia" };
   public static List<string> ListaExcursiones {get; private set;} = new List<string>(){"Toledo","Kayak","Sandemans","Casa rosada","Excursion matutina","Imperial","hidrodeslizador","tour en barco","recorrido en bici","recorrido por la ciudad" };
   public static Dictionary<string,Paquetes> Paquetes {get; private set;} 

    public static bool IngresarPaquete(string destinoSeleccionado, Paquetes paquete){
        if (!(Paquetes.ContainsKey(destinoSeleccionado)))
        {
            return false;    
        }
        else
        {
            Paquetes.Add(destinoSeleccionado,paquete);
            return true;
        }
    }

   // ViewBag.Paquetes; 
}
