namespace Static_Members
{
    public class ConversorMoeda
    {
        public static float IOF =6f;
      

        public static float DolarReal (float Cambio, float Dolares)
        {
          float Total= Cambio * Dolares;
          Total = (Total + Total * IOF /100);
          return Total;
        }
    }
}