using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CustomEnumerations{}

public enum DurationType
{
    NONE,
    ALLANDO,
}

public enum EffectType
{
    NONE,
    OSMAGIA,
    GYUJTOBOL_NEM_KERULHET_SEMMIBE,
    EXTRA_VP_REAGALNI
}

public enum Place
{
    NONE,
    SAJAT_PAKLI,
    SAJAT_KEZ,
    SAJAT_TARTALEK,
    SAJAT_ORPOSZT,
    SAJAT_KOVETO,
    SAJAT_SZABALYLAP,
    SAJAT_GYUJTO,
    SAJAT_SEMMI,
    SAJAT_BUBAJ,
    SAJAT_TARGY,
    ELLENFEL_PAKLI,
    ELLENFEL_KEZ,
    ELLENFEL_TARTALEK,
    ELLENFEL_ORPOSZT,
    ELLENFEL_KOVETO,
    ELLENFEL_SZABALYLAP,
    ELLENFEL_GYUJTO,
    ELLENFEL_SEMMI,
    ELLENFEL_BUBAJ,
    ELLENFEL_TARGY
}

public enum Target
{
    NONE,
    JATEKOS,
    ELLENFEL,
    SAJAT_PAKLI,
    ELLENFEL_PAKLI,
    SAJAT_KEZ,
    ELLENFEL_KEZ,
    SAJAT_TARTALEK,
    ELLENFEL_TARTALEK,
    SAJAT_ORPOSZT,
    ELLENFEL_ORPOSZT,
    SAJAT_GYUJTO,
    ELLENFEL_GYUJTO,
    SAJAT_SEMMI,
    ELLENFEL_SEMMI,
    SAJAT_KOVETO,
    ELLENFEL_KOVETO,
    SAJAT_SZABALYLAP,
    ELLENFEL_SZABALYLAP,
    SAJAT_BUBAJ,
    ELLENFEL_BUBAJ,
    SAJAT_TARGY,
    ELLENFEL_TARGY,
    SAJAT_EPITMENY,
    ELLENFEL_EPITMENY,
    SAJAT_HAJO,
    ELLENFEL_HAJO,
    SAJAT_LENY,
    ELLENFEL_LENY,
    SAJAT_SZORNY,
    ELLENFEL_SZORNY,
    SAJAT_TOKEN,
    ELLENFEL_TOKEN,
    SAJAT_KALANDOZO,
    ELLENFEL_KALANDOZO,
    SAJAT_GALETKI,
    ELLENFEL_GALETKI,
    SAJAT_MAGA
}

public enum Player
{
    NONE,
    JATEKOS,
    ELLENFEL
}

public enum Phase
{
    NONE,
    SAJAT_ELOKESZITO_EGY,
    SAJAT_ELOKESZITO_KETTO,
    SAJAT_HUZAS_EGY,
    SAJAT_HUZAS_KETTO,
    SAJAT_FO_EGY_EGY,
    SAJAT_FO_EGY_KETTO,
    SAJAT_CSERE_EGY,
    SAJAT_CSERE_KETTO,
    SAJAT_CSERE_UTANI_AZONNALI_EGY,
    SAJAT_CSERE_UTANI_AZONNALI_KETTO,
    SAJAT_HARC_EGY,
    SAJAT_HARC_KETTO,
    SAJAT_FO_KETTO_EGY,
    SAJAT_FO_KETTO_KETTO,
    SAJAT_GYOGYULAS_EGY,
    SAJAT_GYOGYULAS_KETTO,
    ELLENFEL_ELOKESZITO_EGY,
    ELLENFEL_ELOKESZITO_KETTO,
    ELLENFEL_HUZAS_EGY,
    ELLENFEL_HUZAS_KETTO,
    ELLENFEL_FO_EGY_EGY,
    ELLENFEL_FO_EGY_KETTO,
    ELLENFEL_CSERE_EGY,
    ELLENFEL_CSERE_KETTO,
    ELLENFEL_CSERE_UTANI_AZONNALI_EGY,
    ELLENFEL_CSERE_UTANI_AZONNALI_KETTO,
    ELLENFEL_HARC_EGY,
    ELLENFEL_HARC_KETTO,
    ELLENFEL_FO_KETTO_EGY,
    ELLENFEL_FO_KETTO_KETTO,
    ELLENFEL_GYOGYULAS_EGY,
    ELLENFEL_GYOGYULAS_KETTO
}

public enum ActionType
{
    NONE,
    PARENT,
    LAPKIJATSZAS,
    BLOKKOLAS,
    VP_SZERZES,
    LAP_HUZAS,
    LAP_VISSZAHUZAS_GYUJTOBOL,
    KIJATSZOTT_LAP_SEMMIBE_RAKASA,
    GYUJTOBOL_NEM_KERULHET_SEMMIBE,
    KEPESSEG_VALASZTAS_KIJATSZAS_ELOTT,
    VIZIO,
    REAGALAS
}

public enum Rarity
{
    NONE,
    GYAKORI,
    NEM_GYAKORI,
    RITKA,
    ULTRA_RITKA
}

public enum SummonCostType
{
    NONE,
    VP,
    SZK,
    EPITO,
    ALDOZAS,
    SEMMIZES,
    ZANSZILANK
}

public enum Icons
{
    NONE,
    ELETKIOLTO,
    ELOHOLT,
    EREKLYE,
    EROD,
    ETNIKUM,
    FA,
    FEM,
    HALO,
    HEGYMELYI,
    HIDEG,
    HORGONY,
    IDEZES,
    ISTENI,
    KEGY,
    KF,
    KINCS,
    KOD,
    LEGENDAS,
    MENTALIS,
    ORZO,
    OSMAGIA,
    REAKCIO_DRAGITAS,
    REPUL,
    REZISZTENCIA,
    SZORNYKOMPONENS,
    TUZ,
    VEDEKEZES,
    VILLAM,
    MAGIKUS_TAMADAS,
    MAGIKUS_VEDEKEZES,
    NORMAL_TAMADAS,
    NORMAL_VEDEKEZES,
    VP,
    SZK,
    EPITO,
    ALDOZAS,
    SEMMIZES,
    ZANSZILANK
}


public enum Group
{
    NONE,
    BUFA,
    BARD,
    CHARADIN,
    MUTANS,
    DORNODON,
    TOLVAJ,
    ELENIOS,
    PSZIONICISTA,
    FAIRLIGHT,
    MAGUS,
    LEAH,
    HALHATATLAN,
    RAIA,
    KATONA,
    SHERAN,
    TUDOS,
    THARR,
    TISZTOGATO,
    RHATT,
    SZINTELEN,
    KOVETO_SZABALYLAP
}

public enum MainType
{
    NONE,
    ALTALANOS,
    AVATAR,
    AZONNALI,
    BUBAJ,
    BUBAJ_BUBAJRA,
    BUBAJ_EPITMENYRE,
    BUBAJ_KALANDOZORA,
    BUBAJ_LAPRA,
    BUBAJ_LENYRE,
    BUBAJ_TARGYRA,
    CEH,
    EGYEB,
    EPITMENY,
    GALETKI,
    HELYSZIN,
    KALANDOZO,
    KOVETO,
    OSLICH,
    SZABALYLAP,
    SZAKERTELEM,
    SZINTLEPES,
    SZORNY,
    TARGY,
    TESTRESZ,
    TORZSZULOTT

}

public enum SubType
{
    NONE,
    ALAKVALTO,
    ANGYAL,
    ARNYMANO,
    BANYA,
    BAZALTELEMENTAL,
    BETEGSEG,
    BURASTYA,
    CHARADIN_FATTYA,
    CSAPDA,
    CSONTVAZ,
    DINO,
    DRUIDA,
    DZSINN,
    EBEN_IJASZ,
    EJFATTY,
    EKSZER,
    ELEKTROMOS,
    ELEMENTAL,
    ELF,
    EMBER,
    EPIKUS,
    FALU,
    FEGYVER,
    FEREG,
    FOKUSZKRISTALY,
    FONIX,
    GANUID,
    GNOM,
    GOBLIN,
    GOLEM,
    GRIFF,
    GROK_KEPZODMENY,
    HADVEZER,
    HAJO,
    HANGSZER,
    HATAS,
    HELYSZIN,
    HIDEG,
    HORDAPARANCSNOK,
    IJASZ,
    JEG,
    KALOZ,
    KAOSZSZELLEM,
    KIGYO,
    KISERTET,
    KOBUDERA,
    KOZOS_TUDAT,
    KRABBER,
    LEGELEMENTAL,
    LOVAS,
    MANO,
    MINOTAURUSZ,
    MOA,
    MORF,
    MOTYOGO,
    MUTANS,
    NEKROMANTA,
    NERUB,
    OLTAR,
    ORGLING,
    ORIAS,
    ORK,
    OSHANGYA,
    PAJZS,
    PANCEL,
    PEGAZUS,
    POK,
    POLIP,
    POLITIKA,
    PRAGLONC,
    PROFETA,
    PULZALO,
    QUWARG,
    QUWARG_BOLY,
    RAK,
    REAKCIO,
    SARKANY,
    SAV,
    SISAK,
    SKORPIO,
    SZENTELY,
    SZILMILL,
    SZINGULARIS,
    SZINGULARITAS,
    SZINTLEPES,
    SZINARUSZ,
    SZIREN,
    SZKRITTER,
    TEKNOS,
    TEMPLOM,
    TERMIK,
    THARGODAN,
    TOJAS,
    TORONY,
    TORPE,
    TRIKLEM_DRAKOLDER,
    TROGDOLITA,
    TROLL,
    TUZELEMENTAL,
    VAMPIR,
    VARKAUDAR,
    VEGZETUR,
    VERFARKAS,
    VILLAM,
    VIZ,
    VIZELEMENTAL,
    VIZIO,
    WOMATH,
    XENO,
    YETI,
    ZAN_INDUKATOR

}

public static class Extensions
{
    public static List<EnumKeyValuePairs> enumvalues = new();

    [System.Serializable]
    public class EnumKeyValuePairs
    {
        public Enum key;
        public string value;

        public EnumKeyValuePairs(Enum key, string value)
        {
            this.key = key;
            this.value = value;
        }
    }

    //This is a extension class of enum
    public static string GetEnumDisplayNameTypeEnum(this Enum enumType)
    {


        if (enumvalues.Count == 0)
        {
            FillEnumValues();
        }
        return (from e in enumvalues
                where e.key == enumType
                select e.value).ToList().First();
    }


    public static Enum GetEnumValueByDisplayName(this Enum enumType, string target)
    {


        if (enumvalues.Count == 0)
        {
            FillEnumValues();
        }

        /*return (from e in enumvalues
                where e.value == target.Trim() && e.key.GetType() == enumType.GetType()
                select e.key).ToList().First();*/

        if (target.Length > 0)
        {
            return (from e in enumvalues
                             where e.value.ToLower() == target.ToLower().Trim() && e.key.GetType() == enumType.GetType()
                             select e.key).ToList().First();
        }
        else
        {
            return (from e in enumvalues
                    where e.key.ToString() == "NONE" && e.key.GetType() == enumType.GetType()
                    select e.key).ToList().First();
        }
    }

    private static void FillEnumValues()
    {
        enumvalues.Add(new EnumKeyValuePairs(DurationType.NONE, "None"));
        enumvalues.Add(new EnumKeyValuePairs(EffectType.NONE, "None"));
        enumvalues.Add(new EnumKeyValuePairs(Place.NONE, "None"));
        enumvalues.Add(new EnumKeyValuePairs(Target.NONE, "None"));
        enumvalues.Add(new EnumKeyValuePairs(Player.NONE, "None"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.NONE, "None"));
        enumvalues.Add(new EnumKeyValuePairs(ActionType.NONE, "None"));
        enumvalues.Add(new EnumKeyValuePairs(Rarity.NONE, "None"));
        enumvalues.Add(new EnumKeyValuePairs(SummonCostType.NONE, "None"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.NONE, "None"));
        enumvalues.Add(new EnumKeyValuePairs(Group.NONE, "None"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.NONE, "None"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.NONE, "None"));

        // DurationType Enum
        enumvalues.Add(new EnumKeyValuePairs(DurationType.ALLANDO, "Állandó"));

        // EffectType Enum
        enumvalues.Add(new EnumKeyValuePairs(EffectType.OSMAGIA, "Õsmágia"));
        enumvalues.Add(new EnumKeyValuePairs(EffectType.GYUJTOBOL_NEM_KERULHET_SEMMIBE, "Gyûjtõbõl Nem Kerülhet Semmibe"));
        enumvalues.Add(new EnumKeyValuePairs(EffectType.EXTRA_VP_REAGALNI, "+X VP reagálni rá"));

        // Place Enum
        enumvalues.Add(new EnumKeyValuePairs(Place.SAJAT_PAKLI, "Saját Pakli"));
        enumvalues.Add(new EnumKeyValuePairs(Place.SAJAT_KEZ, "Saját Kéz"));
        enumvalues.Add(new EnumKeyValuePairs(Place.SAJAT_TARTALEK, "Saját Tartalék"));
        enumvalues.Add(new EnumKeyValuePairs(Place.SAJAT_ORPOSZT, "Saját Õrposzt"));
        enumvalues.Add(new EnumKeyValuePairs(Place.SAJAT_KOVETO, "Saját Követõ"));
        enumvalues.Add(new EnumKeyValuePairs(Place.SAJAT_SZABALYLAP, "Saját Szabálylap"));
        enumvalues.Add(new EnumKeyValuePairs(Place.SAJAT_GYUJTO, "Saját Gyûjtõ"));
        enumvalues.Add(new EnumKeyValuePairs(Place.SAJAT_SEMMI, "Saját Semmi"));
        enumvalues.Add(new EnumKeyValuePairs(Place.SAJAT_BUBAJ, "Saját Semmi"));
        enumvalues.Add(new EnumKeyValuePairs(Place.SAJAT_TARGY, "Saját Tárgy"));
        enumvalues.Add(new EnumKeyValuePairs(Place.ELLENFEL_PAKLI, "Ellenfél Pakli"));
        enumvalues.Add(new EnumKeyValuePairs(Place.ELLENFEL_KEZ, "Ellenfél Kéz"));
        enumvalues.Add(new EnumKeyValuePairs(Place.ELLENFEL_TARTALEK, "Ellenfél Tartalék"));
        enumvalues.Add(new EnumKeyValuePairs(Place.ELLENFEL_ORPOSZT, "Ellenfél Õrposzt"));
        enumvalues.Add(new EnumKeyValuePairs(Place.ELLENFEL_KOVETO, "Ellenfél Követõ"));
        enumvalues.Add(new EnumKeyValuePairs(Place.ELLENFEL_SZABALYLAP, "Ellenfél Szabálylap"));
        enumvalues.Add(new EnumKeyValuePairs(Place.ELLENFEL_GYUJTO, "Ellenfél Gyûjtõ"));
        enumvalues.Add(new EnumKeyValuePairs(Place.ELLENFEL_SEMMI, "Ellenfél Semmi"));
        enumvalues.Add(new EnumKeyValuePairs(Place.ELLENFEL_BUBAJ, "Ellenfél Bûbáj"));
        enumvalues.Add(new EnumKeyValuePairs(Place.ELLENFEL_TARGY, "Ellenfél Tárgy"));

        // Target Enum
        enumvalues.Add(new EnumKeyValuePairs(Target.JATEKOS, "Játékos"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL, "Ellenfél"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_PAKLI, "Saját Pakli"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_PAKLI, "Ellenfél Pakli"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_KEZ, "Saját Kéz"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_KEZ, "Ellenfél Kéz"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_TARTALEK, "Saját Tartalék"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_TARTALEK, "Ellenfél Tartalék"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_ORPOSZT, "Saját Õrposzt"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_ORPOSZT, "Ellenfél Õrposzt"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_GYUJTO, "Saját Gyûjtõ"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_GYUJTO, "Ellenfél Gyûjtõ"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_SEMMI, "Saját Semmi"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_SEMMI, "Ellenfél Semmi"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_KOVETO, "Saját Követõ"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_KOVETO, "Ellenfél Követõ"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_SZABALYLAP, "Saját Szabálylap"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_SZABALYLAP, "Ellenfél Szabálylap"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_BUBAJ, "Saját Bûbáj"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_BUBAJ, "Ellenfél Bûbáj"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_TARGY, "Saját Tárgy"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_TARGY, "Ellenfél Tárgy"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_EPITMENY, "Saját Építmény"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_EPITMENY, "Ellenfél Építmény"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_HAJO, "Saját Hajó"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_HAJO, "Ellenfél Hajó"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_LENY, "Saját Lény"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_LENY, "Ellenfél Lény"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_SZORNY, "Saját Szörny"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_SZORNY, "Ellenfél Szörny"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_TOKEN, "Saját Tóken"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_TOKEN, "Ellenfél Tóken"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_KALANDOZO, "Saját Kalandozó"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_KALANDOZO, "Ellenfél Kalandozó"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_GALETKI, "Saját Galetki"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_GALETKI, "Ellenfél Galetki"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_MAGA, "Saját Maga"));

        // Player Enum
        enumvalues.Add(new EnumKeyValuePairs(Player.JATEKOS, "Játékos"));
        enumvalues.Add(new EnumKeyValuePairs(Player.ELLENFEL, "Ellenfél"));

        // Phase Enum
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_ELOKESZITO_EGY, "Saját Elõkészítõ Fázis Saját Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_ELOKESZITO_KETTO, "Saját Elõkészítõ Fázis Ellenfél Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_HUZAS_EGY, "Saját Húzás Fázis Saját Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_HUZAS_KETTO, "Saját Húzás Fázis Ellenfél Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_FO_EGY_EGY, "Saját Elsõ Fõ Fázis Saját Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_FO_EGY_KETTO, "Saját Elsõ Fõ Fázis Ellenfél Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_CSERE_EGY, "Saját Csere Fázis Saját Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_CSERE_KETTO, "Saját Csere Fázis Ellenfél Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_CSERE_UTANI_AZONNALI_EGY, "Saját Csere Fázis Utáni Azonnali Fázis Saját Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_CSERE_UTANI_AZONNALI_KETTO, "Saját Csere Fázis Utáni Azonnali Fázis Ellenfél Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_HARC_EGY, "Saját Harc Fázis Saját Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_HARC_KETTO, "Saját Harc Fázis Ellenfél Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_FO_KETTO_EGY, "Saját Második Fõ Fázis Saját Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_FO_KETTO_KETTO, "Saját Második Fõ Fázis Ellenfél Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_GYOGYULAS_EGY, "Saját Gyógyulási Fázis Saját Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_GYOGYULAS_KETTO, "Saját Gyógyulási Fázis Saját Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_ELOKESZITO_EGY, "Ellenfél Elõkészítõ Fázis Ellenfél Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_ELOKESZITO_KETTO, "Ellenfél Elõkészítõ Fázis Saját Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_HUZAS_EGY, "Ellenfél Húzás Fázis Ellenfél Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_HUZAS_KETTO, "Ellenfél Húzás Fázis Saját Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_FO_EGY_EGY, "Ellenfél Elsõ Fõ Fázis Ellenfél Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_FO_EGY_KETTO, "Ellenfél Elsõ Fõ Fázis Saját Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_CSERE_EGY, "Ellenfél Csere Fázis Ellenfél Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_CSERE_KETTO, "Ellenfél Csere Fázis Saját Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_CSERE_UTANI_AZONNALI_EGY, "Ellenfél Csere Fázis Utáni Azonnali Fázis Ellenfél Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_CSERE_UTANI_AZONNALI_KETTO, "Ellenfél Csere Fázis Utáni Azonnali Fázis Saját Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_HARC_EGY, "Ellenfél Harc Fázis Ellenfél Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_HARC_KETTO, "Ellenfél Harc Fázis Saját Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_FO_KETTO_EGY, "Ellenfél Második Fõ Fázis Ellenfél Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_FO_KETTO_KETTO, "Ellenfél Második Fõ Fázis Saját Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_GYOGYULAS_EGY, "Ellenfél Gyógyulási Fázis Ellenfél Akció"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_GYOGYULAS_KETTO, "Ellenfél Gyógyulási Fázis Ellenfél Akció"));

        // ActionType Enum
        enumvalues.Add(new EnumKeyValuePairs(ActionType.PARENT, "Szülõ"));
        enumvalues.Add(new EnumKeyValuePairs(ActionType.LAPKIJATSZAS, "Lapkijátszás"));
        enumvalues.Add(new EnumKeyValuePairs(ActionType.BLOKKOLAS, "Blokkolás"));
        enumvalues.Add(new EnumKeyValuePairs(ActionType.VP_SZERZES, "VP Szerzés"));
        enumvalues.Add(new EnumKeyValuePairs(ActionType.LAP_HUZAS, "Lap húzás"));
        enumvalues.Add(new EnumKeyValuePairs(ActionType.LAP_VISSZAHUZAS_GYUJTOBOL, "Lap Visszahúzás Gyûtõbõl"));
        enumvalues.Add(new EnumKeyValuePairs(ActionType.KIJATSZOTT_LAP_SEMMIBE_RAKASA, "Kijászott Lap Semmibe Rakása"));
        enumvalues.Add(new EnumKeyValuePairs(ActionType.KEPESSEG_VALASZTAS_KIJATSZAS_ELOTT, "Képesség Választás Kijátszás Elõtt"));
        enumvalues.Add(new EnumKeyValuePairs(ActionType.VIZIO, "Vízió"));
        enumvalues.Add(new EnumKeyValuePairs(ActionType.REAGALAS, "Reagálás"));


        // Rarity Enum
        enumvalues.Add(new EnumKeyValuePairs(Rarity.GYAKORI, "Gyakori"));
        enumvalues.Add(new EnumKeyValuePairs(Rarity.NEM_GYAKORI, "Nem Gyakori"));
        enumvalues.Add(new EnumKeyValuePairs(Rarity.RITKA, "Ritka"));
        enumvalues.Add(new EnumKeyValuePairs(Rarity.ULTRA_RITKA, "Ultra Ritka"));

        // SummonCostType

        enumvalues.Add(new EnumKeyValuePairs(SummonCostType.VP, "Varázs Pont"));
        enumvalues.Add(new EnumKeyValuePairs(SummonCostType.SZK, "Szörnykomponens"));
        enumvalues.Add(new EnumKeyValuePairs(SummonCostType.EPITO, "Építõ"));
        enumvalues.Add(new EnumKeyValuePairs(SummonCostType.ALDOZAS, "Áldozás"));
        enumvalues.Add(new EnumKeyValuePairs(SummonCostType.SEMMIZES, "Semmizés"));
        enumvalues.Add(new EnumKeyValuePairs(SummonCostType.ZANSZILANK, "Zanszilánk"));

        // Icons
        enumvalues.Add(new EnumKeyValuePairs(Icons.ELETKIOLTO, "Élet Kioltó"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.ELOHOLT, "Élõholt"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.EREKLYE, "Ereklye"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.EROD, "Erõd"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.ETNIKUM, "Etnikum"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.FA, "Fa"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.FEM, "Fém"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.HALO, "Háló"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.HEGYMELYI, "Hegymélyi"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.HIDEG, "Hideg"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.HORGONY, "Horgony"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.IDEZES, "Idézés"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.ISTENI, "Isteni"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.KEGY, "Kegy"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.KF, "KF"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.KINCS, "Kincs"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.KOD, "Köd"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.LEGENDAS, "Legendás"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.MENTALIS, "Mentális"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.ORZO, "Õrzõ"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.OSMAGIA, "Õsmágia"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.REAKCIO_DRAGITAS, "Reakció Drágítás"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.REPUL, "Repül"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.REZISZTENCIA, "Rezisztencia"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.SZORNYKOMPONENS, "Szörnykomponens"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.TUZ, "Tûz"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.VEDEKEZES, "Védekezés"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.VILLAM, "Villám"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.MAGIKUS_TAMADAS, "Mágikus Támadás"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.MAGIKUS_VEDEKEZES, "Mágikus Védekezés"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.NORMAL_TAMADAS, "Normál Támadás"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.NORMAL_VEDEKEZES, "Normál Védekezés"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.VP, "VP (Idézési költség)"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.SZK, "SZK (Idézési költség)"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.EPITO, "Építõ (Idézési költség)"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.ALDOZAS, "Áldozás (Idézési költség)"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.SEMMIZES, "Semmizés (Idézési költség)"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.ZANSZILANK, "Zanszilánk (Idézési költség)"));

        // Group Enum
        enumvalues.Add(new EnumKeyValuePairs(Group.BUFA, "Bufa"));
        enumvalues.Add(new EnumKeyValuePairs(Group.BARD, "Bárd"));
        enumvalues.Add(new EnumKeyValuePairs(Group.CHARADIN, "Chara-din"));
        enumvalues.Add(new EnumKeyValuePairs(Group.MUTANS, "Mutáns"));
        enumvalues.Add(new EnumKeyValuePairs(Group.DORNODON, "Dornodon"));
        enumvalues.Add(new EnumKeyValuePairs(Group.TOLVAJ, "Tolvaj"));
        enumvalues.Add(new EnumKeyValuePairs(Group.ELENIOS, "Elenios"));
        enumvalues.Add(new EnumKeyValuePairs(Group.PSZIONICISTA, "Pszionicista"));
        enumvalues.Add(new EnumKeyValuePairs(Group.FAIRLIGHT, "Fairlight"));
        enumvalues.Add(new EnumKeyValuePairs(Group.MAGUS, "Mágus"));
        enumvalues.Add(new EnumKeyValuePairs(Group.LEAH, "Leah"));
        enumvalues.Add(new EnumKeyValuePairs(Group.HALHATATLAN, "Halhatatlan"));
        enumvalues.Add(new EnumKeyValuePairs(Group.RAIA, "Raia"));
        enumvalues.Add(new EnumKeyValuePairs(Group.KATONA, "Katona"));
        enumvalues.Add(new EnumKeyValuePairs(Group.SHERAN, "Sheran"));
        enumvalues.Add(new EnumKeyValuePairs(Group.TUDOS, "Tudós"));
        enumvalues.Add(new EnumKeyValuePairs(Group.THARR, "Tharr"));
        enumvalues.Add(new EnumKeyValuePairs(Group.TISZTOGATO, "Tisztogató"));
        enumvalues.Add(new EnumKeyValuePairs(Group.RHATT, "Rhatt"));
        enumvalues.Add(new EnumKeyValuePairs(Group.SZINTELEN, "Színtelen"));
        enumvalues.Add(new EnumKeyValuePairs(Group.KOVETO_SZABALYLAP, "Követõ/Szabálylap"));
        enumvalues.Add(new EnumKeyValuePairs(Group.NONE, "Nincs"));

        // MainType
        enumvalues.Add(new EnumKeyValuePairs(MainType.ALTALANOS, "Általános"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.AVATAR, "Avatár"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.AZONNALI, "Azonnali"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.BUBAJ, "Bûbáj"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.BUBAJ_BUBAJRA, "Bûbáj Bûbájra"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.BUBAJ_EPITMENYRE, "Bûbáj Építményre"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.BUBAJ_KALANDOZORA, "Bûbáj Kalandozóra"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.BUBAJ_LAPRA, "Bûbáj Lapra"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.BUBAJ_LENYRE, "Bûbáj Lényre"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.BUBAJ_TARGYRA, "Bûbáj Tárgyra"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.CEH, "Céh"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.EGYEB, "Egyéb"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.EPITMENY, "Építmény"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.GALETKI, "Galetki"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.HELYSZIN, "Helyszín"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.KALANDOZO, "Kalandozó"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.KOVETO, "Követõ"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.OSLICH, "Õslich"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.SZABALYLAP, "Szabálylap"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.SZAKERTELEM, "Szakértelem"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.SZINTLEPES, "Szintlépés"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.SZORNY, "Szörny"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.TARGY, "Tárgy"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.TESTRESZ, "Testrész"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.TORZSZULOTT, "Torzszülött"));

        // SubType
        enumvalues.Add(new EnumKeyValuePairs(SubType.NONE, ""));
        enumvalues.Add(new EnumKeyValuePairs(SubType.ALAKVALTO, "Alakváltó"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.ANGYAL, "Angyal"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.ARNYMANO, "Árnymanó"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.BANYA, "Bánya"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.BAZALTELEMENTAL, "BazaltElementál"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.BETEGSEG, "Betegség"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.BURASTYA, "Burástya"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.CHARADIN_FATTYA, "Chara-din Fattya"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.CSAPDA, "Csapda"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.CSONTVAZ, "Csontváz"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.DINO, "Dinó"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.DRUIDA, "Druida"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.DZSINN, "Dzsinn"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.EBEN_IJASZ, "Ében Íjász"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.EJFATTY, "Éjfatty"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.EKSZER, "Ékszer"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.ELEKTROMOS, "Elektromos"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.ELEMENTAL, "Elementál"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.ELF, "Elf"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.EMBER, "Ember"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.EPIKUS, "Epikus"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.FALU, "Falu"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.FEGYVER, "Fegyver"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.FEREG, "Féreg"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.FOKUSZKRISTALY, "Fókuszkristály"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.FONIX, "Fõnix"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.GANUID, "Ganüid"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.GNOM, "Gnóm"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.GOBLIN, "Goblin"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.GOLEM, "Gólem"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.GRIFF, "Griff"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.GROK_KEPZODMENY, "Grok Képzõdmény"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.HADVEZER, "Hadvezér"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.HAJO, "Hajó"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.HANGSZER, "Hangszer"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.HATAS, "Hátas"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.HELYSZIN, "Helyszín"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.HIDEG, "Hideg"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.HORDAPARANCSNOK, "Hordaparancsnok"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.IJASZ, "Íjász"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.JEG, "Jég"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.KALOZ, "Kalóz"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.KAOSZSZELLEM, "Káoszszellem"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.KIGYO, "Kígyó"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.KISERTET, "Kísértet"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.KOBUDERA, "Kobudera"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.KOZOS_TUDAT, "Közös Tudat"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.KRABBER, "Krabber"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.LEGELEMENTAL, "Légelementál"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.LOVAS, "Lovas"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.MANO, "Manó"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.MINOTAURUSZ, "Minotaurusz"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.MOA, "Moa"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.MORF, "Morf"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.MOTYOGO, "Motyogó"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.MUTANS, "Mutáns"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.NEKROMANTA, "Nekromanta"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.NERUB, "Nerub"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.OLTAR, "Oltár"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.ORGLING, "Orling"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.ORIAS, "Óriás"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.ORK, "Ork"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.OSHANGYA, "Õshangya"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.PAJZS, "Pajzs"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.PANCEL, "Páncél"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.PEGAZUS, "Pegazus"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.POK, "Pók"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.POLIP, "Polip"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.POLITIKA, "Politika"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.PRAGLONC, "Praglonc"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.PROFETA, "Próféta"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.PULZALO, "Pulzáló"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.QUWARG, "Quwarg"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.QUWARG_BOLY, "Quwarg Boly"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.RAK, "Rák"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.REAKCIO, "Reakció"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.SARKANY, "Sárkány"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.SAV, "Sav"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.SISAK, "Sisak"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.SKORPIO, "Skorpió"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.SZENTELY, "Szentély"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.SZILMILL, "Szilmill"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.SZINGULARIS, "Szinguláris"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.SZINGULARITAS, "Szingularitás"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.SZINTLEPES, "Szintlépés"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.SZINARUSZ, "Szinárusz"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.SZIREN, "Szirén"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.SZKRITTER, "Szkritter"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.TEKNOS, "Teknõs"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.TEMPLOM, "Templom"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.TERMIK, "Termik"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.THARGODAN, "Thargodan"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.TOJAS, "Tojás"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.TORONY, "Torony"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.TORPE, "Törpe"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.TRIKLEM_DRAKOLDER, "Triklem Drakolder"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.TROGDOLITA, "Trogdolita"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.TROLL, "Troll"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.TUZELEMENTAL, "Tûzelementál"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.VAMPIR, "Vámpír"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.VARKAUDAR, "Varkaudar"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.VEGZETUR, "Végzetúr"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.VERFARKAS, "Vérfarkas"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.VILLAM, "Villám"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.VIZ, "Víz"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.VIZELEMENTAL, "Vízelementál"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.VIZIO, "Vízió"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.WOMATH, "Womath"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.XENO, "Xenó"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.YETI, "Yeti"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.ZAN_INDUKATOR, "Zan Indukátor"));
    }
}

