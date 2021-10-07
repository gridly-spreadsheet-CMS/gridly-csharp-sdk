/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 3.13.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Com.Gridly.Client.OpenAPIDateConverter;

namespace Com.Gridly.Model
{
    /// <summary>
    /// UpdateColumn
    /// </summary>
    [DataContract]
    public partial class UpdateColumn :  IEquatable<UpdateColumn>, IValidatableObject
    {
        /// <summary>
        /// Defines LanguageCode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LanguageCodeEnum
        {
            /// <summary>
            /// Enum EnUS for value: enUS
            /// </summary>
            [EnumMember(Value = "enUS")]
            EnUS = 1,

            /// <summary>
            /// Enum ArSA for value: arSA
            /// </summary>
            [EnumMember(Value = "arSA")]
            ArSA = 2,

            /// <summary>
            /// Enum CaES for value: caES
            /// </summary>
            [EnumMember(Value = "caES")]
            CaES = 3,

            /// <summary>
            /// Enum ZhCN for value: zhCN
            /// </summary>
            [EnumMember(Value = "zhCN")]
            ZhCN = 4,

            /// <summary>
            /// Enum ZhTW for value: zhTW
            /// </summary>
            [EnumMember(Value = "zhTW")]
            ZhTW = 5,

            /// <summary>
            /// Enum DeDE for value: deDE
            /// </summary>
            [EnumMember(Value = "deDE")]
            DeDE = 6,

            /// <summary>
            /// Enum ItIT for value: itIT
            /// </summary>
            [EnumMember(Value = "itIT")]
            ItIT = 7,

            /// <summary>
            /// Enum JaJP for value: jaJP
            /// </summary>
            [EnumMember(Value = "jaJP")]
            JaJP = 8,

            /// <summary>
            /// Enum KoKR for value: koKR
            /// </summary>
            [EnumMember(Value = "koKR")]
            KoKR = 9,

            /// <summary>
            /// Enum PlPL for value: plPL
            /// </summary>
            [EnumMember(Value = "plPL")]
            PlPL = 10,

            /// <summary>
            /// Enum PtBR for value: ptBR
            /// </summary>
            [EnumMember(Value = "ptBR")]
            PtBR = 11,

            /// <summary>
            /// Enum RuRU for value: ruRU
            /// </summary>
            [EnumMember(Value = "ruRU")]
            RuRU = 12,

            /// <summary>
            /// Enum EsMX for value: esMX
            /// </summary>
            [EnumMember(Value = "esMX")]
            EsMX = 13,

            /// <summary>
            /// Enum EsES for value: esES
            /// </summary>
            [EnumMember(Value = "esES")]
            EsES = 14,

            /// <summary>
            /// Enum BnBD for value: bnBD
            /// </summary>
            [EnumMember(Value = "bnBD")]
            BnBD = 15,

            /// <summary>
            /// Enum BgBG for value: bgBG
            /// </summary>
            [EnumMember(Value = "bgBG")]
            BgBG = 16,

            /// <summary>
            /// Enum ZhHK for value: zhHK
            /// </summary>
            [EnumMember(Value = "zhHK")]
            ZhHK = 17,

            /// <summary>
            /// Enum CsCZ for value: csCZ
            /// </summary>
            [EnumMember(Value = "csCZ")]
            CsCZ = 18,

            /// <summary>
            /// Enum DaDK for value: daDK
            /// </summary>
            [EnumMember(Value = "daDK")]
            DaDK = 19,

            /// <summary>
            /// Enum NlNL for value: nlNL
            /// </summary>
            [EnumMember(Value = "nlNL")]
            NlNL = 20,

            /// <summary>
            /// Enum FiFI for value: fiFI
            /// </summary>
            [EnumMember(Value = "fiFI")]
            FiFI = 21,

            /// <summary>
            /// Enum FrFR for value: frFR
            /// </summary>
            [EnumMember(Value = "frFR")]
            FrFR = 22,

            /// <summary>
            /// Enum FrCA for value: frCA
            /// </summary>
            [EnumMember(Value = "frCA")]
            FrCA = 23,

            /// <summary>
            /// Enum ElGR for value: elGR
            /// </summary>
            [EnumMember(Value = "elGR")]
            ElGR = 24,

            /// <summary>
            /// Enum HeIL for value: heIL
            /// </summary>
            [EnumMember(Value = "heIL")]
            HeIL = 25,

            /// <summary>
            /// Enum HiIN for value: hiIN
            /// </summary>
            [EnumMember(Value = "hiIN")]
            HiIN = 26,

            /// <summary>
            /// Enum HuHU for value: huHU
            /// </summary>
            [EnumMember(Value = "huHU")]
            HuHU = 27,

            /// <summary>
            /// Enum IdID for value: idID
            /// </summary>
            [EnumMember(Value = "idID")]
            IdID = 28,

            /// <summary>
            /// Enum JwID for value: jwID
            /// </summary>
            [EnumMember(Value = "jwID")]
            JwID = 29,

            /// <summary>
            /// Enum LvLV for value: lvLV
            /// </summary>
            [EnumMember(Value = "lvLV")]
            LvLV = 30,

            /// <summary>
            /// Enum MsMY for value: msMY
            /// </summary>
            [EnumMember(Value = "msMY")]
            MsMY = 31,

            /// <summary>
            /// Enum NoNO for value: noNO
            /// </summary>
            [EnumMember(Value = "noNO")]
            NoNO = 32,

            /// <summary>
            /// Enum PtPT for value: ptPT
            /// </summary>
            [EnumMember(Value = "ptPT")]
            PtPT = 33,

            /// <summary>
            /// Enum RoRO for value: roRO
            /// </summary>
            [EnumMember(Value = "roRO")]
            RoRO = 34,

            /// <summary>
            /// Enum SkSK for value: skSK
            /// </summary>
            [EnumMember(Value = "skSK")]
            SkSK = 35,

            /// <summary>
            /// Enum SvSE for value: svSE
            /// </summary>
            [EnumMember(Value = "svSE")]
            SvSE = 36,

            /// <summary>
            /// Enum TlPH for value: tlPH
            /// </summary>
            [EnumMember(Value = "tlPH")]
            TlPH = 37,

            /// <summary>
            /// Enum ThTH for value: thTH
            /// </summary>
            [EnumMember(Value = "thTH")]
            ThTH = 38,

            /// <summary>
            /// Enum TrTR for value: trTR
            /// </summary>
            [EnumMember(Value = "trTR")]
            TrTR = 39,

            /// <summary>
            /// Enum UkUA for value: ukUA
            /// </summary>
            [EnumMember(Value = "ukUA")]
            UkUA = 40,

            /// <summary>
            /// Enum UrIN for value: urIN
            /// </summary>
            [EnumMember(Value = "urIN")]
            UrIN = 41,

            /// <summary>
            /// Enum ViVN for value: viVN
            /// </summary>
            [EnumMember(Value = "viVN")]
            ViVN = 42,

            /// <summary>
            /// Enum AfZA for value: afZA
            /// </summary>
            [EnumMember(Value = "afZA")]
            AfZA = 43,

            /// <summary>
            /// Enum ArAE for value: arAE
            /// </summary>
            [EnumMember(Value = "arAE")]
            ArAE = 44,

            /// <summary>
            /// Enum ArBH for value: arBH
            /// </summary>
            [EnumMember(Value = "arBH")]
            ArBH = 45,

            /// <summary>
            /// Enum ArDZ for value: arDZ
            /// </summary>
            [EnumMember(Value = "arDZ")]
            ArDZ = 46,

            /// <summary>
            /// Enum ArEG for value: arEG
            /// </summary>
            [EnumMember(Value = "arEG")]
            ArEG = 47,

            /// <summary>
            /// Enum ArIQ for value: arIQ
            /// </summary>
            [EnumMember(Value = "arIQ")]
            ArIQ = 48,

            /// <summary>
            /// Enum ArJO for value: arJO
            /// </summary>
            [EnumMember(Value = "arJO")]
            ArJO = 49,

            /// <summary>
            /// Enum ArKW for value: arKW
            /// </summary>
            [EnumMember(Value = "arKW")]
            ArKW = 50,

            /// <summary>
            /// Enum ArLB for value: arLB
            /// </summary>
            [EnumMember(Value = "arLB")]
            ArLB = 51,

            /// <summary>
            /// Enum ArLY for value: arLY
            /// </summary>
            [EnumMember(Value = "arLY")]
            ArLY = 52,

            /// <summary>
            /// Enum ArMA for value: arMA
            /// </summary>
            [EnumMember(Value = "arMA")]
            ArMA = 53,

            /// <summary>
            /// Enum ArOM for value: arOM
            /// </summary>
            [EnumMember(Value = "arOM")]
            ArOM = 54,

            /// <summary>
            /// Enum ArQA for value: arQA
            /// </summary>
            [EnumMember(Value = "arQA")]
            ArQA = 55,

            /// <summary>
            /// Enum ArSY for value: arSY
            /// </summary>
            [EnumMember(Value = "arSY")]
            ArSY = 56,

            /// <summary>
            /// Enum ArTN for value: arTN
            /// </summary>
            [EnumMember(Value = "arTN")]
            ArTN = 57,

            /// <summary>
            /// Enum ArYE for value: arYE
            /// </summary>
            [EnumMember(Value = "arYE")]
            ArYE = 58,

            /// <summary>
            /// Enum AzAZ for value: azAZ
            /// </summary>
            [EnumMember(Value = "azAZ")]
            AzAZ = 59,

            /// <summary>
            /// Enum BeBY for value: beBY
            /// </summary>
            [EnumMember(Value = "beBY")]
            BeBY = 60,

            /// <summary>
            /// Enum BsBA for value: bsBA
            /// </summary>
            [EnumMember(Value = "bsBA")]
            BsBA = 61,

            /// <summary>
            /// Enum CyGB for value: cyGB
            /// </summary>
            [EnumMember(Value = "cyGB")]
            CyGB = 62,

            /// <summary>
            /// Enum DeAT for value: deAT
            /// </summary>
            [EnumMember(Value = "deAT")]
            DeAT = 63,

            /// <summary>
            /// Enum DeCH for value: deCH
            /// </summary>
            [EnumMember(Value = "deCH")]
            DeCH = 64,

            /// <summary>
            /// Enum DeLI for value: deLI
            /// </summary>
            [EnumMember(Value = "deLI")]
            DeLI = 65,

            /// <summary>
            /// Enum DeLU for value: deLU
            /// </summary>
            [EnumMember(Value = "deLU")]
            DeLU = 66,

            /// <summary>
            /// Enum DvMV for value: dvMV
            /// </summary>
            [EnumMember(Value = "dvMV")]
            DvMV = 67,

            /// <summary>
            /// Enum EnAU for value: enAU
            /// </summary>
            [EnumMember(Value = "enAU")]
            EnAU = 68,

            /// <summary>
            /// Enum EnBZ for value: enBZ
            /// </summary>
            [EnumMember(Value = "enBZ")]
            EnBZ = 69,

            /// <summary>
            /// Enum EnCA for value: enCA
            /// </summary>
            [EnumMember(Value = "enCA")]
            EnCA = 70,

            /// <summary>
            /// Enum EnGB for value: enGB
            /// </summary>
            [EnumMember(Value = "enGB")]
            EnGB = 71,

            /// <summary>
            /// Enum EnIE for value: enIE
            /// </summary>
            [EnumMember(Value = "enIE")]
            EnIE = 72,

            /// <summary>
            /// Enum EnJM for value: enJM
            /// </summary>
            [EnumMember(Value = "enJM")]
            EnJM = 73,

            /// <summary>
            /// Enum EnNZ for value: enNZ
            /// </summary>
            [EnumMember(Value = "enNZ")]
            EnNZ = 74,

            /// <summary>
            /// Enum EnPH for value: enPH
            /// </summary>
            [EnumMember(Value = "enPH")]
            EnPH = 75,

            /// <summary>
            /// Enum EnTT for value: enTT
            /// </summary>
            [EnumMember(Value = "enTT")]
            EnTT = 76,

            /// <summary>
            /// Enum EnZA for value: enZA
            /// </summary>
            [EnumMember(Value = "enZA")]
            EnZA = 77,

            /// <summary>
            /// Enum EnZW for value: enZW
            /// </summary>
            [EnumMember(Value = "enZW")]
            EnZW = 78,

            /// <summary>
            /// Enum EsAR for value: esAR
            /// </summary>
            [EnumMember(Value = "esAR")]
            EsAR = 79,

            /// <summary>
            /// Enum EsBO for value: esBO
            /// </summary>
            [EnumMember(Value = "esBO")]
            EsBO = 80,

            /// <summary>
            /// Enum EsCL for value: esCL
            /// </summary>
            [EnumMember(Value = "esCL")]
            EsCL = 81,

            /// <summary>
            /// Enum EsCO for value: esCO
            /// </summary>
            [EnumMember(Value = "esCO")]
            EsCO = 82,

            /// <summary>
            /// Enum EsCR for value: esCR
            /// </summary>
            [EnumMember(Value = "esCR")]
            EsCR = 83,

            /// <summary>
            /// Enum EsDO for value: esDO
            /// </summary>
            [EnumMember(Value = "esDO")]
            EsDO = 84,

            /// <summary>
            /// Enum EsEC for value: esEC
            /// </summary>
            [EnumMember(Value = "esEC")]
            EsEC = 85,

            /// <summary>
            /// Enum EsGT for value: esGT
            /// </summary>
            [EnumMember(Value = "esGT")]
            EsGT = 86,

            /// <summary>
            /// Enum EsHN for value: esHN
            /// </summary>
            [EnumMember(Value = "esHN")]
            EsHN = 87,

            /// <summary>
            /// Enum EsNI for value: esNI
            /// </summary>
            [EnumMember(Value = "esNI")]
            EsNI = 88,

            /// <summary>
            /// Enum EsPA for value: esPA
            /// </summary>
            [EnumMember(Value = "esPA")]
            EsPA = 89,

            /// <summary>
            /// Enum EsPE for value: esPE
            /// </summary>
            [EnumMember(Value = "esPE")]
            EsPE = 90,

            /// <summary>
            /// Enum EsPR for value: esPR
            /// </summary>
            [EnumMember(Value = "esPR")]
            EsPR = 91,

            /// <summary>
            /// Enum EsPY for value: esPY
            /// </summary>
            [EnumMember(Value = "esPY")]
            EsPY = 92,

            /// <summary>
            /// Enum EsSV for value: esSV
            /// </summary>
            [EnumMember(Value = "esSV")]
            EsSV = 93,

            /// <summary>
            /// Enum EsUY for value: esUY
            /// </summary>
            [EnumMember(Value = "esUY")]
            EsUY = 94,

            /// <summary>
            /// Enum EsVE for value: esVE
            /// </summary>
            [EnumMember(Value = "esVE")]
            EsVE = 95,

            /// <summary>
            /// Enum EtEE for value: etEE
            /// </summary>
            [EnumMember(Value = "etEE")]
            EtEE = 96,

            /// <summary>
            /// Enum EuES for value: euES
            /// </summary>
            [EnumMember(Value = "euES")]
            EuES = 97,

            /// <summary>
            /// Enum FaIR for value: faIR
            /// </summary>
            [EnumMember(Value = "faIR")]
            FaIR = 98,

            /// <summary>
            /// Enum FoFO for value: foFO
            /// </summary>
            [EnumMember(Value = "foFO")]
            FoFO = 99,

            /// <summary>
            /// Enum FrBE for value: frBE
            /// </summary>
            [EnumMember(Value = "frBE")]
            FrBE = 100,

            /// <summary>
            /// Enum FrCH for value: frCH
            /// </summary>
            [EnumMember(Value = "frCH")]
            FrCH = 101,

            /// <summary>
            /// Enum FrLU for value: frLU
            /// </summary>
            [EnumMember(Value = "frLU")]
            FrLU = 102,

            /// <summary>
            /// Enum FrMC for value: frMC
            /// </summary>
            [EnumMember(Value = "frMC")]
            FrMC = 103,

            /// <summary>
            /// Enum GlES for value: glES
            /// </summary>
            [EnumMember(Value = "glES")]
            GlES = 104,

            /// <summary>
            /// Enum GuIN for value: guIN
            /// </summary>
            [EnumMember(Value = "guIN")]
            GuIN = 105,

            /// <summary>
            /// Enum HrBA for value: hrBA
            /// </summary>
            [EnumMember(Value = "hrBA")]
            HrBA = 106,

            /// <summary>
            /// Enum HrHR for value: hrHR
            /// </summary>
            [EnumMember(Value = "hrHR")]
            HrHR = 107,

            /// <summary>
            /// Enum HyAM for value: hyAM
            /// </summary>
            [EnumMember(Value = "hyAM")]
            HyAM = 108,

            /// <summary>
            /// Enum IsIS for value: isIS
            /// </summary>
            [EnumMember(Value = "isIS")]
            IsIS = 109,

            /// <summary>
            /// Enum ItCH for value: itCH
            /// </summary>
            [EnumMember(Value = "itCH")]
            ItCH = 110,

            /// <summary>
            /// Enum KaGE for value: kaGE
            /// </summary>
            [EnumMember(Value = "kaGE")]
            KaGE = 111,

            /// <summary>
            /// Enum KkKZ for value: kkKZ
            /// </summary>
            [EnumMember(Value = "kkKZ")]
            KkKZ = 112,

            /// <summary>
            /// Enum KnIN for value: knIN
            /// </summary>
            [EnumMember(Value = "knIN")]
            KnIN = 113,

            /// <summary>
            /// Enum KokIN for value: kokIN
            /// </summary>
            [EnumMember(Value = "kokIN")]
            KokIN = 114,

            /// <summary>
            /// Enum KyKG for value: kyKG
            /// </summary>
            [EnumMember(Value = "kyKG")]
            KyKG = 115,

            /// <summary>
            /// Enum LtLT for value: ltLT
            /// </summary>
            [EnumMember(Value = "ltLT")]
            LtLT = 116,

            /// <summary>
            /// Enum MiNZ for value: miNZ
            /// </summary>
            [EnumMember(Value = "miNZ")]
            MiNZ = 117,

            /// <summary>
            /// Enum MkMK for value: mkMK
            /// </summary>
            [EnumMember(Value = "mkMK")]
            MkMK = 118,

            /// <summary>
            /// Enum MnMN for value: mnMN
            /// </summary>
            [EnumMember(Value = "mnMN")]
            MnMN = 119,

            /// <summary>
            /// Enum MrIN for value: mrIN
            /// </summary>
            [EnumMember(Value = "mrIN")]
            MrIN = 120,

            /// <summary>
            /// Enum MsBN for value: msBN
            /// </summary>
            [EnumMember(Value = "msBN")]
            MsBN = 121,

            /// <summary>
            /// Enum MtMT for value: mtMT
            /// </summary>
            [EnumMember(Value = "mtMT")]
            MtMT = 122,

            /// <summary>
            /// Enum NbNO for value: nbNO
            /// </summary>
            [EnumMember(Value = "nbNO")]
            NbNO = 123,

            /// <summary>
            /// Enum NlBE for value: nlBE
            /// </summary>
            [EnumMember(Value = "nlBE")]
            NlBE = 124,

            /// <summary>
            /// Enum NnNO for value: nnNO
            /// </summary>
            [EnumMember(Value = "nnNO")]
            NnNO = 125,

            /// <summary>
            /// Enum NsZA for value: nsZA
            /// </summary>
            [EnumMember(Value = "nsZA")]
            NsZA = 126,

            /// <summary>
            /// Enum PaIN for value: paIN
            /// </summary>
            [EnumMember(Value = "paIN")]
            PaIN = 127,

            /// <summary>
            /// Enum PsAR for value: psAR
            /// </summary>
            [EnumMember(Value = "psAR")]
            PsAR = 128,

            /// <summary>
            /// Enum QuBO for value: quBO
            /// </summary>
            [EnumMember(Value = "quBO")]
            QuBO = 129,

            /// <summary>
            /// Enum QuEC for value: quEC
            /// </summary>
            [EnumMember(Value = "quEC")]
            QuEC = 130,

            /// <summary>
            /// Enum QuPE for value: quPE
            /// </summary>
            [EnumMember(Value = "quPE")]
            QuPE = 131,

            /// <summary>
            /// Enum SaIN for value: saIN
            /// </summary>
            [EnumMember(Value = "saIN")]
            SaIN = 132,

            /// <summary>
            /// Enum SeFI for value: seFI
            /// </summary>
            [EnumMember(Value = "seFI")]
            SeFI = 133,

            /// <summary>
            /// Enum SeNO for value: seNO
            /// </summary>
            [EnumMember(Value = "seNO")]
            SeNO = 134,

            /// <summary>
            /// Enum SeSE for value: seSE
            /// </summary>
            [EnumMember(Value = "seSE")]
            SeSE = 135,

            /// <summary>
            /// Enum SlSI for value: slSI
            /// </summary>
            [EnumMember(Value = "slSI")]
            SlSI = 136,

            /// <summary>
            /// Enum SqAL for value: sqAL
            /// </summary>
            [EnumMember(Value = "sqAL")]
            SqAL = 137,

            /// <summary>
            /// Enum SrBA for value: srBA
            /// </summary>
            [EnumMember(Value = "srBA")]
            SrBA = 138,

            /// <summary>
            /// Enum SvFI for value: svFI
            /// </summary>
            [EnumMember(Value = "svFI")]
            SvFI = 139,

            /// <summary>
            /// Enum SwKE for value: swKE
            /// </summary>
            [EnumMember(Value = "swKE")]
            SwKE = 140,

            /// <summary>
            /// Enum SyrSY for value: syrSY
            /// </summary>
            [EnumMember(Value = "syrSY")]
            SyrSY = 141,

            /// <summary>
            /// Enum TaIN for value: taIN
            /// </summary>
            [EnumMember(Value = "taIN")]
            TaIN = 142,

            /// <summary>
            /// Enum TeIN for value: teIN
            /// </summary>
            [EnumMember(Value = "teIN")]
            TeIN = 143,

            /// <summary>
            /// Enum TnZA for value: tnZA
            /// </summary>
            [EnumMember(Value = "tnZA")]
            TnZA = 144,

            /// <summary>
            /// Enum TtRU for value: ttRU
            /// </summary>
            [EnumMember(Value = "ttRU")]
            TtRU = 145,

            /// <summary>
            /// Enum UrPK for value: urPK
            /// </summary>
            [EnumMember(Value = "urPK")]
            UrPK = 146,

            /// <summary>
            /// Enum UzUZ for value: uzUZ
            /// </summary>
            [EnumMember(Value = "uzUZ")]
            UzUZ = 147,

            /// <summary>
            /// Enum XhZA for value: xhZA
            /// </summary>
            [EnumMember(Value = "xhZA")]
            XhZA = 148,

            /// <summary>
            /// Enum ZhMO for value: zhMO
            /// </summary>
            [EnumMember(Value = "zhMO")]
            ZhMO = 149,

            /// <summary>
            /// Enum ZhSG for value: zhSG
            /// </summary>
            [EnumMember(Value = "zhSG")]
            ZhSG = 150,

            /// <summary>
            /// Enum ZuZA for value: zuZA
            /// </summary>
            [EnumMember(Value = "zuZA")]
            ZuZA = 151

        }

        /// <summary>
        /// Gets or Sets LanguageCode
        /// </summary>
        [DataMember(Name="languageCode", EmitDefaultValue=false)]
        public LanguageCodeEnum? LanguageCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateColumn" /> class.
        /// </summary>
        /// <param name="languageCode">languageCode.</param>
        /// <param name="name">name.</param>
        /// <param name="numberFormat">numberFormat.</param>
        /// <param name="selectionOptions">selectionOptions.</param>
        public UpdateColumn(LanguageCodeEnum? languageCode = default(LanguageCodeEnum?), string name = default(string), NumberFormat numberFormat = default(NumberFormat), List<string> selectionOptions = default(List<string>))
        {
            this.LanguageCode = languageCode;
            this.Name = name;
            this.NumberFormat = numberFormat;
            this.SelectionOptions = selectionOptions;
        }


        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NumberFormat
        /// </summary>
        [DataMember(Name="numberFormat", EmitDefaultValue=false)]
        public NumberFormat NumberFormat { get; set; }

        /// <summary>
        /// Gets or Sets SelectionOptions
        /// </summary>
        [DataMember(Name="selectionOptions", EmitDefaultValue=false)]
        public List<string> SelectionOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateColumn {\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NumberFormat: ").Append(NumberFormat).Append("\n");
            sb.Append("  SelectionOptions: ").Append(SelectionOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateColumn);
        }

        /// <summary>
        /// Returns true if UpdateColumn instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateColumn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateColumn input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LanguageCode == input.LanguageCode ||
                    (this.LanguageCode != null &&
                    this.LanguageCode.Equals(input.LanguageCode))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NumberFormat == input.NumberFormat ||
                    (this.NumberFormat != null &&
                    this.NumberFormat.Equals(input.NumberFormat))
                ) && 
                (
                    this.SelectionOptions == input.SelectionOptions ||
                    this.SelectionOptions != null &&
                    input.SelectionOptions != null &&
                    this.SelectionOptions.SequenceEqual(input.SelectionOptions)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.LanguageCode != null)
                    hashCode = hashCode * 59 + this.LanguageCode.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NumberFormat != null)
                    hashCode = hashCode * 59 + this.NumberFormat.GetHashCode();
                if (this.SelectionOptions != null)
                    hashCode = hashCode * 59 + this.SelectionOptions.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
