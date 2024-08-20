public class program
{
    public static void Main(string[] args)
    {

        List<string> invitess = new List<string>();
        invitess.Add("Bülent Ersoy");
        invitess.Add("Ajda Pekkan");
        invitess.Add("Ebru Gündeş");
        invitess.Add("\"Hadise");
        invitess.Add("Hande Yenery");
        invitess.Add("Tarkan");
        invitess.Add("Funda Arar");
        invitess.Add("Demet Akalın");

        foreach (string i in invitess)
        {
            Console.WriteLine(i);
        }

    }
}
