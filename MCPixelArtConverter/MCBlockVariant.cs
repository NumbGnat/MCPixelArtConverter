﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCPixelArtConverter
{
    class MCBlockVariant
    {
        MCBlockState blockState;
        String Name { get; }
        List<MCBlockModel> models = new List<MCBlockModel>(); //see bedrock blockstate file
        
        JToken json;
        Dictionary<String, JToken> jsonProperties; //uvlock etc... not good

        /*
        Simple example:
        "normal": { "model": "black_wool" }

        "variants": {
            "normal": [
                //array of models: equal chance of any model
                { "model": "bedrock" },
                { "model": "bedrock_mirrored" },
                { "model": "bedrock", "y": 180 },
                { "model": "bedrock_mirrored", "y": 180 }
            ]
        }
        */
        public MCBlockVariant(MCBlockState blockState, String variantName, JToken value)
        {
            this.blockState = blockState;
            this.Name = variantName;
            json = value;

            switch (value.Type)
            {
                case JTokenType.Object:
                    models.Add(CreateModelFromJson(value));
                    break;
                case JTokenType.Array:
                    foreach (JObject modelObject in (JArray) value)
                    {
                        models.Add(CreateModelFromJson(modelObject));
                    }
                    break;
                default:
                    throw new ArgumentException("Invalid Jtoken type " + value.Type);
            }

        }

        private MCBlockModel CreateModelFromJson(JToken value)
        {
            IDictionary<string, JToken> variantsDict = (JObject)value;
            jsonProperties = variantsDict.ToDictionary(pair => pair.Key, pair => pair.Value);
            String fileName = jsonProperties["model"].ToString();
            return new MCBlockModel(blockState.BaseFolder, fileName);
        }

        public override String ToString()
        {
            return json.ToString();
        }

        public Bitmap getTopView()
        {
            //TODO: handle multiple models
            return models[0].getTopView();
        }
    }
}
