using System;
using System.Text.Json;
using LangtonsAnt;

namespace Json
{
    public static class GameJSONSerializer
    {
        public static string? ToJson(IGame game)
        {
            var serializeOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = {
                    new MultiDimensionalArrayConverter(),
                    //new InterfaceConverterFactory(typeof(GeneralizedAnt), typeof(IAnt)),
                }
            };
            
            return null;
        }

        public static IGame? FromJson(string jsonString)
        {
            IGame? game = null;
            var serializeOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = {
                    new MultiDimensionalArrayConverter(),
                    //new InterfaceConverterFactory(typeof(GeneralizedAnt), typeof(IAnt)),
                }
            };

            return game;
        }
    }
}
