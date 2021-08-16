namespace FinalRemixDb
{
    public class TwewyItem
    {
        public ushort Id { get; set; }
        public ushort Index { get; set; }
        public string Sprite { get; set; }
        public string Name_English { get; set; }
        public string Name_Japanese { get; set; }
        public string Name_Spanish { get; set; }
        public string Name_Italian { get; set; }
        public string Name_German { get; set; }
        public string Name_French { get; set; }
        public string Name_Chinese_Traditional { get; set; }
        public string Name_Chinese_Simplified { get; set; }
        public string Description_English { get; set; }
        public string Description_Japanese { get; set; }
        public string Description_Spanish { get; set; }
        public string Description_Italian { get; set; }
        public string Description_German { get; set; }
        public string Description_French { get; set; }
        public string Description_Chinese_Traditional { get; set; }
        public string Description_Chinese_Simplified { get; set; }

        public byte Type
        {
            get
            {
                if (Id < 20000)
                {
                    return 1; // clothing
                }
                else if (Id > 19999 && Id < 30000)
                {
                    return 2; // food
                }
                else if (Id > 29999)
                {
                    return 3; // treasure a.k.a. "Swag"
                }

                return 0;
            }
        }

        public TwewyItem(ushort id, ushort index, string sprite, string name_English, string name_Japanese, string name_Spanish, string name_Italian, string name_German, string name_French, string name_Chinese_Traditional, string name_Chinese_Simplified, string description_English, string description_Japanese, string description_Spanish, string description_Italian, string description_German, string description_French, string description_Chinese_Traditional, string description_Chinese_Simplified)
        {
            Id = id;
            Index = index;
            Sprite = sprite;
            Name_English = name_English;
            Name_Japanese = name_Japanese;
            Name_Spanish = name_Spanish;
            Name_Italian = name_Italian;
            Name_German = name_German;
            Name_French = name_French;
            Name_Chinese_Traditional = name_Chinese_Traditional;
            Name_Chinese_Simplified = name_Chinese_Simplified;
            Description_English = description_English;
            Description_Japanese = description_Japanese;
            Description_Spanish = description_Spanish;
            Description_Italian = description_Italian;
            Description_German = description_German;
            Description_French = description_French;
            Description_Chinese_Traditional = description_Chinese_Traditional;
            Description_Chinese_Simplified = description_Chinese_Simplified;
        }

        public string GetName(byte LanguageId)
        {
            switch (LanguageId)
            {
                case 0:
                default:
                    return Name_English;

                case 1:
                    return Name_Japanese;

                case 2:
                    return Name_Spanish;

                case 3:
                    return Name_French;

                case 4:
                    return Name_German;

                case 5:
                    return Name_Italian;

                case 6:
                    return Name_Chinese_Traditional;

                case 7:
                    return Name_Chinese_Simplified;
            }
        }

        public string GetDescription(byte LanguageId)
        {
            switch (LanguageId)
            {
                case 0:
                default:
                    return Description_English;

                case 1:
                    return Description_Japanese;

                case 2:
                    return Description_Spanish;

                case 3:
                    return Description_French;

                case 4:
                    return Description_German;

                case 5:
                    return Description_Italian;

                case 6:
                    return Description_Chinese_Traditional;

                case 7:
                    return Description_Chinese_Simplified;
            }
        }
    }
}
