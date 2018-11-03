
// This file was generated using: https://app.quicktype.io/
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var welcome = Welcome.FromJson(jsonString);

namespace Model
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Root
    {
        [JsonProperty("next_change_id")]
        public string NextChangeId { get; set; }

        [JsonProperty("stashes")]
        public Stash[] Stashes { get; set; }
    }

    public partial class Stash
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }

        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        [JsonProperty("lastCharacterName")]
        public string LastCharacterName { get; set; }

        [JsonProperty("stash")]
        public string StashStash { get; set; }

        [JsonProperty("stashType")]
        public StashType StashType { get; set; }

        [JsonProperty("league")]
        public League? League { get; set; }

        [JsonProperty("items")]
        public Item[] Items { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("w")]
        public long W { get; set; }

        [JsonProperty("h")]
        public long H { get; set; }

        [JsonProperty("ilvl")]
        public long Ilvl { get; set; }

        [JsonProperty("icon")]
        public Uri Icon { get; set; }

        [JsonProperty("league")]
        public League League { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sockets", NullValueHandling = NullValueHandling.Ignore)]
        public Socket[] Sockets { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("typeLine")]
        public string TypeLine { get; set; }

        [JsonProperty("identified")]
        public bool Identified { get; set; }

        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public NextLevelRequirement[] Properties { get; set; }

        [JsonProperty("requirements", NullValueHandling = NullValueHandling.Ignore)]
        public NextLevelRequirement[] Requirements { get; set; }

        [JsonProperty("explicitMods", NullValueHandling = NullValueHandling.Ignore)]
        public string[] ExplicitMods { get; set; }

        [JsonProperty("flavourText", NullValueHandling = NullValueHandling.Ignore)]
        public string[] FlavourText { get; set; }

        [JsonProperty("frameType")]
        public long FrameType { get; set; }

        [JsonProperty("category")]
        public ItemCategory Category { get; set; }

        [JsonProperty("x")]
        public long X { get; set; }

        [JsonProperty("y")]
        public long Y { get; set; }

        [JsonProperty("inventoryId")]
        public string InventoryId { get; set; }

        [JsonProperty("socketedItems", NullValueHandling = NullValueHandling.Ignore)]
        public SocketedItem[] SocketedItems { get; set; }

        [JsonProperty("support", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Support { get; set; }

        [JsonProperty("additionalProperties", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProperty[] AdditionalProperties { get; set; }

        [JsonProperty("nextLevelRequirements", NullValueHandling = NullValueHandling.Ignore)]
        public NextLevelRequirement[] NextLevelRequirements { get; set; }

        [JsonProperty("secDescrText", NullValueHandling = NullValueHandling.Ignore)]
        public string SecDescrText { get; set; }

        [JsonProperty("descrText", NullValueHandling = NullValueHandling.Ignore)]
        public string DescrText { get; set; }

        [JsonProperty("implicitMods", NullValueHandling = NullValueHandling.Ignore)]
        public string[] ImplicitMods { get; set; }

        [JsonProperty("utilityMods", NullValueHandling = NullValueHandling.Ignore)]
        public string[] UtilityMods { get; set; }

        [JsonProperty("craftedMods", NullValueHandling = NullValueHandling.Ignore)]
        public string[] CraftedMods { get; set; }

        [JsonProperty("corrupted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Corrupted { get; set; }

        [JsonProperty("talismanTier", NullValueHandling = NullValueHandling.Ignore)]
        public long? TalismanTier { get; set; }

        [JsonProperty("vaal", NullValueHandling = NullValueHandling.Ignore)]
        public Vaal Vaal { get; set; }

        [JsonProperty("stackSize", NullValueHandling = NullValueHandling.Ignore)]
        public long? StackSize { get; set; }

        [JsonProperty("maxStackSize", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxStackSize { get; set; }

        [JsonProperty("duplicated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Duplicated { get; set; }

        [JsonProperty("artFilename", NullValueHandling = NullValueHandling.Ignore)]
        public string ArtFilename { get; set; }
    }

    public partial class AdditionalProperty
    {
        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("values")]
        public Value[][] Values { get; set; }

        [JsonProperty("displayMode")]
        public long DisplayMode { get; set; }

        [JsonProperty("progress")]
        public double Progress { get; set; }

        [JsonProperty("type")]
        public long Type { get; set; }
    }

    public partial class ItemCategory
    {
        [JsonProperty("weapons", NullValueHandling = NullValueHandling.Ignore)]
        public Weapon[] Weapons { get; set; }

        [JsonProperty("gems", NullValueHandling = NullValueHandling.Ignore)]
        public Gem[] Gems { get; set; }

        [JsonProperty("jewels", NullValueHandling = NullValueHandling.Ignore)]
        public object[] Jewels { get; set; }

        [JsonProperty("accessories", NullValueHandling = NullValueHandling.Ignore)]
        public Accessory[] Accessories { get; set; }

        [JsonProperty("flasks", NullValueHandling = NullValueHandling.Ignore)]
        public object[] Flasks { get; set; }

        [JsonProperty("armour", NullValueHandling = NullValueHandling.Ignore)]
        public Armour[] Armour { get; set; }

        [JsonProperty("maps", NullValueHandling = NullValueHandling.Ignore)]
        public object[] Maps { get; set; }

        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public object[] Currency { get; set; }

        [JsonProperty("cards", NullValueHandling = NullValueHandling.Ignore)]
        public object[] Cards { get; set; }
    }

    public partial class NextLevelRequirement
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("values")]
        public Value[][] Values { get; set; }

        [JsonProperty("displayMode")]
        public long DisplayMode { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public long? Type { get; set; }
    }

    public partial class SocketedItem
    {
        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("w")]
        public long W { get; set; }

        [JsonProperty("h")]
        public long H { get; set; }

        [JsonProperty("ilvl")]
        public long Ilvl { get; set; }

        [JsonProperty("icon")]
        public Uri Icon { get; set; }

        [JsonProperty("support")]
        public bool Support { get; set; }

        [JsonProperty("league")]
        public League League { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("typeLine")]
        public string TypeLine { get; set; }

        [JsonProperty("identified")]
        public bool Identified { get; set; }

        [JsonProperty("properties")]
        public NextLevelRequirement[] Properties { get; set; }

        [JsonProperty("additionalProperties")]
        public AdditionalProperty[] AdditionalProperties { get; set; }

        [JsonProperty("requirements")]
        public NextLevelRequirement[] Requirements { get; set; }

        [JsonProperty("secDescrText")]
        public string SecDescrText { get; set; }

        [JsonProperty("explicitMods")]
        public string[] ExplicitMods { get; set; }

        [JsonProperty("descrText")]
        public string DescrText { get; set; }

        [JsonProperty("frameType")]
        public long FrameType { get; set; }

        [JsonProperty("category")]
        public SocketedItemCategory Category { get; set; }

        [JsonProperty("socket")]
        public long Socket { get; set; }

        [JsonProperty("colour")]
        public Colour Colour { get; set; }
    }

    public partial class SocketedItemCategory
    {
        [JsonProperty("gems")]
        public Gem[] Gems { get; set; }
    }

    public partial class Socket
    {
        [JsonProperty("group")]
        public long Group { get; set; }

        [JsonProperty("attr")]
        public Colour Attr { get; set; }

        [JsonProperty("sColour")]
        public SColour SColour { get; set; }
    }

    public partial class Vaal
    {
        [JsonProperty("baseTypeName")]
        public string BaseTypeName { get; set; }

        [JsonProperty("properties")]
        public NextLevelRequirement[] Properties { get; set; }

        [JsonProperty("explicitMods")]
        public string[] ExplicitMods { get; set; }

        [JsonProperty("secDescrText")]
        public string SecDescrText { get; set; }
    }

    public enum Name { Experience };

    public enum Accessory { Amulet, Belt, Ring };

    public enum Armour { Boots, Chest, Gloves, Helmet, Quiver, Shield };

    public enum Gem { Activegem, Supportgem };

    public enum Weapon { Bow, Claw, Dagger, Oneaxe, Onemace, Onesword, Sceptre, Staff, Twoaxe, Twomace, Twosword, Wand };

    public enum League { Hardcore, Standard };

    public enum Colour { D, G, I, S };

    public enum SColour { B, G, R, W };

    public enum StashType { CurrencyStash, NormalStash, PremiumStash };

    public partial struct Value
    {
        public long? Integer;
        public string String;

        public static implicit operator Value(long Integer) => new Value { Integer = Integer };
        public static implicit operator Value(string String) => new Value { String = String };
    }

    public partial class Root
    {
        public static Root FromJson(string json) => JsonConvert.DeserializeObject<Root>(json, Model.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Root self) => JsonConvert.SerializeObject(self, Model.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                NameConverter.Singleton,
                ValueConverter.Singleton,
                AccessoryConverter.Singleton,
                ArmourConverter.Singleton,
                GemConverter.Singleton,
                WeaponConverter.Singleton,
                LeagueConverter.Singleton,
                ColourConverter.Singleton,
                SColourConverter.Singleton,
                StashTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class NameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Name) || t == typeof(Name?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Experience")
            {
                return Name.Experience;
            }
            throw new Exception("Cannot unmarshal type Name");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Name)untypedValue;
            if (value == Name.Experience)
            {
                serializer.Serialize(writer, "Experience");
                return;
            }
            throw new Exception("Cannot marshal type Name");
        }

        public static readonly NameConverter Singleton = new NameConverter();
    }

    internal class ValueConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Value) || t == typeof(Value?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new Value { Integer = integerValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Value { String = stringValue };
            }
            throw new Exception("Cannot unmarshal type Value");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Value)untypedValue;
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            throw new Exception("Cannot marshal type Value");
        }

        public static readonly ValueConverter Singleton = new ValueConverter();
    }

    internal class AccessoryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Accessory) || t == typeof(Accessory?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "amulet":
                    return Accessory.Amulet;
                case "belt":
                    return Accessory.Belt;
                case "ring":
                    return Accessory.Ring;
            }
            throw new Exception("Cannot unmarshal type Accessory");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Accessory)untypedValue;
            switch (value)
            {
                case Accessory.Amulet:
                    serializer.Serialize(writer, "amulet");
                    return;
                case Accessory.Belt:
                    serializer.Serialize(writer, "belt");
                    return;
                case Accessory.Ring:
                    serializer.Serialize(writer, "ring");
                    return;
            }
            throw new Exception("Cannot marshal type Accessory");
        }

        public static readonly AccessoryConverter Singleton = new AccessoryConverter();
    }

    internal class ArmourConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Armour) || t == typeof(Armour?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "boots":
                    return Armour.Boots;
                case "chest":
                    return Armour.Chest;
                case "gloves":
                    return Armour.Gloves;
                case "helmet":
                    return Armour.Helmet;
                case "quiver":
                    return Armour.Quiver;
                case "shield":
                    return Armour.Shield;
            }
            throw new Exception("Cannot unmarshal type Armour");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Armour)untypedValue;
            switch (value)
            {
                case Armour.Boots:
                    serializer.Serialize(writer, "boots");
                    return;
                case Armour.Chest:
                    serializer.Serialize(writer, "chest");
                    return;
                case Armour.Gloves:
                    serializer.Serialize(writer, "gloves");
                    return;
                case Armour.Helmet:
                    serializer.Serialize(writer, "helmet");
                    return;
                case Armour.Quiver:
                    serializer.Serialize(writer, "quiver");
                    return;
                case Armour.Shield:
                    serializer.Serialize(writer, "shield");
                    return;
            }
            throw new Exception("Cannot marshal type Armour");
        }

        public static readonly ArmourConverter Singleton = new ArmourConverter();
    }

    internal class GemConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Gem) || t == typeof(Gem?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "activegem":
                    return Gem.Activegem;
                case "supportgem":
                    return Gem.Supportgem;
            }
            throw new Exception("Cannot unmarshal type Gem");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Gem)untypedValue;
            switch (value)
            {
                case Gem.Activegem:
                    serializer.Serialize(writer, "activegem");
                    return;
                case Gem.Supportgem:
                    serializer.Serialize(writer, "supportgem");
                    return;
            }
            throw new Exception("Cannot marshal type Gem");
        }

        public static readonly GemConverter Singleton = new GemConverter();
    }

    internal class WeaponConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Weapon) || t == typeof(Weapon?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "bow":
                    return Weapon.Bow;
                case "claw":
                    return Weapon.Claw;
                case "dagger":
                    return Weapon.Dagger;
                case "oneaxe":
                    return Weapon.Oneaxe;
                case "onemace":
                    return Weapon.Onemace;
                case "onesword":
                    return Weapon.Onesword;
                case "sceptre":
                    return Weapon.Sceptre;
                case "staff":
                    return Weapon.Staff;
                case "twoaxe":
                    return Weapon.Twoaxe;
                case "twomace":
                    return Weapon.Twomace;
                case "twosword":
                    return Weapon.Twosword;
                case "wand":
                    return Weapon.Wand;
            }
            throw new Exception("Cannot unmarshal type Weapon");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Weapon)untypedValue;
            switch (value)
            {
                case Weapon.Bow:
                    serializer.Serialize(writer, "bow");
                    return;
                case Weapon.Claw:
                    serializer.Serialize(writer, "claw");
                    return;
                case Weapon.Dagger:
                    serializer.Serialize(writer, "dagger");
                    return;
                case Weapon.Oneaxe:
                    serializer.Serialize(writer, "oneaxe");
                    return;
                case Weapon.Onemace:
                    serializer.Serialize(writer, "onemace");
                    return;
                case Weapon.Onesword:
                    serializer.Serialize(writer, "onesword");
                    return;
                case Weapon.Sceptre:
                    serializer.Serialize(writer, "sceptre");
                    return;
                case Weapon.Staff:
                    serializer.Serialize(writer, "staff");
                    return;
                case Weapon.Twoaxe:
                    serializer.Serialize(writer, "twoaxe");
                    return;
                case Weapon.Twomace:
                    serializer.Serialize(writer, "twomace");
                    return;
                case Weapon.Twosword:
                    serializer.Serialize(writer, "twosword");
                    return;
                case Weapon.Wand:
                    serializer.Serialize(writer, "wand");
                    return;
            }
            throw new Exception("Cannot marshal type Weapon");
        }

        public static readonly WeaponConverter Singleton = new WeaponConverter();
    }

    internal class LeagueConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(League) || t == typeof(League?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Hardcore":
                    return League.Hardcore;
                case "Standard":
                    return League.Standard;
            }
            throw new Exception("Cannot unmarshal type League");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (League)untypedValue;
            switch (value)
            {
                case League.Hardcore:
                    serializer.Serialize(writer, "Hardcore");
                    return;
                case League.Standard:
                    serializer.Serialize(writer, "Standard");
                    return;
            }
            throw new Exception("Cannot marshal type League");
        }

        public static readonly LeagueConverter Singleton = new LeagueConverter();
    }

    internal class ColourConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Colour) || t == typeof(Colour?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "D":
                    return Colour.D;
                case "G":
                    return Colour.G;
                case "I":
                    return Colour.I;
                case "S":
                    return Colour.S;
            }
            throw new Exception("Cannot unmarshal type Colour");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Colour)untypedValue;
            switch (value)
            {
                case Colour.D:
                    serializer.Serialize(writer, "D");
                    return;
                case Colour.G:
                    serializer.Serialize(writer, "G");
                    return;
                case Colour.I:
                    serializer.Serialize(writer, "I");
                    return;
                case Colour.S:
                    serializer.Serialize(writer, "S");
                    return;
            }
            throw new Exception("Cannot marshal type Colour");
        }

        public static readonly ColourConverter Singleton = new ColourConverter();
    }

    internal class SColourConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SColour) || t == typeof(SColour?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "B":
                    return SColour.B;
                case "G":
                    return SColour.G;
                case "R":
                    return SColour.R;
                case "W":
                    return SColour.W;
            }
            throw new Exception("Cannot unmarshal type SColour");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SColour)untypedValue;
            switch (value)
            {
                case SColour.B:
                    serializer.Serialize(writer, "B");
                    return;
                case SColour.G:
                    serializer.Serialize(writer, "G");
                    return;
                case SColour.R:
                    serializer.Serialize(writer, "R");
                    return;
                case SColour.W:
                    serializer.Serialize(writer, "W");
                    return;
            }
            throw new Exception("Cannot marshal type SColour");
        }

        public static readonly SColourConverter Singleton = new SColourConverter();
    }

    internal class StashTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StashType) || t == typeof(StashType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "CurrencyStash":
                    return StashType.CurrencyStash;
                case "NormalStash":
                    return StashType.NormalStash;
                case "PremiumStash":
                    return StashType.PremiumStash;
            }
            throw new Exception("Cannot unmarshal type StashType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StashType)untypedValue;
            switch (value)
            {
                case StashType.CurrencyStash:
                    serializer.Serialize(writer, "CurrencyStash");
                    return;
                case StashType.NormalStash:
                    serializer.Serialize(writer, "NormalStash");
                    return;
                case StashType.PremiumStash:
                    serializer.Serialize(writer, "PremiumStash");
                    return;
            }
            throw new Exception("Cannot marshal type StashType");
        }

        public static readonly StashTypeConverter Singleton = new StashTypeConverter();
    }
}
