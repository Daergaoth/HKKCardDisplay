using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RuleBook
{
    //public static Dictionary<Icons, string> IconExplanationMap = new Dictionary<Icons, string>();

    public static List<IconExplanation> IconExplanationMap = new();

    public static bool RuleBookLoaded = false;

    [System.Serializable]
    public class IconExplanation
    {
        public Icons key;
        public string value;

        public IconExplanation(Icons key, string value)
        {
            this.key = key;
            this.value = value;
        }
    }

    public static string GetExplanation(Icons icon)
    {
        return (from e in IconExplanationMap
                where e.key == icon
                select e.value).ToList().FirstOrDefault();
    }

    public static void LoadRuleBook()
    {
        try
        {
            string missing = "Sajnos ehhez az ikonhoz nem áll rendelkezésre leírás.";

            // Add Icon Exaplanations 
            string temp = "<b>Életkioltó</b>: Az életkioltó forrásoktól nem véd az életjelzõ. Ha egy permanens forrás hatására kikerül a játékból vagy gazdát cserél, az életjelzõk elõtte leesnek róla. Életkioltó forrás az olyan varázslat, amin ez az ikon szerepel, vagy az olyan hatás, amit egy ikonnal ellátott lap hoz létre.";
            IconExplanationMap.Add(new IconExplanation(Icons.ELETKIOLTO, temp));

            temp = "<b>Élőholt</b>: Azok a lények, amelyeken szerepel ez az ikon, élőholtnak (élőhalottnak) számítanak.\nHa egy lényt valamilyen módon élőholttá tesznek, úgy kell tekinteni, mintha ez az ikon szerepelne rajta.\nAz élőholt besorolás nem lény altípus, és nem különleges képesség, hanem a lények egy csoportjának megjelölése.";
            IconExplanationMap.Add(new IconExplanation(Icons.ELOHOLT, temp));

            temp = "<b>Ereklye</b>: Azt a lapot, amin ez az ikon szerepel, ereklyének nevezzük.\nAz ereklye nem lap altípus, de lapok egy csoportjának megjelöléseként más lapok hivatkozhatnak rá.\nAz ereklye egy állandóan működő képesség. Jelentése: \"Áldozd fel és rakd a Semmibe: kapsz 1 szörnykomponenst, 3 - mal nő a max.ÉP - d, és gyógyulsz 3 - at.Egy körben csak egyszer áldozhatsz lapot ereklye képességnek.\"";
            IconExplanationMap.Add(new IconExplanation(Icons.EREKLYE, temp));

            temp = "<b>Erőd (Elavult)</b>: Ha egy lapon ez az ikon szerepel, az azt jelenti, hogy a lap ún. „erőd” lap. Ez nem képesség, és nem altípus, hanem lapok egy csoportjának megjelölése.";
            IconExplanationMap.Add(new IconExplanation(Icons.EROD, temp));

            temp = "<b>Etnikum</b>: " + missing;
            IconExplanationMap.Add(new IconExplanation(Icons.ETNIKUM, temp));

            temp = "<b>Fa (Elavult)</b>: Egyes lapok hivatkoznak a fából, illetve fémből készült tárgyakra. Az, hogy egy tárgy fából vagy fémből, esetleg mindkettőből készült, nem tárgy altípus, és nem is képesség, hanem a tárgyak egy-egy csoportjának megjelölése. Ha egy lap szövege a „fém ikon” vagy a „fa ikon” tárgyakra hat, akkor hat azokra a tárgyakra is, amelyek mindkettőből készültek.";
            IconExplanationMap.Add(new IconExplanation(Icons.FA, temp));

            temp = "<b>Fém (Elavult)</b>: Egyes lapok hivatkoznak a fából, illetve fémből készült tárgyakra. Az, hogy egy tárgy fából vagy fémből, esetleg mindkettőből készült, nem tárgy altípus, és nem is képesség, hanem a tárgyak egy-egy csoportjának megjelölése. Ha egy lap szövege a „fém ikon” vagy a „fa ikon” tárgyakra hat, akkor hat azokra a tárgyakra is, amelyek mindkettőből készültek.";
            IconExplanationMap.Add(new IconExplanation(Icons.FEM, temp));

            temp = "<b>Háló</b>: Minden egyes háló ikonnal rendelkező lap játékba kerülésénél külön-külön figyelemmel kell kísérni, hogy az adott lap játékba kerülése után hány lapot játszottak ki a játékosok a kezükből.\nA háló csak azt korlátozza, hogy a játékos megpróbálhat-e kijátszani lapot, vagy sem, tehát a háló játékba kerülése előtt megkezdett lapkijátszást visszamenőleg nem \"akadályozza\" meg. Tehát ha a reakció sorba kerül egy háló képességgel rendelkező lap kijátszása is, az az adott reakció sorban történő lapkijátszást még nem befolyásolja.";
            IconExplanationMap.Add(new IconExplanation(Icons.HALO, temp));

            temp = "<b>Hegymélyi</b>: Ez az ikon azt jelenti, hogy a lap ún. hegymélyi lény vagy ún. hegymélyi varázslat.\nA hegymélyi varázslatok közös kijátszási feltétele, hogy kijátszójuknak lennie kell legalább egy hegymélyi lényének játékban.\nA varázslatként kijátszott hegymélyi lények kijátszásakor ennek a kijátszási feltételnek nem kell teljesülnie.\nA hegymélyi ikon nem altípus és nem képesség, hanem a lapok egy csoportjának megjelölése.";
            IconExplanationMap.Add(new IconExplanation(Icons.HEGYMELYI, temp));

            temp = "<b>Hideg</b>: A hideg, villám, tûz ikonok jelentése: a lap ilyen altípusú. Ha egy forrás hidegre, villámra vagy tûzre hivatkozik (akár szöveggel, akár ikonnal írva), az mind a szöveggel, mind az ikonnal jelölt lapokra vonatkozik.\nHa egy lapon (kivéve a szövegmezőben) a tűz, hideg vagy villám ikon szerepel, akkor a lapnak minden sebzése tűz- hideg- illetve villámsebzés.";
            IconExplanationMap.Add(new IconExplanation(Icons.HIDEG, temp));

            temp = "<b>Horgony</b>: Azt a lapot, amin ez az ikon szerepel, semmilyen módon nem lehet az asztalról kézbe visszavenni.\nA horgony ikon egy állandóan működő képesség, ami akkor is működik, ha a lap passzív.";
            IconExplanationMap.Add(new IconExplanation(Icons.HORGONY, temp));

            temp = "<b>Idézés</b>: Ha az ellenfél kezdte a játszmát, a 2. körtől kezdve az idézéses lap alap idézési költsége 1-gyel kevesebb (lecsökkenhet így 0-ra is). Az idézés szabályt egy meccsben csak egyszer használhatod.\nAzoknak a 2023-tól kiadott lapoknak, amelyeknek csak varázspont van a költségében (zanszilánk vagy más ikon nem) akkor is van idézése, ha ez az ikon nem szerepel rajtuk.\n Nem lehet idézni olyan lapot, melynek költségét nem módosíthatod, vagy nem csökkentheted.\nAz idézéssel kijátszott fix idézési költségű lapok a játékban nem számítanak eggyel kisebb idézési költségűnek.\nHa egy lap a fenti szabályok szerint idézhető, akkor annak korábbi, vele azonos nevű és szövegű kiadásai is idézhetők, akkor is, ha korábbi dátum van rajtuk.";
            IconExplanationMap.Add(new IconExplanation(Icons.IDEZES, temp));

            temp = "<b>Isteni</b>: Egy pakliban csak egy színből használhatsz \"isteni\" ikonnal jelölt lapokat, olyanszínbõl, amilyent egyébként is használsz. A paklidban maximum 13 darab isteni lap lehet.";
            IconExplanationMap.Add(new IconExplanation(Icons.ISTENI, temp));

            temp = "<b>Kegy</b>: Ha egy játékosnak három különböző, ugyanolyan színű ’kegy ikon’ lapja van játékban, akkor a fő fázisában kikereshet egy lapot a paklijából. Egy játszma során egy játékos egyszer kereshet elő így lapot. (Ha a kegy ikon egy azonnali vagy általános varázslaton szerepel, akkor ennek kijátszásakor kell vizsgálni, hogy van-e két további kegy lap játékban, és így teljesül-e a lapkeresés feltétele.) A kegy nem képesség, hanem lapok egy csoportjának megjelölése.";
            IconExplanationMap.Add(new IconExplanation(Icons.KEGY, temp));

            temp = "<b>KF</b>: <b>KF tárgy</b> A tárgyak egy részén az illusztráció és a szövegmező közti keretben a # ikon látható. Ezeket a tárgyakat nem az asztalra kell kitenni, hanem egy olyan lényre kell rátenni, ami képes azt használni, azaz szintén rendelkezik a # ikonnal. A szabályok vagy lapok szövegében a „KF” (kézben fog) rövidítés a # ikont jelenti. Azt a lényt, amelynél tárgy van, nevezzük a tárgy hordozójának.\nA KF ikonos tárgyak kijátszása nem számít sem forrásnak, sem célzásnak.\nHa egy KF tárgy szövegezése kifejezetten megengedi, hogy bármilyen lényre rátehető, akkor ezen azt kell érteni, hogy a lénynek nem kell tudnia tárgyat használni, nem kell rendelkeznie a KF ikonnal, annak hiányában is kaphat ilyen tárgyat.\n<b>KF tárgy megszerzése</b> Amennyiben egy tárgyat hordozó lény harcol egy másik lénnyel, és a tárgyat hordozó lény a harci fázisban kikerül a játékból, míg a vele harcoló lény a játékban marad, akkor a játékból kikerülő lényen lévő tárgy nem kerül automatikusan a gyűjtőbe. Ez esetben a harcot túlélő lény gazdája dönthet úgy, hogy a gyűjtőbe kerülés helyett a rátett tárgyat átrakja a harcban részt vevő és azt túlélő lényére, feltéve, hogy az hordozója lehet a tárgynak. Ilyen esetben az új hordozó gazdája lesz az elvett tárgy új gazdája.\nAz így elvett tárgy a harci fázisnak azon részfázisa végén cserél gazdát, amikor az addigi hordozó kikerült a játékból.\nHa a KF tárgy hordozóját egynél több lény támadja, és a harc végén a tárgyat egynél több lény is megszerezheti, akkor e lények gazdája eldöntheti, hogy a tárgyat mely lénye szerezze meg.";
            IconExplanationMap.Add(new IconExplanation(Icons.KF, temp));

            temp = "<b>Kincs</b>: Ha egy lapon ez az ikon szerepel, akkor a lap kincsként használható.\nA kincsként való használat (röviden: kincsezés) egy kézben működő képesség.\nKincs képességet a játékos a második körétől, a saját fő fázisában, 1 VP elköltésével, körönként egyszer használhat. A kincs ikon lapot ekkor a Semmibe kell dobni, amiért a játékos kap 2 szörnykomponenst.\nA kincsezés cselekvésnek számít, de nem lehet rá reagálni, és nem számít sem lapkijátszásnak, sem forrásnak.\nA kincsezésért kapott szörnykomponensek mennyiségét semmilyen módon nem lehet módosítani.\nA kincsezéssel kapott szörnykomponensekről nem lehet lemondani.";
            IconExplanationMap.Add(new IconExplanation(Icons.KINCS, temp));

            temp = "<b>Köd</b>: Ha egy lapon ez az ikon szerepel, akkor a lapot ún. „köd lap”-nak nevezzük.\nA köd lapok, függetlenül típusuktól, altípusuktól és szövegüktől, kijátszhatók 1 VP-ért azonnali varázslatként (ezt nevezzük ködkereső varázslatnak, ködkeresésnek, vagy röviden: ködözésnek is). A ködkereső varázslat sikeres kijátszása esetén a játékos előkereshet egy köd lapot a paklijából.\nA ködkeresés költsége semmilyen módon nem módosítható, és nem helyettesíthető.\nA ködkeresés is köd ikon kijátszásának számít, és az esetleges altípusát vagy altípusait a 'köd lap ködözéskor is megtartja.\nA köd ikonos lap ködkeresésre csak ténylegesen kézből történő kijátszásakor használható.\nA köd ikonos lapok a gyűjtőből (vízió, feltámadás, stb.) vagy a pakliból kizárólag az eredeti funkciójuk szerint játszhatók ki, ködkeresésként nem.\nEgy adott játékos körönként csak egyszer használhat sikeresen ködkeresést.\nHa a játék során valaki sikeresen használt ködkeresést, a játszma hátralévő részében ködözésen kívül egyéb módon nem kereshet elő lapot (kivéve valamilyen hátrány következményeként).\nA köd ikonos lapok ködözéskor is megtartják az esetleges <missing icon>-t és a kompenzációjukat, és ha rendelkeznek ősmágia ikonnal, ilyen lap kijátszásának kell őket tekinteni.";
            IconExplanationMap.Add(new IconExplanation(Icons.KOD, temp));

            temp = "<b>Legendás</b>: Ha egy lény lapon ez az ikon szerepel, akkor az a lény ún. \"legendás\" lény. Az ilyen lények szöveges leírásában mindig szerepel egy ún. \"legendás képesség\".\nA lények legendás képessége csak akkor működik, ha valamilyen körülmény ezt kifejezetten lehetővé teszi.";
            IconExplanationMap.Add(new IconExplanation(Icons.LEGENDAS, temp));

            temp = "<b>Mentális</b>: Mentális, Tűz, Villám és Hideg ikon. Ezek az ikonok rendre a mentális, tűz, villám és hideg altípust jelölik. Ha egy forrás ezekra az altípusokra hivatkozik (akár szöveggel, akár ikonnal írva), az mind a szöveggel, mind az ikonnal jelölt lapokra vonatkozik. Az ilyen altípusú lapok minden sebzése ilyen sebzésnek minõsül (beleértve a bal alsó sarokba írt sebzést, a direkt sebzõ képességet és a képességekkel okozott sebzést).";
            IconExplanationMap.Add(new IconExplanation(Icons.MENTALIS, temp));

            temp = "<b>Őrző</b>: Ha egy játékban lévő lapon ez az ikon szerepel, akkor az azt jelenti, hogy játékos nem lehet célpontja sebző (azonnali vagy általános) varázslatnak. Az őrző egy állandóan működő képesség.";
            IconExplanationMap.Add(new IconExplanation(Icons.ORZO, temp));

            temp = "<b>Ősmágia</b>: Ha egy lapon ősmágia ikon szerepel, akkor a lapot ősmágiás lapnak nevezzük.\nAz ősmágia egy állandóan működő képesség.\nHa a játékos az általa kijátszott ősmágiás lap idézési költségét nem csökkenti, akkor ellenfele ennek a lapnak az idézési költségét semmilyen módon nem növelheti.\nAz alap idézési költség kiszámítása az ősmágia szempontjából nem minősül az idézési költség csökkentésének.\nAz ősmágia képesség csak az idézési költséget módosító valamennyi körülmény összegzése után vizsgálható.";
            IconExplanationMap.Add(new IconExplanation(Icons.OSMAGIA, temp));

            temp = "<b>Reakció drágítás</b>: " + missing;
            IconExplanationMap.Add(new IconExplanation(Icons.REAKCIO_DRAGITAS, temp));

            temp = "<b>Repül</b>: Repülő lénynek tekintünk minden olyan lényt, amelynek szöveges leírásában szerepel, hogy: \"Repül.\" illetve a lapon megtalálható a „repül ikon” a keretben. Minden más lény „nem repülő” lénynek számít, függetlenül attól, hogy ténylegesen aktívan vagy passzívan került játékba.\nAz e címben található szabályokat megfelelően alkalmazni kell a repülő/nem repülő építményekre is.\nA repülés nem képesség, hanem a lap működéséhez fűzött magyarázat. Azt mutatja meg, hogy a lény vagy építmény a főszabálytól eltérően nem passzívan, hanem aktívan kerül játékba.\nA lapok szöveges leírásában szereplő: \"Aktívan jön játékba.\" – megfogalmazás egyenértékű a \"Repül.\" megfogalmazással, és a \"repül ikon\"-nal.\nHa a lény a saját szövege, vagy az őt kijátszó cselekvés szövege szerint aktívan kerül a tartalékba, vagy a kijátszásakor közvetlenül az őrposztba kerül, de a \"repül ikon\" vagy ennek szöveges megfelelője nem szerepel a lapon, akkor nem tekinthető repülő lénynek.\nHa egy lény bizonyos feltétel teljesítésekor válik repülő lénnyé, a feltétel teljesítése esetén repülő lénynek számít mindaddig, amíg játékban van.\nAz önálló jelzők közül az számít repülő lénynek, amelyek esetében az őt létrehozó lap szövegében, a jelző jellemzőinek felsorolásában kifejezetten szerepel a \"repül\" kitétel. Minden más jelző \"nem repülő\" lénynek számít, függetlenül attól, hogy ténylegesen aktívan vagy passzívan került játékba.";
            IconExplanationMap.Add(new IconExplanation(Icons.REPUL, temp));

            temp = "<b>Rezisztencia</b>: Ha egy lapon ez az ikon szerepel, az azt jelenti, hogy a lap nem lehet célpontja olyan forrásnak, ami a szövege szerint EGY konkrét lapra vagy permanensre hat, beleértve azokat a forrásokat is, amelyek a célpontnak választható lapok vagy permanensek körét valamilyen feltétellel (pl. színük vagy idézési költségük alapján) szűkítik.\nA rezisztencia nem véd azoktól a forrásoktól, amelyek egynél több lapot (permanenst) céloznak, vagy nem igényelnek célpontválasztást.\nA rezisztencia nem véd azoktól a forrásoktól, amelyek egy „célpont lényre/nem-lényre”, „célpont [laptípus]-ra”, „célpont (valamilyen) jelzőre” vagy „célpont [lap altípus]-ra” vonatkoznak, illetve lapok egy további csoportjának valamely tagját célozzák.\nA rezisztencia egy állandóan működő képesség.";
            IconExplanationMap.Add(new IconExplanation(Icons.REZISZTENCIA, temp));

            temp = "<b>Tűz</b>: A hideg, villám, tûz ikonok jelentése: a lap ilyen altípusú. Ha egy forrás hidegre, villámra vagy tûzre hivatkozik (akár szöveggel, akár ikonnal írva), az mind a szöveggel, mind az ikonnal jelölt lapokra vonatkozik.\nHa egy lapon (kivéve a szövegmezőben) a tűz, hideg vagy villám ikon szerepel, akkor a lapnak minden sebzése tűz- hideg- illetve villámsebzés.";
            IconExplanationMap.Add(new IconExplanation(Icons.TUZ, temp));

            temp = "<b>Védekezés</b>: Ha egy lapon ez az ikon szerepel, akkor a lap ún. \"védekezés lap\".\nHa az ellenfél kezdte a játszmát, akkor a védekezés lap az ellenfél első körében kézből ingyen kijátszható. Ezt védekezésből történő lapkijátszásának nevezzük.\nEgyazon játékos védekezésből maximum annyi lapot játszhat ki, ahány lapot az ellenfele az első körében kijátszott.\nA védekezés lap a laptípusától és altípusától függetlenül – akkor is, ha ez a szövegében kifejezetten nem szerepel – védekezésből kijátszható az ellenfél első körének fő fázisában, ha a játszmát az ellenfél kezdte.\nVédekezéses azonnali varázslat védekezésből is bármikor kijátszható, amikor azonnali varázslat játszható ki. Reakcióként a védekezéses lap védekezésből is kijátszható bármikor, amikor a reakcióként egyébként is kijátszható lenne.";
            IconExplanationMap.Add(new IconExplanation(Icons.VEDEKEZES, temp));

            temp = "<b>Villám</b>: A hideg, villám, tûz ikonok jelentése: a lap ilyen altípusú. Ha egy forrás hidegre, villámra vagy tûzre hivatkozik (akár szöveggel, akár ikonnal írva), az mind a szöveggel, mind az ikonnal jelölt lapokra vonatkozik.\nHa egy lapon (kivéve a szövegmezőben) a tűz, hideg vagy villám ikon szerepel, akkor a lapnak minden sebzése tűz- hideg- illetve villámsebzés.";
            IconExplanationMap.Add(new IconExplanation(Icons.VILLAM, temp));

            // EXTRA RULES FROM ICONS

            temp = "<b>Szörnykomponens</b>: Ha egy lény az asztalról a gyűjtőbe (Semmibe) kerül, akkor az ellenfél annyi szörnykomponenst nyerhet ki a lényből, ahány szörnykomponens ikon van a lapon.\nA szörnykomponens kinyerésének lehetősége egy játékszabály, sem forrásnak, sem hatásnak nem tekinthető.\nAz előkészítő fázisban gyűjtőbe (Semmibe) kerülő lényekből az ellenfél nem nyerhet ki szörnykomponenst.\nHa a lény valamely költség kifizetéseként végrehajtott, vagy valamely hátrány következménye miatt történő áldozással kerül a gyűjtőbe (Semmibe), akkor senki nem nyerhet ki belőle szörnykomponenst.\nA szörnykomponens kinyerése nem kötelező, és az erre jogosult játékos azokról részben vagy egészében lemondhat.\nA szörnykomponens kinyerésére annak a fázisnak a végéig van lehetőség, amelyik fázisban a lény a gyűjtőbe (Semmibe) került. Később ez már nem pótolható.\nA szörnyek az előkészítő fázisban komponensért feláldozhatók.\n";
            IconExplanationMap.Add(new IconExplanation(Icons.SZORNYKOMPONENS, temp));

            temp = "<b>Normál Támadás</b>: Az adott kártya támadását jelzi. Ez a támadás típus <b>nem képes</b> Mágikus védekezésű lapok megsebzésére.";
            IconExplanationMap.Add(new IconExplanation(Icons.NORMAL_TAMADAS, temp));

            temp = "<b>Mágikus Támadás</b>: Az adott kártya támadását jelzi. Ez a támadás típus <b>képes</b> Mágikus védekezésű lapok megsebzésére.";
            IconExplanationMap.Add(new IconExplanation(Icons.MAGIKUS_TAMADAS, temp));

            temp = "<b>Mágikus Védekezés</b>: Az adott kártya Életerejét mutatja. Ez a védekezés típus csak mágikus támadással üthető át. Ez az életerő visszaáll a kártya maximális életerejére a gyógyulási fázisban";
            IconExplanationMap.Add(new IconExplanation(Icons.MAGIKUS_VEDEKEZES, temp));

            temp = "<b>Normál Védekezés</b>: Az adott kártya Életerejét mutatja. Ez a védekezés típus mágikus és normál támadással is át üthető. Ez az életerő visszaáll a kártya maximális életerejére a gyógyulási fázisban";
            IconExplanationMap.Add(new IconExplanation(Icons.NORMAL_VEDEKEZES, temp));
            RuleBookLoaded = true;
        }
        catch (Exception e)
        {
            Debug.LogError(e.StackTrace);
        }

        
    }
}
