using System;
using System.IO;
using System.Text;

namespace finalremix_generators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TWEWY Final Remix Generator.");
            Console.WriteLine("1. Items");
            Console.WriteLine("2. Pins");

            Console.Write("Select your choice: ");

            switch (Console.ReadLine())
            {
                case "1":
                    GenerateItemData();
                    break;

                case "2":
                    GeneratePinData();
                    break;
            }
        }

        static void GenerateItemData()
        {
            int ClothingId = 9999;
            int FoodId = 19999;
            int TreasureId = 29999;

            Console.WriteLine("Reading clothing files...");

            string[] ClothingData_Name_E = File.ReadAllLines("menu_itemName_E.txt");
            string[] ClothingData_Name_J = File.ReadAllLines("menu_itemName_J.txt");
            string[] ClothingData_Name_FR = File.ReadAllLines("menu_itemName_FR.txt");
            string[] ClothingData_Name_GE = File.ReadAllLines("menu_itemName_GE.txt");
            string[] ClothingData_Name_IT = File.ReadAllLines("menu_itemName_IT.txt");
            string[] ClothingData_Name_SP = File.ReadAllLines("menu_itemName_SP.txt");
            string[] ClothingData_Name_CH_H = File.ReadAllLines("menu_itemName_CH_H.txt");
            string[] ClothingData_Name_CH_K = File.ReadAllLines("menu_itemName_CH_K.txt");

            string[] ClothingData_Info_E = File.ReadAllLines("menu_itemHelp_E.txt");
            string[] ClothingData_Info_J = File.ReadAllLines("menu_itemHelp_J.txt");
            string[] ClothingData_Info_FR = File.ReadAllLines("menu_itemHelp_FR.txt");
            string[] ClothingData_Info_GE = File.ReadAllLines("menu_itemHelp_GE.txt");
            string[] ClothingData_Info_IT = File.ReadAllLines("menu_itemHelp_IT.txt");
            string[] ClothingData_Info_SP = File.ReadAllLines("menu_itemHelp_SP.txt");
            string[] ClothingData_Info_CH_H = File.ReadAllLines("menu_itemHelp_CH_H.txt");
            string[] ClothingData_Info_CH_K = File.ReadAllLines("menu_itemHelp_CH_K.txt");

            Console.WriteLine("Reading food files...");

            string[] FoodData_Name_E = File.ReadAllLines("menu_foodName_E.txt");
            string[] FoodData_Name_J = File.ReadAllLines("menu_foodName_J.txt");
            string[] FoodData_Name_FR = File.ReadAllLines("menu_foodName_FR.txt");
            string[] FoodData_Name_GE = File.ReadAllLines("menu_foodName_GE.txt");
            string[] FoodData_Name_IT = File.ReadAllLines("menu_foodName_IT.txt");
            string[] FoodData_Name_SP = File.ReadAllLines("menu_foodName_SP.txt");
            string[] FoodData_Name_CH_H = File.ReadAllLines("menu_foodName_CH_H.txt");
            string[] FoodData_Name_CH_K = File.ReadAllLines("menu_foodName_CH_K.txt");

            string[] FoodData_Info_E = File.ReadAllLines("menu_foodHelp_E.txt");
            string[] FoodData_Info_J = File.ReadAllLines("menu_foodHelp_J.txt");
            string[] FoodData_Info_FR = File.ReadAllLines("menu_foodHelp_FR.txt");
            string[] FoodData_Info_GE = File.ReadAllLines("menu_foodHelp_GE.txt");
            string[] FoodData_Info_IT = File.ReadAllLines("menu_foodHelp_IT.txt");
            string[] FoodData_Info_SP = File.ReadAllLines("menu_foodHelp_SP.txt");
            string[] FoodData_Info_CH_H = File.ReadAllLines("menu_foodHelp_CH_H.txt");
            string[] FoodData_Info_CH_K = File.ReadAllLines("menu_foodHelp_CH_K.txt");

            Console.WriteLine("Reading treasure files...");

            string[] TreasureData_Name_E = File.ReadAllLines("menu_treasureName_E.txt");
            string[] TreasureData_Name_J = File.ReadAllLines("menu_treasureName_J.txt");
            string[] TreasureData_Name_FR = File.ReadAllLines("menu_treasureName_FR.txt");
            string[] TreasureData_Name_GE = File.ReadAllLines("menu_treasureName_GE.txt");
            string[] TreasureData_Name_IT = File.ReadAllLines("menu_treasureName_IT.txt");
            string[] TreasureData_Name_SP = File.ReadAllLines("menu_treasureName_SP.txt");
            string[] TreasureData_Name_CH_H = File.ReadAllLines("menu_treasureName_CH_H.txt");
            string[] TreasureData_Name_CH_K = File.ReadAllLines("menu_treasureName_CH_K.txt");

            string[] TreasureData_Info_E = File.ReadAllLines("menu_treasureHelp_E.txt");
            string[] TreasureData_Info_J = File.ReadAllLines("menu_treasureHelp_J.txt");
            string[] TreasureData_Info_FR = File.ReadAllLines("menu_treasureHelp_FR.txt");
            string[] TreasureData_Info_GE = File.ReadAllLines("menu_treasureHelp_GE.txt");
            string[] TreasureData_Info_IT = File.ReadAllLines("menu_treasureHelp_IT.txt");
            string[] TreasureData_Info_SP = File.ReadAllLines("menu_treasureHelp_SP.txt");
            string[] TreasureData_Info_CH_H = File.ReadAllLines("menu_treasureHelp_CH_H.txt");
            string[] TreasureData_Info_CH_K = File.ReadAllLines("menu_treasureHelp_CH_K.txt");

            StringBuilder Builder = new StringBuilder();
            Builder.AppendLine("        private readonly Dictionary<ushort, TwewyItem> GameItems = new Dictionary<ushort, TwewyItem>");
            Builder.AppendLine("        {");

            for (int i = 0; i < ClothingData_Name_E.Length; i++)
            {
                ClothingId++;

                Builder.Append("            { ");
                Builder.Append(ClothingId);
                Builder.Append(", ");

                string Constructor = string.Format("new TwewyItem({0}, {1}, \"{2}\", \"{3}\", \"{4}\", \"{5}\", \"{6}\", \"{7}\", \"{8}\", \"{9}\", \"{10}\", \"{11}\", \"{12}\", \"{13}\", \"{14}\", \"{15}\", \"{16}\", \"{17}\", \"{18}\")",
                    ClothingId,
                    i,
                    "",
                    ClothingData_Name_E[i],
                    ClothingData_Name_J[i],
                    ClothingData_Name_SP[i],
                    ClothingData_Name_IT[i],
                    ClothingData_Name_GE[i],
                    ClothingData_Name_FR[i],
                    ClothingData_Name_CH_H[i],
                    ClothingData_Name_CH_K[i],
                    ClothingData_Info_E[i],
                    ClothingData_Info_J[i],
                    ClothingData_Info_SP[i],
                    ClothingData_Info_IT[i],
                    ClothingData_Info_GE[i],
                    ClothingData_Info_FR[i],
                    ClothingData_Info_CH_H[i],
                    ClothingData_Info_CH_K[i]
                    );

                Builder.Append(Constructor);
                Builder.AppendLine(" },");
            }

            for (int i = 0; i < FoodData_Name_E.Length; i++)
            {
                FoodId++;

                Builder.Append("            { ");
                Builder.Append(FoodId);
                Builder.Append(", ");

                string Constructor = string.Format("new TwewyItem({0}, {1}, \"{2}\", \"{3}\", \"{4}\", \"{5}\", \"{6}\", \"{7}\", \"{8}\", \"{9}\", \"{10}\", \"{11}\", \"{12}\", \"{13}\", \"{14}\", \"{15}\", \"{16}\", \"{17}\", \"{18}\")",
                    FoodId,
                    i,
                    "",
                    FoodData_Name_E[i],
                    FoodData_Name_J[i],
                    FoodData_Name_SP[i],
                    FoodData_Name_IT[i],
                    FoodData_Name_GE[i],
                    FoodData_Name_FR[i],
                    FoodData_Name_CH_H[i],
                    FoodData_Name_CH_K[i],
                    FoodData_Info_E[i],
                    FoodData_Info_J[i],
                    FoodData_Info_SP[i],
                    FoodData_Info_IT[i],
                    FoodData_Info_GE[i],
                    FoodData_Info_FR[i],
                    FoodData_Info_CH_H[i],
                    FoodData_Info_CH_K[i]
                    );

                Builder.Append(Constructor);
                Builder.AppendLine(" },");
            }

            for (int i = 0; i < TreasureData_Name_E.Length; i++)
            {
                TreasureId++;

                Builder.Append("            { ");
                Builder.Append(TreasureId);
                Builder.Append(", ");

                string Constructor = string.Format("new TwewyItem({0}, {1}, \"{2}\", \"{3}\", \"{4}\", \"{5}\", \"{6}\", \"{7}\", \"{8}\", \"{9}\", \"{10}\", \"{11}\", \"{12}\", \"{13}\", \"{14}\", \"{15}\", \"{16}\", \"{17}\", \"{18}\")",
                    TreasureId,
                    i,
                    "",
                    TreasureData_Name_E[i],
                    TreasureData_Name_J[i],
                    TreasureData_Name_SP[i],
                    TreasureData_Name_IT[i],
                    TreasureData_Name_GE[i],
                    TreasureData_Name_FR[i],
                    TreasureData_Name_CH_H[i],
                    TreasureData_Name_CH_K[i],
                    TreasureData_Info_E[i],
                    TreasureData_Info_J[i],
                    TreasureData_Info_SP[i],
                    TreasureData_Info_IT[i],
                    TreasureData_Info_GE[i],
                    TreasureData_Info_FR[i],
                    TreasureData_Info_CH_H[i],
                    TreasureData_Info_CH_K[i]
                    );

                Builder.Append(Constructor);
                Builder.AppendLine(" },");
            }

            Builder.AppendLine("        };");
            File.WriteAllText("output_dictionary_items.cs", Builder.ToString());
        }

        static void GeneratePinData()
        {
            Console.WriteLine("Reading pin files...");

            string[] PinData_Name_E = File.ReadAllLines("menu_bdgName_E.txt");
            string[] PinData_Name_J = File.ReadAllLines("menu_bdgName_J.txt");
            string[] PinData_Name_FR = File.ReadAllLines("menu_bdgName_FR.txt");
            string[] PinData_Name_GE = File.ReadAllLines("menu_bdgName_GE.txt");
            string[] PinData_Name_IT = File.ReadAllLines("menu_bdgName_IT.txt");
            string[] PinData_Name_SP = File.ReadAllLines("menu_bdgName_SP.txt");
            string[] PinData_Name_CH_H = File.ReadAllLines("menu_bdgName_CH_H.txt");
            string[] PinData_Name_CH_K = File.ReadAllLines("menu_bdgName_CH_K.txt");

            string[] PinData_Info_E = File.ReadAllLines("menu_bdgHelp1_E.txt");
            string[] PinData_Info_J = File.ReadAllLines("menu_bdgHelp1_J.txt");
            string[] PinData_Info_FR = File.ReadAllLines("menu_bdgHelp1_FR.txt");
            string[] PinData_Info_GE = File.ReadAllLines("menu_bdgHelp1_GE.txt");
            string[] PinData_Info_IT = File.ReadAllLines("menu_bdgHelp1_IT.txt");
            string[] PinData_Info_SP = File.ReadAllLines("menu_bdgHelp1_SP.txt");
            string[] PinData_Info_CH_H = File.ReadAllLines("menu_bdgHelp1_CH_H.txt");
            string[] PinData_Info_CH_K = File.ReadAllLines("menu_bdgHelp1_CH_K.txt");

            StringBuilder Builder = new StringBuilder();
            Builder.AppendLine("        private readonly Dictionary<ushort, TwewyPin> Pins = new Dictionary<ushort, TwewyPin>");
            Builder.AppendLine("        {");

            for (int i = 0; i < PinData_Name_E.Length; i++)
            {
                Builder.Append("            { ");
                Builder.Append(i);
                Builder.Append(", ");

                string Constructor = string.Format("new TwewyPin({0}, {1} \"{2}\", \"{3}\", \"{4}\", \"{5}\", \"{6}\", \"{7}\", \"{8}\", \"{9}\", \"{10}\", \"{11}\", \"{12}\", \"{13}\", \"{14}\", \"{15}\", \"{16}\", \"{17}\", \"{18}\")",
                    i,
                    string.Empty,
                    "badge_" + (i + 1).ToString("D3"),
                    PinData_Name_E[i],
                    PinData_Name_J[i],
                    PinData_Name_SP[i],
                    PinData_Name_IT[i],
                    PinData_Name_GE[i],
                    PinData_Name_FR[i],
                    PinData_Name_CH_H[i],
                    PinData_Name_CH_K[i],
                    PinData_Info_E[i],
                    PinData_Info_J[i],
                    PinData_Info_SP[i],
                    PinData_Info_IT[i],
                    PinData_Info_GE[i],
                    PinData_Info_FR[i],
                    PinData_Info_CH_H[i],
                    PinData_Info_CH_K[i]
                    );

                Builder.Append(Constructor);
                Builder.AppendLine(" },");
            }

            Builder.AppendLine("        };");
            File.WriteAllText("output_dictionary_pins.cs", Builder.ToString());
        }
    }
}
