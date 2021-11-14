using Exercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HardExercises.Tests
{
    public class VeryHardExerciseTests
    {
        IVeryHardExercises veryHardExercises = new VeryHardExerciseSolutions();

        [Theory]
        [InlineData(new int[] { 2, 7, 6, 9, 5, 1, 4, 3, 8 }, true)]
        [InlineData(new int[] { 2, 7, 600, 9, 5, 1, -94, 3, 8 }, false)]
        [InlineData(new int[] { 2, 7, 50, 9, 555, 1, -9, 3, 8 }, false)]
        [InlineData(new int[] { 16, 3, 2, 13, 5, 10, 11, 8, 9, 6, 7, 12, 4, 15, 14, 1 }, true)]
        [InlineData(new int[] { 7, 12, 1, 14, 2, 13, 8, 11, 16, 3, 10, 5, 9, 6, 15, 4 }, true)]
        [InlineData(new int[] { 7, 12, 1, 14, 2, 13, 8, 11, 16, 3, 10, 5, 9, 6, 16, 5 }, false)]
        [InlineData(new int[] { 1, 14, 14, 4, 11, 7, 6, 9, 8, 10, 10, 5, 13, 2, 3, 15 }, true)]
        [InlineData(new int[] { 1, 14, 14, 4, 11, 7, 6, 9, 8, 11, 10, 5, 13, 2, 3, 15 }, false)]
        [InlineData(new int[] { 1, 15, 4, 14, 10, 11, 5, 8, 7, 6, 12, 9, 16, 2, 13, 3 }, false)]
        public void IsMagicSquare_ShouldReturn(int[] arr, bool expected)
        {
            // Arrange

            // Act
            var actual = veryHardExercises.IsMagicSquare(arr);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("5/7", "5/7")]
        [InlineData("4/6", "2/3")]
        [InlineData("11/10", "11/10")]
        [InlineData("8/4", "2")]
        [InlineData("7/4", "7/4")]
        [InlineData("6/4", "3/2")]
        [InlineData("300/200", "3/2")]
        [InlineData("50/25", "2")]
        [InlineData("5/45", "1/9")]
        public void Simplify_ShouldReturn(string str, string expected)
        {
            // Arrange

            // Act
            var actual = veryHardExercises.Simplify(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, new int[] { 1, 0 })]
        [InlineData(11, new int[] { 10, 1 })]
        [InlineData(229922, new int[] { 1079, 6 })]
        [InlineData(7777, new int[] { 709, 2 })]
        [InlineData(233332, new int[] { 188, 7 })]
        [InlineData(52788725, new int[] { 1894, 13 })]
        [InlineData(88555588, new int[] { 167, 11 })]
        [InlineData(252, new int[] { 252, 0 })]
        [InlineData(987789, new int[] { 100788, 1 })]
        [InlineData(123321, new int[] { 10119, 2 })]
        [InlineData(10001, new int[] { 10000, 1 })]
        public void PalSeq_ShouldReturn(int n, int[] expected)
        {
            // Arrange

            // Act
            var actual = veryHardExercises.PalSeq(n);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, "invalid")]
        [InlineData(3, "b, a, ab")]
        [InlineData(7, "b, a, ab, aba, abaab, abaababa, abaababaabaab")]
        [InlineData(10, "b, a, ab, aba, abaab, abaababa, abaababaabaab, abaababaabaababaababa, abaababaabaababaababaabaababaabaab, abaababaabaababaababaabaababaabaababaababaabaababaababa")]
        [InlineData(15, "b, a, ab, aba, abaab, abaababa, abaababaabaab, abaababaabaababaababa, abaababaabaababaababaabaababaabaab, abaababaabaababaababaabaababaabaababaababaabaababaababa, abaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaab, abaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaababa, abaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaab, abaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaababa, abaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaab")]
        public void FiboWord_ShouldReturn(int num, string expected)
        {
            // Arrange

            // Act
            var actual = veryHardExercises.FiboWord(num);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("Piccolo", "A3", false)]
        [InlineData("Violin", "G6", true)]
        [InlineData("Piano", "C8", true)]
        [InlineData("Piano", "C9", false)]
        [InlineData("Tuba", "C8", false)]
        [InlineData("Guitar", "F4", true)]
        [InlineData("Guitar", "C4", true)]
        [InlineData("Piccolo", "F4", true)]
        [InlineData("Tuba", "F6", false)]
        public void InstrumentRange_ShouldReturn(string instr, string note, bool expected)
        {
            // Arrange

            // Act
            var actual = veryHardExercises.InstrumentRange(instr, note);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(3, 20)]
        [InlineData(5, 104)]
        [InlineData(7, 300)]
        [InlineData(9, 656)]
        [InlineData(11, 1220)]
        [InlineData(13, 2040)]
        [InlineData(15, 3164)]
        [InlineData(17, 4640)]
        [InlineData(19, 6516)]
        [InlineData(21, 8840)]
        [InlineData(23, 11660)]
        [InlineData(25, 15024)]
        [InlineData(27, 18980)]
        [InlineData(29, 23576)]
        [InlineData(31, 28860)]
        [InlineData(33, 34880)]
        [InlineData(35, 41684)]
        [InlineData(37, 49320)]
        [InlineData(39, 57836)]
        [InlineData(41, 67280)]
        [InlineData(43, 77700)]
        [InlineData(45, 89144)]
        [InlineData(47, 101660)]
        [InlineData(49, 115296)]
        [InlineData(51, 130100)]
        public void DiamondSum_ShouldReturn(int n, int expected)
        {
            // Arrange

            // Act
            var actual = veryHardExercises.DiamondSum(n);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("Zebediah", 1, "Bob Jim Becky Pat", 100)]
        [InlineData("Eric", 2, "Adam Caroline Rebecca Frank", 40)]
        [InlineData("Aaron", 3, "Jane Max Olivia Sam", 20)]
        [InlineData("Zebediah", 4, "Bob Jim Becky Pat", 40)]
        [InlineData("Zebediah", 5, "Bob Jim Becky Pat", 20)]
        public void License_ShouldReturn(string me, int agents, string others, int expected)
        {
            // Arrange

            // Act
            var actual = veryHardExercises.License(me, agents, others);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("car", "race", true)]
        [InlineData("nod", "done", true)]
        [InlineData("bag", "grab", false)]
        [InlineData("sap", "spatula", true)]
        [InlineData("sat", "spatula", false)]
        [InlineData("vein", "universal", true)]
        [InlineData("salt", "universal", false)]
        [InlineData("roast", "pastoral", true)]
        [InlineData("altar", "pastoral", false)]
        public void AnagramStrStr_ShouldReturn(string needle, string haystack, bool expected)
        {
            // Arrange

            // Act
            var actual = veryHardExercises.AnagramStrStr(needle, haystack);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("hello world", "dehll loorw")]
        [InlineData("edabit is awesome", "aabdee ei imosstw")]
        [InlineData("have a nice day", "aaac d eehi nvy")]
        [InlineData("i love to code", "c deei lo ootv")]
        [InlineData("joshua senoron", "aehjnn ooorssu")]
        public void TrueAlphabetic_ShouldReturn(string str, string expected)
        {
            // Arrange

            // Act
            var actual = veryHardExercises.TrueAlphabetic(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UniqueFract_ShouldReturn()
        {
            // Arrange

            // Act and Assert
            Assert.Equal(13.5, veryHardExercises.UniqueFract());
        }

        [Theory]
        [InlineData("P1zz@", false)]
        [InlineData("P1zz@P1zz@P1zz@P1zz@P1zz@", false)]
        [InlineData("mypassword11", false)]
        [InlineData("MYPASSWORD11", false)]
        [InlineData("iLoveYou", false)]
        [InlineData("Pè7$areLove", false)]
        [InlineData("Repeeea7!", false)]
        [InlineData("H4(k+x0", true)]
        [InlineData("Fhg93@", true)]
        [InlineData("aA0!@#$%^&*()+=_-{}[]:;\"", true)]
        [InlineData("zZ9'?<>,.", true)]
        public void ValidatePassword_ShouldReturn(string str, bool expected)
        {
            // Arrange

            // Act
            var actual = veryHardExercises.ValidatePassword(str);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("foo", "foo1")]
        [InlineData("foobar01002", "foobar01003")]
        [InlineData("foobar00599", "foobar00600")]
        [InlineData("foo099", "foo100")]
        [InlineData("foo09999", "foo10000")]
        [InlineData("foo9999", "foo10000")]
        public void IncrementString_ShouldReturn(string str, string expected)
        {
            // Arrange

            // Act
            var actual = veryHardExercises.IncrementString(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("abcdefghijklmnopqrstuvwxy", "z")]
        [InlineData("abcdefghijklmnopqrstuvwxyz", "")]
        [InlineData("aabbccddeeffgghhiijjkkllmmnnooppqqrrssttuuvvwwxxyy", "zz")]
        [InlineData("abbccddeeffgghhiijjkkllmmnnooppqqrrssttuuvvwwxxy", "ayzz")]
        [InlineData("edabit", "cfghjklmnopqrsuvwxyz")]
        [InlineData("aaaabbbbccccddddeeeeffffgggghhhhiiiijjjjkkkkllllmmmmnnnnooooppppqqqqrrrrssssttttuuuuvvvvwwwwxxxxyyyyzzzz", "")]
        [InlineData("mubashir", "cdefgjklnopqtvwxyz")]
        [InlineData("aaaa", "bbbbccccddddeeeeffffgggghhhhiiiijjjjkkkkllllmmmmnnnnooooppppqqqqrrrrssssttttuuuuvvvvwwwwxxxxyyyyzzzz")]
        public void MissingAlphabets_ShouldReturn(string str, string expected)
        {
            // Arrange

            // Act
            var actual = veryHardExercises.MissingAlphabets(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("AB", "AB BA")]
        [InlineData("CD", "CD DC")]
        [InlineData("EF", "EF FE")]
        [InlineData("NOT", "NOT NTO ONT OTN TNO TON")]
        [InlineData("RAM", "AMR ARM MAR MRA RAM RMA")]
        [InlineData("YAW", "AWY AYW WAY WYA YAW YWA")]
        [InlineData("FELT", "EFLT EFTL ELFT ELTF ETFL ETLF FELT FETL FLET FLTE FTEL FTLE LEFT LETF LFET LFTE LTEF LTFE TEFL TELF TFEL TFLE TLEF TLFE")]
        [InlineData("LURE", "ELRU ELUR ERLU ERUL EULR EURL LERU LEUR LREU LRUE LUER LURE RELU REUL RLEU RLUE RUEL RULE UELR UERL ULER ULRE UREL URLE")]
        [InlineData("ROME", "EMOR EMRO EOMR EORM ERMO EROM MEOR MERO MOER MORE MREO MROE OEMR OERM OMER OMRE OREM ORME REMO REOM RMEO RMOE ROEM ROME")]
        [InlineData("COAST", "ACOST ACOTS ACSOT ACSTO ACTOS ACTSO AOCST AOCTS AOSCT AOSTC AOTCS AOTSC ASCOT ASCTO ASOCT ASOTC ASTCO ASTOC ATCOS ATCSO ATOCS ATOSC ATSCO ATSOC CAOST CAOTS CASOT CASTO CATOS CATSO COAST COATS COSAT COSTA COTAS COTSA CSAOT CSATO CSOAT CSOTA CSTAO CSTOA CTAOS CTASO CTOAS CTOSA CTSAO CTSOA OACST OACTS OASCT OASTC OATCS OATSC OCAST OCATS OCSAT OCSTA OCTAS OCTSA OSACT OSATC OSCAT OSCTA OSTAC OSTCA OTACS OTASC OTCAS OTCSA OTSAC OTSCA SACOT SACTO SAOCT SAOTC SATCO SATOC SCAOT SCATO SCOAT SCOTA SCTAO SCTOA SOACT SOATC SOCAT SOCTA SOTAC SOTCA STACO STAOC STCAO STCOA STOAC STOCA TACOS TACSO TAOCS TAOSC TASCO TASOC TCAOS TCASO TCOAS TCOSA TCSAO TCSOA TOACS TOASC TOCAS TOCSA TOSAC TOSCA TSACO TSAOC TSCAO TSCOA TSOAC TSOCA")]
        [InlineData("SKATE", "AEKST AEKTS AESKT AESTK AETKS AETSK AKEST AKETS AKSET AKSTE AKTES AKTSE ASEKT ASETK ASKET ASKTE ASTEK ASTKE ATEKS ATESK ATKES ATKSE ATSEK ATSKE EAKST EAKTS EASKT EASTK EATKS EATSK EKAST EKATS EKSAT EKSTA EKTAS EKTSA ESAKT ESATK ESKAT ESKTA ESTAK ESTKA ETAKS ETASK ETKAS ETKSA ETSAK ETSKA KAEST KAETS KASET KASTE KATES KATSE KEAST KEATS KESAT KESTA KETAS KETSA KSAET KSATE KSEAT KSETA KSTAE KSTEA KTAES KTASE KTEAS KTESA KTSAE KTSEA SAEKT SAETK SAKET SAKTE SATEK SATKE SEAKT SEATK SEKAT SEKTA SETAK SETKA SKAET SKATE SKEAT SKETA SKTAE SKTEA STAEK STAKE STEAK STEKA STKAE STKEA TAEKS TAESK TAKES TAKSE TASEK TASKE TEAKS TEASK TEKAS TEKSA TESAK TESKA TKAES TKASE TKEAS TKESA TKSAE TKSEA TSAEK TSAKE TSEAK TSEKA TSKAE TSKEA")]
        [InlineData("RITES", "EIRST EIRTS EISRT EISTR EITRS EITSR ERIST ERITS ERSIT ERSTI ERTIS ERTSI ESIRT ESITR ESRIT ESRTI ESTIR ESTRI ETIRS ETISR ETRIS ETRSI ETSIR ETSRI IERST IERTS IESRT IESTR IETRS IETSR IREST IRETS IRSET IRSTE IRTES IRTSE ISERT ISETR ISRET ISRTE ISTER ISTRE ITERS ITESR ITRES ITRSE ITSER ITSRE REIST REITS RESIT RESTI RETIS RETSI RIEST RIETS RISET RISTE RITES RITSE RSEIT RSETI RSIET RSITE RSTEI RSTIE RTEIS RTESI RTIES RTISE RTSEI RTSIE SEIRT SEITR SERIT SERTI SETIR SETRI SIERT SIETR SIRET SIRTE SITER SITRE SREIT SRETI SRIET SRITE SRTEI SRTIE STEIR STERI STIER STIRE STREI STRIE TEIRS TEISR TERIS TERSI TESIR TESRI TIERS TIESR TIRES TIRSE TISER TISRE TREIS TRESI TRIES TRISE TRSEI TRSIE TSEIR TSERI TSIER TSIRE TSREI TSRIE")]
        [InlineData("POOLED", "DELOOP DELOOP DELOPO DELOPO DELPOO DELPOO DEOLOP DEOLOP DEOLPO DEOLPO DEOOLP DEOOLP DEOOPL DEOOPL DEOPLO DEOPLO DEOPOL DEOPOL DEPLOO DEPLOO DEPOLO DEPOLO DEPOOL DEPOOL DLEOOP DLEOOP DLEOPO DLEOPO DLEPOO DLEPOO DLOEOP DLOEOP DLOEPO DLOEPO DLOOEP DLOOEP DLOOPE DLOOPE DLOPEO DLOPEO DLOPOE DLOPOE DLPEOO DLPEOO DLPOEO DLPOEO DLPOOE DLPOOE DOELOP DOELOP DOELPO DOELPO DOEOLP DOEOLP DOEOPL DOEOPL DOEPLO DOEPLO DOEPOL DOEPOL DOLEOP DOLEOP DOLEPO DOLEPO DOLOEP DOLOEP DOLOPE DOLOPE DOLPEO DOLPEO DOLPOE DOLPOE DOOELP DOOELP DOOEPL DOOEPL DOOLEP DOOLEP DOOLPE DOOLPE DOOPEL DOOPEL DOOPLE DOOPLE DOPELO DOPELO DOPEOL DOPEOL DOPLEO DOPLEO DOPLOE DOPLOE DOPOEL DOPOEL DOPOLE DOPOLE DPELOO DPELOO DPEOLO DPEOLO DPEOOL DPEOOL DPLEOO DPLEOO DPLOEO DPLOEO DPLOOE DPLOOE DPOELO DPOELO DPOEOL DPOEOL DPOLEO DPOLEO DPOLOE DPOLOE DPOOEL DPOOEL DPOOLE DPOOLE EDLOOP EDLOOP EDLOPO EDLOPO EDLPOO EDLPOO EDOLOP EDOLOP EDOLPO EDOLPO EDOOLP EDOOLP EDOOPL EDOOPL EDOPLO EDOPLO EDOPOL EDOPOL EDPLOO EDPLOO EDPOLO EDPOLO EDPOOL EDPOOL ELDOOP ELDOOP ELDOPO ELDOPO ELDPOO ELDPOO ELODOP ELODOP ELODPO ELODPO ELOODP ELOODP ELOOPD ELOOPD ELOPDO ELOPDO ELOPOD ELOPOD ELPDOO ELPDOO ELPODO ELPODO ELPOOD ELPOOD EODLOP EODLOP EODLPO EODLPO EODOLP EODOLP EODOPL EODOPL EODPLO EODPLO EODPOL EODPOL EOLDOP EOLDOP EOLDPO EOLDPO EOLODP EOLODP EOLOPD EOLOPD EOLPDO EOLPDO EOLPOD EOLPOD EOODLP EOODLP EOODPL EOODPL EOOLDP EOOLDP EOOLPD EOOLPD EOOPDL EOOPDL EOOPLD EOOPLD EOPDLO EOPDLO EOPDOL EOPDOL EOPLDO EOPLDO EOPLOD EOPLOD EOPODL EOPODL EOPOLD EOPOLD EPDLOO EPDLOO EPDOLO EPDOLO EPDOOL EPDOOL EPLDOO EPLDOO EPLODO EPLODO EPLOOD EPLOOD EPODLO EPODLO EPODOL EPODOL EPOLDO EPOLDO EPOLOD EPOLOD EPOODL EPOODL EPOOLD EPOOLD LDEOOP LDEOOP LDEOPO LDEOPO LDEPOO LDEPOO LDOEOP LDOEOP LDOEPO LDOEPO LDOOEP LDOOEP LDOOPE LDOOPE LDOPEO LDOPEO LDOPOE LDOPOE LDPEOO LDPEOO LDPOEO LDPOEO LDPOOE LDPOOE LEDOOP LEDOOP LEDOPO LEDOPO LEDPOO LEDPOO LEODOP LEODOP LEODPO LEODPO LEOODP LEOODP LEOOPD LEOOPD LEOPDO LEOPDO LEOPOD LEOPOD LEPDOO LEPDOO LEPODO LEPODO LEPOOD LEPOOD LODEOP LODEOP LODEPO LODEPO LODOEP LODOEP LODOPE LODOPE LODPEO LODPEO LODPOE LODPOE LOEDOP LOEDOP LOEDPO LOEDPO LOEODP LOEODP LOEOPD LOEOPD LOEPDO LOEPDO LOEPOD LOEPOD LOODEP LOODEP LOODPE LOODPE LOOEDP LOOEDP LOOEPD LOOEPD LOOPDE LOOPDE LOOPED LOOPED LOPDEO LOPDEO LOPDOE LOPDOE LOPEDO LOPEDO LOPEOD LOPEOD LOPODE LOPODE LOPOED LOPOED LPDEOO LPDEOO LPDOEO LPDOEO LPDOOE LPDOOE LPEDOO LPEDOO LPEODO LPEODO LPEOOD LPEOOD LPODEO LPODEO LPODOE LPODOE LPOEDO LPOEDO LPOEOD LPOEOD LPOODE LPOODE LPOOED LPOOED ODELOP ODELOP ODELPO ODELPO ODEOLP ODEOLP ODEOPL ODEOPL ODEPLO ODEPLO ODEPOL ODEPOL ODLEOP ODLEOP ODLEPO ODLEPO ODLOEP ODLOEP ODLOPE ODLOPE ODLPEO ODLPEO ODLPOE ODLPOE ODOELP ODOELP ODOEPL ODOEPL ODOLEP ODOLEP ODOLPE ODOLPE ODOPEL ODOPEL ODOPLE ODOPLE ODPELO ODPELO ODPEOL ODPEOL ODPLEO ODPLEO ODPLOE ODPLOE ODPOEL ODPOEL ODPOLE ODPOLE OEDLOP OEDLOP OEDLPO OEDLPO OEDOLP OEDOLP OEDOPL OEDOPL OEDPLO OEDPLO OEDPOL OEDPOL OELDOP OELDOP OELDPO OELDPO OELODP OELODP OELOPD OELOPD OELPDO OELPDO OELPOD OELPOD OEODLP OEODLP OEODPL OEODPL OEOLDP OEOLDP OEOLPD OEOLPD OEOPDL OEOPDL OEOPLD OEOPLD OEPDLO OEPDLO OEPDOL OEPDOL OEPLDO OEPLDO OEPLOD OEPLOD OEPODL OEPODL OEPOLD OEPOLD OLDEOP OLDEOP OLDEPO OLDEPO OLDOEP OLDOEP OLDOPE OLDOPE OLDPEO OLDPEO OLDPOE OLDPOE OLEDOP OLEDOP OLEDPO OLEDPO OLEODP OLEODP OLEOPD OLEOPD OLEPDO OLEPDO OLEPOD OLEPOD OLODEP OLODEP OLODPE OLODPE OLOEDP OLOEDP OLOEPD OLOEPD OLOPDE OLOPDE OLOPED OLOPED OLPDEO OLPDEO OLPDOE OLPDOE OLPEDO OLPEDO OLPEOD OLPEOD OLPODE OLPODE OLPOED OLPOED OODELP OODELP OODEPL OODEPL OODLEP OODLEP OODLPE OODLPE OODPEL OODPEL OODPLE OODPLE OOEDLP OOEDLP OOEDPL OOEDPL OOELDP OOELDP OOELPD OOELPD OOEPDL OOEPDL OOEPLD OOEPLD OOLDEP OOLDEP OOLDPE OOLDPE OOLEDP OOLEDP OOLEPD OOLEPD OOLPDE OOLPDE OOLPED OOLPED OOPDEL OOPDEL OOPDLE OOPDLE OOPEDL OOPEDL OOPELD OOPELD OOPLDE OOPLDE OOPLED OOPLED OPDELO OPDELO OPDEOL OPDEOL OPDLEO OPDLEO OPDLOE OPDLOE OPDOEL OPDOEL OPDOLE OPDOLE OPEDLO OPEDLO OPEDOL OPEDOL OPELDO OPELDO OPELOD OPELOD OPEODL OPEODL OPEOLD OPEOLD OPLDEO OPLDEO OPLDOE OPLDOE OPLEDO OPLEDO OPLEOD OPLEOD OPLODE OPLODE OPLOED OPLOED OPODEL OPODEL OPODLE OPODLE OPOEDL OPOEDL OPOELD OPOELD OPOLDE OPOLDE OPOLED OPOLED PDELOO PDELOO PDEOLO PDEOLO PDEOOL PDEOOL PDLEOO PDLEOO PDLOEO PDLOEO PDLOOE PDLOOE PDOELO PDOELO PDOEOL PDOEOL PDOLEO PDOLEO PDOLOE PDOLOE PDOOEL PDOOEL PDOOLE PDOOLE PEDLOO PEDLOO PEDOLO PEDOLO PEDOOL PEDOOL PELDOO PELDOO PELODO PELODO PELOOD PELOOD PEODLO PEODLO PEODOL PEODOL PEOLDO PEOLDO PEOLOD PEOLOD PEOODL PEOODL PEOOLD PEOOLD PLDEOO PLDEOO PLDOEO PLDOEO PLDOOE PLDOOE PLEDOO PLEDOO PLEODO PLEODO PLEOOD PLEOOD PLODEO PLODEO PLODOE PLODOE PLOEDO PLOEDO PLOEOD PLOEOD PLOODE PLOODE PLOOED PLOOED PODELO PODELO PODEOL PODEOL PODLEO PODLEO PODLOE PODLOE PODOEL PODOEL PODOLE PODOLE POEDLO POEDLO POEDOL POEDOL POELDO POELDO POELOD POELOD POEODL POEODL POEOLD POEOLD POLDEO POLDEO POLDOE POLDOE POLEDO POLEDO POLEOD POLEOD POLODE POLODE POLOED POLOED POODEL POODEL POODLE POODLE POOEDL POOEDL POOELD POOELD POOLDE POOLDE POOLED POOLED")]
        [InlineData("TRANCE", "ACENRT ACENTR ACERNT ACERTN ACETNR ACETRN ACNERT ACNETR ACNRET ACNRTE ACNTER ACNTRE ACRENT ACRETN ACRNET ACRNTE ACRTEN ACRTNE ACTENR ACTERN ACTNER ACTNRE ACTREN ACTRNE AECNRT AECNTR AECRNT AECRTN AECTNR AECTRN AENCRT AENCTR AENRCT AENRTC AENTCR AENTRC AERCNT AERCTN AERNCT AERNTC AERTCN AERTNC AETCNR AETCRN AETNCR AETNRC AETRCN AETRNC ANCERT ANCETR ANCRET ANCRTE ANCTER ANCTRE ANECRT ANECTR ANERCT ANERTC ANETCR ANETRC ANRCET ANRCTE ANRECT ANRETC ANRTCE ANRTEC ANTCER ANTCRE ANTECR ANTERC ANTRCE ANTREC ARCENT ARCETN ARCNET ARCNTE ARCTEN ARCTNE ARECNT ARECTN ARENCT ARENTC ARETCN ARETNC ARNCET ARNCTE ARNECT ARNETC ARNTCE ARNTEC ARTCEN ARTCNE ARTECN ARTENC ARTNCE ARTNEC ATCENR ATCERN ATCNER ATCNRE ATCREN ATCRNE ATECNR ATECRN ATENCR ATENRC ATERCN ATERNC ATNCER ATNCRE ATNECR ATNERC ATNRCE ATNREC ATRCEN ATRCNE ATRECN ATRENC ATRNCE ATRNEC CAENRT CAENTR CAERNT CAERTN CAETNR CAETRN CANERT CANETR CANRET CANRTE CANTER CANTRE CARENT CARETN CARNET CARNTE CARTEN CARTNE CATENR CATERN CATNER CATNRE CATREN CATRNE CEANRT CEANTR CEARNT CEARTN CEATNR CEATRN CENART CENATR CENRAT CENRTA CENTAR CENTRA CERANT CERATN CERNAT CERNTA CERTAN CERTNA CETANR CETARN CETNAR CETNRA CETRAN CETRNA CNAERT CNAETR CNARET CNARTE CNATER CNATRE CNEART CNEATR CNERAT CNERTA CNETAR CNETRA CNRAET CNRATE CNREAT CNRETA CNRTAE CNRTEA CNTAER CNTARE CNTEAR CNTERA CNTRAE CNTREA CRAENT CRAETN CRANET CRANTE CRATEN CRATNE CREANT CREATN CRENAT CRENTA CRETAN CRETNA CRNAET CRNATE CRNEAT CRNETA CRNTAE CRNTEA CRTAEN CRTANE CRTEAN CRTENA CRTNAE CRTNEA CTAENR CTAERN CTANER CTANRE CTAREN CTARNE CTEANR CTEARN CTENAR CTENRA CTERAN CTERNA CTNAER CTNARE CTNEAR CTNERA CTNRAE CTNREA CTRAEN CTRANE CTREAN CTRENA CTRNAE CTRNEA EACNRT EACNTR EACRNT EACRTN EACTNR EACTRN EANCRT EANCTR EANRCT EANRTC EANTCR EANTRC EARCNT EARCTN EARNCT EARNTC EARTCN EARTNC EATCNR EATCRN EATNCR EATNRC EATRCN EATRNC ECANRT ECANTR ECARNT ECARTN ECATNR ECATRN ECNART ECNATR ECNRAT ECNRTA ECNTAR ECNTRA ECRANT ECRATN ECRNAT ECRNTA ECRTAN ECRTNA ECTANR ECTARN ECTNAR ECTNRA ECTRAN ECTRNA ENACRT ENACTR ENARCT ENARTC ENATCR ENATRC ENCART ENCATR ENCRAT ENCRTA ENCTAR ENCTRA ENRACT ENRATC ENRCAT ENRCTA ENRTAC ENRTCA ENTACR ENTARC ENTCAR ENTCRA ENTRAC ENTRCA ERACNT ERACTN ERANCT ERANTC ERATCN ERATNC ERCANT ERCATN ERCNAT ERCNTA ERCTAN ERCTNA ERNACT ERNATC ERNCAT ERNCTA ERNTAC ERNTCA ERTACN ERTANC ERTCAN ERTCNA ERTNAC ERTNCA ETACNR ETACRN ETANCR ETANRC ETARCN ETARNC ETCANR ETCARN ETCNAR ETCNRA ETCRAN ETCRNA ETNACR ETNARC ETNCAR ETNCRA ETNRAC ETNRCA ETRACN ETRANC ETRCAN ETRCNA ETRNAC ETRNCA NACERT NACETR NACRET NACRTE NACTER NACTRE NAECRT NAECTR NAERCT NAERTC NAETCR NAETRC NARCET NARCTE NARECT NARETC NARTCE NARTEC NATCER NATCRE NATECR NATERC NATRCE NATREC NCAERT NCAETR NCARET NCARTE NCATER NCATRE NCEART NCEATR NCERAT NCERTA NCETAR NCETRA NCRAET NCRATE NCREAT NCRETA NCRTAE NCRTEA NCTAER NCTARE NCTEAR NCTERA NCTRAE NCTREA NEACRT NEACTR NEARCT NEARTC NEATCR NEATRC NECART NECATR NECRAT NECRTA NECTAR NECTRA NERACT NERATC NERCAT NERCTA NERTAC NERTCA NETACR NETARC NETCAR NETCRA NETRAC NETRCA NRACET NRACTE NRAECT NRAETC NRATCE NRATEC NRCAET NRCATE NRCEAT NRCETA NRCTAE NRCTEA NREACT NREATC NRECAT NRECTA NRETAC NRETCA NRTACE NRTAEC NRTCAE NRTCEA NRTEAC NRTECA NTACER NTACRE NTAECR NTAERC NTARCE NTAREC NTCAER NTCARE NTCEAR NTCERA NTCRAE NTCREA NTEACR NTEARC NTECAR NTECRA NTERAC NTERCA NTRACE NTRAEC NTRCAE NTRCEA NTREAC NTRECA RACENT RACETN RACNET RACNTE RACTEN RACTNE RAECNT RAECTN RAENCT RAENTC RAETCN RAETNC RANCET RANCTE RANECT RANETC RANTCE RANTEC RATCEN RATCNE RATECN RATENC RATNCE RATNEC RCAENT RCAETN RCANET RCANTE RCATEN RCATNE RCEANT RCEATN RCENAT RCENTA RCETAN RCETNA RCNAET RCNATE RCNEAT RCNETA RCNTAE RCNTEA RCTAEN RCTANE RCTEAN RCTENA RCTNAE RCTNEA REACNT REACTN REANCT REANTC REATCN REATNC RECANT RECATN RECNAT RECNTA RECTAN RECTNA RENACT RENATC RENCAT RENCTA RENTAC RENTCA RETACN RETANC RETCAN RETCNA RETNAC RETNCA RNACET RNACTE RNAECT RNAETC RNATCE RNATEC RNCAET RNCATE RNCEAT RNCETA RNCTAE RNCTEA RNEACT RNEATC RNECAT RNECTA RNETAC RNETCA RNTACE RNTAEC RNTCAE RNTCEA RNTEAC RNTECA RTACEN RTACNE RTAECN RTAENC RTANCE RTANEC RTCAEN RTCANE RTCEAN RTCENA RTCNAE RTCNEA RTEACN RTEANC RTECAN RTECNA RTENAC RTENCA RTNACE RTNAEC RTNCAE RTNCEA RTNEAC RTNECA TACENR TACERN TACNER TACNRE TACREN TACRNE TAECNR TAECRN TAENCR TAENRC TAERCN TAERNC TANCER TANCRE TANECR TANERC TANRCE TANREC TARCEN TARCNE TARECN TARENC TARNCE TARNEC TCAENR TCAERN TCANER TCANRE TCAREN TCARNE TCEANR TCEARN TCENAR TCENRA TCERAN TCERNA TCNAER TCNARE TCNEAR TCNERA TCNRAE TCNREA TCRAEN TCRANE TCREAN TCRENA TCRNAE TCRNEA TEACNR TEACRN TEANCR TEANRC TEARCN TEARNC TECANR TECARN TECNAR TECNRA TECRAN TECRNA TENACR TENARC TENCAR TENCRA TENRAC TENRCA TERACN TERANC TERCAN TERCNA TERNAC TERNCA TNACER TNACRE TNAECR TNAERC TNARCE TNAREC TNCAER TNCARE TNCEAR TNCERA TNCRAE TNCREA TNEACR TNEARC TNECAR TNECRA TNERAC TNERCA TNRACE TNRAEC TNRCAE TNRCEA TNREAC TNRECA TRACEN TRACNE TRAECN TRAENC TRANCE TRANEC TRCAEN TRCANE TRCEAN TRCENA TRCNAE TRCNEA TREACN TREANC TRECAN TRECNA TRENAC TRENCA TRNACE TRNAEC TRNCAE TRNCEA TRNEAC TRNECA")]
        [InlineData("ASCENT", "ACENST ACENTS ACESNT ACESTN ACETNS ACETSN ACNEST ACNETS ACNSET ACNSTE ACNTES ACNTSE ACSENT ACSETN ACSNET ACSNTE ACSTEN ACSTNE ACTENS ACTESN ACTNES ACTNSE ACTSEN ACTSNE AECNST AECNTS AECSNT AECSTN AECTNS AECTSN AENCST AENCTS AENSCT AENSTC AENTCS AENTSC AESCNT AESCTN AESNCT AESNTC AESTCN AESTNC AETCNS AETCSN AETNCS AETNSC AETSCN AETSNC ANCEST ANCETS ANCSET ANCSTE ANCTES ANCTSE ANECST ANECTS ANESCT ANESTC ANETCS ANETSC ANSCET ANSCTE ANSECT ANSETC ANSTCE ANSTEC ANTCES ANTCSE ANTECS ANTESC ANTSCE ANTSEC ASCENT ASCETN ASCNET ASCNTE ASCTEN ASCTNE ASECNT ASECTN ASENCT ASENTC ASETCN ASETNC ASNCET ASNCTE ASNECT ASNETC ASNTCE ASNTEC ASTCEN ASTCNE ASTECN ASTENC ASTNCE ASTNEC ATCENS ATCESN ATCNES ATCNSE ATCSEN ATCSNE ATECNS ATECSN ATENCS ATENSC ATESCN ATESNC ATNCES ATNCSE ATNECS ATNESC ATNSCE ATNSEC ATSCEN ATSCNE ATSECN ATSENC ATSNCE ATSNEC CAENST CAENTS CAESNT CAESTN CAETNS CAETSN CANEST CANETS CANSET CANSTE CANTES CANTSE CASENT CASETN CASNET CASNTE CASTEN CASTNE CATENS CATESN CATNES CATNSE CATSEN CATSNE CEANST CEANTS CEASNT CEASTN CEATNS CEATSN CENAST CENATS CENSAT CENSTA CENTAS CENTSA CESANT CESATN CESNAT CESNTA CESTAN CESTNA CETANS CETASN CETNAS CETNSA CETSAN CETSNA CNAEST CNAETS CNASET CNASTE CNATES CNATSE CNEAST CNEATS CNESAT CNESTA CNETAS CNETSA CNSAET CNSATE CNSEAT CNSETA CNSTAE CNSTEA CNTAES CNTASE CNTEAS CNTESA CNTSAE CNTSEA CSAENT CSAETN CSANET CSANTE CSATEN CSATNE CSEANT CSEATN CSENAT CSENTA CSETAN CSETNA CSNAET CSNATE CSNEAT CSNETA CSNTAE CSNTEA CSTAEN CSTANE CSTEAN CSTENA CSTNAE CSTNEA CTAENS CTAESN CTANES CTANSE CTASEN CTASNE CTEANS CTEASN CTENAS CTENSA CTESAN CTESNA CTNAES CTNASE CTNEAS CTNESA CTNSAE CTNSEA CTSAEN CTSANE CTSEAN CTSENA CTSNAE CTSNEA EACNST EACNTS EACSNT EACSTN EACTNS EACTSN EANCST EANCTS EANSCT EANSTC EANTCS EANTSC EASCNT EASCTN EASNCT EASNTC EASTCN EASTNC EATCNS EATCSN EATNCS EATNSC EATSCN EATSNC ECANST ECANTS ECASNT ECASTN ECATNS ECATSN ECNAST ECNATS ECNSAT ECNSTA ECNTAS ECNTSA ECSANT ECSATN ECSNAT ECSNTA ECSTAN ECSTNA ECTANS ECTASN ECTNAS ECTNSA ECTSAN ECTSNA ENACST ENACTS ENASCT ENASTC ENATCS ENATSC ENCAST ENCATS ENCSAT ENCSTA ENCTAS ENCTSA ENSACT ENSATC ENSCAT ENSCTA ENSTAC ENSTCA ENTACS ENTASC ENTCAS ENTCSA ENTSAC ENTSCA ESACNT ESACTN ESANCT ESANTC ESATCN ESATNC ESCANT ESCATN ESCNAT ESCNTA ESCTAN ESCTNA ESNACT ESNATC ESNCAT ESNCTA ESNTAC ESNTCA ESTACN ESTANC ESTCAN ESTCNA ESTNAC ESTNCA ETACNS ETACSN ETANCS ETANSC ETASCN ETASNC ETCANS ETCASN ETCNAS ETCNSA ETCSAN ETCSNA ETNACS ETNASC ETNCAS ETNCSA ETNSAC ETNSCA ETSACN ETSANC ETSCAN ETSCNA ETSNAC ETSNCA NACEST NACETS NACSET NACSTE NACTES NACTSE NAECST NAECTS NAESCT NAESTC NAETCS NAETSC NASCET NASCTE NASECT NASETC NASTCE NASTEC NATCES NATCSE NATECS NATESC NATSCE NATSEC NCAEST NCAETS NCASET NCASTE NCATES NCATSE NCEAST NCEATS NCESAT NCESTA NCETAS NCETSA NCSAET NCSATE NCSEAT NCSETA NCSTAE NCSTEA NCTAES NCTASE NCTEAS NCTESA NCTSAE NCTSEA NEACST NEACTS NEASCT NEASTC NEATCS NEATSC NECAST NECATS NECSAT NECSTA NECTAS NECTSA NESACT NESATC NESCAT NESCTA NESTAC NESTCA NETACS NETASC NETCAS NETCSA NETSAC NETSCA NSACET NSACTE NSAECT NSAETC NSATCE NSATEC NSCAET NSCATE NSCEAT NSCETA NSCTAE NSCTEA NSEACT NSEATC NSECAT NSECTA NSETAC NSETCA NSTACE NSTAEC NSTCAE NSTCEA NSTEAC NSTECA NTACES NTACSE NTAECS NTAESC NTASCE NTASEC NTCAES NTCASE NTCEAS NTCESA NTCSAE NTCSEA NTEACS NTEASC NTECAS NTECSA NTESAC NTESCA NTSACE NTSAEC NTSCAE NTSCEA NTSEAC NTSECA SACENT SACETN SACNET SACNTE SACTEN SACTNE SAECNT SAECTN SAENCT SAENTC SAETCN SAETNC SANCET SANCTE SANECT SANETC SANTCE SANTEC SATCEN SATCNE SATECN SATENC SATNCE SATNEC SCAENT SCAETN SCANET SCANTE SCATEN SCATNE SCEANT SCEATN SCENAT SCENTA SCETAN SCETNA SCNAET SCNATE SCNEAT SCNETA SCNTAE SCNTEA SCTAEN SCTANE SCTEAN SCTENA SCTNAE SCTNEA SEACNT SEACTN SEANCT SEANTC SEATCN SEATNC SECANT SECATN SECNAT SECNTA SECTAN SECTNA SENACT SENATC SENCAT SENCTA SENTAC SENTCA SETACN SETANC SETCAN SETCNA SETNAC SETNCA SNACET SNACTE SNAECT SNAETC SNATCE SNATEC SNCAET SNCATE SNCEAT SNCETA SNCTAE SNCTEA SNEACT SNEATC SNECAT SNECTA SNETAC SNETCA SNTACE SNTAEC SNTCAE SNTCEA SNTEAC SNTECA STACEN STACNE STAECN STAENC STANCE STANEC STCAEN STCANE STCEAN STCENA STCNAE STCNEA STEACN STEANC STECAN STECNA STENAC STENCA STNACE STNAEC STNCAE STNCEA STNEAC STNECA TACENS TACESN TACNES TACNSE TACSEN TACSNE TAECNS TAECSN TAENCS TAENSC TAESCN TAESNC TANCES TANCSE TANECS TANESC TANSCE TANSEC TASCEN TASCNE TASECN TASENC TASNCE TASNEC TCAENS TCAESN TCANES TCANSE TCASEN TCASNE TCEANS TCEASN TCENAS TCENSA TCESAN TCESNA TCNAES TCNASE TCNEAS TCNESA TCNSAE TCNSEA TCSAEN TCSANE TCSEAN TCSENA TCSNAE TCSNEA TEACNS TEACSN TEANCS TEANSC TEASCN TEASNC TECANS TECASN TECNAS TECNSA TECSAN TECSNA TENACS TENASC TENCAS TENCSA TENSAC TENSCA TESACN TESANC TESCAN TESCNA TESNAC TESNCA TNACES TNACSE TNAECS TNAESC TNASCE TNASEC TNCAES TNCASE TNCEAS TNCESA TNCSAE TNCSEA TNEACS TNEASC TNECAS TNECSA TNESAC TNESCA TNSACE TNSAEC TNSCAE TNSCEA TNSEAC TNSECA TSACEN TSACNE TSAECN TSAENC TSANCE TSANEC TSCAEN TSCANE TSCEAN TSCENA TSCNAE TSCNEA TSEACN TSEANC TSECAN TSECNA TSENAC TSENCA TSNACE TSNAEC TSNCAE TSNCEA TSNEAC TSNECA")]
        public void Permutations_ShouldReturn(string s, string expected)
        {
            // Arrange

            // Act
            var actual = veryHardExercises.Permutations(s);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 2, 1, 3, 4 }, new int[] { 3, 2, 2, 5 }, 6)]
        [InlineData(new int[] { 2, -9, 11, 5 }, new int[] { 5, -11, 2, 9 }, 10)]
        [InlineData(new int[] { -8, -7, 4, 7 }, new int[] { -5, -9, 4, 7 }, 5)]
        [InlineData(new int[] { -11, 2, 10, 4 }, new int[] { -8, 2, 4, 7 }, 16)]
        [InlineData(new int[] { -4, -6, 5, 7 }, new int[] { -2, -2, 5, 6 }, 9)]
        [InlineData(new int[] { -3, -3, 6, 6 }, new int[] { -1, -1, 2, 2 }, 4)]
        [InlineData(new int[] { 1, 1, 3, 3 }, new int[] { 4, 4, 2, 2 }, 0)]
        [InlineData(new int[] { 1, 1, 3, 2 }, new int[] { 4, 4, 2, 2 }, 0)]
        [InlineData(new int[] { 1, 1, 2, 2 }, new int[] { 4, 4, 2, 2 }, 0)]
        public void OverlappingRectangles_ShouldReturn(int[] rect1, int[] rect2, int expected)
        {
            // Arrange

            // Act
            var actual = veryHardExercises.OverlappingRectangles(rect1, rect2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Edabit", "Tibade")]
        [InlineData("UPPER lower", "REWOL reppu")]
        [InlineData("1 23 456", "6 54 321")]
        [InlineData("Hello World!", "!dlro Wolleh")]
        [InlineData("Where's your dog Daisy?", "?ysiadg odru oys 'erehw")]
        [InlineData("addition(3, 2) = 5", "5=)2,3(noit id d a")]
        [InlineData("It's known that CSS means Cascading Style Sheets", "Stee hsely tsgn IDA csacs Naemsscta Htnwo Nks'ti")]
        public void SpecialReverseString_ShouldReturn(string txt, string expected)
        {
            // Arrange

            // Act
            var actual = veryHardExercises.SpecialReverseString(txt);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("..<.<.", new int[] { 1, 1 })]
        [InlineData("....................................................................................................", new int[] { 100, 0 })]
        [InlineData("<>>>><><<<><>>>><><<<><>>><>", new int[] { 0, 0 })]
        [InlineData(".<..<...<....<.....<......", new int[] { 3, 4 })]
        [InlineData(">>..", new int[] { -2, 0 })]
        [InlineData("..<<..>>..<<..>>..", new int[] { 2, 0 })]
        public void TrackRobot_ShouldReturn(string steps, int[] expected)
        {
            // Arrange

            // Act
            var actual = veryHardExercises.TrackRobot(steps);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("hello", new int[] { 5, 2, 9, 9, 3 })]
        [InlineData("wonderful", new int[] { 11, 3, 2, 1, 2, 6, 3, 9, 9 })]
        [InlineData("all my friends", new int[] { 16, 9, 9, 5, 10, 4, 5, 3, 6, 6, 2, 2, 1, 7 })]
        [InlineData("River", new int[] { 10, 6, 10, 2, 6 })]
        public void Decode_ShouldReturn(string steps, int[] expected)
        {
            // Arrange

            // Act
            var actual = veryHardExercises.Decode(steps);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("H. Wells", true)]
        [InlineData("H. G. Wells", true)]
        [InlineData("Herbert G. Wells", true)]
        [InlineData("Herbert George Wells", true)]
        [InlineData("Herbert", false)]
        [InlineData("Herbert W. G. Wells", false)]
        [InlineData("h. Wells", false)]
        [InlineData("herbert G. Wells", false)]
        [InlineData("H Wells", false)]
        [InlineData("Herb. Wells", false)]
        [InlineData("H. George Wells", false)]
        [InlineData("Herbert George W.", false)]
        public void ValidName_ShouldReturn(string name, bool expected)
        {
            // Arrange

            // Act
            var actual = veryHardExercises.ValidName(name);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new double[] { 9, 17, 30, 1.5 }, "$240.00")]
        [InlineData(new double[] { 9, 18, 40, 2 }, "$400.00")]
        [InlineData(new double[] { 13, 20, 32.5, 2 }, "$325.00")]
        [InlineData(new double[] { 9, 13, 25, 1.5 }, "$100.00")]
        [InlineData(new double[] { 11.5, 19, 40, 1.8 }, "$364.00")]
        [InlineData(new double[] { 10, 17, 30, 1.5 }, "$210.00")]
        [InlineData(new double[] { 10.5, 17, 32.25, 1.5 }, "$209.63")]
        [InlineData(new double[] { 16, 18, 30, 1.8 }, "$84.00")]
        public void OverTime_ShouldReturn(double[] arr, string expected)
        {
            // Arrange

            // Act
            var actual = veryHardExercises.OverTime(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("eA2a1E", "aAeE12")]
        [InlineData("Re4r", "erR4")]
        [InlineData("6jnM31Q", "jMnQ136")]
        [InlineData("f5Eex", "eEfx5")]
        [InlineData("846ZIbo", "bIoZ468")]
        [InlineData("2lZduOg1jB8SPXf5rakC37wIE094Qvm6Tnyh", "aBCdEfghIjklmnOPQrSTuvwXyZ0123456789")]
        public void Sorting_ShouldReturn(string str, string expected)
        {
            // Arrange

            // Act
            var actual = veryHardExercises.Sorting(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("844929328912985315632725682153", "56327256")]
        [InlineData("769697538272129475593767931733", "27212947")]
        [InlineData("937948289456111258444958189244", "894561")]
        [InlineData("736237766362158694825822899262", "636")]
        [InlineData("369715978955362655737322836233", "369")]
        [InlineData("345724969853525333273796592356", "496985")]
        [InlineData("548915548581127334254139969136", "8581")]
        [InlineData("417922164857852157775176959188", "78521")]
        [InlineData("251346385699223913113161144327", "638569")]
        [InlineData("483563951878576456268539849244", "18785")]
        [InlineData("853667717122615664748443484823", "474")]
        [InlineData("398785511683322662883368457392", "98785")]
        [InlineData("368293545763611759335443678239", "76361")]
        [InlineData("775195358448494712934755311372", "4947")]
        [InlineData("646113733929969155976523363762", "76523")]
        [InlineData("575337321726324966478369152265", "478369")]
        [InlineData("754388489999793138912431545258", "545258")]
        [InlineData("198644286258141856918653955964", "2581418569")]
        [InlineData("643349187319779695864213682274", "349")]
        [InlineData("919331281193713636178478295857", "36361")]
        public void LongestSubstring_ShouldReturn(string str, string expected)
        {
            // Arrange

            // Act
            var actual = veryHardExercises.LongestSubstring(str);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("ABAB", "CDCD", true)]
        [InlineData("AAABBB", "CCCDDD", true)]
        [InlineData("ABCBA", "BCDCB", true)]
        [InlineData("AAAA", "BBBB", true)]
        [InlineData("BAAB", "ABBA", true)]
        [InlineData("BAAB", "QZZQ", true)]
        [InlineData("TTZZVV", "PPSSBB", true)]
        [InlineData("ZYX", "ABC", true)]
        [InlineData("AABAA", "SSCSS", true)]
        [InlineData("AABAABAA", "SSCSSCSS", true)]
        [InlineData("UBUBUBUB", "WEWEWEWE", true)]
        [InlineData("FFGG", "FFG", false)]
        [InlineData("FFGG", "CDCD", false)]
        [InlineData("FFFG", "GGHI", false)]
        [InlineData("FFFF", "ABCD", false)]
        [InlineData("ABCA", "ABCD", false)]
        [InlineData("ABCAAA", "DDABCD", false)]
        public void SameLetterPattern_ShouldReturn(string str1, string str2, bool expected)
        {
            // Arrange

            // Act
            var actual = veryHardExercises.SameLetterPattern(str1, str2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, "0 1")]
        [InlineData(2, "00 01 10")]
        [InlineData(3, "000 001 010 100 101")]
        [InlineData(4, "0000 0001 0010 0100 0101 1000 1001 1010")]
        [InlineData(5, "00000 00001 00010 00100 00101 01000 01001 01010 10000 10001 10010 10100 10101")]
        [InlineData(6, "000000 000001 000010 000100 000101 001000 001001 001010 010000 010001 010010 010100 010101 100000 100001 100010 100100 100101 101000 101001 101010")]
        [InlineData(7, "0000000 0000001 0000010 0000100 0000101 0001000 0001001 0001010 0010000 0010001 0010010 0010100 0010101 0100000 0100001 0100010 0100100 0100101 0101000 0101001 0101010 1000000 1000001 1000010 1000100 1000101 1001000 1001001 1001010 1010000 1010001 1010010 1010100 1010101")]
        [InlineData(8, "00000000 00000001 00000010 00000100 00000101 00001000 00001001 00001010 00010000 00010001 00010010 00010100 00010101 00100000 00100001 00100010 00100100 00100101 00101000 00101001 00101010 01000000 01000001 01000010 01000100 01000101 01001000 01001001 01001010 01010000 01010001 01010010 01010100 01010101 10000000 10000001 10000010 10000100 10000101 10001000 10001001 10001010 10010000 10010001 10010010 10010100 10010101 10100000 10100001 10100010 10100100 10100101 10101000 10101001 10101010")]
        [InlineData(9, "000000000 000000001 000000010 000000100 000000101 000001000 000001001 000001010 000010000 000010001 000010010 000010100 000010101 000100000 000100001 000100010 000100100 000100101 000101000 000101001 000101010 001000000 001000001 001000010 001000100 001000101 001001000 001001001 001001010 001010000 001010001 001010010 001010100 001010101 010000000 010000001 010000010 010000100 010000101 010001000 010001001 010001010 010010000 010010001 010010010 010010100 010010101 010100000 010100001 010100010 010100100 010100101 010101000 010101001 010101010 100000000 100000001 100000010 100000100 100000101 100001000 100001001 100001010 100010000 100010001 100010010 100010100 100010101 100100000 100100001 100100010 100100100 100100101 100101000 100101001 100101010 101000000 101000001 101000010 101000100 101000101 101001000 101001001 101001010 101010000 101010001 101010010 101010100 101010101")]
        [InlineData(10, "0000000000 0000000001 0000000010 0000000100 0000000101 0000001000 0000001001 0000001010 0000010000 0000010001 0000010010 0000010100 0000010101 0000100000 0000100001 0000100010 0000100100 0000100101 0000101000 0000101001 0000101010 0001000000 0001000001 0001000010 0001000100 0001000101 0001001000 0001001001 0001001010 0001010000 0001010001 0001010010 0001010100 0001010101 0010000000 0010000001 0010000010 0010000100 0010000101 0010001000 0010001001 0010001010 0010010000 0010010001 0010010010 0010010100 0010010101 0010100000 0010100001 0010100010 0010100100 0010100101 0010101000 0010101001 0010101010 0100000000 0100000001 0100000010 0100000100 0100000101 0100001000 0100001001 0100001010 0100010000 0100010001 0100010010 0100010100 0100010101 0100100000 0100100001 0100100010 0100100100 0100100101 0100101000 0100101001 0100101010 0101000000 0101000001 0101000010 0101000100 0101000101 0101001000 0101001001 0101001010 0101010000 0101010001 0101010010 0101010100 0101010101 1000000000 1000000001 1000000010 1000000100 1000000101 1000001000 1000001001 1000001010 1000010000 1000010001 1000010010 1000010100 1000010101 1000100000 1000100001 1000100010 1000100100 1000100101 1000101000 1000101001 1000101010 1001000000 1001000001 1001000010 1001000100 1001000101 1001001000 1001001001 1001001010 1001010000 1001010001 1001010010 1001010100 1001010101 1010000000 1010000001 1010000010 1010000100 1010000101 1010001000 1010001001 1010001010 1010010000 1010010001 1010010010 1010010100 1010010101 1010100000 1010100001 1010100010 1010100100 1010100101 1010101000 1010101001 1010101010")]
        public void GenerateNonconsecutive_ShouldReturn(int len, string expected)
        {
            // Arrange

            // Act
            var actual = veryHardExercises.GenerateNonconsecutive(len);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(new int[] { 3, 4, 5, 4, 3 }, "mountain")]
        [InlineData(new int[] { 9, 7, 3, 1, 2, 4 }, "valley")]
        [InlineData(new int[] { 9, 8, 9 }, "valley")]
        [InlineData(new int[] { 9, 8, 9, 8 }, "neither")]
        [InlineData(new int[] { 1, 3, 5, 4, 3, 2 }, "mountain")]
        [InlineData(new int[] { -1, 0, -1 }, "mountain")]
        [InlineData(new int[] { 10, 9, 8, 7, 2, 3, 4, 5 }, "valley")]
        [InlineData(new int[] { 350, 100, 200, 400, 700 }, "valley")]
        [InlineData(new int[] { -1, -1, 0, -1, -1 }, "mountain")]
        [InlineData(new int[] { 0, -1, -1, 0, -1, -1 }, "neither")]
        [InlineData(new int[] { 1, 2, 3, 2, 4, 1 }, "neither")]
        [InlineData(new int[] { 5, 4, 3, 2, 1 }, "neither")]
        [InlineData(new int[] { 1, 2, 3, 4 }, "neither")]

        public void LandscapeType_ShouldReturn(int[] arr, string expected)
        {
            // Arrange

            // Act
            var actual = veryHardExercises.LandscapeType(arr);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("greeting", ".. .. .... .. . ..... . ..... .... .... .. .... ... ... .. ..")]
        [InlineData("confrontation", ". ... ... .... ... ... .. . .... .. ... .... ... ... .... .... . . .... .... .. .... ... .... ... ...")]
        [InlineData("leadership", "... . . ..... . . . .... . ..... .... .. .... ... .. ... .. .... ... .....")]
        [InlineData("ankle", ". . ... ... . ... ... . . .....")]
        [InlineData("extreme", ". ..... ..... ... .... .... .... .. . ..... ... .. . .....")]
        [InlineData(".... .... ... .... ... ... .. .... .. .. .. ... .... ....", "tonight")]
        [InlineData("... . ... .... ..... .... . . ... . .... .... ..... ....", "loyalty")]
        [InlineData(".... .. . ..... .. . . ..... .... .. .... .. . . ... .", "referral")]
        [InlineData(". ..... ..... ... ... ..... .... .. . ..... .... ... .... ... .. .... ... .... ... ...", "expression")]
        [InlineData(". . .. . .. . .. .... ... ... .. .... .... .... ..... ....", "affinity")]
        [InlineData("correspondence", ". ... ... .... .... .. .... .. . ..... .... ... ... ..... ... .... ... ... . .... . ..... ... ... . ... . .....")]
        [InlineData("atmosphere", ". . .... .... ... .. ... .... .... ... ... ..... .. ... . ..... .... .. . .....")]
        [InlineData("absolute", ". . . .. .... ... ... .... ... . .... ..... .... .... . .....")]
        [InlineData("redundancy", ".... .. . ..... . .... .... ..... ... ... . .... . . ... ... . ... ..... ....")]
        [InlineData("infrastructure", ".. .... ... ... .. . .... .. . . .... ... .... .... .... .. .... ..... . ... .... .... .... ..... .... .. . .....")]
        [InlineData("... ..... ... .... .. .... ... ... .... ....", "point")]
        [InlineData("... ..... .... .. . ..... .. . . ..... .... .. . ..... ... ... . ... . .....", "preference")]
        [InlineData(".. .. .... ..... .. .... . .... . .....", "guide")]
        [InlineData(". ... .. ... . . .... .. . . . ... .... .... . ..... .... .. .. .... .... ... .... .... .. .... . ...", "characteristic")]
        [InlineData(". ... ... .... ... .. ... .. . ..... .... .. . ... . .....", "commerce")]


        public void TapCode_ShouldReturn(string text, string expected)
        {
            // Arrange

            // Act
            var actual = veryHardExercises.TapCode(text);

            // Assert
            Assert.Equal(expected, actual);
        }

    }
}
