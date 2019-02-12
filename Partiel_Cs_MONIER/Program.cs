using System;
using System.IO;

namespace Partiel_Cs_MONIER
{
    class Program
    {
        private static void addLog()
        {
            //Instanciation d'un objet Log
            Log log     = new Log();
            log.Message = "Blabla";
            //Utilisation du DateTime.Now pour récupérer la date système
            log.Date    = DateTime.Now;
            log.Niveau  = "information";


            Console.Write("Début de la sérialisation...");

            var serializer = JsonSerializer.Create();
            using (StreamWriter sw = new StreamWriter(@"d:\test.json"))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, log);
                }
            }
        }


        private static void saveFile()
        {
           
            var json = JsonConvert.SerializeObject(data);
            File.WriteAllText("test.xml", json);

            //Sérialisation du fichier XML
            var serialiser = new XmlSerializer(typeof(Log));
            using (var sw = new StreamWriter("test.xml"))
            {
                serialiser.Deserialize(sw, log);
            }
        }


        private static void showFiles()
        {
            if (Date.contains(query, StringComparison)
            {

            }
        }


        static void Main(string[] args)
        {
            var exit = false;

            while (!exit)
            {
                //MENU
                Console.WriteLine("1: Ajouter log");
                Console.WriteLine("2: Sauvegarder fichier");
                Console.WriteLine("3: Afficher les logs du fichier XML");
                Console.WriteLine("q: Quitter");

                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        addLog();
                        break;
                    case "2":
                        saveFile();
                        break;
                    case "3":
                        showFiles();
                        break;
                    case "q":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("invalid input");
                        break;
                }
            }
        }
    }
}
