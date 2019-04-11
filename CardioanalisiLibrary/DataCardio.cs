using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioAnalisiLibrary
{
    public class DataCardio
    {
        //calcolo dei battiti efficaci minimi per un allentamneto efficace
        public static double CalcoloBattitiEfficaciMinimi(int Eta)
        {
            string Messaggio = ControlloInserimenti(Eta);

            int FrequenzaMassima = CalcoloFrequenzaMax(Eta);
            
            double BattitiEfficaciMin = (FrequenzaMassima * 70) / 100; //battiti efficaci min in bpm
            
            return BattitiEfficaciMin;
        }
        //calcolo dei battiti efficaci massimi per un allentamneto efficace
        public static double CalcoloBattitiEfficaciMassimi(int Eta)
        {
            string Messaggio = ControlloInserimenti(Eta);

            int FrequenzaMassima = CalcoloFrequenzaMax(Eta);
            
            double BattitiEfficaciMax = (FrequenzaMassima * 90) / 100; //battiti efficaci max in bpm
            
            return BattitiEfficaciMax;
        }
        //calcolo della frequenza massima
        public static int CalcoloFrequenzaMax(int EtaSoggetto)
        {
            string Messaggio = ControlloInserimenti(EtaSoggetto);

            int FrequenzaMax;

            FrequenzaMax = 220 - EtaSoggetto; //frequenza cardiaca massima consigliata
            
            return FrequenzaMax;
        }
// controllo sui dati interi
        public static string ControlloInserimenti(int VariabileA)
        {
            string Messaggio = "";

            int variabile;

            try
            {
                variabile = Convert.ToInt32(VariabileA);

                if (variabile <= 0)
                {
                    Messaggio = "Errore";
                }
            }
            catch (Exception)
            {
                Messaggio = "Si è verificato un'errore nella conversione del dato inserito";
            }
            return Messaggio;
        }
        // controllo sui dati double uno
        public static string ControlloInserimenti2(double Valore1, double Valore2, double Valore3, double Valore4)
        {
            string Messaggio = "";

            double variabile1;
            double variabile2;
            double variabile3;
            double variabile4;

            try
            {
                variabile1 = Convert.ToDouble(Valore1);
                variabile2 = Convert.ToDouble(Valore2);
                variabile3 = Convert.ToDouble(Valore3);
                variabile4 = Convert.ToDouble(Valore4);

                if (variabile1 <= 0 || variabile2 <= 0 || variabile3 <= 0 || variabile4 <= 0)

                {
                    Messaggio = "Errore";
                }
            }

            catch (Exception)
            {
                Messaggio = "Si è verificato un'errore nella conversione del dato inserito";
            }
            return Messaggio;
        }


        //controllo sui dati double due
        public static string ControlloInserimenti3(double Valore1, double Valore2)
        {
            string Messaggio = "";

            double variabile1;
            double variabile2;

            try
            {
                variabile1 = Convert.ToDouble(Valore1);
                variabile2 = Convert.ToDouble(Valore2);

                if (variabile1 <= 0 || variabile2 <= 0)

                {
                    Messaggio = "Errore";

                }

            }

            catch (Exception)
            {
                Messaggio = "Si è verificato un'errore nella conversione del dato inserito";

            }

            return Messaggio;
        }
    }
}