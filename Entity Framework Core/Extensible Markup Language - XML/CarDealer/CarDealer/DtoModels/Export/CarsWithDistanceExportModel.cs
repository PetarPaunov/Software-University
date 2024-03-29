﻿using System.Xml.Serialization;

namespace CarDealer.DtoModels.Export
{
    [XmlType("car")]
    public class CarsWithDistanceExportModel
    {
        [XmlElement("make")]
        public string Make { get; set; }

        [XmlElement("model")]
        public string Model { get; set; }

        [XmlElement("travelled-distance")]
        public long Travelled { get; set; }
    }
}

//< car >
//    < make > BMW </ make >
//    < model > 1M Coupe </ model >
//    < travelled - distance > 39826890 </ travelled - distance >
//  </ car >

